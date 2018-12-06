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
    public partial class Frm_Ayarlar : Form
    {
        public Frm_Ayarlar()
        {
            InitializeComponent();
        }
        private void Frm_Ayarlar_Load(object sender, EventArgs e)
        {
            Nud_Kirmizi.Value = Class1.KirmiziIsikSuresi;
            Nud_Sari.Value = Class1.SariIsikSuresi;
            Nud_Yesil.Value = Class1.YesilIsikSuresi;
        }
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            Class1.KirmiziIsikSuresi = Convert.ToInt32(Nud_Kirmizi.Value);
            Class1.SariIsikSuresi = Convert.ToInt32(Nud_Sari.Value);
            Class1.YesilIsikSuresi = Convert.ToInt32(Nud_Yesil.Value);
            MessageBox.Show("Bilgileriniz Kaydedildi.");
            Close();
        }  
    }
}