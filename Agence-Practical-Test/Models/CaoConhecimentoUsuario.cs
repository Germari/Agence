using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class CaoConhecimentoUsuario
    {
        public string CoUsuario { get; set; }
        public int CoConhecimento { get; set; }
        public int? NvConhecimento { get; set; }
        public byte? IsCertificado { get; set; }
    }
}
