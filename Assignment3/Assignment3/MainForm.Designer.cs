namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.noteGroupBox = new System.Windows.Forms.GroupBox();
            this.noteBox = new System.Windows.Forms.RichTextBox();
            this.removeProblemBtn = new System.Windows.Forms.Button();
            this.problemsListbox = new System.Windows.Forms.ListBox();
            this.vitalsListBox = new System.Windows.Forms.ListBox();
            this.bpLbl = new System.Windows.Forms.Label();
            this.problemsLbl = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.ProblemsLabel = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.patientLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.problemsTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.deleteNoteBtn = new System.Windows.Forms.Button();
            this.updateNoteBtn = new System.Windows.Forms.Button();
            this.addNoteBtn = new System.Windows.Forms.Button();
            this.btnStartNewNote = new System.Windows.Forms.Button();
            this.noteList = new System.Windows.Forms.ListBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.noteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteGroupBox
            // 
            this.noteGroupBox.Controls.Add(this.noteBox);
            this.noteGroupBox.Controls.Add(this.removeProblemBtn);
            this.noteGroupBox.Controls.Add(this.problemsListbox);
            this.noteGroupBox.Controls.Add(this.vitalsListBox);
            this.noteGroupBox.Controls.Add(this.bpLbl);
            this.noteGroupBox.Controls.Add(this.problemsLbl);
            this.noteGroupBox.Controls.Add(this.notesLabel);
            this.noteGroupBox.Controls.Add(this.addBtn);
            this.noteGroupBox.Controls.Add(this.datePicker);
            this.noteGroupBox.Controls.Add(this.ProblemsLabel);
            this.noteGroupBox.Controls.Add(this.lblDob);
            this.noteGroupBox.Controls.Add(this.patientLabel);
            this.noteGroupBox.Controls.Add(this.label1);
            this.noteGroupBox.Controls.Add(this.problemsTextBox);
            this.noteGroupBox.Controls.Add(this.nameTextBox);
            this.noteGroupBox.Controls.Add(this.idTextBox);
            this.noteGroupBox.Controls.Add(this.deleteNoteBtn);
            this.noteGroupBox.Controls.Add(this.updateNoteBtn);
            this.noteGroupBox.Controls.Add(this.addNoteBtn);
            this.noteGroupBox.Location = new System.Drawing.Point(335, 103);
            this.noteGroupBox.Name = "noteGroupBox";
            this.noteGroupBox.Size = new System.Drawing.Size(867, 596);
            this.noteGroupBox.TabIndex = 0;
            this.noteGroupBox.TabStop = false;
            this.noteGroupBox.Text = "Add/Edit/Delete Encounter Note:";
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(27, 265);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(823, 261);
            this.noteBox.TabIndex = 11;
            this.noteBox.Text = "";
            // 
            // removeProblemBtn
            // 
            this.removeProblemBtn.Location = new System.Drawing.Point(526, 163);
            this.removeProblemBtn.Name = "removeProblemBtn";
            this.removeProblemBtn.Size = new System.Drawing.Size(145, 32);
            this.removeProblemBtn.TabIndex = 9;
            this.removeProblemBtn.Text = "Remove Problem";
            this.removeProblemBtn.UseVisualStyleBackColor = true;
            this.removeProblemBtn.Click += new System.EventHandler(this.removeProblemBtn_Click);
            // 
            // problemsListbox
            // 
            this.problemsListbox.FormattingEnabled = true;
            this.problemsListbox.ItemHeight = 16;
            this.problemsListbox.Location = new System.Drawing.Point(526, 79);
            this.problemsListbox.Name = "problemsListbox";
            this.problemsListbox.Size = new System.Drawing.Size(145, 84);
            this.problemsListbox.TabIndex = 8;
            // 
            // vitalsListBox
            // 
            this.vitalsListBox.FormattingEnabled = true;
            this.vitalsListBox.ItemHeight = 16;
            this.vitalsListBox.Location = new System.Drawing.Point(677, 79);
            this.vitalsListBox.Name = "vitalsListBox";
            this.vitalsListBox.Size = new System.Drawing.Size(173, 116);
            this.vitalsListBox.TabIndex = 8;
            // 
            // bpLbl
            // 
            this.bpLbl.AutoSize = true;
            this.bpLbl.Location = new System.Drawing.Point(674, 46);
            this.bpLbl.Name = "bpLbl";
            this.bpLbl.Size = new System.Drawing.Size(120, 16);
            this.bpLbl.TabIndex = 7;
            this.bpLbl.Text = "BP Measurements:";
            // 
            // problemsLbl
            // 
            this.problemsLbl.AutoSize = true;
            this.problemsLbl.Location = new System.Drawing.Point(523, 46);
            this.problemsLbl.Name = "problemsLbl";
            this.problemsLbl.Size = new System.Drawing.Size(68, 16);
            this.problemsLbl.TabIndex = 7;
            this.problemsLbl.Text = "Problems:";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(23, 230);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(58, 20);
            this.notesLabel.TabIndex = 5;
            this.notesLabel.Text = "Notes:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(418, 162);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(127, 128);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 3;
            // 
            // ProblemsLabel
            // 
            this.ProblemsLabel.AutoSize = true;
            this.ProblemsLabel.Location = new System.Drawing.Point(24, 169);
            this.ProblemsLabel.Name = "ProblemsLabel";
            this.ProblemsLabel.Size = new System.Drawing.Size(94, 16);
            this.ProblemsLabel.TabIndex = 2;
            this.ProblemsLabel.Text = "New problems";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(24, 128);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(82, 16);
            this.lblDob.TabIndex = 2;
            this.lblDob.Text = "Date of Birth ";
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Location = new System.Drawing.Point(24, 85);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(88, 16);
            this.patientLabel.TabIndex = 2;
            this.patientLabel.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Note ID";
            // 
            // problemsTextBox
            // 
            this.problemsTextBox.Location = new System.Drawing.Point(127, 163);
            this.problemsTextBox.Name = "problemsTextBox";
            this.problemsTextBox.Size = new System.Drawing.Size(274, 22);
            this.problemsTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(127, 79);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(366, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(127, 40);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(113, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // deleteNoteBtn
            // 
            this.deleteNoteBtn.Location = new System.Drawing.Point(282, 542);
            this.deleteNoteBtn.Name = "deleteNoteBtn";
            this.deleteNoteBtn.Size = new System.Drawing.Size(95, 33);
            this.deleteNoteBtn.TabIndex = 0;
            this.deleteNoteBtn.Text = "Delete Note";
            this.deleteNoteBtn.UseVisualStyleBackColor = true;
            this.deleteNoteBtn.Click += new System.EventHandler(this.deleteNoteBtn_Click);
            // 
            // updateNoteBtn
            // 
            this.updateNoteBtn.Location = new System.Drawing.Point(140, 542);
            this.updateNoteBtn.Name = "updateNoteBtn";
            this.updateNoteBtn.Size = new System.Drawing.Size(110, 33);
            this.updateNoteBtn.TabIndex = 0;
            this.updateNoteBtn.Text = "Update Note";
            this.updateNoteBtn.UseVisualStyleBackColor = true;
            this.updateNoteBtn.Click += new System.EventHandler(this.updateNoteBtn_Click);
            // 
            // addNoteBtn
            // 
            this.addNoteBtn.Location = new System.Drawing.Point(27, 542);
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Size = new System.Drawing.Size(89, 33);
            this.addNoteBtn.TabIndex = 0;
            this.addNoteBtn.Text = "Add Note";
            this.addNoteBtn.UseVisualStyleBackColor = true;
            this.addNoteBtn.Click += new System.EventHandler(this.addNoteBtn_Click);
            // 
            // btnStartNewNote
            // 
            this.btnStartNewNote.Location = new System.Drawing.Point(27, 63);
            this.btnStartNewNote.Name = "btnStartNewNote";
            this.btnStartNewNote.Size = new System.Drawing.Size(128, 34);
            this.btnStartNewNote.TabIndex = 1;
            this.btnStartNewNote.Text = "Start new note";
            this.btnStartNewNote.UseVisualStyleBackColor = true;
            this.btnStartNewNote.Click += new System.EventHandler(this.btnStartNewNote_Click);
            // 
            // noteList
            // 
            this.noteList.FormattingEnabled = true;
            this.noteList.ItemHeight = 16;
            this.noteList.Location = new System.Drawing.Point(27, 114);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(240, 532);
            this.noteList.TabIndex = 2;
            this.noteList.SelectedIndexChanged += new System.EventHandler(this.NoteList_SelectedIndexChanged);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.ForeColor = System.Drawing.Color.Red;
            this.statusLbl.Location = new System.Drawing.Point(24, 662);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 16);
            this.statusLbl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 711);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.noteList);
            this.Controls.Add(this.btnStartNewNote);
            this.Controls.Add(this.noteGroupBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.noteGroupBox.ResumeLayout(false);
            this.noteGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox noteGroupBox;
        private System.Windows.Forms.Button btnStartNewNote;
        private System.Windows.Forms.ListBox noteList;
        private System.Windows.Forms.Button deleteNoteBtn;
        private System.Windows.Forms.Button updateNoteBtn;
        private System.Windows.Forms.Button addNoteBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label ProblemsLabel;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox problemsTextBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.ListBox vitalsListBox;
        private System.Windows.Forms.Label bpLbl;
        private System.Windows.Forms.Label problemsLbl;
        private System.Windows.Forms.ListBox problemsListbox;
        private System.Windows.Forms.Button removeProblemBtn;
        private System.Windows.Forms.RichTextBox noteBox;
    }
}

