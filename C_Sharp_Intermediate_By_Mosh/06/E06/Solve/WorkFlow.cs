using System.Collections.Generic;

namespace C_Sharp_Intermediate_By_Mosh.E06.Solve
{
    public class WorkFlow
    {
        public IList<IActivity> _activities { get;}

        public WorkFlow()
        {
            _activities = new List<IActivity>();
        }
        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
