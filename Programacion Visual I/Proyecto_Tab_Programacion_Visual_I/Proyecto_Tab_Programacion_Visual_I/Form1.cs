using System;
using System.Windows.Forms;

namespace ProyectoTabs
{
    public partial class Form1 : Form
    {
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //CONTADOR
        private void btnClic_Click(object sender, EventArgs e)
        {
            contador++;
            lblContador.Text = contador.ToString();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            contador = 0;
            lblContador.Text = "0";
        }

        //IMC
        private void btnCalcularIMC_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);

                if (peso <= 0 || altura <= 0)
                {
                    MessageBox.Show("Ingrese valores positivos.");
                    return;
                }

                double imc = peso / (altura * altura);
                string clasificacion;

                if (imc < 18.5) clasificacion = "Bajo peso";
                else if (imc < 24.9) clasificacion = "Peso normal";
                else if (imc < 29.9) clasificacion = "Sobrepeso";
                else clasificacion = "Obesidad";

                lblResultadoIMC.Text = $"IMC: {imc:F2} - {clasificacion}";
            }
            catch
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
            }
        }

        //CONVERSOR DE TEMPERATURA
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txtTemperatura.Text);
                string de = cmbDe.SelectedItem?.ToString();
                string a = cmbA.SelectedItem?.ToString();

                if (de == null || a == null)
                {
                    MessageBox.Show("Seleccione las unidades de conversión.");
                    return;
                }

                double resultado = valor;

                if (de == "F") resultado = (valor - 32) * 5 / 9;
                else if (de == "K") resultado = valor - 273.15;
                else if (de == "C") resultado = valor;

                if (a == "F") resultado = (resultado * 9 / 5) + 32;
                else if (a == "K") resultado = resultado + 273.15;

                lblResultadoTemp.Text = $"{valor} °{de} = {resultado:F2} °{a}";
            }
            catch
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void cmbDe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
