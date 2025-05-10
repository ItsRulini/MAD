using MAD.DAO;
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.Models;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel; // Necesario para ListSortDirection

namespace MAD
{
    public partial class Reservar : Form
    {
        private Guid idHotelSeleccionado; // id del hotel seleccionado
        private Guid idComprador;
        private Guid idVendedor;

        private string precioNocheHabitacion;
        private string precioPersonaHabitacion;

        private double subtotal;
        private double iva;
        private double total;

        DataGridViewCell subtotalCelda;
        DataGridViewCell ivaCelda;
        DataGridViewCell totalCelda;


        public Reservar(Guid idUsuario)
        {
            InitializeComponent();
            inicializarComboPagos();
            inicializarComboCiudades();

            idVendedor = idUsuario;

            inicializarGridCarrito();
        }

        private void inicializarGridCarrito()
        {
            subtotal = 0;
            iva = 0;
            total = 0;

            // Primero agregas las filas y guardas el índice
            int filaSubtotal = dgvCarritoReserva.Rows.Add("Subtotal", "$" + subtotal + " MXN");
            int filaIVA = dgvCarritoReserva.Rows.Add("IVA", "$" + subtotal * 0.16 + " MXN");
            int filaTotal = dgvCarritoReserva.Rows.Add("Total", "$" + subtotal * 1.16 + " MXN");

            // Ahora sí obtienes las celdas que quieras modificar luego
            subtotalCelda = dgvCarritoReserva.Rows[filaSubtotal].Cells[1]; // Columna 1: el monto
            ivaCelda = dgvCarritoReserva.Rows[filaIVA].Cells[1];
            totalCelda = dgvCarritoReserva.Rows[filaTotal].Cells[1];
        }

        private void ResetForm(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 1;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
                else if (control is DataGridView)
                {
                    ((DataGridView)control).Rows.Clear();
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control.HasChildren)
                {
                    // Si el control contiene otros controles (como GroupBox, Panel, TabPage)
                    ResetForm(control);
                }
            }
        }



        private void inicializarComboCiudades()
        {
            UbicacionDAO ubicacionDAO = new UbicacionDAO();

            List<Ubicacion> ciudades = ubicacionDAO.getCiudadesHotel();

            foreach (Ubicacion ci in ciudades)
            {
                comboCiudadReserva.Items.Add(ci.Ciudad);
            }

        }
        private void inicializarComboPagos()
        {
            comboMetodoPago.Items.Add("Efectivo");
            comboMetodoPago.Items.Add("Tarjeta");
            comboMetodoPago.Items.Add("Transferencia");
        }

        private void incializarGridHotelesDisponibles()
        {
            HotelDAO hotelDAO = new HotelDAO();

            DateOnly inicio = DateOnly.FromDateTime(dtpDesde.Value);
            DateOnly fin = DateOnly.FromDateTime(dtpHasta.Value);

            List<Hotel> hoteles = hotelDAO.getHotelesDisponibles(inicio, fin, comboCiudadReserva.Text);

            foreach (Hotel hotel in hoteles)
            {
                dgvHoteles.Rows.Add(hotel.Nombre, hotel.IdHotel);
            }
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reservar FReservar = new Reservar();
            //this.Hide();
            //FReservar.ShowDialog();
            //this.Show();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaServicios FVentaServicios = new VentaServicios();
            this.Hide();
            FVentaServicios.ShowDialog();
            ResetForm(this);
            inicializarGridCarrito();
            this.Show();
        }

        private void checkInCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInOut FCheckInOut = new CheckInOut();
            this.Hide();
            FCheckInOut.ShowDialog();
            ResetForm(this);
            inicializarGridCarrito();
            this.Show();
            //CALAR
            if(FCheckInOut.DialogResult == DialogResult.OK)
            {
                Facturar FFacturar = new Facturar();
                this.Hide();
                FFacturar.ShowDialog();
                ResetForm(this);
                inicializarGridCarrito();
                this.Show();
            }
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //QUITAR AL TERMINAR DE DARLE FUNCIONALIDAD

