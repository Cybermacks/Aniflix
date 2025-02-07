﻿namespace Aniflix.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AniflixView));
            panel1 = new Panel();
            SeriesButton = new Custom.RoundedButton();
            FilmesButton = new Custom.RoundedButton();
            panel2 = new Panel();
            panelTitleBar = new Panel();
            Minimize = new PictureBox();
            iconCurrentChildForm = new PictureBox();
            lblTitleChildForm = new Label();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            AnimesButton = new Custom.RoundedButton();
            AnimesFilmesButton = new Custom.RoundedButton();
            BreakOutFilmesButton = new Custom.RoundedButton();
            BreakOutSeriesButton = new Custom.RoundedButton();
            GoreFilmesButton = new Custom.RoundedButton();
            GoreSeriesButton = new Custom.RoundedButton();
            TrashFlixButton = new Custom.RoundedButton();
            FecharButton = new Custom.RoundedButton();
            HomeButton = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HomeButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 30, 68);
            panel1.Controls.Add(FecharButton);
            panel1.Controls.Add(TrashFlixButton);
            panel1.Controls.Add(GoreSeriesButton);
            panel1.Controls.Add(GoreFilmesButton);
            panel1.Controls.Add(BreakOutSeriesButton);
            panel1.Controls.Add(BreakOutFilmesButton);
            panel1.Controls.Add(AnimesFilmesButton);
            panel1.Controls.Add(AnimesButton);
            panel1.Controls.Add(SeriesButton);
            panel1.Controls.Add(FilmesButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 924);
            panel1.TabIndex = 0;
            // 
            // SeriesButton
            // 
            SeriesButton.BackColor = Color.Transparent;
            SeriesButton.BackgroundColor = Color.Transparent;
            SeriesButton.BorderColor = Color.PaleVioletRed;
            SeriesButton.BorderRadius = 0;
            SeriesButton.BorderSize = 0;
            SeriesButton.Dock = DockStyle.Top;
            SeriesButton.FlatAppearance.BorderSize = 0;
            SeriesButton.FlatStyle = FlatStyle.Flat;
            SeriesButton.ForeColor = Color.White;
            SeriesButton.Location = new Point(0, 160);
            SeriesButton.Name = "SeriesButton";
            SeriesButton.Padding = new Padding(10, 0, 20, 0);
            SeriesButton.Size = new Size(280, 60);
            SeriesButton.TabIndex = 2;
            SeriesButton.Text = "Séries";
            SeriesButton.TextColor = Color.White;
            SeriesButton.UseVisualStyleBackColor = false;
            SeriesButton.Click += SeriesButton_Click;
            // 
            // FilmesButton
            // 
            FilmesButton.BackColor = Color.Transparent;
            FilmesButton.BackgroundColor = Color.Transparent;
            FilmesButton.BackgroundImageLayout = ImageLayout.Stretch;
            FilmesButton.BorderColor = Color.PaleVioletRed;
            FilmesButton.BorderRadius = 0;
            FilmesButton.BorderSize = 0;
            FilmesButton.Dock = DockStyle.Top;
            FilmesButton.FlatAppearance.BorderSize = 0;
            FilmesButton.FlatStyle = FlatStyle.Flat;
            FilmesButton.ForeColor = Color.White;
            FilmesButton.Image = (Image)resources.GetObject("FilmesButton.Image");
            FilmesButton.ImageAlign = ContentAlignment.MiddleLeft;
            FilmesButton.Location = new Point(0, 100);
            FilmesButton.Name = "FilmesButton";
            FilmesButton.Padding = new Padding(10, 0, 20, 0);
            FilmesButton.Size = new Size(280, 60);
            FilmesButton.TabIndex = 1;
            FilmesButton.Text = "Filmes";
            FilmesButton.TextColor = Color.White;
            FilmesButton.UseVisualStyleBackColor = false;
            FilmesButton.Click += Filmesutton_Click;
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
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(pictureBox1);
            panelTitleBar.Controls.Add(Minimize);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(280, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1407, 80);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += PanelTitleBar_MouseDown;
            // 
            // Minimize
            // 
            Minimize.Image = Properties.Resources.window_minimize;
            Minimize.Location = new Point(1321, 12);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(34, 34);
            Minimize.SizeMode = PictureBoxSizeMode.StretchImage;
            Minimize.TabIndex = 2;
            Minimize.TabStop = false;
            // 
            // iconCurrentChildForm
            // 
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
            lblTitleChildForm.Text = "label1";
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.window_close;
            pictureBox1.Location = new Point(1361, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AnimesButton
            // 
            AnimesButton.BackColor = Color.Transparent;
            AnimesButton.BackgroundColor = Color.Transparent;
            AnimesButton.BorderColor = Color.PaleVioletRed;
            AnimesButton.BorderRadius = 0;
            AnimesButton.BorderSize = 0;
            AnimesButton.Dock = DockStyle.Top;
            AnimesButton.FlatAppearance.BorderSize = 0;
            AnimesButton.FlatStyle = FlatStyle.Flat;
            AnimesButton.ForeColor = Color.White;
            AnimesButton.Location = new Point(0, 220);
            AnimesButton.Name = "AnimesButton";
            AnimesButton.Padding = new Padding(10, 0, 20, 0);
            AnimesButton.Size = new Size(280, 60);
            AnimesButton.TabIndex = 3;
            AnimesButton.Text = "Animes";
            AnimesButton.TextColor = Color.White;
            AnimesButton.UseVisualStyleBackColor = false;
            // 
            // AnimesFilmesButton
            // 
            AnimesFilmesButton.BackColor = Color.Transparent;
            AnimesFilmesButton.BackgroundColor = Color.Transparent;
            AnimesFilmesButton.BorderColor = Color.PaleVioletRed;
            AnimesFilmesButton.BorderRadius = 0;
            AnimesFilmesButton.BorderSize = 0;
            AnimesFilmesButton.Dock = DockStyle.Top;
            AnimesFilmesButton.FlatAppearance.BorderSize = 0;
            AnimesFilmesButton.FlatStyle = FlatStyle.Flat;
            AnimesFilmesButton.ForeColor = Color.White;
            AnimesFilmesButton.Location = new Point(0, 280);
            AnimesFilmesButton.Name = "AnimesFilmesButton";
            AnimesFilmesButton.Padding = new Padding(10, 0, 20, 0);
            AnimesFilmesButton.Size = new Size(280, 60);
            AnimesFilmesButton.TabIndex = 4;
            AnimesFilmesButton.Text = "Animes Filmes";
            AnimesFilmesButton.TextColor = Color.White;
            AnimesFilmesButton.UseVisualStyleBackColor = false;
            // 
            // BreakOutFilmesButton
            // 
            BreakOutFilmesButton.BackColor = Color.Transparent;
            BreakOutFilmesButton.BackgroundColor = Color.Transparent;
            BreakOutFilmesButton.BorderColor = Color.PaleVioletRed;
            BreakOutFilmesButton.BorderRadius = 0;
            BreakOutFilmesButton.BorderSize = 0;
            BreakOutFilmesButton.Dock = DockStyle.Top;
            BreakOutFilmesButton.FlatAppearance.BorderSize = 0;
            BreakOutFilmesButton.FlatStyle = FlatStyle.Flat;
            BreakOutFilmesButton.ForeColor = Color.White;
            BreakOutFilmesButton.Location = new Point(0, 340);
            BreakOutFilmesButton.Name = "BreakOutFilmesButton";
            BreakOutFilmesButton.Padding = new Padding(10, 0, 20, 0);
            BreakOutFilmesButton.Size = new Size(280, 60);
            BreakOutFilmesButton.TabIndex = 5;
            BreakOutFilmesButton.Text = "BreakOut Filmes";
            BreakOutFilmesButton.TextColor = Color.White;
            BreakOutFilmesButton.UseVisualStyleBackColor = false;
            // 
            // BreakOutSeriesButton
            // 
            BreakOutSeriesButton.BackColor = Color.Transparent;
            BreakOutSeriesButton.BackgroundColor = Color.Transparent;
            BreakOutSeriesButton.BorderColor = Color.PaleVioletRed;
            BreakOutSeriesButton.BorderRadius = 0;
            BreakOutSeriesButton.BorderSize = 0;
            BreakOutSeriesButton.Dock = DockStyle.Top;
            BreakOutSeriesButton.FlatAppearance.BorderSize = 0;
            BreakOutSeriesButton.FlatStyle = FlatStyle.Flat;
            BreakOutSeriesButton.ForeColor = Color.White;
            BreakOutSeriesButton.Location = new Point(0, 400);
            BreakOutSeriesButton.Name = "BreakOutSeriesButton";
            BreakOutSeriesButton.Padding = new Padding(10, 0, 20, 0);
            BreakOutSeriesButton.Size = new Size(280, 60);
            BreakOutSeriesButton.TabIndex = 6;
            BreakOutSeriesButton.Text = "BreakOut Séries";
            BreakOutSeriesButton.TextColor = Color.White;
            BreakOutSeriesButton.UseVisualStyleBackColor = false;
            // 
            // GoreFilmesButton
            // 
            GoreFilmesButton.BackColor = Color.Transparent;
            GoreFilmesButton.BackgroundColor = Color.Transparent;
            GoreFilmesButton.BorderColor = Color.PaleVioletRed;
            GoreFilmesButton.BorderRadius = 0;
            GoreFilmesButton.BorderSize = 0;
            GoreFilmesButton.Dock = DockStyle.Top;
            GoreFilmesButton.FlatAppearance.BorderSize = 0;
            GoreFilmesButton.FlatStyle = FlatStyle.Flat;
            GoreFilmesButton.ForeColor = Color.White;
            GoreFilmesButton.Location = new Point(0, 460);
            GoreFilmesButton.Name = "GoreFilmesButton";
            GoreFilmesButton.Padding = new Padding(10, 0, 20, 0);
            GoreFilmesButton.Size = new Size(280, 60);
            GoreFilmesButton.TabIndex = 7;
            GoreFilmesButton.Text = "Gore Filmes";
            GoreFilmesButton.TextColor = Color.White;
            GoreFilmesButton.UseVisualStyleBackColor = false;
            // 
            // GoreSeriesButton
            // 
            GoreSeriesButton.BackColor = Color.Transparent;
            GoreSeriesButton.BackgroundColor = Color.Transparent;
            GoreSeriesButton.BorderColor = Color.PaleVioletRed;
            GoreSeriesButton.BorderRadius = 0;
            GoreSeriesButton.BorderSize = 0;
            GoreSeriesButton.Dock = DockStyle.Top;
            GoreSeriesButton.FlatAppearance.BorderSize = 0;
            GoreSeriesButton.FlatStyle = FlatStyle.Flat;
            GoreSeriesButton.ForeColor = Color.White;
            GoreSeriesButton.Location = new Point(0, 520);
            GoreSeriesButton.Name = "GoreSeriesButton";
            GoreSeriesButton.Padding = new Padding(10, 0, 20, 0);
            GoreSeriesButton.Size = new Size(280, 60);
            GoreSeriesButton.TabIndex = 8;
            GoreSeriesButton.Text = "Gore Séries";
            GoreSeriesButton.TextColor = Color.White;
            GoreSeriesButton.UseVisualStyleBackColor = false;
            // 
            // TrashFlixButton
            // 
            TrashFlixButton.BackColor = Color.Transparent;
            TrashFlixButton.BackgroundColor = Color.Transparent;
            TrashFlixButton.BorderColor = Color.PaleVioletRed;
            TrashFlixButton.BorderRadius = 0;
            TrashFlixButton.BorderSize = 0;
            TrashFlixButton.Dock = DockStyle.Top;
            TrashFlixButton.FlatAppearance.BorderSize = 0;
            TrashFlixButton.FlatStyle = FlatStyle.Flat;
            TrashFlixButton.ForeColor = Color.White;
            TrashFlixButton.Location = new Point(0, 580);
            TrashFlixButton.Name = "TrashFlixButton";
            TrashFlixButton.Padding = new Padding(10, 0, 20, 0);
            TrashFlixButton.Size = new Size(280, 60);
            TrashFlixButton.TabIndex = 9;
            TrashFlixButton.Text = "TrashFlix";
            TrashFlixButton.TextColor = Color.White;
            TrashFlixButton.UseVisualStyleBackColor = false;
            // 
            // FecharButton
            // 
            FecharButton.BackColor = Color.Transparent;
            FecharButton.BackgroundColor = Color.Transparent;
            FecharButton.BorderColor = Color.PaleVioletRed;
            FecharButton.BorderRadius = 0;
            FecharButton.BorderSize = 0;
            FecharButton.Dock = DockStyle.Top;
            FecharButton.FlatAppearance.BorderSize = 0;
            FecharButton.FlatStyle = FlatStyle.Flat;
            FecharButton.ForeColor = Color.White;
            FecharButton.Location = new Point(0, 640);
            FecharButton.Name = "FecharButton";
            FecharButton.Padding = new Padding(10, 0, 20, 0);
            FecharButton.Size = new Size(280, 60);
            FecharButton.TabIndex = 10;
            FecharButton.Text = "Fechar";
            FecharButton.TextColor = Color.White;
            FecharButton.UseVisualStyleBackColor = false;
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
            // AniflixView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1687, 924);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panel1);
            Name = "AniflixView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aniflix";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)HomeButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Custom.RoundedButton FilmesButton;
        private Panel panel2;
        private Custom.RoundedButton SeriesButton;
        private Panel panelTitleBar;
        private Panel panelDesktop;
        private Label lblTitleChildForm;
        private PictureBox iconCurrentChildForm;
        private PictureBox Minimize;
        private PictureBox pictureBox1;
        private Custom.RoundedButton FecharButton;
        private Custom.RoundedButton TrashFlixButton;
        private Custom.RoundedButton GoreSeriesButton;
        private Custom.RoundedButton GoreFilmesButton;
        private Custom.RoundedButton BreakOutSeriesButton;
        private Custom.RoundedButton BreakOutFilmesButton;
        private Custom.RoundedButton AnimesFilmesButton;
        private Custom.RoundedButton AnimesButton;
        private PictureBox HomeButton;
    }
}