using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.Interfaces
{
    interface IBlogRepository : IRepository<Blog, string>
    {
        IEnumerable<Blog> GetBlogsByAuthor(Doctor doctor);
        IEnumerable<Blog> GetBlogsByDate(DateTime date);
    }
}
