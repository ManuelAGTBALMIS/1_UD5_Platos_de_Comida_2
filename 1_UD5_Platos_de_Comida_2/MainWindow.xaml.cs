using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1_UD5_Platos_de_Comida_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Plato> platos = Plato.GetSamples("Imagenes/");

        List<string> combo = new List<string>(new string[] { "Americana", "China", "Mexicana" });

        public MainWindow()
        {
            InitializeComponent();
            ItemsListBox.DataContext = platos;
            comboComidasComboBox.DataContext = combo;

        }

    }
}
