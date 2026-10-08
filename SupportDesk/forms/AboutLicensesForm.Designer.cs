namespace SupportDesk.forms
{
    partial class AboutLicensesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutLicensesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSendBags = new System.Windows.Forms.Button();
            this.buttonUserGuide = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 20);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.buttonExit.BorderColor = System.Drawing.Color.Black;
            this.buttonExit.BorderSize = 1;
            this.buttonExit.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.HoverColor = System.Drawing.Color.Red;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(380, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Remember = false;
            this.buttonExit.RememberColor = System.Drawing.Color.White;
            this.buttonExit.ShowBorder = false;
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "expUIButtonIcon1";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(10, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(375, 202);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // buttonSendBags
            // 
            this.buttonSendBags.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSendBags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendBags.FlatAppearance.BorderSize = 0;
            this.buttonSendBags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendBags.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendBags.ForeColor = System.Drawing.Color.White;
            this.buttonSendBags.Location = new System.Drawing.Point(220, 252);
            this.buttonSendBags.Name = "buttonSendBags";
            this.buttonSendBags.Size = new System.Drawing.Size(170, 25);
            this.buttonSendBags.TabIndex = 5;
            this.buttonSendBags.Text = "Отзыв / Предложение";
            this.buttonSendBags.UseVisualStyleBackColor = false;
            this.buttonSendBags.Click += new System.EventHandler(this.ButtonSendBags_Click);
            // 
            // buttonUserGuide
            // 
            this.buttonUserGuide.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonUserGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserGuide.FlatAppearance.BorderSize = 0;
            this.buttonUserGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserGuide.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUserGuide.ForeColor = System.Drawing.Color.White;
            this.buttonUserGuide.Location = new System.Drawing.Point(10, 252);
            this.buttonUserGuide.Name = "buttonUserGuide";
            this.buttonUserGuide.Size = new System.Drawing.Size(200, 25);
            this.buttonUserGuide.TabIndex = 4;
            this.buttonUserGuide.Text = "Руководство пользователя";
            this.buttonUserGuide.UseVisualStyleBackColor = false;
            this.buttonUserGuide.Click += new System.EventHandler(this.ButtonUserGuide_Click);
            // 
            // AboutLicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 290);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSendBags);
            this.Controls.Add(this.buttonUserGuide);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 292);
            this.MinimumSize = new System.Drawing.Size(400, 292);
            this.Name = "AboutLicensesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AboutLicensesForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSendBags;
        private System.Windows.Forms.Button buttonUserGuide;
        private ExpUI.dll.ExpUIButtonIcon buttonExit;
    }
}