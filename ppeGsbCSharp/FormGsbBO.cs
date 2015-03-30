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
        //Gestion des Commandes
        #region commande
        //creation d'une arraylist Commande appelant DAOCommande
        ArrayList uneCommande = DAOCommande.list();
        List<Produit> unProduit = daoProduit.listeProduit();
        //List<Produit> unProduit = daoProduit.recupererLesProduits();
        List<commandeListe> lesLigne = DAOCommande.ligneCommande();
        List<commandeListe> nouvelleLigne = new List<commandeListe>();
        //Procedure verouille les fonctionnalisés tant que le numero de commande n'ai pas selectionné
        public void verouillage()
        {
            CbxEtatCommande.Enabled = false;
            BtnModifierEtatCommande.Enabled = false;
            BtnAjoutCommande.Enabled = false;
        }
        //Procedure reinitialise les commandes
        public void reefrechComboBox()
        {
            //charge les nouveaux numeros de commande
            ArrayList uneCommande = DAOCommande.list();
            CbxNumeroCommande.Items.Clear();
            for (int i = 0; i < uneCommande.Count; i++)
            {
                Commande laCommande = (Commande)uneCommande[i];
                CbxNumeroCommande.Items.Add(laCommande.getNum());

            }
            CbxClientCommandeAjout.Items.Clear();
            //charge les clients
            lesClients = new List<Client>();
            daoClient monDaoClient = new daoClient();
            lesClients = monDaoClient.recupererLesClients();
            for (int i = 1; i < lesClients.Count(); i++)
            {
                Client leClient = lesClients[i];
                CbxClientCommandeAjout.Items.Add(leClient.Nom.ToString());
            }
            //Vide les champs de l'ajout d'une commande
            txtNumeroCommande.Text = "";
            CbxClientCommandeAjout.Text = "";
            CbxProduitCommande.Text = "";
            TxtQuantiteCommande.Text = "";
            DgvCommandeLesProduitAjouter.Rows.Clear();

        }
        //Verification de la saisi de la selection d'un client s'il elle est vide et du numero 
        //de Commande.A la validation de la commande, si le numero de commande existe, ou que 
        //le client n'ai pas selectionner un message box indicant que le numero de commande 
        //existe déjà, ou qu'un client n'a pas etait selectionner empechant 
        //toute action, sinon elle laisse faire l'utilisateur,
        private Boolean verificationDeSaisi()
        {
            Boolean verif = false;
            Boolean com = false;
            Boolean com2 = false;
            for (int i = 0; i < uneCommande.Count; i++)
            {
                Commande laCommande = (Commande)uneCommande[i];
                if (txtNumeroCommande.Text != "")
                {
                    if (txtNumeroCommande.Text == laCommande.getNum())
                    {
                        com = true;
                    }
                }
                else
                {
                    com2 = true;
                }
            }
            if (com == true)
            {
                MessageBox.Show("Numero de commande existante, veuiller changer");
                txtNumeroCommande.Text = "";
                this.txtNumeroCommande.BorderStyle = BorderStyle.FixedSingle;
                Pen p = new Pen(Color.Red);
                verif = true;
            }
            else
            {
                if (com2 == true)
                {
                    MessageBox.Show("Veuillez saisir un numero de commande");
                    this.txtNumeroCommande.BorderStyle = BorderStyle.FixedSingle;
                    Pen p = new Pen(Color.Red);
                    verif = true;
                }
                else
                {
                    if (CbxClientCommandeAjout.Text == "")
                    {
                        MessageBox.Show("Veuillez saisir un client");
                        verif = true;
                    }
                }
            }
            return verif;

        }
        //affiche les element selectionner par la combobox numero de commande
        private void CbxNumeroCommande_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ArrayList uneCommande = DAOCommande.list();
            List<commandeListe> lesLigne = DAOCommande.ligneCommande();
            CbxEtatCommande.Enabled = true;
            BtnModifierEtatCommande.Enabled = true;
            int indice = CbxNumeroCommande.SelectedIndex;
            Commande laCommande = (Commande)uneCommande[indice];
            LblDateCommandeAffiche.Text = laCommande.getDate();
            //Ajout au dataGridView les nom de produit ainsi que la quantite
            DgvListeCommande.Rows.Clear();
            for (int i = 0; i < unProduit.Count(); i++)
            {
                Produit leProduit = unProduit[i];
                for (int j = 0; j < lesLigne.Count(); j++)
                {
                    if (leProduit.getNum() == lesLigne[j].getleNumProduit())
                    {
                        if (laCommande.getNum() == lesLigne[j].getNumCommande())
                        {
                            DgvListeCommande.Rows.Add(leProduit.getNom(), lesLigne[j].getQuantite());
                        }

                    }
                }
            }
            //affiche l'etat de la commande
            CbxEtatCommande.Text = laCommande.getEtat();
            //charge les clients
            lesClients = new List<Client>();
            daoClient monDaoClient = new daoClient();
            lesClients = monDaoClient.recupererLesClients();
            for (int i = 0; i < lesClients.Count(); i++)
            {
                if (lesClients[i].Id == laCommande.getUnClientId())
                {
                    Client leClient = lesClients[i];
                    LblClientCommandeAffiche.Text = leClient.Nom.ToString() + leClient.Prenom.ToString();
                }
            }
        }
        //modification de l'etat en faisant appele a la classe Commande
        private void BtnModifierEtatCommande_Click(object sender, EventArgs e)
        {
            ArrayList uneCommande = DAOCommande.list();
            int indice = CbxNumeroCommande.SelectedIndex;
            Commande laCommande = (Commande)uneCommande[indice];
            int indiceEtat = CbxEtatCommande.SelectedIndex;
            laCommande.updateEtat(indiceEtat + 1, CbxEtatCommande.Text, CbxNumeroCommande.Text);
        }
        //Verification de la quantite, si elle est supperieur la textbox metra la quantite
        //maximum possible, sinon elle gardera la quantite saisi
        private void TxtQuantiteCommande_TextChanged_1(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < leProduit.Count; i++)
            {
                produit = (Produit)leProduit[i];
                if (txtProduit1.Text == produit.getRef().ToString())
                {
                    if (TxtQuantiteCommande.Text != "")
                    {
                        if (int.Parse(TxtQuantiteCommande.Text) > produit.getQuantite())
                        {
                            TxtQuantiteCommande.Text = produit.getQuantiteRestante().ToString();
                        }
                    }
                }
            }*/
        }
        //empeche l'utilisateur d'utiliser une chaine de caratere dans la texte box de la quantite
        private void TxtQuantiteCommande_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
        //Premiere verification du numero de Commande signalant l'utilisateur de l'utilisation
        //d'un numero de commande existant, si il existe, un label indicant
        //que le numero de commande existe déjà sinon, la textbox laisse faire l'utilisateur
        private void txtNumeroCommande_TextChanged_1(object sender, EventArgs e)
        {
            if (txtNumeroCommande.Text != "")
            {
                lblNumeroCommadeUtiliser.ForeColor = System.Drawing.Color.Green;
                lblNumeroCommadeUtiliser.Text = "Numero de commande disponible !";
            }
            else
            {
                lblNumeroCommadeUtiliser.Text = "";
            }
            for (int i = 0; i < uneCommande.Count; i++)
            {
                Commande laCommande = (Commande)uneCommande[i];
                if (txtNumeroCommande.Text != "")
                {
                    if (txtNumeroCommande.Text == laCommande.getNum())
                    {
                        lblNumeroCommadeUtiliser.ForeColor = System.Drawing.Color.Red;
                        lblNumeroCommadeUtiliser.Text="Le numero de commande est déjà existante !";
                    }
                }
            }
        }
        //ajout d'une commande dans la classe commande/commandeListe ainsi que dans la bdd
        private void BtnAjoutCommande_Click_1(object sender, EventArgs e)
        {
            Boolean verifSaisi = verificationDeSaisi();
            if (verifSaisi == false)
            {
                int indice = CbxClientCommandeAjout.SelectedIndex;
                Client leClientSelect = (Client)lesClients[indice];
                Commande ajoutCommande = new Commande(txtNumeroCommande.Text, DateTime.Now.ToString(), "En cours", int.Parse(leClientSelect.Id.ToString()));
                Commande.ajoutComandeListe(int.Parse(leClientSelect.Id.ToString()), txtNumeroCommande.Text, DateTime.Now.ToString(), 1);
                int indiceProduit = CbxProduitCommande.SelectedIndex;
                Produit leProduit = (Produit)unProduit[indiceProduit];
                for (int j = 0; j < nouvelleLigne.Count; j++)
                {
                    if (nouvelleLigne[j].getNumCommande() == txtNumeroCommande.Text)
                    {
                        commandeListe.ajoutComandeListe(txtNumeroCommande.Text, nouvelleLigne[j].getQuantite(), nouvelleLigne[j].getleNumProduit());
                    }
                }
                MessageBox.Show("Insertion éffèctué");
                reefrechComboBox();
                BtnAjoutCommande.Enabled = false;
                txtNumeroCommande.Enabled = true;
                CbxClientCommandeAjout.Enabled = true;
            }
        }
        //ajouter le produit dans le dataGridView, afin de pouvoir passer une commande
        private void btnAjoutCommandeLigneProduit_Click_1(object sender, EventArgs e)
        {
            
            Boolean verifSaisi = verificationDeSaisi();
            if (verifSaisi == false)
            {
                if (CbxProduitCommande.Text != "" && TxtQuantiteCommande.Text != "")
                {
                    BtnAjoutCommande.Enabled = true;
                    txtNumeroCommande.Enabled = false;
                    CbxClientCommandeAjout.Enabled = false;
                    int indiceProduit = CbxProduitCommande.SelectedIndex;
                    Produit leProduit = (Produit)unProduit[indiceProduit];
                    DgvCommandeLesProduitAjouter.Rows.Add(leProduit.getNom(), TxtQuantiteCommande.Text);
                    nouvelleLigne.Add(new commandeListe(txtNumeroCommande.Text, leProduit.getNum(), int.Parse(TxtQuantiteCommande.Text)));
                    commandeListe ajoutCommandeListe = new commandeListe(txtNumeroCommande.Text, leProduit.getNum(), int.Parse(TxtQuantiteCommande.Text));
                }
                else
                {
                    MessageBox.Show("Vous devez saisir tout les champs pour ajouter un produit");
                }
                CbxProduitCommande.Text = "";
                TxtQuantiteCommande.Text = "";
            }
        }
        //insertion d'item dans la combobox numero de commande ainsi que dans la comboBox 
        //produits suituer dans l'onglet ajout et insertion des etats
        private void tabCommandes_Enter(object sender, EventArgs e)
        {
            verouillage();
            CbxNumeroCommande.Items.Clear();
            CbxEtatCommande.Items.Clear();
            //charge les numeros de commande
            for (int i = 0; i < uneCommande.Count; i++)
            {
                Commande laCommande = (Commande)uneCommande[i];
                CbxNumeroCommande.Items.Add(laCommande.getNum());

            }
            //charge les etats des commandes
            ArrayList recupEtat = DAOCommande.recupEtat();
            for (int i = 0; i < recupEtat.Count; i++)
            {
                Commande laCommande = (Commande)recupEtat[i];
                CbxEtatCommande.Items.Add(laCommande.getEtatTotal());
            }
            //charge les Commandes
            for (int i = 0; i < unProduit.Count(); i++)
            {
                Produit leProduit = unProduit[i];
                CbxProduitCommande.Items.Add(leProduit.getNom());
            }
            CbxClientCommandeAjout.Items.Clear();
            //charge les clients
            lesClients = new List<Client>();
            daoClient monDaoClient = new daoClient();
            lesClients = monDaoClient.recupererLesClients();
            for (int i = 0; i < lesClients.Count(); i++)
            {
                Client leClient = lesClients[i];
                CbxClientCommandeAjout.Items.Add(leClient.Nom.ToString());
            }
        }

        #endregion
        //Gestion des Clients
        #region Client
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
                    txbTelephoneClient.Text = leClient.Telephone.ToString();
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
                    daoClient.modifierClient(int.Parse(txbCodeClient.Text), cbxNomClient.Text, txbPrenomClient.Text, cbxRaisonClient.Text, txbAdresseClient.Text, txbCpClient.Text, txbVilleClient.Text, 1, txbMailClient.Text, txbTelephoneClient.Text);
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
                cbxNomClient.Items.Add(lesClients[i].Nom.ToString().Trim());
            }
            #endregion
        }

        private void btnAjouterRdv_Click(object sender, EventArgs e)
        {
          //  if (cbxNomClient.Text != "" && dateRdvClient.Text != "" && txbMinutesRdv.Text != "" && txbVisiteurAjoutRdvClient.Text != "" && rtbRdvClient.Text != "")
            //{
              //  dgvAgendaClient.Rows.Add(dateRdvClient.Text, txbHeuresRDV.Text + ":" + txbMinutesRdv.Text, txbVisiteurAjoutRdvClient.Text, rtbRdvClient.Text);

                // Création du client qui correspond au client courant du formulaire
                //Client monClient = trouverClient(int.Parse(txbCodeClient.Text));

                // Création de la visite avec les informations du formulaire et ajout à l'ArrayList lesVisites du client
                //Visite maVisite = new Visite(monClient, dateRdvClient.Text, txbHeuresRDV.Text, rtbRdvClient.Text);
                //monClient.ajouterVisite(maVisite);
                //monClient.LesVisites.Add(maVisite);

            //    MessageBox.Show(monClient.Nom);
            //    for (int i = 0; i < monClient.LesVisites.Count(); ++i)
            //    {
            //
            //    }
            //        MessageBox.Show(monClient.LesVisites[0].Heure);
            //}
            //else
            //{
            //    MessageBox.Show("Veuillez remplir tous les champs du rendes-vous");
            //}
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
            Client clientVide = new Client(-1, "vide", "vide", "vide", "vide", "vide", "vide", "vide", 0,"0000000000");
            for (int i = 0; i < lesClients.Count(); ++i)
            {
                if (lesClients[i].Id == unId)
                {
                    Client monClient = new Client(unId, lesClients[i].Nom, lesClients[i].Prenom, lesClients[i].RaisonSociale, lesClients[i].Ville, lesClients[i].Adresse, lesClients[i].Cp, lesClients[i].Email, lesClients[i].IdTypeProfessionnel, lesClients[i].Telephone);
                    return monClient;
                }
            }
            return clientVide;
        }

        private void cbxNomClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxNomClient_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        #endregion





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
