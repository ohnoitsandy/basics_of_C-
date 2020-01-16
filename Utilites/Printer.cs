using System.Runtime.InteropServices;
using static System.Console;

namespace CoreSchool.Utilities
{
    public static class Printer
    {
        public static void DrawLine(int size = 10)
        {
            var line = "".PadLeft(size, '-');
            WriteLine($"+{line}+");
            //WriteLine("SCHOOL COURSES FOR THE JAN - JUN SEMESTER");
        }

        public static void DrawTitle(string title)
        {
            DrawLine(title.Length + 18);
            WriteLine($"-------- {title.ToUpper()} ----------");
            DrawLine(title.Length + 18);
        }
        
    }
}