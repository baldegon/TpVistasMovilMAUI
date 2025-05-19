using Microsoft.Maui.Controls;

namespace TP2MOVIL.Page;

public partial class Service : ContentPage
{
	public Service()
	{
		InitializeComponent();

	}

    public void btnMenu_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Menu();
    }
}