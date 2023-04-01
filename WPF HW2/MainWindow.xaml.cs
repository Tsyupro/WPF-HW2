using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace WPF_HW2
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
        private void New_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            ofd.FilterIndex = 2;
            ofd.ShowDialog();
            StreamReader reader = File.OpenText(ofd.FileName);
            TextBox.Text = reader.ReadToEnd();
            reader.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files(*.txt) | *.txt";
            sfd.DefaultExt = "txt";
            sfd.ShowDialog();
            SaveFile(sfd.FileName);

        }
        private void SaveFile(string path)
        {
            StreamWriter write = new StreamWriter(path);
            write.Write(TextBox.Text);
            write.Close();
        }

        private void WrapCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (WrapCheckBox.IsChecked == true)
            {
                TextBox.TextWrapping = TextWrapping.Wrap;
            }
            else
            {
                TextBox.TextWrapping = TextWrapping.NoWrap;
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)radiobutton1.IsChecked)
            {
                TextBox.FontSize = 10;
            }
            else if ((bool)radiobutton2.IsChecked)
            {
                TextBox.FontSize = 12;
            }
           else if ((bool)radiobutton3.IsChecked)
            {
                TextBox.FontSize = 14;
            }
           else if ((bool)radiobutton4.IsChecked)
            {
                TextBox.FontSize = 16;
            }
           else if ((bool)radiobutton5.IsChecked)
            {
                TextBox.FontSize = 20;
            }

        }
    }
}
