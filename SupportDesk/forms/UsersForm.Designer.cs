namespace SupportDesk.forms
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxDepart = new System.Windows.Forms.ComboBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.ColumnKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGroup = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
            this.expUIButtonMail = new ExpUI.dll.ExpUIButton();
            this.expUIButtonDelete = new ExpUI.dll.ExpUIButton();
            this.expUIButtonAdd = new ExpUI.dll.ExpUIButton();
            this.expUIButtonSave = new ExpUI.dll.ExpUIButton();
            this.expUIButtonRefresh = new ExpUI.dll.ExpUIButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.comboBoxDepart);
            this.panel1.Controls.Add(this.expUIButtonMail);
            this.panel1.Controls.Add(this.expUIButtonDelete);
            this.panel1.Controls.Add(this.expUIButtonAdd);
            this.panel1.Controls.Add(this.expUIButtonSave);
            this.panel1.Controls.Add(this.expUIButtonRefresh);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 400);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 20);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1117, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Пользователи";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // comboBoxDepart
            // 
            this.comboBoxDepart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDepart.FormattingEnabled = true;
            this.comboBoxDepart.Items.AddRange(new object[] {
            "Все пользователи"});
            this.comboBoxDepart.Location = new System.Drawing.Point(0, 76);
            this.comboBoxDepart.Name = "comboBoxDepart";
            this.comboBoxDepart.Size = new System.Drawing.Size(150, 24);
            this.comboBoxDepart.TabIndex = 3;
            this.comboBoxDepart.TextChanged += new System.EventHandler(this.ComboBoxDepart_TextChanged);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKod,
            this.ColumnFamily,
            this.ColumnName,
            this.ColumnFather,
            this.ColumnNumber,
            this.ColumnEmail,
            this.ColumnDepart,
            this.ColumnPosition,
            this.ColumnLogin,
            this.ColumnPass,
            this.ColumnGroup});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.Location = new System.Drawing.Point(150, 20);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1120, 380);
            this.dataGridViewUsers.TabIndex = 7;
            this.dataGridViewUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridViewUsers_MouseDown);
            // 
            // ColumnKod
            // 
            this.ColumnKod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnKod.Frozen = true;
            this.ColumnKod.HeaderText = "Код";
            this.ColumnKod.Name = "ColumnKod";
            this.ColumnKod.ReadOnly = true;
            // 
            // ColumnFamily
            // 
            this.ColumnFamily.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnFamily.Frozen = true;
            this.ColumnFamily.HeaderText = "Фамилия";
            this.ColumnFamily.Name = "ColumnFamily";
            this.ColumnFamily.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnName.Frozen = true;
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnFather
            // 
            this.ColumnFather.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnFather.Frozen = true;
            this.ColumnFather.HeaderText = "Отчество";
            this.ColumnFather.Name = "ColumnFather";
            this.ColumnFather.ReadOnly = true;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnNumber.Frozen = true;
            this.ColumnNumber.HeaderText = "Номер телефона";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnEmail.Frozen = true;
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnDepart
            // 
            this.ColumnDepart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDepart.Frozen = true;
            this.ColumnDepart.HeaderText = "Отдел";
            this.ColumnDepart.Name = "ColumnDepart";
            this.ColumnDepart.ReadOnly = true;
            // 
            // ColumnPosition
            // 
            this.ColumnPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPosition.Frozen = true;
            this.ColumnPosition.HeaderText = "Должность";
            this.ColumnPosition.Name = "ColumnPosition";
            this.ColumnPosition.ReadOnly = true;
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnLogin.Frozen = true;
            this.ColumnLogin.HeaderText = "Логин";
            this.ColumnLogin.Name = "ColumnLogin";
            this.ColumnLogin.ReadOnly = true;
            // 
            // ColumnPass
            // 
            this.ColumnPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPass.Frozen = true;
            this.ColumnPass.HeaderText = "Пароль";
            this.ColumnPass.Name = "ColumnPass";
            this.ColumnPass.ReadOnly = true;
            // 
            // ColumnGroup
            // 
            this.ColumnGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnGroup.Frozen = true;
            this.ColumnGroup.HeaderText = "Группа";
            this.ColumnGroup.Items.AddRange(new object[] {
            "USER",
            "WORKER",
            "ADMIN"});
            this.ColumnGroup.Name = "ColumnGroup";
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
            this.buttonExit.Location = new System.Drawing.Point(1100, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Remember = false;
            this.buttonExit.RememberColor = System.Drawing.Color.White;
            this.buttonExit.ShowBorder = false;
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.StyleButton = ExpUI.dll.ExpUIButtonIcon.styleButton.Standart;
            this.buttonExit.TabIndex = 46;
            this.buttonExit.Text = "expUIButtonIcon1";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // expUIButtonMail
            // 
            this.expUIButtonMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.expUIButtonMail.BorderSize = 1;
            this.expUIButtonMail.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonMail.ColorTextForBorder = System.Drawing.Color.White;
            this.expUIButtonMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonMail.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonMail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIButtonMail.ForeColor = System.Drawing.Color.White;
            this.expUIButtonMail.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonMail.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonMail.Image")));
            this.expUIButtonMail.Location = new System.Drawing.Point(0, 290);
            this.expUIButtonMail.Name = "expUIButtonMail";
            this.expUIButtonMail.Remember = false;
            this.expUIButtonMail.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.expUIButtonMail.ResponsiveText = true;
            this.expUIButtonMail.Size = new System.Drawing.Size(150, 35);
            this.expUIButtonMail.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.expUIButtonMail.TabIndex = 5;
            this.expUIButtonMail.Text = "Письмо";
            this.expUIButtonMail.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleRight;
            this.expUIButtonMail.Click += new System.EventHandler(this.ExpUIButtonMail_Click);
            // 
            // expUIButtonDelete
            // 
            this.expUIButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.expUIButtonDelete.BorderSize = 1;
            this.expUIButtonDelete.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonDelete.ColorTextForBorder = System.Drawing.Color.White;
            this.expUIButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonDelete.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIButtonDelete.ForeColor = System.Drawing.Color.White;
            this.expUIButtonDelete.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonDelete.Image")));
            this.expUIButtonDelete.Location = new System.Drawing.Point(0, 245);
            this.expUIButtonDelete.Name = "expUIButtonDelete";
            this.expUIButtonDelete.Remember = false;
            this.expUIButtonDelete.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.expUIButtonDelete.ResponsiveText = true;
            this.expUIButtonDelete.Size = new System.Drawing.Size(150, 35);
            this.expUIButtonDelete.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.expUIButtonDelete.TabIndex = 4;
            this.expUIButtonDelete.Text = "Удалить";
            this.expUIButtonDelete.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleRight;
            this.expUIButtonDelete.Click += new System.EventHandler(this.ExpUIButtonDelete_Click);
            // 
            // expUIButtonAdd
            // 
            this.expUIButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.expUIButtonAdd.BorderSize = 1;
            this.expUIButtonAdd.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonAdd.ColorTextForBorder = System.Drawing.Color.White;
            this.expUIButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonAdd.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIButtonAdd.ForeColor = System.Drawing.Color.White;
            this.expUIButtonAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonAdd.Image")));
            this.expUIButtonAdd.Location = new System.Drawing.Point(0, 200);
            this.expUIButtonAdd.Name = "expUIButtonAdd";
            this.expUIButtonAdd.Remember = false;
            this.expUIButtonAdd.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.expUIButtonAdd.ResponsiveText = true;
            this.expUIButtonAdd.Size = new System.Drawing.Size(150, 35);
            this.expUIButtonAdd.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.expUIButtonAdd.TabIndex = 3;
            this.expUIButtonAdd.Text = "Добавить";
            this.expUIButtonAdd.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleRight;
            this.expUIButtonAdd.Click += new System.EventHandler(this.ExpUIButtonAdd_Click);
            // 
            // expUIButtonSave
            // 
            this.expUIButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.expUIButtonSave.BorderSize = 1;
            this.expUIButtonSave.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonSave.ColorTextForBorder = System.Drawing.Color.White;
            this.expUIButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonSave.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIButtonSave.ForeColor = System.Drawing.Color.White;
            this.expUIButtonSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonSave.Image")));
            this.expUIButtonSave.Location = new System.Drawing.Point(0, 155);
            this.expUIButtonSave.Name = "expUIButtonSave";
            this.expUIButtonSave.Remember = false;
            this.expUIButtonSave.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.expUIButtonSave.ResponsiveText = true;
            this.expUIButtonSave.Size = new System.Drawing.Size(150, 35);
            this.expUIButtonSave.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.expUIButtonSave.TabIndex = 2;
            this.expUIButtonSave.Text = "Сохранить";
            this.expUIButtonSave.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleRight;
            this.expUIButtonSave.Click += new System.EventHandler(this.ExpUIButtonSave_Click);
            // 
            // expUIButtonRefresh
            // 
            this.expUIButtonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.expUIButtonRefresh.BorderSize = 1;
            this.expUIButtonRefresh.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonRefresh.ColorTextForBorder = System.Drawing.Color.White;
            this.expUIButtonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonRefresh.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIButtonRefresh.ForeColor = System.Drawing.Color.White;
            this.expUIButtonRefresh.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("expUIButtonRefresh.Image")));
            this.expUIButtonRefresh.Location = new System.Drawing.Point(0, 110);
            this.expUIButtonRefresh.Name = "expUIButtonRefresh";
            this.expUIButtonRefresh.Remember = false;
            this.expUIButtonRefresh.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.expUIButtonRefresh.ResponsiveText = true;
            this.expUIButtonRefresh.Size = new System.Drawing.Size(150, 35);
            this.expUIButtonRefresh.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.expUIButtonRefresh.TabIndex = 1;
            this.expUIButtonRefresh.Text = "Обновить";
            this.expUIButtonRefresh.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleRight;
            this.expUIButtonRefresh.Click += new System.EventHandler(this.ExpUIButtonRefresh_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 398);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1270, 400);
            this.MinimumSize = new System.Drawing.Size(1270, 400);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ExpUI.dll.ExpUIButton expUIButtonDelete;
        private ExpUI.dll.ExpUIButton expUIButtonAdd;
        private ExpUI.dll.ExpUIButton expUIButtonSave;
        private ExpUI.dll.ExpUIButton expUIButtonRefresh;
        private System.Windows.Forms.Panel panel2;
        private ExpUI.dll.ExpUIButtonIcon buttonExit;
        private System.Windows.Forms.Label label11;
        private ExpUI.dll.ExpUIButton expUIButtonMail;
        private System.Windows.Forms.ComboBox comboBoxDepart;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFather;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPass;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnGroup;
    }
}