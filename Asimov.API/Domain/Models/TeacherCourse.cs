﻿namespace Asimov.API.Domain.Models
{
    public class TeacherCourse
    {
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }
    }
}