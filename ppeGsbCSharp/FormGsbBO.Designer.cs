namespace ppeGsbCSharp
{
    partial class FormGsb
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGsb));
            this.tabMenuPrincipal = new System.Windows.Forms.TabControl();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblExplicationsAppplication = new System.Windows.Forms.Label();
            this.tabProduits = new System.Windows.Forms.TabPage();
            this.tabMenuProduits = new System.Windows.Forms.TabControl();
            this.tabProduitsConsulter = new System.Windows.Forms.TabPage();
            this.btnSupprimerProduit = new System.Windows.Forms.Button();
            this.btnModifierProduit = new System.Windows.Forms.Button();
            this.lblInteraction = new System.Windows.Forms.Label();
            this.lblEffets = new System.Windows.Forms.Label();
            this.lblContreIndication = new System.Windows.Forms.Label();
            this.lblPrixProduit = new System.Windows.Forms.Label();
            this.lblNumProduit = new System.Windows.Forms.Label();
            this.lblNomProduit = new System.Windows.Forms.Label();
            this.lsbInteraction = new System.Windows.Forms.ListBox();
            this.lsbEffets = new System.Windows.Forms.ListBox();
            this.lsbContreIndication = new System.Windows.Forms.ListBox();
            this.txbPrixProduit = new System.Windows.Forms.TextBox();
            this.txbNumProduit = new System.Windows.Forms.TextBox();
            this.cbxNomProduit = new System.Windows.Forms.ComboBox();
            this.tabProduitsAjouter = new System.Windows.Forms.TabPage();
            this.BtnAjoutProduit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RtxtContreIndicationProduitAjout = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RtxtInteractionProduitAjout = new System.Windows.Forms.RichTextBox();
            this.RtxtEffetProduitAjout = new System.Windows.Forms.RichTextBox();
            this.TxtPrixProduitAjout = new System.Windows.Forms.TextBox();
            this.TxtNumeroProduitAjout = new System.Windows.Forms.TextBox();
            this.TxtNameProduitAjout = new System.Windows.Forms.TextBox();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.gpbAgendaClient = new System.Windows.Forms.GroupBox();
            this.gpbRdvClient = new System.Windows.Forms.GroupBox();
            this.gbAjouterVisite = new System.Windows.Forms.GroupBox();
            this.txbVisiteurAjoutRdvClient = new System.Windows.Forms.TextBox();
            this.lblSeparateurHeures = new System.Windows.Forms.Label();
            this.txbMinutesRdv = new System.Windows.Forms.TextBox();
            this.txbHeuresRDV = new System.Windows.Forms.TextBox();
            this.lblHeureRdv = new System.Windows.Forms.Label();
            this.dateRdvClient = new System.Windows.Forms.DateTimePicker();
            this.lblVisiteurRdv = new System.Windows.Forms.Label();
            this.btnAjouterRdv = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.rtbRdvClient = new System.Windows.Forms.RichTextBox();
            this.dgvAgendaClient = new System.Windows.Forms.DataGridView();
            this.dgvColonneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColonneVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCompteRendu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbsClient = new System.Windows.Forms.GroupBox();
            this.txbTelephoneClient = new System.Windows.Forms.TextBox();
            this.lblTelephoneClient = new System.Windows.Forms.Label();
            this.txbPrenomClient = new System.Windows.Forms.TextBox();
            this.lblPrenomClient = new System.Windows.Forms.Label();
            this.txbVilleClient = new System.Windows.Forms.TextBox();
            this.txbVille = new System.Windows.Forms.Label();
            this.lblCpClient = new System.Windows.Forms.Label();
            this.txbCpClient = new System.Windows.Forms.TextBox();
            this.cbxNomClient = new System.Windows.Forms.ComboBox();
            this.txbCodeClient = new System.Windows.Forms.TextBox();
            this.cbxRaisonClient = new System.Windows.Forms.ComboBox();
            this.txbAdresseClient = new System.Windows.Forms.TextBox();
            this.txbTypeClient = new System.Windows.Forms.TextBox();
            this.lblMailClient = new System.Windows.Forms.Label();
            this.txbMailClient = new System.Windows.Forms.TextBox();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblTypeClient = new System.Windows.Forms.Label();
            this.lblCodeClient = new System.Windows.Forms.Label();
            this.lblAdresseClient = new System.Windows.Forms.Label();
            this.lblRaisonClient = new System.Windows.Forms.Label();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.tabCommandes = new System.Windows.Forms.TabPage();
            this.tabCommandesA = new System.Windows.Forms.TabControl();
            this.tabCommandesAfficher = new System.Windows.Forms.TabPage();
            this.GrbModificationEtat = new System.Windows.Forms.GroupBox();
            this.BtnModifierEtatCommande = new System.Windows.Forms.Button();
            this.CbxEtatCommande = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GrbAfficheProduit = new System.Windows.Forms.GroupBox();
            this.DgvListeCommande = new System.Windows.Forms.DataGridView();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrbSelectionCommande = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNumeroCommande = new System.Windows.Forms.Label();
            this.CbxNumeroCommande = new System.Windows.Forms.ComboBox();
            this.GrbCommandeAffiche = new System.Windows.Forms.GroupBox();
            this.LblClientCommandeAffiche = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblDateCommandeAffiche = new System.Windows.Forms.Label();
            this.LblDateCommade = new System.Windows.Forms.Label();
            this.tabCommandesAjouter = new System.Windows.Forms.TabPage();
            this.GrbLesProduitsAjouter = new System.Windows.Forms.GroupBox();
            this.DgvCommandeLesProduitAjouter = new System.Windows.Forms.DataGridView();
            this.LesProduitsAjouter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LesProduitsAjouterQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCommandeAjoutProduit = new System.Windows.Forms.GroupBox();
            this.btnAjoutCommandeLigneProduit = new System.Windows.Forms.Button();
            this.CbxProduitCommande = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtQuantiteCommande = new System.Windows.Forms.TextBox();
            this.GrbCommandeAjout = new System.Windows.Forms.GroupBox();
            this.lblClientAjoutCommande = new System.Windows.Forms.Label();
            this.txtNumeroCommande = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxClientCommandeAjout = new System.Windows.Forms.ComboBox();
            this.BtnAjoutCommande = new System.Windows.Forms.Button();
            this.tabMenuPrincipal.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            this.tabProduits.SuspendLayout();
            this.tabMenuProduits.SuspendLayout();
            this.tabProduitsConsulter.SuspendLayout();
            this.tabProduitsAjouter.SuspendLayout();
            this.tabClients.SuspendLayout();
            this.gpbAgendaClient.SuspendLayout();
            this.gpbRdvClient.SuspendLayout();
            this.gbAjouterVisite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaClient)).BeginInit();
            this.gbsClient.SuspendLayout();
            this.tabCommandes.SuspendLayout();
            this.tabCommandesA.SuspendLayout();
            this.tabCommandesAfficher.SuspendLayout();
            this.GrbModificationEtat.SuspendLayout();
            this.GrbAfficheProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListeCommande)).BeginInit();
            this.GrbSelectionCommande.SuspendLayout();
            this.GrbCommandeAffiche.SuspendLayout();
            this.tabCommandesAjouter.SuspendLayout();
            this.GrbLesProduitsAjouter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCommandeLesProduitAjouter)).BeginInit();
            this.grbCommandeAjoutProduit.SuspendLayout();
            this.GrbCommandeAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenuPrincipal
            // 
            this.tabMenuPrincipal.Controls.Add(this.tabAccueil);
            this.tabMenuPrincipal.Controls.Add(this.tabProduits);
            this.tabMenuPrincipal.Controls.Add(this.tabClients);
            this.tabMenuPrincipal.Controls.Add(this.tabCommandes);
            this.tabMenuPrincipal.Location = new System.Drawing.Point(2, -2);
            this.tabMenuPrincipal.Name = "tabMenuPrincipal";
            this.tabMenuPrincipal.SelectedIndex = 0;
            this.tabMenuPrincipal.Size = new System.Drawing.Size(847, 483);
            this.tabMenuPrincipal.TabIndex = 0;
            // 
            // tabAccueil
            // 
            this.tabAccueil.Controls.Add(this.richTextBox1);
            this.tabAccueil.Controls.Add(this.lblExplicationsAppplication);
            this.tabAccueil.Location = new System.Drawing.Point(4, 22);
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccueil.Size = new System.Drawing.Size(839, 457);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            this.tabAccueil.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(152, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(511, 135);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Bonjour et bienvenue sur l\'application GSB !\n ";
            // 
            // lblExplicationsAppplication
            // 
            this.lblExplicationsAppplication.AutoSize = true;
            this.lblExplicationsAppplication.Location = new System.Drawing.Point(285, 128);
            this.lblExplicationsAppplication.Name = "lblExplicationsAppplication";
            this.lblExplicationsAppplication.Size = new System.Drawing.Size(0, 13);
            this.lblExplicationsAppplication.TabIndex = 0;
            // 
            // tabProduits
            // 
            this.tabProduits.Controls.Add(this.tabMenuProduits);
            this.tabProduits.Location = new System.Drawing.Point(4, 22);
            this.tabProduits.Name = "tabProduits";
            this.tabProduits.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduits.Size = new System.Drawing.Size(839, 457);
            this.tabProduits.TabIndex = 1;
            this.tabProduits.Text = "Produits";
            this.tabProduits.UseVisualStyleBackColor = true;
            // 
            // tabMenuProduits
            // 
            this.tabMenuProduits.Controls.Add(this.tabProduitsConsulter);
            this.tabMenuProduits.Controls.Add(this.tabProduitsAjouter);
            this.tabMenuProduits.Location = new System.Drawing.Point(6, 3);
            this.tabMenuProduits.Name = "tabMenuProduits";
            this.tabMenuProduits.SelectedIndex = 0;
            this.tabMenuProduits.Size = new System.Drawing.Size(687, 260);
            this.tabMenuProduits.TabIndex = 0;
            // 
            // tabProduitsConsulter
            // 
            this.tabProduitsConsulter.AllowDrop = true;
            this.tabProduitsConsulter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProduitsConsulter.Controls.Add(this.btnSupprimerProduit);
            this.tabProduitsConsulter.Controls.Add(this.btnModifierProduit);
            this.tabProduitsConsulter.Controls.Add(this.lblInteraction);
            this.tabProduitsConsulter.Controls.Add(this.lblEffets);
            this.tabProduitsConsulter.Controls.Add(this.lblContreIndication);
            this.tabProduitsConsulter.Controls.Add(this.lblPrixProduit);
            this.tabProduitsConsulter.Controls.Add(this.lblNumProduit);
            this.tabProduitsConsulter.Controls.Add(this.lblNomProduit);
            this.tabProduitsConsulter.Controls.Add(this.lsbInteraction);
            this.tabProduitsConsulter.Controls.Add(this.lsbEffets);
            this.tabProduitsConsulter.Controls.Add(this.lsbContreIndication);
            this.tabProduitsConsulter.Controls.Add(this.txbPrixProduit);
            this.tabProduitsConsulter.Controls.Add(this.txbNumProduit);
            this.tabProduitsConsulter.Controls.Add(this.cbxNomProduit);
            this.tabProduitsConsulter.Location = new System.Drawing.Point(4, 22);
            this.tabProduitsConsulter.Name = "tabProduitsConsulter";
            this.tabProduitsConsulter.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduitsConsulter.Size = new System.Drawing.Size(679, 234);
            this.tabProduitsConsulter.TabIndex = 0;
            this.tabProduitsConsulter.Text = "Consulter";
            this.tabProduitsConsulter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerProduit
            // 
            this.btnSupprimerProduit.Location = new System.Drawing.Point(536, 121);
            this.btnSupprimerProduit.Name = "btnSupprimerProduit";
            this.btnSupprimerProduit.Size = new System.Drawing.Size(115, 45);
            this.btnSupprimerProduit.TabIndex = 13;
            this.btnSupprimerProduit.Text = "Supprimer";
            this.btnSupprimerProduit.UseVisualStyleBackColor = true;
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Location = new System.Drawing.Point(536, 47);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(115, 45);
            this.btnModifierProduit.TabIndex = 12;
            this.btnModifierProduit.Text = "Modifier";
            this.btnModifierProduit.UseVisualStyleBackColor = true;
            // 
            // lblInteraction
            // 
            this.lblInteraction.AutoSize = true;
            this.lblInteraction.Location = new System.Drawing.Point(281, 121);
            this.lblInteraction.Name = "lblInteraction";
            this.lblInteraction.Size = new System.Drawing.Size(68, 13);
            this.lblInteraction.TabIndex = 11;
            this.lblInteraction.Text = "Interactions :";
            // 
            // lblEffets
            // 
            this.lblEffets.AutoSize = true;
            this.lblEffets.Location = new System.Drawing.Point(15, 121);
            this.lblEffets.Name = "lblEffets";
            this.lblEffets.Size = new System.Drawing.Size(40, 13);
            this.lblEffets.TabIndex = 10;
            this.lblEffets.Text = "Effets :";
            // 
            // lblContreIndication
            // 
            this.lblContreIndication.AutoSize = true;
            this.lblContreIndication.Location = new System.Drawing.Point(252, 11);
            this.lblContreIndication.Name = "lblContreIndication";
            this.lblContreIndication.Size = new System.Drawing.Size(97, 13);
            this.lblContreIndication.TabIndex = 9;
            this.lblContreIndication.Text = "Contre indications :";
            // 
            // lblPrixProduit
            // 
            this.lblPrixProduit.AutoSize = true;
            this.lblPrixProduit.Location = new System.Drawing.Point(15, 89);
            this.lblPrixProduit.Name = "lblPrixProduit";
            this.lblPrixProduit.Size = new System.Drawing.Size(48, 13);
            this.lblPrixProduit.TabIndex = 8;
            this.lblPrixProduit.Text = "Prix HT :";
            // 
            // lblNumProduit
            // 
            this.lblNumProduit.AutoSize = true;
            this.lblNumProduit.Location = new System.Drawing.Point(15, 63);
            this.lblNumProduit.Name = "lblNumProduit";
            this.lblNumProduit.Size = new System.Drawing.Size(25, 13);
            this.lblNumProduit.TabIndex = 7;
            this.lblNumProduit.Text = "N° :";
            // 
            // lblNomProduit
            // 
            this.lblNomProduit.AutoSize = true;
            this.lblNomProduit.Location = new System.Drawing.Point(15, 36);
            this.lblNomProduit.Name = "lblNomProduit";
            this.lblNomProduit.Size = new System.Drawing.Size(35, 13);
            this.lblNomProduit.TabIndex = 6;
            this.lblNomProduit.Text = "Nom :";
            // 
            // lsbInteraction
            // 
            this.lsbInteraction.FormattingEnabled = true;
            this.lsbInteraction.Location = new System.Drawing.Point(355, 121);
            this.lsbInteraction.Name = "lsbInteraction";
            this.lsbInteraction.Size = new System.Drawing.Size(120, 95);
            this.lsbInteraction.TabIndex = 5;
            // 
            // lsbEffets
            // 
            this.lsbEffets.FormattingEnabled = true;
            this.lsbEffets.Location = new System.Drawing.Point(67, 121);
            this.lsbEffets.Name = "lsbEffets";
            this.lsbEffets.Size = new System.Drawing.Size(120, 95);
            this.lsbEffets.TabIndex = 4;
            // 
            // lsbContreIndication
            // 
            this.lsbContreIndication.FormattingEnabled = true;
            this.lsbContreIndication.Location = new System.Drawing.Point(355, 11);
            this.lsbContreIndication.Name = "lsbContreIndication";
            this.lsbContreIndication.Size = new System.Drawing.Size(120, 95);
            this.lsbContreIndication.TabIndex = 3;
            // 
            // txbPrixProduit
            // 
            this.txbPrixProduit.Location = new System.Drawing.Point(67, 86);
            this.txbPrixProduit.Name = "txbPrixProduit";
            this.txbPrixProduit.Size = new System.Drawing.Size(120, 20);
            this.txbPrixProduit.TabIndex = 2;
            // 
            // txbNumProduit
            // 
            this.txbNumProduit.Location = new System.Drawing.Point(67, 60);
            this.txbNumProduit.Name = "txbNumProduit";
            this.txbNumProduit.Size = new System.Drawing.Size(120, 20);
            this.txbNumProduit.TabIndex = 1;
            // 
            // cbxNomProduit
            // 
            this.cbxNomProduit.FormattingEnabled = true;
            this.cbxNomProduit.Location = new System.Drawing.Point(67, 33);
            this.cbxNomProduit.Name = "cbxNomProduit";
            this.cbxNomProduit.Size = new System.Drawing.Size(121, 21);
            this.cbxNomProduit.TabIndex = 0;
            // 
            // tabProduitsAjouter
            // 
            this.tabProduitsAjouter.Controls.Add(this.BtnAjoutProduit);
            this.tabProduitsAjouter.Controls.Add(this.label11);
            this.tabProduitsAjouter.Controls.Add(this.label10);
            this.tabProduitsAjouter.Controls.Add(this.label9);
            this.tabProduitsAjouter.Controls.Add(this.label7);
            this.tabProduitsAjouter.Controls.Add(this.RtxtContreIndicationProduitAjout);
            this.tabProduitsAjouter.Controls.Add(this.label4);
            this.tabProduitsAjouter.Controls.Add(this.label6);
            this.tabProduitsAjouter.Controls.Add(this.RtxtInteractionProduitAjout);
            this.tabProduitsAjouter.Controls.Add(this.RtxtEffetProduitAjout);
            this.tabProduitsAjouter.Controls.Add(this.TxtPrixProduitAjout);
            this.tabProduitsAjouter.Controls.Add(this.TxtNumeroProduitAjout);
            this.tabProduitsAjouter.Controls.Add(this.TxtNameProduitAjout);
            this.tabProduitsAjouter.Location = new System.Drawing.Point(4, 22);
            this.tabProduitsAjouter.Name = "tabProduitsAjouter";
            this.tabProduitsAjouter.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduitsAjouter.Size = new System.Drawing.Size(679, 234);
            this.tabProduitsAjouter.TabIndex = 1;
            this.tabProduitsAjouter.Text = "Ajouter";
            this.tabProduitsAjouter.UseVisualStyleBackColor = true;
            this.tabProduitsAjouter.UseWaitCursor = true;
            // 
            // BtnAjoutProduit
            // 
            this.BtnAjoutProduit.Location = new System.Drawing.Point(284, 195);
            this.BtnAjoutProduit.Name = "BtnAjoutProduit";
            this.BtnAjoutProduit.Size = new System.Drawing.Size(112, 23);
            this.BtnAjoutProduit.TabIndex = 16;
            this.BtnAjoutProduit.Text = "Ajouter Produit";
            this.BtnAjoutProduit.UseVisualStyleBackColor = true;
            this.BtnAjoutProduit.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Prix HT :";
            this.label11.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "N° :";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Effets :";
            this.label9.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Interactions :";
            this.label7.UseWaitCursor = true;
            // 
            // RtxtContreIndicationProduitAjout
            // 
            this.RtxtContreIndicationProduitAjout.Location = new System.Drawing.Point(409, 17);
            this.RtxtContreIndicationProduitAjout.Name = "RtxtContreIndicationProduitAjout";
            this.RtxtContreIndicationProduitAjout.Size = new System.Drawing.Size(237, 75);
            this.RtxtContreIndicationProduitAjout.TabIndex = 5;
            this.RtxtContreIndicationProduitAjout.Text = "";
            this.RtxtContreIndicationProduitAjout.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nom :";
            this.label4.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contre indications :";
            this.label6.UseWaitCursor = true;
            // 
            // RtxtInteractionProduitAjout
            // 
            this.RtxtInteractionProduitAjout.Location = new System.Drawing.Point(409, 101);
            this.RtxtInteractionProduitAjout.Name = "RtxtInteractionProduitAjout";
            this.RtxtInteractionProduitAjout.Size = new System.Drawing.Size(237, 75);
            this.RtxtInteractionProduitAjout.TabIndex = 6;
            this.RtxtInteractionProduitAjout.Text = "";
            this.RtxtInteractionProduitAjout.UseWaitCursor = true;
            // 
            // RtxtEffetProduitAjout
            // 
            this.RtxtEffetProduitAjout.Location = new System.Drawing.Point(85, 101);
            this.RtxtEffetProduitAjout.Name = "RtxtEffetProduitAjout";
            this.RtxtEffetProduitAjout.Size = new System.Drawing.Size(237, 75);
            this.RtxtEffetProduitAjout.TabIndex = 4;
            this.RtxtEffetProduitAjout.Text = "";
            this.RtxtEffetProduitAjout.UseWaitCursor = true;
            // 
            // TxtPrixProduitAjout
            // 
            this.TxtPrixProduitAjout.Location = new System.Drawing.Point(85, 75);
            this.TxtPrixProduitAjout.Name = "TxtPrixProduitAjout";
            this.TxtPrixProduitAjout.Size = new System.Drawing.Size(105, 20);
            this.TxtPrixProduitAjout.TabIndex = 3;
            this.TxtPrixProduitAjout.UseWaitCursor = true;
            // 
            // TxtNumeroProduitAjout
            // 
            this.TxtNumeroProduitAjout.Location = new System.Drawing.Point(85, 49);
            this.TxtNumeroProduitAjout.Name = "TxtNumeroProduitAjout";
            this.TxtNumeroProduitAjout.Size = new System.Drawing.Size(105, 20);
            this.TxtNumeroProduitAjout.TabIndex = 2;
            this.TxtNumeroProduitAjout.UseWaitCursor = true;
            // 
            // TxtNameProduitAjout
            // 
            this.TxtNameProduitAjout.Location = new System.Drawing.Point(85, 23);
            this.TxtNameProduitAjout.Name = "TxtNameProduitAjout";
            this.TxtNameProduitAjout.Size = new System.Drawing.Size(105, 20);
            this.TxtNameProduitAjout.TabIndex = 0;
            this.TxtNameProduitAjout.UseWaitCursor = true;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.btnSupprimerClient);
            this.tabClients.Controls.Add(this.btnModifierClient);
            this.tabClients.Controls.Add(this.gpbAgendaClient);
            this.tabClients.Controls.Add(this.gbsClient);
            this.tabClients.Controls.Add(this.btnAjouterClient);
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(839, 457);
            this.tabClients.TabIndex = 2;
            this.tabClients.Text = "Prospects / Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            this.tabClients.Click += new System.EventHandler(this.tabClients_Click);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Location = new System.Drawing.Point(208, 397);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(83, 43);
            this.btnSupprimerClient.TabIndex = 27;
            this.btnSupprimerClient.Text = "Supprimer";
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(109, 397);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(83, 43);
            this.btnModifierClient.TabIndex = 26;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // gpbAgendaClient
            // 
            this.gpbAgendaClient.Controls.Add(this.gpbRdvClient);
            this.gpbAgendaClient.Controls.Add(this.dgvAgendaClient);
            this.gpbAgendaClient.Location = new System.Drawing.Point(345, 6);
            this.gpbAgendaClient.Name = "gpbAgendaClient";
            this.gpbAgendaClient.Size = new System.Drawing.Size(488, 448);
            this.gpbAgendaClient.TabIndex = 25;
            this.gpbAgendaClient.TabStop = false;
            this.gpbAgendaClient.Text = "Agenda client";
            // 
            // gpbRdvClient
            // 
            this.gpbRdvClient.Controls.Add(this.gbAjouterVisite);
            this.gpbRdvClient.Controls.Add(this.rtbRdvClient);
            this.gpbRdvClient.Location = new System.Drawing.Point(6, 280);
            this.gpbRdvClient.Name = "gpbRdvClient";
            this.gpbRdvClient.Size = new System.Drawing.Size(474, 168);
            this.gpbRdvClient.TabIndex = 22;
            this.gpbRdvClient.TabStop = false;
            this.gpbRdvClient.Text = "Compte-rendu du rendez-vous";
            // 
            // gbAjouterVisite
            // 
            this.gbAjouterVisite.Controls.Add(this.txbVisiteurAjoutRdvClient);
            this.gbAjouterVisite.Controls.Add(this.lblSeparateurHeures);
            this.gbAjouterVisite.Controls.Add(this.txbMinutesRdv);
            this.gbAjouterVisite.Controls.Add(this.txbHeuresRDV);
            this.gbAjouterVisite.Controls.Add(this.lblHeureRdv);
            this.gbAjouterVisite.Controls.Add(this.dateRdvClient);
            this.gbAjouterVisite.Controls.Add(this.lblVisiteurRdv);
            this.gbAjouterVisite.Controls.Add(this.btnAjouterRdv);
            this.gbAjouterVisite.Controls.Add(this.lblDate);
            this.gbAjouterVisite.Location = new System.Drawing.Point(9, 80);
            this.gbAjouterVisite.Name = "gbAjouterVisite";
            this.gbAjouterVisite.Size = new System.Drawing.Size(459, 83);
            this.gbAjouterVisite.TabIndex = 23;
            this.gbAjouterVisite.TabStop = false;
            this.gbAjouterVisite.Text = "Ajouter visite";
            // 
            // txbVisiteurAjoutRdvClient
            // 
            this.txbVisiteurAjoutRdvClient.Location = new System.Drawing.Point(87, 48);
            this.txbVisiteurAjoutRdvClient.Name = "txbVisiteurAjoutRdvClient";
            this.txbVisiteurAjoutRdvClient.Size = new System.Drawing.Size(200, 20);
            this.txbVisiteurAjoutRdvClient.TabIndex = 31;
            // 
            // lblSeparateurHeures
            // 
            this.lblSeparateurHeures.AutoSize = true;
            this.lblSeparateurHeures.Location = new System.Drawing.Point(391, 22);
            this.lblSeparateurHeures.Name = "lblSeparateurHeures";
            this.lblSeparateurHeures.Size = new System.Drawing.Size(10, 13);
            this.lblSeparateurHeures.TabIndex = 9;
            this.lblSeparateurHeures.Text = ":";
            // 
            // txbMinutesRdv
            // 
            this.txbMinutesRdv.Location = new System.Drawing.Point(405, 18);
            this.txbMinutesRdv.Name = "txbMinutesRdv";
            this.txbMinutesRdv.Size = new System.Drawing.Size(34, 20);
            this.txbMinutesRdv.TabIndex = 8;
            // 
            // txbHeuresRDV
            // 
            this.txbHeuresRDV.Location = new System.Drawing.Point(351, 18);
            this.txbHeuresRDV.Name = "txbHeuresRDV";
            this.txbHeuresRDV.Size = new System.Drawing.Size(34, 20);
            this.txbHeuresRDV.TabIndex = 7;
            // 
            // lblHeureRdv
            // 
            this.lblHeureRdv.AutoSize = true;
            this.lblHeureRdv.Location = new System.Drawing.Point(307, 22);
            this.lblHeureRdv.Name = "lblHeureRdv";
            this.lblHeureRdv.Size = new System.Drawing.Size(42, 13);
            this.lblHeureRdv.TabIndex = 6;
            this.lblHeureRdv.Text = "Heure :";
            // 
            // dateRdvClient
            // 
            this.dateRdvClient.Location = new System.Drawing.Point(87, 19);
            this.dateRdvClient.Name = "dateRdvClient";
            this.dateRdvClient.Size = new System.Drawing.Size(200, 20);
            this.dateRdvClient.TabIndex = 5;
            // 
            // lblVisiteurRdv
            // 
            this.lblVisiteurRdv.AutoSize = true;
            this.lblVisiteurRdv.Location = new System.Drawing.Point(15, 51);
            this.lblVisiteurRdv.Name = "lblVisiteurRdv";
            this.lblVisiteurRdv.Size = new System.Drawing.Size(47, 13);
            this.lblVisiteurRdv.TabIndex = 3;
            this.lblVisiteurRdv.Text = "Visiteur :";
            this.lblVisiteurRdv.Click += new System.EventHandler(this.lblVisiteurRdv_Click);
            // 
            // btnAjouterRdv
            // 
            this.btnAjouterRdv.Location = new System.Drawing.Point(358, 51);
            this.btnAjouterRdv.Name = "btnAjouterRdv";
            this.btnAjouterRdv.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterRdv.TabIndex = 2;
            this.btnAjouterRdv.Text = "Ajouter";
            this.btnAjouterRdv.UseVisualStyleBackColor = true;
            this.btnAjouterRdv.Click += new System.EventHandler(this.btnAjouterRdv_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date :";
            // 
            // rtbRdvClient
            // 
            this.rtbRdvClient.Location = new System.Drawing.Point(6, 14);
            this.rtbRdvClient.Name = "rtbRdvClient";
            this.rtbRdvClient.Size = new System.Drawing.Size(462, 59);
            this.rtbRdvClient.TabIndex = 22;
            this.rtbRdvClient.Text = "Entrez le contenu du compte-rendu ici ...";
            // 
            // dgvAgendaClient
            // 
            this.dgvAgendaClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColonneDate,
            this.dgvHeure,
            this.dgvColonneVisiteur,
            this.dgvCompteRendu});
            this.dgvAgendaClient.Location = new System.Drawing.Point(12, 16);
            this.dgvAgendaClient.Name = "dgvAgendaClient";
            this.dgvAgendaClient.Size = new System.Drawing.Size(465, 255);
            this.dgvAgendaClient.TabIndex = 21;
            // 
            // dgvColonneDate
            // 
            this.dgvColonneDate.HeaderText = "Date";
            this.dgvColonneDate.Name = "dgvColonneDate";
            // 
            // dgvHeure
            // 
            this.dgvHeure.HeaderText = "Heure";
            this.dgvHeure.Name = "dgvHeure";
            // 
            // dgvColonneVisiteur
            // 
            this.dgvColonneVisiteur.HeaderText = "Visiteur";
            this.dgvColonneVisiteur.Name = "dgvColonneVisiteur";
            // 
            // dgvCompteRendu
            // 
            this.dgvCompteRendu.HeaderText = "Compte rendu";
            this.dgvCompteRendu.Name = "dgvCompteRendu";
            // 
            // gbsClient
            // 
            this.gbsClient.Controls.Add(this.txbTelephoneClient);
            this.gbsClient.Controls.Add(this.lblTelephoneClient);
            this.gbsClient.Controls.Add(this.txbPrenomClient);
            this.gbsClient.Controls.Add(this.lblPrenomClient);
            this.gbsClient.Controls.Add(this.txbVilleClient);
            this.gbsClient.Controls.Add(this.txbVille);
            this.gbsClient.Controls.Add(this.lblCpClient);
            this.gbsClient.Controls.Add(this.txbCpClient);
            this.gbsClient.Controls.Add(this.cbxNomClient);
            this.gbsClient.Controls.Add(this.txbCodeClient);
            this.gbsClient.Controls.Add(this.cbxRaisonClient);
            this.gbsClient.Controls.Add(this.txbAdresseClient);
            this.gbsClient.Controls.Add(this.txbTypeClient);
            this.gbsClient.Controls.Add(this.lblMailClient);
            this.gbsClient.Controls.Add(this.txbMailClient);
            this.gbsClient.Controls.Add(this.lblNomClient);
            this.gbsClient.Controls.Add(this.lblTypeClient);
            this.gbsClient.Controls.Add(this.lblCodeClient);
            this.gbsClient.Controls.Add(this.lblAdresseClient);
            this.gbsClient.Controls.Add(this.lblRaisonClient);
            this.gbsClient.Location = new System.Drawing.Point(6, 6);
            this.gbsClient.Name = "gbsClient";
            this.gbsClient.Size = new System.Drawing.Size(311, 368);
            this.gbsClient.TabIndex = 24;
            this.gbsClient.TabStop = false;
            this.gbsClient.Text = "Client";
            // 
            // txbTelephoneClient
            // 
            this.txbTelephoneClient.Location = new System.Drawing.Point(98, 328);
            this.txbTelephoneClient.Name = "txbTelephoneClient";
            this.txbTelephoneClient.Size = new System.Drawing.Size(134, 20);
            this.txbTelephoneClient.TabIndex = 30;
            // 
            // lblTelephoneClient
            // 
            this.lblTelephoneClient.AutoSize = true;
            this.lblTelephoneClient.Location = new System.Drawing.Point(9, 331);
            this.lblTelephoneClient.Name = "lblTelephoneClient";
            this.lblTelephoneClient.Size = new System.Drawing.Size(64, 13);
            this.lblTelephoneClient.TabIndex = 29;
            this.lblTelephoneClient.Text = "Téléphone :";
            // 
            // txbPrenomClient
            // 
            this.txbPrenomClient.Location = new System.Drawing.Point(97, 58);
            this.txbPrenomClient.Name = "txbPrenomClient";
            this.txbPrenomClient.Size = new System.Drawing.Size(134, 20);
            this.txbPrenomClient.TabIndex = 28;
            // 
            // lblPrenomClient
            // 
            this.lblPrenomClient.AutoSize = true;
            this.lblPrenomClient.Location = new System.Drawing.Point(25, 61);
            this.lblPrenomClient.Name = "lblPrenomClient";
            this.lblPrenomClient.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomClient.TabIndex = 27;
            this.lblPrenomClient.Text = "Prenom :";
            // 
            // txbVilleClient
            // 
            this.txbVilleClient.Location = new System.Drawing.Point(98, 231);
            this.txbVilleClient.Name = "txbVilleClient";
            this.txbVilleClient.Size = new System.Drawing.Size(136, 20);
            this.txbVilleClient.TabIndex = 26;
            // 
            // txbVille
            // 
            this.txbVille.AutoSize = true;
            this.txbVille.Location = new System.Drawing.Point(41, 234);
            this.txbVille.Name = "txbVille";
            this.txbVille.Size = new System.Drawing.Size(32, 13);
            this.txbVille.TabIndex = 25;
            this.txbVille.Text = "Ville :";
            // 
            // lblCpClient
            // 
            this.lblCpClient.AutoSize = true;
            this.lblCpClient.Location = new System.Drawing.Point(47, 198);
            this.lblCpClient.Name = "lblCpClient";
            this.lblCpClient.Size = new System.Drawing.Size(26, 13);
            this.lblCpClient.TabIndex = 24;
            this.lblCpClient.Text = "Cp :";
            // 
            // txbCpClient
            // 
            this.txbCpClient.Location = new System.Drawing.Point(98, 198);
            this.txbCpClient.Name = "txbCpClient";
            this.txbCpClient.Size = new System.Drawing.Size(134, 20);
            this.txbCpClient.TabIndex = 23;
            // 
            // cbxNomClient
            // 
            this.cbxNomClient.FormattingEnabled = true;
            this.cbxNomClient.Location = new System.Drawing.Point(97, 24);
            this.cbxNomClient.Name = "cbxNomClient";
            this.cbxNomClient.Size = new System.Drawing.Size(136, 21);
            this.cbxNomClient.TabIndex = 0;
            this.cbxNomClient.SelectedIndexChanged += new System.EventHandler(this.cbxNomClient_SelectedIndexChanged);
            this.cbxNomClient.RightToLeftChanged += new System.EventHandler(this.cbxNomClient_RightToLeftChanged);
            this.cbxNomClient.TextChanged += new System.EventHandler(this.cbxNomClient_TextChanged);
            // 
            // txbCodeClient
            // 
            this.txbCodeClient.Location = new System.Drawing.Point(96, 93);
            this.txbCodeClient.Name = "txbCodeClient";
            this.txbCodeClient.Size = new System.Drawing.Size(136, 20);
            this.txbCodeClient.TabIndex = 1;
            // 
            // cbxRaisonClient
            // 
            this.cbxRaisonClient.FormattingEnabled = true;
            this.cbxRaisonClient.Location = new System.Drawing.Point(96, 128);
            this.cbxRaisonClient.Name = "cbxRaisonClient";
            this.cbxRaisonClient.Size = new System.Drawing.Size(136, 21);
            this.cbxRaisonClient.TabIndex = 20;
            // 
            // txbAdresseClient
            // 
            this.txbAdresseClient.Location = new System.Drawing.Point(98, 163);
            this.txbAdresseClient.Name = "txbAdresseClient";
            this.txbAdresseClient.Size = new System.Drawing.Size(136, 20);
            this.txbAdresseClient.TabIndex = 6;
            // 
            // txbTypeClient
            // 
            this.txbTypeClient.Location = new System.Drawing.Point(98, 265);
            this.txbTypeClient.Name = "txbTypeClient";
            this.txbTypeClient.Size = new System.Drawing.Size(136, 20);
            this.txbTypeClient.TabIndex = 5;
            // 
            // lblMailClient
            // 
            this.lblMailClient.AutoSize = true;
            this.lblMailClient.Location = new System.Drawing.Point(41, 303);
            this.lblMailClient.Name = "lblMailClient";
            this.lblMailClient.Size = new System.Drawing.Size(32, 13);
            this.lblMailClient.TabIndex = 15;
            this.lblMailClient.Text = "Mail :";
            // 
            // txbMailClient
            // 
            this.txbMailClient.Location = new System.Drawing.Point(98, 296);
            this.txbMailClient.Name = "txbMailClient";
            this.txbMailClient.Size = new System.Drawing.Size(136, 20);
            this.txbMailClient.TabIndex = 8;
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(38, 27);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(35, 13);
            this.lblNomClient.TabIndex = 9;
            this.lblNomClient.Text = "Nom :";
            // 
            // lblTypeClient
            // 
            this.lblTypeClient.AutoSize = true;
            this.lblTypeClient.Location = new System.Drawing.Point(36, 268);
            this.lblTypeClient.Name = "lblTypeClient";
            this.lblTypeClient.Size = new System.Drawing.Size(37, 13);
            this.lblTypeClient.TabIndex = 13;
            this.lblTypeClient.Text = "Type :";
            // 
            // lblCodeClient
            // 
            this.lblCodeClient.AutoSize = true;
            this.lblCodeClient.Location = new System.Drawing.Point(15, 94);
            this.lblCodeClient.Name = "lblCodeClient";
            this.lblCodeClient.Size = new System.Drawing.Size(59, 13);
            this.lblCodeClient.TabIndex = 10;
            this.lblCodeClient.Text = "Identifiant :";
            // 
            // lblAdresseClient
            // 
            this.lblAdresseClient.AutoSize = true;
            this.lblAdresseClient.Location = new System.Drawing.Point(23, 166);
            this.lblAdresseClient.Name = "lblAdresseClient";
            this.lblAdresseClient.Size = new System.Drawing.Size(51, 13);
            this.lblAdresseClient.TabIndex = 12;
            this.lblAdresseClient.Text = "Adresse :";
            // 
            // lblRaisonClient
            // 
            this.lblRaisonClient.AutoSize = true;
            this.lblRaisonClient.Location = new System.Drawing.Point(3, 131);
            this.lblRaisonClient.Name = "lblRaisonClient";
            this.lblRaisonClient.Size = new System.Drawing.Size(82, 13);
            this.lblRaisonClient.TabIndex = 11;
            this.lblRaisonClient.Text = "Raison sociale :";
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(10, 397);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(83, 43);
            this.btnAjouterClient.TabIndex = 18;
            this.btnAjouterClient.Text = "Créer un client";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // tabCommandes
            // 
            this.tabCommandes.Controls.Add(this.tabCommandesA);
            this.tabCommandes.Location = new System.Drawing.Point(4, 22);
            this.tabCommandes.Name = "tabCommandes";
            this.tabCommandes.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommandes.Size = new System.Drawing.Size(839, 457);
            this.tabCommandes.TabIndex = 3;
            this.tabCommandes.Text = "Commandes";
            this.tabCommandes.UseVisualStyleBackColor = true;
            this.tabCommandes.Enter += new System.EventHandler(this.tabCommandes_Enter);
            // 
            // tabCommandesA
            // 
            this.tabCommandesA.Controls.Add(this.tabCommandesAfficher);
            this.tabCommandesA.Controls.Add(this.tabCommandesAjouter);
            this.tabCommandesA.Location = new System.Drawing.Point(0, 0);
            this.tabCommandesA.Name = "tabCommandesA";
            this.tabCommandesA.SelectedIndex = 0;
            this.tabCommandesA.Size = new System.Drawing.Size(839, 461);
            this.tabCommandesA.TabIndex = 0;
            // 
            // tabCommandesAfficher
            // 
            this.tabCommandesAfficher.Controls.Add(this.GrbModificationEtat);
            this.tabCommandesAfficher.Controls.Add(this.GrbAfficheProduit);
            this.tabCommandesAfficher.Controls.Add(this.GrbSelectionCommande);
            this.tabCommandesAfficher.Controls.Add(this.GrbCommandeAffiche);
            this.tabCommandesAfficher.Location = new System.Drawing.Point(4, 22);
            this.tabCommandesAfficher.Name = "tabCommandesAfficher";
            this.tabCommandesAfficher.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommandesAfficher.Size = new System.Drawing.Size(831, 435);
            this.tabCommandesAfficher.TabIndex = 0;
            this.tabCommandesAfficher.Text = "Afficher";
            this.tabCommandesAfficher.UseVisualStyleBackColor = true;
            // 
            // GrbModificationEtat
            // 
            this.GrbModificationEtat.Controls.Add(this.BtnModifierEtatCommande);
            this.GrbModificationEtat.Controls.Add(this.CbxEtatCommande);
            this.GrbModificationEtat.Controls.Add(this.label8);
            this.GrbModificationEtat.Location = new System.Drawing.Point(25, 226);
            this.GrbModificationEtat.Name = "GrbModificationEtat";
            this.GrbModificationEtat.Size = new System.Drawing.Size(436, 80);
            this.GrbModificationEtat.TabIndex = 13;
            this.GrbModificationEtat.TabStop = false;
            this.GrbModificationEtat.Text = "Modification de l\'état";
            this.GrbModificationEtat.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnModifierEtatCommande
            // 
            this.BtnModifierEtatCommande.Location = new System.Drawing.Point(292, 36);
            this.BtnModifierEtatCommande.Name = "BtnModifierEtatCommande";
            this.BtnModifierEtatCommande.Size = new System.Drawing.Size(138, 23);
            this.BtnModifierEtatCommande.TabIndex = 10;
            this.BtnModifierEtatCommande.Text = "Modifier état";
            this.BtnModifierEtatCommande.UseVisualStyleBackColor = true;
            this.BtnModifierEtatCommande.Click += new System.EventHandler(this.BtnModifierEtatCommande_Click);
            // 
            // CbxEtatCommande
            // 
            this.CbxEtatCommande.FormattingEnabled = true;
            this.CbxEtatCommande.Location = new System.Drawing.Point(131, 36);
            this.CbxEtatCommande.Name = "CbxEtatCommande";
            this.CbxEtatCommande.Size = new System.Drawing.Size(121, 21);
            this.CbxEtatCommande.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Etat :";
            // 
            // GrbAfficheProduit
            // 
            this.GrbAfficheProduit.Controls.Add(this.DgvListeCommande);
            this.GrbAfficheProduit.Location = new System.Drawing.Point(486, 10);
            this.GrbAfficheProduit.Name = "GrbAfficheProduit";
            this.GrbAfficheProduit.Size = new System.Drawing.Size(315, 246);
            this.GrbAfficheProduit.TabIndex = 12;
            this.GrbAfficheProduit.TabStop = false;
            this.GrbAfficheProduit.Text = "Les produits";
            // 
            // DgvListeCommande
            // 
            this.DgvListeCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListeCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produit,
            this.Quantite});
            this.DgvListeCommande.Location = new System.Drawing.Point(6, 19);
            this.DgvListeCommande.Name = "DgvListeCommande";
            this.DgvListeCommande.Size = new System.Drawing.Size(303, 221);
            this.DgvListeCommande.TabIndex = 0;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.Name = "Produit";
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            // 
            // GrbSelectionCommande
            // 
            this.GrbSelectionCommande.Controls.Add(this.label1);
            this.GrbSelectionCommande.Controls.Add(this.LblNumeroCommande);
            this.GrbSelectionCommande.Controls.Add(this.CbxNumeroCommande);
            this.GrbSelectionCommande.Location = new System.Drawing.Point(25, 10);
            this.GrbSelectionCommande.Name = "GrbSelectionCommande";
            this.GrbSelectionCommande.Size = new System.Drawing.Size(435, 76);
            this.GrbSelectionCommande.TabIndex = 15;
            this.GrbSelectionCommande.TabStop = false;
            this.GrbSelectionCommande.Text = "Sélèction Commande";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sélèctionner le numéro de la commande";
            // 
            // LblNumeroCommande
            // 
            this.LblNumeroCommande.AutoSize = true;
            this.LblNumeroCommande.Location = new System.Drawing.Point(10, 38);
            this.LblNumeroCommande.Name = "LblNumeroCommande";
            this.LblNumeroCommande.Size = new System.Drawing.Size(53, 13);
            this.LblNumeroCommande.TabIndex = 13;
            this.LblNumeroCommande.Text = "Numero : ";
            // 
            // CbxNumeroCommande
            // 
            this.CbxNumeroCommande.FormattingEnabled = true;
            this.CbxNumeroCommande.Location = new System.Drawing.Point(110, 35);
            this.CbxNumeroCommande.Name = "CbxNumeroCommande";
            this.CbxNumeroCommande.Size = new System.Drawing.Size(121, 21);
            this.CbxNumeroCommande.TabIndex = 12;
            this.CbxNumeroCommande.SelectedIndexChanged += new System.EventHandler(this.CbxNumeroCommande_SelectedIndexChanged_1);
            // 
            // GrbCommandeAffiche
            // 
            this.GrbCommandeAffiche.Controls.Add(this.LblClientCommandeAffiche);
            this.GrbCommandeAffiche.Controls.Add(this.label12);
            this.GrbCommandeAffiche.Controls.Add(this.LblDateCommandeAffiche);
            this.GrbCommandeAffiche.Controls.Add(this.LblDateCommade);
            this.GrbCommandeAffiche.Location = new System.Drawing.Point(25, 96);
            this.GrbCommandeAffiche.Name = "GrbCommandeAffiche";
            this.GrbCommandeAffiche.Size = new System.Drawing.Size(436, 105);
            this.GrbCommandeAffiche.TabIndex = 11;
            this.GrbCommandeAffiche.TabStop = false;
            this.GrbCommandeAffiche.Text = "Commande";
            // 
            // LblClientCommandeAffiche
            // 
            this.LblClientCommandeAffiche.AutoSize = true;
            this.LblClientCommandeAffiche.Location = new System.Drawing.Point(106, 74);
            this.LblClientCommandeAffiche.Name = "LblClientCommandeAffiche";
            this.LblClientCommandeAffiche.Size = new System.Drawing.Size(0, 13);
            this.LblClientCommandeAffiche.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Client :";
            // 
            // LblDateCommandeAffiche
            // 
            this.LblDateCommandeAffiche.AutoSize = true;
            this.LblDateCommandeAffiche.Location = new System.Drawing.Point(106, 36);
            this.LblDateCommandeAffiche.Name = "LblDateCommandeAffiche";
            this.LblDateCommandeAffiche.Size = new System.Drawing.Size(0, 13);
            this.LblDateCommandeAffiche.TabIndex = 3;
            // 
            // LblDateCommade
            // 
            this.LblDateCommade.AutoSize = true;
            this.LblDateCommade.Location = new System.Drawing.Point(9, 36);
            this.LblDateCommade.Name = "LblDateCommade";
            this.LblDateCommade.Size = new System.Drawing.Size(36, 13);
            this.LblDateCommade.TabIndex = 2;
            this.LblDateCommade.Text = "Date :";
            // 
            // tabCommandesAjouter
            // 
            this.tabCommandesAjouter.Controls.Add(this.GrbLesProduitsAjouter);
            this.tabCommandesAjouter.Controls.Add(this.grbCommandeAjoutProduit);
            this.tabCommandesAjouter.Controls.Add(this.GrbCommandeAjout);
            this.tabCommandesAjouter.Controls.Add(this.BtnAjoutCommande);
            this.tabCommandesAjouter.Location = new System.Drawing.Point(4, 22);
            this.tabCommandesAjouter.Name = "tabCommandesAjouter";
            this.tabCommandesAjouter.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommandesAjouter.Size = new System.Drawing.Size(831, 435);
            this.tabCommandesAjouter.TabIndex = 1;
            this.tabCommandesAjouter.Text = "Ajouter";
            this.tabCommandesAjouter.UseVisualStyleBackColor = true;
            // 
            // GrbLesProduitsAjouter
            // 
            this.GrbLesProduitsAjouter.Controls.Add(this.DgvCommandeLesProduitAjouter);
            this.GrbLesProduitsAjouter.Location = new System.Drawing.Point(512, 16);
            this.GrbLesProduitsAjouter.Name = "GrbLesProduitsAjouter";
            this.GrbLesProduitsAjouter.Size = new System.Drawing.Size(295, 264);
            this.GrbLesProduitsAjouter.TabIndex = 18;
            this.GrbLesProduitsAjouter.TabStop = false;
            this.GrbLesProduitsAjouter.Text = "Les produits ajoutés";
            // 
            // DgvCommandeLesProduitAjouter
            // 
            this.DgvCommandeLesProduitAjouter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCommandeLesProduitAjouter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LesProduitsAjouter,
            this.LesProduitsAjouterQuantite});
            this.DgvCommandeLesProduitAjouter.Location = new System.Drawing.Point(6, 19);
            this.DgvCommandeLesProduitAjouter.Name = "DgvCommandeLesProduitAjouter";
            this.DgvCommandeLesProduitAjouter.Size = new System.Drawing.Size(283, 239);
            this.DgvCommandeLesProduitAjouter.TabIndex = 18;
            // 
            // LesProduitsAjouter
            // 
            this.LesProduitsAjouter.HeaderText = "Produits";
            this.LesProduitsAjouter.Name = "LesProduitsAjouter";
            // 
            // LesProduitsAjouterQuantite
            // 
            this.LesProduitsAjouterQuantite.HeaderText = "Quantite";
            this.LesProduitsAjouterQuantite.Name = "LesProduitsAjouterQuantite";
            // 
            // grbCommandeAjoutProduit
            // 
            this.grbCommandeAjoutProduit.Controls.Add(this.btnAjoutCommandeLigneProduit);
            this.grbCommandeAjoutProduit.Controls.Add(this.CbxProduitCommande);
            this.grbCommandeAjoutProduit.Controls.Add(this.label3);
            this.grbCommandeAjoutProduit.Controls.Add(this.label2);
            this.grbCommandeAjoutProduit.Controls.Add(this.TxtQuantiteCommande);
            this.grbCommandeAjoutProduit.Location = new System.Drawing.Point(18, 142);
            this.grbCommandeAjoutProduit.Name = "grbCommandeAjoutProduit";
            this.grbCommandeAjoutProduit.Size = new System.Drawing.Size(488, 110);
            this.grbCommandeAjoutProduit.TabIndex = 17;
            this.grbCommandeAjoutProduit.TabStop = false;
            this.grbCommandeAjoutProduit.Text = "Ajout des produits";
            // 
            // btnAjoutCommandeLigneProduit
            // 
            this.btnAjoutCommandeLigneProduit.Location = new System.Drawing.Point(166, 69);
            this.btnAjoutCommandeLigneProduit.Name = "btnAjoutCommandeLigneProduit";
            this.btnAjoutCommandeLigneProduit.Size = new System.Drawing.Size(121, 23);
            this.btnAjoutCommandeLigneProduit.TabIndex = 18;
            this.btnAjoutCommandeLigneProduit.Text = "Ajouter produit";
            this.btnAjoutCommandeLigneProduit.UseVisualStyleBackColor = true;
            this.btnAjoutCommandeLigneProduit.Click += new System.EventHandler(this.btnAjoutCommandeLigneProduit_Click_1);
            // 
            // CbxProduitCommande
            // 
            this.CbxProduitCommande.FormattingEnabled = true;
            this.CbxProduitCommande.Location = new System.Drawing.Point(95, 30);
            this.CbxProduitCommande.Name = "CbxProduitCommande";
            this.CbxProduitCommande.Size = new System.Drawing.Size(121, 21);
            this.CbxProduitCommande.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantité :";
            // 
            // TxtQuantiteCommande
            // 
            this.TxtQuantiteCommande.Location = new System.Drawing.Point(336, 31);
            this.TxtQuantiteCommande.Name = "TxtQuantiteCommande";
            this.TxtQuantiteCommande.Size = new System.Drawing.Size(121, 20);
            this.TxtQuantiteCommande.TabIndex = 4;
            this.TxtQuantiteCommande.TextChanged += new System.EventHandler(this.TxtQuantiteCommande_TextChanged_1);
            this.TxtQuantiteCommande.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantiteCommande_KeyPress_1);
            // 
            // GrbCommandeAjout
            // 
            this.GrbCommandeAjout.Controls.Add(this.lblClientAjoutCommande);
            this.GrbCommandeAjout.Controls.Add(this.txtNumeroCommande);
            this.GrbCommandeAjout.Controls.Add(this.label5);
            this.GrbCommandeAjout.Controls.Add(this.CbxClientCommandeAjout);
            this.GrbCommandeAjout.Location = new System.Drawing.Point(18, 16);
            this.GrbCommandeAjout.Name = "GrbCommandeAjout";
            this.GrbCommandeAjout.Size = new System.Drawing.Size(488, 110);
            this.GrbCommandeAjout.TabIndex = 15;
            this.GrbCommandeAjout.TabStop = false;
            this.GrbCommandeAjout.Text = "Ajout Commande";
            // 
            // lblClientAjoutCommande
            // 
            this.lblClientAjoutCommande.AutoSize = true;
            this.lblClientAjoutCommande.Location = new System.Drawing.Point(16, 39);
            this.lblClientAjoutCommande.Name = "lblClientAjoutCommande";
            this.lblClientAjoutCommande.Size = new System.Drawing.Size(39, 13);
            this.lblClientAjoutCommande.TabIndex = 16;
            this.lblClientAjoutCommande.Text = "Client :";
            // 
            // txtNumeroCommande
            // 
            this.txtNumeroCommande.Location = new System.Drawing.Point(97, 67);
            this.txtNumeroCommande.Name = "txtNumeroCommande";
            this.txtNumeroCommande.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroCommande.TabIndex = 0;
            this.txtNumeroCommande.TextChanged += new System.EventHandler(this.txtNumeroCommande_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CbxClientCommandeAjout
            // 
            this.CbxClientCommandeAjout.FormattingEnabled = true;
            this.CbxClientCommandeAjout.Location = new System.Drawing.Point(97, 31);
            this.CbxClientCommandeAjout.Name = "CbxClientCommandeAjout";
            this.CbxClientCommandeAjout.Size = new System.Drawing.Size(121, 21);
            this.CbxClientCommandeAjout.TabIndex = 15;
            // 
            // BtnAjoutCommande
            // 
            this.BtnAjoutCommande.Location = new System.Drawing.Point(573, 327);
            this.BtnAjoutCommande.Name = "BtnAjoutCommande";
            this.BtnAjoutCommande.Size = new System.Drawing.Size(193, 74);
            this.BtnAjoutCommande.TabIndex = 13;
            this.BtnAjoutCommande.Text = "Ajouter Commande";
            this.BtnAjoutCommande.UseVisualStyleBackColor = true;
            this.BtnAjoutCommande.Click += new System.EventHandler(this.BtnAjoutCommande_Click_1);
            // 
            // FormGsb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 482);
            this.Controls.Add(this.tabMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGsb";
            this.Text = "Application GSB";
            this.Load += new System.EventHandler(this.FormGsb_Load);
            this.tabMenuPrincipal.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            this.tabProduits.ResumeLayout(false);
            this.tabMenuProduits.ResumeLayout(false);
            this.tabProduitsConsulter.ResumeLayout(false);
            this.tabProduitsConsulter.PerformLayout();
            this.tabProduitsAjouter.ResumeLayout(false);
            this.tabProduitsAjouter.PerformLayout();
            this.tabClients.ResumeLayout(false);
            this.gpbAgendaClient.ResumeLayout(false);
            this.gpbRdvClient.ResumeLayout(false);
            this.gbAjouterVisite.ResumeLayout(false);
            this.gbAjouterVisite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaClient)).EndInit();
            this.gbsClient.ResumeLayout(false);
            this.gbsClient.PerformLayout();
            this.tabCommandes.ResumeLayout(false);
            this.tabCommandesA.ResumeLayout(false);
            this.tabCommandesAfficher.ResumeLayout(false);
            this.GrbModificationEtat.ResumeLayout(false);
            this.GrbModificationEtat.PerformLayout();
            this.GrbAfficheProduit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListeCommande)).EndInit();
            this.GrbSelectionCommande.ResumeLayout(false);
            this.GrbSelectionCommande.PerformLayout();
            this.GrbCommandeAffiche.ResumeLayout(false);
            this.GrbCommandeAffiche.PerformLayout();
            this.tabCommandesAjouter.ResumeLayout(false);
            this.GrbLesProduitsAjouter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCommandeLesProduitAjouter)).EndInit();
            this.grbCommandeAjoutProduit.ResumeLayout(false);
            this.grbCommandeAjoutProduit.PerformLayout();
            this.GrbCommandeAjout.ResumeLayout(false);
            this.GrbCommandeAjout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenuPrincipal;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.TabPage tabProduits;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabCommandes;
        private System.Windows.Forms.Label lblExplicationsAppplication;
        private System.Windows.Forms.TabControl tabMenuProduits;
        private System.Windows.Forms.TabPage tabProduitsConsulter;
        private System.Windows.Forms.TabPage tabProduitsAjouter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbxRaisonClient;
        private System.Windows.Forms.Label lblMailClient;
        private System.Windows.Forms.Label lblTypeClient;
        private System.Windows.Forms.Label lblAdresseClient;
        private System.Windows.Forms.Label lblRaisonClient;
        private System.Windows.Forms.Label lblCodeClient;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.TextBox txbMailClient;
        private System.Windows.Forms.TextBox txbAdresseClient;
        private System.Windows.Forms.TextBox txbTypeClient;
        private System.Windows.Forms.TextBox txbCodeClient;
        private System.Windows.Forms.ComboBox cbxNomClient;
        private System.Windows.Forms.Button btnSupprimerProduit;
        private System.Windows.Forms.Button btnModifierProduit;
        private System.Windows.Forms.Label lblInteraction;
        private System.Windows.Forms.Label lblEffets;
        private System.Windows.Forms.Label lblContreIndication;
        private System.Windows.Forms.Label lblPrixProduit;
        private System.Windows.Forms.Label lblNumProduit;
        private System.Windows.Forms.Label lblNomProduit;
        private System.Windows.Forms.ListBox lsbInteraction;
        private System.Windows.Forms.ListBox lsbEffets;
        private System.Windows.Forms.ListBox lsbContreIndication;
        private System.Windows.Forms.TextBox txbPrixProduit;
        private System.Windows.Forms.TextBox txbNumProduit;
        private System.Windows.Forms.ComboBox cbxNomProduit;
        private System.Windows.Forms.TabControl tabCommandesA;
        private System.Windows.Forms.TabPage tabCommandesAfficher;
        private System.Windows.Forms.TabPage tabCommandesAjouter;
        private System.Windows.Forms.DataGridView dgvAgendaClient;
        private System.Windows.Forms.GroupBox gbsClient;
        private System.Windows.Forms.GroupBox gpbAgendaClient;
        private System.Windows.Forms.GroupBox gpbRdvClient;
        private System.Windows.Forms.RichTextBox rtbRdvClient;
        private System.Windows.Forms.GroupBox gbAjouterVisite;
        private System.Windows.Forms.Button btnAjouterRdv;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVisiteurRdv;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button BtnModifierEtatCommande;
        private System.Windows.Forms.ComboBox CbxEtatCommande;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblDateCommandeAffiche;
        private System.Windows.Forms.Label LblDateCommade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtQuantiteCommande;
        private System.Windows.Forms.TextBox txtNumeroCommande;
        private System.Windows.Forms.Button BtnAjoutCommande;
        private System.Windows.Forms.ComboBox CbxProduitCommande;
        private System.Windows.Forms.GroupBox GrbCommandeAjout;
        private System.Windows.Forms.GroupBox GrbCommandeAffiche;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RtxtContreIndicationProduitAjout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox RtxtInteractionProduitAjout;
        private System.Windows.Forms.RichTextBox RtxtEffetProduitAjout;
        private System.Windows.Forms.TextBox TxtPrixProduitAjout;
        private System.Windows.Forms.TextBox TxtNumeroProduitAjout;
        private System.Windows.Forms.TextBox TxtNameProduitAjout;
        private System.Windows.Forms.Button BtnAjoutProduit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateRdvClient;
        private System.Windows.Forms.ComboBox CbxClientCommandeAjout;
        private System.Windows.Forms.Label lblClientAjoutCommande;
        private System.Windows.Forms.TextBox txbCpClient;
        private System.Windows.Forms.Label lblCpClient;
        private System.Windows.Forms.TextBox txbVilleClient;
        private System.Windows.Forms.Label txbVille;
        private System.Windows.Forms.Label lblPrenomClient;
        private System.Windows.Forms.TextBox txbPrenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColonneDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColonneVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCompteRendu;
        private System.Windows.Forms.Label lblSeparateurHeures;
        private System.Windows.Forms.TextBox txbMinutesRdv;
        private System.Windows.Forms.TextBox txbHeuresRDV;
        private System.Windows.Forms.Label lblHeureRdv;
        private System.Windows.Forms.TextBox txbTelephoneClient;
        private System.Windows.Forms.Label lblTelephoneClient;
        private System.Windows.Forms.TextBox txbVisiteurAjoutRdvClient;
        private System.Windows.Forms.GroupBox GrbAfficheProduit;
        private System.Windows.Forms.GroupBox GrbSelectionCommande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNumeroCommande;
        private System.Windows.Forms.ComboBox CbxNumeroCommande;
        private System.Windows.Forms.DataGridView DgvListeCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.Label LblClientCommandeAffiche;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox GrbModificationEtat;
        private System.Windows.Forms.GroupBox grbCommandeAjoutProduit;
        private System.Windows.Forms.Button btnAjoutCommandeLigneProduit;
        private System.Windows.Forms.DataGridView DgvCommandeLesProduitAjouter;
        private System.Windows.Forms.GroupBox GrbLesProduitsAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn LesProduitsAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn LesProduitsAjouterQuantite;
    }
}

