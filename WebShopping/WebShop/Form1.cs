using System;
using System.Windows.Forms;

namespace WebShop
{
    public partial class frmKosarica : Form
    {
        public frmKosarica()
        {
            InitializeComponent();
        }

        int naruceniProizvodi;
        const int BrojProizvoda = 10;
        Proizvod[] proizvodi = new Proizvod[BrojProizvoda];
        Proizvod p;

        private void frmKosarica_Load(object sender, EventArgs e)
        {            
            proizvodi[0] = new Proizvod("Računalo", 999, "Tehnologija");
            proizvodi[1] = new Proizvod("Printer", 299, "Tehnologija");
            proizvodi[2] = new Proizvod("Miš", 250, "Tehnologija");
            proizvodi[3] = new Proizvod("Tipkovnica", 349, "Tehnologija");
            proizvodi[4] = new Proizvod("Kombinezon", 289, "Odjeća");
            proizvodi[5] = new Proizvod("Majica", 489, "Odjeća");
            proizvodi[6] = new Proizvod("Hlače", 119, "Odjeća");
            proizvodi[7] = new Proizvod("Set noževa", 279, "Kuhinjski pribor");
            proizvodi[8] = new Proizvod("Daska za rezanje", 799, "Kuhinjski pribor");
            proizvodi[9] = new Proizvod("Šampon za kosu", 79, "Higijena");

            p = new Proizvod("Računalo", 999, "Tehnologija");
            p = new Proizvod("Printer", 299, "Tehnologija");
            p = new Proizvod("Miš", 250, "Tehnologija");
            p = new Proizvod("Tipkovnica", 349, "Tehnologija");
            p = new Proizvod("Kombinezon", 289, "Odjeća");
            p = new Proizvod("Majica", 489, "Odjeća");
            p = new Proizvod("Hlače", 119, "Odjeća");
            p = new Proizvod("Set noževa", 279, "Kuhinjski pribor");
            p = new Proizvod("Daska za rezanje", 799, "Kuhinjski pribor");
            p = new Proizvod("Šampon za kosu", 79, "Higijena");

            
            for (int i = 0; i < BrojProizvoda; i++)
            {

                lstPrikazProizvoda.Items.Add(proizvodi[i].Opis + " " + proizvodi[i].Cijena + "kn  " + proizvodi[i].Kategorija);

            }
         
            cmbPostanskiBroj.SelectedIndex = 6;
            cmbPostanskiBroj.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnDodajuKosaricu_Click(object sender, EventArgs e)
        {

            foreach (Proizvod p in proizvodi)
            {
                if (lstPrikazProizvoda.SelectedItem.ToString() == p.Opis + " " + p.Cijena + "kn  " + p.Kategorija)
                {
                    p.Kolicina++;
                }
            }

            naruceniProizvodi++;
            lblNaruceno.Text = "Naruceni proizvodi: " + naruceniProizvodi.ToString();
        }

        double Ukupno;



        private void tabShop_selectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabShop.SelectedIndex)
            {
                case 1:
                    if (naruceniProizvodi == 0)
                    {
                        MessageBox.Show("Niste ništa narucili", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabShop.SelectedIndex = 0;
                    }
                    else
                    {
                        Ukupno = 0;
                        lstProizvodi.Items.Clear();
                        for (int i = 0; i < BrojProizvoda; i++)
                        {
                            if (proizvodi[i].Kolicina != 0)
                            {
                                lstProizvodi.Items.Add(proizvodi[i].Kolicina.ToString() + " " + proizvodi[i].Opis + " " + proizvodi[i].Cijena + "kn");
                                Ukupno += p.UkupnaCijena(proizvodi[i].Kolicina, proizvodi[i].Cijena);

                            }
                        }

                        lblUkupno.Text = "Ukupna cijena: " + String.Format("{0:f2}", Ukupno) + "kn";
                    }
                    break;
                case 3:
                    if (imeiPrezime == "" || adresaiKucniBroj == "" || postanskiBroj == "")
                    {
                        MessageBox.Show("Nije unesena adresa", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabShop.SelectedIndex = 2;
                    }
                    break;
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPrikazProizvoda.Items.Clear();
            foreach (Proizvod p in this.proizvodi)
            {
                if (p.Kategorija == cmbFilter.SelectedItem.ToString())
                {
                    lstPrikazProizvoda.Items.Add(p.Opis + " " + p.Cijena + "kn  " + p.Kategorija);
                }
                if (cmbFilter.SelectedItem.ToString() == "---")
                {
                    lstPrikazProizvoda.Items.Add(p.Opis + " " + p.Cijena + "kn  " + p.Kategorija);
                }
            }
        }



        private void cmbPostanskiBroj_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbPostanskiBroj.SelectedIndex == 0)
            {
                txtGrad.Text = "Split";
                txtDrzava.Text = "Hrvatska";
            }
            else if (cmbPostanskiBroj.SelectedIndex == 1)
            {
                txtGrad.Text = "Dugopolje";
                txtDrzava.Text = "Hrvatska";
            }
            else if (cmbPostanskiBroj.SelectedIndex == 2)
            {
                txtGrad.Text = "Trogir";
                txtDrzava.Text = "Hrvatska";
            }
            else if (cmbPostanskiBroj.SelectedIndex == 3)
            {
                txtGrad.Text = "Omiš";
                txtDrzava.Text = "Hrvatska";
            }
            else if (cmbPostanskiBroj.SelectedIndex == 4)
            {
                txtGrad.Text = "Solin";
                txtDrzava.Text = "Hrvatska";
            }
            else if (cmbPostanskiBroj.SelectedIndex == 5)
            {
                txtGrad.Text = "Stobreč";
                txtDrzava.Text = "Hrvatska";
            }
        }

        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            lstPregledAdrese.Items.Clear();
            tabShop.SelectedIndex = 2;
        }

