using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoDiaryReportConsultor
    {
        public int CoDiaryReportConsultor { get; set; }
        public int CoMovimento { get; set; }
        public int CoAtividade { get; set; }
        public string DsEmpresa { get; set; }
        public string DsAssunto { get; set; }
        public long? CoCliente { get; set; }
        public DateTime DtAgendamentoFim { get; set; }
        public DateTime DtAgendamento { get; set; }
        public float VlFechamento { get; set; }
    }
}
