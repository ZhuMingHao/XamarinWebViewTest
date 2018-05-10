using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var urlSource = new UrlWebViewSource { Url = "https://htmlpreview.github.io/?https://github.com/joelbyrd/external-resources/blob/master/storefulfillment/Printing/Packing/GNC-Pick.htm" };
            var htmlStringSource = new HtmlWebViewSource
            {
                Html = @"<!doctype html><html lang='en'><head><meta charset='utf-8'><meta http-equiv='x-ua-compatible' content='ie=edge'><meta name='viewport' content='width=device-width, initial-scale=1'><title>Test</title></head><body><div id='log'></div><p>some text</p><script>document.getElementById('log').innerHTML += `<p>Testing</p>`;</script></body></html>"
            };

            var webView = new WebView
            {
                Margin = new Thickness(0, 20, 0, 0),
                //Source = urlSource, // displays as expected
                Source = htmlStringSource // <script>'s are processed twice, appending "Testing" to the body twice
            };

            Content = webView;
        }

    }
}
