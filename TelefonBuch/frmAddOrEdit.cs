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
    public partial class frmAddOrEdit : Form
    {
        ITelefonBuchRepository repository;
        public int kontaktId = 0;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new TelefonBuch();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (kontaktId == 0)
            {
                this.Text = "Neuer Kontakt";
            }
            else
            {
                this.Text = "Kontakt Bearbeiten";
                DataTable dt = repository.SelectRow(kontaktId);
                txtName.Text = dt.Rows[0][1].ToString();
                txtFamilie.Text = dt.Rows[0][2].ToString();
                txtHandyNummer.Text = dt.Rows[0][3].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();
                txtAge.Text = dt.Rows[0][5].ToString();
                txtAnschrift.Text = dt.Rows[0][6].ToString();
                btnSubmit.Text = "Bearbeiten";
            }
        }

        bool ValidateInputs()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Bitte Gehen Sie Ihren Namen ein", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFamilie.Text == "")
            {
                MessageBox.Show("Bitte Gehen Sie Ihren Familie ein", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtHandyNummer.Text == "")
            {
                MessageBox.Show("Bitte Gehen Sie Ihren HandyNummer ein", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Bitte Gehen Sie Ihre Email ein", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtAge.Value == 0)
            {
                MessageBox.Show("Bitte Gehen Sie Ihr Alter ein", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool isSuccess;
                if (kontaktId == 0)
                {
                    isSuccess = repository.Insert(txtName.Text, txtFamilie.Text, txtHandyNummer.Text, txtEmail.Text, (int)txtAge.Value, txtAnschrift.Text);
                }
                else
                {
                    isSuccess = repository.Update(kontaktId, txtName.Text, txtFamilie.Text, txtHandyNummer.Text, txtEmail.Text, (int)txtAge.Value, txtAnschrift.Text);
                }


                if (isSuccess == true)
                {
                    MessageBox.Show("Mission Erfüllt", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Die Operation ist Fehlgeschlagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
