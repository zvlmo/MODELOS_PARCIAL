using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLavaderoWF
{
    public partial class FormIngresoVehiculos : Form
    {
        public FormIngresoVehiculos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Auto":
                    txtAsientos.Enabled = true;
                    txtTara.Enabled = false;
                    txtCilindrada.Enabled = false;
                    break;
                case "Moto":
                    txtCilindrada.Enabled = true;
                    txtTara.Enabled = false;
                    txtAsientos.Enabled = false;

                    break;
                case "Camion":
                    txtTara.Enabled = true;
                    txtAsientos.Enabled = false;
                    txtCilindrada.Enabled = false;
                    break;
            }
        }

        private void aceptarBtn_Click(object sender, EventArgs e)

        {

            this.DialogResult = DialogResult.OK;
        }
    }
}
