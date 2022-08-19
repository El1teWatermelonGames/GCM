
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
            this.comboDensity = new System.Windows.Forms.ComboBox();
            this.newDensity = new System.Windows.Forms.Button();
            this.deleteDensity = new System.Windows.Forms.Button();
            this.inputDensity = new System.Windows.Forms.TextBox();
            this.usePrecisionSave = new System.Windows.Forms.CheckBox();
            this.savePrecision = new System.Windows.Forms.Button();
            this.precisionIn = new System.Windows.Forms.TextBox();
            this.useRounding = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboDensity
            // 
            this.comboDensity.FormattingEnabled = true;
            this.comboDensity.Location = new System.Drawing.Point(172, 23);
            this.comboDensity.Name = "comboDensity";
            this.comboDensity.Size = new System.Drawing.Size(121, 21);
            this.comboDensity.TabIndex = 1;
            this.comboDensity.SelectedIndexChanged += new System.EventHandler(this.comboDensity_SelectedIndexChanged);
            // 
            // newDensity
            // 
            this.newDensity.Location = new System.Drawing.Point(6, 22);
            this.newDensity.Name = "newDensity";
            this.newDensity.Size = new System.Drawing.Size(75, 23);
            this.newDensity.TabIndex = 2;
            this.newDensity.Text = "New Preset";
            this.newDensity.UseVisualStyleBackColor = true;
            this.newDensity.Click += new System.EventHandler(this.newDensity_Click);
            // 
            // deleteDensity
            // 
            this.deleteDensity.Location = new System.Drawing.Point(87, 22);
            this.deleteDensity.Name = "deleteDensity";
            this.deleteDensity.Size = new System.Drawing.Size(79, 23);
            this.deleteDensity.TabIndex = 3;
            this.deleteDensity.Text = "Delete Preset";
            this.deleteDensity.UseVisualStyleBackColor = true;
            this.deleteDensity.Click += new System.EventHandler(this.deleteDensity_Click);
            // 
            // inputDensity
            // 
            this.inputDensity.Location = new System.Drawing.Point(299, 24);
            this.inputDensity.Name = "inputDensity";
            this.inputDensity.ReadOnly = true;
            this.inputDensity.Size = new System.Drawing.Size(100, 20);
            this.inputDensity.TabIndex = 4;
            this.inputDensity.TextChanged += new System.EventHandler(this.inputDensity_TextChanged);
            // 
            // usePrecisionSave
            // 
            this.usePrecisionSave.AutoSize = true;
            this.usePrecisionSave.Location = new System.Drawing.Point(321, 19);
            this.usePrecisionSave.Name = "usePrecisionSave";
            this.usePrecisionSave.Size = new System.Drawing.Size(78, 17);
            this.usePrecisionSave.TabIndex = 19;
            this.usePrecisionSave.Text = "Use Preset";
            this.usePrecisionSave.UseVisualStyleBackColor = true;
            this.usePrecisionSave.CheckedChanged += new System.EventHandler(this.usePrecisionSave_CheckedChanged);
            // 
            // savePrecision
            // 
            this.savePrecision.Location = new System.Drawing.Point(205, 15);
            this.savePrecision.Name = "savePrecision";
            this.savePrecision.Size = new System.Drawing.Size(110, 23);
            this.savePrecision.TabIndex = 18;
            this.savePrecision.Text = "Save as preset";
            this.savePrecision.UseVisualStyleBackColor = true;
            this.savePrecision.Click += new System.EventHandler(this.savePrecision_Click);
            // 
            // precisionIn
            // 
            this.precisionIn.Location = new System.Drawing.Point(89, 17);
            this.precisionIn.Name = "precisionIn";
            this.precisionIn.Size = new System.Drawing.Size(110, 20);
            this.precisionIn.TabIndex = 17;
            this.precisionIn.TextChanged += new System.EventHandler(this.precisionIn_TextChanged);
            // 
            // useRounding
            // 
            this.useRounding.AutoSize = true;
            this.useRounding.Location = new System.Drawing.Point(6, 19);
            this.useRounding.Name = "useRounding";
            this.useRounding.Size = new System.Drawing.Size(72, 17);
            this.useRounding.TabIndex = 20;
            this.useRounding.Text = "Rounding";
            this.useRounding.UseVisualStyleBackColor = true;
            this.useRounding.CheckedChanged += new System.EventHandler(this.useRounding_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newDensity);
            this.groupBox1.Controls.Add(this.deleteDensity);
            this.groupBox1.Controls.Add(this.comboDensity);
            this.groupBox1.Controls.Add(this.inputDensity);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 51);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Density";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.savePrecision);
            this.groupBox2.Controls.Add(this.usePrecisionSave);
            this.groupBox2.Controls.Add(this.precisionIn);
            this.groupBox2.Controls.Add(this.useRounding);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 47);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decimal Places";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 123);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "GCM Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboDensity;
        private System.Windows.Forms.Button newDensity;
        private System.Windows.Forms.Button deleteDensity;
        private System.Windows.Forms.TextBox inputDensity;
        private System.Windows.Forms.CheckBox usePrecisionSave;
        private System.Windows.Forms.Button savePrecision;
        private System.Windows.Forms.TextBox precisionIn;
        private System.Windows.Forms.CheckBox useRounding;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}