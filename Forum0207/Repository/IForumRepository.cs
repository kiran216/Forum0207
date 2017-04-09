using Forum0207.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum0207.Repository
{
    public interface IForumRepository
    {
        List<Category> GetCategories();

        Category GetCategory(int id);
    }
}
