using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoMenuContador
    {
        public string CoUsuario { get; set; }
        public byte CoMenu { get; set; }
        public byte NuPontos { get; set; }
        public byte InProcessado { get; set; }
    }
}
