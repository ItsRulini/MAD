using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.DAO;
using MAD.Models;

namespace MAD
{
    public partial class AñadirServicio : Form
    {
        List<Unidad> unidades = new List<Unidad>();
        public AñadirServicio()
        {
            InitializeComponent();
            llenarGridServicios();
            llenarComboUnidades();
        }

        private void llenarComboUnidades()
        {
            UnidadDAO unidadDAO = new UnidadDAO();

            unidades = unidadDAO.getUnidades();
            foreach (Unidad unidad in unidades)
            {
                comboClaveUnidad.Items.Add(unidad.ClaveUnidad);
            }
        }

        private void llenarGridServicios()
        {
            dgvServiciosExistente.Rows.Clear(); // Limpiar el DataGridView antes de llenarlo
            ServicioDAO servicioDAO = new ServicioDAO();
            List<Servicio> servicios = servicioDAO.getServicios();

            foreach (Servicio servicio in servicios)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvServiciosExistente);
                row.Cells[0].Value = servicio.Nombre;
                dgvServiciosExistente.Rows.Add(row);
            }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            ServicioDAO servicioDAO = new ServicioDAO();

            if (string.IsNullOrEmpty(textNombreServicio.Text) || comboClaveUnidad.SelectedIndex < 0 || string.IsNullOrEmpty(textClaveSAT.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
            }


            if (servicioDAO.insertarServicio(textNombreServicio.Text, long.Parse(textClaveSAT.Text), comboClaveUnidad.Text))
            {
                MessageBox.Show("Servicio agregado correctamente");
                llenarGridServicios();

                textNombreServicio.Clear();
                textClaveSAT.Clear();
                comboClaveUnidad.SelectedIndex = -1;
                textBoxUnidad.Clear();
            }
            else
            {
                MessageBox.Show("Error al agregar el servicio");
            }


        }

        private void textClaveSAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y teclas de control como backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla presionada
                MessageBox.Show("Por favor, ingrese solo números.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboClaveUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboClaveUnidad.SelectedIndex >= 0)
                textBoxUnidad.Text = unidades.Find(u => u.ClaveUnidad == comboClaveUnidad.Text).Unidad1.ToString();
        }
    }
}
