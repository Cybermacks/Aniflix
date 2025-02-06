using System.Data;
using Aniflix.Models;
using MySqlConnector;
using Aniflix.Globals;

namespace Aniflix.Controllers
{
    public static class SeriesController
    {

        public static void Registrar(Series series)
        {
            var serie = GlobalVars._conn.SelectData("series", "codigo = @codigo", new MySqlParameter("@codigo", series.Codigo));

            if (serie.Rows.Count > 0)
            {
                MessageBox.Show(series.Titulo + " já está cadastrada!", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int rowsAffected = GlobalVars._conn.InsertData("series",
                    new MySqlParameter("@codigo", series.Codigo),
                    new MySqlParameter("@titulo", series.Titulo),
                    new MySqlParameter("@audio", series.Audio),
                    new MySqlParameter("@sinopse", series.Sinopse),
                    new MySqlParameter("@titulo_original", series.TituloOriginal),
                    new MySqlParameter("@data_lancamento", series.DataLancamento),
                    new MySqlParameter("@titulo_alternativo", series.TituloAlternativo),
                    new MySqlParameter("@pais_origem", series.PaisOrigem),
                    new MySqlParameter("@idioma_original", series.IdiomaOriginal),
                    new MySqlParameter("@serie", series.Serie),
                    new MySqlParameter("@autores", series.Autores),
                    new MySqlParameter("@criadores", series.Criadores),
                    new MySqlParameter("@obra_original", series.PaisOrigem),
                    new MySqlParameter("@genero", series.Genero),
                    new MySqlParameter("@tags", series.Tags),
                    new MySqlParameter("@diretor", series.Diretor),
                    new MySqlParameter("@mcu", series.MCU),
                    new MySqlParameter("@estrelas", series.Estrelas),
                    new MySqlParameter("@estudio", series.Estudio)
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show(series.Titulo + " cadastrada com sucesso!", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public static DataRow? MostraPrimeiro()
        {
            return GlobalVars._conn.GetFirstRecord("series");
        }
        public static DataRow? MoveAnterior(int id)
        {
            return GlobalVars._conn.GetPreviousRecord("series", id);
        }
        public static DataRow? MoveProximo(int id)
        {
            return GlobalVars._conn.GetNextRecord("series", id);
        }

        public static void AtualizaDados(Series series)
        {
            int rowsAffected = GlobalVars._conn.UpdateData("series", "codigo = @codigo",
                new MySqlParameter("@codigo", series.Codigo),
                new MySqlParameter("@titulo", series.Titulo),
                new MySqlParameter("@audio", series.Audio),
                new MySqlParameter("@sinopse", series.Sinopse),
                new MySqlParameter("@titulo_original", series.TituloOriginal),
                new MySqlParameter("@data_lancamento", series.DataLancamento),
                new MySqlParameter("@titulo_alternativo", series.TituloAlternativo),
                new MySqlParameter("@pais_origem", series.PaisOrigem),
                new MySqlParameter("@idioma_original", series.IdiomaOriginal),
                new MySqlParameter("@serie", series.Serie),
                new MySqlParameter("@autores", series.Autores),
                new MySqlParameter("@criadores", series.Criadores),
                new MySqlParameter("@obra_original", series.PaisOrigem),
                new MySqlParameter("@genero", series.Genero),
                new MySqlParameter("@tags", series.Tags),
                new MySqlParameter("@diretor", series.Diretor),
                new MySqlParameter("@mcu", series.MCU),
                new MySqlParameter("@estrelas", series.Estrelas),
                new MySqlParameter("@estudio", series.Estudio)
            );

            if (rowsAffected > 0)
            {
                MessageBox.Show("Série atualizada com sucesso!", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o registro.", "Séries", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}