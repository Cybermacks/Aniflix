using System.Data;
using Aniflix.Models;
using MySqlConnector;
using Aniflix.Factory;
using Aniflix.Globals;

namespace Aniflix.Controllers
{
    public static class AnimesController
    {

        public static void Registrar(Animes animes)
        {
            var serie = GlobalVars._conn.SelectData("animes", "codigo = @codigo", new MySqlParameter("@codigo", animes.Codigo));

            if (serie.Rows.Count > 0)
            {
                MessageBox.Show(animes.Titulo + " já está cadastrado!", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int rowsAffected = GlobalVars._conn.InsertData("animes",
                    new MySqlParameter("@codigo", animes.Codigo),
                    new MySqlParameter("@titulo", animes.Titulo),
                    new MySqlParameter("@audio", animes.Audio),
                    new MySqlParameter("@sinopse", animes.Sinopse),
                    new MySqlParameter("@titulo_original", animes.TituloOriginal),
                    new MySqlParameter("@data_lancamento", animes.DataLancamento),
                    new MySqlParameter("@titulo_alternativo", animes.TituloAlternativo),
                    new MySqlParameter("@pais_origem", animes.PaisOrigem),
                    new MySqlParameter("@idioma_original", animes.IdiomaOriginal),
                    new MySqlParameter("@anime", animes.Serie),
                    new MySqlParameter("@autores", animes.Autores),
                    new MySqlParameter("@genero", animes.Genero),
                    new MySqlParameter("@tags", animes.Tags),
                    new MySqlParameter("@diretor", animes.Diretor),
                    new MySqlParameter("@estrelas", animes.Estrelas),
                    new MySqlParameter("@estudio", animes.Estudio)
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show(animes.Titulo + " cadastrada com sucesso!", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public static DataRow? MostraPrimeiro()
        {
            return GlobalVars._conn.GetFirstRecord("animes");
        }
        public static DataRow? MoveAnterior(int id)
        {
            return GlobalVars._conn.GetPreviousRecord("animes", id);
        }
        public static DataRow? MoveProximo(int id)
        {
            return GlobalVars._conn.GetNextRecord("animes", id);
        }

        public static void AtualizaDados(Animes animes)
        {
            int rowsAffected = GlobalVars._conn.UpdateData("animes", "codigo = @codigo",
                new MySqlParameter("@codigo", animes.Codigo),
                new MySqlParameter("@titulo", animes.Titulo),
                new MySqlParameter("@audio", animes.Audio),
                new MySqlParameter("@sinopse", animes.Sinopse),
                new MySqlParameter("@titulo_original", animes.TituloOriginal),
                new MySqlParameter("@data_lancamento", animes.DataLancamento),
                new MySqlParameter("@titulo_alternativo", animes.TituloAlternativo),
                new MySqlParameter("@pais_origem", animes.PaisOrigem),
                new MySqlParameter("@idioma_original", animes.IdiomaOriginal),
                new MySqlParameter("@serie", animes.Anime),
                new MySqlParameter("@autores", animes.Autores),
                new MySqlParameter("@obra_original", animes.PaisOrigem),
                new MySqlParameter("@genero", animes.Genero),
                new MySqlParameter("@tags", animes.Tags),
                new MySqlParameter("@diretor", animes.Diretor),
                new MySqlParameter("@estrelas", animes.Estrelas),
                new MySqlParameter("@estudio", animes.Estudio)
            );

            if (rowsAffected > 0)
            {
                MessageBox.Show("Anime atualizada com sucesso!", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o registro.", "Animes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}