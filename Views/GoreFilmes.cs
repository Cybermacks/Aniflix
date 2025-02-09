using Aniflix.Globals;

namespace Aniflix.Views
{
    public partial class GoreFilmes : Form
    {
        public GoreFilmes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = GlobFunctions.MovieDatabase();
            textBox1.Text = client.GetMovieAsync(98).Result.Title;
        }
    }
}
