/*
 * Austin B & Favour A
 * 
 * Assignment 3
 * 
 * April 6 2024
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment3
{
    internal class ClinicalNoteManager
    {
        private string filePath;
        private Label statusLbl;
        private TextBox txtPatientName;
        private DateTimePicker dtpDateOfBirth;
        private RichTextBox rtbNoteContent;
        private ListBox listBoxNotes;
        private TextBox txtNoteID;
        private ListBox problemsListbox;

        public ClinicalNoteManager(string filePath, Label statusLbl, TextBox txtPatientName, DateTimePicker dtpDateOfBirth, RichTextBox rtbNoteContent, ListBox listBoxNotes, TextBox txtNoteID, ListBox problemsListbox)
        {
            this.filePath = filePath;
            this.statusLbl = statusLbl;
            this.txtPatientName = txtPatientName;
            this.dtpDateOfBirth = dtpDateOfBirth;
            this.rtbNoteContent = rtbNoteContent;
            this.listBoxNotes = listBoxNotes;
            this.txtNoteID = txtNoteID;
            this.problemsListbox = problemsListbox;
        }

        public void StartNewNote()
        {
            txtPatientName.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            rtbNoteContent.Clear();
            txtPatientName.Focus();
            int newID = GetNextNoteID();
            txtNoteID.Text = newID.ToString();
        }

        public void AddNote()
        {
            try
            {
                int noteID = int.Parse(txtNoteID.Text);
                string patientName = txtPatientName.Text;
                DateTime dateOfBirth = dtpDateOfBirth.Value;
                string problems = GetProblemsForPatient(patientName);
                string noteContent = rtbNoteContent.Text;

                ClinicalNote newNote = new ClinicalNote(noteID, patientName, dateOfBirth, problems, noteContent);
                List<ClinicalNote> notes = ReadNotesFromFile();
                notes.Add(newNote);
                WriteNotesToFile(notes);
                UpdateListBox();
                statusLbl.Text = "Note added successfully.";
            }
            catch (Exception ex)
            {
                statusLbl.Text = $"Error adding note: {ex.Message}";
            }
        }

        public void UpdateNote()
        {
            try
            {
                int noteID = int.Parse(txtNoteID.Text);
                string patientName = txtPatientName.Text;
                DateTime dateOfBirth = dtpDateOfBirth.Value;
                string problems = GetProblemsForPatient(patientName);
                string noteContent = rtbNoteContent.Text;

                ClinicalNote updatedNote = new ClinicalNote(noteID, patientName, dateOfBirth, problems, noteContent);
                List<ClinicalNote> notes = ReadNotesFromFile();
                int index = notes.FindIndex(note => note.NoteID == noteID);
                if (index != -1)
                {
                    notes[index] = updatedNote;
                    WriteNotesToFile(notes);
                    statusLbl.Text = "Note updated successfully.";
                    UpdateListBox(); // Reload notes after updating
                }
                else
                {
                    statusLbl.Text = "Note not found.";
                }
            }
            catch (Exception ex)
            {
                statusLbl.Text = $"Error updating note: {ex.Message}";
            }
        }

        public void DeleteNote()
        {
            try
            {
                int noteID = int.Parse(txtNoteID.Text);
                List<ClinicalNote> notes = ReadNotesFromFile();
                int index = notes.FindIndex(note => note.NoteID == noteID);
                if (index != -1)
                {
                    notes.RemoveAt(index);
                    WriteNotesToFile(notes);
                    UpdateListBox();
                    statusLbl.Text = "Note deleted successfully.";
                }
                else
                {
                    statusLbl.Text = "Note not found.";
                }
            }
            catch (Exception ex)
            {
                statusLbl.Text = $"Error deleting note: {ex.Message}";
            }
        }

        public void AddProblem(int noteID, string problem)
        {
            try
            {
                List<ClinicalNote> notes = ReadNotesFromFile();
                ClinicalNote note = notes.FirstOrDefault(n => n.NoteID == noteID);
                if (note != null)
                {
                    note.Problems += ";" + problem;

                    WriteNotesToFile(notes);
                    UpdateListBox(); // Update the listbox to reflect the changes
                    statusLbl.Text = "Problem added successfully.";
                }
                else
                {
                    statusLbl.Text = "Note not found.";
                }
            }
            catch (Exception ex)
            {
                statusLbl.Text = $"Error adding problem: {ex.Message}";
            }
        }

        public void RemoveProblem(int noteID, string problem)
        {
            try
            {
                List<ClinicalNote> notes = ReadNotesFromFile();
                int index = notes.FindIndex(note => note.NoteID == noteID);
                if (index != -1)
                {
                    // Remove the problem from the existing problems for the note
                    string[] currentProblems = notes[index].Problems.Split(';');
                    notes[index].Problems = string.Join(";", currentProblems.Where(p => p != problem));
                    WriteNotesToFile(notes);
                    statusLbl.Text = "Problem removed successfully.";
                }
                else
                {
                    statusLbl.Text = "Note not found.";
                }
            }
            catch (Exception ex)
            {
                statusLbl.Text = $"Error removing problem: {ex.Message}";
            }
        }

        private int GetNextNoteID()
        {
            List<ClinicalNote> notes = ReadNotesFromFile();
            int maxID = notes.Count > 0 ? notes.Max(note => note.NoteID) : 0;
            return maxID + 1;
        }

        private string GetProblemsForPatient(string patientName)
        {
            List<string> problems = new List<string>();

            List<ClinicalNote> notes = ReadNotesFromFile();

            foreach (var note in notes)
            {
                if (note.PatientName == patientName)
                {
                    string[] patientProblems = note.Problems.Split(';');
                    foreach (var problem in patientProblems)
                    {
                        problems.Add(problem);
                    }
                }
            }

            return string.Join(";", problems);
        }

        public List<ClinicalNote> ReadNotesFromFile()
        {
            List<ClinicalNote> notes = new List<ClinicalNote>();

            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] noteData = line.Split('|');

                        if (noteData.Length == 5)
                        {
                            int noteID;
                            if (int.TryParse(noteData[0], out noteID))
                            {
                                string patientName = noteData[1];
                                DateTime dateOfBirth;
                                if (DateTime.TryParse(noteData[2], out dateOfBirth))
                                {
                                    string problems = noteData[3];
                                    string noteContent = noteData[4].Replace(";", Environment.NewLine);
                                    notes.Add(new ClinicalNote(noteID, patientName, dateOfBirth, problems, noteContent));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                statusLbl.Text = $"Error reading notes from file: {ex.Message}";
            }

            return notes;
        }

        private void WriteNotesToFile(List<ClinicalNote> notes)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (ClinicalNote note in notes)
                    {
                        string noteContent = note.NoteContent.Replace(Environment.NewLine, ";");
                        writer.WriteLine($"{note.NoteID}|{note.PatientName}|{note.DateOfBirth.ToShortDateString()}|{note.Problems}|{noteContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                statusLbl.Text = $"Error writing notes to file: {ex.Message}";
            }
        }

        private void UpdateListBox()
        {
            listBoxNotes.Items.Clear();
            List<ClinicalNote> notes = ReadNotesFromFile();
            foreach (ClinicalNote note in notes)
            {
                listBoxNotes.Items.Add($"{note.PatientName} (Note ID: {note.NoteID})");

                if (note.NoteID == int.Parse(txtNoteID.Text))
                {
                    problemsListbox.Items.Clear();
                    foreach (var problem in note.Problems)
                    {
                        problemsListbox.Items.Add(problem);
                    }
                }
            }
        }
    }
}
