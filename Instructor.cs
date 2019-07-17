using System;
using System.Collections.Generic;
using System.Globalization;

namespace student_exercises
{
    public class Instructor
    {
        //Constructor
        public Instructor(string first_name, string last_name, string slack_handle, int cohort, string specialty)
        {
            firstName = first_name;
            lastName = last_name;
            slackHandle = slack_handle;
            instructorsCohort = cohort;
            instructorSpecialty = specialty;
        }
        //Fields and Properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }
        public int instructorsCohort { get; set; }
        public string instructorSpecialty { get; set; }
        //Methods
        public void addAssignment(Student student, Exercise exercise)
        {
            //Assign an exercise to a student
            student.Exercises.Add(exercise);
        }
    }
}