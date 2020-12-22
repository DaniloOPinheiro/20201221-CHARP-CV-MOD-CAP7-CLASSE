using System;

namespace MOD1_CAP7_CLASSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Seguindo apostila de Carlos Vamberto, módulo 1 - Introdução ao .NET com C# ");
            // Cria o Objeto "ca" que é a instância da Classe "Clasee_A"
            Classe_A ca = new Classe_A("ABC");
            System.Console.WriteLine("Dado informado : {0}", ca.getClasse_A());

            // Instância o primeiro Objeto, e cria uma nova;
            ca.setClasse_A("DEF");
            System.Console.WriteLine("Dado inserido : {0}", ca.getClasse_A());
        }
    }
}
