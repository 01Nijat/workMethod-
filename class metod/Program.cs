using System;
using System.Text.RegularExpressions;

namespace class_metod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Hesablama hesablama = new Hesablama();
            //int cavab = hesablama.topla(5, 4);                
            //int vur = hesablama.vurma(3, 4);
            //int cixma = hesablama.cixma(6, 2);
            //int bolme = hesablama.bolme(10, 2);
            //Console.WriteLine($"Toplamin cavabi {cavab} || vurmanin cavabi {vur} || cixmanin cavabi {cixma} || bolmenin cavabi {bolme}");
            #endregion
            #region
            //Console.WriteLine("Xais edirik iki reqem yazin");
            //int say1 = int.Parse(Console.ReadLine());
            //int say2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("xais edirik hansi hesablama usulunu edessiz secin");
            //Console.WriteLine("1 tusu vurma edir");
            //Console.WriteLine("2 tusu bolme edir");
            //Console.WriteLine("3 tusu toplama edir");
            //Console.WriteLine("4 tusu cixma edir");
            //Console.WriteLine("5 tusu kvadratlarinin cemidir");
            //int islem = int.Parse(Console.ReadLine());
            //switch (islem)
            //{
            //    case 1:
            //        Console.WriteLine(vurma(say1,say2));
            //        break;
            //    case 2:
            //        Console.WriteLine(bolme(say1, say2));
            //        break;
            //    case 3:
            //        Console.WriteLine(topla(say1,say2));
            //        break;
            //    case 4:
            //        Console.WriteLine(cixma(say1,say2));
            //        break;

            //} 
            //while (true)
            //{
            //    if (islem==1)
            //    {
            //        Console.WriteLine(vurma(say1,say2));
            //    }
            //    else if(islem==2)
            //        Console.WriteLine(bolme(say1,say2));
            //    else if(islem==3)
            //        Console.WriteLine(topla(say1,say2));
            //    else if(islem==4)
            //        Console.WriteLine(cixma(say1,say2));
            //    else if(islem==5)
            //        Console.WriteLine(kvadrat(say1,say2));
            //    else
            //        Console.WriteLine("duzgun secim edin");
            //    break;
            //}
            #endregion
            #region
            //Console.WriteLine("xais edirik 2 reqem qed edin");
            //Hesablama hesablama = new Hesablama();
            //int say1 = int.Parse(Console.ReadLine());
            //int say2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(" toplama ucun 1-e ||| cixma ucun 2-e |||  vurma ucun 3-e ||  bolme ucun 4 e  basin");
            //int islem = int.Parse(Console.ReadLine());
            //switch (islem)
            //{
            //    case 1:
            //        Console.WriteLine(hesablama.topla(say1,say2));
            //        break;
            //    case 2:
            //        Console.WriteLine(hesablama.cixma(say1,say2));
            //        break;
            //    case 3:
            //        Console.WriteLine(hesablama.vurma(say1,say2));
            //        break;
            //    case 4:
            //        Console.WriteLine(hesablama.bolme(say1,say2));
            //        break;
            #endregion
            #region
            //klavyeden girilen cumlenin necedene metinsel ifade oldugunu gosteren uygulama
            //Console.WriteLine("xais edirik cumle yazin");
            //string cumle = Console.ReadLine();
            //int say = 1;
            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    if (cumle[0]==' ')
            //    {
            //        Console.WriteLine("baslangic ve sonuna bosluq qoymaq olmaz");
            //    }
            //    if (cumle[i]==' ')
            //    {   
            //        say++;
            //    }
            //}
            //Console.WriteLine($"girilen cumlenin kelime sayi - {say}");
            #endregion
            #region
            //Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir.
            //Taksi 1 saatten sonraki her saat başı için %20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda %21.5 ve
            //ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve
            //kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.
            //Console.WriteLine("Xais olunur hansi avtomobil isdifade edirsiz qeyd edin");
            //Console.WriteLine("1-tusu minik avtomobil");
            //Console.WriteLine("2 tusu avtobus");
            //Console.WriteLine("3 tusu yuk masini");
            //string avto = Console.ReadLine();
            //int pul_minik = 5;
            //int pul_bus = 6;
            //int pul_yuk=7;
            //DateTime giris = DateTime.Now;
            //DateTime saat = DateTime.Now.AddMinutes(60);


            //switch (avto)
            //{
            //    case "1":

            //        if (giris<=saat)
            //        {
            //            Console.WriteLine("odenilecek mebleg 5 tl");
            //        }
            //        else if(giris>saat)
            //            Console.WriteLine($"odenilecek mebleg {(pul_minik*80)/100} ");
            //        break;
            //    case "2":
            //        if (giris<=saat)
            //        {
            //            Console.WriteLine("odenilecek mebleg 6tl");
            //        }
            //        else if (giris > saat) Console.WriteLine($"odenilecek mebleg- {(pul_bus*77)/100}");
            //        break;
            //    case "3":
            //        if (giris<=saat)
            //        {
            //            Console.WriteLine("odenilecek mebleg-" +(pul_yuk));
            //        }
            //        else if (giris > saat) Console.WriteLine($"odenilecek mebleg- {(pul_yuk*75)/100}");
            //        break;
            //   }
            #endregion
            #region
            // cumlede nece kelimme var
            //string cumle = Console.ReadLine();
            //string cumleler = cumle.Trim();
            //string[] kelmeler = cumleler.Split();
            //if (cumle[0] == ' ')
            //    Console.WriteLine("xais edirik bosluq basdan ve sondan qoymayin duzgun hesablamaya gore");
            //else
            // Console.WriteLine(kelmeler.Length);
            #endregion
            #region
            //Bir komisyoncu sattığı mallardan fiyatı 50 TL kadar olanlardan %3,
            //daha fazla olanlardan ise %2 komisyon almaktadır.
            //Klavyeden girilen teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve
            //en sonunda da toplam komisyonu ekrana yazdıran programın kodlarını yazınız.
            //double mallar = 0, komisiya = 0, toplam_komisia = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("{0} mallarin qiymetine girin ", i + 1);
            //     mallar = Convert.ToDouble(Console.ReadLine());
            //    if (mallar > 50) komisiya = mallar * 0.2;
            //    else komisiya = mallar * 0.3;
            //    Console.WriteLine("{0} mal ucun komisiya miqdari {1}  ",i+1, komisiya);
            //toplam_komisia += komisiya;

            //}
            //Console.WriteLine("toplam komisiya {0} ", toplam_komisia );
            #endregion
            #region
            // Elemanları kullanıcı tarafından girilen 10 elemanlı string bir dizide,
            // en uzun metni, en uzun metnin karakter sayısını ve en uzun
            // metnin index numarasını bulan ve ekrana yazdıran Console Örneği
            /*
            int enuzunmetin = 0;
            string karakter="";
            int indexNo = 0;
            string[] dizi = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} ci metni yazin ",i+1);
                dizi[i] = Console.ReadLine();
            }
            for (int i = 0; i < 10; i++)
            {
                if (dizi[i].Length > enuzunmetin)
                {
                    enuzunmetin = dizi.Length;
                    karakter = dizi[i];
                    indexNo = i;
                }
            }
            Console.WriteLine("================");
            Console.WriteLine("{0} dizi icinde uzunluq ", enuzunmetin);
            Console.WriteLine("{0} dizi icinde karakter ", karakter);
            Console.WriteLine("{0} dizi icinde indexno ", indexNo);
            */

            #endregion
            #region MyRegion
            //Myclass m1 = new Myclass();
            //Console.WriteLine(m1.Yasi);
            //m1.Yasi = 20;
            //Console.WriteLine(m1.Yasi);
            // init propertisi 
            //Myclass m = new Myclass
            //{
            //    Yasi = 3
            //};
            #endregion
            #region MyRegion
            //Console.WriteLine(m.Yasi);
            //Console.WriteLine(metod(int.Parse(Console.ReadLine())));           
            //metod2();
            //Console.WriteLine(metod(8));
            #endregion
            #region polendrom
            //.Int type-na extension yazın - ədədin polendrom ədəd olub-olmadığını yoxlasın

            //while (true)
            //{
            //    int say, r, sum = 0, temp;
            //    Console.WriteLine("xais edirik reqem secin");
            //    say = int.Parse(Console.ReadLine());
            //    temp = say;
            //    while (say > 0)
            //    {
            //        r = say % 10;
            //        sum = (sum * 10) + r;
            //        say = say / 10;

            //    }
            //    if (temp == sum)
            //    {
            //        Console.WriteLine("bu polendrom ededdir");
            //    }
            //    else
            //    {
            //        Console.WriteLine("polendrom deil");
            //    }

            //}
            #endregion
            
            
            

        }
        #region matchcount 
        public static int Matchcount(string a, string b)
        {
            Console.WriteLine("xais edirik metin qeyd edin");
            string text = Console.ReadLine();
            Console.WriteLine("axtardigniz ifadeni qeyd edin");
            string ifade = Console.ReadLine();
            int uzunluq = text.Length;
            int yeniuzunluq = text.Replace(ifade, null).Length;
            int eded = (uzunluq - yeniuzunluq) / ifade.Length;
            Console.WriteLine(eded + " eded vardir");
        return eded;
        }
        #endregion

        #region MyRegion
        //public static int metod(int a)
        //{
        //    int qeder = 0;
        //    int hesab = 0;
        //    for (int i = 0; i <a; i++)
        //    {

        //        if (qeder%2==0)
        //        {
        //            hesab += qeder;
        //        }
        //        qeder++;
        //    }

        //    return hesab;
        //}

        //public static void metod2()
        //{
        //    Console.WriteLine("Ikinci bir deyer ve void bir metod");
        //    int say = int.Parse(Console.ReadLine());
        //    int qeder = 0;
        //    int toplayan = 0;
        //    while (qeder<say)
        //    {
        //        if (qeder%2==0)
        //        {
        //            toplayan += qeder;
        //        }
        //        qeder++;
        //    }
        //    Console.WriteLine(toplayan);
        //}
        #endregion
    }
}




    // class Myclass
    // {
    //int yasi;
    // string b;

    //public int Yasi
    //{
    //    get
    //    {
    //        return yasi;      //properti uzerinden deyer teleb edildikde bu bolum calisar yeni deyer burdan gondereler.
    //    }
    //    set
    //    {
    //        yasi = value;
    //    }
    //}

    // init propertisi
    // public int Yasi { get; init; } = 5;
    // }




    #region

    //static int vurma(int say1, int say2)
    //{
    //    if (say1==0 || say2==0)
    //    {
    //        Console.WriteLine("0-a her hansi deyeri vurduqda sifir alinir");
    //    }
    //    return say1 * say2;
    //}
    //static int bolme(int nom1, int nom2)
    //{
    //    if (nom1==0)
    //    {
    //        Console.WriteLine("0 i her hansi deyere boldukde 0 alinir");
    //    }
    //    return nom1 / nom2;
    //}
    //static int topla(int nom1, int nom2)
    //{
    //    return nom1 + nom2;
    //}
    //static int cixma(int nom1, int nom2)
    //{

    //    return nom1 - nom2;
    //}
    //static double kvadrat(int nom1,int nom2)
    //{ double ad = Math.Pow(nom1, 2);
    //   double ad2 = Math.Pow(nom2, 2);
    //    return ad + ad2;
    //}
    #endregion


#region
//class Hesablama
//{
//    public int topla(int a, int b)
//    {
//        return a + b;
//    }
//    public int cixma(int a, int b)
//    {
//        return a - b;
//    }
//    public int vurma(int a, int b)
//    {
//        return a * b;
//    }
//    public int bolme(int a, int b)
//    {
//        return a / b;
//    }
//}
#endregion