        string imeiPrezime;
        string adresaiKucniBroj;
        string postanskiBroj;
        string grad;
        string drzava;

        private void btnUnosAdrese_Click(object sender, EventArgs e)
        {
            imeiPrezime = txtImeiPrezime.Text;
            adresaiKucniBroj = txtAdresaa.Text;

            if (cmbPostanskiBroj.SelectedItem.ToString() != "---")
            {
                postanskiBroj = cmbPostanskiBroj.SelectedItem.ToString();
            }
            else
            {
                postanskiBroj = "";
            }

            grad = txtGrad.Text;
            drzava = txtDrzava.Text;


            if (imeiPrezime != "" && adresaiKucniBroj != "" && postanskiBroj != "")
            {
                lstPregledAdrese.Items.Add(imeiPrezime + " | " + adresaiKucniBroj + " | " + postanskiBroj + " | " + grad + " | " + drzava);
            }

        }

        private void btnDodajuNarudzbu_Click(object sender, EventArgs e)
        {
            tabShop.SelectedIndex = 4;
            lstGotovaNarudzba.Items.Add("Ime i prezime: " + imeiPrezime + "\nAdresa: " + adresaiKucniBroj + "\nGrad: " + grad + "\nUkupna cijena: " + Ukupno + "kn");

        }

        private void btnPrijelazNaAdresu_Click(object sender, EventArgs e)
        {
            tabShop.SelectedIndex = 2;

        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            naruceniProizvodi = 0;
            lblNaruceno.Text = "Naruceni proizvodi: 0";
            lstGotovaNarudzba.Items.Clear();

            for (int i = 0; i < BrojProizvoda; i++)
            {
                proizvodi[i].Kolicina = 0;

            }
            lstPrikazProizvoda.SelectedIndex = 0;
            lstProizvodi.Items.Clear();
            lblUkupno.Text = "Ukupna cijena";
            lstPregledAdrese.Items.Clear();
            txtAdresaa.Text = "";
            txtDrzava.Text = "";
            txtGrad.Text = "";
            txtImeiPrezime.Text = "";
            cmbPostanskiBroj.SelectedIndex = -1;
            tabShop.SelectedIndex = 0;
            imeiPrezime = "";
            postanskiBroj = "";
            adresaiKucniBroj = "";
        }

        private void txtImeiPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtAdresaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
