using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //шифрование

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string source_text = tb.Text;
            int key = int.Parse(tbS.Text);

            string cyrillic_s = "абвгдеёжзийклмнопрстуфхцчшщьъэюя";
            string cyrillic_b = cyrillic_s.ToUpper();
            string latin_s = "abcdefghijklmnopqrstuvwxyz";
            string latin_b = latin_s.ToUpper();

            string result_text = "";

            foreach (char s in source_text)
            {
                if (Char.IsUpper(s))
                {
                    if (cyrillic_b.IndexOf(s) > -1)
                    {
                        int letterNumber = cyrillic_b.IndexOf(s);

                        int newLetterNumber = (letterNumber + key + cyrillic_b.Length) % cyrillic_b.Length;

                        result_text += cyrillic_b[newLetterNumber];
                    }
                    else if (latin_b.IndexOf(s) > -1)
                    {
                        int letterNumber = latin_b.IndexOf(s);

                        int newLetterNumber = (letterNumber + key + latin_b.Length) % latin_b.Length;

                        result_text += latin_b[newLetterNumber];
                    }
                    else
                    {
                        result_text += s;
                    }
                }
                else
                {
                    if (cyrillic_s.IndexOf(s) > -1)
                    {
                        int letterNumber = cyrillic_s.IndexOf(s);

                        int newLetterNumber = (letterNumber + key + cyrillic_s.Length) % cyrillic_s.Length;

                        result_text += cyrillic_s[newLetterNumber];
                    }
                    else if (latin_s.IndexOf(s) > -1)
                    {
                        int letterNumber = latin_s.IndexOf(s);

                        int newLetterNumber = (letterNumber + key + latin_s.Length) % latin_s.Length;

                        result_text += latin_s[newLetterNumber];
                    }
                    else
                    {
                        result_text += s;
                    }

                }
            }

            tbRes1.Text = result_text;
        }

        //дешифрование

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string source_text = tb.Text;
            int key = int.Parse(tbS.Text);

            string cyrillic_s = "абвгдеёжзийклмнопрстуфхцчшщьъэюя";
            string cyrillic_b = cyrillic_s.ToUpper();
            string latin_s = "abcdefghijklmnopqrstuvwxyz";
            string latin_b = latin_s.ToUpper();

            string result_text = "";

            foreach (char s in source_text)
            {
                if (Char.IsUpper(s))
                {
                    if (cyrillic_b.IndexOf(s) > -1)
                    {
                        int letterNumber = cyrillic_b.IndexOf(s);

                        int newLetterNumber = (letterNumber - key + cyrillic_b.Length) % cyrillic_b.Length;

                        result_text += cyrillic_b[newLetterNumber];
                    }
                    else if (latin_b.IndexOf(s) > -1)
                    {
                        int letterNumber = latin_b.IndexOf(s);

                        int newLetterNumber = (letterNumber - key + latin_b.Length) % latin_b.Length;

                        result_text += latin_b[newLetterNumber];
                    }
                    else
                    {
                        result_text += s;
                    }
                }
                else
                {
                    if (cyrillic_s.IndexOf(s) > -1)
                    {
                        int letterNumber = cyrillic_s.IndexOf(s);

                        int newLetterNumber = (letterNumber - key + cyrillic_s.Length) % cyrillic_s.Length;

                        result_text += cyrillic_s[newLetterNumber];
                    }
                    else if (latin_s.IndexOf(s) > -1)
                    {
                        int letterNumber = latin_s.IndexOf(s);

                        int newLetterNumber = (letterNumber - key + latin_s.Length) % latin_s.Length;

                        result_text += latin_s[newLetterNumber];
                    }
                    else
                    {
                        result_text += s;
                    }

                }
            }

            tbRes2.Text = result_text;
        }
    }
}

