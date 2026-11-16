using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioConWebView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView.NavigationCompleted += (sender, args) =>
            {
                textUrl.Text = webView.Source.ToString();
            };
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(textUrl.Text);
            }
        }
    }
}
