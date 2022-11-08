using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoMovimentoJustificativa
    {
        public long CoMovimentoJustificativa { get; set; }
        public long CoMovimento { get; set; }
        public long NuOs { get; set; }
        public string DsJustificativa { get; set; }
    }
}
