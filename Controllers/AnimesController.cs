using System;
using System.Linq;
using System.Text;
using Aniflix.Factory;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aniflix.Controllers
{
    public static class AnimesController
    {
        public static readonly DatabaseConnection _conn = DatabaseConnection.Instance;
    }

}
