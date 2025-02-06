using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using Aniflix.Globals;
using Aniflix.Services;
using Aniflix.Controllers;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

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
        | genero: GeneroText.Text,
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
                currentId = Convert.ToInt32(record["id"]);
                CodigoText.Text = record["codigo"].ToString();
                TituloText.Text = record["titulo"].ToString();
                AudioBox.SelectedItem = record["audio"].ToString();
                SinopseText.Text = record["sinopse"].ToString();
                TituloOriginalText.Text = record["titulo_original"].ToString();
                DataLancamentoText.Text = record["data_lancamento"].ToString();
                TituloAlternativoText.Text = record["titulo_alternativo"].ToString();
                PaisOrigemText.Text = record["pais_origem"].ToString();
                IdiomaOriginalText.Text = record["idioma_original"].ToString();
                SerieText.Text = record["serie"].ToString();
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
            var nextRecord = SeriesController.MoveProximo(currentId);

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
            var previousRecord = SeriesController.MoveAnterior(currentId);

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
                SerieText.Text = serie["serie"].ToString();
                AutoresText.Text = serie["autores"].ToString();
                GeneroText.Text = serie["genero"].ToString();
                TagsText.Text = serie["tags"].ToString();
                DiretorText.Text = serie["diretor"].ToString();
                EstrelasText.Text = serie["estrelas"].ToString();
                EstudioText.Text = serie["estudio"].ToString();
            }
        }

    }
}
