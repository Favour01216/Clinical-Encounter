/*
 * Austin B & Favour A
 * 
 * Assignment 3
 * 
 * April 6 2024
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private ClinicalNoteManager noteManager;

        public MainForm()
        {
            InitializeComponent();
            noteManager = new ClinicalNoteManager("notes.txt", statusLbl, nameTextBox, datePicker, noteBox, noteList, idTextBox, problemsListbox);
            idTextBox.Text = GenerateNextNoteID().ToString();
            noteBox.TextChanged += NoteBox_TextChanged;
            Load += MainForm_Load;
            noteList.SelectedIndexChanged += NoteList_SelectedIndexChanged; 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotes();
            EnableNotesList(); 
            DisableControls();
        }

        private void LoadNotes()
        {
            noteList.Items.Clear();
            var notes = noteManager.ReadNotesFromFile();
            foreach (var note in notes)
            {
                noteList.Items.Add($"{note.PatientName} (Note ID: {note.NoteID})");
            }
        }

        private int GenerateNextNoteID()
        {
            var notes = noteManager.ReadNotesFromFile();
            return notes.Count == 0 ? 1 : notes.Max(note => note.NoteID) + 1;
        }

        private void NoteBox_TextChanged(object sender, EventArgs e)
        {
            var noteContent = noteBox.Text;
            vitalsListBox.Items.Clear();
            AddVitalsFromNoteContent(noteContent);
        }
        private void EnableAllControls()
        {
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
        }

        private void EnableControlsForExistingNote()
        {
            EnableAllControls();
            addNoteBtn.Enabled = false; // Disable Add Note button
        }
        private void AddVitalsFromNoteContent(string noteContent)
        {
            var lines = noteContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var measurements = line.Split(':');
                if (measurements.Length == 2)
                {
                    var type = measurements[0];
                    var valueStr = measurements[1].Trim();
                    var vital = new VitalMeasurement(type, valueStr, type == "HR" ? "bpm" : "mmHg"); // Use "bpm" for heart rate
                    string status = vital.IsHigh ? "(High)" : vital.IsLow ? "(Low)" : "";
                    vitalsListBox.Items.Add($"{type}: {valueStr} {vital.Units} {status}");
                }
            }
        }

        private void NoteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noteList.SelectedIndex != -1)
            {
                EnableControlsForExistingNote();
                var selectedItem = noteList.SelectedItem.ToString();
                int startIndex = selectedItem.LastIndexOf(" (Note ID: ") + " (Note ID: ".Length;
                int endIndex = selectedItem.LastIndexOf(")");
                string noteIDStr = selectedItem.Substring(startIndex, endIndex - startIndex).Trim();
                int noteID;
                if (int.TryParse(noteIDStr, out noteID))
                {
                    var notes = noteManager.ReadNotesFromFile();
                    var selectedNote = notes.FirstOrDefault(note => note.NoteID == noteID);
                    if (selectedNote != null)
                    {
                        idTextBox.Text = selectedNote.NoteID.ToString();
                        nameTextBox.Text = selectedNote.PatientName;
                        datePicker.Value = selectedNote.DateOfBirth;
                        noteBox.Text = selectedNote.NoteContent;
                        AddVitalsFromNoteContent(selectedNote.NoteContent); // Populate vitals list
                    }
                }
                else

                {  
                    DisableControls();
                    
                   
                    statusLbl.Text = "Invalid note ID format.";
                }
            }
        }


        private void btnStartNewNote_Click(object sender, EventArgs e)
        {
            idTextBox.Text = GenerateNextNoteID().ToString();
            nameTextBox.Clear();
            datePicker.Value = DateTime.Now;
            noteBox.Clear();
            EnableControls();
        }

        private void addNoteBtn_Click(object sender, EventArgs e)
        {
            noteManager.AddNote();
            LoadNotes();
            DisableControls();
        }

        private void updateNoteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Code to update the selected note
                noteManager.UpdateNote();
                LoadNotes();
                DisableControlsExceptStartNewNoteAndNoteList();
            }
            catch (Exception ex)
            {
                statusLbl.Text = $"Error updating note: {ex.Message}";
            }
        }

        private void DisableControlsExceptStartNewNoteAndNoteList()
        {
            foreach (Control control in Controls)
            {
                // Exclude Start New Note button and note list list box from being disabled
                if (control != btnStartNewNote && control != noteList)
                {
                    control.Enabled = false;
                }
            }
        }
        private void deleteNoteBtn_Click(object sender, EventArgs e)
        {
            noteManager.DeleteNote();
            LoadNotes();
            DisableControls();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           
                if (!int.TryParse(idTextBox.Text, out int noteID))
                {
                    
                    return;
                }

                string problem = problemsTextBox.Text;
                problemsListbox.Items.Add(problem);

                noteManager.AddProblem(noteID, problem); 
                problemsTextBox.Clear(); 
            

        }

        private void removeProblemBtn_Click(object sender, EventArgs e)
        {
            if (problemsListbox.SelectedIndex != -1)
            {
                // Remove the selected item from the problems ListBox
                problemsListbox.Items.RemoveAt(problemsListbox.SelectedIndex);
            }
            else
            {
                // If no item is selected, display a message indicating that no item is selected
                MessageBox.Show("Please select a problem to remove.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void EnableControls()
        {
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
        }

        private void DisableControls()
        {
            foreach (Control control in Controls)
            {
                // Exclude Start New Note button and note list list box from being disabled
                if (control != btnStartNewNote && control != noteList)
                {
                    control.Enabled = false;
                }
            }
        }

        private void EnableNotesList()
        {
            noteList.Enabled = true;
        }

        
    }
}
