using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoPermissao
    {
        public string CoUsuario { get; set; }
        public string PermissaoIntervalo { get; set; }
        public string PermissaoHoraExtra { get; set; }

        public virtual CaoUsuario CoUsuarioNavigation { get; set; }
    }
}
