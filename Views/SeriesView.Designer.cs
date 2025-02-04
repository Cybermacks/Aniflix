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
        VoltarButton = new Button();
        ProximoButton = new Button();
        AnteriorButton = new Button();
        EditarButton = new Button();
        SalvarButton = new Button();
        CopiarButton = new Button();
        FilmesEstudioText = new TextBox();
        label8 = new Label();
        FilmesResumoText = new TextBox();
        FilmesFaseMCUText = new TextBox();
        FilmesEstrelasText = new TextBox();
        label17 = new Label();
        label16 = new Label();
        label14 = new Label();
        label13 = new Label();
        label10 = new Label();
        FilmesDataLancamentoText = new MaskedTextBox();
        label11 = new Label();
        label12 = new Label();
        FilmesTituloAlternativoText = new TextBox();
        FilmesFranquiaText = new TextBox();
        FilmesGeneroText = new TextBox();
        FilmesDiretorText = new TextBox();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        FilmesTagsText = new TextBox();
        FilmesTituloOriginalText = new TextBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        FilmesSinopseText = new TextBox();
        FilmesAudioBox = new ComboBox();
        FilmesTituloText = new TextBox();
        FilmesCodigoText = new TextBox();
        label9 = new Label();
        textBox1 = new TextBox();
        label15 = new Label();
        textBox2 = new TextBox();
        label18 = new Label();
        textBox3 = new TextBox();
        label19 = new Label();
        textBox4 = new TextBox();
        label20 = new Label();
        textBox5 = new TextBox();
        SuspendLayout();
        // 
        // VoltarButton
        // 
        VoltarButton.BackColor = Color.FromArgb(9, 32, 63);
        VoltarButton.FlatStyle = FlatStyle.Popup;
        VoltarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
        VoltarButton.ForeColor = Color.White;
        VoltarButton.ImageIndex = 0;
        VoltarButton.Location = new Point(1075, 742);
        VoltarButton.Name = "VoltarButton";
        VoltarButton.Size = new Size(137, 61);
        VoltarButton.TabIndex = 79;
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
        ProximoButton.Location = new Point(897, 742);
        ProximoButton.Name = "ProximoButton";
        ProximoButton.Size = new Size(137, 61);
        ProximoButton.TabIndex = 78;
        ProximoButton.Text = "Próximo";
        ProximoButton.UseVisualStyleBackColor = false;
        // 
        // AnteriorButton
        // 
        AnteriorButton.BackColor = Color.FromArgb(195, 55, 100);
        AnteriorButton.FlatStyle = FlatStyle.Popup;
        AnteriorButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
        AnteriorButton.ForeColor = Color.White;
        AnteriorButton.ImageIndex = 4;
        AnteriorButton.Location = new Point(719, 742);
        AnteriorButton.Name = "AnteriorButton";
        AnteriorButton.Size = new Size(137, 61);
        AnteriorButton.TabIndex = 77;
        AnteriorButton.Text = "Anterior";
        AnteriorButton.UseVisualStyleBackColor = false;
        // 
        // EditarButton
        // 
        EditarButton.BackColor = Color.FromArgb(46, 34, 114);
        EditarButton.FlatStyle = FlatStyle.Popup;
        EditarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
        EditarButton.ForeColor = Color.White;
        EditarButton.ImageIndex = 2;
        EditarButton.Location = new Point(541, 742);
        EditarButton.Name = "EditarButton";
        EditarButton.Size = new Size(137, 61);
        EditarButton.TabIndex = 76;
        EditarButton.Text = "Editar";
        EditarButton.UseVisualStyleBackColor = false;
        // 
        // SalvarButton
        // 
        SalvarButton.BackColor = Color.FromArgb(229, 92, 68);
        SalvarButton.FlatStyle = FlatStyle.Popup;
        SalvarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
        SalvarButton.ForeColor = Color.White;
        SalvarButton.ImageIndex = 2;
        SalvarButton.Location = new Point(363, 742);
        SalvarButton.Name = "SalvarButton";
        SalvarButton.Size = new Size(137, 61);
        SalvarButton.TabIndex = 75;
        SalvarButton.Text = "Inserir Novo";
        SalvarButton.UseVisualStyleBackColor = false;
        // 
        // CopiarButton
        // 
        CopiarButton.BackColor = Color.FromArgb(0, 97, 149);
        CopiarButton.FlatStyle = FlatStyle.Popup;
        CopiarButton.Font = new Font("Roboto", 12F, FontStyle.Bold);
        CopiarButton.ForeColor = Color.White;
        CopiarButton.ImageIndex = 1;
        CopiarButton.Location = new Point(185, 742);
        CopiarButton.Name = "CopiarButton";
        CopiarButton.Size = new Size(137, 61);
        CopiarButton.TabIndex = 74;
        CopiarButton.Text = "Copiar Dados";
        CopiarButton.UseVisualStyleBackColor = false;
        // 
        // FilmesEstudioText
        // 
        FilmesEstudioText.Location = new Point(12, 667);
        FilmesEstudioText.Name = "FilmesEstudioText";
        FilmesEstudioText.PlaceholderText = "Estúdio";
        FilmesEstudioText.Size = new Size(661, 23);
        FilmesEstudioText.TabIndex = 73;
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
        // FilmesResumoText
        // 
        FilmesResumoText.Location = new Point(779, 33);
        FilmesResumoText.Multiline = true;
        FilmesResumoText.Name = "FilmesResumoText";
        FilmesResumoText.PlaceholderText = "Resumo";
        FilmesResumoText.Size = new Size(601, 657);
        FilmesResumoText.TabIndex = 71;
        // 
        // FilmesFaseMCUText
        // 
        FilmesFaseMCUText.Location = new Point(679, 667);
        FilmesFaseMCUText.Name = "FilmesFaseMCUText";
        FilmesFaseMCUText.PlaceholderText = "Fase MCU";
        FilmesFaseMCUText.Size = new Size(96, 23);
        FilmesFaseMCUText.TabIndex = 70;
        FilmesFaseMCUText.Text = "--";
        // 
        // FilmesEstrelasText
        // 
        FilmesEstrelasText.Location = new Point(12, 623);
        FilmesEstrelasText.Name = "FilmesEstrelasText";
        FilmesEstrelasText.PlaceholderText = "Estrelas";
        FilmesEstrelasText.Size = new Size(761, 23);
        FilmesEstrelasText.TabIndex = 69;
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
        label13.Size = new Size(89, 15);
        label13.TabIndex = 65;
        label13.Text = "Gênero da Série";
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
        // FilmesDataLancamentoText
        // 
        FilmesDataLancamentoText.Location = new Point(656, 315);
        FilmesDataLancamentoText.Mask = "00/00/0000";
        FilmesDataLancamentoText.Name = "FilmesDataLancamentoText";
        FilmesDataLancamentoText.Size = new Size(118, 23);
        FilmesDataLancamentoText.TabIndex = 63;
        FilmesDataLancamentoText.ValidatingType = typeof(DateTime);
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
        // FilmesTituloAlternativoText
        // 
        FilmesTituloAlternativoText.Location = new Point(12, 359);
        FilmesTituloAlternativoText.Name = "FilmesTituloAlternativoText";
        FilmesTituloAlternativoText.PlaceholderText = "Título Alternativo";
        FilmesTituloAlternativoText.Size = new Size(382, 23);
        FilmesTituloAlternativoText.TabIndex = 60;
        FilmesTituloAlternativoText.Text = "--";
        // 
        // FilmesFranquiaText
        // 
        FilmesFranquiaText.Location = new Point(12, 491);
        FilmesFranquiaText.Name = "FilmesFranquiaText";
        FilmesFranquiaText.PlaceholderText = "Franquia";
        FilmesFranquiaText.Size = new Size(381, 23);
        FilmesFranquiaText.TabIndex = 59;
        FilmesFranquiaText.Text = "--";
        // 
        // FilmesGeneroText
        // 
        FilmesGeneroText.Location = new Point(399, 491);
        FilmesGeneroText.Name = "FilmesGeneroText";
        FilmesGeneroText.PlaceholderText = "Gênero da Série";
        FilmesGeneroText.Size = new Size(374, 23);
        FilmesGeneroText.TabIndex = 58;
        // 
        // FilmesDiretorText
        // 
        FilmesDiretorText.Location = new Point(12, 579);
        FilmesDiretorText.Name = "FilmesDiretorText";
        FilmesDiretorText.PlaceholderText = "Diretor";
        FilmesDiretorText.Size = new Size(761, 23);
        FilmesDiretorText.TabIndex = 57;
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
        label6.Location = new Point(679, 649);
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
        // FilmesTagsText
        // 
        FilmesTagsText.Location = new Point(12, 535);
        FilmesTagsText.Name = "FilmesTagsText";
        FilmesTagsText.PlaceholderText = "Tags";
        FilmesTagsText.Size = new Size(761, 23);
        FilmesTagsText.TabIndex = 53;
        // 
        // FilmesTituloOriginalText
        // 
        FilmesTituloOriginalText.Location = new Point(12, 315);
        FilmesTituloOriginalText.Name = "FilmesTituloOriginalText";
        FilmesTituloOriginalText.PlaceholderText = "Título Original";
        FilmesTituloOriginalText.Size = new Size(638, 23);
        FilmesTituloOriginalText.TabIndex = 52;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(634, 15);
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
        // FilmesSinopseText
        // 
        FilmesSinopseText.Location = new Point(12, 77);
        FilmesSinopseText.Multiline = true;
        FilmesSinopseText.Name = "FilmesSinopseText";
        FilmesSinopseText.PlaceholderText = "Sinopse";
        FilmesSinopseText.Size = new Size(762, 217);
        FilmesSinopseText.TabIndex = 47;
        // 
        // FilmesAudioBox
        // 
        FilmesAudioBox.FormattingEnabled = true;
        FilmesAudioBox.Items.AddRange(new object[] { "Dublado", "Legendado", "Nacional", "Desconhecido" });
        FilmesAudioBox.Location = new Point(630, 33);
        FilmesAudioBox.Name = "FilmesAudioBox";
        FilmesAudioBox.Size = new Size(144, 23);
        FilmesAudioBox.TabIndex = 46;
        FilmesAudioBox.Text = "Dublado";
        // 
        // FilmesTituloText
        // 
        FilmesTituloText.Location = new Point(118, 33);
        FilmesTituloText.Name = "FilmesTituloText";
        FilmesTituloText.PlaceholderText = "Título";
        FilmesTituloText.Size = new Size(506, 23);
        FilmesTituloText.TabIndex = 45;
        // 
        // FilmesCodigoText
        // 
        FilmesCodigoText.Location = new Point(12, 33);
        FilmesCodigoText.Name = "FilmesCodigoText";
        FilmesCodigoText.PlaceholderText = "Código";
        FilmesCodigoText.Size = new Size(100, 23);
        FilmesCodigoText.TabIndex = 44;
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
        // textBox1
        // 
        textBox1.Location = new Point(400, 359);
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "País de Origem";
        textBox1.Size = new Size(374, 23);
        textBox1.TabIndex = 80;
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
        // textBox2
        // 
        textBox2.Location = new Point(12, 403);
        textBox2.Name = "textBox2";
        textBox2.PlaceholderText = "Idioma de Origem";
        textBox2.Size = new Size(381, 23);
        textBox2.TabIndex = 82;
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
        // textBox3
        // 
        textBox3.Location = new Point(12, 447);
        textBox3.Name = "textBox3";
        textBox3.PlaceholderText = "Série";
        textBox3.Size = new Size(381, 23);
        textBox3.TabIndex = 84;
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
        // textBox4
        // 
        textBox4.Location = new Point(400, 403);
        textBox4.Name = "textBox4";
        textBox4.PlaceholderText = "Autores";
        textBox4.Size = new Size(374, 23);
        textBox4.TabIndex = 86;
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
        // textBox5
        // 
        textBox5.Location = new Point(401, 447);
        textBox5.Name = "textBox5";
        textBox5.PlaceholderText = "Criadores";
        textBox5.Size = new Size(373, 23);
        textBox5.TabIndex = 88;
        // 
        // SeriesView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1397, 859);
        Controls.Add(label20);
        Controls.Add(textBox5);
        Controls.Add(label19);
        Controls.Add(textBox4);
        Controls.Add(label18);
        Controls.Add(textBox3);
        Controls.Add(label15);
        Controls.Add(textBox2);
        Controls.Add(label9);
        Controls.Add(textBox1);
        Controls.Add(VoltarButton);
        Controls.Add(ProximoButton);
        Controls.Add(AnteriorButton);
        Controls.Add(EditarButton);
        Controls.Add(SalvarButton);
        Controls.Add(CopiarButton);
        Controls.Add(FilmesEstudioText);
        Controls.Add(label8);
        Controls.Add(FilmesResumoText);
        Controls.Add(FilmesFaseMCUText);
        Controls.Add(FilmesEstrelasText);
        Controls.Add(label17);
        Controls.Add(label16);
        Controls.Add(label14);
        Controls.Add(label13);
        Controls.Add(label10);
        Controls.Add(FilmesDataLancamentoText);
        Controls.Add(label11);
        Controls.Add(label12);
        Controls.Add(FilmesTituloAlternativoText);
        Controls.Add(FilmesFranquiaText);
        Controls.Add(FilmesGeneroText);
        Controls.Add(FilmesDiretorText);
        Controls.Add(label5);
        Controls.Add(label6);
        Controls.Add(label7);
        Controls.Add(FilmesTagsText);
        Controls.Add(FilmesTituloOriginalText);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(FilmesSinopseText);
        Controls.Add(FilmesAudioBox);
        Controls.Add(FilmesTituloText);
        Controls.Add(FilmesCodigoText);
        MaximizeBox = false;
        Name = "SeriesView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Séries";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button VoltarButton;
    private Button ProximoButton;
    private Button AnteriorButton;
    private Button EditarButton;
    private Button SalvarButton;
    private Button CopiarButton;
    private TextBox FilmesEstudioText;
    private Label label8;
    private TextBox FilmesResumoText;
    private TextBox FilmesFaseMCUText;
    private TextBox FilmesEstrelasText;
    private Label label17;
    private Label label16;
    private Label label14;
    private Label label13;
    private Label label10;
    private MaskedTextBox FilmesDataLancamentoText;
    private Label label11;
    private Label label12;
    private TextBox FilmesTituloAlternativoText;
    private TextBox FilmesFranquiaText;
    private TextBox FilmesGeneroText;
    private TextBox FilmesDiretorText;
    private Label label5;
    private Label label6;
    private Label label7;
    private TextBox FilmesTagsText;
    private TextBox FilmesTituloOriginalText;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox FilmesSinopseText;
    private ComboBox FilmesAudioBox;
    private TextBox FilmesTituloText;
    private TextBox FilmesCodigoText;
    private Label label9;
    private TextBox textBox1;
    private Label label15;
    private TextBox textBox2;
    private Label label18;
    private TextBox textBox3;
    private Label label19;
    private TextBox textBox4;
    private Label label20;
    private TextBox textBox5;
}