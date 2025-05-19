namespace TP2MOVIL.Page;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}
	public void btnAbout_Clicked(object sender, EventArgs e)
	{
		Application.Current.MainPage = new About();
	}
	public void btnService_Clicked(object sender, EventArgs e)
	{
		Application.Current.MainPage = new Service();

	}

    public void btnLogin_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Login();
    }
}