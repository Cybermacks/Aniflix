using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Aniflix.Custom
{
    [DefaultEvent("_TextChanged")]
    public partial class AnyText : UserControl
    {
        #region -> Fields
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private bool isFocused = false;
        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        public event EventHandler? TextChanged;

        #endregion

        public AnyText()
        {
            InitializeComponent();
        }

        #region -> Properties
        [Category("AnyText")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("AnyText")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("AnyText")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                if (value >= 1)
                {
                    borderSize = value;
                    Invalidate();
                }
            }
        }

        [Category("AnyText")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                Invalidate();
            }
        }

        [Category("AnyText")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                {
                    textBox1.UseSystemPasswordChar = value;
                }
            }
        }

        [Category("AnyText")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("AnyText")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("AnyText")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("AnyText")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }

        [Category("AnyText")]
        public string Texts
        {
            get
            {
                if (isPlaceholder)
                {
                    return "";
                }
                else
                {
                    return textBox1.Text;
                }
            }
            set
            {
                RemovePlaceholder();
                textBox1.Text = value;
                SetPlaceholder();
            }
        }

        [Category("AnyText")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    Invalidate();
                }
            }
        }

        [Category("AnyText")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                {
                    textBox1.ForeColor = value;
                }
            }
        }

        [Category("AnyText")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }
        #endregion

        #region -> Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode)
            {
                UpdateControlHeight();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)
            {
                var rectBorderSmooth = ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius);
                using GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize);
                using Pen penBorderSmooth = new(Parent!.BackColor, smoothSize);
                using Pen penBorder = new(borderColor, borderSize);
                Region = new Region(pathBorderSmooth);
                if (borderRadius > 15)
                {
                    SetTextBoxRoundedRegion();
                }

                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                if (isFocused)
                {
                    penBorder.Color = borderFocusColor;
                }

                if (underlinedStyle)
                {
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    graph.SmoothingMode = SmoothingMode.None;
                    graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                }
                else
                {
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    graph.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                using Pen penBorder = new(borderColor, borderSize);
                Region = new Region(ClientRectangle);
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused)
                {
                    penBorder.Color = borderFocusColor;
                }

                if (underlinedStyle)
                {
                    graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                }
                else
                {
                    graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                }
            }
        }
        #endregion

        #region -> Private methods
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = false;
                }
            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = ForeColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = true;
                }
            }
        }
        private static GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                Height = textBox1.Height + Padding.Top + Padding.Bottom;
            }
        }
        #endregion

        #region -> TextBox events
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            _TextChanged?.Invoke(sender, e);
        }
        private void TextBox1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }
        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            Invalidate();
            RemovePlaceholder();
        }
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            Invalidate();
            SetPlaceholder();
        }
        #endregion
    }
}