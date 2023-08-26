using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
	public class Telefone
	{
		private string tipo;
		private string numero;
		private bool principal;

		public Telefone(string tipo, string numero, bool principal)
		{
			this.tipo = tipo;
			this.numero = numero;
			this.principal = principal;
		}

		public string Tipo { get => this.tipo; set => this.tipo = value; }
		public string Numero { get => this.numero; set => this.numero = value; }
		public bool Principal { get => this.principal; set => this.principal = value; }

		public void setTelefone(string tipo, string numero, bool principal)
		{
			this.tipo = tipo;
			this.numero = numero;
			this.principal = principal;
		}
	

		public override string ToString()
		{
			return this.tipo + " - " + this.numero + (this.principal ? " (Principal)" : "");
		}

	}
}
