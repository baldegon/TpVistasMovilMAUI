using TP2MOVIL.Page;

namespace TP2MOVIL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }
    }
}
