using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject.InMemoryDatabase
{
    class InMemoryDatabase
    {
        static CategoryRepositoryInMemory category;

        private static void printCategories(List<Category> categories)
        {
            foreach(var category in categories)
            {
                Console.WriteLine($"{category.categoryId} - {category.categoryName}");
            }
            Console.WriteLine();
        }

        private static void hasCategory()
        {
            if(category.has() > 0) // true면 1이라서 0보다 큼
            {
                Console.WriteLine("기본 데이터가 있음");
            }
            else
            {
                Console.WriteLine("기본 데이터가 없음");
            }
            Console.WriteLine();
        }

        private static void readCategories()
        {
            var categories = category.read();
            printCategories(categories);
        }
        /*
        static void Main(string[] args)
        {
            category = new CategoryRepositoryInMemory();

            //Console.WriteLine("[1] 기본 데이터");
            //readCategories();
            addCategory();
        }
        */

        private static void addCategory()
        {
            var addedCategory = new Category() { categoryName = "생활용품" };
            category.add(addedCategory);
            readCategories();
        }
    }
}
