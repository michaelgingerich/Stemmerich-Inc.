using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Net.Mail;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace RawMaterialsThresholdNotifier
{
    public partial class rawMaterialsThresholdNotifier : Form
    {
        String savedEmailsFileName = "SavedEmails.bin";
        String savedRawMaterialsFileName = "SavedRawMaterials.bin";
        String savedNotificationFrequencyFileName = "SavedNotificationFrequency.bin";
        Boolean formLoading;
        MailSettingsSectionGroup unencryptedMailSettingsGroup;
        List<int> itemIDList;
        List<Decimal> minThresholdList;
        List<Decimal> maxThresholdList;
        String notification;
        Boolean thresholdsReached;
        static System.Windows.Forms.Timer rawMaterialsThresholdNotificationTimer;
        int notificationFrequency;
        String inventoryDBConnectionString;

        public rawMaterialsThresholdNotifier()
        {
            InitializeComponent();
        }

        private void rawMaterialsThresholdNotifier_Load(object sender, EventArgs e)
        {
            getConfiguration();
            loadEmailAddressList();
            loadRawMaterialList();
            loadNotificationFrequency();
        }

        void getConfiguration()
        {
            try
            {
                //Get the configuration file.
                Configuration config = ConfigurationManager.OpenExeConfiguration("RawMaterialsThresholdNotifier.exe");

                //Get the connection strings and mail settings sections.
                ConnectionStringsSection configConnectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                ConfigurationSection configMailSettingsSection = config.GetSection("system.net/mailSettings/smtp");

                //Check if the connection strings section is encrypted.
                if (configConnectionStringsSection.SectionInformation.IsProtected)
                {
                    //Remove the encryption.
                    configConnectionStringsSection.SectionInformation.UnprotectSection();
                    //Get the unencrypted connection strings section.
                    ConnectionStringsSection unencryptedConnectionStringsSection = config.ConnectionStrings;
                    //Get the unencrypted connection string.
                    ConnectionStringSettings unencryptedConnectionStringSettings = unencryptedConnectionStringsSection.ConnectionStrings["RawMaterialsThresholdNotifier.Properties.Settings.InventoryDBConnection"];
                    //Read the unencrypted connection string into a class level String.
                    inventoryDBConnectionString = unencryptedConnectionStringSettings.ConnectionString;
                    //Encrypt the connection strings section.
                    //unencryptedConnectionStringsSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
                else
                {
                    ConnectionStringsSection unencryptedConnectionStringsSection = config.ConnectionStrings;
                    ConnectionStringSettings unencryptedConnectionStringSettings = unencryptedConnectionStringsSection.ConnectionStrings["RawMaterialsThresholdNotifier.Properties.Settings.InventoryDBConnection"];
                    //unencryptedConnectionStringsSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }

                //Check if the mail settings section is encrypted.
                if (configMailSettingsSection.SectionInformation.IsProtected)
                {
                    //Remove the encryption.
                    configMailSettingsSection.SectionInformation.UnprotectSection();
                    //Read the unencrypted mail settings group into a class level file of type MailSettingsSectionGroup.
                    unencryptedMailSettingsGroup = (MailSettingsSectionGroup)config.GetSectionGroup("system.net/mailSettings");
                    //Encrypt the mail settings section.
                    //configMailSettingsSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
                else
                {
                    unencryptedMailSettingsGroup = (MailSettingsSectionGroup)config.GetSectionGroup("system.net/mailSettings");
                    //configMailSettingsSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
                //Save the configuration file.
                config.Save();
            }
            //Because the type of encryption used is not friendly to moving the exe.config file from one computer to another, the exception calls a help file that will serve to mitigate the issue.
            catch (Exception ex)
            {
                MessageBox.Show("The connection configuration file, RawMaterialsThresholdNotifier.exe.config either does not exist, or it was copied from another computer and cannot be decrypted.  Please consult the \"The Connection Configuration File\" unencryptedConnectionStringsSection of the help file.", "RawMaterialsThresholdNotifier.exe.config");
                Help.ShowHelp(null, "RMTN_Help.chm", HelpNavigator.TopicId, "5");
            }
        }

        //Deserialize the list of raw materials and selection states from SavedRawMaterials.bin.
        void loadRawMaterialList()
        {
            if (File.Exists(savedRawMaterialsFileName))
            {
                Stream FileStream = File.OpenRead(savedRawMaterialsFileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                RawMaterial.rawMaterialList = (List<RawMaterial>)deserializer.Deserialize(FileStream);
                FileStream.Close();
            }
        }

        //Deserialize the notificationFrequency from SavedNotificationFrequency.bin.
        void loadNotificationFrequency()
        {
            if (File.Exists(savedNotificationFrequencyFileName))
            {
                Stream FileStream = File.OpenRead(savedNotificationFrequencyFileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                notificationFrequency = (int)deserializer.Deserialize(FileStream);
                FileStream.Close();

                //Discourage the frequencyInputBox_ValueChanged handler from executing due to state change.
                formLoading = true;
                frequencyInputBox.Value = notificationFrequency;
                formLoading = false;
            }
            else
            {
                notificationFrequency = (int)frequencyInputBox.Value;
            }
            //Initialize the timer that will monitor the inventory database and send e-mail notifications.
            rawMaterialsThresholdNotificationTimer = new System.Windows.Forms.Timer();
            rawMaterialsThresholdNotificationTimer.Interval = (notificationFrequency * 60000);
            rawMaterialsThresholdNotificationTimer.Tick += new EventHandler(rawMaterialsThresholdNotificationTimer_Elapsed);
            rawMaterialsThresholdNotificationTimer.Start();
        }

        //Deserialize the list of e-mail addresses and selected states from SavedEmails.bin.
        void loadEmailAddressList()
        {
            if (File.Exists(savedEmailsFileName))
            {
                Stream FileStream = File.OpenRead(savedEmailsFileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                EmailAddress.emailAddressList = (List<EmailAddress>)deserializer.Deserialize(FileStream);
                FileStream.Close();
            }
            //Discourage the emailAddressesCheckedListBox_ItemCheck handler from executing due to state change.
            formLoading = true;
            //Add email addresses and selection states back to the e-mail selection box.
            foreach (EmailAddress emailAddressListElement in EmailAddress.emailAddressList)
            {
                emailAddressesCheckedListBox.Items.Add(emailAddressListElement.getEmailAddress(), emailAddressListElement.getEmailAddressIsChecked());
            }
            formLoading = false;
        }

        //Serialize the notification frequency to SavedNotificationFrequency.bin.
        void saveNotificationFrequency()
        {
            Stream FileStream = File.Create(savedNotificationFrequencyFileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(FileStream, notificationFrequency);
            FileStream.Close();
        }

        //Serialize the list of email addresses and checked states to SavedEmails.bin.
        void saveEmailAddressList()
        {
            Stream FileStream = File.Create(savedEmailsFileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(FileStream, EmailAddress.emailAddressList);
            FileStream.Close();
        }

        //Monitor the inventory database and send email notifications.
        void rawMaterialsThresholdNotificationTimer_Elapsed(object sender, EventArgs e)
        {
            calculateThresholds();
            checkInventoryLevels();
            sendReport();
        }

        //Detect state change.
        private void frequencyInputBox_ValueChanged(object sender, EventArgs e)
        {
            //Discourage handler execution during deserialization and reinitialization.
            if (formLoading == true)
            {
                return;
            }
            notificationFrequency = (int)frequencyInputBox.Value;
            //Initialize the timer to the newly set frequency by which it will monitor the inventory database and send email notifications.
            rawMaterialsThresholdNotificationTimer = new System.Windows.Forms.Timer();
            rawMaterialsThresholdNotificationTimer.Interval = (notificationFrequency * 60000);
            rawMaterialsThresholdNotificationTimer.Tick += new EventHandler(rawMaterialsThresholdNotificationTimer_Elapsed);
            rawMaterialsThresholdNotificationTimer.Start();
            saveNotificationFrequency();
        }

        //Open the RawMaterialsSelection form.
        private void itemToggleButton_Click(object sender, EventArgs e)
        {
            RawMaterialsSelection rawMaterialsSelectionInstance = new RawMaterialsSelection();
            rawMaterialsSelectionInstance.Show();
        }

        //Manually cue a monitoring operation and open the RawMaterialsThresholdReport form.
        private void viewReportButton_Click(object sender, EventArgs e)
        {
            calculateThresholds();
            checkInventoryLevels();
            if (thresholdsReached)
            {
                RawMaterialsThresholdReport rawMaterialsThresholdReportInstance = new RawMaterialsThresholdReport(notification);
                rawMaterialsThresholdReportInstance.Show();
            }
            else
            {
                MessageBox.Show("No thresholds have been reached.", "No Thresholds Reached");
            }
        }

        public bool validateEmailAddress(String emailAddress)
        {
            // Confirm that the e-mail address string is not empty. 
            if (emailAddress.Length == 0)
            {
                //errorMessage = "EmailAddress address is required.";
                return false;
            }

            // Confirm that the emailAddress address does not contain spaces or begin with @.
            if ((emailAddress.Contains(" ")) || (emailAddress[0] == '@'))
            {
                //errorMessage = "EmailAddress address cannot contain spaces.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    //errorMessage = "";
                    return true;
                }
            }

            //errorMessage = "EmailAddress address must be a valid emailAddress address format.\n" +
               //"For example 'someone@example.com' ";
            return false;
        }

        private void addEmail_Click(object sender, EventArgs e)
        {
            String emailAddress = Interaction.InputBox("Enter an e-mail address:", "Add E-mail Address");

            while (!validateEmailAddress(emailAddress))
            {
                if (emailAddress.Length == 0) break;
                MessageBox.Show("E-mail must be entered in the format name@company.com.");
                emailAddress = Interaction.InputBox("Enter an e-mail address:", "Add e-mail Address");
            }
            if (emailAddress.Length > 0)
            {
                //Add e-mail address and selection state to the list of e-mails.
                emailAddressesCheckedListBox.Items.Add(emailAddress);
                EmailAddress.emailAddressList.Add(new EmailAddress(emailAddress, false));
                //Serialize the list.
                saveEmailAddressList();
            }
        }

        private void editEmailButton_Click(object sender, EventArgs e)
        {
            String emailAddress = Interaction.InputBox("Enter a new e-mail address:", "Edit E-mail Address");

            while (!validateEmailAddress(emailAddress))
            {
                if (emailAddress.Length == 0) break;
                MessageBox.Show("EmailAddress must be entered in the format name@company.com.");
                emailAddress = Interaction.InputBox("Enter a new e-mail address:", "Edit E-mail Address");
            }
            int index = emailAddressesCheckedListBox.SelectedIndex;
            if (index > -1 && emailAddress.Length != 0)
            {
                //Save old e-mail address so that it can be removed from the list of e-mails.
                String oldEmailAddress = emailAddressesCheckedListBox.Items[index].ToString();
                //Remove the e-mail address from the box.
                emailAddressesCheckedListBox.Items.RemoveAt(index);
                //Add the new e-mail address to the box.
                emailAddressesCheckedListBox.Items.Insert(index, emailAddress);
                foreach(EmailAddress emailAddressListElement in EmailAddress.emailAddressList)
                {
                    //Find the old e-mail address in the list of e-mails and replace it.
                    if (emailAddressListElement.getEmailAddress().Equals(oldEmailAddress))
                    {
                        emailAddressListElement.setEmailAddress(emailAddress);
                    }
                }
                //Serialize the list of e-mail addresses.
                saveEmailAddressList();
            }
        }

        private void deleteEmailButton_Click(object sender, EventArgs e)
        {
            if (emailAddressesCheckedListBox.SelectedIndex > -1)
            {
                int index = emailAddressesCheckedListBox.SelectedIndex;
                String selectedEmailAddress = emailAddressesCheckedListBox.Items[index].ToString();
                //Remove e-mail address from the box.
                emailAddressesCheckedListBox.Items.RemoveAt(index);
                //Find the deleted e-mail in the list of emails and remove it and its selected state.
                foreach (EmailAddress emailAddressListElement in EmailAddress.emailAddressList)
                {
                    if (emailAddressListElement.getEmailAddress().Equals(selectedEmailAddress))
                    {
                        EmailAddress.emailAddressList.Remove(emailAddressListElement);
                        break;
                    }
                }
                //Serialize the list of e-mails.
                saveEmailAddressList();
            }
        }

        //Detect state change.
        private void emailAddressesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Discourage handler execution during deserialization and reinitialization.
            if(formLoading == true)
            {
                return;
            }
            int index = emailAddressesCheckedListBox.SelectedIndex;
            String selectedEmailAddress = emailAddressesCheckedListBox.Items[index].ToString();
            //Find selected e-mail address in the list.
            foreach (EmailAddress emailAddressListElement in EmailAddress.emailAddressList)
            {
                if (emailAddressListElement.getEmailAddress().Equals(selectedEmailAddress))
                {
                    //Change the selected state in the list.
                    if (e.NewValue == CheckState.Checked)
                    {
                        emailAddressListElement.setEmailAddressIsChecked(true);
                    }
                    else if (e.NewValue == CheckState.Unchecked)
                    {
                        emailAddressListElement.setEmailAddressIsChecked(false);
                    }
                }
            }
            //Serialize the list of e-mail addresses.
            saveEmailAddressList();
        }

        //Queries the inventory database for all sales transactions.  
        void calculateThresholds()
        {
            try
            {
                //Ensure the datatable is refreshed from the database.
                this.invTrans2TableAdapter.Fill(this.inventoryDatabase.invTrans2DataTable);
            }
            //Show help in the event that the data source has not been created on the local computer.
            catch (Exception ex)
            {
                MessageBox.Show("The Open Database Connectivity data source \"InventoryDataSource\" does not exist.  Please consult the \"Inventory Database Connectivity\" section of the help file.", "InventoryDataSource Does Not Exist");
                Help.ShowHelp(null, "RMTN_Help.chm", HelpNavigator.TopicId, "5");
            }
            //Get today's date from a year ago to calculate numberSold.
            DateTime oneYearAgo = (DateTime.Now).AddYears(-1);
            itemIDList = new List<int>();
            minThresholdList = new List<Decimal>();
            maxThresholdList = new List<Decimal>();

            foreach(RawMaterial rawMaterialListElement in RawMaterial.rawMaterialList)
            {
                int rawMaterialListElementItemID = rawMaterialListElement.getItemID();
                Decimal numberSold = 0;
                //Prepare to find itemID's in the datatable that correspond to the itemID's saved in the RawMaterialsSelection form.
                foreach (DataRow invTrans2DataTableRow in inventoryDatabase.invTrans2DataTable.Rows)
                {
                    foreach (DataColumn invTrans2DataTableColumn in inventoryDatabase.invTrans2DataTable.Columns)
                    {
                        //Ensure transaction date is not null.
                        //Ensure the date exists within the last year.
                        //Ensure the column name is "ItemID".
                        //Ensure the current cell is not null.
                        //Ensure the Qty for this datatable row is not null.
                        if (invTrans2DataTableRow.ItemArray[1] != null && DateTime.Compare(oneYearAgo, (DateTime)invTrans2DataTableRow.ItemArray[1]) < 0 && invTrans2DataTableColumn.ColumnName.Equals("ItemID") && 
                            invTrans2DataTableRow[invTrans2DataTableColumn] != null && invTrans2DataTableRow.ItemArray[4] != null)
                        {
                            int itemID = int.Parse(invTrans2DataTableRow[invTrans2DataTableColumn].ToString());
                            //Check if the itemID for this datatable row exists in the list saved in the RawMaterialsSelection form.
                            if (itemID == rawMaterialListElementItemID)
                            {
                                //Aggregate numberSold for each instance of this itemID.
                                numberSold += Decimal.Parse(invTrans2DataTableRow.ItemArray[4].ToString());
                            }
                        }
                    }
                }
                //Save this itemID with its newly calculated thresholds.
                itemIDList.Add(rawMaterialListElementItemID);
                numberSold *= -1;
                minThresholdList.Add(numberSold / 8);
                maxThresholdList.Add(numberSold / 4);
            }
        }

        //Queries the inventory database for the amount in stock for each itemID
        void checkInventoryLevels()
        {
            try
            {
                //Ensure the datatable is refreshed from the database.
                this.rawMaterialsThresholdNotifierDataTableTableAdapter.Fill(this.inventoryDatabase.rawMaterialsThresholdNotifierDataTable);
            }
            //Show help in the event that the data source has not been created on the local computer.
            catch (Exception ex)
            {
                MessageBox.Show("The Open Database Connectivity data source \"InventoryDataSource\" does not exist.  Please consult the \"Inventory Database Connectivity\" section of the help file.", "InventoryDataSource Does Not Exist");
                Help.ShowHelp(null, "RMTN_Help.chm", HelpNavigator.TopicId, "5");
            }

            notification = "";
            
            if (thresholdsReached)
            {
                thresholdsReached = false;
            }
            
            //Check only for itemID's in the list.
            foreach(int itemIDListElement in itemIDList)
            {
                foreach (DataRow rawMaterialsThresholdNotifierDataTableRow in inventoryDatabase.rawMaterialsThresholdNotifierDataTable.Rows)
                {
                    foreach (DataColumn rawMaterialsThresholdNotifierDataTableColumn in inventoryDatabase.rawMaterialsThresholdNotifierDataTable.Columns)
                    {
                        //Ensure the name of the column is "ItemID".
                        if (rawMaterialsThresholdNotifierDataTableColumn.ColumnName.Equals("ItemID"))
                        {
                            int itemID = int.Parse(rawMaterialsThresholdNotifierDataTableRow[rawMaterialsThresholdNotifierDataTableColumn].ToString());
                            //Check that the itemID exists in the list.
                            if (itemID == itemIDListElement)
                            {
                                int index = itemIDList.IndexOf(itemIDListElement);
                                //Get the amount in stock for this itemID.
                                Decimal total = Decimal.Parse(rawMaterialsThresholdNotifierDataTableRow.ItemArray[4].ToString());
                                //Check if it meets a threshold condition.
                                if (total <= minThresholdList[index])
                                {
                                    if (thresholdsReached == false)
                                    {
                                        thresholdsReached = true;
                                    }
                                    //Set the indicator label.
                                    statusOutputLabel.Text = "Threshold(s) reached.";
                                    //Concatenate the notification String.
                                    notification = notification + "Minimum threshold reached: " + itemID.ToString() + "    |    " + rawMaterialsThresholdNotifierDataTableRow.ItemArray[1].ToString() + "    |    " +
                                        rawMaterialsThresholdNotifierDataTableRow.ItemArray[2].ToString() + "    |    " + Decimal.Parse(rawMaterialsThresholdNotifierDataTableRow.ItemArray[4].ToString()).ToString("N2") + Environment.NewLine;
                                }
                                else if (total >= maxThresholdList[index])
                                {
                                    if (thresholdsReached == false)
                                    {
                                        thresholdsReached = true;
                                    }
                                    statusOutputLabel.Text = "Threshold(s) reached.";
                                    notification = notification + "Maximum threshold reached: " + itemID.ToString() + "    |    " + rawMaterialsThresholdNotifierDataTableRow.ItemArray[1].ToString() + "    |    " +
                                        rawMaterialsThresholdNotifierDataTableRow.ItemArray[2].ToString() + "    |    " + Decimal.Parse(rawMaterialsThresholdNotifierDataTableRow.ItemArray[4].ToString()).ToString("N2") + Environment.NewLine;
                                }
                                else
                                {
                                    statusOutputLabel.Text = "No thresholds reached.";
                                }
                            }
                        }
                    }
                }
            }
        }

        //Send the notification via e-mail.
        void sendReport()
        {
            if(thresholdsReached)
            {
                MailMessage message = new MailMessage();
                //Add e-mails in the list of e-mails that were selected in the box to the MailMessage.To property.
                foreach (EmailAddress emailAddressListElement in EmailAddress.emailAddressList)
                {
                    if (emailAddressListElement.getEmailAddressIsChecked())
                    {
                        message.To.Add(emailAddressListElement.getEmailAddress());
                    }
                }
                //Add the from address that was unencrypted from the configuration file.
                message.From = new MailAddress(unencryptedMailSettingsGroup.Smtp.From);
                message.Subject = "Inventory Threshold(s) Reached";
                message.Body = notification;
                SmtpClient client = new SmtpClient();
                //Add connection information that was unencrypted from the configuration file.
                client.Host = unencryptedMailSettingsGroup.Smtp.Network.Host;
                client.Port = unencryptedMailSettingsGroup.Smtp.Network.Port;
                //Add credential information that was unencrypted from the configuration file.
                client.Credentials = new System.Net.NetworkCredential(unencryptedMailSettingsGroup.Smtp.Network.UserName, unencryptedMailSettingsGroup.Smtp.Network.Password);
                client.EnableSsl = true;
                try
                {
                    client.Send(message);
                }
                //Show error message if there is no internet connection.
                catch (Exception ex)
                {
                    MessageBox.Show("There has been an issue sending the notification e-mail, because there is no internet connection.", "Internet Connection");
                }
                
            }
        }

        //Handle the help button clicked event and open the index in the help file corresponding to this form.
        private void rawMaterialsThresholdNotifier_HelpButtonClicked(Object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Help.ShowHelp(null, "RMTN_Help.chm", HelpNavigator.TopicId, "1");
        }
    }
}
