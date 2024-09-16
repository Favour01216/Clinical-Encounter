/*
 * Austin B & Favour A
 * 
 * Assignment 3
 * 
 * April 6 2024
 */
using System;

namespace Assignment3
{
    internal class VitalMeasurement
    {
        public string Type { get; set; }
        public int Value1 { get; set; } 
        public int Value2 { get; set; } 
        public string Units { get; set; }
        public bool IsHigh { get; set; }
        public bool IsLow { get; set; }

        public VitalMeasurement(string type, string value, string units)
        {
            Type = type;
            Units = units;

            if (type == "BP")
            {
                var parts = value.Split('/');
                if (parts.Length == 2 && int.TryParse(parts[0], out int systolic) && int.TryParse(parts[1], out int diastolic))
                {
                    Value1 = systolic;
                    Value2 = diastolic;
                    IsHigh = systolic > 130 || diastolic > 80;
                    IsLow = systolic < 90 || diastolic < 60;
                }
                else
                {
                    Value1 = Value2 = 0;
                    IsHigh = IsLow = false;
                }
            }
            else
            {
                if (int.TryParse(value, out int parsedValue))
                {
                    Value1 = parsedValue;
                }
                else
                {
                    Value1 = 0;
                }
                IsHigh = IsMeasurementHigh(Value1, type);
                IsLow = IsMeasurementLow(Value1, type);
            }
        }

        private bool IsMeasurementHigh(int value, string type)
        {
            if (type == "HR")
            {
                return value > 100;
            }
            else
            {
                return false;
            }
        }

        private bool IsMeasurementLow(int value, string type)
        {
            if (type == "HR")
            {
                return value < 60; 
            }
            else
            {
                return false; 
            }
        }
    }
}
