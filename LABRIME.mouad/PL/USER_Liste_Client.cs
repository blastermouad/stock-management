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
    public partial class USER_Liste_Client : UserControl
    {
        private static USER_Liste_Client Userclient;
        private dbStockContext db;

        public static USER_Liste_Client Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_Liste_Client();
                }
                return Userclient;
            }
        }
        public USER_Liste_Client()
        {
            InitializeComponent();
            db = new dbStockContext();
            textrecherche.Enabled = false;
        }

        public void Actualisedatagrid()
        {
            db = new dbStockContext();
            dvgclient.Rows.Clear();
            foreach (var S in db.Clients)
            {
                dvgclient.Rows.Add(false,S.ID_Client,S.Nom_Client,S.Prenom_Client,S.Adresse_Client, S.Telephonne_Client, S.Email_Client, S.Pays_Client, S.Ville_Client);
            }
        }
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for(int i = 0; i < dvgclient.Rows.Count; i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value == true)//selectionnement d le ligne
                {
                    Nombreligneselect++;

                }
            }
            if(Nombreligneselect == 0)
            {
                return "Selectionnez Le Client Que Vous-Voulez Modifier !!!!!";
            }
            if (Nombreligneselect > 1)
            {
                return "Selectionnez 1 Seul Client Pour Modifier !!!!!";
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             BL.CLS_Client clclient = new BL.CLS_Client();
            int select = 0;
            for(int i=0; i < dvgclient.Rows.Count; i++)
            {
                if((bool)dvgclient.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if(select == 0)
            {
                MessageBox.Show("Aucun client selectionner","Suppresion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R = 
                MessageBox.Show("Voulez-vous vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R == DialogResult.Yes)
                {
                    for(int i=0; i < dvgclient.Rows.Count; i++)
                    {
                        if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                        {
                            clclient.suprimer_Client(int.Parse(dvgclient.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    Actualisedatagrid();
                    MessageBox.Show("Suppression avec succées","Supression",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Supression et annulé","Supression",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textrecherche.Text == "Recherche")
            {
                textrecherche.Text = "";
                textrecherche.ForeColor = Color.Black;
            }
        }

        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
             Actualisedatagrid();
        }

        private void btnajouteclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Client frmclient = new FRM_Ajoute_Modifier_Client(this);
            frmclient.ShowDialog();
        }

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Client frmclient = new PL.FRM_Ajoute_Modifier_Client(this);
            if (SelectVerif() == null)
            {
                for(int i = 0; i < dvgclient.Rows.Count; i++)
                {
                    if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                    {
                        frmclient.IdSELECT = (int)dvgclient.Rows[i].Cells[1].Value;
                        frmclient.textNom.Text = dvgclient.Rows[i].Cells[2].Value.ToString(); 
                        frmclient.textPrenom.Text = dvgclient.Rows[i].Cells[3].Value.ToString();
                        frmclient.textadresse.Text = dvgclient.Rows[i].Cells[4].Value.ToString();
                        frmclient.texttelephone.Text = dvgclient.Rows[i].Cells[5].Value.ToString();
                        frmclient.textemail.Text = dvgclient.Rows[i].Cells[6].Value.ToString();
                        frmclient.textPays.Text = dvgclient.Rows[i].Cells[7].Value.ToString();
                        frmclient.textville.Text = dvgclient.Rows[i].Cells[8].Value.ToString();
                        
                        
                        
                    }
                }
                frmclient.lblTitre.Text = "Modifier Client";
                frmclient.btnactualiser.Visible = false;
                frmclient.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(),"Modification",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void comborecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            textrecherche.Enabled = true;
            textrecherche.Text = "";
        }

        private void textrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.Clients.ToList();
            if(textrecherche.Text != "")
            {
                switch (comborecherche.Text)
                {
                    case "Nom":
                        listerecherche = listerecherche.Where(s => s.Nom_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Prenom":
                        listerecherche = listerecherche.Where(s => s.Prenom_Client. IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Adresse":
                        listerecherche = listerecherche.Where(s => s.Adresse_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Telephone":
                        listerecherche = listerecherche.Where(s => s.Telephonne_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listerecherche = listerecherche.Where(s => s.Email_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listerecherche = listerecherche.Where(s => s.Pays_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listerecherche = listerecherche.Where(s => s.Ville_Client.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    
                   
                    
                    
                }
            }
            dvgclient.Rows.Clear();
            foreach (var l in listerecherche)
            {
                dvgclient.Rows.Add(false, l.ID_Client, l.Nom_Client, l.Prenom_Client, l.Adresse_Client, l.Telephonne_Client, l.Email_Client, l.Pays_Client, l.Ville_Client);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
