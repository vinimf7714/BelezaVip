using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelezaVip.Models
{

    public class Profissional
    {
        public int idProfissional { get; set; }
        public string nomeProfissional { get; set; }

    }
    public class AtendimentoViewModel
    {
        public AtendimentoViewModel()
        {
            List<Profissional> profissional = new List<Profissional>();
        }

        public List<AtendimentoViewModel> lista = new List<AtendimentoViewModel>();

        List<Profissional> profissional;
        public DateTime DataAtendimento { get; set; }
        public String NomeCliente { get; set; }
        public String NomeProfissional { get; set; }
        public String IdProfissional { get; set; }
        public String NomeProcedimento { get; set; }
        public String ValorProcedimento { get; set; }
        public double ValorDesconto { get; set; }
        public double ComissaoPorcentagem { get; set; }
        public double ComissaoValor { get; set; }
        public char StatusAtendimento { get; set; }


    }
}
