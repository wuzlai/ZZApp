using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ZZApp.ViewModels;

namespace ZZApp.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext=new MainWindowViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void btnClick()
        {
            UserAgreementView view = new UserAgreementView();
            view.Show();

        }
    }
}
