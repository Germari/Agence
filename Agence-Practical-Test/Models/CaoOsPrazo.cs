using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoOsPrazo
    {
        public int CoPrazo { get; set; }
        public int? CoOs { get; set; }
        public int? CoFase { get; set; }
        public int? TotalAnalista { get; set; }
        public int? TotalHora { get; set; }
    }
}
