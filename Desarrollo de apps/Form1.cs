using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Desarrollo_de_apps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //se crea el diccionario 
        private Dictionary<string, string> miDiccionario = new Dictionary<string, string>();
        private void button1_Click(object sender, EventArgs e)
        {

            // Capturar el nombre y la cédula del usuario
            string nombre = textNombre.Text;
            string cedula = textCedula.Text;

            // Validar que los campos no estén vacíos
            if (nombre != "" && cedula != "")
            {
                // Agregar los datos al diccionario
                miDiccionario.Add(nombre, cedula);

                // Limpiar los campos de texto
                textNombre.Text = "";
                textCedula.Text = "";

                // Mostrar un mensaje de éxito
                MessageBox.Show("Datos guardados correctamente.");
            }
            else
            {
                // Mostrar un mensaje de error si algún campo está vacío
                MessageBox.Show("Por favor ingrese el nombre y la cédula.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Recorrer el diccionario y mostrar los datos
            foreach (KeyValuePair<string, string> persona in miDiccionario)
            {
                MessageBox.Show($"Nombre: {persona.Key}\nCédula: {persona.Value}");
            }
        }
    }
}
