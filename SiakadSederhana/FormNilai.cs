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
    public partial class FormNilai : Form
    {
        public static List<Nilai> ListNilai =new List<Nilai >();

        private Nilai nilaiDiklik = null;

        public FormNilai()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Nilai newNilai = new Nilai();
                newNilai.IdSemester = "Id Semester" + i.ToString();
                newNilai.KodeMataKuliah = "Kode MK" + i.ToString();
                newNilai.Nim = "123456789" + i.ToString();
                newNilai.NilaiAngka = 80;
                newNilai.NilaiHuruf = "Nilai huruf" + i.ToString();

                ListNilai.Add(newNilai);
            }
            dataGridViewData.DataSource = ListNilai;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahNilai formTambahNilai = new FormTambahNilai();
            formTambahNilai.Show();
            formTambahNilai.tambah = true;

        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var nilaiCell = dataGridViewData.Rows[e.RowIndex].Cells[0].Value;
            var nilaiCell1 = dataGridViewData.Rows[e.RowIndex].Cells[1].Value;
            var nilaiCell2 = dataGridViewData.Rows[e.RowIndex].Cells[2].Value;


            if (nilaiCell != null && nilaiCell1 != null && nilaiCell2 != null)
            {
                var isiCell = nilaiCell.ToString();
                var isiCell1 = nilaiCell1.ToString();
                var isiCell2 = nilaiCell2.ToString();

                nilaiDiklik = ListNilai.Find(x => x.IdSemester == isiCell && x.KodeMataKuliah == isiCell1 && x.Nim == isiCell2);

            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormTambahNilai formTambahNilai = new FormTambahNilai();
            formTambahNilai.nilaiDipilih = nilaiDiklik;
            formTambahNilai.Show();
            formTambahNilai.tambah = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = ListNilai;
        }
        

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.DataSource != null)
            {
                FormNilai.ListNilai.Remove(nilaiDiklik);
            }

            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = ListNilai;
        }

        private void FormNilai_Activated(object sender, EventArgs e)
        {
            buttonRefresh.PerformClick();
        }
    }
}
