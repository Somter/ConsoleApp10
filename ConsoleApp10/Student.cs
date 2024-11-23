using ConsoleApp10;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ConsoleApp10
{
    [Serializable]
    [DataContract]
    public class Student : Person, IComparable
    {
        [DataMember]
        public double Average { get; set; } = 0.0;
        [DataMember]
        public int NumberOfGroup { get; set; } = 0;

        public Student() : base() { }

        public Student(string name, string surname, int age, string phone, double average, int numberOfGroup)
            : base(name, surname, phone, age)
        {
            Average = average;
            NumberOfGroup = numberOfGroup;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"Average - {Average}\nNumber of group - {NumberOfGroup}");
        }

        //Сортировка по имени (по умолчанию) с помощью IComparable
        public int CompareTo(object obj) 
        {
            if (obj is Student)
                return Name.CompareTo((obj as Student).Name);

            throw new NotImplementedException();
        }

        [Serializable]
        // сортировка по возрасту с помощью IComparer (встроенный класс)
        public class SortByAge : IComparer 
        {
            int IComparer.Compare(object obj1, object obj2)     
            {
                if (obj1 is Student && obj2 is Student)
                    return (obj1 as Student).Age.CompareTo((obj2 as Student).Age);       

                throw new NotImplementedException();
            }
        }

        [Serializable]
        // сортировка по фамилии с помощью IComparer (встроенный класс)
        public class SortBySurname : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Student && obj2 is Student)
                    return (obj1 as Student).Surname.CompareTo((obj2 as Student).Surname);

                throw new NotImplementedException();
            }
        }

    }
}
