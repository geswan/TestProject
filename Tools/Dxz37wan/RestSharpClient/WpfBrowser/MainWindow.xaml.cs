﻿using mshtml;
using System;
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

namespace WpfBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += (s, e) =>
            {
                Button_Click(s, e);
            };
        }

        private void Login()
        {
            IHTMLDocument2 doc = (IHTMLDocument2)webBrowser.Document;
            doc.all.item("username").setAttribute("value", "wangcl2");
            doc.all.item("password").setAttribute("value", "314114");

            IHTMLWindow2 window = doc.parentWindow;
            window.execScript("login();");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    IHTMLDocument2 doc = (IHTMLDocument2)webBrowser.Document;

            //    IHTMLWindow2 window = doc.parentWindow;
            //    window.execScript("alert($('iframe').contentWindow)");
            //}
            //catch (Exception)
            //{

            //}


            this.webBrowser.LoadCompleted += (s, arg) =>
            {
                try
                {
                    Login();
                }
                catch (Exception)
                {

                }
            };
            var timer = new System.Timers.Timer(TimeSpan.FromMinutes(Convert.ToInt32(this.check.Text)).TotalMilliseconds);
            timer.Elapsed += (s, er) =>
            {
                this.webBrowser.Dispatcher.Invoke(() =>
                {
                    this.webBrowser.Navigate(new Uri(@"http://dxz.37wan.com/ingame.php?server=S510&time=1381806598&tuitan=&source="));
                });
            };

            timer.Start();
            this.webBrowser.Navigate(new Uri(@"http://dxz.37wan.com/ingame.php?server=S510&time=1381806598&tuitan=&source="));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.webBrowser.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.webBrowser.Visibility = Visibility.Visible;
        }
    }
}