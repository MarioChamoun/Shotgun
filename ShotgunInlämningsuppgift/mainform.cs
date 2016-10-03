using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShotgunInlämningsuppgift
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        public bool DatorVinst { get; set; }
        public bool SpelarVinst { get; set; }
        int spelarSkott = 0;
        int datorSkott = 0;
        Spelare nyspelare = new Spelare();
        resultat resultat = new resultat();
        Dator nydator = new Dator();

        public void datorval()
        {
                nydator.Antaldatorskott = int.Parse(lblAntalDatorSkott.Text);
                Random rnd = new Random();
                int val = rnd.Next(0, 3);
            if (lblAntalDatorSkott.Text == "3") { datorshotgun(); }
            else
            {
                if (val == 0) { resultat.DatorVal = "Ladda"; nydator.skott(this, "Ladda"); vinst(); }
                else if (val == 1) { resultat.DatorVal = "Skjuta"; nydator.skott(this, "Skjuta"); vinst(); }
                else if (val == 2) { resultat.DatorVal = "Blocka"; nydator.skott(this, "Blocka"); vinst(); }
            }
        }

        private void spelaigen()
        {
            DatorVinst = false;
            SpelarVinst = false;
            spelarSkott = 0;
            datorSkott = 0;
            nydator.Antaldatorskott = 0;
            lblAntalSkott.Text =  "0";
            if (spelarSkott < 3) { btnShotgun.Enabled = false; }
            lblAntalDatorSkott.Text =  "0";

            lstAction.Items.Clear();
        }

        private void vinst()
        {
            resultat.checkavinst(this);
            if(DatorVinst == true)
            {
                lstAction.Items.Add("DU FÖRLORA!!!");
                
                if (MessageBox.Show("Vill du spela igen?", "DU HAR FÖRLORAT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    spelaigen();

                }
                else
                {
                    this.Close();
                }

            }
            else if(SpelarVinst == true)
            {
                lstAction.Items.Add("DU VANN!!!");
                if (MessageBox.Show("Vill du spela igen?", "DU HAR VUNNIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    spelaigen();

                } else
                {
                    this.Close();
                }

            }
        }

        private void datorshotgun()
        {
            if(lblAntalDatorSkott.Text == "3")
            {
                lstAction.Items.Clear();
                lstAction.Items.Add("Datorn använde shotgun!");
                lstAction.Items.Add("DU FÖRLORA!!!");
                if (MessageBox.Show("Vill du spela igen?", "DU HAR FÖRLORAT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    spelaigen();
                    
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                btnBlocka.Enabled = false;
                btnLadda.Enabled = false;
                btnSkjuta.Enabled = false;
                btnShotgun.Enabled = false;
                lblAntalDatorSkott.Visible = false;
                lblAntalSkott.Visible = false;
                lblDatortext.Visible = false;
                lblTextSkott.Visible = false;
        }

        private void btnLadda_Click(object sender, EventArgs e)
        {
            
            if (spelarSkott == 3) { MessageBox.Show("Du kan inte få fler än 3 skott"); }
            else
            {
                lstAction.Items.Clear();
                nyspelare.AntalSpelarSkott = spelarSkott;
                spelarSkott = nyspelare.laddaskott();
                lblAntalSkott.Text = spelarSkott.ToString();
                lstAction.Items.Add("Du har fått ett skott");
                if(spelarSkott == 3) { btnShotgun.Enabled = true; } else { btnShotgun.Enabled = false; }
                resultat.SpelareVal = "Ladda";
                datorval();
            }
        }

        private void btnSkjuta_Click(object sender, EventArgs e)
        {
            if(spelarSkott < 1) { MessageBox.Show("Du har inga skott att skjuta med"); }
            else
            {
                lstAction.Items.Clear();
                nyspelare.AntalSpelarSkott = spelarSkott;
                spelarSkott = nyspelare.skjutaskott();
                lblAntalSkott.Text = spelarSkott.ToString();
                lstAction.Items.Add("Du sköt ett skott!");
                btnShotgun.Enabled = false;
                resultat.SpelareVal = "Skjuta";
                datorval();
            }
        }

        private void btnBlocka_Click(object sender, EventArgs e)
        {
            lstAction.Items.Clear();
            resultat.SpelareVal = "Blocka";
            nyspelare.AntalSpelarSkott = spelarSkott;
            lstAction.Items.Add("Du har blockerat!");
            datorval();
        }

        private void btnStartaSpel_Click(object sender, EventArgs e)
        {
            btnBlocka.Enabled = true;
            btnLadda.Enabled = true;
            btnSkjuta.Enabled = true;
            btnShotgun.Enabled = true;
            lblAntalDatorSkott.Visible = true;
            lblAntalSkott.Visible = true;
            lblDatortext.Visible = true;
            lblTextSkott.Visible = true;
            btnStartaSpel.Enabled = false;
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            lstAction.Items.Clear();
            lstAction.Items.Add("Du använde shotgun!");
            lstAction.Items.Add("DU VANN!!!");
            if (MessageBox.Show("Vill du spela igen?", "DU HAR VUNNIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                spelaigen();
            }
            else
            {
                this.Close();
            }
        }
    }
}
