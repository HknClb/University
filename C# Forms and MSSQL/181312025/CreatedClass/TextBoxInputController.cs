using System;
using System.Windows.Forms;

namespace _181312025.CreatedClass
{
    static class TextBoxInputController
    {
        public static bool IsNull(TextBox txt, ErrorProvider errorProvider, string hintText = "")
        {
            if (txt.Text.Trim().Equals(string.Empty) || txt.Text.Equals(hintText))
            {
                errorProvider.SetError(txt, "Boş Geçilmez!");
                return true;
            }
            return false;
        }

        public static bool CheckSpace(TextBox txt, ErrorProvider errorProvider, string hintText = "")
        {
            if (!txt.Text.Equals(hintText) && txt.Text.Trim().Contains(Convert.ToString((char)32)))
            {
                errorProvider.SetError(txt, "Girişte Boşluk Yer Almaz!");
                return true;
            }
            return false;
        }
    }
}
