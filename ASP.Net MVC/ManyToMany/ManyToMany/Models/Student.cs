using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManyToMany.Models
{
    public class Student
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name="Имя студента")]
        [UIHint("Url")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        public string SurName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }
    }

    public class LogModel
    {
        public string Login { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}