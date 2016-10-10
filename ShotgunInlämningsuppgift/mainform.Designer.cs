namespace ShotgunInlämningsuppgift
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLadda = new System.Windows.Forms.Button();
            this.btnBlocka = new System.Windows.Forms.Button();
            this.btnSkjuta = new System.Windows.Forms.Button();
            this.lblTextSkott = new System.Windows.Forms.Label();
            this.lblAntalSkott = new System.Windows.Forms.Label();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.lstAction = new System.Windows.Forms.ListBox();
            this.lblAntalDatorSkott = new System.Windows.Forms.Label();
            this.lblDatortext = new System.Windows.Forms.Label();
            this.btnStartaSpel = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLadda
            // 
            this.btnLadda.Location = new System.Drawing.Point(213, 68);
            this.btnLadda.Name = "btnLadda";
            this.btnLadda.Size = new System.Drawing.Size(75, 23);
            this.btnLadda.TabIndex = 0;
            this.btnLadda.Text = "Ladda";
            this.btnLadda.UseVisualStyleBackColor = true;
            this.btnLadda.Click += new System.EventHandler(this.btnLadda_Click);
            // 
            // btnBlocka
            // 
            this.btnBlocka.Location = new System.Drawing.Point(213, 107);
            this.btnBlocka.Name = "btnBlocka";
            this.btnBlocka.Size = new System.Drawing.Size(75, 23);
            this.btnBlocka.TabIndex = 1;
            this.btnBlocka.Text = "Blocka";
            this.btnBlocka.UseVisualStyleBackColor = true;
            this.btnBlocka.Click += new System.EventHandler(this.btnBlocka_Click);
            // 
            // btnSkjuta
            // 
            this.btnSkjuta.Location = new System.Drawing.Point(213, 149);
            this.btnSkjuta.Name = "btnSkjuta";
            this.btnSkjuta.Size = new System.Drawing.Size(75, 23);
            this.btnSkjuta.TabIndex = 2;
            this.btnSkjuta.Text = "Skjuta";
            this.btnSkjuta.UseVisualStyleBackColor = true;
            this.btnSkjuta.Click += new System.EventHandler(this.btnSkjuta_Click);
            // 
            // lblTextSkott
            // 
            this.lblTextSkott.AutoSize = true;
            this.lblTextSkott.Location = new System.Drawing.Point(200, 18);
            this.lblTextSkott.Name = "lblTextSkott";
            this.lblTextSkott.Size = new System.Drawing.Size(88, 13);
            this.lblTextSkott.TabIndex = 4;
            this.lblTextSkott.Text = "Antal spelar skott";
            // 
            // lblAntalSkott
            // 
            this.lblAntalSkott.AutoSize = true;
            this.lblAntalSkott.ForeColor = System.Drawing.Color.Crimson;
            this.lblAntalSkott.Location = new System.Drawing.Point(210, 41);
            this.lblAntalSkott.Name = "lblAntalSkott";
            this.lblAntalSkott.Size = new System.Drawing.Size(13, 13);
            this.lblAntalSkott.TabIndex = 5;
            this.lblAntalSkott.Text = "0";
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(213, 205);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(75, 23);
            this.btnShotgun.TabIndex = 6;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // lstAction
            // 
            this.lstAction.FormattingEnabled = true;
            this.lstAction.Location = new System.Drawing.Point(12, 68);
            this.lstAction.Name = "lstAction";
            this.lstAction.Size = new System.Drawing.Size(195, 160);
            this.lstAction.TabIndex = 7;
            // 
            // lblAntalDatorSkott
            // 
            this.lblAntalDatorSkott.AutoSize = true;
            this.lblAntalDatorSkott.ForeColor = System.Drawing.Color.Crimson;
            this.lblAntalDatorSkott.Location = new System.Drawing.Point(12, 41);
            this.lblAntalDatorSkott.Name = "lblAntalDatorSkott";
            this.lblAntalDatorSkott.Size = new System.Drawing.Size(13, 13);
            this.lblAntalDatorSkott.TabIndex = 9;
            this.lblAntalDatorSkott.Text = "0";
            // 
            // lblDatortext
            // 
            this.lblDatortext.AutoSize = true;
            this.lblDatortext.Location = new System.Drawing.Point(12, 18);
            this.lblDatortext.Name = "lblDatortext";
            this.lblDatortext.Size = new System.Drawing.Size(84, 13);
            this.lblDatortext.TabIndex = 8;
            this.lblDatortext.Text = "Antal dator skott";
            // 
            // btnStartaSpel
            // 
            this.btnStartaSpel.Location = new System.Drawing.Point(12, 234);
            this.btnStartaSpel.Name = "btnStartaSpel";
            this.btnStartaSpel.Size = new System.Drawing.Size(75, 23);
            this.btnStartaSpel.TabIndex = 10;
            this.btnStartaSpel.Text = "Starta Spel";
            this.btnStartaSpel.UseVisualStyleBackColor = true;
            this.btnStartaSpel.Click += new System.EventHandler(this.btnStartaSpel_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.ForeColor = System.Drawing.Color.Navy;
            this.lblResultat.Location = new System.Drawing.Point(137, 278);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 13);
            this.lblResultat.TabIndex = 11;
            this.lblResultat.Visible = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 264);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnStartaSpel);
            this.Controls.Add(this.lblAntalDatorSkott);
            this.Controls.Add(this.lblDatortext);
            this.Controls.Add(this.lstAction);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.lblAntalSkott);
            this.Controls.Add(this.lblTextSkott);
            this.Controls.Add(this.btnSkjuta);
            this.Controls.Add(this.btnBlocka);
            this.Controls.Add(this.btnLadda);
            this.Name = "mainform";
            this.Text = "Shotgun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox lstAction;
        public System.Windows.Forms.Label lblAntalDatorSkott;
        public System.Windows.Forms.Button btnLadda;
        public System.Windows.Forms.Button btnBlocka;
        public System.Windows.Forms.Button btnSkjuta;
        public System.Windows.Forms.Label lblTextSkott;
        public System.Windows.Forms.Label lblAntalSkott;
        public System.Windows.Forms.Button btnShotgun;
        public System.Windows.Forms.Label lblDatortext;
        public System.Windows.Forms.Button btnStartaSpel;
        private System.Windows.Forms.Label lblResultat;
    }
}

