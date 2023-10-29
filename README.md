# Java Exerciser With Angular Frontend
To utilise my C# skills a colleague suggested that I rewrite one of his programs in C#.  
His program written in Kotlin can be found here: https://github.com/EWLameijer/CodingExerciseAnalyzer.

## Program overview
The program should function as follows:
- Upon start, display a list of Java exercises with columns for Name, Size, Techniques and Instructions
- Clicking an exercise will open that exercise's page
- On the exercise page show:
  - A back button, to return to the list
  - Exercise instructions
  - A text field for the user to enter their solution
  - A "Show a Solution" button
- Clicking the "Show a Solution" button will
  - Show a solution for the current exercise
  - Show two buttons, the user can decide if their answer is correct and
    click "I did it!" or "I should try again later"
- Clicking either button will open the list page again
- The User's decision is reflected on the list entries with colors
  - Blank/default color for new/unread
  - Yellow for pending/"I should try again later"
  - Green for solved

## Project plan
My plan is to write an ASP.NET API for the backend and make a webpage using angular for the frontend.  
I will decide what models to design and setup a database in a MSSQL server that will store the Java exercises.
Then I will write interfaces with methods for reading and updating the database.  
A Domain library will hold the models and interfaces.
A Data Access library will provide the database connection.
In a Business library I will implement the methods from the interfaces.  
Before writing the logic for those methods I will make a unit-test project to outline what each method is
expected to do. I will then add logic to the methods until all the unit-tests pass.  
When the Business library is functional I'll create an ASP.NET Web API project.
I'll add an ExerciseController that uses the Business methods to handle the exercise data.