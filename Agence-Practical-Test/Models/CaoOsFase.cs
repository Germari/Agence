using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoOsFase
    {
        public int CoFase { get; set; }
        public string Descricao { get; set; }
        public string DescricaoIngl { get; set; }
        public int? Ordem { get; set; }
    }
}
