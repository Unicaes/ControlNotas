using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PlayerUI
{
    public partial class FrmAgregarDocente : Form
    {
        public FrmAgregarDocente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Interaction.InputBox("Ingresa el Documento del docente", "Búsqueda de Docente", "");
        }
    }
}
