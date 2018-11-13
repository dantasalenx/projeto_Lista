using System;
using System.Collections.Generic;
using System.Linq;

namespace projeto_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            List<string> listacompleta = new List<string>();

            var valor = "";
            do
            {
                Console.WriteLine("Informe um nome para add na lista: \n");
                valor = Console.ReadLine().TrimEnd().ToUpper();
                if (valor != "sair".ToUpper() && !lista.Contains(valor))lista.Add(valor);
            } while (valor != "sair".ToUpper());

            foreach (string e in lista) { Console.WriteLine(e); }

            int quantidade = lista.Count;
            bool tem = lista.Contains("ALENX");

            listacompleta = lista.ToList();

            Console.WriteLine("\nInforme o nome a ser excluido: ");
            lista.Remove(Console.ReadLine().ToUpper());

            Console.Clear();

            Console.WriteLine("Antes: ");
            foreach(var e in listacompleta)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("----------------------");

            Console.WriteLine("Depois: ");
            foreach (var e in lista)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("\nQuantidade inicial: " + quantidade);
            Console.WriteLine("\nQuantidade final: " + lista.Count);
            Console.WriteLine("\nTEM: " + tem);
            }
        }
    }
