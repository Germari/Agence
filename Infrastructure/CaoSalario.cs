using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoSalario
    {
        public string CoUsuario { get; set; }
        public DateTime DtAlteracao { get; set; }
        public float BrutSalario { get; set; }
        public float LiqSalario { get; set; }

        public static CaoSalario FromReader(MySqlDataReader reader)
        {
            return new CaoSalario()
            {
                BrutSalario=float.Parse(reader["brut_salario"].ToString())
            };
        }
    }
}
