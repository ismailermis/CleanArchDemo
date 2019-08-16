using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRespository : ICourseRepository
    {
        private UniversityDBContext _ctx;
        public CourseRespository(UniversityDBContext dBContext)
        {
            _ctx=dBContext;
        }

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
