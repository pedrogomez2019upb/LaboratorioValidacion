//######################################
//-LABORATORIO VALIDACION-
//######################################
using System;
using System.Collections.Generic;
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
//using System.Windows.Forms;

//######################################
//-CREACION INTERFAZ-
//######################################
//Por Primera instancia creamos la interfaz grafica para el uso del programa
namespace LaboratorioValidacion_GomezPedro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonCalcular_Click(object sender, RoutedEventArgs e)
        {
            //######################################
            //-CREACION BOTON CALCULAR
            //######################################
            //Al momento de crear el boton , este nos crea un
            //espacio para poner los comandos correspondientes
            //Primero creamos el SMLM
            float smlm = 828116;
            //Creamos el subsidio
            float subsidio = 97032;
            //Creamos el nuevo sueldo
            float nuevoSueldo = 0;


        }
    }
}
//Desarrollado por Pedro Gomez / ID:000396221