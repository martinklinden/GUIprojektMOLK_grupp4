using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace GUIprojektMOLK_grupp4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            

            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Molk";
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WorkingDirectory = path,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false
            };

            process.StartInfo = startInfo;
            process.Start();

            process.StandardInput.WriteLine($"molk -j {destinationBox.Text}\\archive2.molk {fileBox.Text}");

            //molk path+archivename path+fileORfiletyp
        }

    }
}
