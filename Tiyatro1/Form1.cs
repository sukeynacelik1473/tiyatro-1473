using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiyatro1
{
    public partial class Form1 : Form
    {
        BindingList<Tiyatro> oyunlar = new BindingList<Tiyatro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string oyunAd = cmbOyun.Text;
            string sahne = cmbSahne.Text;
            DateTime tarih = dtpTarih.Value;
            int sure = Convert.ToInt32(numSure.Value);
            int fiyat = Convert.ToInt32(txtFiyat.Text);
            bool muzikal = cbMuzikal.Checked;

            Tiyatro oyun = new Tiyatro(oyunAd, sahne, tarih, sure, fiyat, muzikal);

            oyunlar.Add(oyun);

            dtvBilgi.Refresh();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dtvBilgi.SelectedRows.Count > 0)
            {
                Tiyatro tiyatro = (Tiyatro)dtvBilgi.SelectedRows[0].DataBoundItem;

                tiyatro.Oyun = cmbOyun.Text;
                tiyatro.Sahne = cmbSahne.Text;
                tiyatro.KayitTarih = dtpTarih.Value;
                tiyatro.Sure = Convert.ToInt32(numSure.Value);
                tiyatro.Fiyat = Convert.ToInt32(txtFiyat.Text);
                tiyatro.Muzikal = cbMuzikal.Checked;

                dtvBilgi.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tiyatro oyun1 = new Tiyatro("Karagöz", "Bağcılar", new DateTime(2023, 10, 05), 100, 50, true);
            Tiyatro oyun2 = new Tiyatro("Kukla", "Atatürk Kültür Merkezi", new DateTime(2024, 01, 25), 50, 20, false);
            Tiyatro oyun3 = new Tiyatro("Hokkabazlık", "Fatih Belediyesi", new DateTime(2024, 02, 08), 45, 30, true);

            oyunlar.Add(oyun1);
            oyunlar.Add(oyun2);
            oyunlar.Add(oyun3);

            dtvBilgi.DataSource = oyunlar;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dtvBilgi.SelectedRows.Count > 0)
            {
                Tiyatro oyun = (Tiyatro)dtvBilgi.SelectedRows[0].DataBoundItem;

                DialogResult sonuc = MessageBox.Show(oyun.Oyun + " Silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {

                    oyunlar.Remove(oyun);
                }
            }
        }

        private void dtvBilgi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvBilgi.SelectedRows.Count > 0)
            {
                Tiyatro tiyatro = (Tiyatro)dtvBilgi.SelectedRows[0].DataBoundItem;

                cmbOyun.Text = tiyatro.Oyun;
                cmbSahne.Text = tiyatro.Sahne;
                dtpTarih.Value = tiyatro.KayitTarih;
                numSure.Value = tiyatro.Sure;
                txtFiyat.Text = tiyatro.Fiyat.ToString();
                cbMuzikal.Checked = tiyatro.Muzikal;
            }
        }
    }
    
    
}
    

