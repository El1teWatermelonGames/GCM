using System;
using System.Windows.Forms;
using System.IO;

namespace GCM
{
    public partial class Form1 : Form
    {


        static public decimal density;
        static public int precision;
        static public bool Rounding;

        public decimal cmResult;
        public decimal gResult;

        public decimal gCalc;
        public decimal cmCalc;

        public Form1()
        {
            InitializeComponent();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Form2 panelSettings = new Form2();
            panelSettings.ShowDialog();
        }

        private void gramsIn_TextChanged(object sender, EventArgs e)
        {
            gramsIn.KeyPress += new KeyPressEventHandler(CheckEnterKeyPressGIn);
            bool isNumeric = decimal.TryParse(gramsIn.Text, out gCalc);
            if (!isNumeric)
            {
                gramsIn.Text = "";
                convertCm.Enabled = false;
            }
            else
            {
                convertCm.Enabled = true;
            }
        }

        private void CheckEnterKeyPressGIn(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (!Rounding) cmResult = gCalc / density;
                else cmResult = decimal.Round(gCalc / density, precision, MidpointRounding.AwayFromZero);
                cmOut.Text = cmResult.ToString();
                e.Handled = true;
            }
        }

        private void convertCm_Click(object sender, EventArgs e)
        {
            if(!Rounding) cmResult = gCalc / density;
            else cmResult = decimal.Round(gCalc / density, precision, MidpointRounding.AwayFromZero);
            cmOut.Text = cmResult.ToString();
        }

        private void cmOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmIn_TextChanged(object sender, EventArgs e)
        {
            cmIn.KeyPress += new KeyPressEventHandler(CheckEnterKeyPressCmIn);
            bool isNumeric = decimal.TryParse(cmIn.Text, out cmCalc);
            if (!isNumeric)
            {
                cmIn.Text = "";
                convertG.Enabled = false;
            }
            else
            {
                convertG.Enabled = true;
            }
        }

        private void CheckEnterKeyPressCmIn(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (!Rounding) gResult = cmCalc * density;
                else gResult = decimal.Round(cmCalc * density, precision, MidpointRounding.AwayFromZero);
                gOut.Text = gResult.ToString();
                e.Handled = true;
            }
        }

        private void convertG_Click(object sender, EventArgs e)
        {
            if (!Rounding) gResult = cmCalc * density;
            else gResult = decimal.Round(cmCalc * density, precision, MidpointRounding.AwayFromZero);
            gOut.Text = gResult.ToString();
        }

        private void gOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Form2.densityBoolFile)) File.WriteAllText(Form2.densityBoolFile, "false");
            if (!File.Exists(Form2.precisionBoolFile)) File.WriteAllText(Form2.precisionBoolFile, "false");
            if (!File.Exists(Form2.usePrecisionFile)) File.WriteAllText(Form2.usePrecisionFile, "false");
            bool.TryParse(File.ReadAllText(Form2.densityBoolFile), out bool densitySave);
            bool.TryParse(File.ReadAllText(Form2.precisionBoolFile), out bool precisionSave);
            bool.TryParse(File.ReadAllText(Form2.usePrecisionFile), out bool usePrecisionSave);
            if (densitySave)
            {
                decimal.TryParse(File.ReadAllText(Form2.densityFile), out decimal resultD);
                density = resultD;
            }
            if (precisionSave)
            {
                int.TryParse(File.ReadAllText(Form2.precisionFile), out int resultP);
                precision = resultP;
            }
            if (usePrecisionSave) Rounding = true;
        }
    }
}
