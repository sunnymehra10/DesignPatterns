namespace DesignPattern_COR.DealCycle
{
    public class PipelineHandler : BaseDealHandler
    {
        
        public PipelineHandler(RequestToProcess request):base( request)
        {
            
        }

        public override DealStagesEnum StageName { get { return DealStagesEnum.PIPELINE; } }

        public override void ProcessRequest()
        {
            base.RequestToProcess.OnRisk.AppendLine("Deal moved to Pipeline");
            if (base.RequestToProcess.ToDateDealStage == this.StageName)
            {
                base.Showresult();

            }
            else
            {
                base.RequestToProcess.OnRisk.AppendLine("Deal moved out of Pieline");
                this.Successor().ProcessRequest();
            }
        }

        public override BaseDealHandler Successor()
        {
            return new InmarketHandler(base.RequestToProcess);
        }
    }
}
