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
        // dans public partial class FormGsb : Form
        List<Produit> lesProduits;

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

        }

        private void FormGsb_Load(object sender, EventArgs e)
        {

            txbCodeClient.Enabled = false;

            // dans private void FormGsb_Load(object sender, EventArgs e)
            //chargerLesProduits();
            daoProduit monDaoProduit = new daoProduit();

            chargerLesClients();
            daoClient monDaoClient = new daoClient();
            //MessageBox.Show((monDaoClient.trouverNomProfessionParId(1)));
            //MessageBox.Show((monDaoClient.trouverIdProfessionnelParNomProfession("Cadre").ToString()));

            daoVisiteur monDaoVisiteur = new daoVisiteur();



            #region Ajout des types de clients à la collection de la combobox cbxRaisonClient
            cbxRaisonClient.Items.Add("Médecin");
            cbxRaisonClient.Items.Add("Chômeur");
            cbxRaisonClient.Items.Add("Chirurgien");
            #endregion

            #region Ajout des visiteurs à la ComboBox Visiteur

            #endregion

        }

        private void cbxNomClient_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < lesClients.Count(); i++)
            {
                daoClient monDaoClientTXB = new daoClient();
                if (lesClients[i].Nom.ToString() == cbxNomClient.Text)
                {
                    Client leClient = lesClients[i];
                    txbPrenomClient.Text = leClient.Prenom.ToString();
                    txbCodeClient.Text = leClient.Id.ToString();
                    cbxRaisonClient.Text = leClient.RaisonSociale.ToString();
                    txbAdresseClient.Text = leClient.Adresse.ToString();
                    txbCpClient.Text = leClient.Cp.ToString();
                    txbVilleClient.Text = leClient.Ville.ToString();
                    txbTypeClient.Text = monDaoClientTXB.trouverNomProfessionParId(leClient.IdTypeProfessionnel);
                    txbMailClient.Text = leClient.Email.ToString();
                    /////////////////////////////////////
                    /////////////////////////////////////
                    /////////////////////////////////////
                }
            }
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            if (cbxNomClient.Text != ""
            && txbPrenomClient.Text != ""
            && txbCodeClient.Text != ""
            && cbxRaisonClient.Text != ""
            && cbxRaisonClient.Text != ""
            && txbAdresseClient.Text != ""
            && txbCpClient.Text != ""
            && txbVilleClient.Text != ""
            && txbTypeClient.Text != ""
            && txbMailClient.Text != "")
            {
                // FINIR L'AJOUT
                try
                {
                    daoClient.modifierClient(int.Parse(txbCodeClient.Text), cbxNomClient.Text, txbPrenomClient.Text, cbxRaisonClient.Text, txbAdresseClient.Text, txbCpClient.Text, txbVilleClient.Text, 1, txbMailClient.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la création du client" + ex.ToString());
                }
                MessageBox.Show("Modification effectuée avec succés");
            }
            else
            {
                MessageBox.Show("L'un des champs n'a pas été rempli correctement et la création ne peut donc pas être effectuée. Veuillez réessayer.");
            }
        }

        public void chargerLesClients()
        {
            #region Création de la liste lesClients contenant les clients de la base de données
            lesClients = new List<Client>();
            daoClient monDaoClient = new daoClient();
            lesClients = monDaoClient.recupererLesClients();
            #endregion

            #region Ajout du nom des clients à la collection de la combobox Client
            for (int i = 0; i < lesClients.Count(); i++)
            {
                cbxNomClient.Items.Add(lesClients[i].Nom.ToString());
            }
            #endregion
        }

        private void btnAjouterRdv_Click(object sender, EventArgs e)
        {
            if (cbxNomClient.Text != "" && dateRdvClient.Text != "" && txbMinutesRdv.Text != "" && txbVisiteurAjoutRdvClient.Text != "" && rtbRdvClient.Text != "")
            {
                dgvAgendaClient.Rows.Add(dateRdvClient.Text, txbHeuresRDV.Text + ":" + txbMinutesRdv.Text, txbVisiteurAjoutRdvClient.Text, rtbRdvClient.Text);


                Client monClient = trouverClient(int.Parse(txbCodeClient.Text));
                Visite maVisite = new Visite(monClient, dateRdvClient.Text, txbHeuresRDV.Text, rtbRdvClient.Text);
                monClient.ajouterVisite(maVisite);
                monClient.LesVisites.Add(maVisite);
                MessageBox.Show(monClient.Nom);
                MessageBox.Show(monClient.LesVisites[0].Date);
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs du rendes-vous");
            }
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {

            Form instanceFormCreerClient = new formCreerClient();
            instanceFormCreerClient.ShowDialog();
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (cbxNomClient.Text != ""
            && txbPrenomClient.Text != ""
            && txbCodeClient.Text != "")
            {
                // FINIR LA SUPPRESSION
                try
                {
                    daoClient.supprimerClient(int.Parse(txbCodeClient.Text), cbxNomClient.Text, txbPrenomClient.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la création du client" + ex.ToString());
                }
                MessageBox.Show("Suppression effectuée avec succés");
            }
            else
            {
                MessageBox.Show("L'un des champs n'a pas été rempli correctement et la création ne peut donc pas être effectuée. Veuillez réessayer.");
            }

        }

        private Client trouverClient(int unId)
        {
            Client clientVide = new Client(-1, "vide", "vide", "vide", "vide", "vide", "vide", "vide", 0);
            for (int i = 0; i < lesClients.Count(); ++i)
            {
                if (lesClients[i].Id == unId)
                {
                    Client monClient = new Client(unId, lesClients[i].Nom, lesClients[i].Prenom, lesClients[i].RaisonSociale, lesClients[i].Ville, lesClients[i].Adresse, lesClients[i].Cp, lesClients[i].Email, lesClients[i].IdTypeProfessionnel);
                    return monClient;
                }
            }
            return clientVide;
        }


//        public void chargerLesProduits()
//        {
//            // Création de la liste lesProduits contenant les produits de la bdd
//            lesProduits = new List<Produit>();
//            daoProduit monDaoProduit = new daoProduit();
//            lesProduits = monDaoProduit.recupererLesProduits();
//
//            // Ajout du nom des produits à la collection de la combobox Produit
//            for (int i = 0; i < lesProduits.Count(); i++)
//            {
//                try
//                {
//  cbxNomProduit.Items.Add(lesProduits[i].getNom().ToString());
//
//                }
//                catch (Exception ex2)
//                {
//                    MessageBox.Show("Erreur : " + ex2.ToString());
//                }
//              
//            }
//        }

//        public void cbxNomProduit_TextChanged(object sender, EventArgs e)
//        {
//            for (int i = 0; i < lesProduits.Count(); i++)
//            {
//                daoProduit monDaoProduitTxb = new daoProduit();
//                if (lesProduits[i].getNom().ToString() == cbxNomProduit.Text)
//                {
//                    Produit leProduit = lesProduits[i];
//                    txbNumProduit.Text = leProduit.getNum().ToString();
//                    txbPrixProduit.Text = leProduit.getPrixHT().ToString();
//                    lsbEffets.Text = leProduit.getEffets().ToString();
//                    lsbInteraction.Text = leProduit.getInteractions().ToString();
//                    lsbContreIndication.Text = leProduit.getIndications().ToString();
//                }
//            }
    }
}
