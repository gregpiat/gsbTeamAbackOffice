using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ppeGsbCSharp
{
    public partial class FormGsb : Form
    {
        List<Client> lesClients;
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

        private void FormGsb_Load(object sender, EventArgs e)
        {
            lesClients = new List<Client>();
        }
    }
}
