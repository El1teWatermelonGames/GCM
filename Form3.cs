using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GCM
{
    public partial class Settings : Form
    {
        static public string addToCombo;

        static public string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EliteWatermelonGames.GCM";
        static public string comboBoxItems = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EliteWatermelonGames.GCM\comboBoxItems.gcmp";
        static public string lastIndex = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EliteWatermelonGames.GCM\lastIndex.gcmp";
        static public string precisionFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EliteWatermelonGames.GCM\precision.gcmp";
        static public string precisionBoolFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EliteWatermelonGames.GCM\precisionBool.gcmp";
        static public string usePrecisionFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EliteWatermelonGames.GCM\usePrecision.gcmp";

        List<string> comboList;

        public Settings()
        {
            InitializeComponent();

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(appDataFolder)) Directory.CreateDirectory(appDataFolder);
            if (!File.Exists(comboBoxItems))
            {
                File.Create(comboBoxItems).Close();
                File.WriteAllText(comboBoxItems, "Custom Preset");
            }
            if (!File.Exists(lastIndex))
            {
                File.Create(lastIndex).Close();
                File.WriteAllText(lastIndex, "0");
            }
            if (!File.Exists(precisionFile))
            {
                var recentFile = File.Create(precisionFile);
                recentFile.Close();
            }
            if (!File.Exists(precisionBoolFile)) File.WriteAllText(precisionBoolFile, "false");
            if (!File.Exists(usePrecisionFile)) File.WriteAllText(usePrecisionFile, "false");
            bool.TryParse(File.ReadAllText(precisionBoolFile), out bool precisionSave);
            bool.TryParse(File.ReadAllText(usePrecisionFile), out bool usePrecision);
            usePrecisionSave.Checked = precisionSave;
            useRounding.Checked = usePrecision;

            comboList = File.ReadLines(comboBoxItems).ToList();
            for(int i = 0; i < comboList.Count; i++)
            {
                comboDensity.Items.Add(comboList[i]);
            }
            int.TryParse(File.ReadAllLines(lastIndex)[0], out int changeIndex);
            comboDensity.SelectedIndex = changeIndex;
        }

        private void newDensity_Click(object sender, EventArgs e)
        {
            Form4 panelSettings = new Form4();
            panelSettings.ShowDialog();
            if(addToCombo == null)
            {
                return;
            }
            comboDensity.Items.Add(addToCombo);
            comboDensity.SelectedItem = addToCombo;
            comboList.Add(addToCombo);
            File.WriteAllLines(comboBoxItems, comboList);
        }

        private void deleteDensity_Click(object sender, EventArgs e)
        {
            comboList.Remove(comboDensity.Text);
            File.WriteAllLines(comboBoxItems, comboList);
            comboDensity.Items.Remove(comboDensity.SelectedItem);
        }

        private void comboDensity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDensity.SelectedItem.ToString() != "Custom Preset")
            {
                deleteDensity.Enabled = true;
                inputDensity.ReadOnly = true;
            }
            else
            {
                deleteDensity.Enabled = false;
                inputDensity.ReadOnly = false;
            }
            File.WriteAllText(lastIndex, comboDensity.SelectedIndex.ToString());
            decimal.TryParse(Regex.Match(comboDensity.Text.ToString(), @"\d+.+\d").Value, out Form1.density);
        }

        private void inputDensity_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = decimal.TryParse(inputDensity.Text, out Form1.density);
            if (!isNumeric) inputDensity.Text = "";
        }

        private void precisionIn_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Working");
            bool isNumeric = int.TryParse(precisionIn.Text, out Form1.precision);
            if (!isNumeric) precisionIn.Text = "";
        }

        private void savePrecision_Click(object sender, EventArgs e)
        {
            File.WriteAllText(precisionFile, precisionIn.Text);
        }

        private void usePrecisionSave_CheckedChanged(object sender, EventArgs e)
        {
            if (usePrecisionSave.Checked)
            {
                // Get the new precision and change the input box so it displays the density preset in use and make it read only
                string prePrecision = File.ReadAllText(precisionFile);
                precisionIn.ReadOnly = true;
                precisionIn.Text = prePrecision;
                // Save the current status of the check box to a file
                File.WriteAllText(precisionBoolFile, "true");
            }
            else
            {
                // Clear the input text box and make it editable again
                precisionIn.Text = "";
                precisionIn.ReadOnly = false;
                // Save the current status of the check box to a file
                File.WriteAllText(precisionBoolFile, "false");
            }
        }

        private void useRounding_CheckedChanged(object sender, EventArgs e)
        {
            if (!useRounding.Checked)
            {
                Form1.Rounding = false;
                File.WriteAllText(usePrecisionFile, "false");
                precisionIn.Enabled = false;
                savePrecision.Enabled = false;
                usePrecisionSave.Enabled = false;
            }
            else
            {
                Form1.Rounding = true;
                File.WriteAllText(usePrecisionFile, "true");
                precisionIn.Enabled = true;
                savePrecision.Enabled = true;
                usePrecisionSave.Enabled = true;
            }
        }
    }
}
