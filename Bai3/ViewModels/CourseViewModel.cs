﻿using Bai3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bai3.ViewModels
{
    public class CourseViewModel
    {
        [Required(ErrorMessage = "Phải có tên")]
       

        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time {  set; get; }
        [Required]
        public byte Category {   get; set; }    
        public IEnumerable<Category> Categories {  set; get; }
        public IEnumerable<Course> UpcommingCourses { set; get; }
        public bool ShowAction { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1} ",Date,Time));
        }
    }
}