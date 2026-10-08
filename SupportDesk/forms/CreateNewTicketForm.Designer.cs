namespace SupportDesk.forms
{
    partial class CreateNewTicketForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewTicketForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDiscription = new System.Windows.Forms.TextBox();
            this.comboBoxKab = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLoadDocs = new System.Windows.Forms.Button();
            this.buttonSendRequest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxExecutor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxTime4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTime3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTime2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTime1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.expUIButtonFile = new ExpUI.dll.ExpUIButton();
            this.buttonExit = new ExpUI.dll.ExpUIButtonIcon();
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
            this.panel2.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(500, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Новая задача";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "Тема задачи:";
            // 
            // textBoxTema
            // 
            this.textBoxTema.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTema.Location = new System.Drawing.Point(10, 50);
            this.textBoxTema.MaxLength = 50;
            this.textBoxTema.Name = "textBoxTema";
            this.textBoxTema.Size = new System.Drawing.Size(330, 22);
            this.textBoxTema.TabIndex = 1;
            this.textBoxTema.TextChanged += new System.EventHandler(this.CheckTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Тип работы:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.White;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(10, 102);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(256, 24);
            this.comboBoxType.TabIndex = 2;
            this.comboBoxType.TextChanged += new System.EventHandler(this.CheckTextBox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 77;
            this.label5.Text = "Описание работы:";
            // 
            // textBoxDiscription
            // 
            this.textBoxDiscription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDiscription.Location = new System.Drawing.Point(10, 210);
            this.textBoxDiscription.MaxLength = 500;
            this.textBoxDiscription.Multiline = true;
            this.textBoxDiscription.Name = "textBoxDiscription";
            this.textBoxDiscription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDiscription.Size = new System.Drawing.Size(330, 100);
            this.textBoxDiscription.TabIndex = 4;
            this.textBoxDiscription.TextChanged += new System.EventHandler(this.CheckTextBox);
            // 
            // comboBoxKab
            // 
            this.comboBoxKab.BackColor = System.Drawing.Color.White;
            this.comboBoxKab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxKab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKab.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxKab.FormattingEnabled = true;
            this.comboBoxKab.Location = new System.Drawing.Point(10, 156);
            this.comboBoxKab.Name = "comboBoxKab";
            this.comboBoxKab.Size = new System.Drawing.Size(256, 24);
            this.comboBoxKab.TabIndex = 3;
            this.comboBoxKab.TextChanged += new System.EventHandler(this.CheckTextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Номер кабинета:";
            // 
            // buttonLoadDocs
            // 
            this.buttonLoadDocs.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLoadDocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadDocs.FlatAppearance.BorderSize = 0;
            this.buttonLoadDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadDocs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadDocs.ForeColor = System.Drawing.Color.White;
            this.buttonLoadDocs.Location = new System.Drawing.Point(180, 480);
            this.buttonLoadDocs.Name = "buttonLoadDocs";
            this.buttonLoadDocs.Size = new System.Drawing.Size(160, 30);
            this.buttonLoadDocs.TabIndex = 12;
            this.buttonLoadDocs.Text = "Прикрепить документ";
            this.buttonLoadDocs.UseVisualStyleBackColor = false;
            this.buttonLoadDocs.Click += new System.EventHandler(this.ButtonLoadDocs_Click);
            // 
            // buttonSendRequest
            // 
            this.buttonSendRequest.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSendRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendRequest.Enabled = false;
            this.buttonSendRequest.FlatAppearance.BorderSize = 0;
            this.buttonSendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendRequest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendRequest.ForeColor = System.Drawing.Color.White;
            this.buttonSendRequest.Location = new System.Drawing.Point(10, 480);
            this.buttonSendRequest.Name = "buttonSendRequest";
            this.buttonSendRequest.Size = new System.Drawing.Size(160, 30);
            this.buttonSendRequest.TabIndex = 11;
            this.buttonSendRequest.Text = "Отправить задачу";
            this.buttonSendRequest.UseVisualStyleBackColor = false;
            this.buttonSendRequest.Click += new System.EventHandler(this.ButtonSendRequest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(350, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 500);
            this.panel1.TabIndex = 80;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(350, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 2);
            this.panel3.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(350, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 82;
            this.label3.Text = "Вложения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 16);
            this.label6.TabIndex = 83;
            this.label6.Text = "Предварительный исполнитель:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 84;
            this.label7.Text = "Срок (до):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 16);
            this.label8.TabIndex = 85;
            this.label8.Text = "Желаемый интервал времени прихода специалиста:";
            // 
            // comboBoxExecutor
            // 
            this.comboBoxExecutor.BackColor = System.Drawing.Color.White;
            this.comboBoxExecutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxExecutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExecutor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxExecutor.FormattingEnabled = true;
            this.comboBoxExecutor.Location = new System.Drawing.Point(10, 340);
            this.comboBoxExecutor.Name = "comboBoxExecutor";
            this.comboBoxExecutor.Size = new System.Drawing.Size(150, 24);
            this.comboBoxExecutor.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(10, 394);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // textBoxTime4
            // 
            this.textBoxTime4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTime4.Location = new System.Drawing.Point(169, 447);
            this.textBoxTime4.MaxLength = 2;
            this.textBoxTime4.Name = "textBoxTime4";
            this.textBoxTime4.Size = new System.Drawing.Size(20, 22);
            this.textBoxTime4.TabIndex = 10;
            this.textBoxTime4.TextChanged += new System.EventHandler(this.CheckTextBox);
            this.textBoxTime4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(153, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 16);
            this.label10.TabIndex = 95;
            this.label10.Text = ":";
            // 
            // textBoxTime3
            // 
            this.textBoxTime3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTime3.Location = new System.Drawing.Point(127, 447);
            this.textBoxTime3.MaxLength = 2;
            this.textBoxTime3.Name = "textBoxTime3";
            this.textBoxTime3.Size = new System.Drawing.Size(20, 22);
            this.textBoxTime3.TabIndex = 9;
            this.textBoxTime3.TextChanged += new System.EventHandler(this.CheckTextBox);
            this.textBoxTime3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(102, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 16);
            this.label9.TabIndex = 94;
            this.label9.Text = "до";
            // 
            // textBoxTime2
            // 
            this.textBoxTime2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTime2.Location = new System.Drawing.Point(74, 447);
            this.textBoxTime2.MaxLength = 2;
            this.textBoxTime2.Name = "textBoxTime2";
            this.textBoxTime2.Size = new System.Drawing.Size(20, 22);
            this.textBoxTime2.TabIndex = 8;
            this.textBoxTime2.TextChanged += new System.EventHandler(this.CheckTextBox);
            this.textBoxTime2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(58, 450);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 16);
            this.label12.TabIndex = 93;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(10, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 16);
            this.label13.TabIndex = 92;
            this.label13.Text = "c";
            // 
            // textBoxTime1
            // 
            this.textBoxTime1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTime1.Location = new System.Drawing.Point(32, 447);
            this.textBoxTime1.MaxLength = 2;
            this.textBoxTime1.Name = "textBoxTime1";
            this.textBoxTime1.Size = new System.Drawing.Size(20, 22);
            this.textBoxTime1.TabIndex = 7;
            this.textBoxTime1.TextChanged += new System.EventHandler(this.CheckTextBox);
            this.textBoxTime1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Выберите файл";
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
            this.expUIButtonFile.TabIndex = 13;
            this.expUIButtonFile.Text = "Название файла";
            this.expUIButtonFile.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleRight;
            this.toolTip1.SetToolTip(this.expUIButtonFile, "Открыть файл");
            this.expUIButtonFile.Visible = false;
            this.expUIButtonFile.Click += new System.EventHandler(this.ExpUIButtonFile_Click);
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
            // CreateNewTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 518);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxTime4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxTime3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxTime2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxTime1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxExecutor);
            this.Controls.Add(this.expUIButtonFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLoadDocs);
            this.Controls.Add(this.buttonSendRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDiscription);
            this.Controls.Add(this.comboBoxKab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTema);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 520);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "CreateNewTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CreateNewTicketForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private ExpUI.dll.ExpUIButtonIcon buttonExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDiscription;
        private System.Windows.Forms.ComboBox comboBoxKab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLoadDocs;
        private System.Windows.Forms.Button buttonSendRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ExpUI.dll.ExpUIButton expUIButtonFile;
        private System.Windows.Forms.ComboBox comboBoxExecutor;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxTime4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTime3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTime2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxTime1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}