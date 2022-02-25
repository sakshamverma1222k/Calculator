using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        float iCelsius, iFahrenheit, iKelvin;
        Char iOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            labelnum.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 287;//329;
            textDisplay.Width = 248;//331;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 626;
            textDisplay.Width = 496;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            double cosinq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("cosin" + "(" + (textDisplay.Text) + ")");
            cosinq = 1 / Math.Sinh(cosinq);
            textDisplay.Text = System.Convert.ToString(cosinq);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 939;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1240;
        }

        private void Number_click(object sender, EventArgs e)
        {
            if ((textDisplay.Text.Contains("Calculator")) || (enter_value))
                textDisplay.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                    textDisplay.Text = textDisplay.Text + num.Text;
            }
            else
                textDisplay.Text = textDisplay.Text + num.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            labelnum.Text = "";
        }

        private void BackSpace_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
            if (textDisplay.Text=="")
            {
                textDisplay.Text = "0";
            }
        }

        private void ArithmeticOp(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(textDisplay.Text);
            textDisplay.Text = "";
            labelnum.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            labelnum.Text = "";
            switch (operation)
            {
                case "+":
                    textDisplay.Text = (result + Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "-":
                    textDisplay.Text = (result - Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "*":
                    textDisplay.Text = (result * Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "/":
                    textDisplay.Text = (result / Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "Mod":
                    textDisplay.Text = (result % Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(textDisplay.Text);
                    double q;
                    q = (result);
                    textDisplay.Text = Math.Exp(i * Math.Log(q*4)).ToString();
                    break;
                case "?=":
                    break;
            }
        }

        private void PiButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "3.1415926535897932384626338";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("log" + "(" + (textDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            textDisplay.Text = System.Convert.ToString(ilog);
        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Sqrt" + "(" + (textDisplay.Text) + ")");
            sqrt = Math.Sqrt(sqrt);
            textDisplay.Text = System.Convert.ToString(sqrt);
        }

        private void CubeRoot_Click(object sender, EventArgs e)
        {
            double cbrt = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Cbrt" + "(" + (textDisplay.Text) + ")");
            cbrt = Math.Pow(cbrt, (double) 1/3);
            textDisplay.Text = System.Convert.ToString(cbrt);
        }

        private void Binary_Click(object sender, EventArgs e)
        {
            int bnr = int.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Bin" + "(" + (textDisplay.Text) + ")");
            textDisplay.Text = System.Convert.ToString(bnr, 2);
        }

        private void SinH_Click(object sender, EventArgs e)
        {
            double sinhq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Sinh" + "(" + (textDisplay.Text) + ")");
            sinhq = Math.Sinh(sinhq);
            textDisplay.Text = System.Convert.ToString(sinhq);
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            double sinq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Sin" + "(" + (textDisplay.Text) + ")");
            sinq = Math.Sin(sinq);
            textDisplay.Text = System.Convert.ToString(sinq);
        }

        private void Deg_Click(object sender, EventArgs e)
        {
            String q = labelnum.Text;
            int pFrom = q.IndexOf("(");
            string qf = q.Substring(0, pFrom);
            int qTo = q.LastIndexOf(")");
            double res = Double.Parse(q.Substring(pFrom + 1, qTo - pFrom - 1));
            double nres = res * 3.1415926535897932384626338 / 180;
            labelnum.Text = System.Convert.ToString(qf +"(" +nres+ ")");
            double resu;
            switch (qf)
            {
                case "Sin":
                    resu = Math.Sin(nres);
                    textDisplay.Text = System.Convert.ToString(resu); 
                    break;
                case "Sinh":
                    resu = Math.Sinh(nres);
                    textDisplay.Text = System.Convert.ToString(resu); 
                    break;
                case "Cos":
                    resu = Math.Cos(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Cosh":
                    resu = Math.Cosh(nres);
                    textDisplay.Text = System.Convert.ToString(resu); 
                    break;
                case "Tan":
                    resu = Math.Tan(nres);
                    textDisplay.Text = System.Convert.ToString(resu); 
                    break;
                case "Tanh":
                    resu = Math.Tanh(nres);
                    textDisplay.Text = System.Convert.ToString(resu); 
                    break;
                case "Cot":
                    resu = 1/Math.Tan(nres);
                    textDisplay.Text = System.Convert.ToString(resu); 
                    break;
                case "Coth":
                    resu = 1/Math.Tanh(nres);
                    textDisplay.Text = System.Convert.ToString(resu); 
                    break;
                case "Sec":
                    resu = 1/Math.Cos(nres);
                    textDisplay.Text = System.Convert.ToString(resu); 
                    break;
                case "Sech":
                    resu = 1/Math.Cosh(nres);
                    textDisplay.Text = System.Convert.ToString(resu); 
                    break;
                case "Cosec":
                    resu = 1/Math.Sin(nres);
                    textDisplay.Text = System.Convert.ToString(resu); 
                    break;
                case "Cosech":
                    resu = 1/Math.Sinh(nres);
                    textDisplay.Text = System.Convert.ToString(resu); 
                    break;
            }
        }

        private void Rad_Click(object sender, EventArgs e)
        {
            String q = labelnum.Text;
            int pFrom = q.IndexOf("(");
            string qf = q.Substring(0, pFrom);
            int qTo = q.LastIndexOf(")");
            double res = Double.Parse(q.Substring(pFrom + 1, qTo - pFrom - 1));
            double nres = res / 3.1415926535897932384626338 * 180;
            labelnum.Text = System.Convert.ToString(qf + "(" + nres + ")");
            double resu;
            switch (qf)
            {
                case "Sin":
                    resu = Math.Sin(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Sinh":
                    resu = Math.Sinh(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Cos":
                    resu = Math.Cos(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Cosh":
                    resu = Math.Cosh(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Tan":
                    resu = Math.Tan(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Tanh":
                    resu = Math.Tanh(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Cot":
                    resu = 1 / Math.Tan(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Coth":
                    resu = 1 / Math.Tanh(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Sec":
                    resu = 1 / Math.Cos(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Sech":
                    resu = 1 / Math.Cosh(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Cosec":
                    resu = 1 / Math.Sin(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
                case "Cosech":
                    resu = 1 / Math.Sinh(nres);
                    textDisplay.Text = System.Convert.ToString(resu);
                    break;
            }
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double cosq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Cos" + "(" + (textDisplay.Text) + ")");
            cosq = Math.Cos(cosq);
            textDisplay.Text = System.Convert.ToString(cosq);
        }

        private void CosH_Click(object sender, EventArgs e)
        {
            double coshq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Cosh" + "(" + (textDisplay.Text) + ")");
            coshq = Math.Cosh(coshq);
            textDisplay.Text = System.Convert.ToString(coshq);
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double tanq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Tan" + "(" + (textDisplay.Text) + ")");
            tanq = Math.Tan(tanq);
            textDisplay.Text = System.Convert.ToString(tanq);
        }

        private void TanH_Click(object sender, EventArgs e)
        {
            double tanhq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Tanh" + "(" + (textDisplay.Text) + ")");
            tanhq = Math.Tanh(tanhq);
            textDisplay.Text = System.Convert.ToString(tanhq);
        }

        private void CosinH_Click(object sender, EventArgs e)
        {
            double cosinhq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Cosinh" + "(" + (textDisplay.Text) + ")");
            cosinhq = 1 / Math.Sinh(cosinhq);
            textDisplay.Text = System.Convert.ToString(cosinhq);
        }

        private void Sec_Click(object sender, EventArgs e)
        {
            double secq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Sec" + "(" + (textDisplay.Text) + ")");
            secq = 1 / Math.Sinh(secq);
            textDisplay.Text = System.Convert.ToString(secq);
        }

        private void SecH_Click(object sender, EventArgs e)
        {
            double sechq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Sech" + "(" + (textDisplay.Text) + ")");
            sechq = 1 / Math.Sinh(sechq);
            textDisplay.Text = System.Convert.ToString(sechq);
        }

        private void CotH_Click(object sender, EventArgs e)
        {
            double cothq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Coth" + "(" + (textDisplay.Text) + ")");
            cothq = 1 / Math.Sinh(cothq);
            textDisplay.Text = System.Convert.ToString(cothq);
        }

        private void Cot_Click(object sender, EventArgs e)
        {
            double cotq = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Cot" + "(" + (textDisplay.Text) + ")");
            cotq = 1 / Math.Sinh(cotq);
            textDisplay.Text = System.Convert.ToString(cotq);
        }

        private void Octa_Click(object sender, EventArgs e)
        {
            int oct = int.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Oct" + "(" + (textDisplay.Text) + ")");
            textDisplay.Text = System.Convert.ToString(oct, 8);
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            int dec = int.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Dec" + "(" + (textDisplay.Text) + ")");
            textDisplay.Text = System.Convert.ToString(dec, 10);
        }

        private void Hexadecimal_Click(object sender, EventArgs e)
        {
            int hex = int.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Hex" + "(" + (textDisplay.Text) + ")");
            textDisplay.Text = System.Convert.ToString(hex, 16);
        }

        private void Power_Click(object sender, EventArgs e)
        {
            Double pow = double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Pow:" + (textDisplay.Text) + "^?");
            textDisplay.Text = "?=";
        }

        private void button17_Click(object nsender, EventArgs ee, double pow)
        {
            int resu = 1;
            int powr = int.Parse(System.Convert.ToString(pow));
            Double outp = double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Pow:" + pow + "^" + outp);
            for (int i = 0; outp > i; i++)
                resu = resu * powr;
            textDisplay.Text = System.Convert.ToString(resu);
        }

        private void inverse_Click(object sender, EventArgs e)
        {
            double invs = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("Invs" + "(" + (textDisplay.Text) + ")");
            invs = 1/(invs);
            textDisplay.Text = System.Convert.ToString(invs);
        }
        
        private void NaturalLog_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textDisplay.Text);
            labelnum.Text = System.Convert.ToString("log" + "(" + (textDisplay.Text) + ")");
            ilog = Math.Log(ilog);
            textDisplay.Text = System.Convert.ToString(ilog);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 287;
            textDisplay.Width = 248;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 626;
            textDisplay.Width = 496;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 939;
            textDisplay.Width = 496;
        }

        private void textDisplaySmallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textDisplay.Width = 248;
        }

        private void textDisplayLargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textDisplay.Width = 496;
        }

        private void CellToFah_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void button23_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            { 
                case 'C':
                    iCelsius = float.Parse(textToConvert.Text);
                    lblConverted.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;
                case 'F':
                    iFahrenheit = float.Parse(textToConvert.Text);
                    lblConverted.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break ;
                case 'K':
                    iKelvin = float.Parse(textToConvert.Text);
                    lblConverted.Text = ((((9 * iKelvin) / 5) + 32) + 273.15).ToString();
                    break ;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            float x = float.Parse(lblConverted.Text);
            textToConvert.Text = x.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textToConvert.Text = "";
            lblConverted.Text = "";
            FahToCel.Checked = false;
            CellToFah.Checked = false;
            CelToKel.Checked = false;
        }

        private void FahToCel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void CelToKel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }
    }
}