            Facturar FFacturar = new Facturar();
            this.Hide();
            FFacturar.ShowDialog();
            ResetForm(this);
            inicializarGridCarrito();
            this.Show();
        }


        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AggCliente FAgregarCliente = new AggCliente();
            this.Hide();
            FAgregarCliente.ShowDialog();
            ResetForm(this);
            inicializarGridCarrito();
            this.Show();
        }

        private void modificarEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModElimCliente FModElimCliente = new ModElimCliente();
            this.Hide();
            FModElimCliente.ShowDialog();
            ResetForm(this);
            inicializarGridCarrito();
            this.Show();
        }


        private void btnAggCarrito_Click(object sender, EventArgs e)
        {

            if (comboHabitacion.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de habitación");
                return;
            }

            string tipoHabitacion = comboHabitacion.Text;
            TipoHabitacionDAO tipoHab = new TipoHabitacionDAO();
            Dictionary<TipoHabitacion, Amenidad> precio = tipoHab.getCaracteristicas(tipoHabitacion, idHotelSeleccionado);



            int? cantidadMaxina = precio.FirstOrDefault().Key.CanidadMaximaPersonas;

            if (numeroPersonas.Value > cantidadMaxina)
            {
                MessageBox.Show("La cantidad máxima de personas es de: " + cantidadMaxina);
                return;
            }


            subtotal += Math.Round(double.Parse(precio.FirstOrDefault().Key.PrecioPorNoche.ToString()));
            iva = Math.Round(subtotal * 0.16);
            total = Math.Round(iva + subtotal);

            subtotalCelda.Value = "$" + subtotal + " MXN";
            ivaCelda.Value = "$" + iva + " MXN";
            totalCelda.Value = "$" + total + " MXN";

            // Insertar la nueva fila en la posición 0
            dgvCarritoReserva.Rows.Insert(0, comboHabitacion.Text, numeroPersonas.Value);


            int numeroHabitacionesDelTipo = 0;

            foreach (DataGridViewRow row in dgvCarritoReserva.Rows)
            {
                if (row.IsNewRow) continue; // Ignorar la fila nueva en DataGridView si está habilitada
                string tipo = row.Cells[0].Value.ToString();
                if (tipo == tipoHabitacion)
                {
                    numeroHabitacionesDelTipo++;
                }
            }

            HabitacionDAO habitacionDAO = new HabitacionDAO();
            int cantidadHabitaciones = habitacionDAO.getCantidadTipoHabitacion_Hotel(idHotelSeleccionado, tipoHabitacion, dtpDesde.Value, dtpHasta.Value);

            if (numeroHabitacionesDelTipo > cantidadHabitaciones)
            {
                MessageBox.Show("No hay habitaciones disponibles de este tipo");
                dgvCarritoReserva.Rows.RemoveAt(0);
                subtotal -= Math.Round(double.Parse(precio.FirstOrDefault().Key.PrecioPorNoche.ToString()));
                iva = Math.Round(subtotal * 0.16);
                total = Math.Round(iva + subtotal);
                subtotalCelda.Value = "$" + subtotal + " MXN";
                ivaCelda.Value = "$" + iva + " MXN";
                totalCelda.Value = "$" + total + " MXN";
                return;
            }
            else
            {
                MessageBox.Show("Articulo agregado al carrito.");
            }


            
            comboHabitacion.SelectedIndex = -1;
            textDetallesHab.Clear();


            if (dgvCarritoReserva.Rows.Count == 4)
            {
                //dgvHoteles.Rows.Clear();
                // Iterar desde el final hacia el principio para evitar problemas al eliminar filas
                for (int i = dgvHoteles.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow fila = dgvHoteles.Rows[i];

                    // Verificar si la fila no está seleccionada
                    if (fila.Cells[1].Value.ToString() != idHotelSeleccionado.ToString())
                    {
                        dgvHoteles.Rows.RemoveAt(i);
                    }
                }
            }

        }

        private void textAnticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y teclas de control como backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla presionada
                MessageBox.Show("Por favor, ingrese solo números.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnComprarReserva_Click(object sender, EventArgs e)
        {
            if (comboMetodoPago.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un método de pago");
                return;
            }

            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }

            if (dgvCarritoReserva.Rows.Count == 3)
            {
                MessageBox.Show("No hay artículos en el carrito");
                return;
            }

            if (string.IsNullOrEmpty(textAnticipo.Text))
            {
                MessageBox.Show("El anticipo no puede estar vacío");
                return;
            }

            //decimal.Parse(row.Cells[1].Value.ToString().Replace("$", "").Replace("MXN", ""));
            if (decimal.Parse(textAnticipo.Text.ToString())
                > decimal.Parse(totalCelda.Value.ToString().Replace("$","").Replace(" MXN", "")))
            {
                MessageBox.Show("El anticipo no puede ser mayor al total de su cuenta");
                return;
            }

            HabitacionDAO habitacionDAO = new HabitacionDAO();

            // Diccionary para almacenar las habitaciones y su cantidad
            Dictionary<Guid, int> tipoHabitaciones = new Dictionary<Guid, int>();
            TipoHabitacionDAO tipoHabitacionDAO = new TipoHabitacionDAO();
            TipoHabitacion tipoHabitacion = new TipoHabitacion();

            foreach (DataGridViewRow row in dgvCarritoReserva.Rows)
            {
                if (row.IsNewRow) continue; // Ignorar la fila nueva en DataGridView si está habilitada

                string tipo = row.Cells[0].Value.ToString();
                
                if (!string.IsNullOrEmpty(tipo))
                {
                    if (tipo == "Subtotal" || tipo == "IVA" || tipo == "Total")
                    {
                        continue; // Ignoranos las filas de subtotal, IVA y total
                    }

                    Guid tipoHabitacionKey = new Guid();
                    tipoHabitacionKey = tipoHabitacionDAO.getIdTipoHabitacion(tipo, idHotelSeleccionado);

                    if (tipoHabitaciones.ContainsKey(tipoHabitacionKey))
                    {
                        Guid claveExistente = tipoHabitaciones.Keys.First(k => k.Equals(tipoHabitacionKey));
                        tipoHabitaciones[claveExistente]++;
                    }
                    else
                    {
                        tipoHabitaciones[tipoHabitacionKey] = 1;
                    }
                }
            }

            List<Habitacion> habitaciones = habitacionDAO.getHabitacionesParaReservar(idHotelSeleccionado, tipoHabitaciones, dtpDesde.Value, dtpHasta.Value);

            DataGridViewRow[] filas = { };


            int numFilasAExcluir = 3;
            List<object[]> datosFilasExcluidas = new List<object[]>();

            int indiceUltimaFilaDeDatos = dgvCarritoReserva.Rows.Count - 1;
            if (dgvCarritoReserva.AllowUserToAddRows && indiceUltimaFilaDeDatos >= 0 && dgvCarritoReserva.Rows[indiceUltimaFilaDeDatos].IsNewRow)
            {
                indiceUltimaFilaDeDatos--;
            }

            if (indiceUltimaFilaDeDatos + 1 >= numFilasAExcluir)
            {
                for (int i = 0; i < numFilasAExcluir; i++)
                {
                    DataGridViewRow filaACapturar = dgvCarritoReserva.Rows[indiceUltimaFilaDeDatos - numFilasAExcluir + 1 + i];

                    // Guardar los valores de las celdas de esta fila.
                    object[] valoresCelda = new object[filaACapturar.Cells.Count];
                    for (int j = 0; j < filaACapturar.Cells.Count; j++)
                    {
                        valoresCelda[j] = filaACapturar.Cells[j].Value;
                    }
                    datosFilasExcluidas.Add(valoresCelda);
                }

                for (int i = 0; i < numFilasAExcluir; i++)
                {
                    // Recalcular el índice de la última fila de datos antes de cada eliminación.
                    int indiceRealUltimaFila = dgvCarritoReserva.Rows.Count - 1;
                    if (dgvCarritoReserva.AllowUserToAddRows && indiceRealUltimaFila >= 0 && dgvCarritoReserva.Rows[indiceRealUltimaFila].IsNewRow)
                    {
                        indiceRealUltimaFila--;
                    }

                    if (indiceRealUltimaFila >= 0) // Asegurarse de que aún hay filas de datos para eliminar.
                    {
                        dgvCarritoReserva.Rows.RemoveAt(indiceRealUltimaFila);
                    }
                    else
                    {
                        break; // No hay más filas de datos para eliminar.
                    }
                }
            }

            if (dgvCarritoReserva.Columns.Count > 0) // Asegurarse de que haya al menos una columna
            {
                dgvCarritoReserva.Sort(dgvCarritoReserva.Columns[0], ListSortDirection.Ascending);
            }

            if (datosFilasExcluidas.Any()) // Verifica si la lista tiene elementos.
            {
                foreach (object[] dataFila in datosFilasExcluidas)
                {
                    // Añade una nueva fila al final del DataGridView con los datos guardados.
                    dgvCarritoReserva.Rows.Add(dataFila);
                }
            }

            indiceUltimaFilaDeDatos = dgvCarritoReserva.Rows.Count - 1;
            if (dgvCarritoReserva.AllowUserToAddRows && indiceUltimaFilaDeDatos >= 0 && dgvCarritoReserva.Rows[indiceUltimaFilaDeDatos].IsNewRow)
            {
                indiceUltimaFilaDeDatos--;
            }

            subtotalCelda = dgvCarritoReserva.Rows[indiceUltimaFilaDeDatos - 2].Cells[1]; // Columna 1: el monto
            ivaCelda = dgvCarritoReserva.Rows[indiceUltimaFilaDeDatos - 1].Cells[1];
            totalCelda = dgvCarritoReserva.Rows[indiceUltimaFilaDeDatos].Cells[1];


            Dictionary<Habitacion, int> habitacionesReservadas = new Dictionary<Habitacion, int>();

            foreach (DataGridViewRow row in dgvCarritoReserva.Rows)
            {
                if (row.IsNewRow) continue; // Ignorar la fila nueva en DataGridView si está habilitada

                string tipo = row.Cells[0].Value.ToString();

                if (tipo == "Subtotal" || tipo == "IVA" || tipo == "Total")
                {
                    continue; // Ignoranos las filas de subtotal, IVA y total
                }

                int cantidad = int.Parse(row.Cells[1].Value.ToString());
                if (!string.IsNullOrEmpty(tipo))
                {

                    habitacionesReservadas.Add(habitaciones.FirstOrDefault(), cantidad);
                    habitaciones.Remove(habitaciones.FirstOrDefault());
                }
            }

            DatosPersonaDAO datosPersonaDAO = new DatosPersonaDAO();

            if (comboBox1.Text.Contains("@"))
            {
                idComprador = datosPersonaDAO.getIdPersonaPorCorreo(comboBox1.Text);
            }
            else
            {
                string nombreCompleto = comboBox1.Text;
                string[] partesNombre = nombreCompleto.Split(' ');

                if(partesNombre.Length > 3)
                {
                    partesNombre[0] = partesNombre[0] + " " + partesNombre[1];
                    partesNombre[1] = partesNombre[2];
                    partesNombre[2] = partesNombre[3];

                }

                idComprador = datosPersonaDAO.getIdPersonaPorApellidos(partesNombre[0], partesNombre[1], partesNombre[2]);
            }


            Reservacion reservacion = new Reservacion();
            reservacion.IdReservacion = Guid.NewGuid();
            reservacion.IdComprador = idComprador;
            reservacion.IdVendedor = idVendedor;
            reservacion.IdHotel = idHotelSeleccionado;
            reservacion.MetodoPago = comboMetodoPago.Text;
            reservacion.Anticipo = decimal.Parse(textAnticipo.Text);
            reservacion.MontoTotal = decimal.Parse(total.ToString());
            reservacion.FechaInicioHospedaje = DateOnly.FromDateTime(dtpDesde.Value);
            reservacion.FechaFinHospedaje = DateOnly.FromDateTime(dtpHasta.Value);

            // Llamar al pop-up de confirmación
            ConfirmarReserva confirmarReserva = new ConfirmarReserva(reservacion, habitacionesReservadas);
            confirmarReserva.ShowDialog();

            if(confirmarReserva.DialogResult == DialogResult.OK)
            {
                dgvCarritoReserva.Rows.Clear();
                comboBox1.Items.Clear();
                textAnticipo.Clear();
                textBox1.Clear();
                textDetallesHab.Clear();
                inicializarGridCarrito();
            }

        }

        private void comboHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboHabitacion.SelectedIndex == -1)
                return;

            textDetallesHab.Text = "";
            TipoHabitacionDAO tipoDAO = new TipoHabitacionDAO();
            Dictionary<TipoHabitacion, Amenidad> caracteristicas = tipoDAO.getCaracteristicas(comboHabitacion.Text, idHotelSeleccionado); //:::::::::::::::::

            StringBuilder caracteristicasStrs = new StringBuilder();

            string precioNoche = caracteristicas.FirstOrDefault().Key.PrecioPorNoche.ToString().Trim();
            string precioPersona = caracteristicas.FirstOrDefault().Key.PrecioPorPersona.ToString().Trim();
            string cantPersonas = caracteristicas.FirstOrDefault().Key.CanidadMaximaPersonas.ToString().Trim();

            precioNocheHabitacion = precioNoche;
            precioPersonaHabitacion = precioPersona;

            caracteristicasStrs.Append("Precio por persona: $" + precioPersona + " MXN\n");
            caracteristicasStrs.Append("Precio por noche: $" + precioNoche + " MXN\n");
            caracteristicasStrs.Append("Personas máximas permitidas: " + cantPersonas + "\n");
            caracteristicasStrs.AppendLine("Amenidades:\n");

            foreach (var item in caracteristicas)
            {
                caracteristicasStrs.AppendLine(item.Value.Amenidad1 + "\n");
            }

            caracteristicasStrs.AppendLine("PRECIOS NO INCLUYEN IVA.");

            textDetallesHab.Text = caracteristicasStrs.ToString();
        }

        private void llenarComboHabitaciones()
        {
            DateOnly inicio = DateOnly.FromDateTime(dtpDesde.Value);
            DateOnly fin = DateOnly.FromDateTime(dtpHasta.Value);
            Guid id = Guid.Parse(dgvHoteles.CurrentRow.Cells[1].Value.ToString());

            TipoHabitacionDAO tipoDAO = new TipoHabitacionDAO();
            List<TipoHabitacion> habitaciones = tipoDAO.getTiposHabitacionPorHotel(inicio, fin, id);
            foreach (TipoHabitacion habitacion in habitaciones)
            {
                comboHabitacion.Items.Add(habitacion.NivelHabitacion);
            }
        }
        private void dgvHoteles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Seleccionado: " + dgvHoteles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            idHotelSeleccionado = Guid.Parse(dgvHoteles.Rows[e.RowIndex].Cells[1].Value.ToString());
            comboHabitacion.Items.Clear();
            llenarComboHabitaciones();
        }

        private void llenarComboCliente(List<string> clientes)
        {
            foreach (string cliente in clientes)
            {
                comboBox1.Items.Add(cliente);
            }
        }
        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {

        }



        //No sirve
        private void label5_Click(object sender, EventArgs e)
        {

        }
        //No sirve
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e) {/*no sirve*/}

        // Eliminar del carrito un item
        private void dgvCarritoReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != subtotalCelda.RowIndex && e.RowIndex != ivaCelda.RowIndex
                && e.RowIndex != totalCelda.RowIndex) // Para evitar errores si clickeas en los encabezados
            {
                TipoHabitacionDAO tipoHab = new TipoHabitacionDAO();
                Dictionary<TipoHabitacion, Amenidad> precio = tipoHab.getCaracteristicas((dgvCarritoReserva.Rows[e.RowIndex].Cells[0].Value?.ToString()), idHotelSeleccionado);

                subtotal -= Math.Round(double.Parse(precio.FirstOrDefault().Key.PrecioPorNoche.ToString()));
                iva = Math.Round(subtotal * 0.16);
                total = Math.Round(iva + subtotal);

                subtotalCelda.Value = "$" + subtotal + " MXN";
                ivaCelda.Value = "$" + iva + " MXN";
                totalCelda.Value = "$" + total + " MXN";

                dgvCarritoReserva.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            List<string> persona = new List<string>();
            DatosPersonaDAO personaDAO = new DatosPersonaDAO();

            comboBox1.SelectedIndex = -1; // Limpiar el combo de clientes
            comboBox1.Items.Clear(); // Limpiar el combo de clientes
            comboHabitacion.SelectedIndex = -1;
            comboHabitacion.Items.Clear();
            dgvHoteles.Rows.Clear();

            //Limpia carrito cada que buscar y lo vuelve a inicializar
            dgvCarritoReserva.Rows.Clear();
            inicializarGridCarrito();

            if (dtpDesde.Value.Date < DateTime.Today || dtpHasta.Value.Date < dtpDesde.Value.Date)
            {
                MessageBox.Show("Fechas inválidas");
                return;
            }


            if (checkBuscarPorApellido.Checked) // búsqueda por apellidos  
            {
                // Fixing the declaration of the array and assignment  
                string[] apellidos = textBox1.Text.Split(' ');

                // Ensure we pass the required arguments to the method  
                if (apellidos.Length >= 2)
                {
                    persona = personaDAO.busquedaAvanzadaApellidos(apellidos[0], apellidos[1]);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese ambos apellidos separados por un espacio.");
                    return;
                }
            }
            else // rfc o correo  
            {
                persona = personaDAO.busquedaAvanzadaCliente(textBox1.Text);
            }

            if (persona.FirstOrDefault() == "Cliente no encontrado")
            {
                MessageBox.Show("Cliente no encontrado");
                return;
            }

            llenarComboCliente(persona);
            incializarGridHotelesDisponibles();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener id del usuario seleccionado
            //XDeclaration;1
        }
        private void comboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCiudadReserva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
