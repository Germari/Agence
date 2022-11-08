using Agence_Practical_Test.Infrastructure;
using Agence_Practical_Test.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Agence_Practical_Test.Services
{
    public interface IMySqlService
    {
        Task<List<CaoUsuario>> GetConsultores();
        Task<CaoUsuario> GetConsultor(string coUsuario);
        Task<ConDesemConsultorRel> GetConDesemConsultorRel(string noUsuario, DateTime initialD, DateTime finalD);
        Task<List<CaoCliente>> GetClientes();
    }
}