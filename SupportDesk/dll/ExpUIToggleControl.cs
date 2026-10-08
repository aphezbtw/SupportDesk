using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExpUI.dll
{
    public class ExpUIToggleControl : Control
    {
        #region Private Field
        private StringFormat StringFormatOFF = new StringFormat();
        private StringFormat StringFormatON = new StringFormat();
        #endregion
        #region Public Field
        public bool SwitchOnOff = false;
        [Category("ExpUI Properties")]
        [Description("Цвет кнопки, при Enabled = false")]
        public Color DisableColor { get; set; } = Color.FromArgb(80, Color.White);
        [Category("ExpUI Properties")]
        [Description("Основной цвет, когда ВКЛ")]
        public Color ColorMainON { get; set; } = Color.Green;
        [Category("ExpUI Properties")]
        [Description("Основной цвет, когда ВЫКЛ")]
        public Color ColorMainOFF { get; set; } = Color.Red;
        [Category("ExpUI Properties")]
        [Description("Цвет шара, когда ВКЛ")]
        public Color ColorON { get; set; } = Color.White;
        [Category("ExpUI Properties")]
        [Description("Цвет шара, когда ВЫКЛ")]
        public Color ColorOFF { get; set; } = Color.White;
        [Category("ExpUI Properties")]
        [Description("Цвет текста, когда ВКЛ")]
        public Color ColorTextON { get; set; } = Color.White;
        [Category("ExpUI Properties")]
        [Description("Цвет текста, когда ВЫКЛ")]
        public Color ColorTextOFF { get; set; } = Color.Black;
        [Category("ExpUI Properties")]
        [Description("Используется для закрашивания")]
        public bool SolidStyle { get; set; } = true;
        [Category("ExpUI Properties")]
        [Description("Использовать текст")]
        public bool UseText { get; set; } = false;
        #endregion
        public ExpUIToggleControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor
            | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(60, 25);
            Font = new Font("Arial", 9.75F, FontStyle.Bold);
            Cursor = Cursors.Hand;
            StringFormatOFF.Alignment = StringAlignment.Far;
            StringFormatOFF.LineAlignment = StringAlignment.Center;
            StringFormatON.Alignment = StringAlignment.Near;
            StringFormatON.LineAlignment = StringAlignment.Center;
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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int toggleSize = Height - 5;
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);
            Rectangle rectTextOFF = new Rectangle(0, 0, Width - 6, Height - 1);
            Rectangle rectTextON = new Rectangle(8, 0, Width - 1, Height - 1);
            if (SwitchOnOff)
            {
                if (SolidStyle)
                    graph.FillPath(new SolidBrush(ColorMainON), GetFigurePath());
                else graph.DrawPath(new Pen(ColorMainON, 2), GetFigurePath());
                graph.FillEllipse(new SolidBrush(ColorON), new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));
                if (UseText)
                    graph.DrawString("ON", Font, new SolidBrush(ColorTextON), rectTextON, StringFormatON);
            }
            else
            {
                if (SolidStyle)
                    graph.FillPath(new SolidBrush(ColorMainOFF), GetFigurePath());
                else graph.DrawPath(new Pen(ColorMainOFF, 2), GetFigurePath());
                graph.FillEllipse(new SolidBrush(ColorOFF), new Rectangle(2, 2, toggleSize, toggleSize));
                if (UseText)
                    graph.DrawString("OFF", Font, new SolidBrush(ColorTextOFF), rectTextOFF, StringFormatOFF);
            }
            if (!Enabled)
            {
                graph.DrawPath(new Pen(DisableColor), GetFigurePath());
                graph.FillPath(new SolidBrush(DisableColor), GetFigurePath());
                graph.FillEllipse(new SolidBrush(DisableColor), new Rectangle(2, 2, toggleSize, toggleSize));
                graph.DrawString("ON", Font, new SolidBrush(DisableColor), rectTextON, StringFormatON);
                graph.DrawString("OFF", Font, new SolidBrush(DisableColor), rectTextOFF, StringFormatOFF);
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            SwitchOnOff = !SwitchOnOff;
            Invalidate();
        }
    }
}