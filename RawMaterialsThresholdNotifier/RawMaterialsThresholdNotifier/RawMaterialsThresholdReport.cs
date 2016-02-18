using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawMaterialsThresholdNotifier
{
    public partial class RawMaterialsThresholdReport : Form
    {
        public RawMaterialsThresholdReport()
        {
            InitializeComponent();
        }

        //Initialize the text box to the notification String created in the RawMaterialsThreshold notifier form.
        public RawMaterialsThresholdReport(String notification)
        {
            InitializeComponent();
            rawMaterialsThresholdReportTextBox.Text = notification;
        }

        //Handle the help button click and open the help file to the index corresponding to this form.
        private void rawMaterialsThresholdReport_HelpButtonClicked(Object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Help.ShowHelp(null, "RMTN_Help.chm", HelpNavigator.TopicId, "3");
        }
    }
}
