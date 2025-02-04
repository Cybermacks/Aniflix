using System.Data;
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
        private int currentId = 0;
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

                        FormatGenre(movie.Genres[0].Name, hashtags);
                        FormatGenre(movie.Genres[1].Name, hashtags);
                        FormatGenre(movie.Genres[2].Name, hashtags);

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
            DisableControls(this);
            EnableControls(this);
        }

        private void CopiarButton_Click(object sender, EventArgs e)
        {
            FilmesResumoText.SelectAll();
            FilmesResumoText.Copy();
        }


        private void CarregarFilme()
        {
            var filme = FilmesController.BuscaPrimeiroFilme();

            if (filme != null)
            {
                FilmesCodigoText.Text = filme["codigo"].ToString();
                FilmesTituloText.Text = filme["titulo"].ToString();
                FilmesAudioBox.SelectedItem = filme["audio"].ToString();
                FilmesSinopseText.Text = filme["sinopse"].ToString();
                FilmesTituloOriginalText.Text = filme["titulo_original"].ToString();
                FilmesDataLancamentoText.Text = filme["data_lancamento"].ToString();
                FilmesTituloAlternativoText.Text = filme["titulo_alternativo"].ToString();
                FilmesFranquiaText.Text = filme["franquia"].ToString();
                FilmesGeneroText.Text = filme["genero"].ToString();
                FilmesTagsText.Text = filme["tags"].ToString();
                FilmesDiretorText.Text = filme["diretor"].ToString();
                FilmesFaseMCUText.Text = filme["mcu"].ToString();
                FilmesEstrelasText.Text = filme["estrelas"].ToString();
                FilmesEstudioText.Text = filme["estudio"].ToString();
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
                MessageBox.Show("Por favor, insira o código do filme.", "Filmes - Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencheDados(DataRow record)
        {
            if (record != null)
            {
                currentId = Convert.ToInt32(record["id"]);
                FilmesCodigoText.Text = record["codigo"].ToString();
                FilmesTituloText.Text = record["titulo"].ToString();
                FilmesAudioBox.SelectedItem = record["audio"].ToString();
                FilmesSinopseText.Text = record["sinopse"].ToString();
                FilmesTituloOriginalText.Text = record["titulo_original"].ToString();
                FilmesDataLancamentoText.Text = record["data_lancamento"].ToString();
                FilmesTituloAlternativoText.Text = record["titulo_alternativo"].ToString();
                FilmesFranquiaText.Text = record["franquia"].ToString();
                FilmesGeneroText.Text = record["genero"].ToString();
                FilmesTagsText.Text = record["tags"].ToString();
                FilmesDiretorText.Text = record["diretor"].ToString();
                FilmesFaseMCUText.Text = record["mcu"].ToString();
                FilmesEstrelasText.Text = record["estrelas"].ToString();
                FilmesEstudioText.Text = record["estudio"].ToString();
            }
        }

        private void ProximoButton_Click(object sender, EventArgs e)
        {
            var nextRecord = FilmesController.ProcuraFilmeProximo(currentId);

            if (nextRecord != null)
            {
                PreencheDados(nextRecord);
            }
            else
            {
                MessageBox.Show("Último registro alcançado.");
            }
        }

        private void AnteriorButton_Click(object sender, EventArgs e)
        {
            var record = FilmesController.ProcuraFilmeAnterior(currentId);

            if (record != null)
            {
                PreencheDados(record);
            }
            else
            {
                MessageBox.Show("Primeiro registro alcançado.");
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            EditarButton.Text = "Editando";

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

            var resposta = MessageBox.Show("Atualizar as informações sobre o filme " + filmes.Titulo + " ?", "Filmes - Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {

                //FilmesController.AtualizaFilme(filmes);
            }
        }

        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        private void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
            }
        }
    }
}