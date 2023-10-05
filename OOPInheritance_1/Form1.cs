using OOPInheritance_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPInheritance_1
{
    public partial class Form1 : Form
    {

        /*
         
                        ****Inheritance Miras Alma / Verme
                        *
                        *Eger yarattıgınız bir sınıfın ögelerini baska sınıflarda da kullanmak istiyorsanız bu ögeleri tekrar tekrar yazmak yonetilebilirligi, geliştirilebilirligi ve tekrar kullanılabilirligi  tamamen kapatacaktır... Aynı zamanda kod tekrarı yaptıgınız icin gelen sablonda bir degişiklik yapmak istediginiz takdirde tek tek tüm o özellikleri yazdıgımız snıflarda degişikligi uygulamak zorunda kalacagız...
                        *
                        *
                        *Inheritance, bir sınıfnı baska bir sınıfa kalıtım vermesidir...Bir sınıfa kalıtım veren sınıf ona tüm ögelerini aktarır...Özelliklerini bir sınıfa aktaran bir class'a base class deriz...Kalıtım alan sınıflara da türeyen sınıflar(derived class) denir...Parent child ilişkisi gibi yaklasabilirsiniz...
                        *
                        *
                        *Mesela bir Ucak sınıfı düsünün...Aynı zamanda YolcuUcagı ve SavasUcagi sınıflarımız da olsun...YolcuUcagi ve SavasUcagi sınıflarımız Ucak özelliklerini almak zorundadır...Bu durumda aslında iki farklı sınıf olsalar da Ucak sınıfından miras alacaklardır...Kalıtım veren sınıf Ucak sınıfı oldugundan dolayı base class'imiz Ucak olur...YolcuUcagi ve SavaUcagi ise base class'tan türeyen mirascı (derived,child) class'lardır...
                        *
                        *C#'ta Multi-Inheritance destegi yoktur... Yani bir sınıf sadece bir sınıftan miras alabilir...Tabii ki bu kesinlikle bir sınıfın istedigi kadar sınıfa miras veremeyecegi anlamına asla gelmez... Ancak zincirleme miras yapabilirsiniz...
         
         

        Protected erişim belirteci ile tanımlanmıs bir yapı sadece ve sadece o ilgili sınıfın miras verdigi alanlardan direkt olarak veya kendi icerisinde kullanılabilir...
         
         
         Protected && Internal 
        Protected internal erişim belirteci : Bir yapının hem protected özelliklerine sahip oldugunu hem de internal özelliklerine sahip oldugunu ve bu ikisini de kullanabilecegini belirtir...(bir yapı normalde protected ise nasıl davranıyorsa bu erişim belirtecine sahip olan bu şekilde de davranabilir, normalde internal özelligine sahip olan bir yapı bu erişim belirtecine sahipse bu şekilde de davranabilir)..
         
         
         
         
         
         
         
         
         
         
         
         */







        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Egitmen egt = new Egitmen();
            
            

           
            
        }
    }
}
