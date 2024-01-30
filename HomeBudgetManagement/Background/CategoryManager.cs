using Database;
using Database.Entities;
using System;
using System.Collections.Generic;

namespace Model.Manager
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

        public CategoryManager()
        {
            Service = new CategoryService(new HomeManagementDbContext());
        }

        public void AddCategory(Category category)
        {
            Service.Add(category);
        }
        public List<Category> GetAll()
        {
            return Service.GetAll();
        }

        public void ChangeName(String name)
        {
            category.Name = name;
            Service.Update(category);
        }

        public void ChangeLimit(decimal limit)
        {
            category.Limit = limit;
            Service.Update(category);
        }
    }
}
