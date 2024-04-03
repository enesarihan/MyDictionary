using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> not = new MyDictionary<string, int>();
            not.Add("Enes", 99);
            not.Add("Semih", 29);
            not.Add("Hakan", 93);
            not.Add("Cemil", 84);

            string[] anahtarlar = not.Anahtarlar;
            int[] degerler = not.Degerler;

            for (int i = 0; i < anahtarlar.Length; i++)
            {
                Console.WriteLine("İsim : "+anahtarlar[i]+"\n Not : "+degerler[i]);
            }

            
            Console.ReadKey();
        }

        public class MyDictionary<Anahtar,Deger>
        {
            Anahtar[] _anahtar;
            Deger[] _deger;

            public MyDictionary()
            {
                _anahtar = new Anahtar[0];
                _deger = new Deger[0];
            }

            public void Add(Anahtar anahtar,Deger deger)
            {
                Anahtar[] tempAnahtar = _anahtar;
                Deger[] tempDeger = _deger;

                _anahtar = new Anahtar[_anahtar.Length+1];
                _deger = new Deger[_deger.Length+1];

                for (int i = 0; i < tempAnahtar.Length; i++)
                {
                    _anahtar[i] = tempAnahtar[i];
                }
                for (int i = 0; i < tempDeger.Length; i++)
                {
                    _deger[i] = tempDeger[i];
                }

                _anahtar[_anahtar.Length-1]=anahtar;
                _deger[_deger.Length-1]=deger;

            }


            public Anahtar[]Anahtarlar
            {
                get { return _anahtar; }
            }
            public Deger[] Degerler
            {
                get { return _deger; }
            }


        }

    }
}
