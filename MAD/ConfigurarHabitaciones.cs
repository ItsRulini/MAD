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
    public partial class ConfigurarHabitaciones : Form
    {
        // Lo que vamos a usar para guardar los datos de las habitaciones
        public Dictionary<int, TipoHabitacion> tipoHabitaciones { get; private set; }
        public Dictionary<int, Amenidad> amenidades { get; private set; }
        public Dictionary<int, CamaTipoHabitacion> camas { get; private set; }

        public ConfigurarHabitaciones()
        {
            InitializeComponent();
            enableControls(false);

            llenarGridAmenidades();
            llenarComboCamabas();
        }

        private void enableControls(bool value)
        {
            textPrecioPersona.Enabled = value;
            CantMaxPers.Enabled = value;
            comboTipoCama.Enabled = value;
            CantCamas.Enabled = value;
            btnAgregarCama.Enabled = value;
            radioPasillo.Enabled = value;
            radioVentana.Enabled = value;
            radioTerraza.Enabled = value;
            btnAgregarHabitacion.Enabled = value;
            dgvAmenidades.Enabled = value;
            dgvCamas.Enabled = value;
        }

        private void llenarComboCamabas()
        {
            comboTipoCama.Items.Add("Individual");
            comboTipoCama.Items.Add("Matrimonial");
            comboTipoCama.Items.Add("Queen size");
            comboTipoCama.Items.Add("King size");
        }
        private void llenarGridAmenidades()
        {
            dgvAmenidades.Rows.Clear(); // Limpiar el DataGridView antes de llenarlo
            AmenidadDAO amenidadDAO = new AmenidadDAO();
            List<Amenidad> amenidades = amenidadDAO.getAmenidaes();
            foreach (Amenidad amenidad in amenidades)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvAmenidades);
                row.Cells[0].Value = amenidad.Amenidad1;
                dgvAmenidades.Rows.Add(row);
            }
        }
        private void ConfigurarHabitaciones_Load(object sender, EventArgs e)
        {

        }

        private void radioVentana_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNombre.Text))
            {
                enableControls(false);
            }
            else
            {
                enableControls(true);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AñadorAmenidad formAddAmenidad = new AñadorAmenidad();

            formAddAmenidad.ShowDialog();
            this.Focus();
            llenarGridAmenidades();
        }
        private void btnAgregarCama_Click(object sender, EventArgs e)
        {
            if (comboTipoCama.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un tipo de cama.");
                return;
            }

            if (string.IsNullOrEmpty(CantCamas.Text))
            {
                MessageBox.Show("Por favor, ingrese la cantidad de camas.");
                return;
            }

            // Validar si el servicio ya fue agregado
            foreach (DataGridViewRow row in dgvCamas.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value?.ToString() == comboTipoCama.Text)
                {
                    if (row.Cells[1].Value?.ToString() == CantCamas.Value.ToString())
                    {
                        MessageBox.Show("Este tipo de cama ya fue agregada con la misma cantidad.");
                        return;
                    }
                    else
                    {
                        dgvCamas.Rows.RemoveAt(row.Index); // Eliminar la fila existente
                        MessageBox.Show("Cantidad actualizada.");
                    }
                }
            }

            dgvCamas.Rows.Add(comboTipoCama.Text, CantCamas.Text);

        }

        private void dgvCamas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // Para evitar errores si clickeas en los encabezados
            {
                dgvCamas.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvConfigHab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 8) // Para evitar errores si clickeas en los encabezados
            {
                dgvConfigHab.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textNombre.Text) || string.IsNullOrEmpty(textPrecioPersona.Text) || CantMaxPers.Value <= 0)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            if (dgvCamas.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, agregue al menos una cama.");
                return;
            }

            bool hasAmenidades = false;

            foreach (DataGridViewRow row in dgvAmenidades.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value))
                {
                    hasAmenidades = true;
                    break;
                }
            }

            if (!hasAmenidades)
            {
                MessageBox.Show("Por favor, agregue al menos una amenidad.");
                return;
            }

            bool ubicacionSeleccionada = false;

            if (radioPasillo.Checked)
            {
                ubicacionSeleccionada = true;
            }
            else if (radioVentana.Checked)
            {
                ubicacionSeleccionada = true;
            }
            else if (radioTerraza.Checked)
            {
                ubicacionSeleccionada = true;
            }

            if (!ubicacionSeleccionada)
            {
                MessageBox.Show("Por favor, seleccione una ubicación.");
                return;
            }

            decimal precioNoche = decimal.Parse(textPrecioPersona.Text) * CantMaxPers.Value;

            StringBuilder amenidadesString = new StringBuilder();

            foreach (DataGridViewRow row in dgvAmenidades.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value))
                {
                    amenidadesString.AppendLine(row.Cells[0].Value.ToString());
                }
            }

            StringBuilder camasString = new StringBuilder();
            StringBuilder cantidadCamaString = new StringBuilder();

            foreach (DataGridViewRow row in dgvCamas.Rows)
            {
                camasString.AppendLine(row.Cells[0].Value.ToString());
                cantidadCamaString.AppendLine(row.Cells[1].Value.ToString());
            }

            dgvConfigHab.Rows.Add(
                textNombre.Text,
                radioPasillo.Checked ? "Pasillo" : radioVentana.Checked ? "Ventana" : "Terraza",
                precioNoche.ToString("C"), // Formato de moneda
                textPrecioPersona.Text,
                CantMaxPers.Value.ToString(), // máxima de huespedes
                camasString.ToString(), // tipo de cama
                cantidadCamaString.ToString(), // cantidad de camas
                amenidadesString.ToString() // amenidades
            );

            textNombre.Clear();
            textPrecioPersona.Clear();
            CantCamas.Value = 1;
            CantMaxPers.Value = 1;
            dgvCamas.Rows.Clear();

            foreach (DataGridViewRow row in dgvAmenidades.Rows)
            {
                row.Cells[1].Value = false; // Desmarcar todas las amenidades
            }

        }

        public List<TipoHabitacion> habitacionesTemp { get; private set; }
        private void btnFinConf_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea agregar estas configuraciones?", "Advertencia", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                // Si el usuario da "No" o "Cancelar", NO seguimos
                return;
            }

            // Una sola lista que contiene todo
            habitacionesTemp = new List<TipoHabitacion>();

            foreach (DataGridViewRow row in dgvConfigHab.Rows)
            {
                if (row.IsNewRow) continue; // saltar fila vacía

                // Creamos el objeto TipoHabitacion
                TipoHabitacion tipoHabitacion = new TipoHabitacion
                {
                    IdTipoHabitacion = Guid.NewGuid(),
                    NivelHabitacion = row.Cells[0].Value?.ToString(),
                    Ubicacion = row.Cells[1].Value?.ToString(),
                    PrecioPorNoche = decimal.Parse(row.Cells[2].Value?.ToString().Replace("$", "").Replace(",", "")),
                    PrecioPorPersona = decimal.Parse(row.Cells[3].Value?.ToString()),
                    CanidadMaximaPersonas = int.Parse(row.Cells[4].Value?.ToString())
                };

                // Procesar camas
                string[] tiposCamas = row.Cells[5].Value?.ToString()
                    .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                string[] cantidadesCamas = row.Cells[6].Value?.ToString()
                    .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                if (tiposCamas != null && cantidadesCamas != null)
                {
                    for (int i = 0; i < tiposCamas.Length; i++)
                    {
                        CamaTipoHabitacion cama = new CamaTipoHabitacion
                        {
                            TipoCama = tiposCamas[i],
                            CantidadCama = int.Parse(cantidadesCamas[i])
                        };
                        tipoHabitacion.CamaTipoHabitacions.Add(cama);
                    }
                }

                // Procesar amenidades
                string[] amenidades = row.Cells[7].Value?.ToString()
                    .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                AmenidadDAO amenidadDAO = new AmenidadDAO();

                if (amenidades != null)
                {
                    foreach (string amenidadStr in amenidades)
                    {
                        AmenidadTipoHabitacion amenidad = new AmenidadTipoHabitacion
                        {
                            IdAmenidad = amenidadDAO.getIdAmenidad(amenidadStr),
                            IdTipoHabitacion = tipoHabitacion.IdTipoHabitacion
                        };
                        tipoHabitacion.AmenidadTipoHabitacions.Add(amenidad);
                    }
                }

                // Finalmente agregamos el tipoHabitacion completo a la lista
                habitacionesTemp.Add(tipoHabitacion);
            }

            this.DialogResult = DialogResult.OK; // Indica que la operación fue exitosa
            MessageBox.Show("Configuración de habitaciones guardada con éxito.");
            this.Close(); // Cierra el formulario
        }



        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAmenidades.IsCurrentCellDirty)
            {
                dgvAmenidades.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dgvAmenidades.Columns["AmenidadSelect"].Index) // Es la columna de eliminar
            //{
            //    var cellValue = dgvAmenidades.Rows[e.RowIndex].Cells["AmenidadSelect"].Value;

            //    if (cellValue != null && Convert.ToBoolean(cellValue))
            //    {
            //        dgvAmenidades.Rows.RemoveAt(e.RowIndex); // Elimina la fila
            //    }
            //}

        }

    }
}
