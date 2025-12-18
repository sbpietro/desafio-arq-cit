namespace DesafioArquiteturalCIT.Domain
{
    public class LancamentoDiario
    {
        public Guid Id { get; set; }
        public string TipoLancamento { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; }

    }
}
