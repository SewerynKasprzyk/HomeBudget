using Database;
using Database.Entities;
using System;

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

        public void AddCategory(String name, decimal limit)
        {
            Service.Add(new Category { Name = name, Limit = limit });
        }

        public void ChangeName(String name)
        {
            category.Name = name;
            Service.Update(category);
        }

        public void ChangeName(decimal limit)
        {
            category.Limit = limit;
            Service.Update(category);
        }
    }
}
