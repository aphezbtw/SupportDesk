namespace SupportDesk.forms
{
    partial class ContactsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expUIButtonDelete = new ExpUI.dll.ExpUIButton();
            this.expUIButtonAdd = new ExpUI.dll.ExpUIButton();
            this.expUIButtonSave = new ExpUI.dll.ExpUIButton();
            this.expUIButtonRefresh = new ExpUI.dll.ExpUIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.ColumnCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.expUIButtonDelete);
            this.panel1.Controls.Add(this.expUIButtonAdd);
            this.panel1.Controls.Add(this.expUIButtonSave);
            this.panel1.Controls.Add(this.expUIButtonRefresh);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 400);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
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
            this.expUIButtonDelete.Location = new System.Drawing.Point(0, 250);
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
            this.expUIButtonAdd.Location = new System.Drawing.Point(0, 205);
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
            this.expUIButtonSave.Location = new System.Drawing.Point(0, 160);
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
            this.expUIButtonRefresh.Location = new System.Drawing.Point(0, 115);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 20);
            this.panel2.TabIndex = 1;
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
            this.buttonExit.TabIndex = 46;
            this.buttonExit.Text = "expUIButtonIcon1";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(400, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Внешние контакты";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.AllowUserToAddRows = false;
            this.dataGridViewContacts.AllowUserToDeleteRows = false;
            this.dataGridViewContacts.AllowUserToResizeColumns = false;
            this.dataGridViewContacts.AllowUserToResizeRows = false;
            this.dataGridViewContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContacts.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCompany,
            this.ColumnName,
            this.ColumnPhone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewContacts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContacts.Location = new System.Drawing.Point(150, 20);
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContacts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewContacts.RowHeadersVisible = false;
            this.dataGridViewContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContacts.Size = new System.Drawing.Size(400, 380);
            this.dataGridViewContacts.TabIndex = 38;
            // 
            // ColumnCompany
            // 
            this.ColumnCompany.HeaderText = "Организация";
            this.ColumnCompany.Name = "ColumnCompany";
            this.ColumnCompany.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "ФИО сотрудника";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Телефон";
            this.ColumnPhone.Name = "ColumnPhone";
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 398);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewContacts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "ContactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private ExpUI.dll.ExpUIButton expUIButtonDelete;
        private ExpUI.dll.ExpUIButton expUIButtonAdd;
        private ExpUI.dll.ExpUIButton expUIButtonSave;
        private ExpUI.dll.ExpUIButton expUIButtonRefresh;
        private System.Windows.Forms.Label label11;
        private ExpUI.dll.ExpUIButtonIcon buttonExit;
    }
}