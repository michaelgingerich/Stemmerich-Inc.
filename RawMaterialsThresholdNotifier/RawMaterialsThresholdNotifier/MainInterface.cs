using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawMaterialsThresholdNotifier{
    public partial class MainInterface : Form    {
        public MainInterface(){
            InitializeComponent();
        }

        void checkRawMaterialsInventoryLevels()
        {
            foreach (DataRow row in inventoryDatabase.dbo_MstItem.Rows)
            {
                foreach (DataColumn column in inventoryDatabase.dbo_MstItem.Columns)
                {
                    
                }
            }
        }

        //private void notificationEmailInputTextBox_Validating(object sender, CancelEventArgs e)
        //{
        //    string errorMsg;
        //    if (!ValidEmailAddress(notificationEmailInputTextBox.Text, out errorMsg))
        //    {
        //        e.Cancel = true;
        //        notificationEmailInputTextBox.Select(0, notificationEmailInputTextBox.Text.Length);
        //        this.emailError.SetError(notificationEmailInputTextBox, errorMsg);
        //    }
        //}
        
        //private void notificationEmailInputTextBox_Validated(object sender, EventArgs e)
        //{
        //    emailError.SetError(notificationEmailInputTextBox, "");
        //}

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the e-mail address string is not empty. 
            if (emailAddress.Length == 0)
            {
                errorMessage = "Email address is required.";
                return false;
            }

            // Confirm that the email address does not contain spaces.
            if (emailAddress.Contains(" "))
            {
                errorMessage = "Email address cannot contain spaces.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "Email address must be a valid email address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }

        private void saveEmail_Click(object sender, EventArgs e)
        {

        }

        private void rawMaterialsThresholdNotifier_HelpButtonClicked(Object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Help.ShowHelp(null, "OITM_Help.chm", HelpNavigator.TopicId, "2");
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDatabase.dbo_MstItem' table. You can move, or remove it, as needed.
            this.dbo_MstItemTableAdapter.Fill(this.inventoryDatabase.dbo_MstItem);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkRawMaterialsInventoryLevels();
        }
    }
}
