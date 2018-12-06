namespace WindowsFormsApplication1
{
    partial class Frm_TrafikLambasi
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
            this.components = new System.ComponentModel.Container();
            this.Tmr_Kirmizi = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Sari = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Yesil = new System.Windows.Forms.Timer(this.components);
            this.Pb_Kirmizi = new System.Windows.Forms.PictureBox();
            this.Pb_Yesil = new System.Windows.Forms.PictureBox();
            this.Pb_Sari = new System.Windows.Forms.PictureBox();
            this.Btn_Ayarlar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Kirmizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Yesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Sari)).BeginInit();
            this.SuspendLayout();
            // 
            // Tmr_Kirmizi
            // 
            this.Tmr_Kirmizi.Interval = 1000;
            this.Tmr_Kirmizi.Tick += new System.EventHandler(this.Tmr_Kirmizi_Tick);
            // 
            // Tmr_Sari
            // 
            this.Tmr_Sari.Interval = 1000;
            this.Tmr_Sari.Tick += new System.EventHandler(this.Tmr_Sari_Tick);
            // 
            // Tmr_Yesil
            // 
            this.Tmr_Yesil.Interval = 1000;
            this.Tmr_Yesil.Tick += new System.EventHandler(this.Tmr_Yesil_Tick);
            // 
            // Pb_Kirmizi
            // 
            this.Pb_Kirmizi.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Kirmizi.Image = global::WindowsFormsApplication1.Properties.Resources.kirmizi_lamba;
            this.Pb_Kirmizi.Location = new System.Drawing.Point(178, 37);
            this.Pb_Kirmizi.Name = "Pb_Kirmizi";
            this.Pb_Kirmizi.Size = new System.Drawing.Size(64, 71);
            this.Pb_Kirmizi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Kirmizi.TabIndex = 3;
            this.Pb_Kirmizi.TabStop = false;
            this.Pb_Kirmizi.Tag = "";
            this.Pb_Kirmizi.Visible = false;
            // 
            // Pb_Yesil
            // 
            this.Pb_Yesil.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Yesil.Image = global::WindowsFormsApplication1.Properties.Resources.yesil_lamba;
            this.Pb_Yesil.Location = new System.Drawing.Point(178, 216);
            this.Pb_Yesil.Name = "Pb_Yesil";
            this.Pb_Yesil.Size = new System.Drawing.Size(65, 64);
            this.Pb_Yesil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Yesil.TabIndex = 4;
            this.Pb_Yesil.TabStop = false;
            this.Pb_Yesil.Visible = false;
            // 
            // Pb_Sari
            // 
            this.Pb_Sari.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Sari.Image = global::WindowsFormsApplication1.Properties.Resources.sari_lamba;
            this.Pb_Sari.Location = new System.Drawing.Point(178, 115);
            this.Pb_Sari.Name = "Pb_Sari";
            this.Pb_Sari.Size = new System.Drawing.Size(64, 92);
            this.Pb_Sari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Sari.TabIndex = 5;
            this.Pb_Sari.TabStop = false;
            this.Pb_Sari.Visible = false;
            // 
            // Btn_Ayarlar
            // 
            this.Btn_Ayarlar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ayarlar;
            this.Btn_Ayarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Ayarlar.Location = new System.Drawing.Point(15, 17);
            this.Btn_Ayarlar.Name = "Btn_Ayarlar";
            this.Btn_Ayarlar.Size = new System.Drawing.Size(53, 51);
            this.Btn_Ayarlar.TabIndex = 6;
            this.Btn_Ayarlar.UseVisualStyleBackColor = true;
            this.Btn_Ayarlar.Click += new System.EventHandler(this.Btn_Ayarlar_Click);
            // 
            // Frm_TrafikLambasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.trafiklambasi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(415, 610);
            this.Controls.Add(this.Btn_Ayarlar);
            this.Controls.Add(this.Pb_Sari);
            this.Controls.Add(this.Pb_Yesil);
            this.Controls.Add(this.Pb_Kirmizi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_TrafikLambasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trafik Lambası";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Kirmizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Yesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Sari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Tmr_Kirmizi;
        private System.Windows.Forms.Timer Tmr_Sari;
        private System.Windows.Forms.Timer Tmr_Yesil;
        private System.Windows.Forms.PictureBox Pb_Kirmizi;
        private System.Windows.Forms.PictureBox Pb_Yesil;
        private System.Windows.Forms.PictureBox Pb_Sari;
        private System.Windows.Forms.Button Btn_Ayarlar;
    }
}

