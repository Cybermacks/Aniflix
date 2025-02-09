using Aniflix.Factory;

namespace Aniflix.Globals
{
    public static class GlobVars
    {
        public static readonly DatabaseConnection _conn = DatabaseConnection.Instance;
        public static int currentId = 0;
        public static bool editando = false;
        public static string TMDB_KEY = "1dcbf681735d3e7454953f5b7c22b6dc";
        public static string DEEPL_KEY = "7feb3eb8-de95-4312-843c-1064aecdab8b:fx";


    }
}