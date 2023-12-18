using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    public static class LimitList
    {
        private static List<Limit> list;

        static LimitList()
        {
            list = new List<Limit>();   
        }

        public static int FindLimitIndex(Limit limit)
        {
            int enumarate = 0;
            foreach (Limit l in list)
            {
                if(l.LimitID == limit.LimitID)
                {
                    
                    return enumarate;
                }
                enumarate++;
            }

            return 0;
        }

        public static void AddToList(Limit limit)
        {
            list.Add(limit);
        }

        public static void DeleteFromList(Limit limit)
        {
            list.RemoveAt(FindLimitIndex(limit));
        }

        public static List<Limit> List { get => list; set => list = value; }
    }
}
