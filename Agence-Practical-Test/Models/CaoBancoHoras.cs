using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoBancoHoras
    {
        public int CoBancHoras { get; set; }
        public string CoUsuario { get; set; }
        public string Periodo { get; set; }
        public int MinMes { get; set; }
        public int MinFerias { get; set; }
        public int MinPago { get; set; }
        public int MinTotal { get; set; }
    }
}
