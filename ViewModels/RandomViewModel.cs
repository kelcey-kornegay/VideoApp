using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoApp.Models;

namespace VideoApp.ViewModels
{
    public class RandomViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> customer { get; set; }
    }
}