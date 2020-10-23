using System;
using System.Collections.Generic;
using System.Text;

namespace _4._2CSharpPracticePart2
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _energyLevel;
        private int EnergyLevel
        {
            get
            {
                return _energyLevel;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Insufficient energy to perform that action.");
                }
                _energyLevel = value;
            }
        }
        private int _stressLevel;
        private int StressLevel
        {
            get
            {
                return _stressLevel;
            }
            set
            {
                if (value > 100)
                {
                    throw new Exception("Too much stress to perform that action.");
                }
                // Stress can't go below zero, but don't throw an exception. This is called clamping.
                if (value < 0)
                {
                    _stressLevel = 0;
                }
                else
                {
                    _stressLevel = value;
                }

            }
        }

        public void Sleep()
        {
            EnergyLevel += 25;
            StressLevel -= 30;
        }

        public void DoHomework()
        {
            EnergyLevel -= 20;
            StressLevel += 25;
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            EnergyLevel = 100;
            StressLevel = 0;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - Stress:{StressLevel} Energy:{EnergyLevel}";
        }
    }
}
