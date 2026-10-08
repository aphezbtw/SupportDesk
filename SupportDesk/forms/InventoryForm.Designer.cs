namespace SupportDesk.forms
{
    partial class InventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxRequest = new System.Windows.Forms.ComboBox();
            this.dataGridViewLicenses = new System.Windows.Forms.DataGridView();
            this.ColumnKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFactLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
            this.expUIButtonDelete = new ExpUI.dll.ExpUIButton();
            this.expUIButtonAdd = new ExpUI.dll.ExpUIButton();
            this.expUIButtonSave = new ExpUI.dll.ExpUIButton();
            this.expUIButtonRefresh = new ExpUI.dll.ExpUIButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.comboBoxRequest);
            this.panel1.Controls.Add(this.expUIButtonDelete);
            this.panel1.Controls.Add(this.expUIButtonAdd);
            this.panel1.Controls.Add(this.expUIButtonSave);
            this.panel1.Controls.Add(this.expUIButtonRefresh);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 400);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 20);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(645, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Инвентаризация";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // comboBoxRequest
            // 
            this.comboBoxRequest.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRequest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxRequest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRequest.ForeColor = System.Drawing.Color.Black;
            this.comboBoxRequest.FormattingEnabled = true;
            this.comboBoxRequest.Items.AddRange(new object[] {
            "Все кабинеты"});
            this.comboBoxRequest.Location = new System.Drawing.Point(0, 98);
            this.comboBoxRequest.Name = "comboBoxRequest";
            this.comboBoxRequest.Size = new System.Drawing.Size(150, 24);
            this.comboBoxRequest.TabIndex = 47;
            this.comboBoxRequest.TextChanged += new System.EventHandler(this.ComboBoxRequest_TextChanged);
            // 
            // dataGridViewLicenses
            // 
            this.dataGridViewLicenses.AllowUserToAddRows = false;
            this.dataGridViewLicenses.AllowUserToDeleteRows = false;
            this.dataGridViewLicenses.AllowUserToResizeColumns = false;
            this.dataGridViewLicenses.AllowUserToResizeRows = false;
            this.dataGridViewLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLicenses.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKod,
            this.ColumnName,
            this.ColumnDate,
            this.ColumnInvNum,
            this.ColumnAmount,
            this.ColumnLocation,
            this.ColumnFactLocation});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLicenses.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewLicenses.Location = new System.Drawing.Point(150, 20);
            this.dataGridViewLicenses.Name = "dataGridViewLicenses";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewLicenses.RowHeadersVisible = false;
            this.dataGridViewLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLicenses.Size = new System.Drawing.Size(645, 380);
            this.dataGridViewLicenses.TabIndex = 26;
            // 
            // ColumnKod
            // 
            this.ColumnKod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnKod.Frozen = true;
            this.ColumnKod.HeaderText = "Код";
            this.ColumnKod.Name = "ColumnKod";
            this.ColumnKod.ReadOnly = true;
            this.ColumnKod.Width = 55;
            // 
            // ColumnName
            // 
            this.ColumnName.FillWeight = 37.80822F;
            this.ColumnName.HeaderText = "Наименование";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnDate
            // 
            this.ColumnDate.FillWeight = 37.80822F;
            this.ColumnDate.HeaderText = "Дата покупки";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // ColumnInvNum
            // 
            this.ColumnInvNum.FillWeight = 37.80822F;
            this.ColumnInvNum.HeaderText = "Инв. Номер";
            this.ColumnInvNum.Name = "ColumnInvNum";
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.FillWeight = 37.80822F;
            this.ColumnAmount.HeaderText = "Количество";
            this.ColumnAmount.Name = "ColumnAmount";
            // 
            // ColumnLocation
            // 
            this.ColumnLocation.FillWeight = 37.80822F;
            this.ColumnLocation.HeaderText = "Место";
            this.ColumnLocation.Name = "ColumnLocation";
            // 
            // ColumnFactLocation
            // 
            this.ColumnFactLocation.FillWeight = 37.80822F;
            this.ColumnFactLocation.HeaderText = "Фактическое";
            this.ColumnFactLocation.Name = "ColumnFactLocation";
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
            this.buttonExit.Location = new System.Drawing.Point(625, 0);
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
            this.expUIButtonDelete.Location = new System.Drawing.Point(0, 267);
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
            this.expUIButtonAdd.Location = new System.Drawing.Point(0, 222);
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
            this.expUIButtonSave.Location = new System.Drawing.Point(0, 177);
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
            this.expUIButtonRefresh.Location = new System.Drawing.Point(0, 132);
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
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 398);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewLicenses);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(796, 400);
            this.MinimumSize = new System.Drawing.Size(796, 400);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicenses)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxRequest;
        private System.Windows.Forms.DataGridView dataGridViewLicenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFactLocation;
    }
}