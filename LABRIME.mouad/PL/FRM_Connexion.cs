using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABRIME.mouad.PL
{
    public partial class FRM_Connexion : Form
    {
        private dbStockContext db;
        private Form frmenu;
        BL.CLS_Connexion C = new BL.CLS_Connexion();
        public FRM_Connexion(Form Menu)
        {
            InitializeComponent();
            this.frmenu= Menu;
            db = new dbStockContext();
        }
        string testobligatoire()
        {
            if(textNom.Text=="" || textNom.Text== "Nom d'utilisateur")
            {
                return "Entrer votre nom";
            }
            if(textmoddepasse.Text=="" || textmoddepasse.Text== "Mot de passe")
            {
                return "Entrer votre mot de passe";
            }
            //enter name o dakchi dialo = nll;
            return null;
            
        }
        private void FRM_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (textNom.Text == "Nom d'utilisateur")
            {
                textNom.Text = "";
                textNom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtmotdepasse_Enter(object sender, EventArgs e)
        {
            if (textmoddepasse.Text == "Mot de passe")
            {
                textmoddepasse.Text = "";
                textmoddepasse.UseSystemPasswordChar = false;
                textmoddepasse.PasswordChar = '*';
                textmoddepasse.ForeColor = Color.WhiteSmoke;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testobligatoire() == null)
            {
                if (C.ConnexionValide(db, textNom.Text, textmoddepasse.Text)==true)
                {
                    MessageBox.Show("Connexion a réussi","Connexion",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    (frmenu as btnparamettre).activerForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Connexion a échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(testobligatoire(),"obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
        }

        private void txtmotdepasse_Leave(object sender, EventArgs e)
        {
            if (textmoddepasse.Text == "")
            {
                textmoddepasse.Text = "Mot de Passe";
                textmoddepasse.UseSystemPasswordChar = true;
                textmoddepasse.ForeColor = Color.Silver;
            }
        }
    }
    }

