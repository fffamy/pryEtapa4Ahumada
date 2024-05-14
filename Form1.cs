using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEtapa4Ahumada
{
    public partial class frmEtapa4 : Form
    {
        //Esto declara una lista genérica llamada vehiculos que contendrá instancias de la clase clsVehiculo
        private List<clsVehiculo> vehiculos;
        //Esto declara una variable entera llamada indiceActual e inicializa su valor en 0
        private int indiceActual = 0;

        public frmEtapa4()
        {
            InitializeComponent();

            //Creo una lista de vehículos (vehiculos) con tres vehículos distintos: un auto, un barco y un avión, cada uno con sus propias características.
            vehiculos = new List<clsVehiculo>
            {
                new clsVehiculo("Auto", "Auto", Properties.Resources.auto),
                new clsVehiculo("Barco", "Barco", Properties.Resources.barco),
                new clsVehiculo("Avion", "Avion", Properties.Resources.avion)
            };
        }

        private void MostrarSiguienteVehiculo()
        {
            //Incremento el indice en 1 y tomo el modulo del resultado con el tamaño de la lista, asi el indice circula a traves de los indices de la lista
            indiceActual = (indiceActual + 1) % vehiculos.Count;
            clsVehiculo vehiculo = vehiculos[indiceActual];


            pctImagen.Image = vehiculo.Imagen;
            pctImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MostrarSiguienteVehiculo();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsVehiculo vehiculo = vehiculos[indiceActual];
            lblListar.Text = vehiculo.Tipo;
        }
    }
}
