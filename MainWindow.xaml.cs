using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AppClientes
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnMenuItemTapped(object sender, TappedRoutedEventArgs e)
        {
            var selectedItem = (NavigationViewItem)sender;
            switch (selectedItem.Content)
            {
                case "Home":
                    contentFrame.Navigate(typeof(ClientePagina));
                    break;
                case "Opciones":
                    // Navegar a la página de opciones si es necesario
                    break;
                case "Perfil":
                    // Navegar a la página de perfil si es necesario
                    break;
            }

        }
    }
}
