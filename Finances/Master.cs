using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finances
{
    public partial class masterForm : Form
    {
        public masterForm()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTableForm frm = new addTableForm();
            frm.Show();
        }

        private void viewData_Click(object sender, EventArgs e)
        {
            viewData frm = new viewData();
            frm.Show();
        }
    }
}
