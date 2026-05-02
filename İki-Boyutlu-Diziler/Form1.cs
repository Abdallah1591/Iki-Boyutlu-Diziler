namespace İki_Boyutlu_Diziler
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numAsatir.Minimum = numAsutun.Minimum = 1;
            numAsatir.Maximum = numAsutun.Maximum = 6;

            numBsatir.Minimum = numBsutun.Minimum = 1;
            numBsatir.Maximum = numBsutun.Maximum = 6;


            grpBoxİşlem.Visible = false;
            btnHesapla.Visible = false;
            lbleşit.Visible = false;
            dgvA.Visible = false;
            dgvB.Visible = false;
            dgvSonuc.Visible = false;
            lblişlem.Visible = false;
            rdBtnToplama.Checked = true;


        }

        private void btnVeriDoldur_Click(object sender, EventArgs e)
        {
            //Matris A
            dgvA.Rows.Clear();
            dgvA.Columns.Clear();
            dgvA.Visible = true;
            for (int i = 0; i < (int)numAsutun.Value; i++) dgvA.Columns.Add("", "");
            for (int i = 0; i < (int)numAsatir.Value; i++)
            {
                dgvA.Rows.Add();
                for (int j = 0; j < (int)numAsutun.Value; j++)
                    dgvA.Rows[i].Cells[j].Value = rnd.Next(1, 51);
            }

            //Matris B
            dgvB.Rows.Clear();
            dgvB.Columns.Clear();
            dgvB.Visible = true;
            for (int i = 0; i < (int)numBsutun.Value; i++) dgvB.Columns.Add("", "");
            for (int i = 0; i < (int)numBsatir.Value; i++)
            {
                dgvB.Rows.Add();
                for (int j = 0; j < (int)numBsutun.Value; j++)
                    dgvB.Rows[i].Cells[j].Value = rnd.Next(1, 51);
            }


            grpBoxİşlem.Visible = true;
            btnHesapla.Visible = true;
            lblişlem.Visible = true;


        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            void SonucMatris(int satir, int sutun)
            {
                dgvSonuc.Rows.Clear();
                dgvSonuc.Columns.Clear();
                dgvSonuc.Visible = true;
                lbleşit.Visible = true;

                for (int i = 0; i < sutun; i++)
                    dgvSonuc.Columns.Add("", "");

                for (int i = 0; i < satir; i++)
                    dgvSonuc.Rows.Add();
            }


            void ToplamaMetodu()
            {
                if (numAsatir.Value == numBsatir.Value && numAsutun.Value == numBsutun.Value)
                {
                    lblişlem.Text = "+";
                    SonucMatris((int)numAsatir.Value, (int)numAsutun.Value);

                    for (int i = 0; i < (int)numAsatir.Value; i++)
                        for (int j = 0; j < (int)numAsutun.Value; j++)
                            dgvSonuc.Rows[i].Cells[j].Value = Convert.ToInt32(dgvA.Rows[i].Cells[j].Value) + Convert.ToInt32(dgvB.Rows[i].Cells[j].Value);
                }
                else MessageBox.Show("Toplama için Matris boyutlar aynı olmalı!");
            }

            void CikarmaMetodu()
            {
                if (numAsatir.Value == numBsatir.Value && numAsutun.Value == numBsutun.Value)
                {
                    lblişlem.Text = "-";
                    SonucMatris((int)numAsatir.Value, (int)numAsutun.Value);
                    for (int i = 0; i < (int)numAsatir.Value; i++)
                        for (int j = 0; j < (int)numAsutun.Value; j++)
                            dgvSonuc.Rows[i].Cells[j].Value = Convert.ToInt32(dgvA.Rows[i].Cells[j].Value) - Convert.ToInt32(dgvB.Rows[i].Cells[j].Value);
                }
                else MessageBox.Show("Çıkarma için Matris boyutlar aynı olmalı!");
            }

            void CarpmaMetodu()
            {
                if (numAsutun.Value == numBsatir.Value)
                {
                    lblişlem.Text = "x";
                    SonucMatris((int)numAsatir.Value, (int)numBsutun.Value);
                    for (int i = 0; i < (int)numAsatir.Value; i++)
                    {
                        for (int j = 0; j < (int)numBsutun.Value; j++)
                        {
                            int toplam = 0;
                            for (int k = 0; k < (int)numAsutun.Value; k++)
                                toplam += Convert.ToInt32(dgvA.Rows[i].Cells[k].Value) * Convert.ToInt32(dgvB.Rows[k].Cells[j].Value);
                            dgvSonuc.Rows[i].Cells[j].Value = toplam;
                        }
                    }
                }
                else MessageBox.Show("A Sutun sayısı B Satır sayısına eşit olmalı!");
            }

            void OrtalamaMetodu()
            {
                lblişlem.Text = "AVR";
                SonucMatris((int)numAsatir.Value, 1); // Results in 1 column
                for (int i = 0; i < (int)numAsatir.Value; i++)
                {
                    double satirToplami = 0;
                    for (int j = 0; j < (int)numAsutun.Value; j++)
                        satirToplami += Convert.ToDouble(dgvA.Rows[i].Cells[j].Value);
                    dgvSonuc.Rows[i].Cells[0].Value = (satirToplami / (int)numAsutun.Value).ToString("0.00");
                }
            }

            void MaksimumMetodu()
            {
                lblişlem.Text = "MAX";
                SonucMatris(1, (int)numAsutun.Value); // Results in 1 row
                for (int j = 0; j < (int)numAsutun.Value; j++)
                {
                    int enBuyuk = 0;
                    for (int i = 0; i < (int)numAsatir.Value; i++)
                    {
                        int sayi = Convert.ToInt32(dgvA.Rows[i].Cells[j].Value);
                        if (sayi > enBuyuk) enBuyuk = sayi;
                    }
                    dgvSonuc.Rows[0].Cells[j].Value = enBuyuk;
                }
            }


            if (rdBtnToplama.Checked) ToplamaMetodu();
            else if (rdBtnCikarma.Checked) CikarmaMetodu();
            else if (rdBtnCarpma.Checked) CarpmaMetodu();
            else if (rdBtnAVR.Checked) OrtalamaMetodu();
            else if (rdBtnMAX.Checked) MaksimumMetodu();
        }
    }
}
