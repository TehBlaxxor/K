namespace WindowsFormsApplication1
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
            this.OutcomeBox = new System.Windows.Forms.RichTextBox();
            this.ThemeDark = new MaterialSkin.Controls.MaterialRadioButton();
            this.ThemeLight = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutcomeBox
            // 
            this.OutcomeBox.DetectUrls = false;
            this.OutcomeBox.Location = new System.Drawing.Point(12, 73);
            this.OutcomeBox.Name = "OutcomeBox";
            this.OutcomeBox.Size = new System.Drawing.Size(142, 424);
            this.OutcomeBox.TabIndex = 0;
            this.OutcomeBox.Text = "";
            // 
            // ThemeDark
            // 
            this.ThemeDark.AutoSize = true;
            this.ThemeDark.Checked = true;
            this.ThemeDark.Depth = 0;
            this.ThemeDark.Font = new System.Drawing.Font("Roboto", 10F);
            this.ThemeDark.Location = new System.Drawing.Point(7, 24);
            this.ThemeDark.Margin = new System.Windows.Forms.Padding(0);
            this.ThemeDark.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ThemeDark.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeDark.Name = "ThemeDark";
            this.ThemeDark.Ripple = true;
            this.ThemeDark.Size = new System.Drawing.Size(57, 30);
            this.ThemeDark.TabIndex = 1;
            this.ThemeDark.TabStop = true;
            this.ThemeDark.Text = "Dark";
            this.ThemeDark.UseVisualStyleBackColor = true;
            this.ThemeDark.CheckedChanged += new System.EventHandler(this.ThemeDark_CheckedChanged);
            // 
            // ThemeLight
            // 
            this.ThemeLight.AutoSize = true;
            this.ThemeLight.Depth = 0;
            this.ThemeLight.Font = new System.Drawing.Font("Roboto", 10F);
            this.ThemeLight.Location = new System.Drawing.Point(74, 24);
            this.ThemeLight.Margin = new System.Windows.Forms.Padding(0);
            this.ThemeLight.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ThemeLight.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeLight.Name = "ThemeLight";
            this.ThemeLight.Ripple = true;
            this.ThemeLight.Size = new System.Drawing.Size(60, 30);
            this.ThemeLight.TabIndex = 2;
            this.ThemeLight.Text = "Light";
            this.ThemeLight.UseVisualStyleBackColor = true;
            this.ThemeLight.CheckedChanged += new System.EventHandler(this.ThemeLight_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 5);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = " Theme Options: ";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(12, 503);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(68, 23);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "Copy";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(86, 503);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(68, 23);
            this.materialRaisedButton2.TabIndex = 5;
            this.materialRaisedButton2.Text = "Add Line";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ThemeDark);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.ThemeLight);
            this.panel1.Location = new System.Drawing.Point(723, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 62);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialRadioButton3);
            this.panel2.Controls.Add(this.materialRadioButton2);
            this.panel2.Controls.Add(this.materialRadioButton1);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Location = new System.Drawing.Point(723, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 128);
            this.panel2.TabIndex = 7;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Primary Color:";
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Checked = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(7, 29);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(53, 30);
            this.materialRadioButton1.TabIndex = 1;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Red";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(7, 59);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(56, 30);
            this.materialRadioButton2.TabIndex = 2;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Blue";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            this.materialRadioButton2.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // materialRadioButton3
            // 
            this.materialRadioButton3.AutoSize = true;
            this.materialRadioButton3.Depth = 0;
            this.materialRadioButton3.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton3.Location = new System.Drawing.Point(7, 89);
            this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton3.Name = "materialRadioButton3";
            this.materialRadioButton3.Ripple = true;
            this.materialRadioButton3.Size = new System.Drawing.Size(66, 30);
            this.materialRadioButton3.TabIndex = 3;
            this.materialRadioButton3.TabStop = true;
            this.materialRadioButton3.Text = "Green";
            this.materialRadioButton3.UseVisualStyleBackColor = true;
            this.materialRadioButton3.CheckedChanged += new System.EventHandler(this.materialRadioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.OutcomeBox);
            this.Name = "Form1";
            this.Text = "TehBlaxxor\'s API Scraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutcomeBox;
        private MaterialSkin.Controls.MaterialRadioButton ThemeDark;
        private MaterialSkin.Controls.MaterialRadioButton ThemeLight;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
    }
}

