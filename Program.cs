using System;

namespace CSharp_Advanced_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            Clases.HolaMundo hola = new Clases.HolaMundo("Hola Mundo");
            // Console.WriteLine(hola.GetMessage());

            // Console.WriteLine("Hello World!");

            Clases.Generic generic = new Clases.Generic();
            // generic.MyList();
            generic.MyListDos();

        }
    }
}
