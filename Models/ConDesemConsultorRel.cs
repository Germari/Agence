using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agence_Practical_Test.Models
{
    public class ConDesemConsultorRel
    {
        public string Name { get; set; }
        public ConDesemConsultorRelSaldo Saldo { get; set; }
        public List<ConDesemConsultorValue> Values { get; set; } = new List<ConDesemConsultorValue>();
    }
    public class ConDesemConsultorRelSaldo
    {
        public float ReceitaLiquida { get; set; }
        public float CustoFixo { get; set; }
        public float Comissao { get; set; }
        public float Lucro { get; set; }
    }
    public class ConDesemConsultorValue
    {
        float _custoFixo;
        float _comissao;
        float _lucro;
        float _receitaLiquida;
        public string Periodo { get; set; }
        public float ReceitaLiquida { get => _receitaLiquida; set => _receitaLiquida = value; }
        public float CustoFixo { get => _custoFixo; set => _custoFixo = value; }
        public float Comissao { get => _comissao; set => _comissao = value; }
        public float Lucro
        {
            get => _lucro;
            set
            {
                _lucro = _receitaLiquida - (_custoFixo + Comissao);
            }
        }
    }

}
