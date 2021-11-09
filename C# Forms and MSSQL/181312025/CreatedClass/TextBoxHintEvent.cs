using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _181312025.CreatedClass
{
    static class TextBoxHintEvent
    {
        private static List<string[]> TextBoxInformation = new List<string[]>();
        public static void Hint(TextBox txt, string text, bool PasswordChar = false)
        {
            string[] information = new string[3];
            information[0] = txt.Name;
            information[1] = text;
            information[2] = PasswordChar.ToString();
            TextBoxInformation.Add(information);
            txt.Click += textbox_Click;
            txt.KeyPress += textbox_KeyPress;
            txt.Leave += textbox_Leave;
            txt.Text = text;
            txt.ForeColor = Color.Gray;
        }

        private static void textbox_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            string textboxText = default;
            foreach (string[] item in TextBoxInformation)
            {
                if (item[0] == txt.Name)
                {
                    textboxText = item[1];
                    break;
                }
            }
            if (txt.Text.Contains(textboxText))
                txt.SelectionStart = 0;
        }

        private static void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            string textboxText = default;
            bool textboxPasswordChar = default;
            foreach (string[] item in TextBoxInformation)
            {
                if (item[0] == txt.Name)
                {
                    textboxText = item[1];
                    textboxPasswordChar = bool.Parse(item[2]);
                    break;
                }
            }
            if (txt.Text.Contains(textboxText))
            {
                txt.Clear();
                if (textboxPasswordChar)
                {
                    txt.UseSystemPasswordChar = true;
                    if (Char.IsLetterOrDigit(e.KeyChar))
                        txt.Text = e.KeyChar.ToString();
                }
                txt.ForeColor = Color.Black;
                txt.SelectionStart = txt.SelectionLength + 1;
            }
            else if (txt.Text.Equals(string.Empty) && char.IsControl(e.KeyChar))
            {
                txt.Text = textboxText;
                txt.ForeColor = Color.Gray;
                txt.UseSystemPasswordChar = false;
                txt.SelectionStart = 0;
            }
        }

        private static void textbox_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text.Equals(string.Empty))
            {
                string textboxText = default;
                foreach (string[] item in TextBoxInformation)
                {
                    if (item[0] == txt.Name)
                    {
                        textboxText = item[1];
                        break;
                    }
                }
                txt.Text = textboxText;
                txt.ForeColor = Color.Gray;
                txt.UseSystemPasswordChar = false;
            }
        }
    }
}
