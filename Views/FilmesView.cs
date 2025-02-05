using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using Aniflix.Models;
using Aniflix.Globals;
using Aniflix.Services;
using Aniflix.Extensions;
using Aniflix.Controllers;
using System.Globalization;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aniflix.Views
{
    public partial class FilmesView : Form
    {
        private int currentId = 0;
        private bool editando = false;

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

                var movieTask = client.GetMovieAsync(CodigoText.Text);
                var creditsTask = client.GetMovieCreditsAsync(Convert.ToInt32(CodigoText.Text));

                await Task.WhenAll(movieTask, creditsTask);

                var movie = movieTask.Result;
                var credits = creditsTask.Result;

                if (movie != null)
                {
                    Invoke((Action)(() =>
                    {
                        TituloText.Text = movie.Title;
                        SinopseText.Text = movie.Overview;
                        TituloOriginalText.Text = movie.OriginalTitle;
                        DataLancamentoText.Text = movie.ReleaseDate?.ToString("dd/MM/yyyy");
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
                        TagsText.Text = $"#Filme #Filme{ano}";
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

                        GeneroText.Text = string.Join(" ", hashtags);
                    }
                }
                else
                {
                    Invoke(() =>
                    {
                        MessageBox.Show("Nenhum filme encontrado.", "Filmes - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CodigoText.Focus();
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
                        DiretorText.Text = string.Join(" ", StringExtensions.ClearLists(directors));
                    }));
                }
                else
                {
                    Invoke((Action)(() =>
                    {
                        DiretorText.Text = string.Empty;
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

                if (movie != null && movie.ProductionCompanies != null)
                {

                    var studios = movie!
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
                    MessageBox.Show($"Erro ao buscar o filme: {ex.Message}", "Filmes - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

        private void UpdateData()
        {
            var model = new FilmesServices(
                titulo: TituloText.Text,
                audio: AudioBox.SelectedItem?.ToString() ?? string.Empty,
                sinopse: SinopseText.Text,
                tituloOriginal: TituloOriginalText.Text,
                dataLancamento: DataLancamentoText.Text,
                tituloAlternativo: TituloAlternativoText.Text,
                franquia: FranquiaText.Text,
                genero: GeneroText.Text,
                tags: TagsText.Text,
                diretor: DiretorText.Text,
                  mcu: FaseMCUText.Text,
                estrelas: EstrelasText.Text,
                estudio: EstudioText.Text

                );
            ResumoText.Text = model.GetFormattedText();
        }

        private void FilmesView_Load(object sender, EventArgs e)
        {
            UpdateData();
            CarregarFilme();
            Functions.DoReadOnly(this);
            TituloAlternativoText.Text = "--";
            FaseMCUText.Text = "--";
            FranquiaText.Text = "--";

        }

        private void CarregarFilme()
        {
            var filme = FilmesController.BuscaPrimeiroFilme();

            if (filme != null)
            {
                CodigoText.Text = filme["codigo"].ToString();
                TituloText.Text = filme["titulo"].ToString();
                AudioBox.SelectedItem = filme["audio"].ToString();
                SinopseText.Text = filme["sinopse"].ToString();
                TituloOriginalText.Text = filme["titulo_original"].ToString();
                DataLancamentoText.Text = filme["data_lancamento"].ToString();
                TituloAlternativoText.Text = filme["titulo_alternativo"].ToString();
                FranquiaText.Text = filme["franquia"].ToString();
                GeneroText.Text = filme["genero"].ToString();
                TagsText.Text = filme["tags"].ToString();
                DiretorText.Text = filme["diretor"].ToString();
                FaseMCUText.Text = filme["mcu"].ToString();
                EstrelasText.Text = filme["estrelas"].ToString();
                EstudioText.Text = filme["estudio"].ToString();
            }
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
                FranquiaText.Text = record["franquia"].ToString();
                GeneroText.Text = record["genero"].ToString();
                TagsText.Text = record["tags"].ToString();
                DiretorText.Text = record["diretor"].ToString();
                FaseMCUText.Text = record["mcu"].ToString();
                EstrelasText.Text = record["estrelas"].ToString();
                EstudioText.Text = record["estudio"].ToString();
            }
        }

        private void CodigoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodigoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void CodigoText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodigoText.Text))
            {
                MessageBox.Show("Por favor, insira o código do filme.");
                CodigoText.Focus();
            }
            else
            {
                await GetFilmesAsync();
            }
        }
        private void TituloText_TextChanged(object sender, EventArgs e)
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

        private void TagsText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FranquiaText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void GeneroText_TextChanged(object sender, EventArgs e)
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

        private void FaseMCUText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void CopiarButton_Click(object sender, EventArgs e)
        {
            ResumoText.SelectAll();
            ResumoText.Copy();
        }

        private void InserirButton_Click(object sender, EventArgs e)
        {
            var filmes = new Filmes
            {
                Codigo = CodigoText.Text,
                Titulo = TituloText.Text,
                Audio = AudioBox.SelectedItem?.ToString() ?? string.Empty,
                Sinopse = SinopseText.Text,
                TituloOriginal = TituloOriginalText.Text,
                DataLancamento = DataLancamentoText.Text,
                TituloAlternativo = TituloAlternativoText.Text,
                Franquia = FranquiaText.Text,
                Genero = GeneroText.Text,
                Tags = TagsText.Text,
                Diretor = DiretorText.Text,
                MCU = FaseMCUText.Text,
                Estrelas = EstrelasText.Text,
                Estudio = EstudioText.Text
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

        private void EditarButton_Click(object sender, EventArgs e)
        {
            var filmes = new Filmes
            {
                Codigo = CodigoText.Text,
                Titulo = TituloText.Text,
                Audio = AudioBox.SelectedItem?.ToString() ?? string.Empty,
                Sinopse = SinopseText.Text,
                TituloOriginal = TituloOriginalText.Text,
                DataLancamento = DataLancamentoText.Text,
                TituloAlternativo = TituloAlternativoText.Text,
                Franquia = FranquiaText.Text,
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
                var cancelar = MessageBox.Show($"Cancelar a edição do filme {filmes.Titulo} ?", "Filmes - Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                var atualizar = MessageBox.Show($"Atualizar as informações sobre o filme {filmes.Titulo} ?", "Filmes - Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (atualizar == DialogResult.Yes)
                {
                    FilmesController.AtualizaFilme(filmes);
                }

                Functions.DoReadOnly(this);
                EditarButton.Text = "Editar";
                editando = false;
            }
        }

        private void AnteriorButton_Click(object sender, EventArgs e)
        {
            var previousRecord = FilmesController.ProcuraFilmeAnterior(currentId);

            if (previousRecord != null)
            {
                PreencheDados(previousRecord);
            }
            else
            {
                MessageBox.Show("Você chegou ao primeiro registro.", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Você chegou ao primeiro registro.", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}