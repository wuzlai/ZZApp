using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CefNet.Avalonia;
using System;
using System.IO;
using System.Threading;

namespace ZZApp.Views
{
    public class UserAgreementView : Window
    {
        public UserAgreementView()
        {
            this.InitializeComponent();

        }
        bool isInit = false;
        WebView webView;
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            webView = this.FindControl<WebView>("webView");
            this.Opened += UserAgreementView_Opened;
        }

        private void UserAgreementView_Opened(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            if (!isInit)
            {
                Thread.Sleep(100);
                isInit = true;
                LoadFile();
            }
        }

       

        private void LoadFile()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(path,"UserAgreement_zh-cn.html");
           
            string content = string.Empty;
            using (StreamReader reader = new StreamReader(filePath))
            {
                content = reader.ReadToEnd();
            }
           
            webView.Navigate("data:text/html;charset=utf-8," + content);
          
        }
    }
}
