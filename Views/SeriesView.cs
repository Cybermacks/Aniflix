using DeepL;
using System.Data;
using Aniflix.Models;
using Aniflix.Globals;
using Aniflix.Services;
using Aniflix.Extensions;
using Aniflix.Controllers;
using System.Globalization;

namespace Aniflix;
public partial class SeriesView : Form
{
    private int currentId = 0;
    private bool editando = false;
    public SeriesView()
    {
        InitializeComponent();
    }

    private async Task GivenData()
    {
        try
        {

            var client = new TMDbLib.Client.TMDbClient("1dcbf681735d3e7454953f5b7c22b6dc")
            {
                DefaultLanguage = "pt-BR",
                DefaultCountry = "BR",
            };

            var deepL = new DeepLClient("7feb3eb8-de95-4312-843c-1064aecdab8b:fx");
            var codigo = int.Parse(CodigoText.Text);
            var givenTask = client.GetTvShowAsync(codigo);
            var creditsTask = client.GetTvShowCreditsAsync(Convert.ToInt32(CodigoText.Text));

            await Task.WhenAll(givenTask, creditsTask);

            var given = givenTask.Result;
            var credits = creditsTask.Result;
            var country = await deepL.TranslateTextAsync(given.ProductionCountries[0].Name, null, LanguageCode.PortugueseBrazilian);
            var language = await deepL.TranslateTextAsync(given.SpokenLanguages[0].Name, null, LanguageCode.PortugueseBrazilian);




            if (given != null)
            {
                Invoke((Action)(() =>
                {
                    TituloText.Text = given.Name;
                    SinopseText.Text = given.Overview;
                    TituloOriginalText.Text = given.OriginalName;
                    DataLancamentoText.Text = given.FirstAirDate?.ToString("dd/MM/yyyy");
                    PaisOrigemText.Text = "#" + StringExtensions.RemoveDiacritics(country.Text.Replace(" ", ""));
                    IdiomaOriginalText.Text = "#" + StringExtensions.RemoveDiacritics(language.Text.Replace(" ", ""));
                    SerieText.Text = "#" + StringExtensions.StripPunctuation(given.Name.Replace(" ", ""));
                }));

                if (
                    DateTime.TryParseExact(
                        DataLancamentoText.Text,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out var releaseData
                    )
                )
                {
                    string ano = releaseData.Year.ToString();
                    TagsText.Text = $"#Serie #Serie{ano} #Série #Série{ano}";
                }

                if (given.Genres != null && given.Genres.Count > 2)
                {
                    var hashtags = new HashSet<string>();

                    static void FormatGenre(string genre, HashSet<string> hashtags)
                    {
                        Dictionary<string, string> specialWords = new()
                    {

                        { "ficção científica", "ficcaocientifica ficçãocientífica" },
                        { "romântico", "romantico romântico" },
                        { "romântica", "romantica romântica" },
                        { "comédia", "comedia comédia" },
                        { "mistério", "misterio mistério" },
                        { "ação", "acao ação" }
                    };

                        string lowerGenre = genre.ToLower();

                        if (specialWords.TryGetValue(lowerGenre, out string? value))
                        {
                            foreach (var tag in value.Split(' '))
                            {
                                hashtags.Add($"#{tag}");
                            }
                        }
                        else
                        {
                            string clean = new(genre.RemoveDiacritics().Where(char.IsAscii).ToArray());
                            hashtags.Add($"#{genre.ToLower().Replace(" ", "")}");
                            hashtags.Add($"#{clean.ToLower().Replace(" ", "")}");
                        }
                    }

                    FormatGenre(given.Genres[0].Name, hashtags);
                    FormatGenre(given.Genres[1].Name, hashtags);
                    FormatGenre(given.Genres[2].Name, hashtags);

                    GeneroText.Text = string.Join(" ", hashtags);
                }
            }
            else
            {
                Invoke(() =>
                {
                    MessageBox.Show("Nenhuma série encontrada.", "Séries - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CodigoText.Focus();
                });
            }

            if (given != null && given.CreatedBy != null)
            {
                var creators = given
                .CreatedBy.Select(person => $"#{person.Name.Replace(" ", "")}")
                .ToList();

                Invoke((Action)(() =>
                {
                    CriadoresText.Text = string.Join(" ", StringExtensions.ClearLists(creators));
                }));
            }
            else
            {
                Invoke((Action)(() =>
                {
                    CriadoresText.Text = string.Empty;
                }));
            }

            if (credits != null && credits.Cast != null)
            {

                var stars = credits
                .Cast.Take(5)
                .Select(person => $"#{person.Name.Replace(" ", "")}")
                .ToList();
                Invoke((Action)(() =>
                {
                    EstrelasText.Text = string.Join(" ", StringExtensions.ClearLists(stars));
                }));
            }
            else
            {
                Invoke((Action)(() =>
                {
                    EstrelasText.Text = string.Empty;
                }));
            }

            if (given != null && given.ProductionCompanies != null)
            {

                var studios = given!
                .ProductionCompanies.Take(5)
                .Select(company => $"#{company.Name.Replace(" ", "")}")
                .ToList();
                Invoke((Action)(() =>
                {
                    EstudioText.Text = string.Join(" ", StringExtensions.ClearLists(studios));
                }));
            }
            else
            {
                Invoke((Action)(() =>
                {
                    EstudioText.Text = string.Empty;
                }));
            }
        }
        catch (Exception ex)
        {
            Invoke((Action)(() =>
            {
                MessageBox.Show($"Erro ao buscar o filme: {ex.Message}", "Séries - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }));
        }
    }

    private async void CodigoText_Leave(object sender, EventArgs e)
    {
        await GivenData();
    }
    private void UpdateData()
    {
        var model = new SeriesServices(
            titulo: TituloText.Text,
            audio: AudioBox.SelectedItem?.ToString() ?? string.Empty,
            sinopse: SinopseText.Text,
            tituloOriginal: TituloOriginalText.Text,
            dataLancamento: DataLancamentoText.Text,
            tituloAlternativo: TituloAlternativoText.Text,
            paisOrigem: PaisOrigemText.Text,
            idiomaOriginal: IdiomaOriginalText.Text,
            serie: SerieText.Text,
            autores: AutoresText.Text,
            criadores: CriadoresText.Text,
            obraOriginal: ObraOriginalText.Text,
            genero: GeneroText.Text,
            tags: TagsText.Text,
            diretor: DiretorText.Text,
            mcu: FaseMCUText.Text,
            estrelas: EstrelasText.Text,
            estudio: EstudioText.Text

            );
        ResumoText.Text = model.GetFormattedText();
    }

    private void PreencheDados(DataRow record)
    {
        if (record != null)
        {
            currentId = Convert.ToInt32(record["id"]);
            CodigoText.Text = record["codigo"].ToString();
            TituloText.Text = record["titulo"].ToString();
            AudioBox.SelectedItem = record["audio"].ToString();
            SinopseText.Text = record["sinopse"].ToString();
            TituloOriginalText.Text = record["titulo_original"].ToString();
            DataLancamentoText.Text = record["data_lancamento"].ToString();
            TituloAlternativoText.Text = record["titulo_alternativo"].ToString();
            PaisOrigemText.Text = record["pais_origem"].ToString();
            IdiomaOriginalText.Text = record["idioma_original"].ToString();
            SerieText.Text = record["serie"].ToString();
            AutoresText.Text = record["autores"].ToString();
            CriadoresText.Text = record["criadores"].ToString();
            ObraOriginalText.Text = record["obra_original"].ToString();
            GeneroText.Text = record["genero"].ToString();
            TagsText.Text = record["tags"].ToString();
            DiretorText.Text = record["diretor"].ToString();
            FaseMCUText.Text = record["mcu"].ToString();
            EstrelasText.Text = record["estrelas"].ToString();
            EstudioText.Text = record["estudio"].ToString();
        }
    }
    private void Next()
    {
        var nextRecord = SeriesController.MoveProximo(currentId);

        if (nextRecord != null)
        {
            PreencheDados(nextRecord);
        }
        else
        {
            MessageBox.Show("Você chegou ao último registro.", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    private void Previous()
    {
        var previousRecord = SeriesController.MoveAnterior(currentId);

        if (previousRecord != null)
        {
            PreencheDados(previousRecord);
        }
        else
        {
            MessageBox.Show("Você chegou ao primeiro registro.", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void CarregarFilme()
    {
        var serie = SeriesController.MostraPrimeiro();

        if (serie != null)
        {
            CodigoText.Text = serie["codigo"].ToString();
            TituloText.Text = serie["titulo"].ToString();
            AudioBox.SelectedItem = serie["audio"].ToString();
            SinopseText.Text = serie["sinopse"].ToString();
            TituloOriginalText.Text = serie["titulo_original"].ToString();
            DataLancamentoText.Text = serie["data_lancamento"].ToString();
            TituloAlternativoText.Text = serie["titulo_alternativo"].ToString();
            PaisOrigemText.Text = serie["pais_origem"].ToString();
            IdiomaOriginalText.Text = serie["idioma_original"].ToString();
            SerieText.Text = serie["serie"].ToString();
            AutoresText.Text = serie["autores"].ToString();
            CriadoresText.Text = serie["criadores"].ToString();
            ObraOriginalText.Text = serie["obra_original"].ToString();
            GeneroText.Text = serie["genero"].ToString();
            TagsText.Text = serie["tags"].ToString();
            DiretorText.Text = serie["diretor"].ToString();
            FaseMCUText.Text = serie["mcu"].ToString();
            EstrelasText.Text = serie["estrelas"].ToString();
            EstudioText.Text = serie["estudio"].ToString();
        }
    }

    private void TituloText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void AudioBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void SinopseText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void TituloOriginalText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void DataLancamentoText_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {
        UpdateData();
    }

    private void TituloAlternativoText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void PaisOrigemText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void IdiomaOriginalText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void AutoresText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void SerieText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void CriadoresText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void ObraOriginalText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void GeneroText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }
    private void TagsText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }

    private void FaseMCUText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }
    private void DiretorText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }
    private void EstrelasText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }
    private void EstudioText_TextChanged(object sender, EventArgs e)
    {
        UpdateData();
    }
    private void SeriesView_Load(object sender, EventArgs e)
    {
        UpdateData();
        CarregarFilme();
        Functions.DoReadOnly(this);
        TituloAlternativoText.Text = "--";
        FaseMCUText.Text = "--";
        FranquiaText.Text = "--";
    }
    private void CopiarButton_Click(object sender, EventArgs e)
    {

        ResumoText.SelectAll();
        ResumoText.Copy();
    }

    private void InserirNovoButton_Click(object sender, EventArgs e)
    {
        var series = new Series
        {
            Codigo = CodigoText.Text,
            Titulo = TituloText.Text,
            Audio = AudioBox.SelectedItem?.ToString() ?? string.Empty,
            Sinopse = SinopseText.Text,
            TituloOriginal = TituloOriginalText.Text,
            DataLancamento = DataLancamentoText.Text,
            TituloAlternativo = TituloAlternativoText.Text,
            PaisOrigem = PaisOrigemText.Text,
            IdiomaOriginal = IdiomaOriginalText.Text,
            Serie = SerieText.Text,
            Autores = AutoresText.Text,
            Criadores = CriadoresText.Text,
            ObraOriginal = ObraOriginalText.Text,
            Genero = GeneroText.Text,
            Tags = TagsText.Text,
            Diretor = DiretorText.Text,
            MCU = FaseMCUText.Text,
            Estrelas = EstrelasText.Text,
            Estudio = EstudioText.Text
        };

        if (!string.IsNullOrEmpty(series.Codigo))
        {
            SeriesController.Registrar(series);
        }
        else
        {
            MessageBox.Show("Por favor, insira o código de pesquisa da série.", "Séries - Inserir Novo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void AnteriorButton_Click(object sender, EventArgs e)
    {
        Previous();
    }

    private void ProximoButton_Click(object sender, EventArgs e)
    {
        Next();
    }

    private void EditarButton_Click(object sender, EventArgs e)
    {
        var series = new Series
        {
            Codigo = CodigoText.Text,
            Titulo = TituloText.Text,
            Audio = AudioBox.SelectedItem?.ToString() ?? string.Empty,
            Sinopse = SinopseText.Text,
            TituloOriginal = TituloOriginalText.Text,
            DataLancamento = DataLancamentoText.Text,
            TituloAlternativo = TituloAlternativoText.Text,
            PaisOrigem = PaisOrigemText.Text,
            IdiomaOriginal = IdiomaOriginalText.Text,
            Serie = SerieText.Text,
            Autores = AutoresText.Text,
            Criadores = CriadoresText.Text,
            ObraOriginal = ObraOriginalText.Text,
            Genero = GeneroText.Text,
            Tags = TagsText.Text,
            Diretor = DiretorText.Text,
            MCU = FaseMCUText.Text,
            Estrelas = EstrelasText.Text,
            Estudio = EstudioText.Text
        };

        if (!editando)
        {
            editando = true;
            EditarButton.Text = "Cancelar";
            Functions.UndoReadOnly(this);
        }
        else if (EditarButton.Text == "Cancelar")
        {
            var cancelar = MessageBox.Show($"Cancelar a edição da série {series.Titulo} ?", "Séries - Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cancelar == DialogResult.Yes)
            {
                editando = false;
                Functions.DoReadOnly(this);
                EditarButton.Text = "Editar";
            }
            else
            {
                EditarButton.Text = "Salvar";
            }
        }
        else if (EditarButton.Text == "Salvar")
        {
            var atualizar = MessageBox.Show($"Atualizar as informações sobre o filme {series.Titulo} ?", "Séries - Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (atualizar == DialogResult.Yes)
            {
                SeriesController.AtualizaDados(series);
            }

            Functions.DoReadOnly(this);
            EditarButton.Text = "Editar";
            editando = false;
        }
    }
}
