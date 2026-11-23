using System;
using System.Windows.Forms;

namespace FormularioConWebView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cambiarUrl();

            webView.SourceChanged += (sender, args) =>
            {
                cambiarUrl();
            };
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(textUrl.Text);
            }
        }

        void cambiarUrl()
        {
            if (webView?.Source != null)
            {
                textUrl.Text = webView.Source.ToString();
            }
        }
    }
}