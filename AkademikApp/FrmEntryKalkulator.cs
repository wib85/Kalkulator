using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademikApp
{
    public partial class FrmEntryKalkulator : Form
    {

        public delegate void CreateUpdateEventHandler(Kalkulator mhs);
        
        public event CreateUpdateEventHandler OnCreate;

        // Constructor default
        public FrmEntryKalkulator() 
        {
            InitializeComponent();
        }

        public FrmEntryKalkulator(string title) 
            : this()
        {
            this.Text = title;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Kalkulator cal = new Kalkulator();
            cal.nilaipertama = Int32.Parse(txtNilaiA.Text);
            cal.nilaikedua = Int32.Parse(txtNilaiB.Text);
            string operasi = cmbOperasi.Text;
            switch (operasi)
            {
                case "Penambahan":
                    cal.hasil = String.Format("Hasil Penambahan {0} + {1} = {2}", txtNilaiA.Text, txtNilaiB.Text, (cal.nilaipertama + cal.nilaikedua));
                    break;
                case "Pengurangan":
                    cal.hasil = String.Format("Hasil Pengurangan {0} - {1} = {2}", txtNilaiA.Text, txtNilaiB.Text, (cal.nilaipertama - cal.nilaikedua));
                    break;
                case "Perkalian":
                    cal.hasil = String.Format("Hasil Perkalian {0} * {1} = {2}", txtNilaiA.Text, txtNilaiB.Text, (cal.nilaipertama * cal.nilaikedua));
                    break;
                case "Pewmbagian":
                    cal.hasil = String.Format("Hasil Pembagian {0} / {1} = {2}", txtNilaiA.Text, txtNilaiB.Text, (cal.nilaipertama / cal.nilaikedua));
                    break;
            }
            OnCreate(cal);
            cmbOperasi.SelectedItem = "Penambahan";
            txtNilaiA.Clear();
            txtNilaiB.Clear();
            txtNilaiA.Focus();

            this.Close();
        }
    }
}
