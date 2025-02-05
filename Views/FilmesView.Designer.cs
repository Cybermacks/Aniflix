﻿namespace Aniflix.Views
{
    partial class FilmesView
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
            VoltarButton = new Button();
            ProximoButton = new Button();
            AnteriorButton = new Button();
            EditarButton = new Button();
            InserirButton = new Button();
            CopiarButton = new Button();
            EstudioText = new TextBox();
            ResumoText = new TextBox();
            FaseMCUText = new TextBox();
            EstrelasText = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label14 = new Label();
            label13 = new Label();
            label10 = new Label();
            DataLancamentoText = new MaskedTextBox();
            label12 = new Label();
            TituloAlternativoText = new TextBox();
            GeneroText = new TextBox();
            DiretorText = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TagsText = new TextBox();
            TituloOriginalText = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SinopseText = new TextBox();
            AudioBox = new ComboBox();
            TituloText = new TextBox();
            CodigoText = new TextBox();
            label11 = new Label();
            FranquiaText = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // VoltarButton
            // 
            VoltarButton.BackColor = Color.FromArgb(9, 32, 63);
            VoltarButton.FlatStyle = FlatStyle.Popup;
            VoltarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            VoltarButton.ForeColor = Color.White;
            VoltarButton.ImageIndex = 0;
            VoltarButton.Location = new Point(1070, 597);
            VoltarButton.Name = "VoltarButton";
            VoltarButton.Size = new Size(137, 61);
            VoltarButton.TabIndex = 125;
            VoltarButton.Text = "Voltar";
            VoltarButton.UseVisualStyleBackColor = false;
            // 
            // ProximoButton
            // 
            ProximoButton.BackColor = Color.FromArgb(29, 38, 113);
            ProximoButton.FlatStyle = FlatStyle.Popup;
            ProximoButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            ProximoButton.ForeColor = Color.White;
            ProximoButton.ImageIndex = 3;
            ProximoButton.Location = new Point(892, 597);
            ProximoButton.Name = "ProximoButton";
            ProximoButton.Size = new Size(137, 61);
            ProximoButton.TabIndex = 124;
            ProximoButton.Text = "Próximo";
            ProximoButton.UseVisualStyleBackColor = false;
            ProximoButton.Click += ProximoButton_Click;
            // 
            // AnteriorButton
            // 
            AnteriorButton.BackColor = Color.FromArgb(195, 55, 100);
            AnteriorButton.FlatStyle = FlatStyle.Popup;
            AnteriorButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            AnteriorButton.ForeColor = Color.White;
            AnteriorButton.ImageIndex = 4;
            AnteriorButton.Location = new Point(714, 597);
            AnteriorButton.Name = "AnteriorButton";
            AnteriorButton.Size = new Size(137, 61);
            AnteriorButton.TabIndex = 123;
            AnteriorButton.Text = "Anterior";
            AnteriorButton.UseVisualStyleBackColor = false;
            AnteriorButton.Click += AnteriorButton_Click;
            // 
            // EditarButton
            // 
            EditarButton.BackColor = Color.FromArgb(46, 34, 114);
            EditarButton.FlatStyle = FlatStyle.Popup;
            EditarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            EditarButton.ForeColor = Color.White;
            EditarButton.ImageIndex = 2;
            EditarButton.Location = new Point(536, 597);
            EditarButton.Name = "EditarButton";
            EditarButton.Size = new Size(137, 61);
            EditarButton.TabIndex = 122;
            EditarButton.Text = "Editar";
            EditarButton.UseVisualStyleBackColor = false;
            EditarButton.Click += EditarButton_Click;
            // 
            // InserirButton
            // 
            InserirButton.BackColor = Color.FromArgb(229, 92, 68);
            InserirButton.FlatStyle = FlatStyle.Popup;
            InserirButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            InserirButton.ForeColor = Color.White;
            InserirButton.ImageIndex = 2;
            InserirButton.Location = new Point(358, 597);
            InserirButton.Name = "InserirButton";
            InserirButton.Size = new Size(137, 61);
            InserirButton.TabIndex = 121;
            InserirButton.Text = "Inserir Novo";
            InserirButton.UseVisualStyleBackColor = false;
            InserirButton.Click += InserirButton_Click;
            // 
            // CopiarButton
            // 
            CopiarButton.BackColor = Color.FromArgb(0, 97, 149);
            CopiarButton.FlatStyle = FlatStyle.Popup;
            CopiarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            CopiarButton.ForeColor = Color.White;
            CopiarButton.ImageIndex = 1;
            CopiarButton.Location = new Point(180, 597);
            CopiarButton.Name = "CopiarButton";
            CopiarButton.Size = new Size(137, 61);
            CopiarButton.TabIndex = 120;
            CopiarButton.Text = "Copiar Dados";
            CopiarButton.UseVisualStyleBackColor = false;
            CopiarButton.Click += CopiarButton_Click;
            // 
            // EstudioText
            // 
            EstudioText.Location = new Point(13, 532);
            EstudioText.Name = "EstudioText";
            EstudioText.PlaceholderText = "Estúdio";
            EstudioText.Size = new Size(658, 23);
            EstudioText.TabIndex = 119;
            EstudioText.TextChanged += EstudioText_TextChanged;
            // 
            // ResumoText
            // 
            ResumoText.Location = new Point(780, 30);
            ResumoText.Multiline = true;
            ResumoText.Name = "ResumoText";
            ResumoText.PlaceholderText = "Resumo";
            ResumoText.Size = new Size(605, 525);
            ResumoText.TabIndex = 117;
            // 
            // FaseMCUText
            // 
            FaseMCUText.Location = new Point(677, 532);
            FaseMCUText.Name = "FaseMCUText";
            FaseMCUText.PlaceholderText = "Fase MCU";
            FaseMCUText.Size = new Size(96, 23);
            FaseMCUText.TabIndex = 116;
            FaseMCUText.Text = "--";
            FaseMCUText.TextChanged += FaseMCUText_TextChanged;
            // 
            // EstrelasText
            // 
            EstrelasText.Location = new Point(12, 488);
            EstrelasText.Name = "EstrelasText";
            EstrelasText.PlaceholderText = "Estrelas";
            EstrelasText.Size = new Size(761, 23);
            EstrelasText.TabIndex = 115;
            EstrelasText.TextChanged += EstrelasText_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 426);
            label17.Name = "label17";
            label17.Size = new Size(43, 15);
            label17.TabIndex = 114;
            label17.Text = "Diretor";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(13, 470);
            label16.Name = "label16";
            label16.Size = new Size(46, 15);
            label16.TabIndex = 113;
            label16.Text = "Estrelas";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(815, 12);
            label14.Name = "label14";
            label14.Size = new Size(50, 15);
            label14.TabIndex = 112;
            label14.Text = "Resumo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(387, 382);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 111;
            label13.Text = "Gênero";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(546, 338);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 110;
            label10.Text = "Tags";
            // 
            // DataLancamentoText
            // 
            DataLancamentoText.Location = new Point(656, 312);
            DataLancamentoText.Mask = "00/00/0000";
            DataLancamentoText.Name = "DataLancamentoText";
            DataLancamentoText.Size = new Size(118, 23);
            DataLancamentoText.TabIndex = 109;
            DataLancamentoText.ValidatingType = typeof(DateTime);
            DataLancamentoText.MaskInputRejected += DataLancamentoText_MaskInputRejected;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 338);
            label12.Name = "label12";
            label12.Size = new Size(99, 15);
            label12.TabIndex = 107;
            label12.Text = "Título Alternativo";
            // 
            // TituloAlternativoText
            // 
            TituloAlternativoText.Location = new Point(12, 356);
            TituloAlternativoText.Name = "TituloAlternativoText";
            TituloAlternativoText.PlaceholderText = "Título Alternativo";
            TituloAlternativoText.Size = new Size(528, 23);
            TituloAlternativoText.TabIndex = 106;
            TituloAlternativoText.Text = "--";
            TituloAlternativoText.TextChanged += TituloAlternativoText_TextChanged;
            // 
            // GeneroText
            // 
            GeneroText.Location = new Point(387, 400);
            GeneroText.Name = "GeneroText";
            GeneroText.PlaceholderText = "Gênero ";
            GeneroText.Size = new Size(386, 23);
            GeneroText.TabIndex = 104;
            GeneroText.TextChanged += GeneroText_TextChanged;
            // 
            // DiretorText
            // 
            DiretorText.Location = new Point(12, 444);
            DiretorText.Name = "DiretorText";
            DiretorText.PlaceholderText = "Diretor";
            DiretorText.Size = new Size(761, 23);
            DiretorText.TabIndex = 103;
            DiretorText.TextChanged += DiretorText_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(658, 294);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 102;
            label5.Text = "Data de Lançamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(677, 514);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 101;
            label6.Text = "Fase MCU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 294);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 100;
            label7.Text = "Título Original";
            // 
            // TagsText
            // 
            TagsText.Location = new Point(546, 356);
            TagsText.Name = "TagsText";
            TagsText.PlaceholderText = "Tags";
            TagsText.Size = new Size(227, 23);
            TagsText.TabIndex = 99;
            TagsText.TextChanged += TagsText_TextChanged;
            // 
            // TituloOriginalText
            // 
            TituloOriginalText.Location = new Point(12, 312);
            TituloOriginalText.Name = "TituloOriginalText";
            TituloOriginalText.PlaceholderText = "Título Original";
            TituloOriginalText.Size = new Size(638, 23);
            TituloOriginalText.TabIndex = 98;
            TituloOriginalText.TextChanged += TituloOriginalText_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(630, 12);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 97;
            label4.Text = "Áudio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 12);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 96;
            label3.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 95;
            label2.Text = "Sinopse";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 94;
            label1.Text = "Código";
            // 
            // SinopseText
            // 
            SinopseText.Location = new Point(12, 74);
            SinopseText.Multiline = true;
            SinopseText.Name = "SinopseText";
            SinopseText.PlaceholderText = "Sinopse";
            SinopseText.Size = new Size(762, 217);
            SinopseText.TabIndex = 93;
            SinopseText.TextChanged += SinopseText_TextChanged;
            // 
            // AudioBox
            // 
            AudioBox.FormattingEnabled = true;
            AudioBox.Items.AddRange(new object[] { "Dublado", "Legendado", "Nacional", "Desconhecido" });
            AudioBox.Location = new Point(630, 30);
            AudioBox.Name = "AudioBox";
            AudioBox.Size = new Size(144, 23);
            AudioBox.TabIndex = 92;
            AudioBox.Text = "Dublado";
            // 
            // TituloText
            // 
            TituloText.Location = new Point(118, 30);
            TituloText.Name = "TituloText";
            TituloText.PlaceholderText = "Título";
            TituloText.Size = new Size(506, 23);
            TituloText.TabIndex = 91;
            TituloText.TextChanged += TituloText_TextChanged;
            // 
            // CodigoText
            // 
            CodigoText.Location = new Point(12, 30);
            CodigoText.Name = "CodigoText";
            CodigoText.PlaceholderText = "Código";
            CodigoText.Size = new Size(100, 23);
            CodigoText.TabIndex = 90;
            CodigoText.TextChanged += CodigoText_TextChanged;
            CodigoText.KeyPress += CodigoText_KeyPress;
            CodigoText.Leave += CodigoText_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 382);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 127;
            label11.Text = "Franquia";
            // 
            // FranquiaText
            // 
            FranquiaText.Location = new Point(13, 400);
            FranquiaText.Name = "FranquiaText";
            FranquiaText.PlaceholderText = "Franquia";
            FranquiaText.Size = new Size(368, 23);
            FranquiaText.TabIndex = 126;
            FranquiaText.TextChanged += FranquiaText_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 514);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 128;
            label9.Text = "Estúdio";
            // 
            // FilmesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 695);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(FranquiaText);
            Controls.Add(VoltarButton);
            Controls.Add(ProximoButton);
            Controls.Add(AnteriorButton);
            Controls.Add(EditarButton);
            Controls.Add(InserirButton);
            Controls.Add(CopiarButton);
            Controls.Add(EstudioText);
            Controls.Add(ResumoText);
            Controls.Add(FaseMCUText);
            Controls.Add(EstrelasText);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(DataLancamentoText);
            Controls.Add(label12);
            Controls.Add(TituloAlternativoText);
            Controls.Add(GeneroText);
            Controls.Add(DiretorText);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(TagsText);
            Controls.Add(TituloOriginalText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SinopseText);
            Controls.Add(AudioBox);
            Controls.Add(TituloText);
            Controls.Add(CodigoText);
            Name = "FilmesView";
            Text = "FilmesView";
            Load += FilmesView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button VoltarButton;
        private Button ProximoButton;
        private Button AnteriorButton;
        private Button EditarButton;
        private Button InserirButton;
        private Button CopiarButton;
        private TextBox EstudioText;
        private TextBox ResumoText;
        private TextBox FaseMCUText;
        private TextBox EstrelasText;
        private Label label17;
        private Label label16;
        private Label label14;
        private Label label13;
        private Label label10;
        private MaskedTextBox DataLancamentoText;
        private Label label12;
        private TextBox TituloAlternativoText;
        private TextBox GeneroText;
        private TextBox DiretorText;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TagsText;
        private TextBox TituloOriginalText;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox SinopseText;
        private ComboBox AudioBox;
        private TextBox TituloText;
        private TextBox CodigoText;
        private Label label11;
        private TextBox FranquiaText;
        private Label label9;
    }
}