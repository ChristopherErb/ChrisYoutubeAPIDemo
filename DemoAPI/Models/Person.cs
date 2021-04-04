using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Users first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// ...Guess
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Unique ID...
        /// </summary>
        public int Id { get; set; }
    }
}