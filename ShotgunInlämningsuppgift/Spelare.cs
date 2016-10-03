using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunInlämningsuppgift
{
    public class Spelare
    {
        public int AntalSpelarSkott { get; set; }
        int maxskott = 3;

        public int laddaskott()
        {
            int antalskott;
            if (AntalSpelarSkott < maxskott)
            {
                AntalSpelarSkott = AntalSpelarSkott + 1;
                antalskott = AntalSpelarSkott;
                return antalskott;
            }
            else
            {
                antalskott = AntalSpelarSkott;
                return antalskott;
            }
        }

        public int skjutaskott()
        {
            int antalskott;
            int minstaskott = 1;
            if(AntalSpelarSkott >= minstaskott)
            {
                AntalSpelarSkott = AntalSpelarSkott - 1;
                antalskott = AntalSpelarSkott;
                return antalskott;
            }
            else
            {
                antalskott = AntalSpelarSkott;
                return antalskott;
            }
        }

        public void blockera()
        {
            int antalskott = AntalSpelarSkott;
            
        }
    }
}
