using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Contatos contatos = new Contatos();
			int opcao = 0;

			do
			{
				Console.WriteLine("--------------------------------------");
				Console.WriteLine("| 0. Sair                            |");
				Console.WriteLine("| 1. Adicionar contato               |");
				Console.WriteLine("| 2. Adicionar telefone no contato   |");
				Console.WriteLine("| 3. Pesquisar contato               |");
				Console.WriteLine("| 4. Alterar contato                 |");
				Console.WriteLine("| 5. Remover contato                 |");
				Console.WriteLine("| 6. Listar contatos                 |");
				Console.WriteLine("--------------------------------------");
				
				Console.Write("Digite a opção desejada: ");
				opcao = int.Parse(Console.ReadLine());

				switch (opcao)
				{
					case 0:
						Console.WriteLine("Saindo...");
						break;
					case 1:
						Console.WriteLine("Adicionar contato");
						Console.Write("Digite o nome: ");
						string nome = Console.ReadLine();
						Console.Write("Digite o email: ");
						string email = Console.ReadLine();
						Console.Write("Digite o dia de nascimento: ");
						int dia = int.Parse(Console.ReadLine());
						Console.Write("Digite o mês de nascimento: ");
						int mes = int.Parse(Console.ReadLine());
						Console.Write("Digite o ano de nascimento: ");
						int ano = int.Parse(Console.ReadLine());
						Contato contato = new Contato(email, nome, new Data(dia, mes, ano));
						if (contatos.adicionar(contato))
						{
							Console.WriteLine("Contato adicionado com sucesso!");
						}
						else
						{
							Console.WriteLine("Contato já existe!");
						}
						break;
					case 2:
						Console.WriteLine("Adicionar telefone no contato");
						Console.Write("Digite o email do contato: ");
						email = Console.ReadLine();
						contato = new Contato(email);
						Contato contatoPesquisado = contatos.pesquisar(contato);
						if (contatoPesquisado != null)
						{
							Console.Write("Digite o tipo do telefone: ");
							string tipo = Console.ReadLine();
							Console.Write("Digite o número do telefone: ");
							string telefone = Console.ReadLine();
							Console.Write("É o telefone principal? (S/N): ");
							bool principal = Console.ReadLine().ToUpper() == "S";
							Telefone t = new Telefone(tipo, telefone, principal);

							contatoPesquisado.adicionarTelefone(t);
							Console.WriteLine("Telefone adicionado com sucesso!");
						}
						else
						{
							Console.WriteLine("Contato não existe!");
						}
						break;
					case 3:
					Console.WriteLine("Pesquisar contato");
						Console.Write("Digite o email do contato: ");
						email = Console.ReadLine();
						contato = new Contato(email);
						contatoPesquisado = contatos.pesquisar(contato);
						if (contatoPesquisado != null)
						{
							Console.WriteLine(contatoPesquisado.ToString());
						}
						else
						{
							Console.WriteLine("Contato não existe!");
						}
						break;
					case 4:
						Console.WriteLine("Alterar contato");
						Console.Write("Digite o email do contato: ");
						email = Console.ReadLine();
						contato = new Contato(email);
						contatoPesquisado = contatos.pesquisar(contato);
						if (contatoPesquisado != null)
						{
							Console.Write("Digite o novo nome: ");
							nome = Console.ReadLine();
							Console.Write("Digite o novo email: ");
							string novoEmail = Console.ReadLine();
							Console.Write("Digite o novo dia de nascimento: ");
							dia = int.Parse(Console.ReadLine());
							Console.Write("Digite o novo mês de nascimento: ");
							mes = int.Parse(Console.ReadLine());
							Console.Write("Digite o novo ano de nascimento: ");
							ano = int.Parse(Console.ReadLine());

							contatoPesquisado.Nome = nome;
							contatoPesquisado.Email = novoEmail;
							contatoPesquisado.DtNasc = new Data(dia, mes, ano);
							Console.WriteLine("Contato alterado com sucesso!");
						}
						else
						{
							Console.WriteLine("Contato não existe!");
						}
						break;
					case 5:
						Console.WriteLine("Remover contato");
						Console.Write("Digite o email do contato: ");
						email = Console.ReadLine();
						contato = new Contato(email);
						if (contatos.remover(contato))
						{
							Console.WriteLine("Contato removido com sucesso!");
						}
						else
						{
							Console.WriteLine("Contato não existe!");
						}
						break;
					case 6:
						Console.WriteLine("Listar contatos");
						Console.WriteLine(contatos.ToString());
						break;
					default:
						Console.WriteLine("Opção inválida!");
						break;
				}

			} while (opcao != 0);
		}
	}
}
