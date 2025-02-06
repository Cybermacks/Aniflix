using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using Aniflix.Globals;
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
            CarregarFilme();
            Functions.DoReadOnly(this);
            TituloAlternativoText.Text = "--";
            FaseMCUText.Text = "--";
            ObraOriginalText.Text = "--";
            AutoresText.Text = "--";
            CriadoresText.Text = "--";
        }
    }
}
