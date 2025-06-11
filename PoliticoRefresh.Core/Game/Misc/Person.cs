#region Using Statements
using Microsoft.Xna.Framework;
#endregion

namespace PoliticoRefresh
{
    public class Person
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }
        public enum Gender
        {
            Male,
            Female
        }

        Gender gender { get; set; }
    }
}