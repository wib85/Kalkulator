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
    public partial class FrmKalkulator : Form
    {

        private IList<Kalkulator> listOfKalkulator = new List<Kalkulator>();
        // constructor
        public FrmKalkulator()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwKalkulator.View = View.Details;
            lvwKalkulator.FullRowSelect = true;
            lvwKalkulator.GridLines = true;
            lvwKalkulator.Columns.Add("", 501, HorizontalAlignment.Left);
        }


        private void FrmEntry_OnCreate(Kalkulator cal)
        {
            listOfKalkulator.Add(cal);
            int noUrut = lvwKalkulator.Items.Count + 1;
            ListViewItem item = new ListViewItem(cal.hasil);
            item.SubItems.Add(cal.hasil);
            
            lvwKalkulator.Items.Add(item);
        }

        private void btnHitung_Click_1(object sender, EventArgs e)
        {
            FrmEntryKalkulator frmEntry = new FrmEntryKalkulator("Calculator");
            frmEntry.OnCreate += FrmEntry_OnCreate;
            frmEntry.ShowDialog();
        }
    }
}
