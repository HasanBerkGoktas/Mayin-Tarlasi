namespace mayın_tarlası

{
    public partial class Form1 : Form
    {
        Class_game oyun = new Class_game();
        int skor = 0;
        public void oyun_baslangic_ayarlari()
        {
            label_skor.Text = "0";
            flowLayoutPanel1.Controls.Clear();
            groupBox_zorluk.Enabled = false;
            basla_buton.Enabled = false;
            flowLayoutPanel1.Enabled = true;
        }

        public void oyun_bitis_ayarlari()
        {
            flowLayoutPanel1.Enabled = false;
            groupBox_zorluk.Enabled = true;
            basla_buton.Enabled = true;
        }



        public void buton_olustur(int boyut)
        {
            for(int i = 0; i < boyut; i++)
            {
                Button yenitn = new Button();
                yenitn.Size = new Size(60, 60);
                yenitn.Margin=new Padding(0);
                yenitn.Tag = i;
                yenitn.Click += new EventHandler(dugme_basildi);
                yenitn.BackColor = Color.Gray;
                flowLayoutPanel1.Controls.Add(yenitn);

            }
        }

        public void dugme_basildi(object sender,EventArgs e)
        {
            Button btn_basılan = (Button)sender;
            if (oyun.kontrol((int)btn_basılan.Tag))
            {
                btn_basılan.BackColor = Color.Red;
                btn_basılan.Enabled = false;
                skor--;
                skor--;
                label_skor.Text = skor.ToString();
                if (skor < 0)
                {
                    MessageBox.Show("Kaybettin");
                    oyun_bitis_ayarlari();
                    skor = 0;
                }
            }
            else
            {
                btn_basılan.BackColor = Color.Green;
                btn_basılan.Enabled = false;
                skor++;
                label_skor.Text = skor.ToString();

            }
        }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyun._boyut = 36;
            oyun.bomba_yerlestir(17);
            oyun_baslangic_ayarlari();
            buton_olustur(oyun._boyut);
        }

    }
}