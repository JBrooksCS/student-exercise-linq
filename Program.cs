using System;
using System.Collections.Generic;
using System.Linq;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create 4, or more, exercises.
            Exercise lesson1_P = new Exercise("Intro to Python", "Python");
            Exercise lesson2_P = new Exercise("Intermediate Python", "Python");
            Exercise lesson3_P = new Exercise("Advanced Python", "Python");

            Exercise lesson1_C = new Exercise("Intro to C#", "C#");
            Exercise lesson2_C = new Exercise("Intermediate C#", "C#");
            Exercise lesson3_C = new Exercise("Advanced C#", "C#");

            Exercise lesson1_R = new Exercise("Intro to Ruby", "Ruby");
            Exercise lesson2_R = new Exercise("Intermediate Ruby", "Ruby");
            Exercise lesson3_R = new Exercise("Advanced Ruby", "Ruby");
            // Create 3, or more, cohorts.
            Cohort cohort_1 = new Cohort("Cohort_1");
            Cohort cohort_2 = new Cohort("Cohort_2");
            Cohort cohort_3 = new Cohort("Cohort_3");
            // Create 4, or more, students and assign them to one of the cohorts.
            Student student_1 = new Student("Jackie", "Robinson", "JRob", 1);
            Student student_2 = new Student("Bo", "Jackson", "BJack", 2);
            Student student_3 = new Student("Sammy", "Sosa", "SammySosa", 3);
            Student student_4 = new Student("Mark", "McGuire", "BashBro1", 3);
            // Create 3, or more, instructors and... 
            Instructor instructor_1 = new Instructor("Brenda", "Long", "BrendaLong", 1, "Javascript");
            Instructor instructor_2 = new Instructor("Adam", "Schaeffer", "AdamRulez", 2, "C#");
            Instructor instructor_3 = new Instructor("Bryan", "Nilsen", "ByanFknNilsen", 3, "Python");
            // ...assign them to one of the cohorts.
            cohort_1.AddToInstructors(instructor_1);
            cohort_2.AddToInstructors(instructor_2);
            cohort_3.AddToInstructors(instructor_3);
            // Have each instructor assign 2 exercises to each of the students.
            instructor_1.addAssignment(student_1, lesson1_C);
            instructor_1.addAssignment(student_1, lesson2_C);
            instructor_1.addAssignment(student_2, lesson1_C);
            instructor_1.addAssignment(student_2, lesson2_C);
            instructor_1.addAssignment(student_3, lesson1_C);
            instructor_1.addAssignment(student_3, lesson2_C);
            instructor_1.addAssignment(student_3, lesson3_C);

            instructor_2.addAssignment(student_1, lesson1_P);
            instructor_2.addAssignment(student_1, lesson2_P);
            instructor_2.addAssignment(student_2, lesson1_P);
            instructor_2.addAssignment(student_2, lesson2_P);
            instructor_2.addAssignment(student_3, lesson1_P);
            instructor_2.addAssignment(student_3, lesson2_P);

            instructor_3.addAssignment(student_1, lesson1_R);
            instructor_3.addAssignment(student_1, lesson2_R);
            instructor_3.addAssignment(student_2, lesson1_R);
            instructor_3.addAssignment(student_2, lesson2_R);
            instructor_3.addAssignment(student_3, lesson1_R);
            instructor_3.addAssignment(student_3, lesson2_R);
            //List of instructors
            List<Instructor> instructor_list = new List<Instructor>();
            instructor_list.Add(instructor_1);
            instructor_list.Add(instructor_2);
            instructor_list.Add(instructor_3);

            // Create a list of students.Add all of the student instances to it.
            List<Student> student_list = new List<Student>();
            student_list.Add(student_1);
            student_list.Add(student_2);
            student_list.Add(student_3);
            student_list.Add(student_4);
            // Create a list of exercises.Add all of the exercise instances to it.
            List<Exercise> exercise_list = new List<Exercise>();
            exercise_list.Add(lesson1_C);
            exercise_list.Add(lesson2_C);
            exercise_list.Add(lesson3_C);
            exercise_list.Add(lesson1_P);
            exercise_list.Add(lesson2_P);
            exercise_list.Add(lesson3_P);
            exercise_list.Add(lesson1_R);
            exercise_list.Add(lesson2_R);
            exercise_list.Add(lesson3_R);
            //List of Cohorts
            List<Cohort> cohorts_list = new List<Cohort>();
            cohorts_list.Add(cohort_1);
            cohorts_list.Add(cohort_2);
            cohorts_list.Add(cohort_3);

            // List exercises for the C# language by using the Where() LINQ method.
            IEnumerable<Exercise> C_lessons = from exercise in exercise_list
                                              where exercise.language == "C#"
                                              select exercise;
            Console.WriteLine("---- Exercises for the C# Language ----");
            foreach (var lesson in C_lessons)
            {
                Console.WriteLine(lesson.name);
            }
            // List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<Student> students_in_C1 = from student in student_list
                                                  where student.studentsCohort == 1
                                                  select student;
            Console.WriteLine("---- Students in Cohort 1 ----");
            foreach (var student in students_in_C1)
            {
                Console.WriteLine(student.firstName + " " + student.lastName);
            }
            // List instructors in a particular cohort by using the Where() LINQ method.
            IEnumerable<Instructor> instructors_in_C1 = from instructor in instructor_list
                                                        where instructor.instructorsCohort == 1
                                                        select instructor;
            Console.WriteLine("---- Instructors in Cohort 1 ----");
            foreach (var instructor in instructors_in_C1)
            {
                Console.WriteLine(instructor.firstName + " " + instructor.lastName);
            }
            // Sort the students by their last name.
            Console.WriteLine("---- Students Sorted by Last Name ----");
            IEnumerable<Student> students_by_lastname = from student in student_list
                                                        orderby student.lastName
                                                        select student;
            foreach (var student in students_by_lastname)
            {
                Console.WriteLine(student.lastName + ", " + student.firstName);
            }
            // Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            IEnumerable<Student> slacker_students = from student in student_list
                                                    where student.Exercises.Count == 0
                                                    select student;
            Console.WriteLine("---- Students with No Exercises ----");

            foreach (var student in slacker_students)
            {
                Console.WriteLine(student.firstName + " " + student.lastName);
            }
            // Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            IEnumerable<Student> busiest_student = from student in student_list
                                                    orderby student.Exercises.Count descending
                                                    select student;
            Console.WriteLine("---- Students with Most Exercises ----");
            Student busiest = busiest_student.First();
            Console.WriteLine(busiest.firstName + " " + busiest.lastName);
            // How many students in each cohort?
            Console.WriteLine("---- Cohort Headcount ----");

            foreach (var cohort in cohorts_list)
            {
                Console.WriteLine(cohort.numberOfStudents() + " students are in " + cohort.name);
            }
        }
    }
}