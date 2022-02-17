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

namespace wpfSample
{
    /// <summary>
    /// _005_Event.xaml の相互作用ロジック
    /// </summary>
    public partial class _005_Event : Window
    {
        public _005_Event()
        {
            InitializeComponent();
        }

        private void AButton_Click(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content += "A";
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "";
        }
    }
}
