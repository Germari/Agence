using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoHelpChamado
    {
        public int CoChamado { get; set; }
        public string DsChamado { get; set; }
        public string DsSolucao { get; set; }
        public byte CoStatus { get; set; }
        public int CoMotivo { get; set; }
        public int CoTela { get; set; }
        public int CoAutor { get; set; }
        public int CoFilial { get; set; }
        public long CoSistema { get; set; }
        public DateTime DtChamado { get; set; }
        public DateTime? DtSolucao { get; set; }
    }
}
