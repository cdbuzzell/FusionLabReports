using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fusion_Lab_Reports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Submissions__xlnm__FilterDatabase' table. You can move, or remove it, as needed.
            this.Submissions__xlnm__FilterDatabaseTableAdapter.Fill(this.DataSet1._Submissions__xlnm__FilterDatabase);
            //this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //"Fusion_Lab_Reports.Reports.01MasterList.rdlc";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fusion_Lab_Reports.Reports." + comboBox1.SelectedItem.ToString().Replace(" ", "") + ".rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}