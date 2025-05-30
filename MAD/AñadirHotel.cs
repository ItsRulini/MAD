﻿using MAD.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
            comboServicio.Items.Clear();
            ServicioDAO servicioDAO = new ServicioDAO();
            List<Servicio> servicios = servicioDAO.getServicios();

            foreach (Servicio servicio in servicios)
            {
                comboServicio.Items.Add(servicio.Nombre);
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
            Dictionary<TipoHabitacion, int> mapTipoHabitaciones = new Dictionary<TipoHabitacion, int>();

            dtpInicioOperacion.MinDate = DateTime.Now; // Establecer la fecha mínima a la fecha actual

            if (dtpInicioOperacion.Value < dtpInicioOperacion.MinDate)
            {
                MessageBox.Show("La fecha de inicio de operaciones no puede ser anterior a la fecha actual.");
                return;
            }

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

            foreach (DataGridViewRow row in gridHabitaciones.Rows)
            {
                if (!row.IsNewRow)
                {

                    TipoHabitacion tipoEncontrado =
                    tipoHabitaciones.Find(x => x.NivelHabitacion == row.Cells[0].Value.ToString());

                    if (tipoEncontrado != null) // Verifica si el tipo de habitación existe
                    {
                        int cantidad = Convert.ToInt32(row.Cells[1].Value);

                        mapTipoHabitaciones.Add(tipoEncontrado, cantidad);
                    }

                }
            }

            hotel.IdHotel = Guid.NewGuid(); // id del hotel
            hotel.IdUsuario = idAdmin; // id del admin que lo creo

            HotelDAO hotelDAO = new HotelDAO();
            hotelDAO.insertHotel(hotel); // insertando el hotel


            TipoHabitacionDAO tipoHabitacionDAO = new TipoHabitacionDAO();

            foreach (var item in mapTipoHabitaciones)
            {
                DataTable cama = new DataTable();
                cama.Columns.Add("tipoCama", typeof(string));
                cama.Columns.Add("cantidadCama", typeof(int));

                foreach (var camaTipo in item.Key.CamaTipoHabitacions)
                {
                    cama.Rows.Add(camaTipo.TipoCama, camaTipo.CantidadCama);
                }

                tipoHabitacionDAO.insertTipoHabitacion(item.Key, hotel.IdHotel, cama); // insertando los tipos de habitación
            }

            // Insertar los servicios del hotel
            bool insertado = hotelDAO.insertInfoHotel(hotel, servicios, mapTipoHabitaciones);

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

        private bool EsPrecioValido(string precio)
        {
            // Verifica que el precio contenga solo dígitos y un punto decimal
            int countPuntos = precio.Count(c => c == '.');
            if (countPuntos > 1) return false;

            // Intenta convertir el precio a un número decimal
            return decimal.TryParse(precio, out _);
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

            // Validar que el precio sea un número válido con un solo punto decimal
            if (!EsPrecioValido(textPrecioServicio.Text))
            {
                MessageBox.Show("El precio debe ser un número válido y puede contener solo un punto decimal.");
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
                        MessageBox.Show("Cantidad actualizada.");
                    }
                }
            }

            //AmenidadDAO amenidadDAO = new AmenidadDAO();
            //List<Amenidad> amenidades = amenidadDAO.getAmenidadesTipoHabitacion(comboTipoHab.Text);

            StringBuilder amenidadesSeleccionadas = new StringBuilder();
            AmenidadDAO amenidadDAO = new AmenidadDAO();

            tipoHabitaciones.Find(x => x.NivelHabitacion == comboTipoHab.Text).AmenidadTipoHabitacions.ToList().ForEach(amenidad =>
            {
                string nombreAmenidad = amenidadDAO.getAmenidadPorId(amenidad.IdAmenidad);
                amenidadesSeleccionadas.Append(nombreAmenidad + Environment.NewLine);
            });

            gridHabitaciones.Rows.Add(comboTipoHab.Text, cantHab.Value, amenidadesSeleccionadas.ToString());

        }
        private void gridHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3) // Para evitar errores si clickeas en los encabezados
            {
                gridHabitaciones.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void gridServiciosHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // Para evitar errores si clickeas en los encabezados
            {
                gridServiciosHotel.Rows.RemoveAt(e.RowIndex);
            }
        }

        private List<TipoHabitacion> tipoHabitaciones;
        private void btnConfigurarHabitaciones_Click(object sender, EventArgs e)
        {
            if (comboTipoHab.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                "¿Está seguro que desea agregar más configuraciones? \nSe perderán las ya existentes",
                "Advertencia",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
                );

                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    // Si el usuario da "No" o "Cancelar", NO seguimos
                    return;
                }

            }

            comboTipoHab.SelectedIndex = -1; // Limpiar la selección actual
            comboTipoHab.Items.Clear();
            gridHabitaciones.Rows.Clear(); // Limpiar el DataGridView antes de llenarlo
            cantHab.Value = 1;

            ConfigurarHabitaciones configurarHabitaciones = new ConfigurarHabitaciones();
            if (configurarHabitaciones.ShowDialog() == DialogResult.OK)
            {
                tipoHabitaciones = configurarHabitaciones.habitacionesTemp;
                foreach (var item in tipoHabitaciones)
                {
                    comboTipoHab.Items.Add(item.NivelHabitacion);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AñadirServicio formAddServicio = new AñadirServicio();
            formAddServicio.ShowDialog();
            this.Focus();
            inicializarComboServicios();
        }

        private void comboTipoHab_SelectedIndexChanged(object sender, EventArgs e)
        {

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

    }
}
