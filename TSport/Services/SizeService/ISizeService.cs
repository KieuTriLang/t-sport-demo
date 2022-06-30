using System.Collections.Generic;
using TSport.Models;

namespace TSport.Services.SizeService
{
    public interface ISizeService : ICRUDService<Size>
    {
        IEnumerable<TopSize> GetTopSize();
    }
}
