namespace SupportDesk.forms
{
    partial class SettingForm
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxClearDB = new System.Windows.Forms.GroupBox();
            this.comboBoxClear = new System.Windows.Forms.ComboBox();
            this.toggleControlAllInventory = new ExpUI.dll.ExpUIToggleControl();
            this.toggleControlAllUsers = new ExpUI.dll.ExpUIToggleControl();
            this.toggleControlCalendar = new ExpUI.dll.ExpUIToggleControl();
            this.ButtonClearLogs = new ExpUI.dll.ExpUIButton();
            this.ButtonOpenLogs = new ExpUI.dll.ExpUIButton();
            this.buttonClearDB = new ExpUI.dll.ExpUIButton();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxClearDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 20);
            this.panel2.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Настройки";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonClearLogs);
            this.groupBox2.Controls.Add(this.ButtonOpenLogs);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(10, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 99);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Лог-система";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toggleControlAllInventory);
            this.groupBox1.Controls.Add(this.toggleControlAllUsers);
            this.groupBox1.Controls.Add(this.toggleControlCalendar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(10, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 115);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виджеты";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(68, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Оборудование ВКЛ/ВЫКЛ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(68, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Пользователи ВКЛ/ВЫКЛ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(68, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Календарь ВКЛ/ВЫКЛ";
            // 
            // groupBoxClearDB
            // 
            this.groupBoxClearDB.Controls.Add(this.buttonClearDB);
            this.groupBoxClearDB.Controls.Add(this.comboBoxClear);
            this.groupBoxClearDB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxClearDB.Location = new System.Drawing.Point(10, 30);
            this.groupBoxClearDB.Name = "groupBoxClearDB";
            this.groupBoxClearDB.Size = new System.Drawing.Size(212, 99);
            this.groupBoxClearDB.TabIndex = 70;
            this.groupBoxClearDB.TabStop = false;
            this.groupBoxClearDB.Text = "Очистка";
            // 
            // comboBoxClear
            // 
            this.comboBoxClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxClear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClear.FormattingEnabled = true;
            this.comboBoxClear.Items.AddRange(new object[] {
            "Не выбрано",
            "База заявок",
            "База пользователей",
            "База картриджей",
            "База лицензий",
            "База инвентаризации",
            "База паролей",
            "База внешних контактов"});
            this.comboBoxClear.Location = new System.Drawing.Point(6, 21);
            this.comboBoxClear.Name = "comboBoxClear";
            this.comboBoxClear.Size = new System.Drawing.Size(200, 24);
            this.comboBoxClear.TabIndex = 0;
            // 
            // toggleControlAllInventory
            // 
            this.toggleControlAllInventory.ColorMainOFF = System.Drawing.Color.Red;
            this.toggleControlAllInventory.ColorMainON = System.Drawing.Color.Green;
            this.toggleControlAllInventory.ColorOFF = System.Drawing.Color.White;
            this.toggleControlAllInventory.ColorON = System.Drawing.Color.White;
            this.toggleControlAllInventory.ColorTextOFF = System.Drawing.Color.Black;
            this.toggleControlAllInventory.ColorTextON = System.Drawing.Color.White;
            this.toggleControlAllInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleControlAllInventory.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toggleControlAllInventory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toggleControlAllInventory.Location = new System.Drawing.Point(6, 83);
            this.toggleControlAllInventory.Name = "toggleControlAllInventory";
            this.toggleControlAllInventory.Size = new System.Drawing.Size(60, 25);
            this.toggleControlAllInventory.SolidStyle = true;
            this.toggleControlAllInventory.TabIndex = 45;
            this.toggleControlAllInventory.Text = "expUIToggleControl1";
            this.toggleControlAllInventory.UseText = false;
            this.toggleControlAllInventory.Click += new System.EventHandler(this.ToggleControlAllInventory_Click);
            // 
            // toggleControlAllUsers
            // 
            this.toggleControlAllUsers.ColorMainOFF = System.Drawing.Color.Red;
            this.toggleControlAllUsers.ColorMainON = System.Drawing.Color.Green;
            this.toggleControlAllUsers.ColorOFF = System.Drawing.Color.White;
            this.toggleControlAllUsers.ColorON = System.Drawing.Color.White;
            this.toggleControlAllUsers.ColorTextOFF = System.Drawing.Color.Black;
            this.toggleControlAllUsers.ColorTextON = System.Drawing.Color.White;
            this.toggleControlAllUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleControlAllUsers.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toggleControlAllUsers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toggleControlAllUsers.Location = new System.Drawing.Point(6, 52);
            this.toggleControlAllUsers.Name = "toggleControlAllUsers";
            this.toggleControlAllUsers.Size = new System.Drawing.Size(60, 25);
            this.toggleControlAllUsers.SolidStyle = true;
            this.toggleControlAllUsers.TabIndex = 44;
            this.toggleControlAllUsers.Text = "expUIToggleControl1";
            this.toggleControlAllUsers.UseText = false;
            this.toggleControlAllUsers.Click += new System.EventHandler(this.ToggleControlAllUsers_Click);
            // 
            // toggleControlCalendar
            // 
            this.toggleControlCalendar.ColorMainOFF = System.Drawing.Color.Red;
            this.toggleControlCalendar.ColorMainON = System.Drawing.Color.Green;
            this.toggleControlCalendar.ColorOFF = System.Drawing.Color.White;
            this.toggleControlCalendar.ColorON = System.Drawing.Color.White;
            this.toggleControlCalendar.ColorTextOFF = System.Drawing.Color.Black;
            this.toggleControlCalendar.ColorTextON = System.Drawing.Color.White;
            this.toggleControlCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleControlCalendar.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toggleControlCalendar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toggleControlCalendar.Location = new System.Drawing.Point(6, 21);
            this.toggleControlCalendar.Name = "toggleControlCalendar";
            this.toggleControlCalendar.Size = new System.Drawing.Size(60, 25);
            this.toggleControlCalendar.SolidStyle = true;
            this.toggleControlCalendar.TabIndex = 43;
            this.toggleControlCalendar.Text = "expUIToggleControl1";
            this.toggleControlCalendar.UseText = false;
            this.toggleControlCalendar.Click += new System.EventHandler(this.ToggleControl_Click);
            // 
            // ButtonClearLogs
            // 
            this.ButtonClearLogs.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonClearLogs.BorderSize = 1;
            this.ButtonClearLogs.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonClearLogs.ColorTextForBorder = System.Drawing.Color.White;
            this.ButtonClearLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClearLogs.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonClearLogs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonClearLogs.ForeColor = System.Drawing.Color.White;
            this.ButtonClearLogs.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonClearLogs.Image = null;
            this.ButtonClearLogs.Location = new System.Drawing.Point(6, 58);
            this.ButtonClearLogs.Name = "ButtonClearLogs";
            this.ButtonClearLogs.Remember = false;
            this.ButtonClearLogs.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonClearLogs.ResponsiveText = false;
            this.ButtonClearLogs.Size = new System.Drawing.Size(200, 35);
            this.ButtonClearLogs.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.ButtonClearLogs.TabIndex = 3;
            this.ButtonClearLogs.Text = "Очистить файл";
            this.ButtonClearLogs.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleCenter;
            this.ButtonClearLogs.Click += new System.EventHandler(this.ButtonClearLogs_Click);
            // 
            // ButtonOpenLogs
            // 
            this.ButtonOpenLogs.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonOpenLogs.BorderSize = 1;
            this.ButtonOpenLogs.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonOpenLogs.ColorTextForBorder = System.Drawing.Color.White;
            this.ButtonOpenLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpenLogs.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonOpenLogs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonOpenLogs.ForeColor = System.Drawing.Color.White;
            this.ButtonOpenLogs.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonOpenLogs.Image = null;
            this.ButtonOpenLogs.Location = new System.Drawing.Point(6, 21);
            this.ButtonOpenLogs.Name = "ButtonOpenLogs";
            this.ButtonOpenLogs.Remember = false;
            this.ButtonOpenLogs.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonOpenLogs.ResponsiveText = false;
            this.ButtonOpenLogs.Size = new System.Drawing.Size(200, 35);
            this.ButtonOpenLogs.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.ButtonOpenLogs.TabIndex = 2;
            this.ButtonOpenLogs.Text = "Открыть файл";
            this.ButtonOpenLogs.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleCenter;
            this.ButtonOpenLogs.Click += new System.EventHandler(this.ButtonOpenLogs_Click);
            // 
            // buttonClearDB
            // 
            this.buttonClearDB.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonClearDB.BorderSize = 1;
            this.buttonClearDB.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonClearDB.ColorTextForBorder = System.Drawing.Color.White;
            this.buttonClearDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearDB.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonClearDB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonClearDB.ForeColor = System.Drawing.Color.White;
            this.buttonClearDB.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClearDB.Image = null;
            this.buttonClearDB.Location = new System.Drawing.Point(6, 58);
            this.buttonClearDB.Name = "buttonClearDB";
            this.buttonClearDB.Remember = false;
            this.buttonClearDB.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClearDB.ResponsiveText = false;
            this.buttonClearDB.Size = new System.Drawing.Size(200, 35);
            this.buttonClearDB.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.buttonClearDB.TabIndex = 1;
            this.buttonClearDB.Text = "Очистить";
            this.buttonClearDB.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleCenter;
            this.buttonClearDB.Click += new System.EventHandler(this.ButtonClearDB_Click);
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
            this.buttonExit.Location = new System.Drawing.Point(237, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Remember = false;
            this.buttonExit.RememberColor = System.Drawing.Color.White;
            this.buttonExit.ShowBorder = false;
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.buttonExit.TabIndex = 42;
            this.buttonExit.Text = "expUIButtonIcon1";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(255, 371);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxClearDB);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(257, 373);
            this.MinimumSize = new System.Drawing.Size(257, 373);
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxClearDB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private ExpUI.dll.ExpUIButtonIcon buttonExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private ExpUI.dll.ExpUIToggleControl toggleControlAllInventory;
        private System.Windows.Forms.Label label3;
        private ExpUI.dll.ExpUIToggleControl toggleControlAllUsers;
        private System.Windows.Forms.Label label2;
        private ExpUI.dll.ExpUIToggleControl toggleControlCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxClearDB;
        private System.Windows.Forms.ComboBox comboBoxClear;
        private ExpUI.dll.ExpUIButton buttonClearDB;
        private ExpUI.dll.ExpUIButton ButtonClearLogs;
        private ExpUI.dll.ExpUIButton ButtonOpenLogs;
    }
}