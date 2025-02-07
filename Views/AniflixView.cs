using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using Aniflix.Custom;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aniflix.Views
{
    public partial class AniflixView : Form
    {
        private RoundedButton? currentBtn;
        private Panel? leftBorderBtn;

        public AniflixView()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel1.Controls.Add(leftBorderBtn);
        }
    }
}
