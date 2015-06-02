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
                String nomClient = txbNomClientAjout.Text.Replace("'", "''");
                String prenomClient = txbPrenomClientAjout.Text.Replace("'", "''");
                String adresse = txbAdresseAjout.Text.Replace("'", "''");
                String ville = txbVilleClientAjout.Text.Replace("'", "''");
                String mail = txbMailClientAjout.Text.Replace("'", "''");

                // FINIR L'AJOUT
                try
                {
                    daoClient.ajouterClient(nomClient, prenomClient, cbxRaisonClientAjout.Text, adresse, txbCpClientAjout.Text, ville, 1, mail, txbTelephoneClientAjout.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la création du client" + ex.ToString());
                }
                MessageBox.Show("Création effectuée avec succés");
                formCreerClient.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("L'un des champs n'a pas été rempli correctement et la création ne peut donc pas être effectuée. Veuillez réessayer.");
            }
        }

        private void txbCpClientAjout_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // Vérifie si l'utilisateur entre un numérique ou un char. Si char --> Bloque la saisie
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbTelephoneClientAjout_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTelephoneClientAjout_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // Vérifie si l'utilisateur entre un numérique ou un char. Si char --> Bloque la saisie
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
