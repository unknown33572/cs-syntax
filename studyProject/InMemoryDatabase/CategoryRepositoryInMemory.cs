using studyProject.Dul.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.InMemoryDatabase
{
    class CategoryRepositoryInMemory : ICategoryRepository //impl
    {
        private static List<Category> categories = new List<Category>();

        public CategoryRepositoryInMemory() // 생성자
        {
            categories = new List<Category>()
            {
                new Category() {categoryId = 1, categoryName = "책"},
                new Category() {categoryId = 2, categoryName = "강의"},
                new Category() {categoryId = 3, categoryName = "컴퓨터"},
            };

        }
        public Category add(Category model)
        {
            model.categoryId = categories.Max(c => c.categoryId) + 1;
            categories.Add(model);
            return model;
        }
        public Category browse(int id)
        {
            return categories.Where(c => c.categoryId == id).SingleOrDefault();
        }
        public bool delete(int id)
        {
            int r = categories.RemoveAll(c => c.categoryId == id);
            if(r > 0)
            {
                return true;
            }
            return false;
        }
        public int has()
        {
            return categories.Count;
        }
        public IEnumerable<Category> ordering(OrderOption orderOption)
        {
            IEnumerable<Category> orderingCategory;

            switch(orderOption)
            {
                case OrderOption.Ascending:
                    orderingCategory = categories.OrderBy(c => c.categoryName);
                    break;
                case OrderOption.Descending:
                    orderingCategory = (from category in categories
                                        orderby category.categoryName descending
                                        select category);
                    break;
                default:
                    orderingCategory = categories;
                    break;
            }
            return categories;
        }
        public List<Category> paging(int pageNumber = 1, int pageSize = 10)
        {
            return categories.Skip((pageNumber - 1) * pageSize)
                             .Take(pageSize)
                             .ToList();
        }
        public List<Category> read()
        {
            return categories;
        }
        public List<Category> search(string query)
        {
            return categories.Where(categories => categories.categoryName.Contains(query)).ToList();
        }
    }
}
