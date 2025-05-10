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
    public partial class Facturar : Form
    {
        public Guid idReservacion;

        FacturaDAO facturaDAO = new FacturaDAO();
        DatosPersonaDAO personaDAO = new DatosPersonaDAO();
        HotelDAO hotelDAO = new HotelDAO();
        ReservacionDAO reservacionDAO = new ReservacionDAO();
        DatosFiscalDAO fiscalDAO = new DatosFiscalDAO();
        ClienteDAO clienteDAO = new ClienteDAO();

        Factura factura = new Factura();
        DatosPersona persona = new DatosPersona();
        Hotel hotel = new Hotel();
        Reservacion reservacion = new Reservacion();
        DatosFiscal fiscal = new DatosFiscal();
        Cliente cliente = new Cliente();

        public Facturar(Guid IdReservacion)
        {
            InitializeComponent();
            idReservacion = IdReservacion;
        }
        //Sobrecarga solo para poder acceder desde el menú de reserva de momento
        public Facturar()
        {
            InitializeComponent();
        }

        private void btnBuscarReservacion_Click(object sender, EventArgs e)
        {
            reservacion = reservacionDAO.ObtenerReservacion(idReservacion);
            Guid idComprador = reservacion.IdComprador.Value;
            Guid idHotel = reservacion.IdHotel.Value;

            persona = personaDAO.ObtenerDatosPersona(idComprador);
            hotel = hotelDAO.ObtenerHotel(idHotel);
            fiscal = fiscalDAO.ObtenerDatosFiscal(idComprador);
            cliente = clienteDAO.ObtenerCliente(idComprador);

        }

        //No sirven
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
