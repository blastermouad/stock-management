using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LABRIME.mouad.PL
{
    
    public partial class FRM_Ajoute_Modifier_Client : Form
    {
        public int IdSELECT;
        private UserControl usclient;
        public FRM_Ajoute_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC;
        }
        string testobligatoire()
        {
            if (textNom.Text == "" || textNom.Text=="Nom Du Client")
            {
                return "Entrer le Nom du client";
            }
            if (textPrenom.Text == "" || textPrenom.Text == "Prenom Du Client")
            {
                return "Entrer le Prenom du client";
            }
            if (textadresse.Text == "" || textadresse.Text == "Adresse Client")
            {
                return "Entrer l'adresse du client";
            }
            if (textemail.Text == "" || textemail.Text == "Email Client")
            {
                return "Entrer l'email du client"; 
            }
            if (texttelephone.Text == "" || texttelephone.Text == "Telephone Client")
            {
                return "Entrer le telephone du client";
            }
            if (textville.Text == "" || textville.Text == "Ville Client")
            {
                return "Entrer ville du client";
            }
            if (textPays.Text == "" || textPays.Text == "Pay Client")
            {
                return "Entrer pay du client";
            }
            
            if(textemail.Text!="" || textemail.Text!="Email Client")
            {
                try
                {
                    new MailAddress(textemail.Text);
                }
                catch (Exception e)
                {
                    return "Email Invalide";
                }
            }
            return null;
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_Entrer(object sender, EventArgs e)
        {
            if(textNom.Text=="Nom Du Client")
            {
                textNom.Text = "";
                textNom.ForeColor = Color.White;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (textNom.Text == "")
            {
                textNom.Text = "Nom Du Client";
                textNom.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            if (textPrenom.Text == "Prenom Du Client")
            {
                textPrenom.Text = "";
                textPrenom.ForeColor = Color.White;
            }
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            if (textPrenom.Text == "")
            {
                textPrenom.Text = "Prenom Du Client";
                textPrenom.ForeColor = Color.Silver;
            }
        }

        private void txtTelephone_Entrer(object sender, EventArgs e)
        {
            if (texttelephone.Text == "Telephone Client")
            {
                texttelephone.Text = "";
                texttelephone.ForeColor = Color.White;
            }
        }

        private void txtTelephone_Leave(object sender, EventArgs e)
        {
            if (texttelephone.Text == "")
            {
                texttelephone.Text = "Telephone Client";
                texttelephone.ForeColor = Color.Silver;
            }
        }

        private void txtAdress_Entrer(object sender, EventArgs e)
        {
            if (textadresse.Text == "Adresse Client")
            {
                textadresse.Text = "";
                textadresse.ForeColor = Color.White;
            }
        }

        private void txtAdress_Leave(object sender, EventArgs e)
        {
            if (textadresse.Text == "")
            {
                textadresse.Text = "Adresse Client";
                textadresse.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Entrer(object sender, EventArgs e)
        {
            if (textemail.Text == "Email Client")
            {
                textemail.Text = "";
                textemail.ForeColor = Color.White;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (textemail.Text == "")
            {
                textemail.Text = "Email Client";
                textemail.ForeColor = Color.Silver;
            }
        }

        private void txtPays_Entrer(object sender, EventArgs e)
        {
            if (textPays.Text == "Pay Client")
            {
                textPays.Text = "";
                textPays.ForeColor = Color.White;
            }
        }

        private void txtPays_Leave(object sender, EventArgs e)
        {
            if (textPays.Text == "")
            {
                textPays.Text = "Pay Client";
                textPays.ForeColor = Color.Silver;
            }
        }

        private void txtVille_Entrer(object sender, EventArgs e)
        {
            if (textville.Text == "Ville Client")
            {
                textville.Text = "";
                textville.ForeColor = Color.White;
            }
        }

        private void txtVille_Leave(object sender, EventArgs e)
        {
            if (textville.Text == "")
            {
                textville.Text = "Ville Client";
                textville.ForeColor = Color.Silver;
            }
        }

        private void textPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(),"obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            if (lblTitre.Text =="Ajouter Client")
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                if (clclient.Ajoute_Client(textNom.Text, textPrenom.Text, textadresse.Text, texttelephone.Text, textemail.Text, textPays.Text, textville.Text) == true)
                {
                    MessageBox.Show("Client Ajouter avec succes","Ajouter",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    (usclient as USER_Liste_Client).Actualisedatagrid();
                }
                else
                {
                    MessageBox.Show("Nom et Prenom de client est déja existant", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier ce Client ?","Modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    clclient.Modifier_Client(IdSELECT, textNom.Text, textPrenom.Text, textadresse.Text, texttelephone.Text, textemail.Text, textPays.Text, textville.Text);
                    (usclient as USER_Liste_Client).Actualisedatagrid();
                    MessageBox.Show("Client Modifier avec succés","Modification",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Modification est annulé","Modification",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

                
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            textNom.Text = "Nom Du Client"; textNom.ForeColor = Color.Silver;
            textPrenom.Text = "Prenom Du Client"; textPrenom.ForeColor = Color.Silver;
            textadresse.Text = "Adresse Client"; textadresse.ForeColor = Color.Silver;
            textville.Text = "Ville Client"; textville.ForeColor = Color.Silver;
            textPays.Text = "Pay Client"; textPays.ForeColor = Color.Silver;
            texttelephone.Text = "Telephone Client"; texttelephone.ForeColor = Color.Silver;
            textemail.Text = "Email Client"; textemail.ForeColor = Color.Silver;
        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_Ajoute_Modifier_Client_Load(object sender, EventArgs e)
        {

        }

        private void textPays_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 