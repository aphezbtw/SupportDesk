using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExpUI.dll
{
    public class ExpUIButton : Control
    {
        /*
         * Добавить стиль: Rounded
         * Добавить анимации
         * Добавить AutoSize под текст
         * Добавить возможность двух icon справа и слева
        */
        #region Private field
        private StringFormat _StringFormat = new StringFormat();
        private bool MouseEntered = false;
        private bool UseMouseClick = false;
        #endregion
        #region Public field
        [Category("ExpUI Properties")]
        [Description("Шрифт, используемый при включенном адаптивном тексте")]
        public Font ResponsiveFontOn { get; set; } = new Font("Arial", 12F, FontStyle.Bold);
        [Category("ExpUI Properties")]
        [DisplayName("Адаптивный текст")]
        [Description("Увеличение текста, при наведении")]
        public bool ResponsiveText { get; set; } = false;
        [Category("ExpUI Properties")]
        [Description("Цвет кнопки, при наведении")]
        public Color HoverColor { get; set; } = Color.FromArgb(25, Color.Black);
        [Category("ExpUI Properties")]
        [Description("Цвет кнопки, при нажатии")]
        public Color ClickColor { get; set; } = Color.FromArgb(80, Color.White);
        [Category("ExpUI Properties")]
        [Description("Цвет кнопки, при Enabled = false")]
        public Color DisableColor { get; set; } = Color.FromArgb(80, Color.White);
        [Category("ExpUI Properties")]
        [Description("Размер рамки")]
        public int BorderSize { get; set; } = 1;
        [Category("ExpUI Properties")]
        [Description("Стиль кнопки")]
        public styleButton StyleButton { get; set; } = styleButton.Standart;
        public enum styleButton
        {
            Standart,
            Border,
            BorderRemember
        }
        [Category("ExpUI Properties")]
        [Description("Изображение, которое будет отображаться (Слева)")]
        public Image Image { get; set; }
        [Category("ExpUI Properties")]
        [Description("Цвет текста, когда включена рамка")]
        public Color ColorTextForBorder { get; set; } = Color.White;
        [Category("ExpUI Properties")]
        [Description("Выравнивание текста")]
        public textAlign TextAlign { get; set; } = textAlign.MiddleCenter;
        public enum textAlign
        {
            TopLeft,
            TopRight,
            MiddleLeft,
            MiddleCenter,
            MiddleRight,
            BottomLeft,
            BottomCenter,
            BottomRight
        }
        public bool Remember { get; set; } = false;
        #endregion
        public ExpUIButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor
                | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(200, 35);
            Font = new Font("Arial", 9.75F, FontStyle.Bold);
            ForeColor = Color.White;
            BackColor = Color.DodgerBlue;
            TabIndex = 1;
            Cursor = Cursors.Hand;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectImageLeft = new Rectangle(5, 2, 32, 32);
            Rectangle rectText = new Rectangle(0, 0, Width - 5, Height - 1);
            ButtonStyle(graph, rect, rectText);
            if (UseMouseClick)
            {
                graph.DrawRectangle(new Pen(ClickColor), rect);
                graph.FillRectangle(new SolidBrush(ClickColor), rect);
            }
            if (Image != null)
                graph.DrawImage(Image, rectImageLeft);
            if (!Enabled)
            {
                graph.DrawRectangle(new Pen(DisableColor), rect);
                graph.FillRectangle(new SolidBrush(DisableColor), rect);
                graph.FillRectangle(new SolidBrush(DisableColor), rectImageLeft);
                graph.FillRectangle(new SolidBrush(DisableColor), rectText);
            }
            if (MouseEntered && ResponsiveText)
                Font = new Font("Arial", 12F, FontStyle.Bold);
            else if (!MouseEntered && ResponsiveText)
                Font = new Font("Arial", 9.75F, FontStyle.Bold);
        }
        private void ButtonStyle(Graphics graph, Rectangle rect, Rectangle rectText)
        {
            if (StyleButton == styleButton.Border)
            {
                graph.DrawRectangle(new Pen(BackColor, BorderSize), rect);
                graph.DrawString(Text, Font, new SolidBrush(ForeColor), rectText, ButtonTextAlign());
            }
            else if (Remember && StyleButton == styleButton.BorderRemember)
            {
                graph.DrawRectangle(new Pen(BackColor), rect);
                graph.FillRectangle(new SolidBrush(BackColor), rect);
                graph.DrawString(Text, Font, new SolidBrush(ColorTextForBorder), rectText, ButtonTextAlign());
            }
            else if (!Remember && StyleButton == styleButton.BorderRemember)
            {
                graph.DrawRectangle(new Pen(BackColor, BorderSize), rect);
                graph.DrawString(Text, Font, new SolidBrush(ForeColor), rectText, ButtonTextAlign());
            }
            else
            {
                graph.DrawRectangle(new Pen(BackColor), rect);
                graph.FillRectangle(new SolidBrush(BackColor), rect);
                graph.DrawString(Text, Font, new SolidBrush(ForeColor), rectText, ButtonTextAlign());
            }
            if (MouseEntered && StyleButton == styleButton.Border)
            {
                graph.FillRectangle(new SolidBrush(BackColor), rect);
                graph.DrawString(Text, Font, new SolidBrush(ColorTextForBorder), rectText, ButtonTextAlign());
            }
            else if (MouseEntered)
            {
                graph.DrawRectangle(new Pen(HoverColor), rect);
                graph.FillRectangle(new SolidBrush(HoverColor), rect);
            }
        }
        private StringFormat ButtonTextAlign()
        {
            if (TextAlign == textAlign.MiddleCenter)
            {
                _StringFormat.Alignment = StringAlignment.Center;
                _StringFormat.LineAlignment = StringAlignment.Center;
                return _StringFormat;
            }
            else if (TextAlign == textAlign.MiddleRight)
            {
                _StringFormat.Alignment = StringAlignment.Far;
                _StringFormat.LineAlignment = StringAlignment.Center;
                return _StringFormat;
            }
            else if (TextAlign == textAlign.MiddleLeft)
            {
                _StringFormat.Alignment = StringAlignment.Near;
                _StringFormat.LineAlignment = StringAlignment.Center;
                return _StringFormat;
            }
            else if (TextAlign == textAlign.TopLeft)
            {
                _StringFormat.Alignment = StringAlignment.Near;
                _StringFormat.LineAlignment = StringAlignment.Near;
                return _StringFormat;
            }
            else if (TextAlign == textAlign.TopRight)
            {
                _StringFormat.Alignment = StringAlignment.Far;
                _StringFormat.LineAlignment = StringAlignment.Near;
                return _StringFormat;
            }
            else if (TextAlign == textAlign.BottomCenter)
            {
                _StringFormat.Alignment = StringAlignment.Center;
                _StringFormat.LineAlignment = StringAlignment.Far;
                return _StringFormat;
            }
            else if (TextAlign == textAlign.BottomRight)
            {
                _StringFormat.Alignment = StringAlignment.Far;
                _StringFormat.LineAlignment = StringAlignment.Far;
                return _StringFormat;
            }
            else if (TextAlign == textAlign.BottomLeft)
            {
                _StringFormat.Alignment = StringAlignment.Near;
                _StringFormat.LineAlignment = StringAlignment.Far;
                return _StringFormat;
            }
            else return _StringFormat;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            UseMouseClick = true;
            if (!Remember)
                Remember = true;
            else
                Remember = false;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            UseMouseClick = false;
            Invalidate();
        }
    }
}