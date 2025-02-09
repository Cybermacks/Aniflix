using Aniflix.Globals;
using Aniflix.Properties;

namespace Aniflix.Views
{
    public partial class AniflixView : Form
    {
        private Button? currentBtn;
        private readonly Panel? leftBorderBtn;
        private Form? currentChildForm;


        protected override void OnHandleCreated(EventArgs e)
        {

            base.OnHandleCreated(e);
            GlobFunctions.
            GlobFunctions.EnableDarkModeForMenus();
            BackColor = Color.FromArgb(30, 30, 30);
        }


        public AniflixView()
        {
            InitializeComponent();
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 60)
            };
            MenuPanel.Controls.Add(leftBorderBtn);
            Text = string.Empty;
            DoubleBuffered = true;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn!.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.Image = currentBtn.Image;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            currentChildForm?.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn!.Visible = false;
            iconCurrentChildForm.Image = Resources.home_circle;
            lblTitleChildForm.Text = "Home";
            currentChildForm = null;
        }


        private void SeriesButton_Click(object sender, EventArgs e)
        {
            ActivateButton((object)sender, RGBColors.color2);
            OpenChildForm(new SeriesView());
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void FecharButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FilmesButton_Click(object sender, EventArgs e)
        {
            ActivateButton((object)sender, RGBColors.color1);
            OpenChildForm(new FilmesView());
        }
    }
}