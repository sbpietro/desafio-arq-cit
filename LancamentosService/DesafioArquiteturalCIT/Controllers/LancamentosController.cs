using DesafioArquiteturalCIT.Domain.Requests;
using DesafioArquiteturalCIT.Infra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DesafioArquiteturalCIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancamentosController : ControllerBase
    {
        private readonly FinanceiroDbContext _dbContext;

        public LancamentosController(FinanceiroDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("lancamento")]
        public IActionResult CriarLancamento([FromBody] LancamentoRequest request)
        {
            // Lógica para criar um lançamento financeiro
            return Ok(new { Mensagem = "Lançamento criado com sucesso!" });
        }

        [HttpGet("lancamentos")]
        public IActionResult ObterLancamentos(string dataLancamento)
        {
            // Lógica para obter lançamentos financeiros
            //var lancamentos = new[]
            //{
            //    new { Id = Guid.NewGuid(), TipoLancamento = "Receita", Valor = 1000.00m, DataLancamento = DateTime.Now },
            //    new { Id = Guid.NewGuid(), TipoLancamento = "Despesa", Valor = 500.00m, DataLancamento = DateTime.Now }
            //};
            var lancamentos = _dbContext.LancamentosDiarios
                .Where(l => l.DataLancamento.Date == Convert.ToDateTime(dataLancamento))
                .Select(l => new 
                { 
                    l.Id, 
                    l.TipoLancamento, 
                    l.Valor, 
                    l.DataLancamento 
                })
                .ToList();

            return Ok(lancamentos);
        }
    }
}
