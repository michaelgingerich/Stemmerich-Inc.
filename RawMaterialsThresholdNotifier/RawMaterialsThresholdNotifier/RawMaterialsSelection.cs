using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawMaterialsThresholdNotifier
{
    public partial class RawMaterialsSelection : Form
    {
        String savedRawMaterialsFileName = "SavedRawMaterials.bin";

        public RawMaterialsSelection()
        {
            InitializeComponent();
        }

        private void RawMaterialsSelection_Load(object sender, EventArgs e)
        {
            try
            {
                this.rawMaterialsThresholdNotifierDataTableTableAdapter.Fill(this.inventoryDatabase.rawMaterialsThresholdNotifierDataTable);
            }
            //Open the data source section of the help file if the data source has not been created on the local machine.
            catch (Exception ex)
            {
                MessageBox.Show("The Open Database Connectivity data source \"InventoryDataSource\" does not exist.  Please consult the \"Inventory Database Connectivity\" section of the help file.", "InventoryDataSource Does Not Exist");
                Help.ShowHelp(null, "RMTN_Help.chm", HelpNavigator.TopicId, "5");
            }
            //Add a checkboxcolumn to the datagridview.
            DataGridViewCheckBoxColumn notify = new DataGridViewCheckBoxColumn();
            notify.HeaderText = "Notify";
            notify.Name = "notifyColumn";
            rawMaterialsSelectionDataGridView.Columns.Insert(0, notify);
            rawMaterialsSelectionDataGridView.Columns["dataGridViewTextBoxColumn5"].DefaultCellStyle.Format = "N2";
            //Synchronize the datagridview with the saved raw material list and selected states.
            syncRawMaterialsSelectionDataGridViewNotifyColumn();
        }

        //Handle checkbox selection.
        private void rawMaterialsSelectionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow rawMaterialsSelectionDataGridViewRow in rawMaterialsSelectionDataGridView.Rows)
            {
                //Find the row where the click occurred.
                if (rawMaterialsSelectionDataGridViewRow.Index == e.RowIndex)
                {
                    //Save cells to variables.
                    DataGridViewCell rawMaterialsSelectionDataGridViewItemIDCell = rawMaterialsSelectionDataGridViewRow.Cells["dataGridViewTextBoxColumn1"] as DataGridViewCell;
                    DataGridViewCell rawMaterialsSelectionDataGridViewNotifyCell = rawMaterialsSelectionDataGridViewRow.Cells["notifyColumn"] as DataGridViewCell;
                    //Ensure that this is not an empty row.
                    if (rawMaterialsSelectionDataGridViewItemIDCell.Value != null)
                    {
                        int rawMaterialsSelectionDataGridViewItemIDCellValue = int.Parse(rawMaterialsSelectionDataGridViewItemIDCell.Value.ToString());
                        Boolean rawMaterialsSelectionDataGridViewNotifyCellValue = (Boolean)rawMaterialsSelectionDataGridViewNotifyCell.FormattedValue;
                        
                        //Get the checkbox value and save it to the list with the itemID.
                        if (rawMaterialsSelectionDataGridViewNotifyCellValue == false)
                        {
                            rawMaterialsSelectionDataGridViewNotifyCellValue = true;
                            RawMaterial.rawMaterialList.Add(new RawMaterial(rawMaterialsSelectionDataGridViewItemIDCellValue, rawMaterialsSelectionDataGridViewNotifyCellValue));
                        }
                        //Remove it from the list if it already exists.
                        else if (rawMaterialsSelectionDataGridViewNotifyCellValue == true)
                        {
                            rawMaterialsSelectionDataGridViewNotifyCellValue = false;
                            foreach (RawMaterial rawMaterialListElement in RawMaterial.rawMaterialList)
                            {
                                if (rawMaterialsSelectionDataGridViewItemIDCellValue == rawMaterialListElement.getItemID())
                                {
                                    RawMaterial.rawMaterialList.Remove(rawMaterialListElement);
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
            }
            //Serialize the list.
            saveRawMaterialList();
        }

        void syncRawMaterialsSelectionDataGridViewNotifyColumn()
        {
            foreach (DataGridViewRow rawMaterialsSelectionDataGridViewRow in rawMaterialsSelectionDataGridView.Rows)
            {
                DataGridViewCell rawMaterialsSelectionDataGridViewItemIDCell = rawMaterialsSelectionDataGridViewRow.Cells["dataGridViewTextBoxColumn1"] as DataGridViewCell;
                DataGridViewCell rawMaterialsSelectionDataGridViewNotifyCell = rawMaterialsSelectionDataGridViewRow.Cells["notifyColumn"] as DataGridViewCell;

                //Ensure that this isn't an empty row.
                if (rawMaterialsSelectionDataGridViewItemIDCell.Value != null)
                {
                    int rawMaterialsSelectionDataGridViewItemIDCellValue = int.Parse(rawMaterialsSelectionDataGridViewItemIDCell.Value.ToString());
                    //Synchronize the datagridview with the itemID's and selected values saved in the list.
                    foreach (RawMaterial rawMaterialListElement in RawMaterial.rawMaterialList)
                    {
                        if (rawMaterialsSelectionDataGridViewItemIDCellValue == rawMaterialListElement.getItemID())
                        {
                            rawMaterialsSelectionDataGridViewNotifyCell.Value = rawMaterialListElement.getNotify();
                        }
                    }
                }
            }
        }

        //Synchronize datagridview with list after sort.
        private void rawMaterialsSelectionDataGridView_Sorted(object sender, EventArgs e)
        {
            syncRawMaterialsSelectionDataGridViewNotifyColumn();
        }

        //Serialize the list.
        void saveRawMaterialList()
        {
            try
            {
                Stream FileStream = File.Create(savedRawMaterialsFileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(FileStream, RawMaterial.rawMaterialList);
                FileStream.Close();
            }
            catch (Exception ex)
            {

            }
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
            rawMaterialsThresholdNotifierDataTableBindingSource.Filter = filterRawMaterialsSelectionDataGridView();
            syncRawMaterialsSelectionDataGridViewNotifyColumn();
        }

        private void descFilterButton_Click_KeyPress(object sender, EventArgs e)
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

            rawMaterialsThresholdNotifierDataTableBindingSource.Filter = filterRawMaterialsSelectionDataGridView();
            syncRawMaterialsSelectionDataGridViewNotifyColumn();
        }

        String filterRawMaterialsSelectionDataGridView()
        {
            String codeFilterTextBoxString = codeFilterTextBox.Text;
            String descFilterTextBoxString = descFilterTextBox.Text;
            return "Code LIKE '*" + codeFilterTextBoxString + "*' AND Description LIKE '*" + descFilterTextBoxString + "*'";
        }

        //Detect text change in the text boxes and set the corresponding button the the accept button.
        private void codeFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = codeFilterButton;
        }

        private void descFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = descFilterButton;
        }

        //Handle the help button click and open the index of the help file corresponding to this form.
        private void RawMaterialsSelection_HelpButtonClicked_1(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Help.ShowHelp(null, "RMTN_Help.chm", HelpNavigator.TopicId, "2");
        }
    }
}
