using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex 1
            StringBuilder testBuilder = new StringBuilder();
            testBuilder.Append("Hello");
            Console.WriteLine(testBuilder);
            testBuilder = testBuilder.Substring(2, 5);
            Console.WriteLine(testBuilder);

            //ex 2
            List<int> myList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i + 3);
            }
            Console.WriteLine(myList.Sum());
            Console.WriteLine(myList.Max());
            Console.WriteLine(myList.Min());
            Console.WriteLine(myList.Average());

            //ex 3
            Student[] arrayStudent =
            {
                new Student("Ana","Stoica",25),
                new Student("Ion","Necula",35),
                new Student("Nelu","Boca",37),
                new Student("Maria","Dancu",29),
                new Student("Bianca","Cojocaru",36),
                new Student("Dragos","Creanga",18),
                new Student("Vasile","Nicu",61),
                new Student("Ciprian","Boncota",41),
                new Student("Denisa","Mazare",20),
                new Student("Mirela","Nechifor",17),
            };

            var result = arrayStudent.Where(x => x.FirstName[0] < x.LastName[0]);

            //ex 4 
            var selectByAge = arrayStudent.Where(x => x.Age >= 18 && x.Age <= 24).ToArray();

            //ex 5
            var sortedFirstLast = arrayStudent.OrderByDescending(x => x.FirstName).ThenBy(x => x.LastName);

            //ex 6
            int[] numberArray = Enumerable.Range(1, 50).ToArray();
            var divisibleBy3and7 = from number in numberArray
                                   where number % 3 == 0 && number % 7 == 0
                                   select number;

            //ex 9

            var studentOne = new Student2("Madalina", "Miron", "115115", "0895801888",
    "madalina.miron@yahoo.com", new List<double> { 2.0, 3.5, 5.5, 6.0 }, new Group(2, "Matematica"));
            students.Add(studentOne);

            var studentTwo = new Student2("Petru", "Cotor", "115706", "+3598958018444",
               "petru.cotor@hotmail.com", new List<double> { 2.0, 6.0, 6.0, 6.0 }, new Group(3, "Biologie"));
            students.Add(studentTwo);

            var studentThree = new Student2("Stefan", "Dumitru", "134654", "0895801777",
                "stefan.dumitru@gmail.com", new List<double> { 2.0, 3.5, 3.5 }, new Group(2, "Matematica"));
            students.Add(studentThree);

            var studentFour = new Student2("Sorin", "Bejan", "234432", "02-345432",
                "sorin.bejan@yahoo.com", new List<double> { 6.0, 4.5, 2.0, 4.0, 5.0 }, new Group(1, "Informatica"));
            students.Add(studentFour);

            var studentFive = new Student2("Andreea", "Stefanica", "467406", "+35921345111",
               "andreea.stefanica@yahoo.com", new List<double> { 2.0, 2.0 }, new Group(2, "Franceza"));
            students.Add(studentFive);


            var studentsFromGroup2 = from student in students
                                     where student.GroupNumber.GroupNumber == 2
                                     select student;

            var sortedStudentsByFirstName = from student in studentsFromGroup2
                                            orderby student.FirstName
                                            select student;

            //ex 10
            var studentsFromGroup2Var2 = students.where(Student.GroupNumber.GroupNumber == 2);

            var sortedStudentByFirstName2 = studentsFromGroup2.OrderBy(x => x.FirstName);

            //ex 12
            var studentsWithPhonesInSofia =
               from student in students
               where student.Tel.StartsWith("02") || student.Tel.StartsWith("+3592")
               select student;

            //ex 13
            var studentsWithExcellentMark =
            from student in students
            where student.Marks.Contains(6.0)
            select new { FullName = student.FirstName + " " + student.LastName, Marks = string.Join(", ", student.Marks) };

            //ex 14
            var studentsWith2PoorMarks = students.Where(stud => stud.Marks.FindAll(m => m == 2.0).Count == 2)
                .Select(x => new { FullName = x.FirstName + " " + x.LastName, Marks = string.Join(", ", x.Marks) });

            //ex 15
            var studentsEnrolled2006 = students.Where(x => x.FacNumber[4] == '0' && x.FacNumber[5] == '6').
               Select(x => new { FullName = x.FirstName + " " + x.LastName, FacNumber = x.FacNumber });

            //ex 16
            var studentsMath = students.Where(x => x.GroupNumber.DepartmentName == "Mathematics").
               Select(x => new { FullName = x.FirstName + " " + x.LastName, Department = x.GroupNumber.DepartmentName });


            Console.ReadKey();
        }
    }
}
