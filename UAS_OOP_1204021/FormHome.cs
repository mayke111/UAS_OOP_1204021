using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204021
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void prodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdi Tampil = new FormProdi();
            Tampil.Show();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMahasiswa Tampil = new FormMahasiswa();
            Tampil.Show();
        }

        private void mahasiswaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormViewMahasiswa Tampil = new FormViewMahasiswa();
            Tampil.Show();
        }

        private void prodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormViewProdi Tampil = new FormViewProdi();
            Tampil.Show();
        }

        private void daftarUlangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewDaftarUlang Tampil = new FormViewDaftarUlang();
            Tampil.Show();
        }

        private void mahasiswaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormUpdateMahasiswa Tampil = new FormUpdateMahasiswa();
            Tampil.Show();
        }

        private void prodiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormUpdateProdi Tampil = new FormUpdateProdi();
            Tampil.Show();
        }

        private void daftarUlangToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormUpdateDaftarUlang Tampil = new FormUpdateDaftarUlang();
            Tampil.Show();
        }

        private void daftarUlangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDaftarUlang Tampil = new FormDaftarUlang();
            Tampil.Show();
        }
    }
}
