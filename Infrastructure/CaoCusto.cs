using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoCusto
    {
        public long CoCusto { get; set; }
        public byte CoTipoCusto { get; set; }
        public string Descricao { get; set; }
        public byte CoEscritorio { get; set; }
        public DateTime? DtCompra { get; set; }
        public DateTime? DtPagamento { get; set; }
        public string CoBoleto { get; set; }
        public float Valor { get; set; }
        public string Parcela { get; set; }
        public bool? Pag { get; set; }
        public long CoCustoHigh { get; set; }
    }
}
