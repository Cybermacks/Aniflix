namespace Aniflix
{
    partial class View
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
            CodigoText = new TextBox();
            TituloText = new TextBox();
            AudioBox = new ComboBox();
            SinopseText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TagsText = new TextBox();
            TituloOriginalText = new TextBox();
            GeneroText = new TextBox();
            DiretorText = new TextBox();
            label11 = new Label();
            label12 = new Label();
            TituloAlternativoText = new TextBox();
            FranquiaText = new TextBox();
            DataLancamentoText = new MaskedTextBox();
            label10 = new Label();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            EstrelasText = new TextBox();
            FaseMCUText = new TextBox();
            ResumoText = new TextBox();
            EstudioText = new TextBox();
            label8 = new Label();
            CopiarButton = new Button();
            SalvarButton = new Button();
            EditarButton = new Button();
            AnteriorButton = new Button();
            ProximoButton = new Button();
            VoltarButton = new Button();
            SuspendLayout();
            // 
            // CodigoText
            // 
            CodigoText.Location = new Point(12, 33);
            CodigoText.Name = "CodigoText";
            CodigoText.PlaceholderText = "Código";
            CodigoText.Size = new Size(100, 23);
            CodigoText.TabIndex = 0;
            CodigoText.KeyPress += CodigoText_KeyPress;
            CodigoText.Leave += CodigoText_Leave;
            // 
            // TituloText
            // 
            TituloText.Location = new Point(118, 33);
            TituloText.Name = "TituloText";
            TituloText.PlaceholderText = "Título";
            TituloText.Size = new Size(506, 23);
            TituloText.TabIndex = 1;
            TituloText.TextChanged += TituloText_TextChanged;
            // 
            // AudioBox
            // 
            AudioBox.FormattingEnabled = true;
            AudioBox.Items.AddRange(new object[] { "Dublado", "Legendado", "Nacional", "Desconhecido" });
            AudioBox.Location = new Point(630, 33);
            AudioBox.Name = "AudioBox";
            AudioBox.Size = new Size(144, 23);
            AudioBox.TabIndex = 2;
            AudioBox.Text = "Dublado";
            AudioBox.SelectedIndexChanged += AudioBox_SelectedIndexChanged;
            // 
            // SinopseText
            // 
            SinopseText.Location = new Point(12, 77);
            SinopseText.Multiline = true;
            SinopseText.Name = "SinopseText";
            SinopseText.PlaceholderText = "Sinopse";
            SinopseText.Size = new Size(762, 217);
            SinopseText.TabIndex = 3;
            SinopseText.TextChanged += SinopseText_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 5;
            label2.Text = "Sinopse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 15);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Título";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(630, 15);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Áudio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(658, 297);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 13;
            label5.Text = "Data de Lançamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(678, 431);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 12;
            label6.Text = "Fase MCU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 297);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 11;
            label7.Text = "Título Original";
            // 
            // TagsText
            // 
            TagsText.Location = new Point(568, 361);
            TagsText.Name = "TagsText";
            TagsText.PlaceholderText = "Tags";
            TagsText.Size = new Size(206, 23);
            TagsText.TabIndex = 9;
            TagsText.TextChanged += TagsText_TextChanged;
            // 
            // TituloOriginalText
            // 
            TituloOriginalText.Location = new Point(12, 317);
            TituloOriginalText.Name = "TituloOriginalText";
            TituloOriginalText.PlaceholderText = "Título Original";
            TituloOriginalText.Size = new Size(642, 23);
            TituloOriginalText.TabIndex = 8;
            TituloOriginalText.TextChanged += TituloOriginalText_TextChanged;
            // 
            // GeneroText
            // 
            GeneroText.Location = new Point(400, 405);
            GeneroText.Name = "GeneroText";
            GeneroText.PlaceholderText = "Gênero do Filme";
            GeneroText.Size = new Size(374, 23);
            GeneroText.TabIndex = 15;
            GeneroText.TextChanged += GeneroText_TextChanged;
            // 
            // DiretorText
            // 
            DiretorText.Location = new Point(12, 449);
            DiretorText.Name = "DiretorText";
            DiretorText.PlaceholderText = "Diretor";
            DiretorText.Size = new Size(660, 23);
            DiretorText.TabIndex = 14;
            DiretorText.TextChanged += DiretorText_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 387);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 25;
            label11.Text = "Franquia";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 343);
            label12.Name = "label12";
            label12.Size = new Size(99, 15);
            label12.TabIndex = 24;
            label12.Text = "Título Alternativo";
            // 
            // TituloAlternativoText
            // 
            TituloAlternativoText.Location = new Point(12, 361);
            TituloAlternativoText.Name = "TituloAlternativoText";
            TituloAlternativoText.PlaceholderText = "Título Alternativo";
            TituloAlternativoText.Size = new Size(550, 23);
            TituloAlternativoText.TabIndex = 21;
            TituloAlternativoText.Text = "--";
            TituloAlternativoText.TextChanged += TituloAlternativoText_TextChanged;
            // 
            // FranquiaText
            // 
            FranquiaText.Location = new Point(12, 405);
            FranquiaText.Name = "FranquiaText";
            FranquiaText.PlaceholderText = "Franquia";
            FranquiaText.Size = new Size(382, 23);
            FranquiaText.TabIndex = 20;
            FranquiaText.Text = "--";
            FranquiaText.TextChanged += FranquiaText_TextChanged;
            // 
            // DataLancamentoText
            // 
            DataLancamentoText.Location = new Point(658, 317);
            DataLancamentoText.Mask = "00/00/0000";
            DataLancamentoText.Name = "DataLancamentoText";
            DataLancamentoText.Size = new Size(118, 23);
            DataLancamentoText.TabIndex = 26;
            DataLancamentoText.ValidatingType = typeof(DateTime);
            DataLancamentoText.MaskInputRejected += DataLancamentoText_MaskInputRejected;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(568, 343);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 27;
            label10.Text = "Tags";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(400, 387);
            label13.Name = "label13";
            label13.Size = new Size(94, 15);
            label13.TabIndex = 28;
            label13.Text = "Gênero do Filme";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(790, 9);
            label14.Name = "label14";
            label14.Size = new Size(50, 15);
            label14.TabIndex = 29;
            label14.Text = "Resumo";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 475);
            label16.Name = "label16";
            label16.Size = new Size(46, 15);
            label16.TabIndex = 31;
            label16.Text = "Estrelas";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 431);
            label17.Name = "label17";
            label17.Size = new Size(43, 15);
            label17.TabIndex = 32;
            label17.Text = "Diretor";
            // 
            // EstrelasText
            // 
            EstrelasText.Location = new Point(12, 493);
            EstrelasText.Name = "EstrelasText";
            EstrelasText.PlaceholderText = "Estrelas";
            EstrelasText.Size = new Size(762, 23);
            EstrelasText.TabIndex = 33;
            EstrelasText.TextChanged += EstrelasText_TextChanged;
            // 
            // FaseMCUText
            // 
            FaseMCUText.Location = new Point(678, 449);
            FaseMCUText.Name = "FaseMCUText";
            FaseMCUText.PlaceholderText = "Fase MCU";
            FaseMCUText.Size = new Size(96, 23);
            FaseMCUText.TabIndex = 34;
            FaseMCUText.Text = "--";
            FaseMCUText.TextChanged += FaseMCUText_TextChanged;
            // 
            // ResumoText
            // 
            ResumoText.Location = new Point(784, 33);
            ResumoText.Multiline = true;
            ResumoText.Name = "ResumoText";
            ResumoText.PlaceholderText = "Resumo";
            ResumoText.Size = new Size(601, 527);
            ResumoText.TabIndex = 35;
            // 
            // EstudioText
            // 
            EstudioText.Location = new Point(12, 537);
            EstudioText.Name = "EstudioText";
            EstudioText.PlaceholderText = "Estúdio";
            EstudioText.Size = new Size(762, 23);
            EstudioText.TabIndex = 37;
            EstudioText.TextChanged += EstudioText_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 519);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 36;
            label8.Text = "Estúdio";
            // 
            // CopiarButton
            // 
            CopiarButton.BackColor = Color.FromArgb(0, 97, 149);
            CopiarButton.FlatStyle = FlatStyle.Popup;
            CopiarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            CopiarButton.ForeColor = Color.White;
            CopiarButton.ImageIndex = 1;
            CopiarButton.Location = new Point(186, 590);
            CopiarButton.Name = "CopiarButton";
            CopiarButton.Size = new Size(137, 61);
            CopiarButton.TabIndex = 38;
            CopiarButton.Text = "Copiar Dados";
            CopiarButton.UseVisualStyleBackColor = false;
            CopiarButton.Click += CopiarButton_Click;
            // 
            // SalvarButton
            // 
            SalvarButton.BackColor = Color.FromArgb(229, 92, 68);
            SalvarButton.FlatStyle = FlatStyle.Popup;
            SalvarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            SalvarButton.ForeColor = Color.White;
            SalvarButton.ImageIndex = 2;
            SalvarButton.Location = new Point(364, 590);
            SalvarButton.Name = "SalvarButton";
            SalvarButton.Size = new Size(137, 61);
            SalvarButton.TabIndex = 39;
            SalvarButton.Text = "Inserir Novo";
            SalvarButton.UseVisualStyleBackColor = false;
            SalvarButton.Click += SalvarButton_Click;
            // 
            // EditarButton
            // 
            EditarButton.BackColor = Color.FromArgb(46, 34, 114);
            EditarButton.FlatStyle = FlatStyle.Popup;
            EditarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            EditarButton.ForeColor = Color.White;
            EditarButton.ImageIndex = 2;
            EditarButton.Location = new Point(542, 590);
            EditarButton.Name = "EditarButton";
            EditarButton.Size = new Size(137, 61);
            EditarButton.TabIndex = 40;
            EditarButton.Text = "Editar";
            EditarButton.UseVisualStyleBackColor = false;
            EditarButton.Click += EditarButton_Click;
            // 
            // AnteriorButton
            // 
            AnteriorButton.BackColor = Color.FromArgb(195, 55, 100);
            AnteriorButton.FlatStyle = FlatStyle.Popup;
            AnteriorButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            AnteriorButton.ForeColor = Color.White;
            AnteriorButton.ImageIndex = 4;
            AnteriorButton.Location = new Point(720, 590);
            AnteriorButton.Name = "AnteriorButton";
            AnteriorButton.Size = new Size(137, 61);
            AnteriorButton.TabIndex = 41;
            AnteriorButton.Text = "Anterior";
            AnteriorButton.UseVisualStyleBackColor = false;
            AnteriorButton.Click += AnteriorButton_Click;
            // 
            // ProximoButton
            // 
            ProximoButton.BackColor = Color.FromArgb(29, 38, 113);
            ProximoButton.FlatStyle = FlatStyle.Popup;
            ProximoButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            ProximoButton.ForeColor = Color.White;
            ProximoButton.ImageIndex = 3;
            ProximoButton.Location = new Point(898, 590);
            ProximoButton.Name = "ProximoButton";
            ProximoButton.Size = new Size(137, 61);
            ProximoButton.TabIndex = 42;
            ProximoButton.Text = "Próximo";
            ProximoButton.UseVisualStyleBackColor = false;
            ProximoButton.Click += ProximoButton_Click;
            // 
            // VoltarButton
            // 
            VoltarButton.BackColor = Color.FromArgb(9, 32, 63);
            VoltarButton.FlatStyle = FlatStyle.Popup;
            VoltarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
            VoltarButton.ForeColor = Color.White;
            VoltarButton.ImageIndex = 0;
            VoltarButton.Location = new Point(1076, 590);
            VoltarButton.Name = "VoltarButton";
            VoltarButton.Size = new Size(137, 61);
            VoltarButton.TabIndex = 43;
            VoltarButton.Text = "Voltar";
            VoltarButton.UseVisualStyleBackColor = false;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 690);
            Controls.Add(VoltarButton);
            Controls.Add(ProximoButton);
            Controls.Add(AnteriorButton);
            Controls.Add(EditarButton);
            Controls.Add(SalvarButton);
            Controls.Add(CopiarButton);
            Controls.Add(EstudioText);
            Controls.Add(label8);
            Controls.Add(ResumoText);
            Controls.Add(FaseMCUText);
            Controls.Add(EstrelasText);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(DataLancamentoText);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(TituloAlternativoText);
            Controls.Add(FranquiaText);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View";
            Load += View_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CodigoText;
        private TextBox TituloText;
        private ComboBox AudioBox;
        private TextBox SinopseText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TagsText;
        private TextBox TituloOriginalText;
        private TextBox GeneroText;
        private TextBox DiretorText;
        private Label label11;
        private Label label12;
        private TextBox TituloAlternativoText;
        private TextBox FranquiaText;
        private MaskedTextBox DataLancamentoText;
        private Label label10;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label17;
        private TextBox EstrelasText;
        private TextBox FaseMCUText;
        private TextBox ResumoText;
        private TextBox EstudioText;
        private Label label8;
        private System.Windows.Forms.Button CopiarButton;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button AnteriorButton;
        private System.Windows.Forms.Button ProximoButton;
        private System.Windows.Forms.Button VoltarButton;
    }
}