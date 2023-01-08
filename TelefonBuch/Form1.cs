using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonBuch
{
    public partial class Form1 : Form
    {
        ITelefonBuchRepository repository;
        public Form1()
        {
            InitializeComponent();
            repository = new TelefonBuch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgKontakt.AutoGenerateColumns = false;
            dgKontakt.DataSource = repository.SelectAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frm = new frmAddOrEdit();
            frm.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            if (dgKontakt.CurrentRow != null)
            {
                if (MessageBox.Show("Möchten Sie diesen Kontakt wirklich Löschen ?", "Warnung", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int kontaktId = int.Parse(dgKontakt.CurrentRow.Cells[0].Value.ToString());
                    repository.Delete(kontaktId);
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("Bitte Walhen Sie einen Kontakt aus");
            }
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            if(dgKontakt.CurrentRow!=null)
            {
                int kontaktId = int.Parse(dgKontakt.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdit frm = new frmAddOrEdit();
                frm.kontaktId = kontaktId;
                if(frm.ShowDialog()==DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void txtSuche_TextChanged(object sender, EventArgs e)
        {
            dgKontakt.DataSource = repository.Search(txtSuche.Text);
        }
    }
}
