using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCuevasEjerxResolverSP3
{
    public partial class frmRegistroDeRepuestos : Form
    {
        struct Repuesto
        {
            public string Marca;
            public string Origen;
            public int Numero;
            public float Precio;
            public string Descripcion;
        }
        Repuesto[] vecRepuesto = new Repuesto[100];
        public int Indice;
        public int IndiceRegistro;
        public frmRegistroDeRepuestos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Indice = 0;
            if (IndiceRegistro < vecRepuesto.Length)
            {
                if (vecRepuesto[Indice].Numero == int.Parse(txtNroRepuesto.Text))
                {

                    MessageBox.Show("El número de serie del repuesto ya existe en el sistema. Por favor controlar que sea correcto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnRegistrar.Enabled = false;
                    LimpiarInterfaz();

                }

                else
                {

                    if (btnRegistrar.Enabled)
                    {
                        btnConsultar.Enabled = true;

                    }
                    Indice++;

                    vecRepuesto[IndiceRegistro].Marca = cmbMarca.Text;
                    vecRepuesto[IndiceRegistro].Origen = cmbOrigen.Text;
                    vecRepuesto[IndiceRegistro].Numero = int.Parse(txtNroRepuesto.Text);
                    vecRepuesto[IndiceRegistro].Descripcion = txtDescripcion.Text;
                    vecRepuesto[IndiceRegistro].Precio = float.Parse(txtPrecio.Text);
                    MessageBox.Show("Usuario Registrado correctamente.","Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    IndiceRegistro++;
                }
            }
            else
            {
                MessageBox.Show("Se ha llegado al limite de registros. Intente nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            LimpiarInterfaz();
        }
        private void LimpiarInterfaz()
        {
            cmbMarca.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            txtNroRepuesto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";

            cmbMarca.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta.Items.Clear();
            Indice = 0;
            while (Indice < vecRepuesto.Length)
            {
                if (vecRepuesto[Indice].Marca == cmbMarcaConsulta.Text)
                {

                    if (optNacional.Checked == true && vecRepuesto[Indice].Origen == "Nacional")
                    {
                        Consulta.Items.Add("Nro Repuesto: " + vecRepuesto[Indice].Numero);
                        Consulta.Items.Add("Descripcion: " + vecRepuesto[Indice].Descripcion);
                        Consulta.Items.Add("Precio: $" + vecRepuesto[Indice].Precio);
                    }
                    else
                    {
                        if (optImportado.Checked == true && vecRepuesto[Indice].Origen == "Importado")
                        {
                            Consulta.Items.Add("Nro Repuesto: " + vecRepuesto[Indice].Numero);
                            Consulta.Items.Add("Descripcion: " + vecRepuesto[Indice].Descripcion);
                            Consulta.Items.Add("Precio: $" + vecRepuesto[Indice].Precio);
                        }

                    }
                }
                Indice++;
            }
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbMarca.SelectedIndex != -1)
            {
                cmbOrigen.Enabled = true;
            }
            else
            {
                cmbOrigen.Enabled = false;
            }
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedIndex != -1)
            {
                txtNroRepuesto.Enabled = true;
            }
            else
            {
                txtNroRepuesto.Enabled = false;
            }
        }

        private void txtNroRepuesto_TextChanged(object sender, EventArgs e)
        {
            if (txtNroRepuesto.Text != "")
            {
                txtDescripcion.Enabled = true;
            }
            else
            {
                txtDescripcion.Enabled = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                txtPrecio.Enabled = true;
            }
            else
            {
                txtPrecio.Enabled = false;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarInterfaz();
        }

        private void txtNroRepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // borrar la tecla ingresada
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e, false);
        }
        private static void OnlyNumber(KeyPressEventArgs e, bool isdecimal)
        {
            String aceptados;
            if (!isdecimal)
            {
                aceptados = "0123456789," + Convert.ToChar(8);
            }
            else
                aceptados = "0123456789." + Convert.ToChar(8);

            if (aceptados.Contains("" + e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
