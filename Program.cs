using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUla09
{
	class Program
	{

		static List<string> produtos = new List<string>();
		static void Main(string[] args)
		{


			string texto = "";
			Console.WriteLine("Bem-Vindo ao Conradito Store");
			Console.WriteLine("Digite\n1- Cadastrar\n2- Listar Estoque");
			string resposta = Console.ReadLine();

			if (resposta == "1")
			{
				Console.WriteLine("Digite o nome do produto");
				string produto = Console.ReadLine();

				if (produtos.Contains(produto)){
					Console.WriteLine("Esse produto já está na lista.");
					Console.ReadLine();
					Console.Clear();
					Main(null);

					return;

				}else{
					produtos.Add(produto.ToLower());
					
					Console.WriteLine($"Você registrou {produto}");
					Console.ReadLine();

					Main(null);

					return;
				}

			}else{
				
				
				int contador = 0;

				while (contador < produtos.Count){

					string nome = produtos[contador];
					string primeira_letra = nome.Substring(0, 1).ToUpper();
					string resto = nome.Substring(1, nome.Length -1);
					string nome_tratado = primeira_letra + resto;

					texto += produtos[contador] + ", ";
					contador++;

				}
				texto = texto.Substring(1, texto.Length - 2);
				

				Console.WriteLine(texto);
				Console.ReadLine();
				Main(null);

				return;

			}


			
		}
	}
}
