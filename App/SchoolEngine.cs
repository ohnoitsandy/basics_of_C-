using System.Collections.Generic;
using CoreSchool.Entities;

namespace CoreSchool
{
    public class SchoolEngine
    {
        public School School { get; set; }

        public SchoolEngine()
        {
            
        }

        public void Initialize()
        {
            School = new School("LIFE HOMIE", 2020, SchoolTypes.HighSchool, "Santa catarina", "Babilonia");
            
            School.Courses = new List<Course>()
            {
                new Course() {Name = "Fuckallthat", Turn = TurnTypes.Morning},
                new Course() {Name = "Fuckallthat Advanced", Turn = TurnTypes.Afternoon},
                new Course() {Name = "Fuckallthat with love", Turn = TurnTypes.Night},
                new Course() {Name = "How to unfuckallthat", Turn = TurnTypes.Morning},
                new Course() {Name = "Learning how to live fuckingallthat", Turn = TurnTypes.Afternoon},
                new Course() {Name = "Making peace with fuckingallthat", Turn = TurnTypes.Night},
            };
        }
    }
}