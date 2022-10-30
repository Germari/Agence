using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoFormacaoUsuario
    {
        public string CoUsuario { get; set; }
        public string TpCurso { get; set; }
        public string DsCurso { get; set; }
        public string DsInstituicao { get; set; }
        public DateTime? DtConclusao { get; set; }
    }
}
