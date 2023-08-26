using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
	public class Contatos
	{
		private readonly List<Contato> agenda;
		
		public Contatos()
		{
			this.agenda = new List<Contato>();
		}

		public List<Contato> Agenda { get => agenda; }
		
		public bool adicionar(Contato c)
		{
			if (this.pesquisar(c) == null)
			{
				this.agenda.Add(c);
				return true;
			}
			return false;
		}

		public Contato pesquisar(Contato c)
		{
			foreach (Contato contato in this.agenda)
			{
				if (contato.Equals(c))
				{
					return contato;
				}
			}
			return null;
		}

		public bool alterar(Contato c, Contato novoContato)
		{
			Contato contato = this.pesquisar(c);
			if (contato != null)
			{
				contato.Email = novoContato.Email;
				contato.Nome = novoContato.Nome;
				contato.DtNasc = novoContato.DtNasc;
				contato.Telefones = novoContato.Telefones;
				return true;
			}
			return false;
		}

		public bool remover(Contato c)
		{
			Contato contato = this.pesquisar(c);
			if (contato != null)
			{
				this.agenda.Remove(contato);
				return true;
			}
			return false;
		}

		public override string ToString()
		{
			string s = "----\n";
			foreach (Contato c in this.agenda)
			{
				s += c.ToString() + "\n";
			}
			s += "----";
			return s;
		}
	}
}
