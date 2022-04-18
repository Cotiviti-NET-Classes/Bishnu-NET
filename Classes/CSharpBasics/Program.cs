using System;
using LearningBasics;

Console.Write("Hello World!");

Student s1 = new() {
    name = "Bishnu",
    semester = "2nd",
    mobileNumber = "9857483948"
};

Student s2 = new Student();
s1.name = "Ram";
s1.semester = "3rd";
s1.mobileNumber = "9855583948";

Student s3 = new Student("Hari", "1st", "8729034823");
