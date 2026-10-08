using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExpUI.dll
{
    public class ExpUICheckBox : Control
    {
        /*
         * Заливка + Image
         */ 
        #region Private Field
        private StringFormat _StringFormat = new StringFormat();
        private bool MouseEntered = false;
        #endregion
        #region Public Field
        public bool isChecked { get; set; } = false;
        [Category("ExpUI Properties")]
        [Description("Цвет заливки, без Image")]
        public Color FillColor { get; set; } = Color.DodgerBlue;
        [Category("ExpUI Properties")]
        [Description("Цвет рамки")]
        public Color BorderColor { get; set; } = Color.Black;
        [Category("ExpUI Properties")]
        [Description("Цвет, при наведении")]
        public Color HoverColor { get; set; } = Color.DodgerBlue;
        [Category("ExpUI Properties")]
        [Description("Цвет, при Enabled = false")]
        public Color DisableColor { get; set; } = Color.FromArgb(80, Color.White);
        [Category("ExpUI Properties")]
        [Description("Стиль CheckBox")]
        public styleButton Style { get; set; } = styleButton.Standart;
        public enum styleButton
        {
            Standart,
            Big
        }
        [Category("ExpUI Properties")]
        [Description("Изображение, которое будет отображаться (Внутри)")]
        public Image Image { get; set; }
        #endregion
        public ExpUICheckBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor
                | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(110, 17);
            Font = new Font("Arial", 8.25F);
            BackColor = Color.White;
            TabIndex = 1;
            Cursor = Cursors.Hand;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);
            Rectangle rectMain = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectBlock = new Rectangle(0, 0, 15, 15);
            Rectangle rectBlockBig = new Rectangle(0, 0, 20, 20);
            Rectangle rectImageBlock = new Rectangle(1, 1, 13, 13);
            Rectangle rectImageBlockBig = new Rectangle(1, 1, 18, 18);
            Rectangle rectText = new Rectangle(10, 0, Width - 5, Height - 1);
            CheckBoxStyle(graph, rectMain, rectBlock, rectBlockBig, rectImageBlock, rectImageBlockBig, rectText);
            if (!Enabled)
            {
                graph.DrawRectangle(new Pen(DisableColor), rectMain);
                graph.DrawRectangle(new Pen(DisableColor), rectBlock);
                graph.DrawRectangle(new Pen(DisableColor), rectBlockBig);
                graph.FillRectangle(new SolidBrush(DisableColor), rectImageBlock);
                graph.FillRectangle(new SolidBrush(DisableColor), rectImageBlockBig);
                graph.FillRectangle(new SolidBrush(DisableColor), rectText);
            }
        }
        private void CheckBoxStyle(Graphics graph, Rectangle rectMain, Rectangle rectBlock, Rectangle rectBlockBig, Rectangle rectImageBlock, Rectangle rectImageBlockBig, Rectangle rectText)
        {
            if (Style == styleButton.Standart)
            {
                graph.DrawString(Text, Font, new SolidBrush(ForeColor), rectText, CheckBoxTextAlign());
                if (MouseEntered && !isChecked || MouseEntered && isChecked && Image != null)
                    graph.DrawRectangle(new Pen(HoverColor), rectBlock);
                else
                {
                    graph.DrawRectangle(new Pen(BackColor), rectMain);
                    graph.DrawRectangle(new Pen(BorderColor), rectBlock);
                }
                if (isChecked && Image == null)
                {
                    graph.DrawRectangle(new Pen(FillColor), rectBlock);
                    graph.FillRectangle(new SolidBrush(FillColor), rectBlock);
                }
                else if (isChecked && Image != null)
                    graph.DrawImage(Image, rectImageBlock);
            }
            else if (Style == styleButton.Big)
            {
                Font = new Font("Arial", 9.75F);
                Size = new Size(150, 22);
                graph.DrawString(Text, Font, new SolidBrush(ForeColor), rectText, CheckBoxTextAlign());
                if (MouseEntered && !isChecked || MouseEntered && isChecked && Image != null)
                    graph.DrawRectangle(new Pen(HoverColor), rectBlockBig);
                else
                {
                    graph.DrawRectangle(new Pen(BackColor), rectMain);
                    graph.DrawRectangle(new Pen(BorderColor), rectBlockBig);
                }
                if (isChecked && Image == null)
                {
                    graph.DrawRectangle(new Pen(FillColor), rectBlockBig);
                    graph.FillRectangle(new SolidBrush(FillColor), rectBlockBig);
                }
                else if (isChecked && Image != null)
                    graph.DrawImage(Image, rectImageBlockBig);
            }
        }
        private StringFormat CheckBoxTextAlign()
        {
            _StringFormat.Alignment = StringAlignment.Center;
            _StringFormat.LineAlignment = StringAlignment.Center;
            return _StringFormat;
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
            isChecked = !isChecked;
            Invalidate();
        }
    }
}