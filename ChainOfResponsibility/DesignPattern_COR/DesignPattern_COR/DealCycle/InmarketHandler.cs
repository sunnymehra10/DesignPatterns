namespace DesignPattern_COR.DealCycle
{
    public class InmarketHandler : BaseDealHandler
    {
        public InmarketHandler(RequestToProcess request) : base(request)
        {

        }

        public override DealStagesEnum StageName { get { return DealStagesEnum.INMARKET; } }

        public override void ProcessRequest()
        {
            base.RequestToProcess.OnRisk.AppendLine("Deal moved to In Market - On risk");

            if (base.RequestToProcess.ToDateDealStage== this.StageName)
            {
                base.Showresult();
            }
            else
            {
                base.RequestToProcess.OnRisk.AppendLine("Deal moved out of Market - Out Of risk");
                this.Successor().ProcessRequest();
            }
               
        }

        public override BaseDealHandler Successor()
        {
            return new CompleteHandler(base.RequestToProcess);
        }
    }
}
