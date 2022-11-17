using SENC_Comparator_NF48_1._0.ViewModels;
using System.Windows;

namespace SENC_Comparator_NF48_1._0
{
    /// <summary>
    /// AppShell.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AppShell : Window
    {
        MainViewModel MainViewModel;

        public AppShell()
        {
            InitializeComponent();

            MainViewModel = new MainViewModel();
            DataContext = MainViewModel;
        }
    }
}