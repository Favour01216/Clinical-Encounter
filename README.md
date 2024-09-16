# Clinical Encounter Notes Application

## Overview

This project is a basic application to manage clinical encounter notes, enabling users to **create**, **edit**, **view**, and **delete** notes stored in a text file.

## Features

- **Create, Edit, View, and Delete Clinical Notes**

  - Display existing notes in a ListBox with patient name and note ID.
  - Edit or delete selected notes or create new ones.

- **Problem List Management**

  - Add and delete patient problems (e.g., Diabetes) associated with the clinical note.

- **Vitals Extraction with Regex**

  - Automatically extract and display vital signs (e.g., Blood Pressure, Heart Rate) from note text.
  - Highlight high or low readings in a dedicated ListBox.

- **File I/O**
  - Store all notes and problems in a text file.
  - Automatically save changes (add, update, delete) to the file in real-time.

## Technologies Used

- **C# WinForms** for the graphical user interface (GUI).
- **Object-Oriented Programming (OOP)** to structure the code using classes.
- **File I/O** for reading and writing notes to a text file.
- **Regular Expressions (Regex)** to extract vital signs from clinical note content.

## How to Run

- Open the project in your preferred C# IDE (e.g., Visual Studio).
- Build and run the application to start managing clinical encounter notes.
