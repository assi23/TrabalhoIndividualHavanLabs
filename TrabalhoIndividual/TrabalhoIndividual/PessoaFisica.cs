﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoIndividual
{
	class PessoaFisica : Pessoa
	{
		public string RG { get; set; }
		public string CPF { get; set; }

		public Endereco endereco { get; set; }
	}
}
