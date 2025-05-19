
namespace TP2MOVIL.Page;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}

    public void btnMenu_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Menu();
    }
}

