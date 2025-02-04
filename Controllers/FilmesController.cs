using System.Data;
using Aniflix.Models;
using MySqlConnector;
using Aniflix.Factory;

namespace Aniflix.Controllers
{
    public static class FilmesController
    {
        public static readonly DatabaseConnection _conn = DatabaseConnection.Instance;

        public static void InsereNovoFilme(Filmes filmes)
        {
            var filme = _conn.SelectData("filmes", "codigo = @codigo", new MySqlParameter("@codigo", filmes.Codigo));

            if (filme.Rows.Count > 0)
            {
                MessageBox.Show("Filme " + filmes.Titulo + " já está cadastrado!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int rowsAffected = _conn.InsertData("INSERT INTO filmes (codigo, titulo, audio, sinopse, titulo_original, data_lancamento, titulo_alternativo, franquia, genero, tags, diretor, mcu, estrelas, estudio) VALUES (@Codigo, @Titulo, @Audio, @Sinopse, @TituloOriginal, @DataLancamento, @TituloAlternativo, @Franquia, @Genero, @Tags, @Diretor, @MCU, @Estrelas, @Estudio)",
                    new MySqlParameter("@Codigo", filmes.Codigo),
                    new MySqlParameter("@Titulo", filmes.Titulo),
                    new MySqlParameter("@Audio", filmes.Audio),
                    new MySqlParameter("@Sinopse", filmes.Sinopse),
                    new MySqlParameter("@TituloOriginal", filmes.TituloOriginal),
                    new MySqlParameter("@DataLancamento", filmes.DataLancamento),
                    new MySqlParameter("@TituloAlternativo", filmes.TituloAlternativo),
                    new MySqlParameter("@Franquia", filmes.Franquia),
                    new MySqlParameter("@Genero", filmes.Genero),
                    new MySqlParameter("@Tags", filmes.Tags),
                    new MySqlParameter("@Diretor", filmes.Diretor),
                    new MySqlParameter("@MCU", filmes.MCU),
                    new MySqlParameter("@Estrelas", filmes.Estrelas),
                    new MySqlParameter("@Estudio", filmes.Estudio)
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Filme " + filmes.Titulo + " cadastrado com sucesso!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public static DataRow? BuscaPrimeiroFilme()
        {
            return _conn.GetFirstRecord("filmes");
        }
    }
}