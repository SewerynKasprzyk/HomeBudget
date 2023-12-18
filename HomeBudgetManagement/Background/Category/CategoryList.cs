using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public static class CategoryList
    {

        static CategoryList()
        {
            
        }

        public static void AddToList(Category item)
        {
            Categories.Add(item);
        }

        //to deeply implement
        public static void RemoveFromList(Category item)
        {
            Categories.Remove(item);
        }

        public static List<Category> Categories { get; set; }
   
    }
}
