using System.Collections.Generic;
using TSport.Models;

namespace TSport.Services.CategoryService
{
    public interface ICategoryService : ICRUDService<Category>
    {
        List<TopCategory> GetTopCategory();
    }
}
