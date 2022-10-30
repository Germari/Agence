using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoBonusStatus
    {
        public int Id { get; set; }
        public string CoUsuario { get; set; }
        public DateTime DataSolic { get; set; }
        public string Mes { get; set; }
        public string Valor { get; set; }
        public string IsSolic { get; set; }
        public string IsPg { get; set; }
        public string IsHoras { get; set; }
    }
}
