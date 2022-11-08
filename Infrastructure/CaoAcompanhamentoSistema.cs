using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoAcompanhamentoSistema
    {
        public int CoAcompanhamento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public long? CoSistema { get; set; }
        public string Status { get; set; }
    }
}
