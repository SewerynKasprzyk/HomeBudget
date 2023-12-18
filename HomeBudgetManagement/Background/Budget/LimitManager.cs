using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    public class LimitManager
    {
        private Limit limit;
        private List<Limit> limits;
        private int userID;

        public LimitManager(int userID)
        {
            this.userID = userID;
        }

        public List<Limit> GetListOfAccLimits()
        {
            foreach (Limit limit in LimitList)
            {
                
            }
        }

        public int UserID { get => userID; set => userID = value; }
        public Limit Limit { get => limit; set => limit = value; }
        public List<Limit> Limits { get => limits; set => limits = value; }
    }
}
