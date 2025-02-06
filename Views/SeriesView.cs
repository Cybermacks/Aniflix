using DeepL;
using Aniflix.Models;
using Aniflix.Services;
using Aniflix.Extensions;
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
                    TagsText.Text = $"#Serie #Serie{ano} #S�rie #S�rie{ano}";
                }

                if (given.Genres != null && given.Genres.Count > 2)
                {
                    var hashtags = new HashSet<string>();

                    static void FormatGenre(string genre, HashSet<string> hashtags)
                    {
                        Dictionary<string, string> specialWords = new()
                    {

                        { "fic��o cient�fica", "ficcaocientifica fic��ocient�fica" },
                        { "rom�ntico", "romantico rom�ntico" },
                        { "rom�ntica", "romantica rom�ntica" },
                        { "com�dia", "comedia com�dia" },
                        { "mist�rio", "misterio mist�rio" },
                        { "a��o", "acao a��o" }
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
                    MessageBox.Show("Nenhuma s�rie encontrada.", "S�ries - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Erro ao buscar o filme: {ex.Message}", "S�ries - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }

    private void CopiarButton_Click(object sender, EventArgs e)
    {
        ResumoText.SelectAll();
        ResumoText.Copy();
    }
}