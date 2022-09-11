using System;
using System.Runtime.Serialization.Formatters.Binary;
using Fitness.BL.Model;

namespace Fitness.BL.Controller
{
    /// <summary>
    /// Controller of user.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// User of app
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Creating new cotroller of user.
        /// </summary>
        /// <param name="user"></param>
        public UserController(string userName, string genderName, DateTime birdthDay, double weight, double height)
        {
            // TODO: Checking
            var gender = new Gender(genderName);
            User = new User(userName, gender, birdthDay, weight, height);
        }

        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                // TODO: What do if don't read user? 
            }
        }
        /// <summary>
        /// Save data of user.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using(var fs=new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
    }
}
