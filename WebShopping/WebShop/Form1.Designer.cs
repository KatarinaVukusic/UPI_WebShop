namespace WebShop
{
    partial class frmKosarica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabShop = new System.Windows.Forms.TabControl();
            this.tabProizvodi = new System.Windows.Forms.TabPage();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblProizvodi = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lstPrikazProizvoda = new System.Windows.Forms.ListBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblNaruceno = new System.Windows.Forms.Label();
            this.btnDodajuKosaricu = new System.Windows.Forms.Button();
            this.tabPregledKosarica = new System.Windows.Forms.TabPage();
            this.lblPregledKosarice = new System.Windows.Forms.Label();
            this.btnPrijelazNaAdresu = new System.Windows.Forms.Button();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lstProizvodi = new System.Windows.Forms.ListBox();
            this.tabAdresa = new System.Windows.Forms.TabPage();
            this.lblUnosAdrese = new System.Windows.Forms.Label();
            this.btnUnosAdrese = new System.Windows.Forms.Button();
            this.cmbPostanskiBroj = new System.Windows.Forms.ComboBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtAdresaa = new System.Windows.Forms.TextBox();
            this.txtImeiPrezime = new System.Windows.Forms.TextBox();
            this.lblDrzava = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblPostanskiBroj = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblImeiPrezime = new System.Windows.Forms.Label();
            this.tbPregledAdrese = new System.Windows.Forms.TabPage();
            this.lstPregledAdrese = new System.Windows.Forms.ListBox();
            this.btnDodajuNarudzbu = new System.Windows.Forms.Button();
            this.btnIzmjena = new System.Windows.Forms.Button();
            this.tbPregledNarudzbe = new System.Windows.Forms.TabPage();
            this.lblPregledNarudzbe = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.lstGotovaNarudzba = new System.Windows.Forms.ListBox();
            this.tabShop.SuspendLayout();
            this.tabProizvodi.SuspendLayout();
            this.tabPregledKosarica.SuspendLayout();
            this.tabAdresa.SuspendLayout();
            this.tbPregledAdrese.SuspendLayout();
            this.tbPregledNarudzbe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabShop
            // 
            this.tabShop.Controls.Add(this.tabProizvodi);
            this.tabShop.Controls.Add(this.tabPregledKosarica);
            this.tabShop.Controls.Add(this.tabAdresa);
            this.tabShop.Controls.Add(this.tbPregledAdrese);
            this.tabShop.Controls.Add(this.tbPregledNarudzbe);
            this.tabShop.Location = new System.Drawing.Point(11, 10);
            this.tabShop.Margin = new System.Windows.Forms.Padding(2);
            this.tabShop.Name = "tabShop";
            this.tabShop.SelectedIndex = 0;
            this.tabShop.Size = new System.Drawing.Size(447, 375);
            this.tabShop.TabIndex = 0;
            this.tabShop.SelectedIndexChanged += new System.EventHandler(this.tabShop_selectedIndexChanged);
            // 
            // tabProizvodi
            // 
            this.tabProizvodi.Controls.Add(this.lblFilter);
            this.tabProizvodi.Controls.Add(this.lblProizvodi);
            this.tabProizvodi.Controls.Add(this.cmbFilter);
            this.tabProizvodi.Controls.Add(this.lstPrikazProizvoda);
            this.tabProizvodi.Controls.Add(this.btnOdustani);
            this.tabProizvodi.Controls.Add(this.lblNaruceno);
            this.tabProizvodi.Controls.Add(this.btnDodajuKosaricu);
            this.tabProizvodi.Location = new System.Drawing.Point(4, 22);
            this.tabProizvodi.Margin = new System.Windows.Forms.Padding(2);
            this.tabProizvodi.Name = "tabProizvodi";
            this.tabProizvodi.Padding = new System.Windows.Forms.Padding(2);
            this.tabProizvodi.Size = new System.Drawing.Size(439, 349);
            this.tabProizvodi.TabIndex = 0;
            this.tabProizvodi.Text = "Proizvodi";
            this.tabProizvodi.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(293, 29);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(117, 13);
            this.lblFilter.TabIndex = 11;
            this.lblFilter.Text = "Filtriraj po kategorijama:";
            // 
            // lblProizvodi
            // 
            this.lblProizvodi.AutoSize = true;
            this.lblProizvodi.Location = new System.Drawing.Point(4, 5);
            this.lblProizvodi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProizvodi.Name = "lblProizvodi";
            this.lblProizvodi.Size = new System.Drawing.Size(50, 13);
            this.lblProizvodi.TabIndex = 10;
            this.lblProizvodi.Text = "Proizvodi";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Tehnologija",
            "Kuhinjski pribor",
            "Higijena",
            "Odjeća",
            "---"});
            this.cmbFilter.Location = new System.Drawing.Point(296, 46);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(140, 21);
            this.cmbFilter.TabIndex = 9;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // lstPrikazProizvoda
            // 
            this.lstPrikazProizvoda.FormattingEnabled = true;
            this.lstPrikazProizvoda.Location = new System.Drawing.Point(58, 14);
            this.lstPrikazProizvoda.Margin = new System.Windows.Forms.Padding(2);
            this.lstPrikazProizvoda.Name = "lstPrikazProizvoda";
            this.lstPrikazProizvoda.Size = new System.Drawing.Size(218, 212);
            this.lstPrikazProizvoda.TabIndex = 7;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(283, 261);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 66);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblNaruceno
            // 
            this.lblNaruceno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNaruceno.Location = new System.Drawing.Point(296, 106);
            this.lblNaruceno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaruceno.Name = "lblNaruceno";
            this.lblNaruceno.Size = new System.Drawing.Size(126, 19);
            this.lblNaruceno.TabIndex = 4;
            this.lblNaruceno.Text = "Naruceni proizvodi: 0";
            // 
            // btnDodajuKosaricu
            // 
            this.btnDodajuKosaricu.Location = new System.Drawing.Point(39, 261);
            this.btnDodajuKosaricu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajuKosaricu.Name = "btnDodajuKosaricu";
            this.btnDodajuKosaricu.Size = new System.Drawing.Size(134, 66);
            this.btnDodajuKosaricu.TabIndex = 3;
            this.btnDodajuKosaricu.Text = "Dodaj u košaricu";
            this.btnDodajuKosaricu.UseVisualStyleBackColor = true;
            this.btnDodajuKosaricu.Click += new System.EventHandler(this.btnDodajuKosaricu_Click);
            // 
            // tabPregledKosarica
            // 
            this.tabPregledKosarica.Controls.Add(this.lblPregledKosarice);
            this.tabPregledKosarica.Controls.Add(this.btnPrijelazNaAdresu);
            this.tabPregledKosarica.Controls.Add(this.lblUkupno);
            this.tabPregledKosarica.Controls.Add(this.lstProizvodi);
            this.tabPregledKosarica.Location = new System.Drawing.Point(4, 22);
            this.tabPregledKosarica.Margin = new System.Windows.Forms.Padding(2);
            this.tabPregledKosarica.Name = "tabPregledKosarica";
            this.tabPregledKosarica.Padding = new System.Windows.Forms.Padding(2);
            this.tabPregledKosarica.Size = new System.Drawing.Size(439, 349);
            this.tabPregledKosarica.TabIndex = 1;
            this.tabPregledKosarica.Text = "Kosarica";
            this.tabPregledKosarica.UseVisualStyleBackColor = true;
            // 
            // lblPregledKosarice
            // 
            this.lblPregledKosarice.AutoSize = true;
            this.lblPregledKosarice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPregledKosarice.Location = new System.Drawing.Point(24, 20);
            this.lblPregledKosarice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPregledKosarice.Name = "lblPregledKosarice";
            this.lblPregledKosarice.Size = new System.Drawing.Size(168, 29);
            this.lblPregledKosarice.TabIndex = 3;
            this.lblPregledKosarice.Text = "Vaša košarica:";
            // 
            // btnPrijelazNaAdresu
            // 
            this.btnPrijelazNaAdresu.Location = new System.Drawing.Point(178, 285);
            this.btnPrijelazNaAdresu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrijelazNaAdresu.Name = "btnPrijelazNaAdresu";
            this.btnPrijelazNaAdresu.Size = new System.Drawing.Size(98, 58);
            this.btnPrijelazNaAdresu.TabIndex = 2;
            this.btnPrijelazNaAdresu.Text = "Dalje na adresu";
            this.btnPrijelazNaAdresu.UseVisualStyleBackColor = true;
            this.btnPrijelazNaAdresu.Click += new System.EventHandler(this.btnPrijelazNaAdresu_Click);
            // 
            // lblUkupno
            // 
            this.lblUkupno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUkupno.Location = new System.Drawing.Point(74, 223);
            this.lblUkupno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(289, 41);
            this.lblUkupno.TabIndex = 1;
            this.lblUkupno.Text = "Ukupna cijena";
            // 
            // lstProizvodi
            // 
            this.lstProizvodi.FormattingEnabled = true;
            this.lstProizvodi.Location = new System.Drawing.Point(196, 20);
            this.lstProizvodi.Margin = new System.Windows.Forms.Padding(2);
            this.lstProizvodi.Name = "lstProizvodi";
            this.lstProizvodi.Size = new System.Drawing.Size(199, 173);
            this.lstProizvodi.TabIndex = 0;
            // 
            // tabAdresa
            // 
            this.tabAdresa.Controls.Add(this.lblUnosAdrese);
            this.tabAdresa.Controls.Add(this.btnUnosAdrese);
            this.tabAdresa.Controls.Add(this.cmbPostanskiBroj);
            this.tabAdresa.Controls.Add(this.txtDrzava);
            this.tabAdresa.Controls.Add(this.txtGrad);
            this.tabAdresa.Controls.Add(this.txtAdresaa);
            this.tabAdresa.Controls.Add(this.txtImeiPrezime);
            this.tabAdresa.Controls.Add(this.lblDrzava);
            this.tabAdresa.Controls.Add(this.lblGrad);
            this.tabAdresa.Controls.Add(this.lblPostanskiBroj);
            this.tabAdresa.Controls.Add(this.lblAdresa);
            this.tabAdresa.Controls.Add(this.lblImeiPrezime);
            this.tabAdresa.Location = new System.Drawing.Point(4, 22);
            this.tabAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.tabAdresa.Name = "tabAdresa";
            this.tabAdresa.Padding = new System.Windows.Forms.Padding(2);
            this.tabAdresa.Size = new System.Drawing.Size(439, 349);
            this.tabAdresa.TabIndex = 2;
            this.tabAdresa.Text = "Adresa narudžbe";
            this.tabAdresa.UseVisualStyleBackColor = true;
            // 
            // lblUnosAdrese
            // 
            this.lblUnosAdrese.AutoSize = true;
            this.lblUnosAdrese.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUnosAdrese.Location = new System.Drawing.Point(113, 2);
            this.lblUnosAdrese.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnosAdrese.Name = "lblUnosAdrese";
            this.lblUnosAdrese.Size = new System.Drawing.Size(198, 37);
            this.lblUnosAdrese.TabIndex = 12;
            this.lblUnosAdrese.Text = "Unos adrese";
            // 
            // btnUnosAdrese
            // 
            this.btnUnosAdrese.Location = new System.Drawing.Point(164, 269);
            this.btnUnosAdrese.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnosAdrese.Name = "btnUnosAdrese";
            this.btnUnosAdrese.Size = new System.Drawing.Size(118, 52);
            this.btnUnosAdrese.TabIndex = 11;
            this.btnUnosAdrese.Text = "Unesi";
            this.btnUnosAdrese.UseVisualStyleBackColor = true;
            this.btnUnosAdrese.Click += new System.EventHandler(this.btnUnosAdrese_Click);
            // 
            // cmbPostanskiBroj
            // 
            this.cmbPostanskiBroj.FormattingEnabled = true;
            this.cmbPostanskiBroj.Items.AddRange(new object[] {
            "21000",
            "21204",
            "21218",
            "21310",
            "21209",
            "21311",
            "---"});
            this.cmbPostanskiBroj.Location = new System.Drawing.Point(113, 141);
            this.cmbPostanskiBroj.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPostanskiBroj.Name = "cmbPostanskiBroj";
            this.cmbPostanskiBroj.Size = new System.Drawing.Size(112, 21);
            this.cmbPostanskiBroj.TabIndex = 10;
            this.cmbPostanskiBroj.SelectedIndexChanged += new System.EventHandler(this.cmbPostanskiBroj_SelectedIndexChanged);
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(113, 214);
            this.txtDrzava.Margin = new System.Windows.Forms.Padding(2);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.ReadOnly = true;
            this.txtDrzava.Size = new System.Drawing.Size(94, 20);
            this.txtDrzava.TabIndex = 9;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(113, 178);
            this.txtGrad.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.ReadOnly = true;
            this.txtGrad.Size = new System.Drawing.Size(76, 20);
            this.txtGrad.TabIndex = 8;
            // 
            // txtAdresaa
            // 
            this.txtAdresaa.Location = new System.Drawing.Point(133, 98);
            this.txtAdresaa.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresaa.Name = "txtAdresaa";
            this.txtAdresaa.Size = new System.Drawing.Size(150, 20);
            this.txtAdresaa.TabIndex = 7;
            this.txtAdresaa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdresaa_KeyPress);
            // 
            // txtImeiPrezime
            // 
            this.txtImeiPrezime.Location = new System.Drawing.Point(113, 65);
            this.txtImeiPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtImeiPrezime.Name = "txtImeiPrezime";
            this.txtImeiPrezime.Size = new System.Drawing.Size(152, 20);
            this.txtImeiPrezime.TabIndex = 6;
            this.txtImeiPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImeiPrezime_KeyPress);
            // 
            // lblDrzava
            // 
            this.lblDrzava.AutoSize = true;
            this.lblDrzava.Location = new System.Drawing.Point(17, 218);
            this.lblDrzava.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(44, 13);
            this.lblDrzava.TabIndex = 5;
            this.lblDrzava.Text = "Država:";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(17, 180);
            this.lblGrad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(33, 13);
            this.lblGrad.TabIndex = 4;
            this.lblGrad.Text = "Grad:";
            // 
            // lblPostanskiBroj
            // 
            this.lblPostanskiBroj.AutoSize = true;
            this.lblPostanskiBroj.Location = new System.Drawing.Point(17, 146);
            this.lblPostanskiBroj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostanskiBroj.Name = "lblPostanskiBroj";
            this.lblPostanskiBroj.Size = new System.Drawing.Size(76, 13);
            this.lblPostanskiBroj.TabIndex = 3;
            this.lblPostanskiBroj.Text = "Poštanski broj:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(17, 102);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(97, 13);
            this.lblAdresa.TabIndex = 2;
            this.lblAdresa.Text = "Adresa i kućni broj:";
            // 
            // lblImeiPrezime
            // 
            this.lblImeiPrezime.AutoSize = true;
            this.lblImeiPrezime.Location = new System.Drawing.Point(17, 65);
            this.lblImeiPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImeiPrezime.Name = "lblImeiPrezime";
            this.lblImeiPrezime.Size = new System.Drawing.Size(71, 13);
            this.lblImeiPrezime.TabIndex = 1;
            this.lblImeiPrezime.Text = "Ime i prezime:";
            // 
            // tbPregledAdrese
            // 
            this.tbPregledAdrese.Controls.Add(this.lstPregledAdrese);
            this.tbPregledAdrese.Controls.Add(this.btnDodajuNarudzbu);
            this.tbPregledAdrese.Controls.Add(this.btnIzmjena);
            this.tbPregledAdrese.Location = new System.Drawing.Point(4, 22);
            this.tbPregledAdrese.Margin = new System.Windows.Forms.Padding(2);
            this.tbPregledAdrese.Name = "tbPregledAdrese";
            this.tbPregledAdrese.Padding = new System.Windows.Forms.Padding(2);
            this.tbPregledAdrese.Size = new System.Drawing.Size(439, 349);
            this.tbPregledAdrese.TabIndex = 3;
            this.tbPregledAdrese.Text = "Pregled adrese";
            this.tbPregledAdrese.UseVisualStyleBackColor = true;
            // 
            // lstPregledAdrese
            // 
            this.lstPregledAdrese.FormattingEnabled = true;
            this.lstPregledAdrese.Location = new System.Drawing.Point(81, 20);
            this.lstPregledAdrese.Margin = new System.Windows.Forms.Padding(2);
            this.lstPregledAdrese.Name = "lstPregledAdrese";
            this.lstPregledAdrese.Size = new System.Drawing.Size(264, 212);
            this.lstPregledAdrese.TabIndex = 4;
            // 
            // btnDodajuNarudzbu
            // 
            this.btnDodajuNarudzbu.Location = new System.Drawing.Point(266, 256);
            this.btnDodajuNarudzbu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajuNarudzbu.Name = "btnDodajuNarudzbu";
            this.btnDodajuNarudzbu.Size = new System.Drawing.Size(114, 60);
            this.btnDodajuNarudzbu.TabIndex = 3;
            this.btnDodajuNarudzbu.Text = "Dodaj";
            this.btnDodajuNarudzbu.UseVisualStyleBackColor = true;
            this.btnDodajuNarudzbu.Click += new System.EventHandler(this.btnDodajuNarudzbu_Click);
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.Location = new System.Drawing.Point(40, 256);
            this.btnIzmjena.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(118, 60);
            this.btnIzmjena.TabIndex = 2;
            this.btnIzmjena.Text = "Izmjeni";
            this.btnIzmjena.UseVisualStyleBackColor = true;
            this.btnIzmjena.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // tbPregledNarudzbe
            // 
            this.tbPregledNarudzbe.Controls.Add(this.lblPregledNarudzbe);
            this.tbPregledNarudzbe.Controls.Add(this.btnPotvrdi);
            this.tbPregledNarudzbe.Controls.Add(this.lstGotovaNarudzba);
            this.tbPregledNarudzbe.Location = new System.Drawing.Point(4, 22);
            this.tbPregledNarudzbe.Margin = new System.Windows.Forms.Padding(2);
            this.tbPregledNarudzbe.Name = "tbPregledNarudzbe";
            this.tbPregledNarudzbe.Padding = new System.Windows.Forms.Padding(2);
            this.tbPregledNarudzbe.Size = new System.Drawing.Size(439, 349);
            this.tbPregledNarudzbe.TabIndex = 4;
            this.tbPregledNarudzbe.Text = "Pregled narudžbe";
            this.tbPregledNarudzbe.UseVisualStyleBackColor = true;
            // 
            // lblPregledNarudzbe
            // 
            this.lblPregledNarudzbe.AutoSize = true;
            this.lblPregledNarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPregledNarudzbe.Location = new System.Drawing.Point(167, 12);
            this.lblPregledNarudzbe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPregledNarudzbe.Name = "lblPregledNarudzbe";
            this.lblPregledNarudzbe.Size = new System.Drawing.Size(106, 26);
            this.lblPregledNarudzbe.TabIndex = 3;
            this.lblPregledNarudzbe.Text = "Narudzba";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(156, 279);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(124, 50);
            this.btnPotvrdi.TabIndex = 2;
            this.btnPotvrdi.Text = "Potvrdi narudžbu";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // lstGotovaNarudzba
            // 
            this.lstGotovaNarudzba.FormattingEnabled = true;
            this.lstGotovaNarudzba.Location = new System.Drawing.Point(16, 54);
            this.lstGotovaNarudzba.Margin = new System.Windows.Forms.Padding(2);
            this.lstGotovaNarudzba.Name = "lstGotovaNarudzba";
            this.lstGotovaNarudzba.Size = new System.Drawing.Size(415, 212);
            this.lstGotovaNarudzba.TabIndex = 0;
            // 
            // frmKosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 395);
            this.Controls.Add(this.tabShop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKosarica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kosarica";
            this.Load += new System.EventHandler(this.frmKosarica_Load);
            this.tabShop.ResumeLayout(false);
            this.tabProizvodi.ResumeLayout(false);
            this.tabProizvodi.PerformLayout();
            this.tabPregledKosarica.ResumeLayout(false);
            this.tabPregledKosarica.PerformLayout();
            this.tabAdresa.ResumeLayout(false);
            this.tabAdresa.PerformLayout();
            this.tbPregledAdrese.ResumeLayout(false);
            this.tbPregledNarudzbe.ResumeLayout(false);
            this.tbPregledNarudzbe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabShop;
        private System.Windows.Forms.TabPage tabProizvodi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaruceno;
        private System.Windows.Forms.Button btnDodajuKosaricu;
        private System.Windows.Forms.TabPage tabPregledKosarica;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.ListBox lstProizvodi;
        private System.Windows.Forms.TabPage tabAdresa;
        private System.Windows.Forms.ListBox lstPrikazProizvoda;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnPrijelazNaAdresu;
        private System.Windows.Forms.ComboBox cmbPostanskiBroj;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtAdresaa;
        private System.Windows.Forms.TextBox txtImeiPrezime;
        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label lblPostanskiBroj;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblImeiPrezime;
        private System.Windows.Forms.Button btnUnosAdrese;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblProizvodi;
        private System.Windows.Forms.Label lblPregledKosarice;
        private System.Windows.Forms.TabPage tbPregledAdrese;
        private System.Windows.Forms.Button btnIzmjena;
        private System.Windows.Forms.Button btnDodajuNarudzbu;
        private System.Windows.Forms.ListBox lstPregledAdrese;
        private System.Windows.Forms.TabPage tbPregledNarudzbe;
        private System.Windows.Forms.Label lblPregledNarudzbe;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.ListBox lstGotovaNarudzba;
        private System.Windows.Forms.Label lblUnosAdrese;
    }
}

