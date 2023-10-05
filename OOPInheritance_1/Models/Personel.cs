using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance_1.Models
{
    public class Personel
    {

        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        protected string TCKNo { get; set; } //protected erişim belirteciyle marklanmıs olan bu oge sadece bu sınıfın miras verildigi yerlerde kullanılabilir

        protected internal string Deneme{get;set;}
        public string BilgiGoster()
        {
            return $"{Isim} {SoyIsim} {TCKNo}";
        }

    }
}
