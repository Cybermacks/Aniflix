
using System.Runtime.InteropServices;
using DeepL;
using TMDbLib.Client;

namespace Aniflix.Globals
{
    public static class GlobFunctions
    {
        [LibraryImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [LibraryImport("uxtheme.dll", EntryPoint = "#135", SetLastError = true)]
        public static extern int SetPreferredAppMode(int mode);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        private static bool darkModeEnabled = true;
        private static Button? toggleButton;
        private static Label? titleLabel;
        private static TextBox? inputBox;
        private static ComboBox? themeSelector;
        private static Form? form;

        public static bool IsWindows10OrGreater(int build = -1)
        {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }

        public static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                int attribute = IsWindows10OrGreater(18985) ? DWMWA_USE_IMMERSIVE_DARK_MODE : DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                int useDark = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, attribute, ref useDark, sizeof(int)) == 0;
            }
            return false;
        }

        public static void EnableDarkModeForMenus()
        {
            if (IsWindows10OrGreater(22000))
            {
                SetPreferredAppMode(1);
            }
        }

        public static void ApplyTheme(int themeIndex)
        {
            if (themeIndex == 0)
            {
                form!.BackColor = Color.FromArgb(30, 30, 30);
                toggleButton!.BackColor = Color.FromArgb(50, 50, 50);
                inputBox!.BackColor = Color.FromArgb(50, 50, 50);
                inputBox.ForeColor = Color.White;
            }
            else if (themeIndex == 1)
            {
                form!.BackColor = Color.FromArgb(60, 60, 60);
                toggleButton!.BackColor = Color.FromArgb(80, 80, 80);
                inputBox!.BackColor = Color.FromArgb(80, 80, 80);
                inputBox.ForeColor = Color.White;
            }
            else if (themeIndex == 2)
            {
                form!.BackColor = Color.White;
                toggleButton!.BackColor = Color.LightGray;
                inputBox!.BackColor = Color.White;
                inputBox.ForeColor = Color.Black;
            }

            titleLabel!.ForeColor = (themeIndex == 2) ? Color.Black : Color.White;
            toggleButton!.ForeColor = (themeIndex == 2) ? Color.Black : Color.White;
        }


        public static TMDbClient MovieDatabase()
        {
            var client = new TMDbClient(GlobalVars.TMDB_KEY)
            {
                DefaultLanguage = "pt-BR",
                DefaultCountry = "BR",
            };
            return client;
        }

        public static DeepLClient DeepTranslate()
        {
            var client = new DeepLClient(GlobalVars.DEEPL_KEY);
            return client;
        }
    }
}