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

namespace EventBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> list = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetBubblingTextBox()
        {
            txtBubbling.Text = string.Join(" > ", list);
            ClearList();
        }

        private void SetTunnelingTextBox()
        {
            txtTunneling.Text = string.Join(" > ", list);
            ClearList();
        }

        private async void ClearList()
        {
            await Task.Delay(100);
            list.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Add("Button-Gray");
            SetBubblingTextBox();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("Border-Blue");
            SetBubblingTextBox();
            e.Handled = true;
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("Rectangle-Red");
            SetBubblingTextBox();
        }


        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("Button-Gray");
            SetTunnelingTextBox();
            // 이벤트 제어
            // 더이상 자식쪽으로 이벤트를 발생시키고 싶지 않을경우
            e.Handled = true;
        }

        private void Border_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("Border-Blue");
            SetTunnelingTextBox();
        }

        private void Rectangle_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("Rectangle-Red");
            SetTunnelingTextBox();
        }
    }
}