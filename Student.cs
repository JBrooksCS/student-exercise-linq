using System;
using System.Collections.Generic;
using System.Globalization;

namespace student_exercises
{
    public class Student
    {

        //constructor
        public Student(string first_name, string last_name, string slack_handle, int cohort)
        {
            firstName = first_name;
            lastName = last_name;
            slackHandle = slack_handle;
            studentsCohort = cohort;
        }
        //Fields and Properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }
        public int studentsCohort { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();
    }
}