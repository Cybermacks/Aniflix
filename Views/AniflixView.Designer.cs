namespace Aniflix.Views
{
    partial class AniflixView
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
            components = new System.ComponentModel.Container();
            MenuPanel = new Panel();
            panel2 = new Panel();
            HomeButton = new PictureBox();
            TitleBarPanel = new Panel();
            CloseButton = new PictureBox();
            MinimizeButton = new PictureBox();
            iconCurrentChildForm = new PictureBox();
            lblTitleChildForm = new Label();
            panelDesktop = new Panel();
            FilmesButton = new Button();
            ListImage = new ImageList(components);
            MenuPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomeButton).BeginInit();
            TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(31, 30, 68);
            MenuPanel.Controls.Add(FilmesButton);
            MenuPanel.Controls.Add(panel2);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(280, 924);
            MenuPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(HomeButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 100);
            panel2.TabIndex = 0;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(12, 12);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(247, 68);
            HomeButton.TabIndex = 0;
            HomeButton.TabStop = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = Color.FromArgb(26, 25, 62);
            TitleBarPanel.Controls.Add(CloseButton);
            TitleBarPanel.Controls.Add(MinimizeButton);
            TitleBarPanel.Controls.Add(iconCurrentChildForm);
            TitleBarPanel.Controls.Add(lblTitleChildForm);
            TitleBarPanel.Dock = DockStyle.Top;
            TitleBarPanel.Location = new Point(280, 0);
            TitleBarPanel.Name = "TitleBarPanel";
            TitleBarPanel.Size = new Size(1407, 80);
            TitleBarPanel.TabIndex = 1;
            TitleBarPanel.MouseDown += PanelTitleBar_MouseDown;
            // 
            // CloseButton
            // 
            CloseButton.Image = Properties.Resources.window_close;
            CloseButton.Location = new Point(1379, 2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(24, 24);
            CloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseButton.TabIndex = 3;
            CloseButton.TabStop = false;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Image = Properties.Resources.window_minimize;
            MinimizeButton.Location = new Point(1352, 2);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(24, 24);
            MinimizeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeButton.TabIndex = 2;
            MinimizeButton.TabStop = false;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.Image = Properties.Resources.home_circle;
            iconCurrentChildForm.Location = new Point(17, 12);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(55, 50);
            iconCurrentChildForm.SizeMode = PictureBoxSizeMode.StretchImage;
            iconCurrentChildForm.TabIndex = 1;
            iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.Font = new Font("Segoe UI", 12F);
            lblTitleChildForm.ForeColor = Color.White;
            lblTitleChildForm.Location = new Point(78, 28);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(100, 23);
            lblTitleChildForm.TabIndex = 0;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(280, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1407, 844);
            panelDesktop.TabIndex = 2;
            // 
            // FilmesButton
            // 
            FilmesButton.Dock = DockStyle.Top;
            FilmesButton.FlatStyle = FlatStyle.Popup;
            FilmesButton.ForeColor = Color.White;
            FilmesButton.Location = new Point(0, 100);
            FilmesButton.Name = "FilmesButton";
            FilmesButton.Size = new Size(280, 65);
            FilmesButton.TabIndex = 1;
            FilmesButton.Text = "Filmes";
            FilmesButton.UseVisualStyleBackColor = true;
            FilmesButton.Click += FilmesButton_Click;
            // 
            // ListImage
            // 
            ListImage.ColorDepth = ColorDepth.Depth32Bit;
            ListImage.ImageSize = new Size(16, 16);
            ListImage.TransparentColor = Color.Transparent;
            // 
            // AniflixView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1687, 924);
            Controls.Add(panelDesktop);
            Controls.Add(TitleBarPanel);
            Controls.Add(MenuPanel);
            Name = "AniflixView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aniflix";
            MenuPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HomeButton).EndInit();
            TitleBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Panel panel2;
        private Panel TitleBarPanel;
        private Panel panelDesktop;
        private Label lblTitleChildForm;
        private PictureBox iconCurrentChildForm;
        private PictureBox MinimizeButton;
        private PictureBox CloseButton;

        private PictureBox HomeButton;
        private ColorDialog colorDialog1;
        private Button FilmesButton;
        private ImageList ListImage;
    }
}