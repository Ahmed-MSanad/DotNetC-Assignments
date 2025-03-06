using Assignment_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext context = new CompanyDbContext();

            #region Insert/Read/Update/Delete => Department

            //Department[] departments = {
            //    new Department() { Name = "HR", HiringDate = new DateOnly(2023, 5, 15) },
            //    new Department() { Name = "IT", HiringDate = new DateOnly(2022, 10, 28) },
            //    new Department() { Name = "Finance", HiringDate = new DateOnly(2024, 1, 10) },
            //    new Department() { Name = "Marketing", HiringDate = new DateOnly(2023, 8, 22) },
            //    new Department() { Name = "Sales", HiringDate = new DateOnly(2022, 12, 5) }
            //};

            //// Detached
            //Console.WriteLine(context.Entry(departments[0]).State);

            //context.AddRange(departments); // batching // insert

            //// Added
            //Console.WriteLine(context.Entry(departments[0]).State);

            //context.SaveChanges();

            //// Unchanged
            //Console.WriteLine(context.Entry(departments[0]).State);


            //departments[0].HiringDate = new DateOnly(2025, 2, 2); // update

            //// departments[0].HiringDate --> Modified
            //Console.WriteLine(context.Entry(departments[0]).State);

            //context.SaveChanges();

            //// departments[0].HiringDate --> Unchanged
            //Console.WriteLine(context.Entry(departments[0]).State);


            //var hired2022 = context.departments.Where(x => x.HiringDate.Year == 2022).ToList(); // read

            //foreach (var dept in hired2022)
            //    Console.WriteLine($"{dept.Name}");

            //context.Remove(hired2022[0]); // delete the department

            //// hired2022[0] --> Deleted
            //Console.WriteLine(context.Entry(hired2022[0]).State);

            //context.SaveChanges();

            //// hired2022[0] --> Detached
            //Console.WriteLine(context.Entry(hired2022[0]).State);


            #endregion

            #region Insert/Read/Update/Delete => Student

            //Student[] students = {
            //    new Student() { FName = "Ahmed", LName = "Sanad", Address = "US", Age = 22, Dep_Id = 1002 },
            //    new Student() { FName = "Sara", LName = "Mahmoud", Address = "Canada", Age = 20, Dep_Id = 1004 },
            //    new Student() { FName = "Mohamed", LName = "Ali", Address = "UK", Age = 25, Dep_Id = 1005 },
            //    new Student() { FName = "Aisha", LName = "Hassan", Address = "Egypt", Age = 21, Dep_Id = 1002 },
            //    new Student() { FName = "Omar", LName = "Youssef", Address = "Australia", Age = 23, Dep_Id = 1006 },
            //    new Student() { FName = "Laila", LName = "Khaled", Address = "Germany", Age = 24, Dep_Id = 1004 }
            //};

            //// Detached

            //context.Set<Student>().AddRange(students); // batching // insert

            //// Added

            //context.SaveChanges();

            //// Unchanged

            //students[0].Address = "Cairo"; // update

            //// Modified

            //context.SaveChanges();

            //// Unchanged

            //var firstStudents = context.students.Where(x => x.StuId < 3).ToList(); // read

            //foreach (var stu in firstStudents)
            //    Console.WriteLine($"{stu.FName}");

            //context.Remove(firstStudents[0]); // delete

            //// firstStudents[0] --> Deleted

            //context.SaveChanges();

            //// firstStudents[0] --> Detached

            #endregion

            #region Insert/Read/Update/Delete => Topic

            //Topic[] topics = {
            //    new Topic() { Name = "Introduction to C#" },
            //    new Topic() { Name = "Object-Oriented Programming" },
            //    new Topic() { Name = "Data Structures and Algorithms" },
            //    new Topic() { Name = "Database Design" },
            //    new Topic() { Name = "Web Development with ASP.NET Core" },
            //    new Topic() { Name = "Mobile Development with Xamarin" }
            //};

            //// Detached
            //Console.WriteLine(context.Entry(topics[0]).State);

            //context.AddRange(topics); // batching // insert

            //// Added
            //Console.WriteLine(context.Entry(topics[0]).State);

            //context.SaveChanges();

            //// Unchanged
            //Console.WriteLine(context.Entry(topics[0]).State);


            //topics[0].Name = "Master C#"; // update

            //// topics[0].Name --> Modified
            //Console.WriteLine(context.Entry(topics[0]).State);

            //context.SaveChanges();

            //// topics[0].Name --> Unchanged
            //Console.WriteLine(context.Entry(topics[0]).State);


            //var longNamesTopics = context.topics.Where(x => x.Name.Length >= 32).ToList(); // read

            //foreach (var topic in longNamesTopics)
            //    Console.WriteLine($"Topic Name: {topic.Name}");

            //context.Remove(longNamesTopics[0]); // delete the 1st Topic

            //// allTopicsNames[0] --> Deleted
            //Console.WriteLine(context.Entry(longNamesTopics[0]).State);

            //context.SaveChanges();

            //// allTopicsNames[0] --> Detached
            //Console.WriteLine(context.Entry(longNamesTopics[0]).State);


            #endregion

            #region Insert/Read/Update/Delete => Instructor

            //Instructor[] instructors = {
            //    new Instructor() { Name = "Dr. Ahmed Mahmoud", Bouns = 500.00, Salary = 8000.00, Address = "123 Main St, Cairo", HourRate = 50.00, Dep_Id = 1002 },
            //    new Instructor() { Name = "Prof. Sara Ali", Bouns = 300.00, Salary = 7000.00, Address = "456 Elm St, Alexandria", HourRate = 45.00, Dep_Id = 1004 },
            //    new Instructor() { Name = "Eng. Mohamed Hassan", Bouns = 100.00, Salary = 5500.00, Address = "789 Oak St, Giza", HourRate = 40.00, Dep_Id = 1005 },
            //    new Instructor() { Name = "Ms. Laila Youssef", Bouns = 400.00, Salary = 7500.00, Address = "101 Pine St, Mansoura", HourRate = 55.00, Dep_Id = 1006 },
            //    new Instructor() { Name = "Mr. Omar Khaled", Bouns = 100.00, Salary = 5500.00, Address = "202 Cedar St, Tanta", HourRate = 35.00, Dep_Id = 1002 }
            //};

            //// Detached
            //Console.WriteLine(context.Entry(instructors[0]).State);

            //context.AddRange(instructors); // batching // insert

            //// Added
            //Console.WriteLine(context.Entry(instructors[0]).State);

            //context.SaveChanges();

            //// Unchanged
            //Console.WriteLine(context.Entry(instructors[0]).State);


            //instructors[0].Salary = 100_00.00; // update

            //// instructors[0].Salary --> Modified
            //Console.WriteLine(context.Entry(instructors[0]).State);

            //context.SaveChanges();

            //// instructors[0].Salary --> Unchanged
            //Console.WriteLine(context.Entry(instructors[0]).State);


            //var lowBonusInstructors = context.instructors.Where(x => x.Bouns <= 300).ToList(); // read

            //foreach (var ins in lowBonusInstructors)
            //    Console.WriteLine($"Instructor Name: {ins.Name}, Bonus: {ins.Bouns}");

            //context.Remove(lowBonusInstructors[0]); // delete the 1st instructor with lowest bonus

            //// lowBonusInstructors[0] --> Deleted
            //Console.WriteLine(context.Entry(lowBonusInstructors[0]).State);

            //context.SaveChanges();

            //// lowBonusInstructors[0] --> Detached
            //Console.WriteLine(context.Entry(lowBonusInstructors[0]).State);


            #endregion

            #region Insert/Read/Update/Delete => Course

            //Course[] courses = {
            //    new Course() { Name = "Introduction to Programming", Duration = 40, Description = "Learn the basics of programming.", Top_Id = 1002 },
            //    new Course() { Name = "Web Development Fundamentals", Duration = 60, Description = "Build websites using HTML, CSS, and JavaScript.", Top_Id = 1003 },
            //    new Course() { Name = "Data Science with Python", Duration = 80, Description = "Analyze data and build machine learning models.", Top_Id = 1004 },
            //    new Course() { Name = "Mobile App Development", Duration = 70, Description = "Create mobile apps for iOS and Android.", Top_Id = 1005 },
            //    new Course() { Name = "Database Management", Duration = 50, Description = "Learn to design and manage databases.", Top_Id = 1007 }
            //};

            //// Detached
            //Console.WriteLine(context.Entry(courses[0]).State);

            //context.AddRange(courses); // batching // insert

            //// Added
            //Console.WriteLine(context.Entry(courses[0]).State);

            //context.SaveChanges();

            //// Unchanged
            //Console.WriteLine(context.Entry(courses[0]).State);


            //courses[0].Duration = 90; // update

            //// courses[0].Duration --> Modified
            //Console.WriteLine(context.Entry(courses[0]).State);

            //context.SaveChanges();

            //// courses[0].Duration --> Unchanged
            //Console.WriteLine(context.Entry(courses[0]).State);


            //var lowDurationCourses = context.courses.Where(x => x.Duration <= 60).ToList(); // read

            //foreach (var course in lowDurationCourses)
            //    Console.WriteLine($"Course Name: {course.Name} => Duration: {course.Duration}");

            //context.Remove(lowDurationCourses[0]); // delete the department

            //// lowDurationCourses[0] --> Deleted
            //Console.WriteLine(context.Entry(lowDurationCourses[0]).State);

            //context.SaveChanges();

            //// lowDurationCourses[0] --> Detached
            //Console.WriteLine(context.Entry(lowDurationCourses[0]).State);


            #endregion

            #region Insert/Read/Update/Delete => Course_Ins

            //Course_Ins[] course_Ins = {
            //    new Course_Ins() { Course_Id = 1003, Ins_Id = 1002, Evaluate = "Excellent" },
            //    new Course_Ins() { Course_Id = 1005, Ins_Id = 1004, Evaluate = "Good" },
            //    new Course_Ins() { Course_Id = 1006, Ins_Id = 1005, Evaluate = "Satisfactory" },
            //    new Course_Ins() { Course_Id = 1007, Ins_Id = 1006, Evaluate = "Needs Improvement" },
            //    new Course_Ins() { Course_Id = 1003, Ins_Id = 1006, Evaluate = "Outstanding" }
            //};

            //// Detached
            //Console.WriteLine(context.Entry(course_Ins[0]).State);

            //context.AddRange(course_Ins); // batching // insert

            //// Added
            //Console.WriteLine(context.Entry(course_Ins[0]).State);

            //context.SaveChanges();

            //// Unchanged
            //Console.WriteLine(context.Entry(course_Ins[0]).State);


            //course_Ins[0].Evaluate = "Very bad"; // update

            //// course_Ins[0].Evaluate --> Modified
            //Console.WriteLine(context.Entry(course_Ins[0]).State);

            //context.SaveChanges();

            //// course_Ins[0].Evaluate --> Unchanged
            //Console.WriteLine(context.Entry(course_Ins[0]).State);


            //var course_Instructors = context.Course_Ins.Select(x => x).ToList(); // read

            //foreach (var ins in course_Instructors)
            //    Console.WriteLine($"Instructor Evaluation: {ins.Evaluate}");

            //context.Remove(course_Instructors[0]); // delete the 1st instructor - course

            //// course_Instructors[0] --> Deleted
            //Console.WriteLine(context.Entry(course_Instructors[0]).State);

            //context.SaveChanges();

            //// course_Instructors[0] --> Detached
            //Console.WriteLine(context.Entry(course_Instructors[0]).State);


            #endregion

            #region Insert/Read/Update/Delete => Stud_Course

            Stud_Course[] stud_Course = {
                new Stud_Course() { Course_Id = 1003, Stud_Id = 1002, Grade = 92.5 },
                new Stud_Course() { Course_Id = 1005, Stud_Id = 1003, Grade = 85.0 },
                new Stud_Course() { Course_Id = 1006, Stud_Id = 1004, Grade = 78.3 },
                new Stud_Course() { Course_Id = 1007, Stud_Id = 1005, Grade = 95.8 },
                new Stud_Course() { Course_Id = 1003, Stud_Id = 1006, Grade = 60.0 },
                new Stud_Course() { Course_Id = 1006, Stud_Id = 1002, Grade = 100.0 }
            };

            // Detached
            Console.WriteLine(context.Entry(stud_Course[0]).State);

            context.AddRange(stud_Course); // batching // insert

            // Added
            Console.WriteLine(context.Entry(stud_Course[0]).State);

            context.SaveChanges();

            // Unchanged
            Console.WriteLine(context.Entry(stud_Course[0]).State);


            stud_Course[0].Grade = 77.7; // update

            // stud_Course[0].Grade --> Modified
            Console.WriteLine(context.Entry(stud_Course[0]).State);

            context.SaveChanges();

            // stud_Course[0].Grade --> Unchanged
            Console.WriteLine(context.Entry(stud_Course[0]).State);


            var notGoodGrades = context.Stud_Courses.Where(x => x.Grade < 80).ToList(); // read

            foreach (var stuGrade in notGoodGrades)
                Console.WriteLine($"Student Grade: {stuGrade.Grade}");

            context.Remove(notGoodGrades[0]); // delete the 1st student - course

            // notGoodGrades[0] --> Deleted
            Console.WriteLine(context.Entry(notGoodGrades[0]).State);

            context.SaveChanges();

            // notGoodGrades[0] --> Detached
            Console.WriteLine(context.Entry(notGoodGrades[0]).State);


            #endregion


        }
    }
}
