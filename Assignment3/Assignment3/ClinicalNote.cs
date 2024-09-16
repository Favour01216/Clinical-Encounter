/*
 * Austin B & Favour A
 * 
 * Assignment 3
 * 
 * April 6 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class ClinicalNote
    {
        public List<string> Vitals { get; set; }
        public int NoteID { get; set; }
        public string PatientName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Problems { get; set; }
        public string NoteContent { get; set; }

        public ClinicalNote(int noteID, string patientName, DateTime dateOfBirth, string problems, string noteContent)
        {
            NoteID = noteID;
            PatientName = patientName;
            DateOfBirth = dateOfBirth;
            Problems = problems;
            NoteContent = noteContent;
            Vitals = new List<string>();
        }
    }
}
