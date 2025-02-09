namespace Aniflix.Globals
{
    public class GlobFunctions
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("uxtheme.dll", EntryPoint = "#135", SetLastError = true)]
        private static extern int SetPreferredAppMode(int mode);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        private bool darkModeEnabled = true;
        private Button toggleButton;
        private Label titleLabel;
        private TextBox inputBox;
        private ComboBox themeSelector;

        private static bool IsWindows10OrGreater(int build = -1)
        {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }

        private static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                int attribute = IsWindows10OrGreater(18985) ? DWMWA_USE_IMMERSIVE_DARK_MODE : DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                int useDark = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, attribute, ref useDark, sizeof(int)) == 0;
            }
            return false;
        }

        private static void EnableDarkModeForMenus()
        {
            if (IsWindows10OrGreater(22000))
            {
                SetPreferredAppMode(1); // Ativa tema escuro para menus do sistema (Windows 11)
            }
        }
    }
}
