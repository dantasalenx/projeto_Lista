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
                Console.WriteLine("Informe um nome para add na lista: ");
                valor = Console.ReadLine().TrimEnd().ToUpper();
                if (valor != "valor") lista.Add(valor);
            } while (valor != "sair".ToUpper());

            int quantidade = lista.Count;

            listacompleta = lista.ToList();


            Console.WriteLine("Informe o nome a ser excluido: ");
            lista.Remove(Console.ReadLine().ToUpper());


            foreach(var e in listacompleta){
                Console.WriteLine(e);
            }

            Console.WriteLine("-------------");
            foreach (var e in lista)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Quantidade inicial: " + quantidade);
            Console.WriteLine("Quantidade final: " + lista.Count);
            }
        }
    }
