//Task 2.Coherent is developing a training management system. Each training consists of a set of
//lectures and practical exercises. It is necessary to create classes to represent the following
//entities: training, lecture, practical lesson.
//All specified entities have a text description (this is an arbitrary string, possibly empty or equal
//to null).
//A lecture has a topic (an arbitrary string, possibly empty or equal to null), practical lesson - a
//link to a task condition (an arbitrary string, possibly empty or equal to null) and a link to a
//solution (an arbitrary string, possibly empty or equal to null).
//The training should store a set of lectures and practice letures in an internal array and have an
//Add() method for adding a lecture or practice session.In addition, the training must have an
//IsPractical() method - it returns true if the training contains only practical lessons.
//Implement the Clone() instance method in the training class to clone the training.

//Caution: Deep cloning should be performed, not shallow cloning.
//Test the classes in a console application.

using System;
using System.Collections.Generic;
using System.Reflection;
using Task2_TMS;


namespace TMS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Training testing
            var winterTraining = new Training("Winter training");

            Console.WriteLine("Welcome to " + winterTraining.Description);

            Practical_Lesson lesson1 = new Practical_Lesson("Link to first task",
                                                            "Link to second solution",
                                                            "In first task we test if cloning is working or not");
            //Adding lesson to winterTraining
            winterTraining.Add(lesson1);
            Console.WriteLine("\nAdded first lesson");
            //Checking if training contains practical lesson
            Console.WriteLine("Does winter training only contains practical lessons: "
                              + winterTraining.IsPractical());

            //Creating lecture
            Lecture lecture1 = new Lecture("First lecture", "C#");

            //Adding lecture to winter training
            winterTraining.Add(lecture1);
            Console.WriteLine("\nAdded first lecture");
            //Checking if training still contains practical lessons after adding lecture to training
            Console.WriteLine("After adding lecture to winter training will it still contain only practical lessons: "
                              + winterTraining.IsPractical());

            //Cloning winter training list
            Console.WriteLine("\nCloning made");
            var clonedWinterTraining = (Training)winterTraining.Clone();
            //Practical lesson cloning and comparing
            var clonedPracticalLesson = (Practical_Lesson)clonedWinterTraining.trainingList[0];

            Console.Write("Checking if the cloning works by comparing pratical lessons link to task: ");
            Console.WriteLine(clonedPracticalLesson.LinkToTask == "Link to first task");

            //Lecture cloning and comparing
            var clonedLecture = (Lecture)clonedWinterTraining.trainingList[1];

            Console.Write("\nChecking if the cloning works by comparing lecture programming language: ");
            Console.Write(clonedLecture.Description == "C#");

            Console.ReadLine();
        }
    }
}