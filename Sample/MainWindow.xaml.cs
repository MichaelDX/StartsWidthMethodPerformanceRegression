using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows;

namespace Sample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        List<string> list = new List<string>();

        public MainWindow() {
            InitializeComponent();          
            for (int i = 0; i < 1000000; i++) {
                list.Add($"{i}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var watch = new Stopwatch();
            watch.Start();
            list.ForEach(str => str.StartsWith("1"));
            watch.Stop();

            MessageBox.Show($"Culture: {Thread.CurrentThread.CurrentCulture.Name}; Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
