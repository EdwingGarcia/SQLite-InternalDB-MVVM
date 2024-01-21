using sqlliteMVVM.Models;
using sqlliteMVVM.ViewModels;

namespace sqlliteMVVM.Views;

public partial class DetalleProductoPage : ContentPage
{
    private readonly DetalleProductoViewModel _vModel;
    public DetalleProductoPage(Producto Producto)
    {
        InitializeComponent();
        _vModel = new DetalleProductoViewModel(Producto);
        BindingContext = _vModel;
    }

    protected override async void OnAppearing() 
    {
        base.OnAppearing();
        _vModel.MostrarProductos();
    }

}