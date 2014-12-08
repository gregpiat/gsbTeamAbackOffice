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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGsb));
            this.tabMenuPrincipal = new System.Windows.Forms.TabControl();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
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
            this.tabClients = new System.Windows.Forms.TabPage();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.gpbAgendaClient = new System.Windows.Forms.GroupBox();
            this.gpbRdvClient = new System.Windows.Forms.GroupBox();
            this.gbAjouterVisite = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblVisiteurRdv = new System.Windows.Forms.Label();
            this.btnAjouterRdv = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txbDateRdv = new System.Windows.Forms.TextBox();
            this.rtbRdvClient = new System.Windows.Forms.RichTextBox();
            this.dgvAgendaClient = new System.Windows.Forms.DataGridView();
            this.gbsClient = new System.Windows.Forms.GroupBox();
            this.cbxNomClient = new System.Windows.Forms.ComboBox();
            this.txbCodeClient = new System.Windows.Forms.TextBox();
            this.cbxRaisonClient = new System.Windows.Forms.ComboBox();
            this.txbAdresseClient = new System.Windows.Forms.TextBox();
            this.txbTypeClient = new System.Windows.Forms.TextBox();
            this.txbTelClient = new System.Windows.Forms.TextBox();
            this.lblTelClient = new System.Windows.Forms.Label();
            this.lblMailClient = new System.Windows.Forms.Label();
            this.lblDateClient = new System.Windows.Forms.Label();
            this.txbDateClient = new System.Windows.Forms.TextBox();
            this.txbContactClient = new System.Windows.Forms.TextBox();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblTypeClient = new System.Windows.Forms.Label();
            this.lblCodeClient = new System.Windows.Forms.Label();
            this.lblAdresseClient = new System.Windows.Forms.Label();
            this.lblRaisonClient = new System.Windows.Forms.Label();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.tabCommandes = new System.Windows.Forms.TabPage();
            this.tabCommandesA = new System.Windows.Forms.TabControl();
            this.tabCommandesAfficher = new System.Windows.Forms.TabPage();
            this.tabCommandesAjouter = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabMenuPrincipal.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            this.tabProduits.SuspendLayout();
            this.tabMenuProduits.SuspendLayout();
            this.tabProduitsConsulter.SuspendLayout();
            this.tabClients.SuspendLayout();
            this.gpbAgendaClient.SuspendLayout();
            this.gpbRdvClient.SuspendLayout();
            this.gbAjouterVisite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaClient)).BeginInit();
            this.gbsClient.SuspendLayout();
            this.tabCommandes.SuspendLayout();
            this.tabCommandesA.SuspendLayout();
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
            this.tabAccueil.Controls.Add(this.btnConnexion);
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
            this.richTextBox1.Location = new System.Drawing.Point(213, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(267, 143);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Bonjour et bienvenue sur l\'application GSB !\n ";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(6, 142);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(96, 28);
            this.btnConnexion.TabIndex = 1;
            this.btnConnexion.Text = "Me connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
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
            this.tabMenuProduits.Size = new System.Drawing.Size(682, 249);
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
            this.tabProduitsConsulter.Size = new System.Drawing.Size(674, 223);
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
            this.tabProduitsAjouter.Location = new System.Drawing.Point(4, 22);
            this.tabProduitsAjouter.Name = "tabProduitsAjouter";
            this.tabProduitsAjouter.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduitsAjouter.Size = new System.Drawing.Size(674, 223);
            this.tabProduitsAjouter.TabIndex = 1;
            this.tabProduitsAjouter.Text = "Ajouter";
            this.tabProduitsAjouter.UseVisualStyleBackColor = true;
            this.tabProduitsAjouter.UseWaitCursor = true;
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
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Location = new System.Drawing.Point(223, 365);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(83, 43);
            this.btnSupprimerClient.TabIndex = 27;
            this.btnSupprimerClient.Text = "Supprimer";
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(111, 365);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(83, 43);
            this.btnModifierClient.TabIndex = 26;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = true;
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
            this.gbAjouterVisite.Controls.Add(this.comboBox1);
            this.gbAjouterVisite.Controls.Add(this.lblVisiteurRdv);
            this.gbAjouterVisite.Controls.Add(this.btnAjouterRdv);
            this.gbAjouterVisite.Controls.Add(this.lblDate);
            this.gbAjouterVisite.Controls.Add(this.txbDateRdv);
            this.gbAjouterVisite.Location = new System.Drawing.Point(9, 80);
            this.gbAjouterVisite.Name = "gbAjouterVisite";
            this.gbAjouterVisite.Size = new System.Drawing.Size(459, 83);
            this.gbAjouterVisite.TabIndex = 23;
            this.gbAjouterVisite.TabStop = false;
            this.gbAjouterVisite.Text = "Ajouter visite";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lblVisiteurRdv
            // 
            this.lblVisiteurRdv.AutoSize = true;
            this.lblVisiteurRdv.Location = new System.Drawing.Point(37, 59);
            this.lblVisiteurRdv.Name = "lblVisiteurRdv";
            this.lblVisiteurRdv.Size = new System.Drawing.Size(47, 13);
            this.lblVisiteurRdv.TabIndex = 3;
            this.lblVisiteurRdv.Text = "Visiteur :";
            this.lblVisiteurRdv.Click += new System.EventHandler(this.lblVisiteurRdv_Click);
            // 
            // btnAjouterRdv
            // 
            this.btnAjouterRdv.Location = new System.Drawing.Point(315, 43);
            this.btnAjouterRdv.Name = "btnAjouterRdv";
            this.btnAjouterRdv.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterRdv.TabIndex = 2;
            this.btnAjouterRdv.Text = "Ajouter";
            this.btnAjouterRdv.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(37, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date :";
            // 
            // txbDateRdv
            // 
            this.txbDateRdv.Location = new System.Drawing.Point(124, 26);
            this.txbDateRdv.Name = "txbDateRdv";
            this.txbDateRdv.Size = new System.Drawing.Size(144, 20);
            this.txbDateRdv.TabIndex = 0;
            // 
            // rtbRdvClient
            // 
            this.rtbRdvClient.Location = new System.Drawing.Point(6, 14);
            this.rtbRdvClient.Name = "rtbRdvClient";
            this.rtbRdvClient.Size = new System.Drawing.Size(462, 59);
            this.rtbRdvClient.TabIndex = 22;
            this.rtbRdvClient.Text = "";
            // 
            // dgvAgendaClient
            // 
            this.dgvAgendaClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaClient.Location = new System.Drawing.Point(15, 19);
            this.dgvAgendaClient.Name = "dgvAgendaClient";
            this.dgvAgendaClient.Size = new System.Drawing.Size(465, 255);
            this.dgvAgendaClient.TabIndex = 21;
            // 
            // gbsClient
            // 
            this.gbsClient.Controls.Add(this.cbxNomClient);
            this.gbsClient.Controls.Add(this.txbCodeClient);
            this.gbsClient.Controls.Add(this.cbxRaisonClient);
            this.gbsClient.Controls.Add(this.txbAdresseClient);
            this.gbsClient.Controls.Add(this.txbTypeClient);
            this.gbsClient.Controls.Add(this.txbTelClient);
            this.gbsClient.Controls.Add(this.lblTelClient);
            this.gbsClient.Controls.Add(this.lblMailClient);
            this.gbsClient.Controls.Add(this.lblDateClient);
            this.gbsClient.Controls.Add(this.txbDateClient);
            this.gbsClient.Controls.Add(this.txbContactClient);
            this.gbsClient.Controls.Add(this.lblNomClient);
            this.gbsClient.Controls.Add(this.lblTypeClient);
            this.gbsClient.Controls.Add(this.lblCodeClient);
            this.gbsClient.Controls.Add(this.lblAdresseClient);
            this.gbsClient.Controls.Add(this.lblRaisonClient);
            this.gbsClient.Location = new System.Drawing.Point(6, 22);
            this.gbsClient.Name = "gbsClient";
            this.gbsClient.Size = new System.Drawing.Size(311, 315);
            this.gbsClient.TabIndex = 24;
            this.gbsClient.TabStop = false;
            this.gbsClient.Text = "Client";
            // 
            // cbxNomClient
            // 
            this.cbxNomClient.FormattingEnabled = true;
            this.cbxNomClient.Location = new System.Drawing.Point(83, 29);
            this.cbxNomClient.Name = "cbxNomClient";
            this.cbxNomClient.Size = new System.Drawing.Size(121, 21);
            this.cbxNomClient.TabIndex = 0;
            // 
            // txbCodeClient
            // 
            this.txbCodeClient.Location = new System.Drawing.Point(83, 65);
            this.txbCodeClient.Name = "txbCodeClient";
            this.txbCodeClient.Size = new System.Drawing.Size(121, 20);
            this.txbCodeClient.TabIndex = 1;
            // 
            // cbxRaisonClient
            // 
            this.cbxRaisonClient.FormattingEnabled = true;
            this.cbxRaisonClient.Location = new System.Drawing.Point(83, 102);
            this.cbxRaisonClient.Name = "cbxRaisonClient";
            this.cbxRaisonClient.Size = new System.Drawing.Size(121, 21);
            this.cbxRaisonClient.TabIndex = 20;
            // 
            // txbAdresseClient
            // 
            this.txbAdresseClient.Location = new System.Drawing.Point(83, 141);
            this.txbAdresseClient.Name = "txbAdresseClient";
            this.txbAdresseClient.Size = new System.Drawing.Size(121, 20);
            this.txbAdresseClient.TabIndex = 6;
            // 
            // txbTypeClient
            // 
            this.txbTypeClient.Location = new System.Drawing.Point(83, 179);
            this.txbTypeClient.Name = "txbTypeClient";
            this.txbTypeClient.Size = new System.Drawing.Size(121, 20);
            this.txbTypeClient.TabIndex = 5;
            // 
            // txbTelClient
            // 
            this.txbTelClient.Location = new System.Drawing.Point(83, 216);
            this.txbTelClient.Name = "txbTelClient";
            this.txbTelClient.Size = new System.Drawing.Size(121, 20);
            this.txbTelClient.TabIndex = 7;
            // 
            // lblTelClient
            // 
            this.lblTelClient.AutoSize = true;
            this.lblTelClient.Location = new System.Drawing.Point(21, 281);
            this.lblTelClient.Name = "lblTelClient";
            this.lblTelClient.Size = new System.Drawing.Size(36, 13);
            this.lblTelClient.TabIndex = 14;
            this.lblTelClient.Text = "Date :";
            // 
            // lblMailClient
            // 
            this.lblMailClient.AutoSize = true;
            this.lblMailClient.Location = new System.Drawing.Point(25, 251);
            this.lblMailClient.Name = "lblMailClient";
            this.lblMailClient.Size = new System.Drawing.Size(32, 13);
            this.lblMailClient.TabIndex = 15;
            this.lblMailClient.Text = "Mail :";
            // 
            // lblDateClient
            // 
            this.lblDateClient.AutoSize = true;
            this.lblDateClient.Location = new System.Drawing.Point(25, 219);
            this.lblDateClient.Name = "lblDateClient";
            this.lblDateClient.Size = new System.Drawing.Size(28, 13);
            this.lblDateClient.TabIndex = 16;
            this.lblDateClient.Text = "Tel :";
            // 
            // txbDateClient
            // 
            this.txbDateClient.Location = new System.Drawing.Point(83, 278);
            this.txbDateClient.Name = "txbDateClient";
            this.txbDateClient.Size = new System.Drawing.Size(121, 20);
            this.txbDateClient.TabIndex = 17;
            // 
            // txbContactClient
            // 
            this.txbContactClient.Location = new System.Drawing.Point(83, 248);
            this.txbContactClient.Name = "txbContactClient";
            this.txbContactClient.Size = new System.Drawing.Size(121, 20);
            this.txbContactClient.TabIndex = 8;
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(25, 32);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(35, 13);
            this.lblNomClient.TabIndex = 9;
            this.lblNomClient.Text = "Nom :";
            // 
            // lblTypeClient
            // 
            this.lblTypeClient.AutoSize = true;
            this.lblTypeClient.Location = new System.Drawing.Point(25, 182);
            this.lblTypeClient.Name = "lblTypeClient";
            this.lblTypeClient.Size = new System.Drawing.Size(37, 13);
            this.lblTypeClient.TabIndex = 13;
            this.lblTypeClient.Text = "Type :";
            // 
            // lblCodeClient
            // 
            this.lblCodeClient.AutoSize = true;
            this.lblCodeClient.Location = new System.Drawing.Point(25, 68);
            this.lblCodeClient.Name = "lblCodeClient";
            this.lblCodeClient.Size = new System.Drawing.Size(38, 13);
            this.lblCodeClient.TabIndex = 10;
            this.lblCodeClient.Text = "Code :";
            // 
            // lblAdresseClient
            // 
            this.lblAdresseClient.AutoSize = true;
            this.lblAdresseClient.Location = new System.Drawing.Point(25, 144);
            this.lblAdresseClient.Name = "lblAdresseClient";
            this.lblAdresseClient.Size = new System.Drawing.Size(51, 13);
            this.lblAdresseClient.TabIndex = 12;
            this.lblAdresseClient.Text = "Adresse :";
            // 
            // lblRaisonClient
            // 
            this.lblRaisonClient.AutoSize = true;
            this.lblRaisonClient.Location = new System.Drawing.Point(25, 105);
            this.lblRaisonClient.Name = "lblRaisonClient";
            this.lblRaisonClient.Size = new System.Drawing.Size(46, 13);
            this.lblRaisonClient.TabIndex = 11;
            this.lblRaisonClient.Text = "Raison :";
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(6, 365);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(83, 43);
            this.btnAjouterClient.TabIndex = 18;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
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
            // 
            // tabCommandesA
            // 
            this.tabCommandesA.Controls.Add(this.tabCommandesAfficher);
            this.tabCommandesA.Controls.Add(this.tabCommandesAjouter);
            this.tabCommandesA.Location = new System.Drawing.Point(0, 0);
            this.tabCommandesA.Name = "tabCommandesA";
            this.tabCommandesA.SelectedIndex = 0;
            this.tabCommandesA.Size = new System.Drawing.Size(692, 252);
            this.tabCommandesA.TabIndex = 0;
            // 
            // tabCommandesAfficher
            // 
            this.tabCommandesAfficher.Location = new System.Drawing.Point(4, 22);
            this.tabCommandesAfficher.Name = "tabCommandesAfficher";
            this.tabCommandesAfficher.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommandesAfficher.Size = new System.Drawing.Size(684, 226);
            this.tabCommandesAfficher.TabIndex = 0;
            this.tabCommandesAfficher.Text = "Afficher";
            this.tabCommandesAfficher.UseVisualStyleBackColor = true;
            // 
            // tabCommandesAjouter
            // 
            this.tabCommandesAjouter.Location = new System.Drawing.Point(4, 22);
            this.tabCommandesAjouter.Name = "tabCommandesAjouter";
            this.tabCommandesAjouter.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommandesAjouter.Size = new System.Drawing.Size(684, 226);
            this.tabCommandesAjouter.TabIndex = 1;
            this.tabCommandesAjouter.Text = "Ajouter";
            this.tabCommandesAjouter.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormGsb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 481);
            this.Controls.Add(this.tabMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGsb";
            this.Text = "Application GSB";
            this.tabMenuPrincipal.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            this.tabProduits.ResumeLayout(false);
            this.tabMenuProduits.ResumeLayout(false);
            this.tabProduitsConsulter.ResumeLayout(false);
            this.tabProduitsConsulter.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenuPrincipal;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.TabPage tabProduits;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabCommandes;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblExplicationsAppplication;
        private System.Windows.Forms.TabControl tabMenuProduits;
        private System.Windows.Forms.TabPage tabProduitsConsulter;
        private System.Windows.Forms.TabPage tabProduitsAjouter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbxRaisonClient;
        private System.Windows.Forms.TextBox txbDateClient;
        private System.Windows.Forms.Label lblDateClient;
        private System.Windows.Forms.Label lblMailClient;
        private System.Windows.Forms.Label lblTelClient;
        private System.Windows.Forms.Label lblTypeClient;
        private System.Windows.Forms.Label lblAdresseClient;
        private System.Windows.Forms.Label lblRaisonClient;
        private System.Windows.Forms.Label lblCodeClient;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.TextBox txbContactClient;
        private System.Windows.Forms.TextBox txbTelClient;
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
        private System.Windows.Forms.TextBox txbDateRdv;
        private System.Windows.Forms.Label lblVisiteurRdv;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAjouterClient;
    }
}

