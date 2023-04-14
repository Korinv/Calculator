using System.Drawing.Printing;

namespace Calculator
{
    public partial class Calculator : Form
    {
        //
        //Calculator
        //
        public Calculator()
        {
            InitializeComponent();
        }

        private bool isTherePoint = false;
        private string numOne;
        private string numTwo;
        private bool isAdd = false, isSub = false, isMul = false, isDiv = false, isPow = false, isSqr = false, isMod = false;
        private bool error = false;
        private int equClick = 0;
        //
        // clearing character
        //
        private void noCharacterChoosen()
        {
            whiteButtons();
            equClick = 0;
            num2_box.Clear();
            isAdd = false;
            isSub = false;
            isMul = false;
            isDiv = false;
            isPow = false;
            isSqr = false;
            isMod = false;
        }
        //
        // grey & white buttons
        //
        private void grayButtons()
        {
            btn_pm.BackColor = Color.Gray;
            btn_equ.BackColor = Color.Gray;
            btn_plu.BackColor = Color.Gray;
            btn_min.BackColor = Color.Gray;
            btn_mul.BackColor = Color.Gray;
            btn_div.BackColor = Color.Gray;
            btn_pow.BackColor = Color.Gray;
            btn_sqr.BackColor = Color.Gray;
            btn_mod.BackColor = Color.Gray;
            btn_poi.BackColor = Color.Gray;
            btn_del.BackColor = Color.Gray;
            btn_0.BackColor = Color.Gray;
            btn_1.BackColor = Color.Gray;
            btn_2.BackColor = Color.Gray;
            btn_3.BackColor = Color.Gray;
            btn_4.BackColor = Color.Gray;
            btn_5.BackColor = Color.Gray;
            btn_6.BackColor = Color.Gray;
            btn_7.BackColor = Color.Gray;
            btn_8.BackColor = Color.Gray;
            btn_9.BackColor = Color.Gray;
        }
        private void whiteButtons()
        {
            btn_pm.BackColor = Color.White;
            btn_equ.BackColor = Color.White;
            btn_plu.BackColor = Color.White;
            btn_min.BackColor = Color.White;
            btn_mul.BackColor = Color.White;
            btn_div.BackColor = Color.White;
            btn_pow.BackColor = Color.White;
            btn_sqr.BackColor = Color.White;
            btn_mod.BackColor = Color.White;
            btn_poi.BackColor = Color.White;
            btn_del.BackColor = Color.White;
            btn_0.BackColor = Color.White;
            btn_1.BackColor = Color.White;
            btn_2.BackColor = Color.White;
            btn_3.BackColor = Color.White;
            btn_4.BackColor = Color.White;
            btn_5.BackColor = Color.White;
            btn_6.BackColor = Color.White;
            btn_7.BackColor = Color.White;
            btn_8.BackColor = Color.White;
            btn_9.BackColor = Color.White;
        }

