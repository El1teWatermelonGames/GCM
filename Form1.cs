using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

        List<string> comboList;

        public Form1()
        {
            InitializeComponent();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settings panelSettings = new Settings();
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
            if (!Directory.Exists(Settings.appDataFolder)) Directory.CreateDirectory(Settings.appDataFolder);
            if (!File.Exists(Settings.precisionBoolFile)) File.WriteAllText(Settings.precisionBoolFile, "false");
            if (!File.Exists(Settings.usePrecisionFile)) File.WriteAllText(Settings.usePrecisionFile, "false");
            if (!File.Exists(Settings.lastIndex))
            {
                File.Create(Settings.lastIndex).Close();
                File.WriteAllText(Settings.lastIndex, "0");
            }
            if (!File.Exists(Settings.comboBoxItems))
            {
                File.Create(Settings.comboBoxItems).Close();
                File.WriteAllText(Settings.comboBoxItems, "Custom Preset");
            }
            bool.TryParse(File.ReadAllText(Settings.precisionBoolFile), out bool precisionSave);
            bool.TryParse(File.ReadAllText(Settings.usePrecisionFile), out bool usePrecisionSave);
            if (precisionSave)
            {
                int.TryParse(File.ReadAllText(Settings.precisionFile), out int resultP);
                precision = resultP;
            }
            if (usePrecisionSave) Rounding = true;

            comboList = File.ReadLines(Settings.comboBoxItems).ToList();
            int.TryParse(File.ReadAllText(Settings.lastIndex), out int index);
            decimal.TryParse(Regex.Match(comboList[index], @"\d+.+\d").Value, out Form1.density);
        }
    }
}
