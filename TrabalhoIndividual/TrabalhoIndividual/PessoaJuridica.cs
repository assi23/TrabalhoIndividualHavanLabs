﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoIndividual
{
	class PessoaJuridica : Pessoa
	{
		public string IE { get; set; }
		public string CNPJ { get; set; }

		public Endereco endereco { get; set; }
	}
}
