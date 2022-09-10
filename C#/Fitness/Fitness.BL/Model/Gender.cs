using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Gender
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Name of gender
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Create new gender 
        /// </summary>
        /// <param name="name"> Name of gender</param>
        /// <exception cref="ArgumentNullException"></exception>

        public Gender(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name of gender can't be empty or null", nameof(name));
            }
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
