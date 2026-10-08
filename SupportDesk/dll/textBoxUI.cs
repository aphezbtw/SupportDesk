using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MaterialUIPack.dll
{
    public class textBoxUI : Control
    {
        [Category("Appearance")]
        [Description("Цвет обводки textBox")]
        public Color BorderColor { get; set; } = Color.Black;
        [Category("Appearance")]
        [Description("Заголовок")]
        public string TextPreview { get; set; } = "Input text";
        [Category("Appearance")]
        [Description("Шрифт, используемый для отображения заголовка")]
        public Font FontTextPreview { get; set; } = new Font("Arial", 9.75f, FontStyle.Regular);
        [Category("Appearance")]
        [Description("Цвет заголовка")]
        public Color FontColor { get; set; } = Color.Black;
        [Category("Behavior")]
        [Description("Используется для пароля")]
        public bool UseSystemPasswordChar
		{
			get => tbInput.UseSystemPasswordChar;
			set => tbInput.UseSystemPasswordChar = value;
		}
        private StringFormat _StringFormat = new StringFormat();
        TextBox tbInput = new TextBox();
        int topBorderOffSet = 0;
        public textBoxUI()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor
            | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(200, 50);
            Cursor = Cursors.IBeam;
            BackColor = Color.White;
            ForeColor = Color.Black;
            _StringFormat.Alignment = StringAlignment.Center;
            _StringFormat.LineAlignment = StringAlignment.Center;
            AdjustTextBoxInput();
            Controls.Add(tbInput);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);
            topBorderOffSet = graph.MeasureString(TextPreview, FontTextPreview).ToSize().Height / 2;
            //Основной прямоугольник
            Rectangle rect = new Rectangle(0, topBorderOffSet, Width - 1, Height - 1 - topBorderOffSet);
            Size TextPreviewRectSize = graph.MeasureString(TextPreview, FontTextPreview).ToSize();
            Rectangle rectTextPreview = new Rectangle(5,0, TextPreviewRectSize.Width + 3, TextPreviewRectSize.Height);
            //Обводка
            graph.DrawRectangle(new Pen(BorderColor), rect);
            //Заголовок
            graph.DrawRectangle(new Pen(Parent.BackColor), rectTextPreview);
            graph.FillRectangle(new SolidBrush(Parent.BackColor), rectTextPreview);
            //Цвет внутри
            graph.FillRectangle(new SolidBrush(BackColor), rect);
            graph.DrawString(TextPreview, FontTextPreview, new SolidBrush(FontColor), rectTextPreview, _StringFormat);
        }
        private void AdjustTextBoxInput()
        {
            tbInput = new TextBox();
            tbInput.Name = "InputBox";
            tbInput.BorderStyle = BorderStyle.None;
            tbInput.BackColor = BackColor;
            tbInput.ForeColor = ForeColor;
            tbInput.Font = Font;
            int offset = TextRenderer.MeasureText(TextPreview, FontTextPreview).Height / 2;
            tbInput.Location = new Point(5, Height / 2 - offset);
            tbInput.Size = new Size(Width - 10, tbInput.Height);
            tbInput.TextChanged += TbInput_TextChanged;
        }
        private void TbInput_TextChanged(object sender, EventArgs e)
        {
            Text = tbInput.Text;
        }
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            tbInput.BackColor = BackColor;
        }
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            tbInput.ForeColor = ForeColor;
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            tbInput.Font = Font;
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            tbInput.Text = Text;
        }
        protected override void OnTabStopChanged(EventArgs e)
        {
            base.OnTabStopChanged(e);
            tbInput.TabStop = true;
        }
    }
}
