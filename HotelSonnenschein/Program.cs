using System;
using System.IO;

namespace HotelSonnenschein {
    class Program {
        static void Main ( string [] args ) {
            try {
                FileStream fs = File.Open ( "data_hotel.txt", FileMode.Open );
                StreamReader sr = new StreamReader ( fs );

                // Lese die gesamte Datei und zeige diese an ...
                //Console.WriteLine ( sr.ReadToEnd () );
                // lese genau eine Zeile aus der Datei
                // und schreibe das Ergebnis in eine string-Variable
                string zeile =  sr.ReadLine() ;
                
                // Ausgabe des strings zeile
                //Console.WriteLine ( zeile );

                char [] charArray = { ',', ';', ':' };

                string [] arrayMitFeldern = zeile.Split (charArray);

                //foreach ( var item in arrayMitFeldern ) {
                //    Console.Write (item);
                //}

                string s1 = arrayMitFeldern [ 0 ];
                string s2 = arrayMitFeldern [ 1 ];

                Console.WriteLine ("{0}  {1}",s1, s2);

                double zahl = Convert.ToDouble (s2);
                Console.WriteLine (zahl * 2);

                //for ( int i = 0 ; i < 4 ; i++ ) {
                //    zeile = sr.ReadLine ();
                //    arrayMitFeldern = zeile.Split ( charArray );
                //    s1 = arrayMitFeldern [ 0 ];
                //    s2 = arrayMitFeldern [ 1 ];
                //    zahl = Convert.ToDouble ( s2 );
                //    zahl *= 2;
                //    Console.WriteLine ("{0}  {1}", s1, zahl);
                //}


                //string line;

                //while ( ( line = sr.ReadLine () ) != null ) {
                //    System.Console.WriteLine ( line );
                //    //counter++;
                //}

            }
            catch (Exception e) {
                  Console.WriteLine ("Es ist ein Fehler aufgetreten");

            } 
            //finally {
            //    Console.WriteLine ("egal ob Fehler oder nicht: Ich werde immer ausgeführt");
            //}

            Console.ReadLine ();
        }
    }
}
