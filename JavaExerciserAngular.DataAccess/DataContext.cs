using JavaExerciserAngular.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace JavaExerciserAngular.DataAccess;

public class DataContext : DbContext
{
    public DbSet<Exercise> Exercises { get; set; }

    public DataContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exercise>().HasData(
            new Exercise
            {
                Id = 1,
                Name = "AddTwoBinaryNumbers.java",
                Size = 14,
                Techniques = new() { "int, Integer.parseInt()", "Integer.toBinaryString()", "operators - arithmetic", "Scanner", "Scanner.next()", "String" },
                Instructions = "https://www.w3resource.com/java-exercises/basic/index.php\r\n"
                               + "Write a Java program to add two binary numbers.\r\n"
                               + "Input Data:\r\n"
                               + "Input first binary number: 10\r\n"
                               + "Input second binary number: 11\r\n"
                               + "Expected Output\r\n"
                               + "\r\n"
                               + "Sum of two binary numbers: 101\r\n"
                               + "\r\n"
                               + "** HINT: it can be fun to make your own method to convert a number or String to a binary number. But one thing to\r\n"
                               + "** learn on the road to becoming a professional is that Java has LOTS of useful methods already inbuilt. Check\r\n"
                               + "** the wrapper class of int, Integer! :)",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 2,
                Name = "AddTwoNumbers.java",
                Size = 12,
                Techniques = new() { "operators - arithmetic", "Scanner", "Scanner.nextInt()", "System.out.print()", "System.out.println()" },
                Instructions = "https://www.codezclub.com/java-program-sum-two-numbers-input-value-keyboard/\r\n"
                               + "Make a program that lets the user input two numbers, and then shows the result of adding them.\r\n"
                               + "\r\n"
                               + "Example run:\r\n"
                               + "Enter the first number: 3\r\n"
                               + "Enter the second number: 5\r\n"
                               + "The sum is: 8",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 3,
                Name = "AlphabetAnimalGame.java",
                Size = 18,
                Techniques = new() { "foreach-loops", "List", "List.of()", "Scanner", "Scanner.next()", "String.charAt()", "String.length()", "System.exit()", "System.out.print()", "System.out.printf()" },
                Instructions = "https://www.funology.com/alphabet-animal-game/\r\n"
                               + "\r\n"
                               + "There is a game where someone must say an animal name (like 'ant') and the next player has to say the name of an\r\n"
                               + "animal that starts with the last letter of that animal (like 'termite'), a third player should mention an animal\r\n"
                               + "whose name starts with the last letter of THAT (like an 'eagle')\r\n"
                               + "\r\n"
                               + "Goal: create a game where you can enter an animal, and the program responds by naming an animal whose name starts\r\n"
                               + "with the last letter of the animal you mentioned, or \"I don't know any animal whose name starts with '[letter]'.\r\n"
                               + "You win!\" if the computer does not know any animal whose name starts with the correct letter.\r\n"
                               + "\r\n"
                               + "Example run 1:\r\n"
                               + "Name an animal: cat\r\n"
                               + "turtle!\r\n"
                               + "\r\n"
                               + "Example run 2:\r\n"
                               + "Name an animal: dog\r\n"
                               + "I don't know any animal whose name starts with 'g'. You win!\r\n"
                               + "\r\n"
                               + "Hint: some sample animal names: cat, dog, turtle.",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 4,
                Name = "AltPairs.java",
                Size = 18,
                Techniques = new() { "if", "for-loops", "methods", "operators - relational", "parameters", "return ", "String", "String.length()", "String - concatenation" },
                Instructions = "https://codingbat.com/prob/p121596\r\n"
                               + "Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so \"kittens\" yields \"kien\".\r\n"
                               + "\r\n"
                               + "altPairs(\"kitten\") → \"kien\"\r\n"
                               + "altPairs(\"Chocolate\") → \"Chole\"\r\n"
                               + "altPairs(\"CodingHorror\") → \"Congrr\"",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 5,
                Name = "AreaAndPerimeterOfCircle.java",
                Size = 9,
                Techniques = new() { "double", "Math.PI", "operators - arithmetic" },
                Instructions = "https://www.w3resource.com/java-exercises/basic/index.php\r\n"
                               + "Write a Java program to print the area and perimeter of a circle.\r\n"
                               + "Test Data:\r\n"
                               + "Radius = 7.5\r\n"
                               + "Expected Output\r\n"
                               + "Perimeter is = 47.12388980384689\r\n"
                               + "Area is = 176.71458676442586",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 6,
                Name = "AreaAndPerimeterOfRectangle.java",
                Size = 10,
                Techniques = new() { "double", "operators - arithmetic", "System.out.printf()" },
                Instructions = "https://www.w3resource.com/java-exercises/basic/index.php\r\n"
                               + "Write a Java program to print the area and perimeter of a rectangle.\r\n"
                               + "Test Data:\r\n"
                               + "Width = 5.6 Height = 8.5\r\n"
                               + "\r\n"
                               + "Expected Output\r\n"
                               + "Area is 5.6 * 8.5 = 47.60\r\n"
                               + "Perimeter is 2 * (5.6 + 8.5) = 28.20",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 7,
                Name = "AreaOfHexagon.java",
                Size = 11,
                Techniques = new() { "Math.PI", "Math.tan()", "methods", "operators - arithmetic", "parameters", "return ", "Scanner", "Scanner.nextDouble" },
                Instructions = "https://www.w3resource.com/java-exercises/basic/index.php\r\n"
                               + "Write a Java program to compute the area of a hexagon.\r\n"
                               + "Area of a hexagon = (6 * s^2)/(4*tan(π/6))\r\n"
                               + "where s is the length of a side\r\n"
                               + "Input Data:\r\n"
                               + "Input the length of a side of the hexagon: 6.0\r\n"
                               + "Expected Output\r\n"
                               + "\r\n"
                               + "The area of the hexagon is: 93.53074360871938",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 8,
                Name = "AreaOfPolygon.java",
                Size = 14,
                Techniques = new() { "Math.PI", "Math.tan()", "methods", "operators - arithmetic", "parameters", "return ", "Scanner", "Scanner.nextDouble()", "Scanner.nextInt()" },
                Instructions = "https://www.w3resource.com/java-exercises/basic/index.php\r\n"
                               + "Write a Java program to compute the area of a polygon.\r\n"
                               + "Area of a polygon = (n*s^2)/(4*tan(π/n))\r\n"
                               + "where n is n-sided polygon and s is the length of a side\r\n"
                               + "Input Data:\r\n"
                               + "Input the number of sides on the polygon: 7\r\n"
                               + "Input the length of one of the sides: 6\r\n"
                               + "Expected Output\r\n"
                               + "\r\n"
                               + "The area is: 130.82084798405722",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 9,
                Name = "AreaOfTriangleBasedOnSides.java",
                Size = 17,
                Techniques = new() { "Math.sqrt()", "operators - logical", "operators - arithmetic", "Scanner", "Scanner.nextInt()", "System.out.print()" },
                Instructions = "Calculate the area of a triangle based on the length of its sides (you can find the formula after some googling).\r\n"
                               + "If the triangle cannot exist (one side is longer that the other two combined) report so.\r\n"
                               + "\r\n"
                               + "Input 1:\r\n"
                               + "Enter the length of the first side: 2\r\n"
                               + "Enter the length of the second side: 3\r\n"
                               + "Enter the length of the third side: 4\r\n"
                               + "Output 1:\r\n"
                               + "The area of the triangle is: 2.9047375096555625\r\n"
                               + "\r\n"
                               + "Input 2:\r\n"
                               + "Enter the length of the first side: 2\r\n"
                               + "Enter the length of the second side: 3\r\n"
                               + "Enter the length of the third side: 6\r\n"
                               + "\r\n"
                               + "Output 2:\r\n"
                               + "Such a triangle does not exist!\r\n"
                               + "\r\n"
                               + "HINT: if you can't easily find the formula, try https://www.cuemath.com/measurement/area-of-triangle-with-3-sides/",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 10,
                Name = "ArithmeticOperations.java",
                Size = 8,
                Techniques = new() { "operators-arithmetic" },
                Instructions = "https://www.w3resource.com/java-exercises/basic/index.php\r\n"
                               + "Write a Java program to print the result of the following operations.\r\n"
                               + "Test Data:\r\n"
                               + "a. -5 + 8 * 6\r\n"
                               + "b. (55+9) % 9\r\n"
                               + "c. 20 + -3*5 / 8\r\n"
                               + "d. 5 + 15 / 3 * 2 - 8 % 3\r\n"
                               + "Expected Output :\r\n"
                               + "43\r\n"
                               + "1\r\n"
                               + "19\r\n"
                               + "13",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 11,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 12,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 13,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 14,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 15,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 16,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 17,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 18,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 19,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 20,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 21,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 22,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 23,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 24,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 25,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 26,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 27,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 28,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 29,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 30,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 31,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 32,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 33,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 34,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 35,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 36,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 37,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 38,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 39,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 40,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 41,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 42,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 43,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 44,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 45,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 46,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 47,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 48,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 49,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 50,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 51,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 52,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 53,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 54,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 55,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 56,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 57,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 58,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 59,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 60,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 61,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 62,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 63,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 64,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 65,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 66,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 67,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 68,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 69,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 70,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 71,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 72,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 73,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 74,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 75,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 76,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 77,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 78,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 79,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 80,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 81,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 82,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 83,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 84,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 85,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 86,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 87,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 88,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 89,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 90,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 91,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 92,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 93,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 94,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 95,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 96,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 97,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 98,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 99,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 100,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 101,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 102,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 103,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 104,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 105,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 106,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 107,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 108,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 109,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 110,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 111,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 112,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 113,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 114,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 115,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 116,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 117,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 118,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 119,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 120,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 121,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 122,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 123,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 124,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 125,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 126,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 127,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 128,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 129,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 130,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 131,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 132,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 133,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 134,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 135,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 136,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 137,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 138,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 139,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 140,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 141,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 142,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 143,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 144,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 145,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 146,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 147,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 148,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 149,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 150,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 151,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 152,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            },
            new Exercise
            {
                Id = 153,
                Name = "Test",
                Size = 100,
                Techniques = new() { "wow" },
                Instructions = "",
                Status = Status.Default,
                Solution = ""
            });
    }
}