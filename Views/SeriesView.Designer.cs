using System.ComponentModel;

namespace Aniflix;
partial class SeriesView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(SeriesView));
        EstudioText = new TextBox();
        label8 = new Label();
        ResumoText = new TextBox();
        FaseMCUText = new TextBox();
        EstrelasText = new TextBox();
        label17 = new Label();
        label16 = new Label();
        label14 = new Label();
        label13 = new Label();
        label10 = new Label();
        DataLancamentoText = new MaskedTextBox();
        label11 = new Label();
        label12 = new Label();
        TituloAlternativoText = new TextBox();
        ObraOriginalText = new TextBox();
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
        label9 = new Label();
        PaisOrigemText = new TextBox();
        label15 = new Label();
        IdiomaOriginalText = new TextBox();
        label18 = new Label();
        SerieText = new TextBox();
        label19 = new Label();
        AutoresText = new TextBox();
        label20 = new Label();
        CriadoresText = new TextBox();
        VoltarButton = new Button();
        ProximoButton = new Button();
        AnteriorButton = new Button();
        EditarButton = new Button();
        InserirNovoButton = new Button();
        CopiarButton = new Button();
        SuspendLayout();
        // 
        // EstudioText
        // 
        EstudioText.Location = new Point(12, 667);
        EstudioText.Name = "EstudioText";
        EstudioText.PlaceholderText = "Estúdio";
        EstudioText.Size = new Size(761, 23);
        EstudioText.TabIndex = 73;
        EstudioText.TextChanged += EstudioText_TextChanged;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(12, 649);
        label8.Name = "label8";
        label8.Size = new Size(46, 15);
        label8.TabIndex = 72;
        label8.Text = "Estúdio";
        // 
        // ResumoText
        // 
        ResumoText.Location = new Point(780, 33);
        ResumoText.Multiline = true;
        ResumoText.Name = "ResumoText";
        ResumoText.PlaceholderText = "Resumo";
        ResumoText.Size = new Size(605, 657);
        ResumoText.TabIndex = 71;
        // 
        // FaseMCUText
        // 
        FaseMCUText.Location = new Point(677, 535);
        FaseMCUText.Name = "FaseMCUText";
        FaseMCUText.PlaceholderText = "Fase MCU";
        FaseMCUText.Size = new Size(96, 23);
        FaseMCUText.TabIndex = 70;
        FaseMCUText.Text = "--";
        FaseMCUText.TextChanged += FaseMCUText_TextChanged;
        // 
        // EstrelasText
        // 
        EstrelasText.Location = new Point(12, 623);
        EstrelasText.Name = "EstrelasText";
        EstrelasText.PlaceholderText = "Estrelas";
        EstrelasText.Size = new Size(761, 23);
        EstrelasText.TabIndex = 69;
        EstrelasText.TextChanged += EstrelasText_TextChanged;
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(12, 561);
        label17.Name = "label17";
        label17.Size = new Size(43, 15);
        label17.TabIndex = 68;
        label17.Text = "Diretor";
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(12, 605);
        label16.Name = "label16";
        label16.Size = new Size(46, 15);
        label16.TabIndex = 67;
        label16.Text = "Estrelas";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(779, 15);
        label14.Name = "label14";
        label14.Size = new Size(50, 15);
        label14.TabIndex = 66;
        label14.Text = "Resumo";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(399, 473);
        label13.Name = "label13";
        label13.Size = new Size(45, 15);
        label13.TabIndex = 65;
        label13.Text = "Gênero";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(12, 517);
        label10.Name = "label10";
        label10.Size = new Size(31, 15);
        label10.TabIndex = 64;
        label10.Text = "Tags";
        // 
        // DataLancamentoText
        // 
        DataLancamentoText.Location = new Point(656, 315);
        DataLancamentoText.Mask = "00/00/0000";
        DataLancamentoText.Name = "DataLancamentoText";
        DataLancamentoText.Size = new Size(118, 23);
        DataLancamentoText.TabIndex = 63;
        DataLancamentoText.ValidatingType = typeof(DateTime);
        DataLancamentoText.MaskInputRejected += DataLancamentoText_MaskInputRejected;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(13, 473);
        label11.Name = "label11";
        label11.Size = new Size(78, 15);
        label11.TabIndex = 62;
        label11.Text = "Obra Original";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(13, 341);
        label12.Name = "label12";
        label12.Size = new Size(99, 15);
        label12.TabIndex = 61;
        label12.Text = "Título Alternativo";
        // 
        // TituloAlternativoText
        // 
        TituloAlternativoText.Location = new Point(12, 359);
        TituloAlternativoText.Name = "TituloAlternativoText";
        TituloAlternativoText.PlaceholderText = "Título Alternativo";
        TituloAlternativoText.Size = new Size(382, 23);
        TituloAlternativoText.TabIndex = 60;
        TituloAlternativoText.Text = "--";
        TituloAlternativoText.TextChanged += TituloAlternativoText_TextChanged;
        // 
        // ObraOriginalText
        // 
        ObraOriginalText.Location = new Point(12, 491);
        ObraOriginalText.Name = "ObraOriginalText";
        ObraOriginalText.PlaceholderText = "Franquia";
        ObraOriginalText.Size = new Size(381, 23);
        ObraOriginalText.TabIndex = 59;
        ObraOriginalText.Text = "--";
        ObraOriginalText.TextChanged += ObraOriginalText_TextChanged;
        // 
        // GeneroText
        // 
        GeneroText.Location = new Point(399, 491);
        GeneroText.Name = "GeneroText";
        GeneroText.PlaceholderText = "Gênero ";
        GeneroText.Size = new Size(374, 23);
        GeneroText.TabIndex = 58;
        GeneroText.TextChanged += GeneroText_TextChanged;
        // 
        // DiretorText
        // 
        DiretorText.Location = new Point(12, 579);
        DiretorText.Name = "DiretorText";
        DiretorText.PlaceholderText = "Diretor";
        DiretorText.Size = new Size(761, 23);
        DiretorText.TabIndex = 57;
        DiretorText.TextChanged += DiretorText_TextChanged;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(658, 297);
        label5.Name = "label5";
        label5.Size = new Size(116, 15);
        label5.TabIndex = 56;
        label5.Text = "Data de Lançamento";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(677, 517);
        label6.Name = "label6";
        label6.Size = new Size(60, 15);
        label6.TabIndex = 55;
        label6.Text = "Fase MCU";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(12, 297);
        label7.Name = "label7";
        label7.Size = new Size(83, 15);
        label7.TabIndex = 54;
        label7.Text = "Título Original";
        // 
        // TagsText
        // 
        TagsText.Location = new Point(13, 535);
        TagsText.Name = "TagsText";
        TagsText.PlaceholderText = "Tags";
        TagsText.Size = new Size(658, 23);
        TagsText.TabIndex = 53;
        TagsText.TextChanged += TagsText_TextChanged;
        // 
        // TituloOriginalText
        // 
        TituloOriginalText.Location = new Point(12, 315);
        TituloOriginalText.Name = "TituloOriginalText";
        TituloOriginalText.PlaceholderText = "Título Original";
        TituloOriginalText.Size = new Size(638, 23);
        TituloOriginalText.TabIndex = 52;
        TituloOriginalText.TextChanged += TituloOriginalText_TextChanged;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(630, 15);
        label4.Name = "label4";
        label4.Size = new Size(39, 15);
        label4.TabIndex = 51;
        label4.Text = "Áudio";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(118, 15);
        label3.Name = "label3";
        label3.Size = new Size(38, 15);
        label3.TabIndex = 50;
        label3.Text = "Título";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 59);
        label2.Name = "label2";
        label2.Size = new Size(48, 15);
        label2.TabIndex = 49;
        label2.Text = "Sinopse";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 15);
        label1.Name = "label1";
        label1.Size = new Size(46, 15);
        label1.TabIndex = 48;
        label1.Text = "Código";
        // 
        // SinopseText
        // 
        SinopseText.Location = new Point(12, 77);
        SinopseText.Multiline = true;
        SinopseText.Name = "SinopseText";
        SinopseText.PlaceholderText = "Sinopse";
        SinopseText.Size = new Size(762, 217);
        SinopseText.TabIndex = 47;
        SinopseText.TextChanged += SinopseText_TextChanged;
        // 
        // AudioBox
        // 
        AudioBox.FormattingEnabled = true;
        AudioBox.Items.AddRange(new object[] { "Dublado", "Legendado", "Nacional", "Desconhecido" });
        AudioBox.Location = new Point(630, 33);
        AudioBox.Name = "AudioBox";
        AudioBox.Size = new Size(144, 23);
        AudioBox.TabIndex = 46;
        AudioBox.Text = "Dublado";
        AudioBox.SelectedIndexChanged += AudioBox_SelectedIndexChanged;
        // 
        // TituloText
        // 
        TituloText.Location = new Point(118, 33);
        TituloText.Name = "TituloText";
        TituloText.PlaceholderText = "Título";
        TituloText.Size = new Size(506, 23);
        TituloText.TabIndex = 45;
        TituloText.TextChanged += TituloText_TextChanged;
        // 
        // CodigoText
        // 
        CodigoText.Location = new Point(12, 33);
        CodigoText.Name = "CodigoText";
        CodigoText.PlaceholderText = "Código";
        CodigoText.Size = new Size(100, 23);
        CodigoText.TabIndex = 44;
        CodigoText.KeyPress += CodigoText_KeyPress;
        CodigoText.Leave += CodigoText_Leave;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(401, 341);
        label9.Name = "label9";
        label9.Size = new Size(87, 15);
        label9.TabIndex = 81;
        label9.Text = "País de Origem";
        // 
        // PaisOrigemText
        // 
        PaisOrigemText.Location = new Point(400, 359);
        PaisOrigemText.Name = "PaisOrigemText";
        PaisOrigemText.PlaceholderText = "País de Origem";
        PaisOrigemText.Size = new Size(374, 23);
        PaisOrigemText.TabIndex = 80;
        PaisOrigemText.TextChanged += PaisOrigemText_TextChanged;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(13, 385);
        label15.Name = "label15";
        label15.Size = new Size(103, 15);
        label15.TabIndex = 83;
        label15.Text = "Idioma de Origem";
        // 
        // IdiomaOriginalText
        // 
        IdiomaOriginalText.Location = new Point(12, 403);
        IdiomaOriginalText.Name = "IdiomaOriginalText";
        IdiomaOriginalText.PlaceholderText = "Idioma de Origem";
        IdiomaOriginalText.Size = new Size(381, 23);
        IdiomaOriginalText.TabIndex = 82;
        IdiomaOriginalText.TextChanged += IdiomaOriginalText_TextChanged;
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Location = new Point(13, 429);
        label18.Name = "label18";
        label18.Size = new Size(32, 15);
        label18.TabIndex = 85;
        label18.Text = "Série";
        // 
        // SerieText
        // 
        SerieText.Location = new Point(12, 447);
        SerieText.Name = "SerieText";
        SerieText.PlaceholderText = "Série";
        SerieText.Size = new Size(381, 23);
        SerieText.TabIndex = 84;
        SerieText.TextChanged += SerieText_TextChanged;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Location = new Point(401, 385);
        label19.Name = "label19";
        label19.Size = new Size(48, 15);
        label19.TabIndex = 87;
        label19.Text = "Autores";
        // 
        // AutoresText
        // 
        AutoresText.Location = new Point(400, 403);
        AutoresText.Name = "AutoresText";
        AutoresText.PlaceholderText = "Autores";
        AutoresText.Size = new Size(374, 23);
        AutoresText.TabIndex = 86;
        AutoresText.TextChanged += AutoresText_TextChanged;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(402, 429);
        label20.Name = "label20";
        label20.Size = new Size(57, 15);
        label20.TabIndex = 89;
        label20.Text = "Criadores";
        // 
        // CriadoresText
        // 
        CriadoresText.Location = new Point(401, 447);
        CriadoresText.Name = "CriadoresText";
        CriadoresText.PlaceholderText = "Criadores";
        CriadoresText.Size = new Size(373, 23);
        CriadoresText.TabIndex = 88;
        CriadoresText.TextChanged += CriadoresText_TextChanged;
        // 
        // VoltarButton
        // 
        VoltarButton.BackColor = Color.FromArgb(9, 32, 63);
        VoltarButton.FlatStyle = FlatStyle.Popup;
        VoltarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
        VoltarButton.ForeColor = Color.White;
        VoltarButton.ImageIndex = 0;
        VoltarButton.Location = new Point(1076, 729);
        VoltarButton.Name = "VoltarButton";
        VoltarButton.Size = new Size(160, 85);
        VoltarButton.TabIndex = 131;
        VoltarButton.Text = "Voltar";
        VoltarButton.TextAlign = ContentAlignment.BottomLeft;
        VoltarButton.UseVisualStyleBackColor = false;
        // 
        // ProximoButton
        // 
        ProximoButton.BackColor = Color.FromArgb(29, 38, 113);
        ProximoButton.FlatStyle = FlatStyle.Popup;
        ProximoButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
        ProximoButton.ForeColor = Color.White;
        ProximoButton.ImageIndex = 3;
        ProximoButton.Location = new Point(893, 729);
        ProximoButton.Name = "ProximoButton";
        ProximoButton.Size = new Size(160, 85);
        ProximoButton.TabIndex = 130;
        ProximoButton.Text = "Próximo";
        ProximoButton.TextAlign = ContentAlignment.BottomLeft;
        ProximoButton.UseVisualStyleBackColor = false;
        // 
        // AnteriorButton
        // 
        AnteriorButton.BackColor = Color.FromArgb(195, 55, 100);
        AnteriorButton.FlatStyle = FlatStyle.Popup;
        AnteriorButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
        AnteriorButton.ForeColor = Color.White;
        AnteriorButton.ImageIndex = 4;
        AnteriorButton.Location = new Point(710, 729);
        AnteriorButton.Name = "AnteriorButton";
        AnteriorButton.Size = new Size(160, 85);
        AnteriorButton.TabIndex = 129;
        AnteriorButton.Text = "Anterior";
        AnteriorButton.TextAlign = ContentAlignment.BottomLeft;
        AnteriorButton.UseVisualStyleBackColor = false;
        // 
        // EditarButton
        // 
        EditarButton.BackColor = Color.FromArgb(46, 34, 114);
        EditarButton.FlatStyle = FlatStyle.Popup;
        EditarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
        EditarButton.ForeColor = Color.White;
        EditarButton.ImageIndex = 2;
        EditarButton.Location = new Point(527, 729);
        EditarButton.Name = "EditarButton";
        EditarButton.Size = new Size(160, 85);
        EditarButton.TabIndex = 128;
        EditarButton.Text = "Editar";
        EditarButton.TextAlign = ContentAlignment.BottomLeft;
        EditarButton.UseVisualStyleBackColor = false;
        // 
        // InserirNovoButton
        // 
        InserirNovoButton.BackColor = Color.FromArgb(229, 92, 68);
        InserirNovoButton.FlatStyle = FlatStyle.Popup;
        InserirNovoButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
        InserirNovoButton.ForeColor = Color.White;
        InserirNovoButton.ImageIndex = 5;
        InserirNovoButton.Location = new Point(344, 729);
        InserirNovoButton.Name = "InserirNovoButton";
        InserirNovoButton.Size = new Size(160, 85);
        InserirNovoButton.TabIndex = 127;
        InserirNovoButton.Text = "Inserir Novo";
        InserirNovoButton.TextAlign = ContentAlignment.BottomLeft;
        InserirNovoButton.UseVisualStyleBackColor = false;
        // 
        // CopiarButton
        // 
        CopiarButton.BackColor = Color.FromArgb(0, 97, 149);
        CopiarButton.FlatStyle = FlatStyle.Popup;
        CopiarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
        CopiarButton.ForeColor = Color.White;
        CopiarButton.ImageKey = "content-copy.png";
        CopiarButton.Location = new Point(161, 729);
        CopiarButton.Name = "CopiarButton";
        CopiarButton.Size = new Size(160, 85);
        CopiarButton.TabIndex = 126;
        CopiarButton.Text = "Copiar Dados";
        CopiarButton.TextAlign = ContentAlignment.BottomLeft;
        CopiarButton.UseVisualStyleBackColor = false;
        // 
        // SeriesView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1397, 852);
        Controls.Add(VoltarButton);
        Controls.Add(ProximoButton);
        Controls.Add(AnteriorButton);
        Controls.Add(EditarButton);
        Controls.Add(InserirNovoButton);
        Controls.Add(CopiarButton);
        Controls.Add(label20);
        Controls.Add(CriadoresText);
        Controls.Add(label19);
        Controls.Add(AutoresText);
        Controls.Add(label18);
        Controls.Add(SerieText);
        Controls.Add(label15);
        Controls.Add(IdiomaOriginalText);
        Controls.Add(label9);
        Controls.Add(PaisOrigemText);
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
        Controls.Add(ObraOriginalText);
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
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "SeriesView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Séries";
        Load += SeriesView_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox EstudioText;
    private Label label8;
    private TextBox ResumoText;
    private TextBox FaseMCUText;
    private TextBox EstrelasText;
    private Label label17;
    private Label label16;
    private Label label14;
    private Label label13;
    private Label label10;
    private MaskedTextBox DataLancamentoText;
    private Label label11;
    private Label label12;
    private TextBox TituloAlternativoText;
    private TextBox ObraOriginalText;
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
    private Label label9;
    private TextBox PaisOrigemText;
    private Label label15;
    private TextBox IdiomaOriginalText;
    private Label label18;
    private TextBox SerieText;
    private Label label19;
    private TextBox AutoresText;
    private Label label20;
    private TextBox CriadoresText;
    private Button VoltarButton;
    private Button ProximoButton;
    private Button AnteriorButton;
    private Button EditarButton;
    private Button InserirNovoButton;
    private Button CopiarButton;
}