using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoBonus
    {
        public int BonCategoria { get; set; }
        public int BonInicio { get; set; }
        public int BonFim { get; set; }
        public float? BonValorSem { get; set; }
        public float? BonValorFimsem { get; set; }
    }
}
