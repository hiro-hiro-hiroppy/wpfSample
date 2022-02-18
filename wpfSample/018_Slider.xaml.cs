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
    /// _018_Slider.xaml の相互作用ロジック
    /// </summary>
    public partial class _018_Slider : Window
    {
        public _018_Slider()
        {
            InitializeComponent();
        }

        private void ASlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ASlider.Text = e.NewValue.ToString();
        }

        private void BSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BSlider.Text = e.NewValue.ToString();
        }
    }
}
