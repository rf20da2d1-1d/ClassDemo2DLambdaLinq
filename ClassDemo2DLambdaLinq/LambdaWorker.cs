using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using ClassDemo2DLambdaLinq.model;

namespace ClassDemo2DLambdaLinq
{
    public class LambdaWorker
    {

        // definerer type af metode referencen
        delegate int AddType(int x, int y);
     
        // erklærer en variable Sum der kan pege på en metode
        private AddType Sum = null;


        // prædefineret delegate metoder Action = returværdien er void hhv Func = har en returværdi
        private Action<string> stringMetode;
        private Func<int, int, int> talMetode;


        public LambdaWorker()
        {
        }

        public void StartLambda()
        {

            // tildeles en metode - som lambda udtryk
            Sum = (x, y) => x + y; 

            int res = Sum(5, 8);

            Console.WriteLine(res);

            Sum = EnAndenMetode;

            res = Sum(5, 8);

            Console.WriteLine(res);


            stringMetode = (s) =>
            {
                Console.WriteLine("Dette er en tekst " + s);
            };
            talMetode = (x, y) => x + y;

            stringMetode("Peter");

            int res2 = talMetode(4, 9);
            Console.WriteLine("Talmetode = " + res2);


        }

        private int EnAndenMetode(int i, int j)
        {
            return (i + j) * 2;
        }




        public void StartLinq()
        {
            List<Bil> biler = new List<Bil>(MockDataFactory.GetBiler);

            var res =
                from b in biler
                where b.Farve == "rød"
                select b;

            //foreach (var bil in res)
            //{
            //    Console.WriteLine(bil);
            //}

            var res2 = biler.Where(b => b.Farve == "rød").Select(b => new {b.RegistreringsNr, b.Pris});

            //foreach (var bil in res2)
            //{
            //    Console.WriteLine(bil);
            //}

            var res3 =
                from b in biler
                group b by b.Farve
                into bg
                select bg;


            foreach (var gruppe in res3)
            {
                Console.WriteLine("Farve - {0} ", gruppe.Key);
                Console.WriteLine("{0} -- {1} -- {2}", "ID", "Pris", "Reg.Nr");

                foreach (Bil b in gruppe)
                {
                    Console.WriteLine($"{b.Id} -- {b.Pris} -- {b.RegistreringsNr}");
                }

            }


             

        }

    }
}