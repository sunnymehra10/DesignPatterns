using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_COR
{
    public class RequestToProcess
    {
        public string DealName { get; set; }
        public DealCycle.DealStagesEnum FromDateDealStage { get; set; }
        public DealCycle.DealStagesEnum ToDateDealStage { get; set; }
        public StringBuilder OnRisk { get; set; }
        public StringBuilder NotOnRisk { get; set; }
    }
}
