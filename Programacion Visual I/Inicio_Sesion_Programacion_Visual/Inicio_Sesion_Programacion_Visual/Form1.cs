using System;
using System.Windows.Forms;

namespace Inicio_Sesion_Programacion_Visual
{
    public partial class Form1 : Form
    {
        private int intentos = 0;                 
        private const int maxIntentos = 3;        

        private string correoCorrecto = "junior@gmail.com";
        private string passwordCorrecto = "12345";

        public Form1()
        {
            InitializeComponent();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string correoIngresado = txtCorreo.Text;
            string passwordIngresado = txtPassword.Text;

            if (correoIngresado == correoCorrecto && passwordIngresado == passwordCorrecto)
            {
                MessageBox.Show("¡Bienvenido Junior!", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                intentos = 0;
            }
            else
            {
                intentos++;

                if (intentos < maxIntentos)

                {
                    MessageBox.Show($"Intento {intentos} de {maxIntentos} fallido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Has alcanzado el máximo de intentos. El programa se cerrará.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
