using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoClienteContato
    {
        public int CoCliente { get; set; }
        public DateTime? DtContato { get; set; }
        public int? FgAgendado { get; set; }
        public TimeSpan? HrIni { get; set; }
        public TimeSpan? HrEnd { get; set; }
    }
}
