using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExpUI.dll
{
    public class ExpUIButtonIcon : Control
    {
        #region Private Field
        private bool MouseEntered = false;
        private bool UseMouseClick = false;
        #endregion
        #region Public Field
        [Category("ExpUI Properties")]
        [Description("Цвет кнопки, при Remember = true")]
        public Color RememberColor { get; set; } = Color.White;
        [Category("ExpUI Properties")]
        [Description("Цвет кнопки, при Enabled = false")]
        public Color DisableColor { get; set; } = Color.FromArgb(80, Color.White);
        [Category("ExpUI Properties")]
        [Description("Цвет кнопки, при нажатии")]
        public Color ClickColor { get; set; } = Color.FromArgb(80, Color.White);
        [Category("ExpUI Properties")]
        [Description("Цвет кнопки, при наведении")]
        public Color HoverColor { get; set; } = Color.FromArgb(25, Color.Black);
        [Category("ExpUI Properties")]
        [Description("Размер рамки")]
        public int BorderSize { get; set; } = 1;
        [Category("ExpUI Properties")]
        [Description("Цвет рамки")]
        public Color BorderColor { get; set; } = Color.Black;
        [Category("ExpUI Properties")]
        [Description("Изображение иконки")]
        public Image Image { get; set; }
        [Category("ExpUI Properties")]
        [Description("Отображение рамки")]
        public bool ShowBorder { get; set; } = true;
        [Category("ExpUI Properties")]
        [Description("Стиль кнопки")]
        public styleButton StyleButton { get; set; } = styleButton.Standart;
        public enum styleButton
        {
            Standart,
            Border,
            Remember,
            Rounded,
            RoundedBorder,
            RememberRounded
        }
        public bool Remember { get; set; } = false;
        #endregion
        public ExpUIButtonIcon()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor
            | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(35, 35);
            Cursor = Cursors.Hand;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectImage = new Rectangle(2, 2, Width - 5, Height - 5);
            Rectangle rectRound = new Rectangle(7, 7, Width - 15, Height - 15);
            ButtonStyle(graph, rect, rectRound, rectImage);
            if (!Enabled)
            {
                graph.DrawRectangle(new Pen(DisableColor), rect);
                graph.FillRectangle(new SolidBrush(DisableColor), rect);
                graph.FillRectangle(new SolidBrush(DisableColor), rectImage);
                graph.FillRectangle(new SolidBrush(DisableColor), rectRound);
            }
        }
        private void ButtonStyle(Graphics graph, Rectangle rect, Rectangle rectRound, Rectangle rectImage)
        {
            if (StyleButton == styleButton.Standart)
            {
                graph.FillRectangle(new SolidBrush(BackColor), rect);
                if (MouseEntered && ShowBorder)
                    graph.DrawRectangle(new Pen(BorderColor, BorderSize), rect);
                else if (MouseEntered && !ShowBorder)
                    graph.FillRectangle(new SolidBrush(HoverColor), rect);
                if (UseMouseClick)
                {
                    graph.DrawRectangle(new Pen(ClickColor), rect);
                    graph.FillRectangle(new SolidBrush(ClickColor), rect);
                }
                if (Image != null)
                    graph.DrawImage(Image, rectImage);
            }
            else if (StyleButton == styleButton.Border)
            {
                graph.DrawRectangle(new Pen(BorderColor, BorderSize), rect);
                if (MouseEntered && ShowBorder)
                    graph.FillRectangle(new SolidBrush(HoverColor), rect);
                else if (MouseEntered && !ShowBorder)
                {
                    graph.DrawRectangle(new Pen(BackColor), rect);
                    graph.FillRectangle(new SolidBrush(BackColor), rect);
                }
                if (UseMouseClick)
                {
                    graph.DrawRectangle(new Pen(ClickColor), rect);
                    graph.FillRectangle(new SolidBrush(ClickColor), rect);
                }
                if (Image != null)
                    graph.DrawImage(Image, rectImage);
            }
            else if (StyleButton == styleButton.Remember && Remember)
            {
                graph.FillRectangle(new SolidBrush(RememberColor), rect);
                if (MouseEntered && ShowBorder)
                    graph.DrawRectangle(new Pen(BorderColor, BorderSize), rect);
                else if (MouseEntered && !ShowBorder)
                    graph.FillRectangle(new SolidBrush(HoverColor), rect);
                if (UseMouseClick)
                {
                    graph.DrawRectangle(new Pen(RememberColor), rect);
                    graph.FillRectangle(new SolidBrush(RememberColor), rect);
                }
                if (Image != null)
                    graph.DrawImage(Image, rectImage);
            }
            else if (StyleButton == styleButton.Remember && !Remember)
            {
                graph.FillRectangle(new SolidBrush(BackColor), rect);
                if (MouseEntered && ShowBorder)
                    graph.DrawRectangle(new Pen(BorderColor, BorderSize), rect);
                else if (MouseEntered && !ShowBorder)
                    graph.FillRectangle(new SolidBrush(HoverColor), rect);
                if (UseMouseClick)
                {
                    graph.DrawRectangle(new Pen(RememberColor), rect);
                    graph.FillRectangle(new SolidBrush(RememberColor), rect);
                }
                if (Image != null)
                    graph.DrawImage(Image, rectImage);
            }
            else if (StyleButton == styleButton.Rounded)
            {
                graph.FillPath(new SolidBrush(BackColor), GetFigurePath());
                if (MouseEntered && ShowBorder)
                    graph.DrawPath(new Pen(BorderColor, BorderSize), GetFigurePath());
                else if (MouseEntered && !ShowBorder)
                    graph.FillPath(new SolidBrush(HoverColor), GetFigurePath());
                if (UseMouseClick)
                {
                    graph.DrawPath(new Pen(ClickColor), GetFigurePath());
                    graph.FillPath(new SolidBrush(ClickColor), GetFigurePath());
                }
                if (Image != null)
                    graph.DrawImage(Image, rectRound);
            }
            else if (StyleButton == styleButton.RoundedBorder)
            {
                graph.DrawPath(new Pen(BorderColor, BorderSize), GetFigurePath());
                if (MouseEntered)
                    graph.FillPath(new SolidBrush(HoverColor), GetFigurePath());
                if (UseMouseClick)
                {
                    graph.DrawPath(new Pen(ClickColor), GetFigurePath());
                    graph.FillPath(new SolidBrush(ClickColor), GetFigurePath());
                }
                if (Image != null)
                    graph.DrawImage(Image, rectRound);
            }
            else if (StyleButton == styleButton.RememberRounded && Remember)
            {
                graph.FillPath(new SolidBrush(RememberColor), GetFigurePath());
                if (MouseEntered && ShowBorder)
                    graph.DrawPath(new Pen(BorderColor, BorderSize), GetFigurePath());
                else if (MouseEntered && !ShowBorder)
                    graph.FillPath(new SolidBrush(HoverColor), GetFigurePath());
                if (UseMouseClick)
                {
                    graph.DrawPath(new Pen(RememberColor), GetFigurePath());
                    graph.FillPath(new SolidBrush(RememberColor), GetFigurePath());
                }
                if (Image != null)
                    graph.DrawImage(Image, rectRound);
            }
            else if (StyleButton == styleButton.RememberRounded && !Remember)
            {
                graph.FillPath(new SolidBrush(BackColor), GetFigurePath());
                if (MouseEntered && ShowBorder)
                    graph.DrawPath(new Pen(BorderColor, BorderSize), GetFigurePath());
                else if (MouseEntered && !ShowBorder)
                    graph.FillPath(new SolidBrush(HoverColor), GetFigurePath());
                if (UseMouseClick)
                {
                    graph.DrawPath(new Pen(RememberColor), GetFigurePath());
                    graph.FillPath(new SolidBrush(RememberColor), GetFigurePath());
                }
                if (Image != null)
                    graph.DrawImage(Image, rectRound);
            }
        }
        private GraphicsPath GetFigurePath()
        {
            int arcSize = Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
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
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            BackColor = BackColor;
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