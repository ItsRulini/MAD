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

//Para generar el pdf
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

using System.Drawing; // Para Bitmap
using System.IO;       // Para MemoryStream

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
        DatosFiscal fiscalComprador = new DatosFiscal();
        DatosFiscal fiscalHotel = new DatosFiscal();
        Cliente cliente = new Cliente();

        DataTable Tablefactura = new DataTable();

        string subtotal;
        string anticipo;
        string IVA;
        string Total;

        public Facturar(Guid IdReservacion)
        {
            InitializeComponent();
            idReservacion = IdReservacion;
            textIdReservacion.Text = idReservacion.ToString();
        }
        //Sobrecarga solo para poder acceder desde el menú de reserva de momento
        public Facturar()
        {
            InitializeComponent();
        }

        private void btnBuscarReservacion_Click(object sender, EventArgs e)
        {
            idReservacion = Guid.Parse(textIdReservacion.Text);
            reservacion = reservacionDAO.ObtenerReservacion(idReservacion);
            Guid idComprador = reservacion.IdComprador.HasValue ? reservacion.IdComprador.Value : Guid.Empty;
            Guid idHotel = reservacion.IdHotel.HasValue ? reservacion.IdHotel.Value : Guid.Empty;
              
            persona = personaDAO.ObtenerDatosPersona(idComprador);
            hotel = hotelDAO.ObtenerHotel(idHotel);
            fiscalComprador = fiscalDAO.ObtenerDatosFiscal(idComprador);
            fiscalHotel = fiscalDAO.ObtenerDatosFiscal(idHotel);
            cliente = clienteDAO.ObtenerCliente(idComprador);

            Tablefactura = facturaDAO.generarFactura(idReservacion);

            dataGridView1.DataSource = Tablefactura;
            

            subtotal = facturaDAO.GetSubtotalPorReservacion(idReservacion).ToString();
            anticipo = reservacion.Anticipo.ToString();
            IVA      = facturaDAO.GetIVAPorReservacion(idReservacion).ToString();
            Total    = (facturaDAO.GetTotalPorReservacion(idReservacion) - reservacion.Anticipo).ToString();

            textSubTotal.Text = "$" + subtotal + " MXN";
            textAnticipo.Text = "$" + anticipo + " MXN";
            textIVA.Text = "$" + IVA + " MXN";
            textTotal.Text = "$" + Total + " MXN";
        }
        private void button2_Click(object sender, EventArgs e) // Imprimir factura
        {
            
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }

            PreparaFactura(persona, hotel, fiscalComprador, fiscalHotel, cliente, Tablefactura);
        }

        //No sirven
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Facturar_Load(object sender, EventArgs e)
        {

        }

        public static string NumeroALetras(decimal numero)
        {
            string decimales = "";
            var entero = (int)Math.Floor(numero);
            var fraccion = (int)Math.Round((numero - entero) * 100);

            if (fraccion > 0)
            {
                decimales = " CON " + fraccion.ToString() + "/100";
            }

            return NumeroALetras(entero) + decimales;
        }

        private static string NumeroALetras(int numero)
        {
            if (numero == 0) return "CERO";
            if (numero == 1) return "UNO";
            if (numero == 2) return "DOS";
            if (numero == 3) return "TRES";
            if (numero == 4) return "CUATRO";
            if (numero == 5) return "CINCO";
            if (numero == 6) return "SEIS";
            if (numero == 7) return "SIETE";
            if (numero == 8) return "OCHO";
            if (numero == 9) return "NUEVE";
            if (numero == 10) return "DIEZ";
            if (numero == 11) return "ONCE";
            if (numero == 12) return "DOCE";
            if (numero == 13) return "TRECE";
            if (numero == 14) return "CATORCE";
            if (numero == 15) return "QUINCE";
            if (numero < 20) return "DIECI" + NumeroALetras(numero - 10);
            if (numero == 20) return "VEINTE";
            if (numero < 30) return "VEINTI" + NumeroALetras(numero - 20);
            if (numero == 30) return "TREINTA";
            if (numero == 40) return "CUARENTA";
            if (numero == 50) return "CINCUENTA";
            if (numero == 60) return "SESENTA";
            if (numero == 70) return "SETENTA";
            if (numero == 80) return "OCHENTA";
            if (numero == 90) return "NOVENTA";
            if (numero < 100) return NumeroALetras((int)(Math.Floor((decimal)numero / 10) * 10)) + " Y " + NumeroALetras(numero % 10);
            if (numero == 100) return "CIEN";
            if (numero < 200) return "CIENTO " + NumeroALetras(numero - 100);
            if (numero == 200 || numero == 300 || numero == 400 || numero == 600 || numero == 800) return NumeroALetras(numero / 100) + "CIENTOS";
            if (numero == 500) return "QUINIENTOS";
            if (numero == 700) return "SETECIENTOS";
            if (numero == 900) return "NOVECIENTOS";
            if (numero < 1000) return NumeroALetras((int)(Math.Floor((decimal)numero / 100) * 100)) + " " + NumeroALetras(numero % 100);
            if (numero == 1000) return "MIL";
            if (numero < 2000) return "MIL " + NumeroALetras(numero % 1000);
            if (numero < 1000000)
            {
                var miles = (int)Math.Floor((decimal)numero / 1000);
                var resto = numero % 1000;
                var milesTexto = NumeroALetras(miles) + " MIL";
                if (resto > 0)
                {
                    milesTexto += " " + NumeroALetras(resto);
                }
                return milesTexto;
            }
            if (numero == 1000000) return "UN MILLÓN";
            if (numero < 2000000) return "UN MILLÓN " + NumeroALetras(numero % 1000000);
            if (numero < 1000000000000)
            {
                var millones = (int)Math.Floor((decimal)numero / 1000000);
                var resto = numero - (millones * 1000000);
                var millonesTexto = NumeroALetras(millones) + " MILLONES";
                if (resto > 0)
                {
                    millonesTexto += " " + NumeroALetras((int)resto);
                }
                return millonesTexto;
            }

            return "";
        }

        public static long GenerateRandomPositiveLong()
        {
            byte[] buffer = new byte[8];
            Random random = new Random();
            random.NextBytes(buffer);
            return Math.Abs(BitConverter.ToInt64(buffer, 0));
        }

        public static int GenerateRandomPositiveSixDigitNumber()
        {
            Random random = new Random();
            return random.Next(0, 1000000); // 0 a 999,999
        }


        public void PreparaFactura(DatosPersona persona, Hotel hotel, DatosFiscal fiscalCliente, DatosFiscal fiscalHotel,
            Cliente cliente, DataTable dt)
        {
            // Crear un nuevo documento PDF
            Document doc = new Document(PageSize.LETTER);

            try
            {
                string nombreCompleto = persona.Nombres + " " + persona.Paterno + " " + persona.Materno;

                // Formatear la fecha de forma válida para nombre de archivo
                string fecha = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

                // Limpiar el nombre completo quitando caracteres no válidos (opcional pero recomendable)
                foreach (char c in Path.GetInvalidFileNameChars())
                {
                    nombreCompleto = nombreCompleto.Replace(c, '_');
                }

                // Crear el escritor para el documento
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream($"Factura_{nombreCompleto}_{fecha}.pdf", FileMode.Create));

                // Abrir el documento
                doc.Open();

                UbicacionDAO ubicacionDAO = new UbicacionDAO();
                Ubicacion ubicacionHotel = ubicacionDAO.getUbicacion(hotel.IdUbicacion);
                Ubicacion ubicacionCliente = ubicacionDAO.getUbicacion(cliente.IdUbicacion);

                // Cargar el logo desde Resources
                System.Drawing.Image logo = Properties.Resources.LOGO_HOTEL_removebg_preview; // Cambia 'NombreDelRecurso' al nombre real del recurso de tu imagen

                // Convertirlo a iTextSharp.text.Image  
                using (MemoryStream ms = new MemoryStream())
                {
                    logo.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // O .Jpeg si tu imagen es JPEG  
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());
                    img.ScaleAbsolute(100f, 50f); // Ajusta el tamaño (ancho, alto) según necesites  
                    img.Alignment = Element.ALIGN_LEFT; // Alinear a la izquierda  

                    doc.Add(img); // Agregar la imagen al documento  
                }

                // Agregar la información del emisor (DatosPersona y Hotel)
                //doc.Add(new Paragraph($"[LOGO DE LA EMPRESA]", FontFactory.GetFont("Arial", 12))); // Espacio para el logo
                doc.Add(new Paragraph($"RFC: {hotel.Rfc}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Emisor: {hotel.Nombre}", FontFactory.GetFont("Arial", 12)));
                doc.Add(new Paragraph($"Domicilio: {hotel.Domicilio}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Ciudad: {ubicacionHotel.Ciudad}, Estado: {ubicacionHotel.Estado}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Régimen Fiscal: {fiscalHotel.RegimenFiscal}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 8)));


                // Agregar la información del receptor (Cliente)
                doc.Add(new Paragraph($"Cliente: {nombreCompleto}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"RFC: {cliente.Rfc}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Domicilio: {cliente.Domicilio}, {cliente.Colonia}, " +
                    $"C.P. {cliente.Cp}, Ciudad: {ubicacionCliente.Ciudad}, Estado: {ubicacionCliente.Estado}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 8)));

                string uuid = Guid.NewGuid().ToString();
                string formaPago = reservacion.MontoTotal == reservacion.Anticipo ? "Una sola exhibición" : "A parcialidades";

                // Agregar la información general de la factura
                doc.Add(new Paragraph($"Tipo de Comprobante: Ingreso", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Lugar de Expedición: {GenerateRandomPositiveSixDigitNumber()}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Folio: {GenerateRandomPositiveLong()}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Fecha: {DateTime.Now}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Forma de Pago: {reservacion.MetodoPago}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Método de Pago: {formaPago}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Moneda: MXN", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Serie: {GenerateRandomPositiveLong()}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"UUID: {uuid}", FontFactory.GetFont("Arial", 10))); // Si aplica
                doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 8)));

                // Crear la tabla para los conceptos
                PdfPTable table = new PdfPTable(7); // Cantidad, Unidad, Descripción, Precio Unitario, Importe
                table.WidthPercentage = 100;
                float[] widths = new float[] { 10f, 15f, 30f, 15f, 20f,20f,20f};
                table.SetWidths(widths);

                // Encabezados de la tabla
                table.AddCell(new PdfPCell(new Phrase("Cantidad", FontFactory.GetFont("Arial", 9))));
                table.AddCell(new PdfPCell(new Phrase("Unidad", FontFactory.GetFont("Arial", 9))));
                table.AddCell(new PdfPCell(new Phrase("Clave Unidad SAT", FontFactory.GetFont("Arial", 9))));
                table.AddCell(new PdfPCell(new Phrase("Clave Producto/Servicio", FontFactory.GetFont("Arial", 9))));
                table.AddCell(new PdfPCell(new Phrase("Concepto/Descripcion", FontFactory.GetFont("Arial", 9))));
                table.AddCell(new PdfPCell(new Phrase("Valor Unitario", FontFactory.GetFont("Arial", 9))));
                table.AddCell(new PdfPCell(new Phrase("IVA", FontFactory.GetFont("Arial", 9))));


                table.HeaderRows = 1;

                // Llenar la tabla con los datos del DataTable
                foreach (DataRow row in dt.Rows)
                {
                    table.AddCell(new PdfPCell(new Phrase(row["Cantidad"].ToString(), FontFactory.GetFont("Arial", 8))));
                    table.AddCell(new PdfPCell(new Phrase(row["Unidad"].ToString(), FontFactory.GetFont("Arial", 8))));
                    table.AddCell(new PdfPCell(new Phrase(row["Clave Unidad SAT"].ToString(), FontFactory.GetFont("Arial", 8))));
                    table.AddCell(new PdfPCell(new Phrase(row["Clave Producto/Servicio"].ToString(), FontFactory.GetFont("Arial", 8))));
                    table.AddCell(new PdfPCell(new Phrase(row["Concepto/Descripción"].ToString(), FontFactory.GetFont("Arial", 8))));

                    table.AddCell(new PdfPCell(new Phrase(row["Valor Unitario"].ToString(), FontFactory.GetFont("Arial", 8))));
                    table.AddCell(new PdfPCell(new Phrase(row["IVA"].ToString(), FontFactory.GetFont("Arial", 8))));


                }

                doc.Add(table);
                doc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 8)));

                // Agregar los totales
                doc.Add(new Paragraph($"Subtotal: {subtotal}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"IVA: {IVA}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Descuentos: {anticipo}", FontFactory.GetFont("Arial", 10)));
                doc.Add(new Paragraph($"Total: {Total}", FontFactory.GetFont("Arial", 10)));

                // Agregar importe con letra
                doc.Add(new Paragraph($"Importe con letra: {NumeroALetras(decimal.Parse(Total))}", FontFactory.GetFont("Arial", 10)));

                // Cerrar el documento
                doc.Close();
                writer.Close();
                MessageBox.Show("Factura generada");
                this.Close();
            }
            catch (DocumentException de)
            {
                Console.Error.WriteLine(de.Message);
            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);
            }
        }

    }


}

