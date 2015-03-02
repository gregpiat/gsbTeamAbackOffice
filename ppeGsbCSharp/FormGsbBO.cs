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
        List<Visiteur> lesVisiteurs;

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
            Visiteur visiteur1 = new Visiteur(1, "Aubel", "François");
            Visiteur visiteur2 = new Visiteur(2, "Aurel", "Thomas");
            List<Visiteur> lesVisiteurs = new List<Visiteur>();
            lesVisiteurs.Add(visiteur1);
            lesVisiteurs.Add(visiteur2);
            cbxVisiteurAjoutRdvClient.Items.Add(lesVisiteurs[0].Nom.ToString());

            chargerLesClients();
            daoClient monDaoClient = new daoClient();
            //MessageBox.Show((monDaoClient.trouverNomProfessionParId(1)));
            //MessageBox.Show((monDaoClient.trouverIdProfessionnelParNomProfession("Cadre").ToString()));


            chargerLesVisiteurs();
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

        public void chargerLesVisiteurs()
        {
            #region Création de la liste lesClients contenant les clients de la base de données
            lesVisiteurs = new List<Visiteur>();
            //daoVisiteur monDaoVisiteur = new daoVisiteur();
            //lesVisiteurs = monDaoVisiteur.recupererLesVisiteurs();
            #endregion

            #region Ajout du nom des clients à la collection de la combobox Client
            for (int i = 0; i < lesVisiteurs.Count(); i++)
            {
                cbxVisiteurAjoutRdvClient.Items.Add(lesVisiteurs[i].Nom.ToString());
            }
            #endregion
        }

        private void btnAjouterRdv_Click(object sender, EventArgs e)
        {
            dgvAgendaClient.Rows.Add(dateRdvClient.Text, txbHeuresRDV.Text +":"+ txbMinutesRdv.Text, cbxVisiteurAjoutRdvClient.Text, rtbRdvClient.Text);
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            if(cbxNomClient.Text != "" 
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
                //daoClient.ajouterClient(cbxNomClient.Text, cbxCodeClient.Text, txbCode);
                MessageBox.Show("Création effectuée avec succés");
            }
            else
            {
                MessageBox.Show("L'un des champs n'a pas été rempli correctement et la création ne peut donc pas être effectuée. Veuillez réessayer.");
            }
        }
    }
}
