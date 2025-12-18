using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioArquiteturalCIT.Domain.Requests
{
    public class LancamentoRequest
    {
        public LancamentoRequest()
        {
            
        }

        public LancamentoRequest(string tipoLancamento, decimal valor, DateTime? dataLancamento)
        {
            TipoLancamento = tipoLancamento;
            Valor = valor;
            DataLancamento = dataLancamento ?? DateTime.Now;
        }

        public Guid Id { get; set; }
        public string TipoLancamento { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
