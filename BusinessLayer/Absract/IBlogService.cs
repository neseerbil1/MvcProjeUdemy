using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Absract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogByID(int id);
        List<Blog> GetBlogByAuthor(int id);
    }
}
