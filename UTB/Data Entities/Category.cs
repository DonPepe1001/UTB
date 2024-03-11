using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Data_Entities
{
    public class Category
    {
        public int categoryId { get; set; }
        public string category { get; set; }
        public string description { get; set; }
            
        public Category() { }

        public int GetCategoryId()
        {
            return categoryId;
        }

        public void SetCategoryId(int categoryId)
        {
            this.categoryId = categoryId;
        }

        public string GetCategory()
        {
            return category;
        }

        public void SetCategory(string category)
        {
            this.category = category;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }
    }

}
