using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        // Global variables
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        float varCelsius, varFahrenheit, varKelvin;
        char varOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 330;
            calcInputBox.Width = 285;
        }

        // Methods for menu strip items
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 328;
            calcInputBox.Width = 285;
        }
        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 632;
            calcInputBox.Width = 588;
        }
        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1178;
            calcInputBox.Width = 588;
            txtTempInput.Focus();

            tempGroupBox.Visible = true;
            tempConvertGroupBox.Visible = true;
            multiplicationGBox.Visible = false;
        }
        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1050;
            calcInputBox.Width = 588;
            txtMultiply.Focus();
            // Setting other group boxes visibility to false
            tempConvertGroupBox.Visible = false;
            tempGroupBox.Visible = false;
            // Setting multiplication group box visible
            multiplicationGBox.Visible = true;
            // Settin up multiplication group box location
            multiplicationGBox.Location = new Point(620, 31);
            multiplicationGBox.Width = 394;
            multiplicationGBox.Height = 401;
        }

        // Method for number button click action
        private void numButton_Click(object sender, EventArgs e)
        {
            if ((calcInputBox.Text == "0") || (enter_value))
            {
                calcInputBox.Text = "";
            }
            enter_value = false;
            Button btnNum = (Button)sender;

            if(btnNum.Text == ".")
            {
                if (!calcInputBox.Text.Contains("."))
                {
                    calcInputBox.Text = calcInputBox.Text + btnNum.Text;
                }
            }
            else
            {
                calcInputBox.Text = calcInputBox.Text + btnNum.Text;
            }
        }

        // Method for number CE click action
        private void btnCE_Click(object sender, EventArgs e)
        {
            calcInputBox.Text = "0";
            lblShowOp.Text = "";
        }

        // Method for C button click action
        private void btnC_Click(object sender, EventArgs e)
        {
            calcInputBox.Text = "0";
            lblShowOp.Text = "";
        }

        // Method for backspace button click action
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if(calcInputBox.Text.Length > 0)
            {
                calcInputBox.Text = calcInputBox.Text.Remove(calcInputBox.Text.Length - 1, 1);
            }

            if(calcInputBox.Text == "")
            {
                calcInputBox.Text = "0";
            }
        }

        // Method for arithmetic operator
        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button btnNum = (Button)sender;
            operation = btnNum.Text;
            results = Double.Parse(calcInputBox.Text);
            calcInputBox.Text = "";
            lblShowOp.Text = System.Convert.ToString(results) + " " + operation; 
        }

        // Method for = button
        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch (operation)
            {
                case "+":
                    calcInputBox.Text = (results + Double.Parse(calcInputBox.Text)).ToString();
                    break;
                case "-":
                    calcInputBox.Text = (results - Double.Parse(calcInputBox.Text)).ToString();
                    break;
                case "*":
                    calcInputBox.Text = (results * Double.Parse(calcInputBox.Text)).ToString();
                    break;
                case "/":
                    calcInputBox.Text = (results / Double.Parse(calcInputBox.Text)).ToString();
                    break;
                case "Mod":
                    calcInputBox.Text = (results % Double.Parse(calcInputBox.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(calcInputBox.Text);
                    double q;
                    q = (results);
                    calcInputBox.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        // Method for pi button
        private void btnPi_Click(object sender, EventArgs e)
        {
            calcInputBox.Text = "3.141592653589976323";
        }

        // Log button handler
        private void btnLog_Click(object sender, EventArgs e)
        {
            double iLog = Double.Parse(calcInputBox.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + calcInputBox.Text + ")");
            iLog = Math.Log10(iLog);
            calcInputBox.Text = System.Convert.ToString(iLog);
        }

        // Sqrt button handler
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(calcInputBox.Text);
            lblShowOp.Text = System.Convert.ToString("sqrt" + "(" + calcInputBox.Text + ")");
            sq = Math.Sqrt(sq);
            calcInputBox.Text = System.Convert.ToString(sq);
        }

        // Sinh button handler
        private void btnSinh_Click(object sender, EventArgs e)
        {
            double numSinh = Double.Parse(calcInputBox.Text);
            lblShowOp.Text = System.Convert.ToString("sinh" + "(" + calcInputBox.Text + ")");
            numSinh = Math.Sinh(numSinh);
            calcInputBox.Text = System.Convert.ToString(numSinh);
        }

        // Sin button handler
        private void btnSin_Click(object sender, EventArgs e)
        {
            double numSin = Double.Parse(calcInputBox.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + calcInputBox.Text + ")");
            numSin = Math.Sin(numSin);
            calcInputBox.Text = System.Convert.ToString(numSin);
        }

        // Cosh button handler
        private void btnCosh_Click(object sender, EventArgs e)
        {
            double numCosh = Double.Parse(calcInputBox.Text);
            lblShowOp.Text = System.Convert.ToString("cosh" + "(" + calcInputBox.Text + ")");
            numCosh = Math.Cosh(numCosh);
            calcInputBox.Text = System.Convert.ToString(numCosh);
        }

        // Cos button handler
        private void btnCos_Click(object sender, EventArgs e)
        {
            double numCos = Double.Parse(calcInputBox.Text);
            lblShowOp.Text = System.Convert.ToString("cos" + "(" + calcInputBox.Text + ")");
            numCos = Math.Cos(numCos);
            calcInputBox.Text = System.Convert.ToString(numCos);
        }

        // Tanh button handler
        private void btnTanh_Click(object sender, EventArgs e)
        {
            double numTanh = Double.Parse(calcInputBox.Text);
            lblShowOp.Text = System.Convert.ToString("tanh" + "(" + calcInputBox.Text + ")");
            numTanh = Math.Tanh(numTanh);
            calcInputBox.Text = System.Convert.ToString(numTanh);
        }

        // Tan button handler
        private void btnTan_Click(object sender, EventArgs e)
        {
            double numTan = Double.Parse(calcInputBox.Text);
            lblShowOp.Text = System.Convert.ToString("tan" + "(" + calcInputBox.Text + ")");
            numTan = Math.Tan(numTan);
            calcInputBox.Text = System.Convert.ToString(numTan);
        }

        // Bin button handler
        private void btnBin_Click(object sender, EventArgs e)
        {
            int numBin = int.Parse(calcInputBox.Text);
            calcInputBox.Text = System.Convert.ToString(numBin, 2);
        }

        // Hex button handler
        private void btnHex_Click(object sender, EventArgs e)
        {
            int numHex = int.Parse(calcInputBox.Text);
            calcInputBox.Text = System.Convert.ToString(numHex, 16);
        }

        // Oct button handler
        private void btnOct_Click(object sender, EventArgs e)
        {
            int numOct = int.Parse(calcInputBox.Text);
            calcInputBox.Text = System.Convert.ToString(numOct, 8);
        }

        // x^2 button handler
        private void btnX2_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(calcInputBox.Text) * Convert.ToDouble(calcInputBox.Text);
            calcInputBox.Text = System.Convert.ToString(num);
        }

        // x^3 button handler
        private void btnX3_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(calcInputBox.Text) * Convert.ToDouble(calcInputBox.Text) * Convert.ToDouble(calcInputBox.Text);
            calcInputBox.Text = System.Convert.ToString(num);
        }

        // 1/x button handler
        private void btn1X_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(1.0 / Convert.ToDouble(calcInputBox.Text));
            calcInputBox.Text = System.Convert.ToString(num);
        }

        // ln x button handler
        private void btnLnX_Click(object sender, EventArgs e)
        {
            double iLnx = Double.Parse(calcInputBox.Text);
            lblShowOp.Text = System.Convert.ToString("ln" + "(" + calcInputBox.Text + ")");
            iLnx = Math.Log(iLnx);
            calcInputBox.Text = System.Convert.ToString(iLnx);
        }

        // % button handler
        private void btnPercent_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(calcInputBox.Text) / Convert.ToDouble(100);
            calcInputBox.Text = System.Convert.ToString(num);
        }

        // Radio button handlers
        private void radioCtoF_CheckedChanged(object sender, EventArgs e)
        {
            varOperation = 'C';
        }

        private void radioFtoC_CheckedChanged(object sender, EventArgs e)
        {
            varOperation = 'F';
        }


        private void radioK_CheckedChanged(object sender, EventArgs e)
        {
            varOperation = 'K';
        }

        // Multiply button handler
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtMultiply.Text);
            for (int i = 1; i < 13; i++)
            {
                lstMultiply.Items.Add(i + " X " + num + " = " + num * i);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Multiplication Reset button handler
        private void btnResetM_Click(object sender, EventArgs e)
        {
            lstMultiply.Items.Clear();
            txtMultiply.Clear();
        }

        // Convert button handler
        private void btnConvertTemp_Click(object sender, EventArgs e)
        {
            switch(varOperation)
            {
                case 'C':
                    // Celsius to Fahrenheit
                    varCelsius = float.Parse(txtTempInput.Text);
                    lblTempResultShow.Text = ((((9 * varCelsius) / 5) + 32).ToString());
                    break;
                case 'F':
                    // Fahrenheit to Celsius
                    varFahrenheit = float.Parse(txtTempInput.Text);
                    lblTempResultShow.Text = (((varFahrenheit - 32) * 0.5556).ToString());
                    break;
                case 'K':
                    // Convert to Kelvin
                    varKelvin = float.Parse(txtTempInput.Text);
                    lblTempResultShow.Text = (((((9 * varKelvin) / 5) + 32) + 273.15).ToString());
                    break;
            }
        }
        
        // Reset button handler
        private void btnResetTemp_Click(object sender, EventArgs e)
        {
            txtTempInput.Clear();
            lblTempResultShow.Text = "";
            radioCtoF.Checked = false;
            radioFtoC.Checked = false;
            radioK.Checked = false;
        }
    }
}
