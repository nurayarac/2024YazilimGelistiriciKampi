﻿using Day2Homework3.DataAccess.Abstracts;
using Day2Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Homework3.DataAccess.Concretes
{
    public class InstructorDal:IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal() {
            Instructor instructor1 = new();
            instructor1.Id = 1;
            instructor1.FirstName = "Engin";
            instructor1.LastName = "DEMİROĞ";

            Instructor instructor2 = new();
            instructor2.Id = 2;
            instructor2.FirstName = "Halit Enes";
            instructor2.LastName = "KALAYCI";

            _instructors = new List<Instructor> {instructor1,instructor2 };
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Console.WriteLine("Silme işlemi");
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Güncelleme işlemi");
        }
    }
}
