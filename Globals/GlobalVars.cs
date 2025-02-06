using Aniflix.Factory;

namespace Aniflix.Globals
{
    public static class GlobalVars
    {
        public static readonly DatabaseConnection _conn = DatabaseConnection.Instance;
        public static readonly int currentId = 0;
        private static readonly bool editando = false;
        public static readonly string API_KEY = "1dcbf681735d3e7454953f5b7c22b6dc";


    }
}
