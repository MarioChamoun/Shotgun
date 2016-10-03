using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunInlämningsuppgift
{
   public class resultat
    {

        public string DatorVal { get; set; }
        public string SpelareVal { get; set; }

        public void checkavinst(mainform form)
        {

                if (DatorVal == "Skjuta" && SpelareVal == "Ladda")
                {
                    form.DatorVinst = true;
                    form.SpelarVinst = false;
                }
                else if (SpelareVal == "Skjuta" && DatorVal == "Ladda")
                {
                    form.SpelarVinst = true;
                    form.DatorVinst = false;
                }
            }
    }
}
