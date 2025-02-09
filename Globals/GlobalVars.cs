﻿using Aniflix.Factory;

namespace Aniflix.Globals
{
    public static class GlobalVars
    {
        private static readonly DatabaseConnection _conn = DatabaseConnection.Instance;
        private static int _currentId = 0;
        private static bool _editando = false;
        private static string _api_key = "1dcbf681735d3e7454953f5b7c22b6dc";


        public static string API_KEY
        {

            get { return API_KEY; }
            private set { API_KEY = value; }
        }

        public static string ApiKey => _api_key;

        public static bool Editando
        {
            get { return _editando; }
            set { _editando = value; }
        }

        public static int CurrentId
        {
            get { return _currentId; }
            set { _currentId = value; }
        }


    }
}
