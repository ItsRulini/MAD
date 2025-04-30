using MAD.DAO;
using MAD.Models;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MAD
{
    public partial class AñadirHotel : Form
    {
        private Guid idAdmin; // Almacena el ID del administrador
        public AñadirHotel(Guid idAdmin)
        {
            InitializeComponent();
            inicializarComboUbicacion();
            inicializarComboServicios();
            inicializarComboTipoHabitacion();

            //gridHabitaciones.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //gridHabitaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.idAdmin = idAdmin;
            comboPais.Enabled = true; //Pais
            comboEstado.Enabled = false; //Estado
            comboCiudad.Enabled = false; //Ciudad
        }
        private void AñadirHotel_Load(object sender, EventArgs e)
        {

        }

        private void inicializarComboServicios()
        {
            ServicioDAO servicioDAO = new ServicioDAO();
            List<Servicio> servicios = servicioDAO.getServicios();

            foreach (Servicio servicio in servicios)
            {
                comboServicio.Items.Add(servicio.Nombre);
            }
        }

        private void inicializarComboTipoHabitacion()
        {
            TipoHabitacionDAO tipoHabitacionDAO = new TipoHabitacionDAO();
            List<TipoHabitacion> tiposHabitacion = tipoHabitacionDAO.getTiposHabitacion();

            foreach (TipoHabitacion tipoHabitacion in tiposHabitacion)
            {
                comboTipoHab.Items.Add(tipoHabitacion.NivelHabitacion);
            }
        }

        private void inicializarComboUbicacion()
        {
            UbicacionDAO ubicacionDAO = new UbicacionDAO();

            List<Ubicacion> paises = ubicacionDAO.getPaises();

            foreach (Ubicacion ubicacion in paises)
            {
                comboPais.Items.Add(ubicacion.Pais);
            }

        }
        private void llenarEstados()
        {
            comboEstado.Items.Clear();
            comboCiudad.Items.Clear();
            UbicacionDAO ubicacionDAO = new UbicacionDAO();
            List<Ubicacion> estados = ubicacionDAO.getEstados(comboPais.Text);
            foreach (Ubicacion ubicacion in estados)
            {
                comboEstado.Items.Add(ubicacion.Estado);
            }
        }
        private void comboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarEstados();
            comboEstado.Enabled = true; //Estado
        }

        private void llenarCiudades()
        {
            comboCiudad.Items.Clear();
            UbicacionDAO ubicacionDAO = new UbicacionDAO();
            List<Ubicacion> ciudades = ubicacionDAO.getCiudades(comboEstado.Text);
            foreach (Ubicacion ubicacion in ciudades)
            {
                comboCiudad.Items.Add(ubicacion.Ciudad);
            }
        }
        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCiudades();
            comboCiudad.Enabled = true; //Ciudad
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarHotel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboPais.Text) || string.IsNullOrEmpty(comboEstado.Text) || string.IsNullOrEmpty(comboCiudad.Text))
            {
                MessageBox.Show("La ubicación no puede estar vacía.");
                return;
            }

            if (string.IsNullOrEmpty(textNombreHotel.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textCalle.Text)
                || string.IsNullOrEmpty(cantPisos.Value.ToString()) || string.IsNullOrEmpty(textNumero.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacíos.");
                return;
            }

            if (gridServiciosHotel.Rows.Count == 0)
            {
                MessageBox.Show("No se han agregado servicios.");
                return;
            }

            if (gridHabitaciones.Rows.Count == 0)
            {
                MessageBox.Show("No se han agregado habitaciones.");
                return;
            }

            Hotel hotel = new Hotel();
            List<HotelServicio> servicios = new List<HotelServicio>();
            Dictionary<TipoHabitacion, int> tipoHabitaciones = new Dictionary<TipoHabitacion, int>();

            hotel.Rfc = textBox1.Text;
            hotel.Nombre = textNombreHotel.Text;
            hotel.Domicilio = textCalle.Text + " " + textNumero.Text;
            hotel.NumeroPisos = Convert.ToInt32(cantPisos.Value);
            hotel.FechaInicioOperaciones = DateOnly.FromDateTime(dtpInicioOperacion.Value);

            UbicacionDAO ubicacionDAO = new UbicacionDAO();
            hotel.IdUbicacion = ubicacionDAO.getIdUbicacion(comboCiudad.Text);

            ServicioDAO servicioDAO = new ServicioDAO();

            foreach (DataGridViewRow row in gridServiciosHotel.Rows)
            {
                if (!row.IsNewRow)
                {
                    HotelServicio hotelServicio = new HotelServicio();
                    hotelServicio.IdServicio = servicioDAO.getIdServicio(row.Cells[0].Value.ToString());
                    hotelServicio.Precio = decimal.Parse(row.Cells[1].Value.ToString().Replace("$", "").Replace(" MXN", ""));
                    servicios.Add(hotelServicio);
                }
            }

            TipoHabitacionDAO tipoHabitacionDAO = new TipoHabitacionDAO();

            foreach (DataGridViewRow row in gridHabitaciones.Rows)
            {
                if (!row.IsNewRow)
                {
                    TipoHabitacion tipoHabitacion = new TipoHabitacion();

                    tipoHabitacion.IdTipoHabitacion = tipoHabitacionDAO.getIdTipoHabitacion(row.Cells[0].Value.ToString());
                    int cantidad = Convert.ToInt32(row.Cells[1].Value);

                    tipoHabitaciones.Add(tipoHabitacion, cantidad);
                }
            }

            HotelDAO hotelDAO = new HotelDAO();
            bool insertado = hotelDAO.insertHotel(hotel, servicios, tipoHabitaciones, idAdmin);

            if (insertado)
            {
                MessageBox.Show("Hotel agregado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el hotel.");
            }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            bool seleccionado = comboServicio.SelectedIndex < 0 ? false : true;

            if (!seleccionado)
            {
                MessageBox.Show("Seleccione un servicio");
                return;
            }

            if (seleccionado == true && string.IsNullOrEmpty(textPrecioServicio.Text))
            {
                MessageBox.Show("El precio del servicio no puede estar vacío.");
                return;
            }


            // Validar si el servicio ya fue agregado
            foreach (DataGridViewRow row in gridServiciosHotel.Rows)
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
                        gridServiciosHotel.Rows.RemoveAt(row.Index); // Eliminar la fila existente
                        MessageBox.Show("Precio actualizado.");
                    }
                }
            }


            gridServiciosHotel.Rows.Add(comboServicio.Text, '$' + textPrecioServicio.Text + " MXN");

        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            bool seleccionado = comboTipoHab.SelectedIndex < 0 ? false : true;

            if (!seleccionado)
            {
                MessageBox.Show("Seleccione un tipo de habitación");
                return;
            }

            foreach (DataGridViewRow row in gridHabitaciones.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value?.ToString() == comboTipoHab.Text)
                {
                    if (row.Cells[1].Value?.ToString() == cantHab.Value.ToString())
                    {
                        MessageBox.Show("El tipo de habitación ya fue agregado con la misma cantidad.");
                        return;
                    }
                    else
                    {
                        gridHabitaciones.Rows.RemoveAt(row.Index); // Eliminar la fila existente
                        MessageBox.Show("Cantidad actualizado.");
                    }
                }
            }

            AmenidadDAO amenidadDAO = new AmenidadDAO();
            List<Amenidad> amenidades = amenidadDAO.getAmenidadesTipoHabitacion(comboTipoHab.Text);

            StringBuilder amenidadesSeleccionadas = new StringBuilder();

            foreach (Amenidad amenidad in amenidades)
            {
                amenidadesSeleccionadas.Append(amenidad.Amenidad1 + Environment.NewLine);
            }

            gridHabitaciones.Rows.Add(comboTipoHab.Text, cantHab.Value, amenidadesSeleccionadas.ToString());

        }

        private void btnConfigurarHabitaciones_Click(object sender, EventArgs e)
        {
            ConfigurarHabitaciones configurarHabitaciones = new ConfigurarHabitaciones();
            configurarHabitaciones.ShowDialog();
            this.Focus();
        }
    }
}
