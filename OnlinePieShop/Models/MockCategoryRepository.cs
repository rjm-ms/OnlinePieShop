using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
              new Category { CategoryId=1,CategoryName="Fruit pies", Decription="All-fruity pies"},
              new Category { CategoryId=2,CategoryName="Cheese cakes", Decription="Cheesy all the way"},
              new Category { CategoryId=3,CategoryName="Seasonal pies", Decription="Get in the mood for a seasonal pie"}
            };
    }
}
