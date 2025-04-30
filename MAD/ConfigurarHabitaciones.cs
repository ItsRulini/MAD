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
    public partial class ConfigurarHabitaciones : Form
    {
        public ConfigurarHabitaciones()
        {
            InitializeComponent();
            textPrecioPersona.Enabled = false;

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
                textPrecioPersona.Enabled = false;
            }
            else
            {
                textPrecioPersona.Enabled = true;
            }
        }
    }
}
