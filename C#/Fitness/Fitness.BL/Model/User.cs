using System;

namespace Fitness.BL.Model
{
    /// <summary>
    /// User
    /// </summary>
    public class User
    {
        #region Properties
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Gender
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Weight
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        public double Height { get; set; }
        #endregion

        /// <summary>
        /// Create new user.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="gender">Surname.</param>
        /// <param name="birthDate">date of birth.</param>
        /// <param name="weight">weight.</param>
        /// <param name="height">height.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            #region Checking conditions
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name of user can't be empty or null.", nameof(name));
            }

            if (Gender == null)
            { 
            throw new ArgumentNullException("Gender can't be null.",nameof(Gender));
            }

            if (birthDate < DateTime.Parse("01.01.1900")|| birthDate>=DateTime.Now)
            {
                throw new ArgumentException("Impossible date of birthday.", nameof(birthDate));
            }

            if(weight <= 0)
            {
                throw new ArgumentException("Weight can't be less than or equal to 0.", nameof(weight));
            }

            if(height <= 0)
            {
                throw new ArgumentException("Height can't be less than or equal to 0.", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
