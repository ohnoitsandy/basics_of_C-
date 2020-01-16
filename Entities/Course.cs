using System;

namespace CoreSchool.Entities
{
    public class Course
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public TurnTypes Turn { get; set; }

        public Course() => this.Id = Guid.NewGuid().ToString();

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Name}";
        }
    }
}