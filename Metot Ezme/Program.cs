using System;

namespace Metot_Ezme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Metod ezmede kalıtımda base class da olan fonksiyonla yanı isimde yeni fonksiyon kullanılır
             * bu fonksiyon kullanılırken virtual ve overrider kullanılır
             * virtual asıl yani base deki overrider kalıtım daki fonksiyonu belirtir
             */
            kedi siyam=new kedi();
            siyam.ses();
            kopek kurt=new kopek();
            kurt.ses();

        }
    }
    class hayvan
    {
        public virtual void ses()
        {
            Console.WriteLine("---------");
        }
    }
    class kedi:hayvan
    {
        public override void ses()
        {
            Console.WriteLine("Miyav");
        }
    }
    class kopek:hayvan
    {
        public override void ses()
        {
            Console.WriteLine("Hav Hav");
        }
    }
}
