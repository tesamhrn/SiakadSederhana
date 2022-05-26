using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiakadSederhana.Entitas;

namespace SiakadSederhana
{
    public partial class FormTambahMahasiswa : Form
    {
        public Mahasiswa mahasiswaDipilih = null;

        public bool tambah = false;
        
        public FormTambahMahasiswa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 10)
            {
                MessageBox.Show("Panjang NIM harus 10 karakter");

                return;
            }

            long longNim = 0;

            if (long.TryParse(textBox1.Text, out longNim) == false )
            {
                MessageBox.Show("NIM harus angka");

                return;
            }

            if (tambah == true )
            {
                Mahasiswa newMahasiswa = new Mahasiswa();
                newMahasiswa.Nim = textBox1.Text;
                newMahasiswa.Nama = textBox2.Text;
                newMahasiswa.JenisKelamin = bool.Parse(textBox3.Text);
                newMahasiswa.Angkatan = int.Parse(textBox4.Text);

                FormMahasiswa.ListMahasiswa.Add(newMahasiswa);
                MessageBox.Show("Data telah ditambahkan");

                this.Close();

            }
            else
            {
                if (mahasiswaDipilih != null)
                {
                    var mahasiswaYangMauDiEdit = FormMahasiswa.ListMahasiswa.Find(x => x.Nim == mahasiswaDipilih.Nim);

                    if (mahasiswaYangMauDiEdit != null)
                    {
                        mahasiswaYangMauDiEdit.Nama = textBox2.Text;
                        mahasiswaYangMauDiEdit.JenisKelamin = bool.Parse(textBox3.Text);
                        mahasiswaYangMauDiEdit.Angkatan = int.Parse(textBox4.Text);

                        MessageBox.Show("Data telah diubah");
                        this.Close();
                    }
                }

            }

        }
        
        private void FormTambahMahasiswa_Shown_1(object sender, EventArgs e)
        {
            if (mahasiswaDipilih != null)
            {
                textBox1.Text = mahasiswaDipilih.Nim;
                textBox2.Text = mahasiswaDipilih.Nama;
                textBox3.Text = mahasiswaDipilih.JenisKelamin.ToString();
                textBox4.Text = mahasiswaDipilih.Angkatan.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}