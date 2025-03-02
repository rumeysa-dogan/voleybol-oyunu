using voleybol.odevi;

namespace voleybol.odevi
{
    public partial class Form1 : Form
    {
        private Smacor smacor1, smacor2;
        private Libero libero;
        private Pasor pasor1, pasor2;
        private OrtaOyuncu ortaOyuncu;
        private Smacor rakipSmacor3, rakipSmacor4;
        private Libero rakipLibero;
        private Pasor rakipPasor3, rakipPasor4;
        private OrtaOyuncu rakipOrtaOyuncu;


        private int skor; 

        public Form1()
        {
            InitializeComponent();
            
            smacor1 = new Smacor("Smacor1", 90, 80, 85);
            smacor2 = new Smacor("Smacor2", 85, 75, 80);
            libero = new Libero("Libero", 70, 95, 90);
            pasor1 = new Pasor("Pasor1", 85, 80, 92);
            pasor2 = new Pasor("Pasor2", 80, 78, 88);
            ortaOyuncu = new OrtaOyuncu("Orta1", 88, 75, 87);

          
            rakipSmacor3 = new Smacor("Rakip Smacor3", 80, 78, 82);
            rakipSmacor4 = new Smacor("Rakip Smacor4", 75, 70, 78);
            rakipLibero = new Libero("Rakip Libero", 65, 90, 85);
            rakipPasor3 = new Pasor("Rakip Pasor3", 82, 75, 88);
            rakipPasor4 = new Pasor("Rakip Pasor4", 78, 72, 84);
            rakipOrtaOyuncu = new OrtaOyuncu("Rakip OrtaOyuncu", 85, 70, 83);

            comboBox1.Items.AddRange(Enum.GetValues(typeof(Yetenek)).Cast<object>().ToArray());

            skor = 0;
            UpdateSkorLabel();


        }

        private void UpdateSkorLabel()
        {

            skorLabel.Text = "Skor: " + skor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj = pasor1.Oyna(secim);

                MessageBox.Show(mesaj, "Pasor1 Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj = ortaOyuncu.Oyna(secim);

                MessageBox.Show(mesaj, "OrtaOyuncu1 Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj = smacor1.Oyna(secim);

                MessageBox.Show(mesaj, "Smacor1 Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj = smacor2.Oyna(secim);

                MessageBox.Show(mesaj, "Smacor2 Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj = libero.Oyna(secim);

                MessageBox.Show(mesaj, "libero1 Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj = pasor2.Oyna(secim);

                MessageBox.Show(mesaj, "Pasor2 Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {
                MessageBox.Show("Seçilen yetenek: " + secim + "Bilgi");
            }
            else
            {
                MessageBox.Show("Geçerli bir yetenek seçiniz.", "Uyarý");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj = rakipPasor3.Oyna(secim);

                MessageBox.Show(mesaj, "RakipPasor3 Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj = rakipOrtaOyuncu.Oyna(secim);

                MessageBox.Show(mesaj, "RakipOrtaOyuncu Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj = rakipSmacor3.Oyna(secim);

                MessageBox.Show(mesaj, "RakipSmaçor3 Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj = rakipSmacor4.Oyna(secim);

                MessageBox.Show(mesaj, "RakipSmacor4 Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj =rakipLibero.Oyna(secim);

                MessageBox.Show(mesaj, "RakipLibero Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Yetenek secim)
            {

                var mesaj = rakipPasor4.Oyna(secim);

                MessageBox.Show(mesaj, "RakipPasor4 Aksiyonu");

                if (!mesaj.Contains("kullanamaz"))
                {
                    skor++;
                    UpdateSkorLabel();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yetenek seçiniz.", "Uyarý");
            }
        }
    }
}
