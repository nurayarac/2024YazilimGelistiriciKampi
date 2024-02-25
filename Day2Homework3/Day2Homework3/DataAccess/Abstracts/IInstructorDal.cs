using Day2Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Homework3.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        void Add(Instructor ınstructor);
        void Delete(Instructor ınstructor);
        void Update(Instructor ınstructor);
    }
}
