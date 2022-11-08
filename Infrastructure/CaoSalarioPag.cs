using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoSalarioPag
    {
        public int IdPagamento { get; set; }
        public string CoUsuario { get; set; }
        public DateTime DtEfetuado { get; set; }
        public string Status { get; set; }
        public string Observacao { get; set; }

        public virtual CaoUsuario CoUsuarioNavigation { get; set; }
    }
}
