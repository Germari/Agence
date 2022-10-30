using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Models
{
    public partial class PermissaoSistema
    {
        public string CoUsuario { get; set; }
        public long CoTipoUsuario { get; set; }
        public long CoSistema { get; set; }
        public string InAtivo { get; set; }
        public string CoUsuarioAtualizacao { get; set; }
        public DateTime DtAtualizacao { get; set; }

        public static PermissaoSistema FromReader(MySqlDataReader reader)
        {
            return new PermissaoSistema()
            {
                CoSistema = long.Parse(reader["co_sistema"].ToString()),
                InAtivo = reader["in_ativo"].ToString(),
                CoTipoUsuario = long.Parse(reader["co_tipp_usuario"].ToString())

            };
        }
    }
}
