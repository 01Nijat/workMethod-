using System;
using System.Collections.Generic;
using System.Text;

namespace calisma2
{
    class silah
    {
        //avtomat simulasiyasi;
        public string Uzi;
        public string islemeyi="avtomatik";
        public string islemey = "tek"; /* avtomaticski, tek-tek*/
        public int darag; /*daraqdaki gulle sayi*/
        public int ehtiyatgulle; /*personal gulle saylari*/
        public int daraglimit; /*daragin limiti*/
        //baslayaq
        public silah(string silahnovu)
        {
            if (silahnovu=="Uzi")
            {
                darag = 22;
                daraglimit = 22;
                ehtiyatgulle = 66;
            }           
        }
        public void Yenileme()
        {
            if (darag<daraglimit)
            {
                if (ehtiyatgulle==0)
                {
                    Console.WriteLine("gulleniz qalmadi qumbara isdifade et, eger yoxdusa bicaga kec.");
                }
                darag++;
                ehtiyatgulle--;
            }else
                Console.WriteLine("Doludur artiq");
        }
        public void Deyismek()
        {
            if (darag==0)
            {
                if (ehtiyatgulle>0)
                {
                    Console.WriteLine("darag yenilenir");
                    darag += 22;
                    ehtiyatgulle -= 22;
                }
                else
                {
                    Console.WriteLine("Daraq bitib qumbara at yoxdusa bicaq isdifade et");
                }
               
            }
            else
            {
                Console.WriteLine("darag bos deil");
            }
        }
        public void ates()
        {
            if (islemeyi=="avtomatik")
            { 
                for (int i = 0; i <= daraglimit; i++)
                {
                                      
                    if (darag>0)
                    {
                        Console.WriteLine(darag);
                        darag--;
                        if (darag==0)
                        {
                            Console.WriteLine("tecili daragi deis");
                        }
                        
                    }
                }
                
            }else
                Console.WriteLine("daragi deis");
        }
        public void tek()
        {
            if (islemey=="tek")
            {
                if (darag>0)
                {
                    darag -= 1;
                    Console.WriteLine(darag);
                }
                else
                {
                    Console.WriteLine("deyis");
                }
            }
        }
    }
}
