using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoOsDailyReport
    {
        public int CoDaily { get; set; }
        public int? CoOs { get; set; }
        public int? CoFase { get; set; }
        public string CoUsuario { get; set; }
        public string DsAssunto { get; set; }
        public TimeSpan? TempoGasto { get; set; }
        public int? CoStatusAtual { get; set; }
        public int? CoChamado { get; set; }
        public int? CoAtividade { get; set; }
        public DateTime Data { get; set; }

    }
}
