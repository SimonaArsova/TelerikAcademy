using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Discipline: IDiscipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numOfLectures, int numOfEx)
        {
            this.Name = name;
            this.NumberOfExercises = numOfEx;
            this.NumberOfLectures = numOfLectures;
        } 


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("String can't be emtpty!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The count of lectures can't be negative!");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The count of lectures can't be negative!");
                }
                this.numberOfExercises = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Discipline: {0}, Number of lectures: {1}, Number of exercises: {2}", this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }


}
