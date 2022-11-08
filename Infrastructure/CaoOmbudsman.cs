using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoOmbudsman
    {
        public int Id { get; set; }
        public byte Idtipo { get; set; }
        public byte Idcategoria { get; set; }
        public string Comentario { get; set; }
        public byte CoEscritorio { get; set; }
        public DateTime Data { get; set; }

        public virtual CaoCategoriasOmbudsman IdcategoriaNavigation { get; set; }
        public virtual CaoTipoOmbudsman IdtipoNavigation { get; set; }
    }
}
