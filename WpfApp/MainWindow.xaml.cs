﻿using System.Text;
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
    }
}