
using System;
using System.Collections.Generic;
using System.Linq;

namespace Naloga3
{
    class Program
    {
        static void Main(string[] args)
        {


            //TODO 30 ustvari seznam tipa List<Zaposleni>
            //koda

            //TODO 31 dodaj 6 zaposlenih ročno!!
            //koda

            //TODO 36 kličite metodo, ki izpiše seznam zaposlenih
            //koda


            //TODO 38 ustvarite spremenljivko povprecnaplaca placa
            //TODO 38 iz seznama iračunajte povprečno plačo in jo shranite v ustvarjeno spremenljvko
            //TODO 38 izračunano vrednost izpišite "Povprečna plača: "
            //koda izračun
            //koda izpis




            //TODO 40
            //izpišite vse osebe z nadpovprečno plačno


            Console.WriteLine("BRANJE JSON");
            //TODO 62 uporabite dopolnjeno metodo Vrnivsebino in jo kličite
            //TODO 62 s parametrov http://dummy.restapiexample.com/api/v1/employees
            //TODO 62 vsebino, ki jo vrne metoda shranite v spremenljivko vsebina tipa string
            string vsebina = "";


            //TODO 63 izpišite vsebino prebrane strani (kasneje lahko izključite),
            //TODO 63 vsebino mora biti enaka vsebini, če jo kličete s brsklalnikom
            Console.WriteLine($"{vsebina}");



            //TODO 65 poglejte kodo in dopišite komentar
            //TODO 65 odkomentirajte in dodajte NuGet paket
            /*  JToken token = JToken.Parse(vsebina);
            JArray zaposleni = (JArray)token.SelectToken("data");
            foreach (JToken zap in zaposleni)
            {
                Console.Write("id: " + zap["id"] + " " + zap["id"]);
                Console.Write(" employee_name: " + zap["employee_name"]);
                Console.Write(" employee_salary: " + zap["employee_salary"]);
                Console.Write(" employee_age: " + zap["employee_age"]);
                Console.WriteLine();


                //TODO 66 prebrano zaposlene dodajte v že obstoječi seznam zaposlenih
                //koda 

             }
           //*/

            //TODO 70 izpišite vse trenutno zaposlene v seznamu
            //koda


            //TODO 81 uporabite metodo izpisi seznam TODO35 in vrni_zaposlene_filter (TODO80)
            //TODO 81 izpisite vse zaposlene, ki zaslužijo med 10000 in 40000
            Console.WriteLine("Zaposleni z zaslužkom med 10k in 40k:");
            //koda

            //TODO 86  uporabite metodo izpisi seznam TODO35 in vrni_zaposlene_filter (TODO85)
            //TODO 86 izpiši zaposlene nad 40 let
            Console.WriteLine("Zaposleni nad 40let:");
            //koda




            //DODATNO NAMESTO FOR UPORABI WHERE
            Console.WriteLine("Zaposleni nad 40let Select:");


            Console.WriteLine("Zaposleni nad 40let SelectLamda:");


        }

        //TODO 60 metodo dopolnite tako:
        //TODO 60 -da bo URL podan kot parameter
        //TODO 60 -da bo metoda vračala vsebino
        static void Vrnivsebino()
        {
            string url = "http://dummy.restapiexample.com/api/v1/employees";

            using (var webClient = new System.Net.WebClient())
            {
                Console.WriteLine(webClient.DownloadString(url));
            }

        }


        //TODO 80 ustvarite statično metodo vrni_zaposlene_filter_placa, ki vrne seznam List<Zaposleni>
        //TODO 80 metoda kot parameter dobi List<Zaposleni>, placaOd in placaDo
        //TODO 80 ustvari nov seznam!!, ki ga vrne, v seznamu so zaposleni s plačo v podanem območju
        //koda


        //TODO 85 ustvarite statično metodo vrni_zaposlene_filter_starost, ki vrne seznam List<Zaposleni>
        //TODO 85 metoda kot parameter dobi List<Zaposleni>, starostOd in starostDo
        //TODO 85 ustvari nov seznam!!, ki ga vrne, v seznamu so zaposleni stari v podanem območju
        //koda



        //TODO 35 ustvarite metodo izpisi_seznam, ki izpiše seznam tipa List<Zaposleni>
        //TODO 35 za izpis posameznega zapis uprabite metodo, ki ste jo ustvarili v razredu Zaposleni
        //koda
    }


}
