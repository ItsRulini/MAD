using MAD.DAO;
using MAD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD
{
    public partial class AñadorAmenidad : Form
    {
        List<Unidad> unidades = new List<Unidad>();
        public AñadorAmenidad()
        {
            InitializeComponent();

            llenarGridAmenidades();
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

        private void llenarGridAmenidades()
        {
            dgvAmenidadExistente.Rows.Clear(); // Limpiar el DataGridView antes de llenarlo
            AmenidadDAO amenidadDAO = new AmenidadDAO();
            List<Amenidad> amenidades = amenidadDAO.getAmenidaes();

            foreach (Amenidad amenidad in amenidades)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvAmenidadExistente);
                row.Cells[0].Value = amenidad.Amenidad1;
                dgvAmenidadExistente.Rows.Add(row);
            }
        }

        private void btnAgregarAmenidad_Click(object sender, EventArgs e)
        {
            AmenidadDAO amenidadDAO = new AmenidadDAO();

            if (string.IsNullOrEmpty(textNombreAmenidad.Text) || comboClaveUnidad.SelectedIndex < 0 || string.IsNullOrEmpty(textClaveSAT.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
            }


            if (amenidadDAO.insertarAmenidad(textNombreAmenidad.Text, long.Parse(textClaveSAT.Text), comboClaveUnidad.Text))
            {
                MessageBox.Show("Amenidad agregada correctamente");
                llenarGridAmenidades();
            }
            else
            {
                MessageBox.Show("Error al agregar la amendiad");
            }

            textNombreAmenidad.Clear();
            comboClaveUnidad.SelectedIndex = -1;
            textClaveSAT.Clear();


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
            if(comboClaveUnidad.SelectedIndex > 0)
                textUnidad.Text = unidades.Find(u => u.ClaveUnidad == comboClaveUnidad.Text).Unidad1.ToString();
        }
    }
}
