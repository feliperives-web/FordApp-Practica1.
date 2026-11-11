using System.Windows;
using FordApp.Pages;

namespace FordApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new InicioPage());
        }

        private void BtnInicio_Click(object sender, RoutedEventArgs e) => MainFrame.Navigate(new InicioPage());
        private void BtnGaleria_Click(object sender, RoutedEventArgs e) => MainFrame.Navigate(new GaleriaPage());
        private void BtnLogin_Click(object sender, RoutedEventArgs e) => MainFrame.Navigate(new LoginPage());

        // Método que se llama desde LoginPage al acertar la contraseña
        public void ActualizarEstadoSesion(bool iniciada)
        {
            if (iniciada)
            {
                PanelSesionGlobal.Visibility = Visibility.Visible;
            }
            else
            {
                PanelSesionGlobal.Visibility = Visibility.Collapsed;
                // Al cerrar sesión globalmente, forzamos la recarga de la página de Login para resetearla
                MainFrame.Navigate(new LoginPage(mostrarMensajeCierre: true));
            }
        }

        private void BtnCerrarSesionGlobal_Click(object sender, RoutedEventArgs e)
        {
            ActualizarEstadoSesion(false);
        }
    }
}