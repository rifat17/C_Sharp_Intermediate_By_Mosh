using System;
namespace C_Sharp_Intermediate_By_Mosh.E06.Solve
{
    public class WorkFlowEngine
    {
        private readonly WorkFlow workFlow;

        public WorkFlowEngine( WorkFlow workFlow)
        {
            this.workFlow = workFlow;
        }
        public void Run()
        {
            var activities = workFlow._activities;

            foreach(var activity in activities)
            {
                activity.Execute();
            }
        }
    }
}
