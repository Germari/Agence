using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoHelpTelaChamado
    {
        public int CoTela { get; set; }
        public int CoCliente { get; set; }
        public int CoSistema { get; set; }
        public string DsTela { get; set; }
    }
}
