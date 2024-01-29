﻿using Database;
using Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public class CategoryManager
    {
        public CategoryService Service { get; set; }
        public Category category;

        public CategoryManager(Category category)
        {
            Service = new CategoryService(new HomeManagementDbContext());
            this.category = category;
        }

        //public addCategory()

    }
}