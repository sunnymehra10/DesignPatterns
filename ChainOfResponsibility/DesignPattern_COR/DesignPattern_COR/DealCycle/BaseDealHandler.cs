using System;

namespace DesignPattern_COR.DealCycle
{
    public abstract class BaseDealHandler
    {
        private RequestToProcess _request;
        public RequestToProcess RequestToProcess { get { return _request; } }
        public BaseDealHandler(RequestToProcess request)
        {
            _request = request;
            
        }
        public abstract DealStagesEnum StageName { get; }

        public abstract BaseDealHandler Successor();

        public abstract void ProcessRequest();

        protected void Showresult()
        {
            Console.WriteLine("------------------Deal---------------");
            Console.WriteLine(_request.DealName);
            Console.WriteLine("Section : On Risk");
            Console.WriteLine(_request.OnRisk);
            Console.WriteLine("Section : Not On Risk");
            Console.WriteLine(_request.NotOnRisk);
        }
    }

   
}
