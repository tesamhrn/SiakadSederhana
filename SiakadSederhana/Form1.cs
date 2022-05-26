using SiakadSederhana.FormDtNilai;
using SiakadSederhana.FormMK;
using SiakadSederhana.FormsMahasiswa;
using SiakadSederhana.FormSmstr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiakadSederhana
{
    public partial class Form1 : Form
    {
        private FormDaftarMhs formMhs;
        private FormDaftarMK formMk;
        private FormDaftarSmtr formSmtr;
        private FormDaftarNilai formNilay;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonMataKuliah_Click(object sender, EventArgs e)
        {
            formMk.Show();
        }

        private void buttonMahasiswa_Click_1(object sender, EventArgs e)
        {
            formMhs.Show();
        }

        
        private void buttonSemester_Click_1(object sender, EventArgs e)
        {
            formSmtr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formNilay.Show();
        }
    }
}