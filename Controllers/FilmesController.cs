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
                MessageBox.Show(filmes.Titulo + " já está cadastrado!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int rowsAffected = _conn.InsertData("filmes",
                    new MySqlParameter("@codigo", filmes.Codigo),
                    new MySqlParameter("@titulo", filmes.Titulo),
                    new MySqlParameter("@audio", filmes.Audio),
                    new MySqlParameter("@sinopse", filmes.Sinopse),
                    new MySqlParameter("@titulo_original", filmes.TituloOriginal),
                    new MySqlParameter("@data_lancamento", filmes.DataLancamento),
                    new MySqlParameter("@titulo_alternativo", filmes.TituloAlternativo),
                    new MySqlParameter("@franquia", filmes.Franquia),
                    new MySqlParameter("@genero", filmes.Genero),
                    new MySqlParameter("@tags", filmes.Tags),
                    new MySqlParameter("@diretor", filmes.Diretor),
                    new MySqlParameter("@mcu", filmes.MCU),
                    new MySqlParameter("@estrelas", filmes.Estrelas),
                    new MySqlParameter("@estudio", filmes.Estudio)
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show(filmes.Titulo + " cadastrado com sucesso!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public static DataRow? BuscaPrimeiroFilme()
        {
            return _conn.GetFirstRecord("filmes");
        }
        public static DataRow? ProcuraFilmeAnterior(int id)
        {
            return _conn.GetPreviousRecord("filmes", id);
        }
        public static DataRow? ProcuraFilmeProximo(int id)
        {
            return _conn.GetNextRecord("filmes", id);
        }

        public static void AtualizaFilme(Filmes filmes)
        {
            _conn.UpdateData("filmes",
                new MySqlParameter("@codigo", filmes.Codigo),
                new MySqlParameter("@titulo", filmes.Titulo),
                new MySqlParameter("@audio", filmes.Audio),
                new MySqlParameter("@sinopse", filmes.Sinopse),
                new MySqlParameter("@titulo_original", filmes.TituloOriginal),
                new MySqlParameter("@data_lancamento", filmes.DataLancamento),
                new MySqlParameter("@titulo_alternativo", filmes.TituloAlternativo),
                new MySqlParameter("@franquia", filmes.Franquia),
                new MySqlParameter("@genero", filmes.Genero),
                new MySqlParameter("@tags", filmes.Tags),
                new MySqlParameter("@diretor", filmes.Diretor),
                new MySqlParameter("@mcu", filmes.MCU),
                new MySqlParameter("@estrelas", filmes.Estrelas),
                new MySqlParameter("@estudio", filmes.Estudio)
            );
        }
    }
}