﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2007_Lesson10.Models
{
    public class Genre
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Genre()
        {

        }

        /// <summary>
        /// This constructor takes one parameter - Name
        /// </summary>
        /// <param name="Name"></param>
        public Genre(string Name)
        {
            this.Name = Name;
        }
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}
