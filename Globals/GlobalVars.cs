using Aniflix.Factory;

namespace Aniflix.Globals
{
    public static class GlobalVars
    {
        public static readonly DatabaseConnection _conn = DatabaseConnection.Instance;

        private static int GlobalVars.currentId = 0;
        private static bool editando = false;


    }
}
