﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab11
{
    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        

        public Movie(string title, string category)
        {
            this.Title = title;
            this.Category = category;
           
        
        }
    }
}
