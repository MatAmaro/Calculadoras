using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Calc
{
    public partial class FmrCalcSimple : Form
    {

        public string TempDiplay { get; private set; } = string.Empty;
        public DataTable resultDysplay { get; private set; } = new DataTable();


        public FmrCalcSimple()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string zero = "0";
            TempDiplay += zero;
            txtName.Text = TempDiplay;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string two = "3";
            TempDiplay += two;
            txtName.Text = TempDiplay;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string one = "1";
            TempDiplay += one;
            txtName.Text = TempDiplay;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string tree = "3";
            TempDiplay += tree;
            txtName.Text = TempDiplay;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string four = "4";
            TempDiplay += four;
            txtName.Text = TempDiplay;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string five = "5";
            TempDiplay += five;
            txtName.Text = TempDiplay;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string six = "6";
            TempDiplay += six;
            txtName.Text = TempDiplay;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string seven = "7";
            TempDiplay += seven;
            txtName.Text = TempDiplay;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string eight = "8";
            TempDiplay += eight;
            txtName.Text = TempDiplay;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string nine = "9";
            TempDiplay += nine;
            txtName.Text = TempDiplay;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            string multi = "*";
            RemoveAfterTrueCheckEnd();
            TempDiplay += multi;
            txtName.Text = TempDiplay;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string divid = "/";
            RemoveAfterTrueCheckEnd();
            TempDiplay += divid;
            txtName.Text = TempDiplay;
        }

        private void btnMen_Click(object sender, EventArgs e)
        {
            string menus = "-";
            RemoveAfterTrueCheckEnd();
            TempDiplay += menus;
            txtName.Text = TempDiplay;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            string soma = "+";
            RemoveAfterTrueCheckEnd();
            TempDiplay += soma;
            txtName.Text = TempDiplay;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (TempDiplay.Length > 0)
            {
                TempDiplay = TempDiplay.Remove(TempDiplay.Length - 1);
                txtName.Text = TempDiplay;
            }

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            TempDiplay = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (TempDiplay.Length > 0)
            {
                RemoveAfterTrueCheckBegin();
                RemoveAfterTrueCheckEnd();
                var result = resultDysplay.Compute(TempDiplay, "");
                txtName.Text = result.ToString();
                TempDiplay = "";
            }
                
        }

        public bool OperatorCheckEnd()
        {
            if(TempDiplay.Length > 0)
            {
                bool checkEnd = TempDiplay[TempDiplay.Length - 1] switch
                {
                    '+' => true,
                    '-' => true,
                    '*' => true,
                    '/' => true,
                    _ => false
                };
                return checkEnd;
            }
            else
                return false;
        }

        public void RemoveAfterTrueCheckEnd()
        {
            if (OperatorCheckEnd())
            {
                TempDiplay = TempDiplay.Remove(TempDiplay.Length - 1,1);
            }
        }

        public bool OperatorCheckBegin()
        {
            if (TempDiplay.Length > 0)
            {
                bool checkBegin = TempDiplay[0] switch
                {                   
                    '*' => true,
                    '/' => true,
                    _ => false
                };
                return checkBegin;
            }
            else
                return false;
        }

        public void RemoveAfterTrueCheckBegin()
        {
            if (OperatorCheckBegin())
            {
                TempDiplay = TempDiplay.Remove(0,1);
            }
        }


    }
}