        //
        // Number buttons
        //
        private void btn_0_Click(object sender, EventArgs e)
        {
            if(!error)
                equ_box.AppendText("0");            
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            if(!error)
                equ_box.AppendText("1");
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (!error)
                equ_box.AppendText("2");
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            if(!error)
                equ_box.AppendText("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if(!error)
                equ_box.AppendText("4");
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            if(!error)
                equ_box.AppendText("5");
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            if(!error)
                equ_box.AppendText("6");
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            if(!error)
                equ_box.AppendText("7");
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            if(!error)
                equ_box.AppendText("8");
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            if(!error)
                equ_box.AppendText("9");
        }
        //
        // point button
        //
        private void btn_poi_Click(object sender, EventArgs e)
        {
            if(!error)
            {
                if (!isTherePoint)
                {
                    equ_box.AppendText(".");
                    isTherePoint = true;
                }
            }
        }
        //
        // plus/minus button
        //
        private void btn_pm_Click(object sender, EventArgs e)
        {
            if (equ_box.Text.Length > 0 && !error)
            {
                double temp = 0;
                if(double.TryParse(equ_box.Text, out temp))
                {
                    equ_box.Clear();
                    temp *= -1;
                    equ_box.Text = temp.ToString();
                }                
            }
        }
        //
        // delete button
        //
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (equ_box.Text.Length > 0 && !error)
            {
                string temp = equ_box.Text;
                equ_box.Clear();
                equ_box.Text = temp.Remove(temp.Length - 1);
            }
        }
        //
        // clear button
        //
        private void btn_clr_Click(object sender, EventArgs e)
        {
            equ_box.Clear();
            num1_box.Clear();
            char_box.Clear();
            num2_box.Clear();
            noCharacterChoosen();
            equClick = 0;
            error = false;
        }
        //
        // addition button
        //
        private void btn_plu_Click(object sender, EventArgs e)
        {
            if(!error)
            {
                noCharacterChoosen();
                isAdd = true;
                btn_plu.BackColor = Color.Green;
                numOne = equ_box.Text;
                num1_box.Text = numOne;
                char_box.Text = btn_plu.Text;
                equ_box.Clear();
            }            
        }
        //
        // substraction button
        //
        private void btn_min_Click(object sender, EventArgs e)
        {
            if(!error)
            {
                noCharacterChoosen();
                isSub = true;
                btn_min.BackColor = Color.Green;
                numOne = equ_box.Text;
                num1_box.Text = numOne;
                char_box.Text = btn_min.Text;
                equ_box.Clear();
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        //
        // multiplication
        //
        private void btn_mul_Click(object sender, EventArgs e)
        {
            if(!error)
            {
                noCharacterChoosen();
                isMul = true;
                btn_mul.BackColor = Color.Green;
                numOne = equ_box.Text;
                num1_box.Text = numOne;
                char_box.Text = btn_mul.Text;
                equ_box.Clear();
            }
        }
        //
        // division button
        //
        private void btn_div_Click(object sender, EventArgs e)
        {
            if(!error)
            {
                noCharacterChoosen();
                isDiv = true;
                btn_div.BackColor = Color.Green;
                numOne = equ_box.Text;
                num1_box.Text = numOne;
                char_box.Text = btn_div.Text;
                equ_box.Clear();
            }
        }
        //
        // power button
        //
        private void btn_pow_Click(object sender, EventArgs e)
        {
            if(!error)
            {
                noCharacterChoosen();
                isPow = true;
                btn_pow.BackColor = Color.Green;
                numOne = equ_box.Text;
                num1_box.Text = numOne;
                char_box.Text = btn_pow.Text;
                equ_box.Clear();
            }
        }
        //
        // square root button
        //
        private void btn_sqr_Click(object sender, EventArgs e)
        {
            if(!error)
            {
                if (equ_box.Text.Length > 0)
                {
                    noCharacterChoosen();
                    isSqr = true;
                    btn_sqr.BackColor = Color.Green;
                    numOne = equ_box.Text;
                    double num1 = double.Parse(numOne);
                    if(num1 >= 0)
                    {
                        double result = Math.Sqrt(num1);
                        equ_box.Clear();
                        num1_box.Clear();
                        num2_box.Text = numOne;
                        char_box.Text = btn_sqr.Text;
                        equ_box.Text = result.ToString();
                    }
                    else
                    {
                        equ_box.Text = "Error!";
                        error = true;
                        grayButtons();
                    }
                }
                else
                    btn_sqr.BackColor = Color.Gray;
            }
        }
        //
        // modulo button
        //
        private void btn_mod_Click(object sender, EventArgs e)
        {
            if(!error)
            {
                noCharacterChoosen();
                isMod = true;
                btn_mod.BackColor = Color.Green;
                numOne = equ_box.Text;
                num1_box.Text = numOne;
                char_box.Text = "%";
                equ_box.Clear();
            }
        }
        //
        // equals button
        //
        private void btn_equ_Click(object sender, EventArgs e)
        {
            if(!error)
            {
                double num1 = 0, num2 = 0;
                if (equClick == 0)
                {
                    numTwo = equ_box.Text;
                    num2_box.Text = numTwo;
                }               
                else
                {
                    numOne = equ_box.Text;
                    num1_box.Text = numOne;
                    num2_box.Text = numTwo;
                }
                if (double.TryParse(numOne, out num1) && double.TryParse(numTwo, out num2))
                {
                    equ_box.Clear();
                    num1 = double.Parse(numOne);
                    num2 = double.Parse(numTwo);
                }
                if (isAdd)
                    equ_box.Text = (num1 + num2).ToString();
                else if (isSub)
                    equ_box.Text = (num1 - num2).ToString();
                else if (isMul)
                    equ_box.Text = (num1 * num2).ToString();
                else if (isDiv)
                {
                    if (num2 != 0)
                        equ_box.Text = (num1 / num2).ToString();
                    else
                    {
                        equ_box.Text = "Error!";
                        error = true;
                        grayButtons();
                    }
                }
                else if (isPow)
                    equ_box.Text = Math.Pow(num1, num2).ToString();
                else if (isSqr)
                    equ_box.Text = numTwo;
                else if (isMod)
                    equ_box.Text = (num1 % num2).ToString();

                equClick++;
            }
        }
    }
}