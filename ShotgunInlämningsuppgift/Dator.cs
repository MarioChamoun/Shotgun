using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunInlämningsuppgift
{

    public class Dator
    {
        public int Antaldatorskott { get; set; }
        int maxskott = 3;
        resultat resultat = new resultat();

        public virtual void skott(mainform form,string metod)
        {
            if(metod == "Ladda") {
                if (Antaldatorskott == maxskott) { form.datorval(); }
                else
                {

                    Antaldatorskott = Antaldatorskott + 1;
                    form.lblAntalDatorSkott.Text = Antaldatorskott.ToString();
                    form.lstAction.Items.Add("Datorn ladda ett skott!");
                }
            }
            else if(metod == "Skjuta") {
                if (form.lblAntalDatorSkott.Text == "0") { form.datorval(); }
                else
                {

                    Antaldatorskott = Antaldatorskott - 1;
                    form.lblAntalDatorSkott.Text = Antaldatorskott.ToString();
                    form.lstAction.Items.Add("Datorn sköt ett skott!");
                }
            }
            else if(metod == "Blocka") {
                form.lblAntalDatorSkott.Text = Antaldatorskott.ToString();
                form.lstAction.Items.Add("Datorn har blockerat!");
            }
        }

    }
}
