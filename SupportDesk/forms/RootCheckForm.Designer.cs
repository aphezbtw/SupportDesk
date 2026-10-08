namespace SupportDesk.forms
{
    partial class RootCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootCheckForm));
            this.textBoxUIRoot = new MaterialUIPack.dll.textBoxUI();
            this.expUIButtonAccept = new ExpUI.dll.ExpUIButton();
            this.expUIButtonClose = new ExpUI.dll.ExpUIButton();
            this.SuspendLayout();
            // 
            // textBoxUIRoot
            // 
            this.textBoxUIRoot.BackColor = System.Drawing.Color.White;
            this.textBoxUIRoot.BorderColor = System.Drawing.Color.Black;
            this.textBoxUIRoot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUIRoot.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUIRoot.FontColor = System.Drawing.Color.Black;
            this.textBoxUIRoot.FontTextPreview = new System.Drawing.Font("Arial", 9.75F);
            this.textBoxUIRoot.ForeColor = System.Drawing.Color.Black;
            this.textBoxUIRoot.Location = new System.Drawing.Point(12, 12);
            this.textBoxUIRoot.Name = "textBoxUIRoot";
            this.textBoxUIRoot.Size = new System.Drawing.Size(276, 50);
            this.textBoxUIRoot.TabIndex = 4;
            this.textBoxUIRoot.TextPreview = "Введите ROOT-пароль";
            this.textBoxUIRoot.UseSystemPasswordChar = false;
            // 
            // expUIButtonAccept
            // 
            this.expUIButtonAccept.BackColor = System.Drawing.Color.DodgerBlue;
            this.expUIButtonAccept.BorderSize = 1;
            this.expUIButtonAccept.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonAccept.ColorTextForBorder = System.Drawing.Color.White;
            this.expUIButtonAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonAccept.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonAccept.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIButtonAccept.ForeColor = System.Drawing.Color.White;
            this.expUIButtonAccept.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonAccept.Image = null;
            this.expUIButtonAccept.Location = new System.Drawing.Point(12, 68);
            this.expUIButtonAccept.Name = "expUIButtonAccept";
            this.expUIButtonAccept.Remember = false;
            this.expUIButtonAccept.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.expUIButtonAccept.ResponsiveText = false;
            this.expUIButtonAccept.Size = new System.Drawing.Size(130, 35);
            this.expUIButtonAccept.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.expUIButtonAccept.TabIndex = 1;
            this.expUIButtonAccept.Text = "Подтвердить";
            this.expUIButtonAccept.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleCenter;
            this.expUIButtonAccept.Click += new System.EventHandler(this.ExpUIButtonAccept_Click);
            // 
            // expUIButtonClose
            // 
            this.expUIButtonClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.expUIButtonClose.BorderSize = 1;
            this.expUIButtonClose.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonClose.ColorTextForBorder = System.Drawing.Color.White;
            this.expUIButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expUIButtonClose.DisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expUIButtonClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.expUIButtonClose.ForeColor = System.Drawing.Color.White;
            this.expUIButtonClose.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expUIButtonClose.Image = null;
            this.expUIButtonClose.Location = new System.Drawing.Point(158, 68);
            this.expUIButtonClose.Name = "expUIButtonClose";
            this.expUIButtonClose.Remember = false;
            this.expUIButtonClose.ResponsiveFontOn = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.expUIButtonClose.ResponsiveText = false;
            this.expUIButtonClose.Size = new System.Drawing.Size(130, 35);
            this.expUIButtonClose.StyleButton = ExpUI.dll.ExpUIButton.styleButton.Standart;
            this.expUIButtonClose.TabIndex = 5;
            this.expUIButtonClose.Text = "Отмена";
            this.expUIButtonClose.TextAlign = ExpUI.dll.ExpUIButton.textAlign.MiddleCenter;
            this.expUIButtonClose.Click += new System.EventHandler(this.ExpUIButtonClose_Click);
            // 
            // RootCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 113);
            this.ControlBox = false;
            this.Controls.Add(this.expUIButtonClose);
            this.Controls.Add(this.expUIButtonAccept);
            this.Controls.Add(this.textBoxUIRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 115);
            this.MinimumSize = new System.Drawing.Size(300, 115);
            this.Name = "RootCheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RootCheckForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialUIPack.dll.textBoxUI textBoxUIRoot;
        private ExpUI.dll.ExpUIButton expUIButtonAccept;
        private ExpUI.dll.ExpUIButton expUIButtonClose;
    }
}