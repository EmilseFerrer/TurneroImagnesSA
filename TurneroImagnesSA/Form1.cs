using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TurneroImagnesSA
{
    public partial class Form1 : Form
    {
        //Para guardar los turnos en una lista
        private List<string> turnos = new List<string>();
       
        public Form1()
        {
            InitializeComponent();
           
            //instancia para seleccionar fecha en formato corto
            dateTimePicker1.Format = DateTimePickerFormat.Short;

            //inicializacion de horarios
            // for (inicialización, condición,incremento)
            for (int i = 0; i < 24; i++)
            {
                cbHorario.Items.Add(i.ToString("D2") + ":00");  // Añade horas en formato 00:00
                cbHorario.Items.Add(i.ToString("D2") + ":30");  // Añade minutos en 30
            }
            cbHorario.SelectedIndex = 0;  // Selecciona la primera hora por defecto
        }
        private void btlimpiar_Click(object sender, EventArgs e)
        {
            // método para el evento limpiar 
            
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbPracticas.SelectedIndex = 0;
            cbEstudio.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            cbHorario.SelectedIndex = 0;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //finalizar la ejecución del programa
            
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            // Obtiene el nombre y apellido, y verifica si están vacíos
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                // Muestra un MessageBox de error si falta el nombre o apellido
                MessageBox.Show("El nombre y el apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convierte nombre y apellido a mayúsculas
            nombre = nombre.ToUpper();
            apellido = apellido.ToUpper();

           // hora seleccionada
            string selectedHora = cbHorario.SelectedItem.ToString();

           //mensaje que aparece en el messageBox
            string mensaje = nombre + "" + apellido + " Usted seleccionó " +
            cbPracticas.Text + "" + cbEstudio.Text + "el día "
            + dateTimePicker1.Value.ToShortDateString() + " a las " + selectedHora;

            object value = MessageBox.Show (mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //lblmensaje.Text = mensaje antes el mensaje aparecia en un label y lo cambie por un messagebox

            //Ingresa a la lista de turnos el mensaje del turno seleccionado
            turnos.Add(mensaje);

            //muestra el mensaje (primero el texto del mensaje, el titulo del mensaje, el boton que aparece, icono)
            MessageBox.Show("El turno se ha guardado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btTurnos_Click(object sender, EventArgs e)
        {
           //si no hay turnos agendados todavia, el paciente al ingresar ver turnos le sale un message box 
            
            if (turnos.Count == 0)
            {
                MessageBox.Show("No hay turnos guardados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //  para mostrar el mensaje con todos los turnos
            //string.join = combina cadenas
            
            string todosTurnos = string.Join("\n", turnos);

            // Muestra todos los turnos en un MessageBox
            MessageBox.Show(todosTurnos, "Turnos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
