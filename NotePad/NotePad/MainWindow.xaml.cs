using System;
using System.IO;
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
using Microsoft.Win32;




namespace NotePad
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

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "Document";
            openfile.DefaultExt = ".txt";
            openfile.Filter = "Text documents (.txt)|*.txt";
            Nullable<bool> result = openfile.ShowDialog();
            if (result == true)
            {
                string filename = openfile.FileName;
                teeeextBox.Text = File.ReadAllText(filename);

            }
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            string teext = "";

            SaveFileDialog saveFile = new SaveFileDialog()
            {
                Filter = "Text Files(*.txt)|*.txt|All(*.*)|*"
            };

            if (saveFile.ShowDialog() == true)

            {
                File.WriteAllText(saveFile.FileName, teext);
            }
        }
    }
}
