using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp02
{
    public partial class FrmOperacionesBasicas : Form
    {
        public FrmOperacionesBasicas()
        {
            InitializeComponent();
        }

        private int numero1 = 0;
        private int numero2 = 0;

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            Numero1TextBox.Clear();
            Numero2TextBox.Clear();
            SumarRadioButton.Checked = true;//vuelvo a poner en seleccionado al boton de la suma
            Numero1TextBox.Focus();
        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                EjecutarOperacion(OperacionBasica.Suma);
            }

        }

        private void EjecutarOperacion(OperacionBasica operacion)
        {
            int resultado = 0;
            switch (operacion)
            {
                case OperacionBasica.Suma:
                    resultado = numero1 + numero2;
                    break;
                case OperacionBasica.Resta:
                    resultado = numero1 - numero2;
                    break;
                case OperacionBasica.Multiplicación:
                    resultado = numero1 * numero2;
                    break;
                case OperacionBasica.División:
                    if (numero2!=0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por 0", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        Numero2TextBox.SelectAll();
                        Numero2TextBox.Focus();
                        return;
                    }
                    break;
                default:
                    break;
            }
            MessageBox.Show($"El resultado de la {operacion.ToString()} es {resultado}", "Resultado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            GuardarOperacion(operacion, numero1, numero2, resultado);
            InicializarControles();

        }

        private void GuardarOperacion(OperacionBasica operacion, int numero1, int numero2, int resultado)
        {
            string linea=$"{operacion.ToString()}-{numero1}-{numero2} - {resultado}";
            ResultadosListBox.Items.Add(linea);
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(Numero1TextBox.Text, out numero1))
            {
                valido = false;
                errorProvider1.SetError(Numero1TextBox,"Número mal ingresado");
            }
            if (!int.TryParse(Numero2TextBox.Text, out numero2))
            {
                valido = false;
                errorProvider1.SetError(Numero2TextBox, "Número mal ingresado");
            }

            return valido;
        }

        private void RestarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                EjecutarOperacion(OperacionBasica.Resta);
            }
        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                EjecutarOperacion(OperacionBasica.Multiplicación);
            }
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                EjecutarOperacion(OperacionBasica.División);
            }
        }



        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                OperacionBasica operacion; 
                if (SumarRadioButton.Checked)
                {
                    operacion = OperacionBasica.Suma;
                }else if (RestarRadioButton.Checked)
                {
                    operacion = OperacionBasica.Resta;
                }else if (MultiplicarRadioButton.Checked)
                {
                    operacion = OperacionBasica.Multiplicación;
                }
                else
                {
                    operacion = OperacionBasica.División;
                }
                EjecutarOperacion(operacion);
            }
        }

        private void FrmOperacionesBasicas_Load(object sender, EventArgs e)
        {

        }
    }
}
