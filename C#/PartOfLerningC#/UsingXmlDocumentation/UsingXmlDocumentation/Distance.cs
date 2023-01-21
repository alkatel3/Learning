namespace UsingXmlDocumentation
{
    
    /// <summary>
    /// The <c>Distance</c> class provider methods
    /// for converting kilometers to and from miles
    /// </summary>
    public class Distance
    {
        
        /// <summary>
        /// Converts kilometers to miles.
        /// </summary>
        /// <param name="kilometers">
        /// Used to indicate kilometers.
        /// A <see cref="double"/>
        /// type representing a value.
        /// </param>
        /// <exception cref="ArgumentException">
        /// If <paramref name="kilometers"/>
        /// is negative.
        /// </exception>
        /// <returns>Returns the distance in miles
        /// </returns>
        public static double KilometersToMiles(double kilometers)
        {
            if(kilometers < 0)
            {
                throw new ArgumentException("Thr value must be positive.");
            }
            return kilometers * 0.621371;
        }
        
        ///<summary>
        ///Converts miles to kilometers.
        ///</summary>
        ///<param name="miles">
        ///Used to indicate miles.
        ///A <see cref="double"/>
        ///</param>
        ///<exception cref="ArgumentException">
        ///If <parenref name="miles"/> is neative.
        ///</exception>
        ///<returbs>Returns the distance in
        ///kilomiters.
        ///</returbs>
        public static double MilesToKilometers(double miles)
        {
            if (miles < 0)
            {
                throw new ArgumentException("The value must be positive.");
            }
            return miles * 1.60934;
        }
    }
}
