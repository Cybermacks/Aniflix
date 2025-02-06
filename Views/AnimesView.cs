﻿using DeepL;
using System.Data;
using Aniflix.Globals;
using Aniflix.Services;
using Aniflix.Extensions;
using Aniflix.Controllers;
using System.Globalization;

namespace Aniflix.Views
{
    public partial class AnimesView : Form
    {
        public AnimesView()
        {
            InitializeComponent();
        }

        private void AnimesView_Load(object sender, EventArgs e)
        {
            UpdateData();
            LoadRecord();
            Functions.DoReadOnly(this);
            TituloAlternativoText.Text = "--";
            AutoresText.Text = "--";
        }

        private async Task GivenData()
        {
            try
            {

                var client = new TMDbLib.Client.TMDbClient(GlobalVars.API_KEY)
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
                        FranquiaText.Text = "#" + StringExtensions.StripPunctuation(given.Name.Replace(" ", ""));
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
                        TagsText.Text = $"#Anime #Anime{ano}";
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
                        MessageBox.Show("Nenhum anime foi encontrado.", "Animes - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CodigoText.Focus();
                    });
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
                    MessageBox.Show($"Erro ao buscar o anime: {ex.Message}", "Animes - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }
        private void UpdateData()
        {
            var model = new AnimesServices(
                titulo: TituloText.Text,
                audio: AudioBox.SelectedItem?.ToString() ?? string.Empty,
                sinopse: SinopseText.Text,
                tituloOriginal: TituloOriginalText.Text,
                dataLancamento: DataLancamentoText.Text,
                tituloAlternativo: TituloAlternativoText.Text,
                franquia: FranquiaText.Text,
                paisOrigem: PaisOrigemText.Text,
                idiomaOriginal: IdiomaOriginalText.Text,
                anime: AnimeText.Text,
                autores: AutoresText.Text,
                genero: GeneroText.Text,
                tags: TagsText.Text,
                diretor: DiretorText.Text,
                estrelas: EstrelasText.Text,
                estudio: EstudioText.Text
            );
            ResumoText.Text = model.GetFormattedText();
        }

        private void PreencheDados(DataRow record)
        {
            if (record != null)
            {
                GlobalVars.currentId = Convert.ToInt32(record["id"]);
                CodigoText.Text = record["codigo"].ToString();
                TituloText.Text = record["titulo"].ToString();
                AudioBox.SelectedItem = record["audio"].ToString();
                SinopseText.Text = record["sinopse"].ToString();
                TituloOriginalText.Text = record["titulo_original"].ToString();
                DataLancamentoText.Text = record["data_lancamento"].ToString();
                TituloAlternativoText.Text = record["titulo_alternativo"].ToString();
                PaisOrigemText.Text = record["pais_origem"].ToString();
                IdiomaOriginalText.Text = record["idioma_original"].ToString();
                FranquiaText.Text = record["serie"].ToString();
                AutoresText.Text = record["autores"].ToString();
                GeneroText.Text = record["genero"].ToString();
                TagsText.Text = record["tags"].ToString();
                DiretorText.Text = record["diretor"].ToString();
                EstrelasText.Text = record["estrelas"].ToString();
                EstudioText.Text = record["estudio"].ToString();
            }
        }
        private void Next()
        {
            var nextRecord = AnimesController.MoveProximo(GlobalVars.currentId);

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
            var previousRecord = AnimesController.MoveAnterior(GlobalVars.currentId);

            if (previousRecord != null)
            {
                PreencheDados(previousRecord);
            }
            else
            {
                MessageBox.Show("Você chegou ao primeiro registro.", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadRecord()
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
                FranquiaText.Text = serie["serie"].ToString();
                AutoresText.Text = serie["autores"].ToString();
                GeneroText.Text = serie["genero"].ToString();
                TagsText.Text = serie["tags"].ToString();
                DiretorText.Text = serie["diretor"].ToString();
                EstrelasText.Text = serie["estrelas"].ToString();
                EstudioText.Text = serie["estudio"].ToString();
            }
        }

        private async void CodigoText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodigoText.Text))
            {
                MessageBox.Show("Por favor, insira o código do filme.", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CodigoText.Focus();
            }
            else
            {
                await GivenData();
            }
        }
    }
}
