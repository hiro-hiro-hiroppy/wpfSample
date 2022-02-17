using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using wpfSample.Objects;

namespace wpfSample
{
    /// <summary>
    /// _009_Sqlite.xaml の相互作用ロジック
    /// </summary>
    public partial class _009_Sqlite : Window
    {
        public _009_Sqlite()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer
            {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text
            };

            using(var connection = new SQLiteConnection(App.DatabasePath))
            {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            using(var connection = new SQLiteConnection(App.DatabasePath))
            {
                connection.CreateTable<Customer>();
                var customers = connection.Table<Customer>().ToList();
            }
        }
    }
}
