using sqlliteMVVM.Models;
using sqlliteMVVM.ViewModels;

namespace sqlliteMVVM.Views;

public partial class ProductoPage : ContentPage
{
    private readonly ProductoViewModel _vModel;
    public ProductoPage()
    {
        InitializeComponent();
        _vModel = new ProductoViewModel();
        BindingContext = _vModel;
    }


    protected override async void OnAppearing() 
    {
        base.OnAppearing();
        _vModel.MostrarProductos();
    }


    private async void detalleLista(object sender, SelectedItemChangedEventArgs e)
    {

        Producto producto = e.SelectedItem as Producto;
        await Navigation.PushAsync(new DetalleProductoPage(producto));

    }
}