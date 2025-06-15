#region Using Statements
using Microsoft.Xna.Framework;
using System.Text.Json; 
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

        public string SayHello()
        {
            return "Hello, My Name is " + first_name + " " + last_name + " Nice to Meet You"; 
        }
    }
}