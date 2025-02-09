using System.Runtime.InteropServices;

namespace Aniflix.Globals
{
    public static class Functions
    {
        public static void DoReadOnly(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Controls != null && c.Controls.Count > 0)
                {
                    DoReadOnly(c);
                }
                else if (c is TextBox box)
                {
                    box.ReadOnly = true;
                }
                else if (c is ComboBox comboBox)
                {
                    comboBox.Enabled = false;
                }
                else if (c is MaskedTextBox maskTextBox)
                {
                    maskTextBox.ReadOnly = true;
                }
            }
        }

        public static void UndoReadOnly(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Controls != null && c.Controls.Count > 0)
                {
                    UndoReadOnly(c);
                }
                else if (c is TextBox box)
                {
                    box.ReadOnly = false;
                }
                else if (c is ComboBox comboBox)
                {
                    comboBox.Enabled = true;
                }
                else if (c is MaskedTextBox maskTextBox)
                {
                    maskTextBox.ReadOnly = false;
                }
            }
        }
    }


        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]


        [LibraryImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        [LibraryImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(nint hWnd, int wMsg, int wParam, int lParam);
        private extern static void SendMessage(nint hWnd, int wMsg, int wParam, int lParam);


        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("uxtheme.dll", EntryPoint = "#135", SetLastError = true)]
        private static extern int SetPreferredAppMode(int mode);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        private const int DWMWA_SYSTEMBACKDROP_TYPE = 38;
        private const int DWMSBT_MAINWINDOW = 2;
        private const int DWMSBT_TRANSIENTWINDOW = 3;

        private static bool IsWindows10OrGreater(int build = -1)
        {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }

        private static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                int attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                if (IsWindows10OrGreater(18985))
                {
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                }

                int useDark = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, attribute, ref useDark, sizeof(int)) == 0;
            }

            return false;
        }

        private static void EnableDarkModeForMenus()
        {
            if (IsWindows10OrGreater(22000))
            {
                SetPreferredAppMode(1);
            }
        }

    }
