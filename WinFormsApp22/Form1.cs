namespace WinFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAd.Focus();
            txtGun.Text = "1";
            rdTekKisi.Checked = true;
            txtOdaFiyati.Text = "1500";
            txtHizmetUcreti.Text = "0";

        }

        private void rdTekKisi_CheckedChanged(object sender, EventArgs e)
        {
            int tek = 0;
            int cift = 0;
            int suit = 0;

            if (rdTekKisi.Checked)
            {
                tek += 1500;
                txtOdaFiyati.Text = tek.ToString();
            }
            else if (rdCiftKisi.Checked)
            {
                cift += 2500;
                txtOdaFiyati.Text = cift.ToString();
            }
            else if (rdSuit.Checked)
            {
                suit += 3500;
                txtOdaFiyati.Text = suit.ToString();
            }

        }

        private void chkYatak_CheckedChanged(object sender, EventArgs e)
        {
            HizmetleriHesapla();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("Lütfen adınızı giriniz.");
                txtAd.Focus();
                return;
            }
            string odaTipi = "";
            if (rdTekKisi.Checked)
            {
                odaTipi = "Tek Kişilik";
            }
            else if (rdCiftKisi.Checked)
            {
                odaTipi = "Çift Kişilik";
            }
            else if (rdSuit.Checked)
            {
                odaTipi = "Suit";
            }

            string ad = txtAd.Text;
            int gun = int.Parse(txtGun.Text);
            int odafiyati = int.Parse(txtOdaFiyati.Text);
            int hizmet = int.Parse(txtHizmetUcreti.Text);

            DateTime giris = DateTime.Now;
            DateTime cikis = giris.AddDays(gun);

            int toplam = (odafiyati * gun) + hizmet;

            listBox1.Items.Add(
                $"Ad: {ad} | Oda: {odaTipi}\n" +
    $"Giriş: {giris}\n" +
    $"Çıkış: {cikis}\n" +
    $"{gun} gün oda: {odafiyati * gun} TL\n" +
    $"Ek hizmet: {hizmet} TL\n" +
    $"TOPLAM: {toplam} TL"
            );
        }

        private void rdCiftKisi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkHavalamani_CheckedChanged(object sender, EventArgs e)
        {
            HizmetleriHesapla();
        }

        private void chkRehber_CheckedChanged(object sender, EventArgs e)
        {
           HizmetleriHesapla();
        }
        private void HizmetleriHesapla()
        {
            int toplam = 0;

            if (chkYatak.Checked)
                toplam += 400;

            if (chkHavalamani.Checked)
                toplam += 600;

            if (chkRehber.Checked)
                toplam += 750;

            txtHizmetUcreti.Text = toplam.ToString();
        }
    }
}
