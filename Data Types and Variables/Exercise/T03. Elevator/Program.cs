using System;

namespace T03_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            bool done = false;

            int courses = 0;
            int lastCourse = 0;

            while (done != true)
            {
                if (people >= capacity)
                {
                    people -= capacity;
                    courses++;
                }
                else
                {
                    people = 0;
                    courses++;
                    lastCourse++;
                }

                if (people == 0)
                {
                    done = true;
                }
            }

            if (courses > 1)
            {
                Console.WriteLine(courses);
            }
            else
            {
                Console.WriteLine(lastCourse);
            }

        }
    }
}
