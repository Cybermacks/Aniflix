using System.Data;
using Aniflix.Models;
using MySqlConnector;
using Aniflix.Factory;

namespace Aniflix.Controllers
{
    public static class SeriesController
    {
        public static readonly DatabaseConnection _conn = DatabaseConnection.Instance;

        public static void InsereNovoFilme(Series series)
        {
            var filme = _conn.SelectData("filmes", "codigo = @codigo", new MySqlParameter("@codigo", series.Codigo));

            if (filme.Rows.Count > 0)
            {
                MessageBox.Show(series.Titulo + " já está cadastrado!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int rowsAffected = _conn.InsertData("series",
                    new MySqlParameter("@codigo", series.Codigo),
                    new MySqlParameter("@titulo", series.Titulo),
                    new MySqlParameter("@audio", series.Audio),
                    new MySqlParameter("@sinopse", series.Sinopse),
                    new MySqlParameter("@titulo_original", series.TituloOriginal),
                    new MySqlParameter("@data_lancamento", series.DataLancamento),
                    new MySqlParameter("@titulo_alternativo", series.TituloAlternativo),
                    new MySqlParameter("@pais_origem", series.PaisOrigem),
                      new MySqlParameter("@idioma_original", series.PaisOrigem),
                        new MySqlParameter("@autores", series.PaisOrigem),
                          new MySqlParameter("@criadores", series.PaisOrigem),
                          new MySqlParameter("@pais_origem", series.PaisOrigem),


                    new MySqlParameter("@genero", series.Genero),

                    new MySqlParameter("@tags", series.Tags),
                    new MySqlParameter("@diretor", series.Diretor),
                    new MySqlParameter("@mcu", series.MCU),

                    new MySqlParameter("@estrelas", series.Estrelas),
                    new MySqlParameter("@estudio", series.Estudio),
                    new MySqlParameter(


                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show(series.Titulo + " cadastrado com sucesso!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int rowsAffected = _conn.UpdateData("filmes", "codigo = @codigo",
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
                MessageBox.Show("Registro atualizado com sucesso!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o registro.", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    }

}
