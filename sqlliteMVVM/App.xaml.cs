using sqlliteMVVM.Services;
using sqlliteMVVM.Views;

namespace sqlliteMVVM
{
    public partial class App : Application
    {
        public static ProductoRepository ProductoRepository { get; set; }
        public App()
        {
            InitializeComponent();
            ProductoRepository = new ProductoRepository();
            MainPage = new NavigationPage(new ProductoPage());
        }
    }
}
