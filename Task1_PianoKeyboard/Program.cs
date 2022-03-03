using System;
using System.Collections.Generic;
using Task1_PianoKeyboard;
using Task1_PianoKeyboard.Enum;

namespace PianoKeyboard
{   
    class Program
    {
        static void Main(string[] args)
        {   //Creating keys
            Key c = new Key(Accidental.Sharp, Octave.First, Note.C);
            Key d = new Key(Accidental.Flat,Octave.First, Note.D);

            //Writing to console keys
            Console.WriteLine(c.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine();
            Console.WriteLine(c.Equals(d) + ", is the same key!"); //Checking if equals method works
            Console.WriteLine(c.CompareTo(d));  //Checking if compareto method works

            Console.ReadLine();
        }
    }
}