using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App19
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        public async void soap()
        {
            ServiceReference1.EVAglobalSoapClient T = new ServiceReference1.EVAglobalSoapClient();
            string soru = "test";
            string cyanid = "aec";
            string cyanpas = "123";
            string p = "testp";
            string lng = "testlng";

            
            ServiceReference1.konusResponse x = await T.konusAsync(soru, cyanid, cyanpas, p, lng);
            string a = x.Body.konusResult;
            textBox.Text = a;
              




        }

        private void _click(object sender, RoutedEventArgs e)
        {

            soap();
        }
    }
}
