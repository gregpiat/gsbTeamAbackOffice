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
    public partial class formCreerClient : Form
    {
        public formCreerClient()
        {
            InitializeComponent();
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            if (txbNomClientAjout.Text != ""
            && txbPrenomClientAjout.Text != ""
            && cbxRaisonClientAjout.Text != ""
            && txbAdresseAjout.Text != ""
            && txbCpClientAjout.Text != ""
            && txbVilleClientAjout.Text != ""
            && txbTypeClientAjout.Text != ""
            && txbMailClientAjout.Text != "")
            {
                // FINIR L'AJOUT
                try
                {
                    daoClient.ajouterClient(/*60, */txbNomClientAjout.Text, txbPrenomClientAjout.Text, cbxRaisonClientAjout.Text, txbAdresseAjout.Text, txbCpClientAjout.Text, txbVilleClientAjout.Text, 1, txbMailClientAjout.Text, txbTelephoneClientAjout.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la création du client" + ex.ToString());
                }
                MessageBox.Show("Création effectuée avec succés");
            }
            else
            {
                MessageBox.Show("L'un des champs n'a pas été rempli correctement et la création ne peut donc pas être effectuée. Veuillez réessayer.");
            }
        }

        private void formCreerClient_Load(object sender, EventArgs e)
        {
        }
    }
}
