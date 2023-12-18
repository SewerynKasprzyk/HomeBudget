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
            limits = new List<Limit>();
            this.userID = userID;
        }

        public void GetListOfAccLimits()
        {
            foreach (Limit limit in LimitList.List)
            {
                if(userID == limit.AccountID)
                {
                    Limits.Add(limit);
                }
            }
        }

        public void ManageLimit(int limitId)
        {
            GetListOfAccLimits();

            foreach (Limit limit in limits)
            {
                if (limitId == limit.LimitID)
                {
                    this.limit = limit;
                }
            }
        }


        public void AddLimitDemo(int id, float limitValue, String name)
        {
            Limit limit = new Limit(id, this.userID, limitValue, name);
            LimitList.AddToList(limit);
            this.Reload();
        }
        public void AddLimit(float limitValue, String name)
        {
            int id = 404;
            Limit limit = new Limit(this.userID, limitValue, name);
            LimitList.AddToList(limit);
            this.Reload();
        }

        public void RemoveLimit()
        {
            LimitList.DeleteFromList(this.limit);
            this.Reload();
        }

        public void ChangeLimit(float value)
        {
            LimitList.List[LimitList.FindLimitIndex(this.limit)].LimitValue =  value;
            this.Reload();
        }

        private void Reload()
        {
            limits = new List<Limit>();

            foreach (Limit limit in LimitList.List)
            {
                if (userID == limit.AccountID)
                {
                    Limits.Add(limit);
                }
            }
        }

        public int UserID { get => userID; set => userID = value; }
        public Limit Limit { get => limit; set => limit = value; }
        public List<Limit> Limits { get => limits; set => limits = value; }
    }
}
