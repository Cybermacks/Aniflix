using Aniflix.Models;
using Aniflix.Factory;
using Aniflix.Services;
using Aniflix.Extensions;
using Aniflix.Controllers;
using System.Globalization;

namespace Aniflix
{
    public partial class FilmesView : Form
    {
        private int filmeAtualId = 1;
        public FilmesView()
        {
            InitializeComponent();
        }
        private async Task GetFilmesAsync()
        {
            try
            {

                var client = new TMDbLib.Client.TMDbClient("1dcbf681735d3e7454953f5b7c22b6dc")
                {
                    DefaultLanguage = "pt-BR",
                    DefaultCountry = "BR",
                };

                var movieTask = client.GetMovieAsync(FilmesCodigoText.Text);
                var creditsTask = client.GetMovieCreditsAsync(Convert.ToInt32(FilmesCodigoText.Text));

                await Task.WhenAll(movieTask, creditsTask);

                var movie = movieTask.Result;
                var credits = creditsTask.Result;

                if (movie != null)
                {
                    Invoke((Action)(() =>
                    {
                        FilmesTituloText.Text = movie.Title;
                        FilmesSinopseText.Text = movie.Overview;
                        FilmesTituloOriginalText.Text = movie.OriginalTitle;
                        FilmesDataLancamentoText.Text = movie.ReleaseDate?.ToString("dd/MM/yyyy");
                    }));

                    if (
                        DateTime.TryParseExact(
                            FilmesDataLancamentoText.Text,
                            "dd/MM/yyyy",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out var releaseData
                        )
                    )
                    {
                        string ano = releaseData.Year.ToString();
                        FilmesTagsText.Text = $"#Filme #Filme{ano}";
                    }

                    if (movie.Genres != null && movie.Genres.Count > 2)
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

                        FormatGenre(movie.Genres[2].Name, hashtags);
                        FormatGenre(movie.Genres[1].Name, hashtags);
                        FormatGenre(movie.Genres[0].Name, hashtags);

                        FilmesGeneroText.Text = string.Join(" ", hashtags);
                    }
                }
                else
                {
                    Invoke(() =>
                    {
                        MessageBox.Show("Nenhum filme encontrado.", "Filmes - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FilmesCodigoText.Focus();
                    });
                }

                if (credits != null && credits.Crew != null)
                {
                    var directors = credits
                    .Crew.Where(person => person.Job == "Director")
                    .Take(4)
                    .Select(person => $"#{person.Name.Replace(" ", "")}")
                    .ToList();

                    Invoke((Action)(() =>
                    {
                        FilmesDiretorText.Text = string.Join(" ", StringExtensions.ClearLists(directors));
                    }));
                }
                else
                {
                    Invoke((Action)(() =>
                    {
                        FilmesDiretorText.Text = string.Empty;
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
                        FilmesEstrelasText.Text = string.Join(" ", StringExtensions.ClearLists(stars));
                    }));
                }
                else
                {
                    Invoke((Action)(() =>
                    {
                        FilmesEstrelasText.Text = string.Empty;
                    }));
                }

                if (movie != null && movie.ProductionCompanies != null)
                {

                    var studios = movie!
                    .ProductionCompanies.Take(5)
                    .Select(company => $"#{company.Name.Replace(" ", "")}")
                    .ToList();
                    Invoke((Action)(() =>
                    {
                        FilmesEstudioText.Text = string.Join(" ", StringExtensions.ClearLists(studios));
                    }));
                }
                else
                {
                    Invoke((Action)(() =>
                    {
                        FilmesEstudioText.Text = string.Empty;
                    }));
                }
            }
            catch (Exception ex)
            {
                Invoke((Action)(() =>
                {
                    MessageBox.Show($"Erro ao buscar o filme: {ex.Message}", "Filmes - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

        private void UpdateData()
        {
            var model = new FilmesServices(
                titulo: FilmesTituloText.Text,
                audio: FilmesAudioBox.SelectedItem?.ToString() ?? string.Empty,
                sinopse: FilmesSinopseText.Text,
                tituloOriginal: FilmesTituloOriginalText.Text,
                dataLancamento: FilmesDataLancamentoText.Text,
                tituloAlternativo: FilmesTituloAlternativoText.Text,
                franquia: FilmesFranquiaText.Text,
                genero: FilmesGeneroText.Text,
                tags: FilmesTagsText.Text,
                diretor: FilmesDiretorText.Text,
                  mcu: FilmesFaseMCUText.Text,
                estrelas: FilmesEstrelasText.Text,
                estudio: FilmesEstudioText.Text

                );
            FilmesResumoText.Text = model.GetFormattedText();
        }

        private void FilmesCodigoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private async void FilmesCodigoText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilmesCodigoText.Text))
            {
                MessageBox.Show("Por favor, insira o código do filme.");
                FilmesCodigoText.Focus();
            }
            else
            {
                await GetFilmesAsync();
            }
        }

        private void FilmesTituloText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesAudioBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesSinopseText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesTituloOriginalText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesDataLancamentoText_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            UpdateData();
        }

        private void FilmesTituloAlternativoText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesTagsText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesFranquiaText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesGeneroText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesDiretorText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesFaseMCUText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesEstrelasText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesEstudioText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesView_Load(object sender, EventArgs e)
        {
            UpdateData();
            CarregarFilme();
            FilmesTituloAlternativoText.Text = "--";
            FilmesFaseMCUText.Text = "--";
            FilmesFranquiaText.Text = "--";
        }

        private void CopiarButton_Click(object sender, EventArgs e)
        {
            FilmesResumoText.SelectAll();
            FilmesResumoText.Copy();
        }


        private void CarregarFilme()
        {
            var filme = FilmesController.GetFirstFilme();
            if (filme != null)
            {
                FilmesCodigoText.Text = filme.Codigo;
                FilmesTituloText.Text = filme.Titulo;
                FilmesAudioBox.SelectedItem = filme.Audio;
                FilmesSinopseText.Text = filme.Sinopse;
                FilmesTituloOriginalText.Text = filme.TituloOriginal;
                FilmesDataLancamentoText.Text = filme.DataLancamento;
                FilmesTituloAlternativoText.Text = filme.TituloAlternativo;
                FilmesFranquiaText.Text = filme.Franquia;
                FilmesGeneroText.Text = filme.Genero;
                FilmesTagsText.Text = filme.Tags;
                FilmesDiretorText.Text = filme.Diretor;
                FilmesFaseMCUText.Text = filme.MCU;
                FilmesEstrelasText.Text = filme.Estrelas;
                FilmesEstudioText.Text = filme.Estudio;
                FilmesEstudioText.Text = filme.Estudio;
            }
        }


        private void SalvarButton_Click(object sender, EventArgs e)
        {
            var filmes = new Filmes
            {
                Codigo = FilmesCodigoText.Text,
                Titulo = FilmesTituloText.Text,
                Audio = FilmesAudioBox.SelectedItem?.ToString() ?? string.Empty,
                Sinopse = FilmesSinopseText.Text,
                TituloOriginal = FilmesTituloOriginalText.Text,
                DataLancamento = FilmesDataLancamentoText.Text,
                TituloAlternativo = FilmesTituloAlternativoText.Text,
                Franquia = FilmesFranquiaText.Text,
                Genero = FilmesGeneroText.Text,
                Tags = FilmesTagsText.Text,
                Diretor = FilmesDiretorText.Text,
                MCU = FilmesFaseMCUText.Text,
                Estrelas = FilmesEstrelasText.Text,
                Estudio = FilmesEstudioText.Text
            };

            if (!string.IsNullOrEmpty(filmes.Codigo))
            {
                FilmesController.InsereNovoFilme(filmes);
            }
            else
            {
                MessageBox.Show("Por favor, insira o código do filme.", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheCampos(Filmes filmes)
        {
            filmes.Codigo = FilmesCodigoText.Text;
            filmes.Titulo = FilmesTituloText.Text;
            filmes.Audio = FilmesAudioBox.SelectedItem?.ToString() ?? string.Empty;
            filmes.Sinopse = FilmesSinopseText.Text;
            filmes.TituloOriginal = FilmesTituloOriginalText.Text;
            filmes.DataLancamento = FilmesDataLancamentoText.Text;
            filmes.TituloAlternativo = FilmesTituloAlternativoText.Text;
            filmes.Franquia = FilmesFranquiaText.Text;
            filmes.Genero = FilmesGeneroText.Text;
            filmes.Tags = FilmesTagsText.Text;
            filmes.Diretor = FilmesDiretorText.Text;
            filmes.MCU = FilmesFaseMCUText.Text;
            filmes.Estrelas = FilmesEstrelasText.Text;
            filmes.Estudio = FilmesEstudioText.Text;
        }
        private void ProximoButton_Click(object sender, EventArgs e)
        {

        }

        private void AnteriorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
