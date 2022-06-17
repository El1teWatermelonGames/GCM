
namespace GCM
{
    partial class Form2
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
            this.densityLabel = new System.Windows.Forms.Label();
            this.densityIn = new System.Windows.Forms.TextBox();
            this.saveDensity = new System.Windows.Forms.Button();
            this.useDensitySave = new System.Windows.Forms.CheckBox();
            this.precisionLabel = new System.Windows.Forms.Label();
            this.precisionIn = new System.Windows.Forms.TextBox();
            this.savePrecision = new System.Windows.Forms.Button();
            this.usePrecisionSave = new System.Windows.Forms.CheckBox();
            this.useRounding = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Location = new System.Drawing.Point(13, 13);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(79, 13);
            this.densityLabel.TabIndex = 0;
            this.densityLabel.Text = "Density (g/cm³)";
            // 
            // densityIn
            // 
            this.densityIn.Location = new System.Drawing.Point(98, 10);
            this.densityIn.Name = "densityIn";
            this.densityIn.Size = new System.Drawing.Size(110, 20);
            this.densityIn.TabIndex = 9;
            this.densityIn.TextChanged += new System.EventHandler(this.densityIn_TextChanged);
            // 
            // saveDensity
            // 
            this.saveDensity.Location = new System.Drawing.Point(214, 8);
            this.saveDensity.Name = "saveDensity";
            this.saveDensity.Size = new System.Drawing.Size(110, 23);
            this.saveDensity.TabIndex = 11;
            this.saveDensity.Text = "Save as preset";
            this.saveDensity.UseVisualStyleBackColor = true;
            this.saveDensity.Click += new System.EventHandler(this.saveDensity_Click);
            // 
            // useDensitySave
            // 
            this.useDensitySave.AutoSize = true;
            this.useDensitySave.Location = new System.Drawing.Point(330, 12);
            this.useDensitySave.Name = "useDensitySave";
            this.useDensitySave.Size = new System.Drawing.Size(78, 17);
            this.useDensitySave.TabIndex = 12;
            this.useDensitySave.Text = "Use Preset";
            this.useDensitySave.UseVisualStyleBackColor = true;
            this.useDensitySave.CheckedChanged += new System.EventHandler(this.useDensitySave_CheckedChanged);
            // 
            // precisionLabel
            // 
            this.precisionLabel.AutoSize = true;
            this.precisionLabel.Location = new System.Drawing.Point(12, 39);
            this.precisionLabel.Name = "precisionLabel";
            this.precisionLabel.Size = new System.Drawing.Size(80, 13);
            this.precisionLabel.TabIndex = 13;
            this.precisionLabel.Text = "Decimal Places";
            // 
            // precisionIn
            // 
            this.precisionIn.Location = new System.Drawing.Point(98, 36);
            this.precisionIn.Name = "precisionIn";
            this.precisionIn.Size = new System.Drawing.Size(110, 20);
            this.precisionIn.TabIndex = 14;
            this.precisionIn.TextChanged += new System.EventHandler(this.precisionIn_TextChanged);
            // 
            // savePrecision
            // 
            this.savePrecision.Location = new System.Drawing.Point(214, 33);
            this.savePrecision.Name = "savePrecision";
            this.savePrecision.Size = new System.Drawing.Size(110, 23);
            this.savePrecision.TabIndex = 15;
            this.savePrecision.Text = "Save as preset";
            this.savePrecision.UseVisualStyleBackColor = true;
            this.savePrecision.Click += new System.EventHandler(this.savePrecision_Click);
            // 
            // usePrecisionSave
            // 
            this.usePrecisionSave.AutoSize = true;
            this.usePrecisionSave.Location = new System.Drawing.Point(330, 37);
            this.usePrecisionSave.Name = "usePrecisionSave";
            this.usePrecisionSave.Size = new System.Drawing.Size(78, 17);
            this.usePrecisionSave.TabIndex = 16;
            this.usePrecisionSave.Text = "Use Preset";
            this.usePrecisionSave.UseVisualStyleBackColor = true;
            this.usePrecisionSave.CheckedChanged += new System.EventHandler(this.usePrecisionSave_CheckedChanged);
            // 
            // useRounding
            // 
            this.useRounding.AutoSize = true;
            this.useRounding.Location = new System.Drawing.Point(12, 67);
            this.useRounding.Name = "useRounding";
            this.useRounding.Size = new System.Drawing.Size(94, 17);
            this.useRounding.TabIndex = 18;
            this.useRounding.Text = "Use Rounding";
            this.useRounding.UseVisualStyleBackColor = true;
            this.useRounding.CheckedChanged += new System.EventHandler(this.useRounding_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 96);
            this.Controls.Add(this.useRounding);
            this.Controls.Add(this.usePrecisionSave);
            this.Controls.Add(this.savePrecision);
            this.Controls.Add(this.precisionIn);
            this.Controls.Add(this.precisionLabel);
            this.Controls.Add(this.useDensitySave);
            this.Controls.Add(this.saveDensity);
            this.Controls.Add(this.densityIn);
            this.Controls.Add(this.densityLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(435, 135);
            this.MinimumSize = new System.Drawing.Size(435, 135);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "GCM Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.TextBox densityIn;
        private System.Windows.Forms.Button saveDensity;
        private System.Windows.Forms.CheckBox useDensitySave;
        private System.Windows.Forms.Label precisionLabel;
        private System.Windows.Forms.TextBox precisionIn;
        private System.Windows.Forms.Button savePrecision;
        private System.Windows.Forms.CheckBox usePrecisionSave;
        private System.Windows.Forms.CheckBox useRounding;
    }
}