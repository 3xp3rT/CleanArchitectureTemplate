using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infostructure.Data.Repositories
{ 
     public interface ICourseRepository
    {
        public IEnumerable<Course> GetCourses();
    }
}
