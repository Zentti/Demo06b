using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {

            // Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon (lopetusehdon voit päättää itse) ja sulje tiedosto. 
            // Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin.

            string sana = "pena";

            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"d:\test.txt");
            while (sana!=" ")
            {
                Console.WriteLine("Give a text line (spacebar quits) ");
                sana = Console.ReadLine();
                outputFile.WriteLine(sana);
            }
            outputFile.Close();

            string text = System.IO.File.ReadAllText(@"d:\test.txt");
            System.Console.WriteLine("Contents of test.txt:\n"+ text);

        }
    }
}
