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
}

