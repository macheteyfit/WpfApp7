﻿using System;
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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GrowButton.Click += GrowButton_Click;
            ShrinkButton.Click += ShrinkButton_Click;
            Button1.Click += Button1_Click;
            Button2.Click += Button2_Click;
        }
        private void GrowButton_Click(object sender, RoutedEventArgs e)
        {
            Rect.Width += 10;            
        }

        private void ShrinkButton_Click(object sender, RoutedEventArgs e)
        {
            Rect.Width -= 10;
           
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
           Rect.Height += 10;
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
           Rect.Height -= 10;
        }
    }
}
