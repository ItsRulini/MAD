using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.Models;
using MAD.DAO;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAD
{
    public partial class ModHotel : Form
    {

        private List<Amenidad> amenidad = new List<Amenidad>();
        private List<Servicio> servicio = new List<Servicio>();
        private List<TipoHabitacion> tipoHabitacion = new List<TipoHabitacion>();
        private List<Servicio> servicioNoHotel = new List<Servicio>();
        ICollection<Amenidad> amenidadesNoEnHabitacion = new List<Amenidad>();

        Guid idHotel; // Id del hotel encontrado

        public ModHotel()
        {
            InitializeComponent();
            llenarComboCiudades();
        }

        private void llenarComboCiudades()
        {
            UbicacionDAO ciudadDAO = new UbicacionDAO();
            List<Ubicacion> ciudades = ciudadDAO.getCiudadesHotel();
            foreach (Ubicacion ciudad in ciudades)
            {
                comboCiudad.Items.Add(ciudad.Ciudad);
            }
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {

            List<HotelServicio> serviciosToInsert = new List<HotelServicio>();
            Dictionary<TipoHabitacion, int> habitacionesToInsert = new Dictionary<TipoHabitacion, int>();

            foreach (DataGridViewRow row in dgvServicioAñadido.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value.ToString() != null)
                {
                    string servicioNombre = row.Cells[0].Value.ToString();

                    Servicio servicio = new Servicio();
                     servicio = servicioNoHotel
                        .FirstOrDefault(x => x.Nombre == servicioNombre);


                    decimal.TryParse(row.Cells[1].Value.ToString(), out decimal precio);

                    HotelServicio servicioHotel = new HotelServicio
                    {
                        IdServicio = servicio.IdServicio,
                        Precio = precio
                    };

                    serviciosToInsert.Add(servicioHotel);
                }
            }

            foreach(DataGridViewRow row in dgvHabAñadidas.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value.ToString() != null)
                {
                    string tipoHabitacionNombre = row.Cells[0].Value.ToString();
                    int.TryParse(row.Cells[1].Value.ToString(), out int cantidad);

                    TipoHabitacion tipoHab = tipoHabitacion
                        .FirstOrDefault(x => x.NivelHabitacion == tipoHabitacionNombre);
                    
                    habitacionesToInsert.Add(tipoHab, cantidad);
                }
            }

            HotelDAO hotelDAO = new HotelDAO();
            if (hotelDAO.updateHotel(idHotel,int.Parse(NumPisos.Value.ToString()), serviciosToInsert, habitacionesToInsert))
            {
                MessageBox.Show("Cambios guardados correctamente");
                this.Close();

                dgvServicioAñadido.Rows.Clear();
                comboServicio.SelectedIndex = -1;

                ServicioDAO servicioDAO = new ServicioDAO();

                foreach (var item in serviciosToInsert)
                {
                    Servicio s = servicioDAO.getServicioPorId(item.IdServicio);

                    servicioNoHotel.Remove(s); // borrando los servicios que ya fueron añadidos
                    comboServicio.Items.Remove(s.Nombre); // removiendo los servicios que ya fueron añadidos

                    dgvServicioExistente.Rows.Add(s.Nombre); // agregando los servicios que se acaban de añadir
                    servicio.Add(s); // agregando los servicios que se acaban de añadir al hotel
                }
            }
            else
            {
                MessageBox.Show("Error al guardar los cambios");
            }

        }

        //Gestión de amenidades

        private void btnAdgregarAmenidad_Click(object sender, EventArgs e)
        {
            if (comboAmenidad.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una amenidad");
                return;
            }

            if (comboTipohabitacionAmenidad.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un tipo de habitación");
                return;
            }

            foreach (DataGridViewRow row in dgvAmenidadesAñadidas.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value?.ToString() == comboAmenidad.Text)
                {
                    MessageBox.Show("Esta amenidad ya fue añadida a este tipo de habitación.");
                    return;
                }
            }

            dgvAmenidadesAñadidas.Rows.Add(comboAmenidad.Text);
        }

        private void comboTipohabitacionAmenidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboTipohabitacionAmenidad.SelectedIndex < 0)
            {
                return; // No hay selección válida
            }
            dgvAmenidadesAñadidas.Rows.Clear();
            comboAmenidad.SelectedIndex = -1;

            amenidad.Clear();
            amenidadesNoEnHabitacion.Clear();

            AmenidadDAO amenidadDAO = new AmenidadDAO();
            Guid idTipoHabitacion = Guid.Empty;

            foreach (var item in tipoHabitacion)
            {
                if (item.NivelHabitacion == comboTipohabitacionAmenidad.Text)
                {
                    idTipoHabitacion = item.IdTipoHabitacion;
                    foreach (var item2 in item.AmenidadTipoHabitacions)
                    {
                        Amenidad am = new Amenidad();

                        am.Amenidad1 = amenidadDAO.getAmenidadPorId(item2.IdAmenidad);
                        amenidad.Add(am);
                    }
                    break;
                }

            }

            amenidadesNoEnHabitacion = amenidadDAO.getAmenidadesNoEnTipoHabitacion(idTipoHabitacion);
            comboAmenidad.Items.Clear(); // Limpiar el combo antes de llenarlo

            foreach (var item in amenidadesNoEnHabitacion)
            {
                comboAmenidad.Items.Add(item.Amenidad1);
            }

            llenarGridAmenidadesExistentes(amenidad);
        }
        private void btnInsertAmenidades_Click(object sender, EventArgs e)
        {
            TipoHabitacion tipoHabitacionToInsert = 
            tipoHabitacion.Find(x => x.NivelHabitacion == comboTipohabitacionAmenidad.Text);

            Guid idTipoHabitacion = tipoHabitacionToInsert.IdTipoHabitacion;

            List<Amenidad> amenidadesToInsert = new List<Amenidad>();
            
            foreach (DataGridViewRow row in dgvAmenidadesAñadidas.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value.ToString() != null)
                {
                    string amenidadNombre = row.Cells[0].Value.ToString();

                    Amenidad amenidad = amenidadesNoEnHabitacion
                        .FirstOrDefault(x => x.Amenidad1 == amenidadNombre);

                    amenidadesToInsert.Add(amenidad);
                }
            }
            //comboAmenidad.Items.Clear();
            comboAmenidad.SelectedIndex = -1;

            AmenidadDAO amenidadDAO = new AmenidadDAO();
            if (amenidadDAO.insertAmenidadesTipoHabitacion(amenidadesToInsert, idTipoHabitacion))
            {
                MessageBox.Show("Amenidades añadidas correctamente");
                dgvAmenidadesAñadidas.Rows.Clear();

                foreach (var item in amenidadesToInsert)
                {
                    amenidadesNoEnHabitacion.Remove(item); // borrando las amenidades que ya fueron añadidas
                    dgvAmenidadExistentes.Rows.Add(item.Amenidad1); // agregando las amenidades que se acaban de añadir
                    comboAmenidad.Items.Remove(item.Amenidad1); // removiendo las amenidades que ya fueron añadidas
                }

                tipoHabitacionToInsert.AmenidadTipoHabitacions = amenidadDAO.getAmenidadesTipoHabitacion(idTipoHabitacion);

            }
            else
            {
                MessageBox.Show("Error al añadir amenidades");
            }

        }
        private void llenarGridAmenidadesExistentes(List<Amenidad> amenidad) //Mandar a llamar cada que se cambie el comboTipoHab
        {
            dgvAmenidadExistentes.Rows.Clear();
            foreach (var item in amenidad)
            {
                dgvAmenidadExistentes.Rows.Add(item.Amenidad1);
            }
        }

        //Gestion de habitaciones

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            if (comboTipoHabitacion.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un tipo de habitación");
                return;
            }

            foreach (DataGridViewRow row in dgvHabAñadidas.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value?.ToString() == comboTipoHabitacion.Text)
                {
                    if ((row.Cells[0].Value?.ToString() == comboTipoHabitacion.Text) && (row.Cells[1].Value?.ToString() == CantTipoHab.Text))
                    {
                        MessageBox.Show("Esta tipo de habitación ya fue añadida con la misma cantidad.");
                        return;
                    }
                    else
                    {
                        dgvHabAñadidas.Rows.RemoveAt(row.Index); // Eliminar la fila existente
                        MessageBox.Show("Cantidad actualizada.");
                    }
                }
            }

            dgvHabAñadidas.Rows.Add(comboTipoHabitacion.Text, CantTipoHab.Text);
        }

        private void llenarGridHabitacionesExistentes(List<TipoHabitacion> tipoHabitacion)
        {
            foreach (var item in tipoHabitacion)
            {
                dgvHabExistentes.Rows.Add(item.NivelHabitacion, item.AmenidadTipoHabitacions);
            }
        }


        //Gestion de servicios

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            if (comboServicio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un servicio");
                return;
            }

            if (string.IsNullOrEmpty(textPrecioServicio.Text))
            {
                MessageBox.Show("Ingrese un precio");
                return;
            }

            foreach (DataGridViewRow row in dgvServicioAñadido.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value?.ToString() == comboServicio.Text)
                {
                    if (row.Cells[1].Value?.ToString() == textPrecioServicio.Text)
                    {
                        MessageBox.Show("El servicio ya fue agregado con el mismo precio.");
                        return;
                    }
                    else
                    {
                        dgvServicioAñadido.Rows.RemoveAt(row.Index); // Eliminar la fila existente
                        MessageBox.Show("Precio actualizado.");
                    }
                }
            }

            dgvServicioAñadido.Rows.Add(comboServicio.Text, textPrecioServicio.Text);
        }

        private void llenarGridServiciosExistentes(List<Servicio> servicio)
        {
            foreach (var item in servicio)
            {
                dgvServicioExistente.Rows.Add(item.Nombre);
            }
        }
        private void llenarComboServicios(List<Servicio> servicioNoHotel)
        {
            foreach (var item in servicioNoHotel)
            {
                comboServicio.Items.Add(item.Nombre);
            }
        }
        private void textPrecioServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y teclas de control como backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla presionada
                MessageBox.Show("Por favor, ingrese solo números.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnBusquedaHotel_Click(object sender, EventArgs e)
        {
            //Vaciar grids, botones y combos
            dgvAmenidadExistentes.Rows.Clear();
            dgvHabExistentes.Rows.Clear();
            dgvServicioExistente.Rows.Clear();
            dgvServicioAñadido.Rows.Clear();
            dgvAmenidadesAñadidas.Rows.Clear();
            dgvHabAñadidas.Rows.Clear();

            comboTipohabitacionAmenidad.SelectedIndex = -1;
            comboTipoHabitacion.SelectedIndex = -1;
            comboAmenidad.SelectedIndex = -1;
            comboServicio.SelectedIndex = -1;

            comboAmenidad.Items.Clear();
            comboTipoHabitacion.Items.Clear();
            comboTipohabitacionAmenidad.Items.Clear();
            comboServicio.Items.Clear();


            textPrecioServicio.Clear();

            //Objetos
            HotelDAO hotelDAO = new HotelDAO();
            TipoHabitacionDAO tipoHabitacionDAO = new TipoHabitacionDAO();
            AmenidadDAO amenidadDAO = new AmenidadDAO();
            ServicioDAO servicioDAO = new ServicioDAO();

            idHotel = hotelDAO.getIdHotel(comboCiudad.Text, textNombreHotel.Text);


            if (idHotel != Guid.Empty)
            {
                NumPisos.Minimum = hotelDAO.getNumPisosHotel(idHotel); //Actualiza el up/down y bloquea a que no pueda quitar pisos
                tipoHabitacion = tipoHabitacionDAO.getTiposHabitacionPorHotel(idHotel);

                foreach (var item in tipoHabitacion)
                {
                    comboTipoHabitacion.Items.Add(item.NivelHabitacion);
                    comboTipohabitacionAmenidad.Items.Add(item.NivelHabitacion);

                    item.AmenidadTipoHabitacions = amenidadDAO.getAmenidadesTipoHabitacion(item.IdTipoHabitacion);
                }

                servicio = servicioDAO.getServiciosHotel(idHotel);
                servicioNoHotel = servicioDAO.getServiciosNoHotel(idHotel);
            }
            else
            {
                return;
            }

            llenarGridServiciosExistentes(servicio);
            llenarGridHabitacionesExistentes(tipoHabitacion);
            llenarComboServicios(servicioNoHotel);
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Eliminar de grids
        private void dgvHabAñadidas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // Para evitar errores si clickeas en los encabezados
            {
                dgvHabAñadidas.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvAmenidadesAñadidas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1) // Para evitar errores si clickeas en los encabezados
            {
                dgvAmenidadesAñadidas.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvServicioAñadido_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // Para evitar errores si clickeas en los encabezados
            {
                dgvServicioAñadido.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
