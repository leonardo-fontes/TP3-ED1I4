using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
	public class Contato
	{
		private string email;
		private string nome;
		private Data dtNasc;
		private List<Telefone> telefones;

		public Contato(string email, string nome, Data dtNasc)
		{
			this.email = email;
			this.nome = nome;
			this.dtNasc = dtNasc;
			this.telefones = new List<Telefone>();
		}

		public Contato(string email)
		{
			this.email = email;
			this.nome = "";
			this.dtNasc = new Data(0, 0, 0);
			this.telefones = new List<Telefone>();
		}

		public string Email { get => this.email; set => this.email = value; }
		public string Nome { get => this.nome; set => this.nome = value; }
		public Data DtNasc { get => this.dtNasc; set => this.dtNasc = value; }
		public List<Telefone> Telefones { get => this.telefones; set => this.telefones = value; }

		public int getIdade()
		{
			return DateTime.Now.Year - this.dtNasc.Ano;
		}

		public void adicionarTelefone(Telefone t)
		{
			this.telefones.Add(t);
		}

		public string getTelefonePrincipal()
		{
			foreach (Telefone t in this.telefones)
			{
				if (t.Principal)
				{
					return t.Numero;
				}
			}
			return "";
		}

		public override string ToString()
		{
			string s = "Nome: " + this.nome + "\n";
			s += "Email: " + this.email + "\n";
			s += "Data de Nascimento: " + this.dtNasc.ToString() + "\n";
			s += "Idade: " + this.getIdade() + "\n";

			if (this.getTelefonePrincipal() != "") { 
			s += "Telefone Principal: " + this.getTelefonePrincipal() + "\n";
			}
			if (this.telefones.Count > 0)
			{
				s += "Telefones: \n";
				foreach (Telefone t in this.telefones)
				{
					s += t.ToString() + "\n";
				}
			}
			return s;
		}

		public override bool Equals(object obj)
		{
			Contato c = (Contato)obj;
			return this.email.Equals(c.email);
		}
		
	}
}
