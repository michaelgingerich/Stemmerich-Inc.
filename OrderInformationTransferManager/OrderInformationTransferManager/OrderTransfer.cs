using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace OrderInformationTransferManager
{
    public partial class OrderTransfer : Form
    {
        OrderTransfer orderTransferInstance;
        TreeNode productsTreeNode;
        String orderNumber;
        String inventoryDBConnectionString;
        Boolean orderTransferred;

        public OrderTransfer()
        {
            InitializeComponent();
        }

        private void OrderTransfer_Load(object sender, EventArgs e)
        {
            getConnectionStrings();
        }

        void getConnectionStrings()
        {
            try
            {
                //Get the configuration file.
                Configuration config = ConfigurationManager.OpenExeConfiguration("OrderInformationTransferManager.exe");

                //Get the connection strings section.
                ConnectionStringsSection section = (ConnectionStringsSection)config.GetSection("connectionStrings");

                //Check if the connection strings section is encrypted.
                if (section.SectionInformation.IsProtected)
                {
                    // Remove the encryption.
                    section.SectionInformation.UnprotectSection();
                    //Get the unencrypted connection strings section.
                    ConnectionStringsSection csSection = config.ConnectionStrings;
                    //Get the unencrypted connection string.
                    ConnectionStringSettings cs = csSection.ConnectionStrings["OrderInformationTransferManager.Properties.Settings.InventoryDBConnectionString"];
                    //Read the unencrypted connection String into a class level String.
                    inventoryDBConnectionString = cs.ConnectionString;
                    //Encrypt the connection strings section.
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
                else
                {
                    ConnectionStringsSection csSection = config.ConnectionStrings;
                    ConnectionStringSettings cs = csSection.ConnectionStrings["OrderInformationTransferManager.Properties.Settings.InventoryDBConnectionString"];
                    inventoryDBConnectionString = cs.ConnectionString;
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
                //Save the configuration file.
                config.Save();
            }
            //Because the type of encryption used is not friendly to moving the exe.config file from one computer to another, the exception calls a help file that will serve to mitigate the issue.
            catch (Exception ex)
            {
                MessageBox.Show("The connection configuration file, OrderInformationTransferManager.exe.config either does not exist, or it was copied from another computer and cannot be decrypted.  Please consult the \"The Connection Configuration File\" section of the help file.", "OrderInformationTransferManager.exe.config");
                Help.ShowHelp(null, "OITM_Help.chm", HelpNavigator.TopicId, "6");
            }
        }

        //Queries the inventory database for customerID's and names.
        void populateCustomerNameComboBox()
        {
            try
            {
                this.customerID_NameDataTableTableAdapter.Fill(this.inventoryDatabase.customerID_NameDataTable);
            }
            //Opens the data source section of the help file if the data source has not been created.
            catch (Exception ex)
            {
                MessageBox.Show("The Open Database Connectivity data source \"InventoryDataSource\" does not exist.  Please consult the \"Inventory Database Connectivity\" section of the help file.", "InventoryDataSource Does Not Exist");
                Help.ShowHelp(null, "OITM_Help.chm", HelpNavigator.TopicId, "5");
            }
            customerNameComboBox.Items.Clear();
            foreach (DataRow customerID_NameDataTableRow in inventoryDatabase.customerID_NameDataTable.Rows)
            {
                foreach (DataColumn customerID_NameDataTableColumn in inventoryDatabase.customerID_NameDataTable.Columns)
                {
                    if (customerID_NameDataTableColumn.ColumnName.Equals("COMPANY"))
                    {
                        //Writes customer names to the customer name box.
                        customerNameComboBox.Items.Add(customerID_NameDataTableRow[customerID_NameDataTableColumn].ToString());
                    }
                }
            }
        }

        //Queries the accounting database for order numbers.
        void getOrderNumber()
        {
            try
            {
                this.orderNumberDataTableTableAdapter.Fill(this.accountingDatabase.orderNumberDataTable);
            }
            //Opens the data source section of the help file if the data source has not been created.
            catch (Exception ex)
            {
                MessageBox.Show("The Open Database Connectivity data source \"AccountingDataSource\" does not exist.  Please consult the \"Accounting Database Connectivity\" section of the help file.", "AccountingDataSource Does Not Exist");
                Help.ShowHelp(null, "OITM_Help.chm", HelpNavigator.TopicId, "4");
            }
            //Ensure that a maximum will be found.
            int postOrder = int.MinValue;
            foreach (DataRow orderNumberDataTableRow in accountingDatabase.orderNumberDataTable.Rows)
            {
                int postOrderValue = orderNumberDataTableRow.Field<int>("PostOrder");
                postOrder = Math.Max(postOrder, postOrderValue);
            }
            
            foreach (DataRow orderNumberDataTableRow in accountingDatabase.orderNumberDataTable.Rows)
            {
                foreach (DataColumn orderNumberDataTableColumn in accountingDatabase.orderNumberDataTable.Columns)
                {
                    if(orderNumberDataTableRow[orderNumberDataTableColumn] != null)
                    {
                        if (orderNumberDataTableColumn.ColumnName.Equals("PostOrder"))
                    {
                        if(int.Parse(orderNumberDataTableRow[orderNumberDataTableColumn].ToString()) == postOrder)
                        {
                            if(orderNumberDataTableRow.ItemArray[1] != null)
                            {
                                orderNumber = orderNumberDataTableRow.ItemArray[1].ToString();
                            }
                        }
                    }
                    }
                }
            }
            orderNumberTextBox.Text = orderNumber;
        }

        private void getOrderNumberButton_Click(object sender, EventArgs e)
        {
            getOrderNumber();
        }

        //Gets the instance of this form and passes it to a new instance of the RawMaterialsAvailability form so that this form can be managed.
        private void addProductButton_Click(object sender, EventArgs e)
        {
            //Assigns a reference of the current OrderTransfer form to orderTransferInstance.
            orderTransferInstance = (OrderTransfer)Form.ActiveForm;
            RawMaterialsAvailability rawMaterialsAvailabilityInstance = new RawMaterialsAvailability(orderTransferInstance);
            rawMaterialsAvailabilityInstance.setRawMaterialsAvailabilityInstance(rawMaterialsAvailabilityInstance);
            rawMaterialsAvailabilityInstance.Show();
        }

        //Iterates through Product.productsList, which contains every Product instance that pertains to the current order.  It writes the values contained in each instance to the productsTreeView.
        public void updateProductsTreeNode()
        {
            List<TreeNode> productsTreeNodeList = new List<TreeNode>(); 
            foreach (Product productsListElement in Product.productsList)
            {
                int[] tempRawMaterialsItemIDArray = productsListElement.getRawMaterialsItemIDArray();
                String[] tempRawMaterialsCodesArray = productsListElement.getRawMaterialsCodesArray();
                Decimal[] tempRequiredRawMaterialsQuantitiesArray = productsListElement.getRequiredRawMaterialsQuantitiesArray();
                String[] tempRarMaterialsDescriptionArray = productsListElement.getRawMaterialsDescriptionArray();
                String rawMaterialsOutputArrayOutputString;
                TreeNode[] rawMaterialsOutputArray = new TreeNode[tempRawMaterialsCodesArray.Length];

                //Concatenates the tree view output String.
                for (int i = 0; i < tempRawMaterialsCodesArray.Length; i++)
                {
                    rawMaterialsOutputArrayOutputString = tempRequiredRawMaterialsQuantitiesArray[i].ToString() + "    |    " + tempRawMaterialsCodesArray[i] + " (" + tempRawMaterialsItemIDArray[i].ToString() + ")    |    " + tempRarMaterialsDescriptionArray[i];
                    rawMaterialsOutputArray[i] = new TreeNode(rawMaterialsOutputArrayOutputString);
                }
                //Creates product node with its corresponding raw materials as child elements.
                productsTreeNode = new TreeNode(productsListElement.getProductName(), rawMaterialsOutputArray);
                productsTreeNodeList.Add(productsTreeNode);
            }
            productsTreeView.Nodes.Clear();
            //Ensures that the tree view output remains synchronized.
            foreach (TreeNode productsTreeNodeListElement in productsTreeNodeList)
            {
                productsTreeView.Nodes.Add(productsTreeNodeListElement);
            }
            productsTreeView.ExpandAll();
        }

        //Transfers the order to the inventory database.
        private void transferOrderButton_Click(object sender, EventArgs e)
        {
            //Ensure that this order has not already been successfully transferred.
            if (orderTransferred == true)
            {
                MessageBox.Show("This order already has been transferred.", "Already Transferred");
                return;
            }

            int customerID = 0;

            //Ensure that products have been added.
            if (!Product.productAdded)
            {
                MessageBox.Show("No products have been added yet.", "Empty Order");
                return;
            }

            //Ensure that the order number box is not empty.
            if (orderNumberTextBox.Text == "")
            {
                MessageBox.Show("The order number box does not contain a valid order number.  Please use the \"Get Order Button\" to query the accounting database for the most recently created order number.  /n/r/n/rYou may also enter an order number that is greater than or equal to the most recently created and saved using Sage 50 Accounting.", "Invalid Order Number");
                return;
            }
            else
            {
                try
                {
                    this.orderNumberDataTableTableAdapter.Fill(this.accountingDatabase.orderNumberDataTable);
                }
                //Opens the data source section of the help file if the data source has not been created.
                catch (Exception ex)
                {
                    MessageBox.Show("The Open Database Connectivity data source \"AccountingDataSource\" does not exist.  Please consult the \"Accounting Database Connectivity\" section of the help file.", "AccountingDataSource Does Not Exist");
                    Help.ShowHelp(null, "OITM_Help.chm", HelpNavigator.TopicId, "4");
                }
                int postOrder = int.MinValue;
                foreach (DataRow orderNumberDataTableRow in accountingDatabase.orderNumberDataTable.Rows)
                {
                    int postOrderValue = orderNumberDataTableRow.Field<int>("PostOrder");
                    postOrder = Math.Max(postOrder, postOrderValue);
                }
                //Check to see if the reference number that corresponds to the most recently created order matches the orderNumber entered in the order number box.
                foreach (DataRow orderNumberDataTableRow in accountingDatabase.orderNumberDataTable.Rows)
                {
                    foreach (DataColumn orderNumberDataTableColumn in accountingDatabase.orderNumberDataTable.Columns)
                    {
                        if (orderNumberDataTableRow[orderNumberDataTableColumn] != null)
                        {
                            if (orderNumberDataTableColumn.ColumnName.Equals("PostOrder"))
                            {
                                if (int.Parse(orderNumberDataTableRow[orderNumberDataTableColumn].ToString()) == postOrder)
                                {
                                    if (orderNumberDataTableRow.ItemArray[1] != null)
                                    {
                                        //If so, ask if the order number is correct.
                                        if (!orderNumberDataTableRow.ItemArray[1].ToString().Equals(orderNumberTextBox.Text))
                                        {
                                            DialogResult dialogResult = MessageBox.Show("The order number listed in the order number box does not appear to belong to the most recently created order.  Is the order number correct?", "Order Number", MessageBoxButtons.YesNo);
                                            if (dialogResult == DialogResult.Yes)
                                            {
                                                orderNumber = orderNumberTextBox.Text;
                                            }
                                            else if (dialogResult == DialogResult.No)
                                            {
                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            try
            {
                this.saleIDDataTableTableAdapter.Fill(this.inventoryDatabase.saleIDDataTable);
            }
            //Opens the data source help section if the data source has not been created.
            catch (Exception ex)
            {
                MessageBox.Show("The Open Database Connectivity data source \"InventoryDataSource\" does not exist.  Please consult the \"Inventory Database Connectivity\" section of the help file.", "InventoryDataSource Does Not Exist");
                Help.ShowHelp(null, "OITM_Help.chm", HelpNavigator.TopicId, "5");
            }
            //Check if the orderNumber entered into the order number box has already been entered into the inventory database.
            foreach (DataRow saleIDDataTableRow in inventoryDatabase.saleIDDataTable.Rows)
            {
                foreach (DataColumn saleIDDataTableColumn in inventoryDatabase.saleIDDataTable.Columns)
                {
                    if (saleIDDataTableColumn.ColumnName.Equals("stsalenum"))
                    {
                        if (saleIDDataTableRow[saleIDDataTableColumn] != null)
                        {
                            //If so, return.
                            if (saleIDDataTableRow[saleIDDataTableColumn].ToString().Equals(orderNumber))
                            {
                                MessageBox.Show("That order number is already listed in the inventory database.  Please choose a different order number.", "Invalid Order Number");
                                return;
                            }
                        }
                    }
                }
            }
            
            //False if customerNameComboBox.Text is not in the list.
            Boolean customerNameExists = customerNameComboBox.Items.Contains(customerNameComboBox.Text);
            String customerName = null;

            //Check if the customer name exists in the inventory database.
            if (!customerNameExists)
            {
                //Allow a new customer name to be entered.
                if (customerNameComboBox.Text == "")
                {
                    MessageBox.Show("Please enter a customer name.", "Customer Name");
                    return;
                }
                //Try to handle the entry of new customer names into the database with care.
                DialogResult dialogResult = MessageBox.Show("The customer name entered into the customer name box does not exist in the inventory database.  Please make sure that the customer name entered into the customer name box is correct.  Would you like to make a correction?", "Customer Name Not Found", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("The name will be inserted into the inventory database.  It will appear in the list for future orders.  Click \"OK\" to continue with the transfer.", "New Customer Name");
                    customerName = customerNameComboBox.Text;
                    //Find the customer number for the new customer.
                    foreach (DataRow customerID_NameDataTableRow in inventoryDatabase.customerID_NameDataTable.Rows)
                    {
                        int maxCustomerID = int.MinValue;
                        foreach (DataColumn customerID_NameDataTableColumn in inventoryDatabase.customerID_NameDataTable.Columns)                            
                        {
                            int customerIDValue = customerID_NameDataTableRow.Field<int>("CustomerID");
                            maxCustomerID = Math.Max(maxCustomerID, customerIDValue);
                        }
                        customerID = maxCustomerID + 1;
                    }
                }
            }
            else
            {
                //Find the customer number of the customer who exists in the inventory database.
                customerName = customerNameComboBox.Text;
                foreach (DataRow customerID_NameDataTableRow in inventoryDatabase.customerID_NameDataTable.Rows)
                {
                    foreach (DataColumn customerID_NameDataTableColumn in inventoryDatabase.customerID_NameDataTable.Columns)
                    {
                        if (customerID_NameDataTableColumn.ColumnName.Equals("COMPANY"))
                        {
                            if (customerName.Equals(customerID_NameDataTableRow[customerID_NameDataTableColumn].ToString()))
                            {
                                customerID = (int)customerID_NameDataTableRow.ItemArray[0];
                            }
                        }
                    }
                }
            }

            //The same itemID may have been added to more than one product.  If that is the case, then the quantities for these itemID's in each of these instances must be added together.
            List<int> tempRawMaterialsItemIDList = new List<int>();
            List<String> tempRawMaterialsCodesList = new List<String>();
            List<String> rawMaterialsDescriptionList = new List<String>();
            List<Decimal> tempRequiredRawMaterialsQuantitiesList = new List<Decimal>();
            int saleID = getSaleID();
            
            foreach (Product productsListElement in Product.productsList)
            {
                int[] tempRawMaterialsItemIDArray = productsListElement.getRawMaterialsItemIDArray();
                String[] tempRawMaterialsCodesArray = productsListElement.getRawMaterialsCodesArray();
                String[] tempRawMaterialsDescriptionArray = productsListElement.getRawMaterialsDescriptionArray();
                Decimal[] tempRequiredRawMaterialsQuantitiesArray = productsListElement.getRequiredRawMaterialsQuantitiesArray();
                for (int i = 0; i < tempRawMaterialsItemIDArray.Length; i++)
                {
                    //If ItemID is not in the tempRawMaterialsItemIDList.
                    if (!tempRawMaterialsItemIDList.Contains(tempRawMaterialsItemIDArray[i]))
                    {
                        tempRawMaterialsItemIDList.Add(tempRawMaterialsItemIDArray[i]);
                        tempRawMaterialsCodesList.Add(tempRawMaterialsCodesArray[i]);
                        rawMaterialsDescriptionList.Add(tempRawMaterialsDescriptionArray[i]);
                        tempRequiredRawMaterialsQuantitiesList.Add(tempRequiredRawMaterialsQuantitiesArray[i]);
                    }
                    //If ItemID is in the tempRawMaterialsItemIDList.
                    else
                    {
                        //If an ItemID exists in the tempRawMaterialsItemIDList, the quantity in the tempRequiredRawMaterialsQuantitiesArray that corresponds to it must be added to the quantity that exists in the tempRequiredRawMaterialsQuantitiesList.
                        tempRequiredRawMaterialsQuantitiesList[tempRawMaterialsItemIDList.IndexOf(tempRawMaterialsItemIDArray[i])] += tempRequiredRawMaterialsQuantitiesList[i];
                    }
                }
            }

            //Get the date and time.
            String transactionDate = DateTime.Now.ToString();

            //If a new customer is supposed to be added to the database, the insert statement is now created.  Otherwise this is skipped.
            String mstCustInsertStatement = null;
            System.Data.Odbc.OdbcCommand mstCustInsertCommand = null;
            if (!customerNameExists)
            {
                mstCustInsertStatement = "INSERT INTO MstCust (CustomerID, Company) VALUES (" + customerID + ",'" + customerName + "')";
                mstCustInsertCommand = new System.Data.Odbc.OdbcCommand(mstCustInsertStatement);
            }
            //Create the insert statement and command for one of the sales tables.
            string mstSalesInsertStatement = "INSERT INTO MstSales (StSaleNum, CustomerID, SaleDate, DateEnt, DateExp, DateShipped) VALUES ('" + orderNumber + "'," + customerID + ",'" + transactionDate + "','" + transactionDate + 
                "',null,null);";
            System.Data.Odbc.OdbcCommand mstSalesInsertCommand = new System.Data.Odbc.OdbcCommand(mstSalesInsertStatement);
            //Create arrays into which insert statements will be added to facilitate multiple entries into the other sales table and the inventory transaction table.
            int numberOfIndexes = tempRawMaterialsItemIDList.Count;
            System.Data.Odbc.OdbcCommand[] dtlSaleInsertCommand = new System.Data.Odbc.OdbcCommand[numberOfIndexes];
            System.Data.Odbc.OdbcCommand[] invTrans2InsertCommand = new System.Data.Odbc.OdbcCommand[numberOfIndexes];
            //Populate the arrays.
            for (int i = 0; i < numberOfIndexes; i++)
            {
                string dtlSaleInsertStatement = "INSERT INTO DtlSale (SaleID, ItemID, ItemNumber, ItemDescription, Qty, InvQty, ShpQty, OffAll, InvLocID, Shipped) VALUES (" + saleID + "," + tempRawMaterialsItemIDList[i] + ",null,'" +
                    rawMaterialsDescriptionList[i] + "'," + tempRequiredRawMaterialsQuantitiesList[i] + "," + tempRequiredRawMaterialsQuantitiesList[i] + ",0,0,1,0);";
                dtlSaleInsertCommand[i] = new System.Data.Odbc.OdbcCommand(dtlSaleInsertStatement);
                //A TranCode of 1 indicates a sale.
                //An InvLocID of 1 indicates the storefront on Gravois.
                string invTrans2InsertStatement = "INSERT INTO InvTrans2 (TransactionDate, TranCode, ItemID, InvLocID, PurchaseOrderID, FileNumber, Qty, UnitAmt) VALUES ('" + transactionDate + "',1," + tempRawMaterialsItemIDList[i] + 
                    ",1,null,'" + orderNumber + "'," + (-1 * tempRequiredRawMaterialsQuantitiesList[i]) + ",0);";
                invTrans2InsertCommand[i] = new System.Data.Odbc.OdbcCommand(invTrans2InsertStatement);
            }
            //Execute the SQL commands.
            using (System.Data.Odbc.OdbcConnection connection = new System.Data.Odbc.OdbcConnection(inventoryDBConnectionString))
            {
                if(!customerNameExists)
                {
                    mstCustInsertCommand.Connection = connection;
                    connection.Open();
                    mstCustInsertCommand.ExecuteNonQuery();
                    connection.Close();
                }
                mstSalesInsertCommand.Connection = connection;
                connection.Open();
                mstSalesInsertCommand.ExecuteNonQuery();
                connection.Close();
                for (int i = 0; i < numberOfIndexes; i++)
                {
                    dtlSaleInsertCommand[i].Connection = connection;
                    invTrans2InsertCommand[i].Connection = connection;
                    connection.Open();
                    dtlSaleInsertCommand[i].ExecuteNonQuery();
                    invTrans2InsertCommand[i].ExecuteNonQuery();
                    connection.Close();
                }
            }
            //Discourage tranferring this order a second time.
            orderTransferred = true;
            //Success!!!
            MessageBox.Show("Order number " + orderNumber + " transferred successfully.", "Success!");
        }

        int getSaleID()
        {
            try
            {
                this.saleIDDataTableTableAdapter.Fill(this.inventoryDatabase.saleIDDataTable);
            }
            //Opens the data source help section if the data source has not been created.
            catch (Exception ex)
            {
                MessageBox.Show("The Open Database Connectivity data source \"InventoryDataSource\" does not exist.  Please consult the \"Inventory Database Connectivity\" section of the help file.", "InventoryDataSource Does Not Exist");
                Help.ShowHelp(null, "OITM_Help.chm", HelpNavigator.TopicId, "5");
            }
            //Finds the saleID that is supposed to be used in transferOrder().
            int maxSaleID = int.MinValue;
            foreach (DataRow saleIDDataTableRow in inventoryDatabase.saleIDDataTable.Rows)
            {
                if (saleIDDataTableRow.ItemArray[0] != null)
                {
                    int saleIDValue = saleIDDataTableRow.Field<int>("SaleID");
                    maxSaleID = Math.Max(maxSaleID, saleIDValue);
                }
            }
            return maxSaleID + 1;
        }

        //Opens the help file to the index corresponding to this form.
        private void orderTransfer_HelpButtonClicked(Object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Help.ShowHelp(null, "OITM_Help.chm", HelpNavigator.TopicId, "2");
        }

        //Resets all relevant variables so that a new order can be created.
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            if (!Product.productAdded)
            {
                MessageBox.Show("The current order already is a new order.", "New Order");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Do you want to create a new order?", "Create New Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RawMaterialsAvailability.staticRawMaterialsAvailabilityReference.resetRawMaterialsAvailability();
                Product.staticProductReference.resetProduct();
                orderTransferInstance.updateProductsTreeNode();
                customerNameComboBox.Text = "";
                orderNumberTextBox.Text = "";
                orderTransferred = false;
                orderNumber = "";
                orderTransferred = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        //Handles the enter event of the customer name box and populates the list.
        private void customerNameComboBox_Enter(object sender, EventArgs e)
        {
            populateCustomerNameComboBox();
        }
    }
}