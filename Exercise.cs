
using System;
using System.Collections.Generic;
using System.Globalization;

namespace student_exercises
{
    public class Exercise{
        //constructor
        public Exercise (string exerciseName, string exerciseLanguage){
            name = exerciseName;
            language = exerciseLanguage;
        }
        //Fields and Properties
        public string name{get; set;}
        public string language {get; set;}
    }
}