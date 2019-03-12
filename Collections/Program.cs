using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsWithBlackHair = new List<string> {"Nathan", "Austin", "Marty McFly"};

            var studentsByHairColor = new Dictionary<string,List<string>>
            {
                {"Black", studentsWithBlackHair }
            };

            studentsByHairColor.Add("Bald", new List<string> { "Martin" });

            // This throws an exception because it tries to create a new list called Bald:
            //studentsByHairColor/.Add("Bald", new List<string> { "Adam" });

            var theBlackHairedStudents = studentsByHairColor["Black"]; // returns a list

            if (theBlackHairedStudents == studentsWithBlackHair)
            {
                Console.WriteLine("They are the same");
            }

            studentsByHairColor["Black"].Add("new person");

            foreach (var (hairColor, students) in studentsByHairColor) // kvp stands for 'key value pair'
            {
                Console.WriteLine($"The following students have {hairColor} hair");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
            Console.ReadLine();
        }
    }
}
