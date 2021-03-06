﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _4._2CSharpPracticePart2
{
    class Student : Person
    {

        private int _energyLevel;
        public int EnergyLevel
        {
            get
            {
                return _energyLevel;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Insufficient energy to perform that action.");
                }
                _energyLevel = value;
            }
        }
        private int _stressLevel;
        public int StressLevel
        {
            get
            {
                return _stressLevel;
            }
            private set
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

        // Static methods cannot reference state properties, but if they don't, they can be run on the class name instead of on an instance.
        public static void Sleep()
        {
            //EnergyLevel += 25;
            //StressLevel -= 30;
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