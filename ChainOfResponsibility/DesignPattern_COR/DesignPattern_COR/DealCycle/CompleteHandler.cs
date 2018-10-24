using System;
namespace DesignPattern_COR.DealCycle
{
    public class CompleteHandler : BaseDealHandler
    {
        public CompleteHandler(RequestToProcess request):base(request)
        {

        }

        public override DealStagesEnum StageName { get { return DealStagesEnum.COMPLETE; } }

        public override void ProcessRequest()
        {
            base.RequestToProcess.NotOnRisk.AppendLine("Deal moved to Complete");
            if (base.RequestToProcess.ToDateDealStage == this.StageName)
            {
                base.RequestToProcess.NotOnRisk.AppendLine("Deal Completed");
                base.Showresult();
            }
            else
            {
                base.RequestToProcess.NotOnRisk.AppendLine("Deal Final status incorrect.Please check with Admin");
                base.Showresult();
            }
        }

        public override BaseDealHandler Successor()
        {
            throw new NotImplementedException();
        }
    }
}
