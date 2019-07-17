using System;
using System.Collections.Generic;
using System.Globalization;

namespace student_exercises
{
    public class Cohort {
        //Constructor
        public Cohort (string cohort_name){
            name = cohort_name;
        }
        //Fields and Properties
        public string name{get; set;}
        private List<Student> _students = new List<Student>();
        private List<Instructor> _instructors = new List<Instructor>();
        //Methods
        public void AddToInstructors(Instructor new_instructor){
            _instructors.Add(new_instructor);
        }
        public int numberOfStudents(){
            var numStudents = _students.Count;
            return numStudents;
        }
    }
}