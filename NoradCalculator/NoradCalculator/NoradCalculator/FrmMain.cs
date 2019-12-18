using System;
using System.Windows.Forms;

namespace NoradCalculator
{
    public partial class FrmMain : Form
    {
        public enum Operator
        {
            plus, minus, multi, div, none
        }

        private string operand1, operand2;
        private Operator lastOperator;
        public FrmMain()
        {
            InitializeComponent();
            ClearOperand2();
            ClearOperand1();
            lastOperator = Operator.none;
        }


        /*Toolstrip gombok*/
        private void tlStrpFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /*Segéd metódusok*/
        private void ModMainText(string number)
        {
            string text = txtBxMain.Text;
            if (number == "b")
            {
                if (text.Length != 1)
                {
                    txtBxMain.Text = text.Remove(text.Length - 1);

                }
                else
                {
                    txtBxMain.Text = "0";
                }
            }
            else if (text != "0")
            {
                txtBxMain.Text = text.Insert(text.Length, number);
            }
            else
            {
                txtBxMain.Text = number;
            }
        }
        private void SetOperand1()
        {
            operand1 = txtBxMain.Text;
        }
        private void SetOperand2()
        {
            operand2 = txtBxMain.Text;
        }
        private void ClearOperand1()
        {
            operand1 = "";
        }
        private void ClearOperand2()
        {
            operand2 = "";
        }
        private void SetLastOperator(Operator op)
        {
            lastOperator = op;
        }
        private void txtBxMain_Clear()
        {
            txtBxMain.Text = "0";
        }
        private void RefreshHelp()
        {
            op1Txt.Text = operand1.ToString();
            op2Txt.Text = operand2.ToString();
            operatorTxt.Text = lastOperator.ToString();            
        }
        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            RefreshHelp();
        }
        private double ConvertToNumber(string s)
        {
            double re = 0;

            try
            {
                re = Double.Parse(s);
            }
            catch (Exception)
            {

                throw new Exception("Konvertálási hiba! ");
            }
            
            return re;
        }


        /*Numerikus gombok*/
        private void btnNum_1_Click(object sender, EventArgs e)
        {
            ModMainText("1");
        }
        private void btnNum_2_Click(object sender, EventArgs e)
        {
            ModMainText("2");
        }
        private void btnNum_3_Click(object sender, EventArgs e)
        {
            ModMainText("3");
        }
        private void btnNum_4_Click(object sender, EventArgs e)
        {
            ModMainText("4");
        }
        private void btnNum_5_Click(object sender, EventArgs e)
        {
            ModMainText("5");
        }
        private void btnNum_6_Click(object sender, EventArgs e)
        {
            ModMainText("6");
        }
        private void btnNum_7_Click(object sender, EventArgs e)
        {
            ModMainText("7");
        }
        private void btnNum_8_Click(object sender, EventArgs e)
        {
            ModMainText("8");
        }
        private void btnNum_9_Click(object sender, EventArgs e)
        {
            ModMainText("9");
        }
        private void btnNum_0_Click(object sender, EventArgs e)
        {
            ModMainText("0");

        }


        /*Operátor gombok*/
        private void opBtn_plus_Click(object sender, EventArgs e)
        {
            if (lastOperator != Operator.none)
            {
                SetOperand2();
                txtBxMain_Clear();
                btnResult_Click(sender, e);
                SetOperand1();
                txtBxResult.Text = operand1.ToString();
                txtBxMain_Clear();
                SetLastOperator(Operator.plus);
            }
            else
            {
                SetOperand1();
                txtBxMain_Clear();
                SetLastOperator(Operator.plus);
            }
        }
        private void btnOp_minus_Click(object sender, EventArgs e)
        {
            SetOperand1();
            txtBxMain_Clear();
            SetLastOperator(Operator.plus);
        }
        private void btnOp_multi_Click(object sender, EventArgs e)
        {
            SetOperand1();
            txtBxMain_Clear();
            SetLastOperator(Operator.plus);
        }
        private void btnOp_div_Click(object sender, EventArgs e)
        {
            SetOperand1();
            txtBxMain_Clear();
            SetLastOperator(Operator.plus);
        }


        /*Funkció gombok*/
        private void tlStrpFileClear_Click(object sender, EventArgs e)
        {
            ClearOperand1();
            ClearOperand2();
            SetLastOperator(Operator.none);
            txtBxMain_Clear();
            op1Txt.Text = "";
            op2Txt.Text = "";
            operatorTxt.Text = "";
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            ModMainText("b");
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            string result = "0";

            if (operand2 == "")
            {
                SetOperand2();
            }

            double op1 = ConvertToNumber(operand1);
            double op2 = ConvertToNumber(operand2);

            switch (lastOperator)
            {
                case Operator.plus:
                    result = (op1 + op2).ToString();
                    break;

                case Operator.minus:
                    result = (op1 - op2).ToString();
                    break;

                case Operator.multi:
                    result = (op1 * op2).ToString();
                    break;

                case Operator.div:
                    result = (op1 / op2).ToString();
                    break;

                case Operator.none:
                    result = operand1;
                    break;

                default:
                    result = "0";
                    break;
            }

            SetLastOperator(Operator.none);
            ClearOperand2();
            txtBxMain_Clear();
            ClearOperand1();
            ClearOperand2();
            txtBxResult.Text = result;

        }

    }
}
