using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderInformationTransferManager
{
    public partial class RawMaterialsAvailability : Form
    {
        public static RawMaterialsAvailability staticRawMaterialsAvailabilityReference= new RawMaterialsAvailability();
        RawMaterialsAvailability rawMaterialsAvailabilityInstance;
        OrderTransfer orderTransferInstance;
        TextBox tb;
        List<int> tempRawMaterialsItemIDList = new List<int>();
        List<String> tempRawMaterialsCodesList = new List<String>();
        List<String> tempRawMaterialsDescriptionList = new List<String>();
        List<Decimal> tempRequiredRawMaterialsQuantitiesList = new List<Decimal>();

        public RawMaterialsAvailability()
        {
            InitializeComponent();
        }

        public RawMaterialsAvailability(OrderTransfer orderTransferInstanceParam)
        {
            InitializeComponent();
            orderTransferInstance = orderTransferInstanceParam;
        }

        private void RawMaterialsAvailability_Load(object sender, EventArgs e)
        {
            try
            {
                rawMaterialsAvailabilityDataTableTableAdapter.Fill(inventoryDatabase.rawMaterialsAvailabilityDataTable);
            }
            //Open the help file section dealing with data sources if the data source has not been created.
            catch (Exception ex)
            {
                MessageBox.Show("The Open Database Connectivity data source \"InventoryDataSource\" does not exist.  Please consult the \"Inventory Database Connectivity\" section of the help file.", "InventoryDataSource Does Not Exist");
                Help.ShowHelp(null, "OITM_Help.chm", HelpNavigator.TopicId, "5");
            }
            //Manually add the Req. Quantity column.
            rawMaterialsAvailabilityDataGridView.Columns.Add("requiredItemQuantity", "Req. Quantity");
            rawMaterialsAvailabilityDataGridView.CurrentCell = rawMaterialsAvailabilityDataGridView["requiredItemQuantity", 0];
            rawMaterialsAvailabilityDataGridView.Columns["dataGridViewTextBoxColumn5"].DefaultCellStyle.Format = "N2";
            rawMaterialsAvailabilityDataGridView.Columns["requiredItemQuantity"].DefaultCellStyle.Format = "N2";
        }

        //Synchronizes the lists that hold selected values.
        private void rawMaterialsAvailabilityDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow rawMaterialsAvailabilityDataGridViewRow in rawMaterialsAvailabilityDataGridView.Rows)
            {
                //Save cells to variables.
                DataGridViewCell rawMaterialsAvailabilityDataGridViewItemIDCell = rawMaterialsAvailabilityDataGridViewRow.Cells["ItemID"] as DataGridViewCell;
                DataGridViewCell rawMaterialsAvailabilityDataGridViewCodeCell = rawMaterialsAvailabilityDataGridViewRow.Cells["dataGridViewTextBoxColumn2"] as DataGridViewCell;
                DataGridViewCell rawMaterialsAvailabilityDataGridViewDescriptionCell = rawMaterialsAvailabilityDataGridViewRow.Cells["dataGridViewTextBoxColumn3"] as DataGridViewCell;
                DataGridViewCell rawMaterialsAvailabilityDataGridViewRequiredItemQuantityCell = rawMaterialsAvailabilityDataGridViewRow.Cells["requiredItemQuantity"] as DataGridViewCell;

                //Ensure this isn't an empty row.
                if (rawMaterialsAvailabilityDataGridViewCodeCell.Value != null)
                {
                    String tempRawMaterialsCodesListElement = rawMaterialsAvailabilityDataGridViewCodeCell.Value.ToString();
                    //Ensure a quantity has been entered.
                    if (rawMaterialsAvailabilityDataGridViewRequiredItemQuantityCell.Value != null)
                    {
                        int tempRawMaterialsItemIDListElement = int.Parse(rawMaterialsAvailabilityDataGridViewItemIDCell.Value.ToString());
                        String tempRawMaterialsDescriptionListElement = rawMaterialsAvailabilityDataGridViewDescriptionCell.Value.ToString();
                        Decimal tempRequiredRawMaterialsQuantitiesListElement = Decimal.Parse(rawMaterialsAvailabilityDataGridViewRequiredItemQuantityCell.Value.ToString());
                        
                        //If values for this row exist, remove them from the lists.
                        if (tempRawMaterialsItemIDList.Contains(tempRawMaterialsItemIDListElement))
                        {
                            tempRawMaterialsItemIDList.RemoveAt(tempRawMaterialsCodesList.IndexOf(tempRawMaterialsCodesListElement));
                            tempRawMaterialsDescriptionList.RemoveAt(tempRawMaterialsCodesList.IndexOf(tempRawMaterialsCodesListElement));
                            tempRequiredRawMaterialsQuantitiesList.RemoveAt(tempRawMaterialsCodesList.IndexOf(tempRawMaterialsCodesListElement));
                            tempRawMaterialsCodesList.Remove(tempRawMaterialsCodesListElement);
                        }
                        //If the quantity is valid, add values to the lists.
                        if (tempRequiredRawMaterialsQuantitiesListElement != 0)
                        {
                            tempRawMaterialsItemIDList.Add(tempRawMaterialsItemIDListElement);
                            tempRawMaterialsDescriptionList.Add(tempRawMaterialsDescriptionListElement);
                            tempRawMaterialsCodesList.Add(tempRawMaterialsCodesListElement);
                            tempRequiredRawMaterialsQuantitiesList.Add(tempRequiredRawMaterialsQuantitiesListElement);
                        }
                    }
                    else
                    {
                        //If the cell value is changed to null and it previously contained a non-null value, it must be removed from the lists.
                        if (tempRawMaterialsCodesList.Contains(tempRawMaterialsCodesListElement))
                        {
                            tempRawMaterialsItemIDList.RemoveAt(tempRawMaterialsCodesList.IndexOf(tempRawMaterialsCodesListElement));
                            tempRawMaterialsDescriptionList.RemoveAt(tempRawMaterialsCodesList.IndexOf(tempRawMaterialsCodesListElement));
                            tempRequiredRawMaterialsQuantitiesList.RemoveAt(tempRawMaterialsCodesList.IndexOf(tempRawMaterialsCodesListElement));
                            tempRawMaterialsCodesList.Remove(tempRawMaterialsCodesListElement);
                        }
                    }
                }
            }
        }

        //Synchronize the datagridview with the values stored in the lists.
        void syncRawMaterialsAvailabilityDataGridViewReqQuantities()
        {
            foreach (DataGridViewRow rawMaterialsAvailabilityDataGridViewRow in rawMaterialsAvailabilityDataGridView.Rows)
            {
                DataGridViewCell rawMaterialsAvailabilityDataGridViewItemIDCell = rawMaterialsAvailabilityDataGridViewRow.Cells["ItemID"] as DataGridViewCell;
                DataGridViewCell rawMaterialsAvailabilityDataGridViewRequiredItemQuantityCell = rawMaterialsAvailabilityDataGridViewRow.Cells["requiredItemQuantity"] as DataGridViewCell;

                if (rawMaterialsAvailabilityDataGridViewItemIDCell.Value != null)
                {
                    int rawMaterialsAvailabilityDataGridViewItemIDCellValue = int.Parse(rawMaterialsAvailabilityDataGridViewItemIDCell.Value.ToString());
                    //If the code exists in the tempRawMaterialsCodesArray, then the corresponding Req. Quantity is written to the Req. Quantity cell.
                    if (tempRawMaterialsItemIDList.Contains(rawMaterialsAvailabilityDataGridViewItemIDCellValue))
                    {
                        rawMaterialsAvailabilityDataGridViewRequiredItemQuantityCell.Value = tempRequiredRawMaterialsQuantitiesList[tempRawMaterialsItemIDList.IndexOf(rawMaterialsAvailabilityDataGridViewItemIDCellValue)];
                    }
                }
            }
        }

        //addRawMaterialsButton_Click iterates through each row displayed in the rawMaterialsAvailabilityDataGridView.  It counts the number of rows where a numeric value has been entered into the Req. Quantity column.  It then writes these values to the tempRawMaterialsCodesArray and the tempRequiredRawMaterialsQuantitiesArray arrays.  These arrays are then passed to an instance of Product.  Finally, this function calls updateProductsTreeNode() in OrderTransfer.
        private void addRawMaterialsButton_Click(object sender, EventArgs e)
        {
            int numberOfElements = tempRawMaterialsCodesList.Count;
            if(numberOfElements == 0)
            {
                MessageBox.Show("No raw materials have been added.", "No Raw Materials");
                return;
            }
            Product tempProductInstance = null;
            //Count the number of non-null cells in the Req. Quantity column.  
            //Uses the number of non-null cells to initialize the tempRawMaterialsCodesArray and the tempRequiredRawMaterialsQuantitiesArray arrays.
            int[] tempRawMaterialsItemIDArray = new int[numberOfElements];
            String[] tempRawMaterialsCodesArray = new String[numberOfElements];
            String[] tempRawMaterialsDescriptionArray = new String[numberOfElements];
            Decimal[] tempRequiredRawMaterialsQuantitiesArray = new Decimal[numberOfElements];
            //Writes the values stored in the Code and Req. Quantity columns to the tempRawMaterialsCodesArray and the tempRequiredRawMaterialsQuantitiesArray arrays.
            for (int i = 0; i < numberOfElements; i++)
            {
                if (tempRawMaterialsCodesList[i] != null)
                {
                    tempRawMaterialsItemIDArray[i] = tempRawMaterialsItemIDList[i];
                    tempRawMaterialsCodesArray[i] = tempRawMaterialsCodesList[i];
                    tempRawMaterialsDescriptionArray[i] = tempRawMaterialsDescriptionList[i];
                    tempRequiredRawMaterialsQuantitiesArray[i] = tempRequiredRawMaterialsQuantitiesList[i];
                }
            }
            //Send instance values to the container class.
            tempProductInstance = new Product(tempRawMaterialsItemIDArray, tempRawMaterialsCodesArray, tempRawMaterialsDescriptionArray, tempRequiredRawMaterialsQuantitiesArray);
            //Saves this instance to a list of instances.
            tempProductInstance.updateProductsList(tempProductInstance);
            //Writes these values to the tree view in the OrderTransfer form.
            orderTransferInstance.updateProductsTreeNode();
            orderTransferInstance.Refresh();
            rawMaterialsAvailabilityInstance.Close();

        }

        //Respond to the help button click by opening the help file to the index corresponding to this form.
        private void rawMaterialsAvailability_HelpButtonClicked(Object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Help.ShowHelp(null, "OITM_Help.chm", HelpNavigator.TopicId, "3");
        }

        //Filter the datagridview.
        private void codeFilterButton_Click_KeyPress(object sender, EventArgs e)
        {
            if (codeFilterButton.Text == "Filter")
            {
                codeFilterButton.Text = "Clear";
            }
            else
            {
                codeFilterButton.Text = "Filter";
                codeFilterTextBox.Text = "";
            }
            rawMaterialsAvailabilityDataTableBindingSource.Filter = filterRawMaterialsAvailabilityDataGridView();
            syncRawMaterialsAvailabilityDataGridViewReqQuantities();
        }

        private void descfilterButton_Click_KeyPress(object sender, EventArgs e)
        {
            if (descFilterButton.Text == "Filter")
            {
                descFilterButton.Text = "Clear";
            }
            else
            {
                descFilterButton.Text = "Filter";
                descFilterTextBox.Text = "";
            }

            rawMaterialsAvailabilityDataTableBindingSource.Filter = filterRawMaterialsAvailabilityDataGridView();
            syncRawMaterialsAvailabilityDataGridViewReqQuantities();
        }

        String filterRawMaterialsAvailabilityDataGridView()
        {
            String codeFilterTextBoxString = codeFilterTextBox.Text;
            String descFilterTextBoxString = descFilterTextBox.Text;
            return "Code LIKE '*" + codeFilterTextBoxString + "*' AND Description LIKE '*" + descFilterTextBoxString + "*'";
        }

        //Suppress undesired values being entered into the required quantities column.
        private void rawMaterialsAvailabilityDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(rawMaterialsAvailabilityDataGridView_KeyPress);
            tb = (TextBox)e.Control;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(rawMaterialsAvailabilityDataGridView_KeyPress);
                }
        }

        private void rawMaterialsAvailabilityDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('.'))
            {
                e.Handled = true;
            }
        }

        //Handle the text change event in the filtering text boxes and set the corresponding button to the accept button.
        private void codeFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = codeFilterButton;
        }

        private void descFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = descFilterButton;
        }

        //Sets rawMaterialsAvailabilityInstance to the instance that was created in the OrderTransfer form so that this instance can be worked with within this form without relying on Forms.ActiveForm.
        public void setRawMaterialsAvailabilityInstance(RawMaterialsAvailability rawMaterialsAvailabilityInstanceParam)
        {
            rawMaterialsAvailabilityInstance = rawMaterialsAvailabilityInstanceParam;
        }

        //Resets all relevant variables for a new order.
        public void resetRawMaterialsAvailability()
        {
            tempRawMaterialsItemIDList = new List<int>();
            tempRawMaterialsCodesList = new List<String>();
            tempRawMaterialsDescriptionList = new List<String>();
            tempRequiredRawMaterialsQuantitiesList = new List<Decimal>();
        }

        //Synchronizes the datagridview if it is sorted.
        private void rawMaterialsAvailabilityDataGridView_Sorted(object sender, EventArgs e)
        {
            syncRawMaterialsAvailabilityDataGridViewReqQuantities();
        }
    }
}
