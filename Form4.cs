using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCM
{
    public partial class Form4 : Form
    {
        static public string addToCombo;
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void valueInput_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = decimal.TryParse(valueInput.Text, out decimal valueDeci);
            if (!isNumeric) valueInput.Text = "";
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Settings.addToCombo = NameInput.Text + " | " + valueInput.Text;
            this.Close();
        }
    }
}
