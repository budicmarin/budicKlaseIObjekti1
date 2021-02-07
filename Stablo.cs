using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicKlaseIObjekti1
{
    class Stablo:Biljka
    {
       public bool opadajuListovi;
        Stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }
        public bool OpadajuListovi()
        {
            return opadajuListovi;
        }
    }
}
