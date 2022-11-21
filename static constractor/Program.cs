using System;

namespace static_constractor
{
    class Program
    {
        static void Main(string[] args)
        {
            new Myclass(); // iki defe cagirdiqda static const yalniz bidefe tetiklenir
            new Myclass();
        }
    }
    // bir sinifdan nesne olustururken ilk ttiklenen funkison constractor metodudur. yeni ilk olarak static konstraktordur sonra consraktordur
    // ilk statik sonra normal konstraktor. amma ve lakin belirli bir duruma istinaden.
     class Myclass
    {
        public Myclass()
        {
            Console.WriteLine("sinif icinde construktor tetiklenmisdir");//sinifde construktor tetiklenir ilk.
        }
        static  Myclass()  // static constructorda geri donus deyeri ve erisim belirleyicisi bildirilmez!
        {                  //overloadin edilmez! bir sinifin icinde bir dene tanimlanmalidir yeni parametre almaz!!!
            Console.WriteLine("sinif icinde static construktor tetiklenmisdir");//en birinci static const tetiklenir yalniz bir defe
            //static constructorin tetiklene bilmesi ucun illa ilk nesne uretimi yapilmasina gerek yoktur.
            //ilgili sinif icersinde herhansi bir sttic yapilanmaninda tetiklenmesi static const. tetiklenmesini saglayacaktir.
        }
    }

}
