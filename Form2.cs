using System;
using System.Windows.Forms;
using System.IO;

namespace GCM
{
    public partial class Form2 : Form
    {
        // The strings that contain all the required directories and file paths
        static public string root = Directory.GetCurrentDirectory()+@"\presets";
        static public string densityFile = Directory.GetCurrentDirectory()+@"\presets\density.txt";
        static public string precisionFile = Directory.GetCurrentDirectory()+@"\presets\precision.txt";
        static public string densityBoolFile = Directory.GetCurrentDirectory()+@"\presets\densityBool.txt";
        static public string precisionBoolFile = Directory.GetCurrentDirectory()+@"\presets\precisionBool.txt";
        static public string usePrecisionFile = Directory.GetCurrentDirectory() + @"\presets\usePrecision.txt";

        public Form2()
        {
            InitializeComponent();
        }

        private void densityIn_TextChanged(object sender, EventArgs e)
        {
            // Every time the text is changed TryParse it to a decimal if it fails to parse clear the box
            bool isNumeric = decimal.TryParse(densityIn.Text, out Form1.density);
            if(!isNumeric)densityIn.Text="";
        }

        private void saveDensity_Click(object sender, EventArgs e)
        {
            // Overwrite all text in the save file with the new decimal
            File.WriteAllText(densityFile, densityIn.Text);
        }

        private void useDensitySave_CheckedChanged(object sender, EventArgs e)
        {
            if (useDensitySave.Checked)
            {
                // Get the new density and change the input box so it displays the density preset in use and make it read only
                string preDensity = File.ReadAllText(densityFile);
                densityIn.ReadOnly = true;
                densityIn.Text = preDensity;
                // Save the current status of the check box to a file
                File.WriteAllText(densityBoolFile, "true");
            }
            else
            {
                // Clear the input text box and make it editable again
                densityIn.Text = "";
                densityIn.ReadOnly = false;
                // Save the current status of the check box to a file
                File.WriteAllText(densityBoolFile, "false");
            }
        }

        private void precisionIn_TextChanged(object sender, EventArgs e)
        {
            // Every time the text is changed TryParse it to an int, if it fails to parse clear the input box
            bool isNumeric = int.TryParse(precisionIn.Text, out Form1.precision);
            if (!isNumeric) precisionIn.Text = "";
        }

        private void savePrecision_Click(object sender, EventArgs e)
        {
            // Overwrite all text in the save file with the new int
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

        private void Form2_Load(object sender, EventArgs e)
        {
            // Check if the required files exist, if not then create them
            if (!Directory.Exists(root)) Directory.CreateDirectory(root);
            if (!File.Exists(densityFile))
            {
                var recentFile = File.Create(densityFile);
                recentFile.Close();
            }
            if (!File.Exists(precisionFile))
            {
                var recentFile = File.Create(precisionFile);
                recentFile.Close();
            }
            if (!File.Exists(densityBoolFile)) File.WriteAllText(densityBoolFile, "false");
            if (!File.Exists(precisionBoolFile)) File.WriteAllText(precisionBoolFile, "false");
            if (!File.Exists(usePrecisionFile)) File.WriteAllText(usePrecisionFile, "false");

            // Load the bools from previous session
            bool.TryParse(File.ReadAllText(densityBoolFile), out bool densitySave);
            bool.TryParse(File.ReadAllText(precisionBoolFile), out bool precisionSave);
            bool.TryParse(File.ReadAllText(usePrecisionFile), out bool usePrecision);
            useDensitySave.Checked = densitySave;
            usePrecisionSave.Checked = precisionSave;
            useRounding.Checked = usePrecision;
        }

        private void useRounding_CheckedChanged(object sender, EventArgs e)
        {
            if (!useRounding.Checked)
            {
                Form1.Rounding = false;
                File.WriteAllText(usePrecisionFile, "false");
            }
            else
            {
                Form1.Rounding = true;
                File.WriteAllText(usePrecisionFile, "true");
            }
        }
    }
}
