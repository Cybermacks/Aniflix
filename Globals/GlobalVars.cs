using Aniflix.Factory;

namespace Aniflix.Globals
{
    public static class GlobalVars
    {
        public static readonly DatabaseConnection _conn = DatabaseConnection.Instance;
        public static int _currentId = 0;
        public static bool _editando = false;
        public static string _api_key = "1dcbf681735d3e7454953f5b7c22b6dc";


        public static string API_KEY
        {

            get { return API_KEY; }
            private set { API_KEY = value; }
        }

        public static bool Editando
        {
            get { return _editando; }
            set { _editando = value; }
        }


    }
}
