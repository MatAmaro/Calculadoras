using IMC;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Calc
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCalcSimple_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new FmrCalcSimple();           
            form.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCalcImc_Click(object sender, EventArgs e)
        {
            var formImc = new FmrImc();
            formImc.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
