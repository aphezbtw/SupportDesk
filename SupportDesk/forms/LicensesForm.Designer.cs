namespace SupportDesk.forms
{
    partial class LicensesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicensesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxRequest = new System.Windows.Forms.ComboBox();
            this.expUIButtonDelete = new ExpUI.dll.ExpUIButton();
            this.expUIButtonAdd = new ExpUI.dll.ExpUIButton();
            this.expUIButtonRefresh = new ExpUI.dll.ExpUIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewLicenses = new System.Windows.Forms.DataGridView();
            this.ColumnCabinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoftware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Controls.Add(this.expUIButtonRefresh);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 400);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
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
            this.comboBoxRequest.Location = new System.Drawing.Point(0, 120);
            this.comboBoxRequest.Name = "comboBoxRequest";
            this.comboBoxRequest.Size = new System.Drawing.Size(150, 24);
            this.comboBoxRequest.TabIndex = 28;
            this.comboBoxRequest.TextChanged += new System.EventHandler(this.ComboBoxRequest_TextChanged);
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
            this.expUIButtonDelete.Location = new System.Drawing.Point(0, 244);
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
            this.expUIButtonAdd.Location = new System.Drawing.Point(0, 199);
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
            this.expUIButtonRefresh.Location = new System.Drawing.Point(0, 154);
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
            this.panel2.Size = new System.Drawing.Size(415, 20);
            this.panel2.TabIndex = 2;
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
            this.buttonExit.Location = new System.Drawing.Point(395, 0);
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
            this.label11.Size = new System.Drawing.Size(412, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Лицензии";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
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
            this.dataGridViewLicenses.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCabinet,
            this.ColumnSoftware,
            this.ColumnCheck});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLicenses.Location = new System.Drawing.Point(150, 20);
            this.dataGridViewLicenses.Name = "dataGridViewLicenses";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLicenses.RowHeadersVisible = false;
            this.dataGridViewLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLicenses.Size = new System.Drawing.Size(415, 380);
            this.dataGridViewLicenses.TabIndex = 25;
            this.dataGridViewLicenses.DoubleClick += new System.EventHandler(this.DataGridViewLicenses_DoubleClick);
            // 
            // ColumnCabinet
            // 
            this.ColumnCabinet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnCabinet.Frozen = true;
            this.ColumnCabinet.HeaderText = "Кабинет";
            this.ColumnCabinet.Name = "ColumnCabinet";
            this.ColumnCabinet.ReadOnly = true;
            this.ColumnCabinet.Width = 60;
            // 
            // ColumnSoftware
            // 
            this.ColumnSoftware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnSoftware.Frozen = true;
            this.ColumnSoftware.HeaderText = "Программное обеспечение";
            this.ColumnSoftware.Name = "ColumnSoftware";
            this.ColumnSoftware.ReadOnly = true;
            this.ColumnSoftware.Width = 200;
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnCheck.Frozen = true;
            this.ColumnCheck.HeaderText = "Лицензия/Не лицензия";
            this.ColumnCheck.Name = "ColumnCheck";
            this.ColumnCheck.ReadOnly = true;
            this.ColumnCheck.Width = 150;
            // 
            // LicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 398);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewLicenses);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(565, 400);
            this.MinimumSize = new System.Drawing.Size(565, 400);
            this.Name = "LicensesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LicensesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ExpUI.dll.ExpUIButton expUIButtonDelete;
        private ExpUI.dll.ExpUIButton expUIButtonAdd;
        private ExpUI.dll.ExpUIButton expUIButtonRefresh;
        private System.Windows.Forms.Panel panel2;
        private ExpUI.dll.ExpUIButtonIcon buttonExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxRequest;
        private System.Windows.Forms.DataGridView dataGridViewLicenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCabinet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoftware;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheck;
    }
}