using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Sample {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            //CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            CultureInfo culture = CultureInfo.CreateSpecificCulture("hr-BA");
            //CultureInfo culture = CultureInfo.CreateSpecificCulture("ru-RU");
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            base.OnStartup(e);
        }
    }
}
