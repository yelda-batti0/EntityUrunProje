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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATEGORILER.ToList();
            dataGridView1.DataSource = kategoriler;
        }

     

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORILER t = new TBLKATEGORILER();
            t.AD = txtkategoriad.Text;
            db.TBLKATEGORILER.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Ekleme işlemi tamamlandı. 'Listele' butonuna tıklayarak listenin güncel haline ulaşabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtkategorid.Text);
            var ktgr = db.TBLKATEGORILER.Find(x);
            db.TBLKATEGORILER.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi. 'Listele' butonuna tıklayarak listenin güncel haline ulaşabilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtkategorid.Text);
            var ktgr = db.TBLKATEGORILER.Find(x);
            ktgr.AD = txtkategoriad.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi tamamlandı. 'Listele' butonuna tıklayarak listenin güncel haline ulaşabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
