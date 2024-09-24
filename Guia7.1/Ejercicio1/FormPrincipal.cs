using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        DepartamentoVehicular dv = new DepartamentoVehicular();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = Convert.ToInt32(tbDNI.Text);
                string nombre = tbNombre.Text;
                string patente = tbPatente.Text;
                Persona propietario = new Persona(dni, nombre);
                RegistroVehiculo rv = dv.RegistrarVehiculo(propietario, patente);

                tbDNI.Clear();
                tbNombre.Clear();
                tbPatente.Clear();
            }
            catch (RangoDniIncorrectoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatoPatenteNoValidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FormVer fVer = new FormVer();
                       
            dv.OrdenarRegistros();

            for (int n = 0; n < dv.CantidadRegistros; n++)
            {
                fVer.tbVer.Text += dv.VerRegistro(n).ToString()+"\r\n";
            }

            fVer.ShowDialog();
        }
    }
}
