namespace Sinema_Bufe_Satis_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasaTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);

            toplam = misir * 50 + bilet * 80 + su * 10 + cay * 20;
            LblToplam.Text = toplam.ToString() + " TL";

            kasaTutar = kasaTutar + toplam;
            LblKasa.Text = kasaTutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";

            TxtMisir.Focus();

        }
    }
}
