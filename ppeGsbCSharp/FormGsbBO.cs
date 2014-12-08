using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ppeGsbCSharp
{
    public partial class FormGsb : Form
    {
        public FormGsb()
        {
            InitializeComponent();
        }

        private void lblVisiteurRdv_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabClients_Click(object sender, EventArgs e)
        {
            if (cbxNomClient.Text == null)
            {
                dgvAgendaClient.Enabled = false;
                gpbAgendaClient.Enabled = false;
                rtbRdvClient.Enabled = false;
                dateRdvClient.Enabled = false;
                cbxVisiteurAjoutRdvClient.Enabled = false;
            }
        }
    }
}
