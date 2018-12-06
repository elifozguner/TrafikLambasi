using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frm_TrafikLambasi : Form
    {
        public Frm_TrafikLambasi()
        {
            InitializeComponent();
        }
        int Sayac_Kirmizi = 0;
        int Sayac_Sari = 0;
        int Sayac_Yesil = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Sayac_Kirmizi = Class1.KirmiziIsikSuresi;
            Sayac_Sari = Class1.SariIsikSuresi;
            Sayac_Yesil = Class1.YesilIsikSuresi;
            Tmr_Kirmizi.Start();
        }
        private void Tmr_Kirmizi_Tick(object sender, EventArgs e)
        {
            Pb_Kirmizi.Visible = true;
            Sayac_Kirmizi--;
            if (Sayac_Kirmizi == 0)
            {
                Pb_Kirmizi.Visible=false;
                Tmr_Kirmizi.Stop();
                Sayac_Kirmizi = Class1.KirmiziIsikSuresi;
                Tmr_Sari.Start();
            }
        }
        private void Tmr_Sari_Tick(object sender, EventArgs e)
        {
            Pb_Sari.Visible = true;
            Sayac_Sari--;
            if (Sayac_Sari == 0)
            {
                Pb_Sari.Visible = false;
                Tmr_Sari.Stop();
                Sayac_Sari = Class1.SariIsikSuresi;
                Tmr_Yesil.Start();
            }
        }
        private void Tmr_Yesil_Tick(object sender, EventArgs e)
        {
            Pb_Yesil.Visible = true;
            Sayac_Yesil--;
            if (Sayac_Yesil == 0)
            {
                Pb_Yesil.Visible = false;
                Tmr_Yesil.Stop();
                Sayac_Yesil = Class1.YesilIsikSuresi;
                Tmr_Kirmizi.Start();
            }
        }

        private void Btn_Ayarlar_Click(object sender, EventArgs e)
        {
            Frm_Ayarlar _ayarlar = new Frm_Ayarlar();
            Tmr_Kirmizi.Stop();
            Tmr_Sari.Stop();
            Tmr_Yesil.Stop();
            _ayarlar.ShowDialog();
            Sayac_Kirmizi = Class1.KirmiziIsikSuresi;
            Sayac_Sari = Class1.SariIsikSuresi;
            Sayac_Yesil = Class1.YesilIsikSuresi;
            Tmr_Kirmizi.Start();
            Pb_Sari.Visible = false;
            Pb_Yesil.Visible = false;
        }
    }
}