namespace SupportDesk.forms
{
    partial class CloseRequestForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseRequestForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
            this.label11 = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.expUIButtonFile = new ExpUI.dll.ExpUIButton();
            this.expUIButtonFileResult = new ExpUI.dll.ExpUIButton();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.comboBoxExecutors = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 20);
            this.panel2.TabIndex = 71;
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
            this.buttonExit.Location = new System.Drawing.Point(480, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Remember = false;
            this.buttonExit.RememberColor = System.Drawing.Color.White;
            this.buttonExit.ShowBorder = false;
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "expUIButtonIcon1";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(500, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Описание задачи № 0";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // labelMain
            // 
            this.labelMain.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.Location = new System.Drawing.Point(10, 30);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(330, 207);
            this.labelMain.TabIndex = 72;
            this.labelMain.Text = resources.GetString("labelMain.Text");
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(350, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 480);
            this.panel1.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(350, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Вложения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(350, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 2);
            this.panel3.TabIndex = 85;
            // 
            // expUIButtonFile
            // 
            this.expUIButtonFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.expUIButtonFile.BorderSize = 1;
            this.expUIButtonFile.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonFile.ColorTextForBorder = System.Drawing.Color.White;
            this.expUIButtonFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonFile.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIButtonFile.ForeColor = System.Drawing.Color.White;
            this.expUIButtonFile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonFile.Image = null;
            this.expUIButtonFile.Location = new System.Drawing.Point(355, 45);
            this.expUIButtonFile.Name = "expUIButtonFile";
            this.expUIButtonFile.Remember = false;
            this.expUIButtonFile.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.expUIButtonFile.ResponsiveText = false;
            this.expUIButtonFile.Size = new System.Drawing.Size(140, 35);
            this.expUIButtonFile.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.expUIButtonFile.TabIndex = 87;
            this.expUIButtonFile.Text = "Название файла";
            this.expUIButtonFile.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleRight;
            this.toolTip1.SetToolTip(this.expUIButtonFile, "Открыть файл");
            this.expUIButtonFile.Visible = false;
            this.expUIButtonFile.Click += new System.EventHandler(this.ExpUIButtonFile_Click);
            // 
            // expUIButtonFileResult
            // 
            this.expUIButtonFileResult.BackColor = System.Drawing.Color.DodgerBlue;
            this.expUIButtonFileResult.BorderSize = 1;
            this.expUIButtonFileResult.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonFileResult.ColorTextForBorder = System.Drawing.Color.White;
            this.expUIButtonFileResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonFileResult.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonFileResult.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIButtonFileResult.ForeColor = System.Drawing.Color.White;
            this.expUIButtonFileResult.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonFileResult.Image = null;
            this.expUIButtonFileResult.Location = new System.Drawing.Point(355, 85);
            this.expUIButtonFileResult.Name = "expUIButtonFileResult";
            this.expUIButtonFileResult.Remember = false;
            this.expUIButtonFileResult.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.expUIButtonFileResult.ResponsiveText = false;
            this.expUIButtonFileResult.Size = new System.Drawing.Size(140, 35);
            this.expUIButtonFileResult.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.expUIButtonFileResult.TabIndex = 88;
            this.expUIButtonFileResult.Text = "Название файла";
            this.expUIButtonFileResult.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleRight;
            this.toolTip1.SetToolTip(this.expUIButtonFileResult, "Открыть файл");
            this.expUIButtonFileResult.Visible = false;
            this.expUIButtonFileResult.Click += new System.EventHandler(this.ExpUIButtonFileResult_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccept.FlatAppearance.BorderSize = 0;
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.ForeColor = System.Drawing.Color.White;
            this.buttonAccept.Location = new System.Drawing.Point(10, 460);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(160, 30);
            this.buttonAccept.TabIndex = 89;
            this.buttonAccept.Text = "Принять задачу";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // comboBoxExecutors
            // 
            this.comboBoxExecutors.BackColor = System.Drawing.Color.White;
            this.comboBoxExecutors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxExecutors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExecutors.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxExecutors.FormattingEnabled = true;
            this.comboBoxExecutors.Location = new System.Drawing.Point(180, 463);
            this.comboBoxExecutors.Name = "comboBoxExecutors";
            this.comboBoxExecutors.Size = new System.Drawing.Size(160, 24);
            this.comboBoxExecutors.TabIndex = 90;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 242);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(330, 208);
            this.textBox1.TabIndex = 91;
            // 
            // CloseRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 498);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxExecutors);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.expUIButtonFileResult);
            this.Controls.Add(this.expUIButtonFile);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "CloseRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CloseRequestForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private ExpUI.dll.ExpUIButtonIcon buttonExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private ExpUI.dll.ExpUIButton expUIButtonFile;
        private ExpUI.dll.ExpUIButton expUIButtonFileResult;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.ComboBox comboBoxExecutors;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}