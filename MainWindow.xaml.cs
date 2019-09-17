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
using System.Text.RegularExpressions;
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
            //-CREACION BOTON CALCULAR-
            //######################################
            //Al momento de crear el boton , este nos crea un
            //espacio para poner los comandos correspondientes
            //Primero creamos el SMLM
            int smlm = 828116;
            //Creamos el subsidio
            int subsidio = 97032;
            int dosSub = subsidio * 2;
            //Creamos el nuevo sueldo
            int nuevoSueldo = 0;
            //Sueldo en int
            int sueldo = 0;
            //Regex para letras
            Regex r = new Regex("^[a-zA-Z\\s]*$");
            //######################################
            //-VERIFICACION Y PROCEDIMIENTO-
            //######################################
            //Para los procedimientos matematicos es necesario
            //hacer unas condicionales, pues estas deciden que
            //hacer de acuerdo al saldo ingresado.
            //
            //Primero creamos un if y then para la caja de texto(nombre)
            int parsedValue;
            if (!int.TryParse(nombreTrabajador.Text, out parsedValue))
            {
                MessageBox.Show("Por favor ingresar un nombre valido.");
                return;
            }
            else
            if (nombreTrabajador.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del trabajador no debe estar vacio. Por favor ingresar el nombre.");
                return;
            }
            else
            //Creamos un if para que verifique si hay algo escrito en el programa principal
            if (saldoTrabajador.Text.Trim().Length == 0)
            {
                MessageBox.Show("El sueldo del trabajador no debe estar vacio. Por favor ingresar el sueldo.");
                return;
            }
            else
            if (!r.IsMatch(saldoTrabajador.Text))
            {
                MessageBox.Show("El nombre del encuestado sólo debe tener caracteres alfabéticos ");
                saldoTrabajador.Focus();
            }
       
            else
            sueldo = Convert.ToInt32(saldoTrabajador.Text);
            //Creamos un if y then para que ingrese algun valor
            if (sueldo <0)
            {
                MessageBox.Show("Por favor ingrese un valor positivo.");
                return;
            }
            else
            //Creamos un if y then para que calcule el sueldo
            if (sueldo==dosSub)
            {
               sueldo = nuevoSueldo;
               MessageBox.Show("El sueldo del trabajador queda como:$",sueldo);
            }
            else
            //Creamos formula para imprimir nuevo sueldo
                if(sueldo<smlm)
            {
                nuevoSueldo = sueldo * smlm;
                MessageBox.Show("El sueldo es:",nuevoSueldo);
            }

        }

        private void BotonCerrar_Click(object sender, RoutedEventArgs e)
        {
            //######################################
            //-CREACION BOTON CERRAR-
            //######################################
            //Creamos el comando para salir
            System.Windows.Application.Current.Shutdown();
        }
    }
}
//Desarrollado por Pedro Gomez / ID:000396221