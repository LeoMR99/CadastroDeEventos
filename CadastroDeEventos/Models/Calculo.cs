using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeEventos.Models
{
    public class Calculo
    {
        public Salao TipoSalao { get; set; }
        public int QntPessoas { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public int Tempo
        {

            get => DataTermino.Subtract(DataInicio).Days;

        }

        public double ValorTotal
        {
            get
            {

                double valor_por_pessoa = (QntPessoas * TipoSalao.Valor);
                double valor_por_tempo = (valor_por_pessoa * Tempo);

                return valor_por_tempo;
            }
        }
    }
}
