using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_kt5
{
    public class Opiskelija
    {
        public int ikä { get; set; }
        public string nimi { get; set; }
        public string otunnus { get; set; }
        public int opvuosi { get; set; }
        public int stressi { get; set; }
        public string sukup { get; set; }

        public override string ToString()
        {
            return ("Opiskelijan nimi: " + nimi + "\nSukupuoli: " + sukup + "\nIkä: " + ikä + "\nOpintovuosi: " + opvuosi + "\nOpintotunnus: " + otunnus + "\nStressitaso: " + stressi + "\n ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //nimilista
            List<Opiskelija> nimet = new List<Opiskelija>();

            //ensimmäinen opiskelija-olio
            Opiskelija Jari = new Opiskelija();
            Jari.nimi = "Jari";
            Jari.sukup = "mies";
            Jari.ikä = 27;
            Jari.opvuosi = 4;
            Jari.otunnus = "J4R1337";
            Jari.stressi = Jari.ikä / Jari.opvuosi;
            nimet.Add(Jari);

            //toinen opiskelija-olio
            Opiskelija Jyri = new Opiskelija();
            Jyri.nimi = "Jyri";
            Jyri.sukup = "mies";
            Jyri.ikä = 19;
            Jyri.opvuosi = 1;
            Jyri.otunnus = "K1337";
            Jyri.stressi = Jyri.ikä / Jyri.opvuosi;
            nimet.Add(Jyri);

            //kolmas opiskelija-olio
            Opiskelija Veera = new Opiskelija();
            Veera.nimi = "Veera";
            Veera.sukup = "mies";
            Veera.ikä = 20;
            Veera.opvuosi = 2;
            Veera.otunnus = "V9001";
            Veera.stressi = Veera.ikä / Veera.opvuosi;
            nimet.Add(Veera);

            //neljäs opiskelija-olio
            Opiskelija Henni = new Opiskelija();
            Henni.nimi = "Henni";
            Henni.sukup = "nainen";
            Henni.ikä = 21;
            Henni.opvuosi = 3;
            Henni.otunnus = "H0MPP3L1";
            Henni.stressi = Henni.ikä / Henni.opvuosi;
            nimet.Add(Henni);

            //viides opiskelija-olio
            Opiskelija Janina = new Opiskelija();
            Janina.nimi = "Janina";
            Janina.sukup = "nainen";
            Janina.ikä = 25;
            Janina.opvuosi = 3;
            Janina.otunnus = "BLÄÄ6LH331LGHLL";
            Janina.stressi = Janina.ikä / Janina.opvuosi;
            nimet.Add(Janina);

            //tulostus
            int j = 0;
            List<string> list = new List<string>();
            for (int i = 0; i < 5; i++, j++)
            {
                list.Add(nimet[j].ToString());
                Console.WriteLine(list[i]);
            }
        }
    }
}
