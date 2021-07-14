using _1811061832_NguyenNhatThanh_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1811061832_NguyenNhatThanh_BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]

        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            string dateString = Date + " " + Time;
            DateTime date3 = DateTime.ParseExact(dateString, @"dd/M/yyyy HH:mm",
                System.Globalization.CultureInfo.InvariantCulture);

            return date3;
        }
    }
}