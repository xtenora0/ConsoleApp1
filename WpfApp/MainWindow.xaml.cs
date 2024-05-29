using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonData _data;
        public MainWindow()
        {
            InitializeComponent();
            _data = new PersonData("https://localhost:7234");
        }


        private void btnCallSync_Click(object sender, RoutedEventArgs e)
        {
            var people = _data.GetAll();

            txbInfo.Text = people.Count.ToString();
        }

        private async void btnCallAsync_Click(object sender, RoutedEventArgs e)
        {
            var people = await _data.GetAllAsync();

            txbInfo.Text = people.Count.ToString();
        }

        private async void btnCallProgress_Click(object sender, RoutedEventArgs e)
        {
            IProgress<int> progress = new Progress<int>(percent => 
            {
                progres1.Value = percent;
                txbInfo.Text = $"{percent}%";
            });

            await DownloadWithProgress(progress);
        }

        private async Task DownloadWithProgress(IProgress<int> progress) 
        {
            int totalItems = await _data.GetPeopleCountAsync();
            int chunk = 100;
            int totalRequest = totalItems / chunk;

            for (int i = 0; i <= totalRequest; i++)
            {
                var newData = await _data.GetRangeAsync(i * chunk, chunk);
                var p = (i * 100) / totalRequest;
                progress.Report(p);
            }

            txbInfo.Text += " HOTOVO";
        }
    }
}