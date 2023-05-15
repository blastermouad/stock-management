using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABRIME.mouad.PL
{
    public partial class btnparamettre : Form
    {
        public btnparamettre()
        {
            InitializeComponent();
            pnlParamettrer.Visible = false; 
        }
        public void desactiverForm()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncategorie.Enabled = false;  
            btncommande.Enabled = false;
            btnutilisateur.Enabled=false;
            pnlBot.Enabled = false;
            btndesactiver.Enabled = false;
            btnconnecter.Enabled = true;
        }
        public void activerForm()
        {
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncategorie.Enabled = true;
            btncommande.Enabled = true;
            btnutilisateur.Enabled = true;
            pnlBot.Enabled = true;
            btndesactiver.Enabled = true;
            btnconnecter.Enabled= false;
            pnlParamettrer.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlBot.Top = btnproduit.Top;
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlBot.Top = btnclient.Top;
            if (!pnlafficher.Controls.Contains(USER_Liste_Client.Instance))
            {
                pnlafficher.Controls.Add(USER_Liste_Client.Instance);
                USER_Liste_Client.Instance.Dock = DockStyle.Fill;
                USER_Liste_Client.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Client.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlBot.Top = btncategorie.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlBot.Top = btncommande.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlBot.Top = btnutilisateur.Top;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnprmtre_Click(object sender, EventArgs e)
        {
            
            pnlParamettrer.Visible= !pnlParamettrer.Visible;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FRM_Connexion frmC= new FRM_Connexion(this);
            frmC.ShowDialog();
        }

        private void pnlParamettrer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnparamettre_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void btndesactiver_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }
    }
}
