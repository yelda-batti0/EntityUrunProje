using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityUrunProje
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUNLER select new { x.URUNID, x.URUNAD, x.MARKA, x.STOK, x.FİYAT, x.TBLKATEGORILER.AD, x.DURUM }).ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLURUNLER t = new TBLURUNLER();
            t.URUNAD = txturunadi.Text;
            t.MARKA = txtmarka.Text;
            t.STOK = short.Parse(txtstok.Text);
            t.KATEGORI = int.Parse(cmbkategori.SelectedValue.ToString());
            t.FİYAT = decimal.Parse(txtfiyat.Text);
            t.DURUM = true;
            db.TBLURUNLER.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün ekleme işlemi başarıyla gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txturunid.Text);
            var urun = db.TBLURUNLER.Find(x);
            db.TBLURUNLER.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txturunid.Text);
            var urun = db.TBLURUNLER.Find(x);
            urun.URUNAD = txturunadi.Text;
            urun.MARKA = txtmarka.Text;
            urun.STOK = short.Parse(txtstok.Text);
            urun.FİYAT = decimal.Parse(txtfiyat.Text);
            urun.DURUM = true;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORILER select new { x.ID, x.AD }).ToList();
            cmbkategori.ValueMember = "ID";
            cmbkategori.DisplayMember = "AD";
            cmbkategori.DataSource = kategoriler;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txturunid.Text = " ";
            txturunadi.Text = " ";
            txtmarka.Text = " ";
            txtstok.Text = " ";
            txtfiyat.Text = "";
            
        }
    }
}
