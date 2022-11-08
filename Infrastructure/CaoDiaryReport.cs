using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Agence_Practical_Test.Infrastructure
{
    public partial class CaoDiaryReport
    {
        public int CoDiaryReport { get; set; }
        public TimeSpan? HrGasta { get; set; }
        public int CoAtividade { get; set; }
        public string DsAssunto { get; set; }
        public long CoMovimento { get; set; }
        public long? NuOs { get; set; }
        public long? CoSistema { get; set; }
    }
}
