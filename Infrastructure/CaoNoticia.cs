using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoNoticia
    {
        public int CoNoticia { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public string Foto { get; set; }
        public string CoUsuario { get; set; }
        public DateTime DtNoticia { get; set; }
    }
}
