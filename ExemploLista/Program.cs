using System;
using System.Collections.Generic;

namespace ExemploLista {
    class Program {
        static void Main (string[] args) {
            /*
            List<string> cidades = new List<string> (); // Cria uma nova lista do tipo STRING com o nome CIDADES
            cidades.Add ("São Paulo"); // lista.add inclui um item na lista
            cidades.Add ("Curitiba");
            cidades.Add ("Osasco");
            cidades.Add ("Manaus");

            System.Console.WriteLine (cidades[1].ToUpper ()); // escreve o dado na posição 1 (tb inicia no 0 igual array)
            */

            /*
            List<Usuarios> us = new List<Usuarios> (); // Cria uma nova lista do tipo USUARIOS
            Usuarios Lucas = new Usuarios () { ID = 35, Login = "lucasred", Senha = "1234" }; // usando a classse USUARIOS cadastra um novo objeto com os atributos especificados no arquivo USUARIOS.cs
            Usuarios Tuanny = new Usuarios () { ID = 10, Login = "tuannyzon", Senha = "pamonha" };
            us.Add (Lucas);
            us.Add (Tuanny);

            System.Console.WriteLine (us[0].Login);
            System.Console.WriteLine (us[1].Senha);
            */

            List<Produto> sacola = new List<Produto> ();
            HigienePessoa sabonete = new HigienePessoa ();
            sabonete.ID = 10;
            sabonete.Nome = "Dove";

            Bebidas cerveja = new Bebidas ();
            cerveja.ID = 30;
            cerveja.Nome = "skol";

            sacola.Add (sabonete);
            sacola.Add (cerveja);

            foreach (var item in sacola) {
                string tipoclasse = item.GetType ().ToString ();
                switch (tipoclasse) {
                    case "ExemploLista.HigienePessoa":
                        {
                            HigienePessoa higiene = (HigienePessoa) item;
                            System.Console.WriteLine ("Higiene Pessoal: " + higiene.Nome + " - " + higiene.ID + " - " + higiene.Marca);
                           
                            break;
                        }
                    case "ExemploLista.Bebidas":
                        {
                            Bebidas bebida = (Bebidas) item;
                            System.Console.WriteLine ("Bebidas: " + bebida.Nome + " - " + bebida.Preco + " - " + bebida.Tipo);
                            
                            break;
                        }
                }
            }
        }
    }
}