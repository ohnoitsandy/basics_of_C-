using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using CoreSchool.Entities;
using static System.Console;

namespace fase1
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("LIFE HOMIE", 2020, SchoolTypes.HighSchool, "Santa catarina", "Babilonia");

            school.Courses = new List<Course>()
            {
                new Course() {Name = "Fuckallthat", Turn = TurnTypes.Morning},
                new Course() {Name = "Fuckallthat Advanced", Turn = TurnTypes.Afternoon},
                new Course() {Name = "Fuckallthat with love", Turn = TurnTypes.Night},
            };
            
            school.Courses.Add(new Course(){Name = "Fuckallthat but why", Turn = TurnTypes.Morning});
            school.Courses.Add(new Course(){Name = "Once u fucked all that", Turn = TurnTypes.Afternoon});
            
            var newListOfCourses = new List<Course>()
            {
                new Course() {Name = "How to unfuckallthat", Turn = TurnTypes.Morning},
                new Course() {Name = "Learning how to live fuckingallthat", Turn = TurnTypes.Afternoon},
                new Course() {Name = "Making peace with fuckingallthat", Turn = TurnTypes.Night},
            };
            
            school.Courses.AddRange(newListOfCourses);

            PrintSchoolCourses(school);

            school.Courses.RemoveAll(MethodPredicate);
            
            PrintSchoolCourses(school);


            static bool MethodPredicate(Course courseObject)
            {
                return courseObject.Name == "Fuckallthat";
            }
        }

        private static void PrintSchoolCourses(School school)
        {
            WriteLine("+--------------+");
            WriteLine("SCHOOL COURSES FOR THE JAN - JUN SEMESTER");
            WriteLine("+--------------+");

            if (school?.Courses == null) return;
            foreach (var course in school.Courses)
            {
                WriteLine($"Name: {course.Name}, ID: {course.Id}, Turn: {course.Turn}");
            }
        }
    }
}
