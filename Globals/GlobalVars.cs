using Aniflix.Factory;

namespace Aniflix.Globals
{
    public static class GlobalVars
    {
        public static readonly DatabaseConnection _conn = DatabaseConnection.Instance;
        public static readonly int currentId = 0;
        private static readonly bool GlobalVars.editando = false;


    }
}
