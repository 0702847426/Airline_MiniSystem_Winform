using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLine_System
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void aIRPLINEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aIRPLINEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airLineDataSet);

        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airLineDataSet.AIRPLINE' table. You can move, or remove it, as needed.
            this.aIRPLINETableAdapter.Fill(this.airLineDataSet.AIRPLINE);

        }
    }
}
