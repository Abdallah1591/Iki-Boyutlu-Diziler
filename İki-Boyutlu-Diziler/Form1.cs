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

            dgvA.RowHeadersVisible = false;
            dgvA.ColumnHeadersVisible = false;
            dgvB.RowHeadersVisible = false; 
            dgvB.ColumnHeadersVisible = false;
            dgvSonuc.RowHeadersVisible = false; 
            dgvSonuc.ColumnHeadersVisible = false;

            dgvA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSonuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;   

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
                        {
                            int a = Convert.ToInt32(dgvA.Rows[i].Cells[j].Value);
                            int b = Convert.ToInt32(dgvB.Rows[i].Cells[j].Value);
                            dgvSonuc.Rows[i].Cells[j].Value = a + b;
                        }
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
                        {
                            int a = Convert.ToInt32(dgvA.Rows[i].Cells[j].Value);
                            int b = Convert.ToInt32(dgvB.Rows[i].Cells[j].Value);
                            dgvSonuc.Rows[i].Cells[j].Value = a - b;
                        }
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
                            {
                                int a = Convert.ToInt32(dgvA.Rows[i].Cells[k].Value);
                                int b = Convert.ToInt32(dgvB.Rows[k].Cells[j].Value);
                                toplam += a * b;
                            }
                            dgvSonuc.Rows[i].Cells[j].Value = toplam;
                        }
                    }
                }
                else MessageBox.Show("A Sutun sayısı B Satır sayısına eşit olmalı!");
            }

            void OrtalamaMetodu()
            {
                lblişlem.Text = "AVR";
                int maxSatir = (int)Math.Max(numAsatir.Value, numBsatir.Value);
                SonucMatris(maxSatir, 1);
                for (int i = 0; i < maxSatir; i++)
                {
                    double satirToplami = 0;
                    int hucreSayisi = 0;

                    if (i < (int)numAsatir.Value)
                    {
                        for (int j = 0; j < (int)numAsutun.Value; j++)
                        {
                            satirToplami += Convert.ToDouble(dgvA.Rows[i].Cells[j].Value);
                            hucreSayisi++; 
                        }
                    }

                    if (i < (int)numBsatir.Value)
                    {
                        for (int j = 0; j < (int)numBsutun.Value; j++)
                        {
                            satirToplami += Convert.ToDouble(dgvB.Rows[i].Cells[j].Value);
                            hucreSayisi++; 
                        }
                    }

                    if (hucreSayisi > 0)
                    {
                        double ortalama = satirToplami / hucreSayisi;
                        dgvSonuc.Rows[i].Cells[0].Value = ortalama.ToString("0.00");
                    }
                }
            }

            void MaksimumMetodu()
            {
                lblişlem.Text = "MAX";
                int maxSutun = (int)Math.Max(numAsutun.Value, numBsutun.Value);
                SonucMatris(1, maxSutun); 

                for (int j = 0; j < maxSutun; j++)
                {
                    int enBuyuk = 0; 

                    
                    if (j < (int)numAsutun.Value)
                    {
                        for (int i = 0; i < (int)numAsatir.Value; i++)
                        {
                            int deger = Convert.ToInt32(dgvA.Rows[i].Cells[j].Value);
                            if (deger > enBuyuk) enBuyuk = deger;
                        }
                    }

                    
                    if (j < (int)numBsutun.Value)
                    {
                        for (int i = 0; i < (int)numBsatir.Value; i++)
                        {
                            int deger = Convert.ToInt32(dgvB.Rows[i].Cells[j].Value);
                            if (deger > enBuyuk) enBuyuk = deger;
                        }
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
