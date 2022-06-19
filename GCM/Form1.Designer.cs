
namespace GCM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.settings = new System.Windows.Forms.Button();
            this.gCmGroup = new System.Windows.Forms.GroupBox();
            this.enterGramsLabel = new System.Windows.Forms.Label();
            this.convertCm = new System.Windows.Forms.Button();
            this.cmOut = new System.Windows.Forms.TextBox();
            this.gramsIn = new System.Windows.Forms.TextBox();
            this.cmGGroup = new System.Windows.Forms.GroupBox();
            this.enterCmLabel = new System.Windows.Forms.Label();
            this.convertG = new System.Windows.Forms.Button();
            this.gOut = new System.Windows.Forms.TextBox();
            this.cmIn = new System.Windows.Forms.TextBox();
            this.watermark = new System.Windows.Forms.Label();
            this.gCmGroup.SuspendLayout();
            this.cmGGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(12, 255);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 23);
            this.settings.TabIndex = 0;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // gCmGroup
            // 
            this.gCmGroup.Controls.Add(this.enterGramsLabel);
            this.gCmGroup.Controls.Add(this.convertCm);
            this.gCmGroup.Controls.Add(this.cmOut);
            this.gCmGroup.Controls.Add(this.gramsIn);
            this.gCmGroup.Location = new System.Drawing.Point(11, 12);
            this.gCmGroup.Name = "gCmGroup";
            this.gCmGroup.Size = new System.Drawing.Size(137, 237);
            this.gCmGroup.TabIndex = 5;
            this.gCmGroup.TabStop = false;
            this.gCmGroup.Text = "g to cm³";
            // 
            // enterGramsLabel
            // 
            this.enterGramsLabel.AutoSize = true;
            this.enterGramsLabel.Location = new System.Drawing.Point(6, 27);
            this.enterGramsLabel.Name = "enterGramsLabel";
            this.enterGramsLabel.Size = new System.Drawing.Size(115, 13);
            this.enterGramsLabel.TabIndex = 4;
            this.enterGramsLabel.Text = "Enter the grams below:";
            // 
            // convertCm
            // 
            this.convertCm.Enabled = false;
            this.convertCm.Location = new System.Drawing.Point(7, 125);
            this.convertCm.Name = "convertCm";
            this.convertCm.Size = new System.Drawing.Size(75, 23);
            this.convertCm.TabIndex = 2;
            this.convertCm.Text = "Convert";
            this.convertCm.UseVisualStyleBackColor = true;
            this.convertCm.Click += new System.EventHandler(this.convertCm_Click);
            // 
            // cmOut
            // 
            this.cmOut.Location = new System.Drawing.Point(7, 154);
            this.cmOut.Multiline = true;
            this.cmOut.Name = "cmOut";
            this.cmOut.ReadOnly = true;
            this.cmOut.Size = new System.Drawing.Size(120, 77);
            this.cmOut.TabIndex = 2;
            this.cmOut.TabStop = false;
            this.cmOut.TextChanged += new System.EventHandler(this.cmOut_TextChanged);
            // 
            // gramsIn
            // 
            this.gramsIn.Location = new System.Drawing.Point(7, 47);
            this.gramsIn.Name = "gramsIn";
            this.gramsIn.Size = new System.Drawing.Size(120, 20);
            this.gramsIn.TabIndex = 1;
            this.gramsIn.TextChanged += new System.EventHandler(this.gramsIn_TextChanged);
            // 
            // cmGGroup
            // 
            this.cmGGroup.Controls.Add(this.enterCmLabel);
            this.cmGGroup.Controls.Add(this.convertG);
            this.cmGGroup.Controls.Add(this.gOut);
            this.cmGGroup.Controls.Add(this.cmIn);
            this.cmGGroup.Location = new System.Drawing.Point(154, 12);
            this.cmGGroup.Name = "cmGGroup";
            this.cmGGroup.Size = new System.Drawing.Size(137, 237);
            this.cmGGroup.TabIndex = 6;
            this.cmGGroup.TabStop = false;
            this.cmGGroup.Text = "cm³ to g";
            // 
            // enterCmLabel
            // 
            this.enterCmLabel.AutoSize = true;
            this.enterCmLabel.Location = new System.Drawing.Point(6, 27);
            this.enterCmLabel.Name = "enterCmLabel";
            this.enterCmLabel.Size = new System.Drawing.Size(104, 13);
            this.enterCmLabel.TabIndex = 4;
            this.enterCmLabel.Text = "Enter the cm³ below:";
            // 
            // convertG
            // 
            this.convertG.Enabled = false;
            this.convertG.Location = new System.Drawing.Point(9, 125);
            this.convertG.Name = "convertG";
            this.convertG.Size = new System.Drawing.Size(75, 23);
            this.convertG.TabIndex = 4;
            this.convertG.Text = "Convert";
            this.convertG.UseVisualStyleBackColor = true;
            this.convertG.Click += new System.EventHandler(this.convertG_Click);
            // 
            // gOut
            // 
            this.gOut.Location = new System.Drawing.Point(6, 154);
            this.gOut.Multiline = true;
            this.gOut.Name = "gOut";
            this.gOut.ReadOnly = true;
            this.gOut.Size = new System.Drawing.Size(120, 77);
            this.gOut.TabIndex = 2;
            this.gOut.TabStop = false;
            this.gOut.TextChanged += new System.EventHandler(this.gOut_TextChanged);
            // 
            // cmIn
            // 
            this.cmIn.Location = new System.Drawing.Point(7, 47);
            this.cmIn.Name = "cmIn";
            this.cmIn.Size = new System.Drawing.Size(120, 20);
            this.cmIn.TabIndex = 3;
            this.cmIn.TextChanged += new System.EventHandler(this.cmIn_TextChanged);
            // 
            // watermark
            // 
            this.watermark.AutoSize = true;
            this.watermark.Location = new System.Drawing.Point(115, 260);
            this.watermark.Name = "watermark";
            this.watermark.Size = new System.Drawing.Size(177, 13);
            this.watermark.TabIndex = 7;
            this.watermark.Text = "Created by Elite Watermelon Games";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 286);
            this.Controls.Add(this.watermark);
            this.Controls.Add(this.gCmGroup);
            this.Controls.Add(this.cmGGroup);
            this.Controls.Add(this.settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 325);
            this.MinimumSize = new System.Drawing.Size(320, 325);
            this.Name = "Form1";
            this.Text = "GCM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gCmGroup.ResumeLayout(false);
            this.gCmGroup.PerformLayout();
            this.cmGGroup.ResumeLayout(false);
            this.cmGGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.GroupBox gCmGroup;
        private System.Windows.Forms.Label enterGramsLabel;
        private System.Windows.Forms.Button convertCm;
        private System.Windows.Forms.TextBox cmOut;
        private System.Windows.Forms.TextBox gramsIn;
        private System.Windows.Forms.GroupBox cmGGroup;
        private System.Windows.Forms.Label enterCmLabel;
        private System.Windows.Forms.Button convertG;
        private System.Windows.Forms.TextBox gOut;
        private System.Windows.Forms.TextBox cmIn;
        private System.Windows.Forms.Label watermark;
    }
}

