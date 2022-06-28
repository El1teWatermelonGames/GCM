
namespace GCM
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboDensity = new System.Windows.Forms.ComboBox();
            this.newDensity = new System.Windows.Forms.Button();
            this.deleteDensity = new System.Windows.Forms.Button();
            this.inputDensity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usePrecisionSave = new System.Windows.Forms.CheckBox();
            this.savePrecision = new System.Windows.Forms.Button();
            this.precisionIn = new System.Windows.Forms.TextBox();
            this.useRounding = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Density (g/cm³)";
            // 
            // comboDensity
            // 
            this.comboDensity.FormattingEnabled = true;
            this.comboDensity.Location = new System.Drawing.Point(264, 10);
            this.comboDensity.Name = "comboDensity";
            this.comboDensity.Size = new System.Drawing.Size(121, 21);
            this.comboDensity.TabIndex = 1;
            this.comboDensity.SelectedIndexChanged += new System.EventHandler(this.comboDensity_SelectedIndexChanged);
            // 
            // newDensity
            // 
            this.newDensity.Location = new System.Drawing.Point(98, 8);
            this.newDensity.Name = "newDensity";
            this.newDensity.Size = new System.Drawing.Size(75, 23);
            this.newDensity.TabIndex = 2;
            this.newDensity.Text = "New Preset";
            this.newDensity.UseVisualStyleBackColor = true;
            this.newDensity.Click += new System.EventHandler(this.newDensity_Click);
            // 
            // deleteDensity
            // 
            this.deleteDensity.Location = new System.Drawing.Point(179, 8);
            this.deleteDensity.Name = "deleteDensity";
            this.deleteDensity.Size = new System.Drawing.Size(79, 23);
            this.deleteDensity.TabIndex = 3;
            this.deleteDensity.Text = "Delete Preset";
            this.deleteDensity.UseVisualStyleBackColor = true;
            this.deleteDensity.Click += new System.EventHandler(this.deleteDensity_Click);
            // 
            // inputDensity
            // 
            this.inputDensity.Location = new System.Drawing.Point(391, 10);
            this.inputDensity.Name = "inputDensity";
            this.inputDensity.ReadOnly = true;
            this.inputDensity.Size = new System.Drawing.Size(100, 20);
            this.inputDensity.TabIndex = 4;
            this.inputDensity.TextChanged += new System.EventHandler(this.inputDensity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Decimal Places";
            // 
            // usePrecisionSave
            // 
            this.usePrecisionSave.AutoSize = true;
            this.usePrecisionSave.Location = new System.Drawing.Point(330, 38);
            this.usePrecisionSave.Name = "usePrecisionSave";
            this.usePrecisionSave.Size = new System.Drawing.Size(56, 17);
            this.usePrecisionSave.TabIndex = 19;
            this.usePrecisionSave.Text = "Preset";
            this.usePrecisionSave.UseVisualStyleBackColor = true;
            this.usePrecisionSave.CheckedChanged += new System.EventHandler(this.usePrecisionSave_CheckedChanged);
            // 
            // savePrecision
            // 
            this.savePrecision.Location = new System.Drawing.Point(214, 34);
            this.savePrecision.Name = "savePrecision";
            this.savePrecision.Size = new System.Drawing.Size(110, 23);
            this.savePrecision.TabIndex = 18;
            this.savePrecision.Text = "Save as preset";
            this.savePrecision.UseVisualStyleBackColor = true;
            this.savePrecision.Click += new System.EventHandler(this.savePrecision_Click);
            // 
            // precisionIn
            // 
            this.precisionIn.Location = new System.Drawing.Point(98, 36);
            this.precisionIn.Name = "precisionIn";
            this.precisionIn.Size = new System.Drawing.Size(110, 20);
            this.precisionIn.TabIndex = 17;
            this.precisionIn.TextChanged += new System.EventHandler(this.precisionIn_TextChanged);
            // 
            // useRounding
            // 
            this.useRounding.AutoSize = true;
            this.useRounding.Location = new System.Drawing.Point(392, 38);
            this.useRounding.Name = "useRounding";
            this.useRounding.Size = new System.Drawing.Size(94, 17);
            this.useRounding.TabIndex = 20;
            this.useRounding.Text = "Use Rounding";
            this.useRounding.UseVisualStyleBackColor = true;
            this.useRounding.CheckedChanged += new System.EventHandler(this.useRounding_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 61);
            this.Controls.Add(this.useRounding);
            this.Controls.Add(this.usePrecisionSave);
            this.Controls.Add(this.savePrecision);
            this.Controls.Add(this.precisionIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputDensity);
            this.Controls.Add(this.deleteDensity);
            this.Controls.Add(this.newDensity);
            this.Controls.Add(this.comboDensity);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "GCM Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDensity;
        private System.Windows.Forms.Button newDensity;
        private System.Windows.Forms.Button deleteDensity;
        private System.Windows.Forms.TextBox inputDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox usePrecisionSave;
        private System.Windows.Forms.Button savePrecision;
        private System.Windows.Forms.TextBox precisionIn;
        private System.Windows.Forms.CheckBox useRounding;
    }
}