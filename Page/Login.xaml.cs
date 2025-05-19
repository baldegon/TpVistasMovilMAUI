namespace TP2MOVIL.Page;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if((UsuarioEntry.Text=="baldegoni" || UsuarioEntry.Text=="Baldegoni") &&  ContraseñaEntry.Text == "1234")
		{
			Application.Current.MainPage = new Menu();
		}
		else
		{
			DisplayAlert(title: "Login error", message: "User o Contraseña Incorrecto", cancel:"OK");
		}

    }
	
}