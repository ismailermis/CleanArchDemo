using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRespository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRespository =courseRepository;
        }
        
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRespository.GetCourses()
            };
        }
    }
}
