using DesignPattern_COR.DealCycle;
using System;
using System.Text;

namespace DesignPattern_COR
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestToProcess req1 = new RequestToProcess();
            req1.NotOnRisk = new StringBuilder();
            req1.OnRisk = new StringBuilder();
            req1.DealName = "Deal 123";
            req1.ToDateDealStage = DealStagesEnum.COMPLETE;

            PipelineHandler handler = new PipelineHandler(req1);
            handler.ProcessRequest();
            
            RequestToProcess req2 = new RequestToProcess();
            req2.NotOnRisk = new StringBuilder();
            req2.OnRisk = new StringBuilder();
            req2.DealName = "Deal XYZ";
            req2.ToDateDealStage = DealStagesEnum.INMARKET;

            PipelineHandler handler2 = new PipelineHandler(req2);
            handler2.ProcessRequest();
            
            Console.ReadKey();
        }
    }
}
