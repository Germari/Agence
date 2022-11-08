using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoMovimento
    {
        public long CoMovimento { get; set; }
        public string CoUsuario { get; set; }
        public byte IsEncerrado { get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtSaidaAlmoco { get; set; }
        public DateTime DtVoltaAlmoco { get; set; }
        public DateTime DtSaida { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFim { get; set; }
    }
}
