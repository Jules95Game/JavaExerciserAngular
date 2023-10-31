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
                Status = ExerciseStatus.Default,
                Solution = "import java.util.Scanner;\r\n"
                           + "\r\n"
                           + "public class AddTwoBinaryNumbers {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        Scanner in = new Scanner(System.in);\r\n"
                           + "\r\n"
                           + "        System.out.print(\"Input first binary number: \");\r\n"
                           + "        String firstNumberAsString = in.next();\r\n"
                           + "        System.out.print(\"Input second binary number: \");\r\n"
                           + "        String secondNumberAsString = in.next();\r\n"
                           + "\r\n"
                           + "        int firstNumber = Integer.parseInt(firstNumberAsString, 2);\r\n"
                           + "        int secondNumber = Integer.parseInt(secondNumberAsString, 2);\r\n"
                           + "\r\n"
                           + "        int sum = firstNumber + secondNumber;\r\n"
                           + "        System.out.println(\"Sum of two binary numbers: \" + Integer.toBinaryString(sum));\r\n"
                           + "    }\r\n"
                           + "}"
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
                Status = ExerciseStatus.Default,
                Solution = "import java.util.Scanner;\r\n"
                           + "\r\n"
                           + "public class AddTwoNumbers {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        Scanner in = new Scanner(System.in);\r\n"
                           + "        System.out.print(\"Enter the first number: \");\r\n"
                           + "        int firstNumber = in.nextInt();\r\n"
                           + "        System.out.print(\"Enter the second number: \");\r\n"
                           + "        int secondNumber = in.nextInt();\r\n"
                           + "        int sum = firstNumber + secondNumber;\r\n"
                           + "        System.out.println(\"The sum is: \" + sum);\r\n"
                           + "    }\r\n"
                           + "}"
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
                Status = ExerciseStatus.Default,
                Solution = "import java.util.List;\r\n"
                           + "import java.util.Scanner;\r\n"
                           + "\r\n"
                           + "public class AlphabetAnimalGame {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        List<String> animals = List.of(\"cat\", \"dog\", \"turtle\");\r\n"
                           + "        System.out.print(\"Name an animal: \");\r\n"
                           + "        Scanner in = new Scanner(System.in);\r\n"
                           + "        String playerAnimal = in.next();\r\n"
                           + "        char lastLetter = playerAnimal.charAt(playerAnimal.length() - 1);\r\n"
                           + "        for (String animal : animals) {\r\n"
                           + "            if (animal.charAt(0) == lastLetter) {\r\n"
                           + "                System.out.println(animal + \"!\");\r\n"
                           + "                System.exit(0);\r\n"
                           + "            }\r\n"
                           + "        }\r\n"
                           + "        System.out.printf(\"I don't know any animal whose name starts with '%c'. You win!\\n\", lastLetter);\r\n"
                           + "    }\r\n"
                           + "}"
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
                Status = ExerciseStatus.Default,
                Solution = "public class AltPairs {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        System.out.println(altPairs(\"kitten\"));\r\n"
                           + "        System.out.println(altPairs(\"Chocolate\"));\r\n"
                           + "        System.out.println(altPairs(\"CodingHorror\"));\r\n"
                           + "    }\r\n"
                           + "\r\n"
                           + "    private static String altPairs(String text) {\r\n"
                           + "        String result = \"\";\r\n"
                           + "\r\n"
                           + "        // Run i by 4 to hit 0, 4, 8, ...\r\n"
                           + "        for (int i = 0; i < text.length(); i += 4) {\r\n"
                           + "            // Append the chars between i and i+2\r\n"
                           + "            int end = i + 2;\r\n"
                           + "            if (end > text.length()) {\r\n"
                           + "                end = text.length();\r\n"
                           + "            }\r\n"
                           + "            result = result + text.substring(i, end);\r\n"
                           + "        }\r\n"
                           + "\r\n"
                           + "        return result;\r\n"
                           + "    }\r\n"
                           + "}"
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
                Status = ExerciseStatus.Default,
                Solution = "public class AreaAndPerimeterOfCircle {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        double radius = 7.5;\r\n"
                           + "        double perimeter = 2 * Math.PI * radius;\r\n"
                           + "        double area = Math.PI * radius * radius;\r\n"
                           + "\r\n"
                           + "        System.out.println(\"Perimeter is = \" + perimeter);\r\n"
                           + "        System.out.println(\"Area is = \" + area);\r\n"
                           + "    }\r\n"
                           + "}"
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
                Status = ExerciseStatus.Default,
                Solution = "public class AreaAndPerimeterOfRectangle {\r\n" +
                "    public static void main(String[] strings) {\r\n" +
                "        final double width = 5.6;\r\n" +
                "        final double height = 8.5;\r\n" +
                "\r\n" +
                "        double area = width * height;\r\n" +
                "        System.out.printf(\"Area is %.1f * %.1f = %.2f\\n\", width, height, area);\r\n" +
                "        double perimeter = 2 * (height + width);\r\n" +
                "        System.out.printf(\"Perimeter is 2 * (%.1f + %.1f) = %.2f\\n\", height, width, perimeter);\r\n" +
                "    }\r\n" +
                "}"
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
                Status = ExerciseStatus.Default,
                Solution = "import java.util.Scanner;\r\n"
                           + "\r\n"
                           + "public class AreaOfHexagon {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        Scanner input = new Scanner(System.in);\r\n"
                           + "        System.out.print(\"Input the length of a side of the hexagon: \");\r\n"
                           + "        double side = input.nextDouble();\r\n"
                           + "        System.out.println(\"The area of the hexagon is: \" + hexagonArea(side));\r\n"
                           + "    }\r\n"
                           + "\r\n"
                           + "    public static double hexagonArea(double side) {\r\n"
                           + "        return 3 * Math.sqrt(3) * side * side / 2;\r\n"
                           + "    }\r\n"
                           + "}"
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
                Status = ExerciseStatus.Default,
                Solution = "import java.util.Scanner;\r\n"
                           + "\r\n"
                           + "public class AreaOfPolygon {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        Scanner input = new Scanner(System.in);\r\n"
                           + "        System.out.print(\"Input the number of sides on the polygon: \");\r\n"
                           + "        int numberOfSides = input.nextInt();\r\n"
                           + "        System.out.print(\"Input the length of one of the sides: \");\r\n"
                           + "        double side = input.nextDouble();\r\n"
                           + "        System.out.println(\"The area is: \" + polygonArea(numberOfSides, side));\r\n"
                           + "    }\r\n"
                           + "\r\n"
                           + "    public static double polygonArea(int ns, double side) {\r\n"
                           + "        return (ns * (side * side)) / (4.0 * Math.tan((Math.PI / ns)));\r\n"
                           + "    }\r\n"
                           + "}"
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
                Status = ExerciseStatus.Default,
                Solution = "import java.util.Scanner;\r\n"
                           + "\r\n"
                           + "public class AreaOfTriangleBasedOnSides {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        Scanner in = new Scanner(System.in);\r\n"
                           + "\r\n"
                           + "        System.out.print(\"Enter the length of the first side: \");\r\n"
                           + "        int a = in.nextInt();\r\n"
                           + "\r\n"
                           + "        System.out.print(\"Enter the length of the second side: \");\r\n"
                           + "        int b = in.nextInt();\r\n"
                           + "\r\n"
                           + "        System.out.print(\"Enter the length of the third side: \");\r\n"
                           + "        int c = in.nextInt();\r\n"
                           + "\r\n"
                           + "        if (a + b > c && a + c > b && b + c > a) {\r\n"
                           + "            double s = (a + b + c) / 2.0;\r\n"
                           + "            double area = Math.sqrt(s * (s - a) * (s - b) * (s - c));\r\n"
                           + "            System.out.println(\"The area of the triangle is: \" + area);\r\n"
                           + "        } else System.out.println(\"Such a triangle does not exist!\");\r\n"
                           + "    }\r\n"
                           + "}"
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
                Status = ExerciseStatus.Default,
                Solution = "public class ArithmeticOperations {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        System.out.println(-5 + 8 * 6);\r\n"
                           + "        System.out.println((55 + 9) % 9);\r\n"
                           + "        System.out.println(20 + -3 * 5 / 8);\r\n"
                           + "        System.out.println(5 + 15 / 3 * 2 - 8 % 3);\r\n"
                           + "    }\r\n"
                           + "}"
            },
            new Exercise
            {
                Id = 11,
                Name = "ArmstrongNumbers.java",
                Size = 18,
                Techniques = new() { "casting", "if", "Math.pow()", "operators - arithmetic", "Scanner", "Scanner.nextInt()", "String.length()", "System.out.print()", "while-loops" },
                Instructions = "https://www.codezclub.com/java-program-check-number-armstrong-or-not/\r\n"
                               + "An Armstrong number is a number that is the sum of its own digits each raised to the power of the number of digits\r\n"
                               + "is equal to the number itself.\r\n"
                               + "\r\n"
                               + "For example:\r\n"
                               + "Three Digits Armstrong number is 153, 1 ^ 3 + 5 ^ 3 + 3 ^ 3 = 153\r\n"
                               + "\r\n"
                               + "Four Digits Armstrong number is 1634, 1 ^ 4 + 6 ^ 4 + 3 ^ 4 + 4 ^ 4 + = 1634\r\n"
                               + "\r\n"
                               + "and So on...\r\n"
                               + "\r\n"
                               + "Example run 1:\r\n"
                               + "Enter the number which you want to check: 1634\r\n"
                               + "This number is an Armstrong number.\r\n"
                               + "\r\n"
                               + "Example run 2:\r\n"
                               + "Enter the number which you want to check: 1635\r\n"
                               + "This number is not an Armstrong number.",
                Status = ExerciseStatus.Default,
                Solution = "import java.util.Scanner;\r\n"
                           + "\r\n"
                           + "public class ArmstrongNumbers {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        System.out.print(\"Enter the number which you want to check: \");\r\n"
                           + "        Scanner in = new Scanner(System.in);\r\n"
                           + "        int originalNumber = in.nextInt();\r\n"
                           + "\r\n"
                           + "        int numberLength = (\"\" + originalNumber).length();\r\n"
                           + "        int armstrongNumber = 0;\r\n"
                           + "        int number = originalNumber;\r\n"
                           + "        while (number > 0) {\r\n"
                           + "            int currentDigit = number % 10;\r\n"
                           + "            number /= 10;\r\n"
                           + "            armstrongNumber += (int) Math.pow(currentDigit, numberLength);\r\n"
                           + "        }\r\n"
                           + "\r\n"
                           + "        if (armstrongNumber == originalNumber) System.out.println(\"This number is an Armstrong number.\");\r\n"
                           + "        else System.out.println(\"This number is not an Armstrong number.\");\r\n"
                           + "    }\r\n"
                           + "}"
            },
            new Exercise
            {
                Id = 12,
                Name = "Array123.java",
                Size = 13,
                Techniques = new() { "Array.index", "Array.length", "arrays", "boolean", "for-loops", "methods", "operators - logical", "operators - relational", "parameters", "return ", "varargs" },
                Instructions = "https://codingbat.com/prob/p136041\r\n"
                               + "Given an array of ints, return true if the sequence of numbers 1, 2, 3 appears in the array somewhere.\r\n"
                               + "You can use an array123(int... numbers) varargs method to automatically convert a sequence of ints to an array\r\n"
                               + "\r\n"
                               + "array123(1, 1, 2, 3, 1) → true\r\n"
                               + "array123(1, 1, 2, 4, 1) → false\r\n"
                               + "array123(1, 1, 2, 1, 2, 3) → true",
                Status = ExerciseStatus.Default,
                Solution = "public class Array123 {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        System.out.println(array123(1, 1, 2, 3, 1));\r\n"
                           + "        System.out.println(array123(1, 1, 2, 4, 1));\r\n"
                           + "        System.out.println(array123(1, 1, 2, 1, 2, 3));\r\n"
                           + "    }\r\n"
                           + "\r\n"
                           + "    private static boolean array123(int... numbers) {\r\n"
                           + "        // Note: iterate < length-2, so can use i+1 and i+2 in the loop\r\n"
                           + "        for (int i = 0; i < numbers.length - 2; i++) {\r\n"
                           + "            if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3) return true;\r\n"
                           + "        }\r\n"
                           + "        return false;\r\n"
                           + "    }\r\n"
                           + "}"
            },
            new Exercise
            {
                Id = 13,
                Name = "Array667.java",
                Size = 18,
                Techniques = new() { "Array.index", "Array.length", "arrays", "for-loops", "if", "methods", "operators - logical", "operators - relational", "parameters", "return " },
                Instructions = "https://codingbat.com/prob/p110019\r\n"
                               + "Given an array of ints, return the number of times that two 6's are next to each other in the array. Also count instances where the second \"6\" is actually a 7.\r\n"
                               + "\r\n"
                               + "array667(new int[]{6, 6, 2}) → 1\r\n"
                               + "array667(new int[]{6, 6, 2, 6}) → 1\r\n"
                               + "array667(new int[]{6, 7, 2, 6}) → 1",
                Status = ExerciseStatus.Default,
                Solution = "public class Array667 {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        System.out.println(array667(new int[]{6, 6, 2}));\r\n"
                           + "        System.out.println(array667(new int[]{6, 6, 2, 6}));\r\n"
                           + "        System.out.println(array667(new int[]{6, 7, 2, 6}));\r\n"
                           + "    }\r\n"
                           + "\r\n"
                           + "    private static int array667(int[] numbers) {\r\n"
                           + "        int count = 0;\r\n"
                           + "        // Note: iterate to length-1, so can use i+1 in the loop\r\n"
                           + "        for (int i = 0; i < numbers.length - 1; i++) {\r\n"
                           + "            if (numbers[i] == 6) {\r\n"
                           + "                if (numbers[i + 1] == 6 || numbers[i + 1] == 7) {\r\n"
                           + "                    count++;\r\n"
                           + "                }\r\n"
                           + "            }\r\n"
                           + "        }\r\n"
                           + "        return count;\r\n"
                           + "    }\r\n"
                           + ""
                           + "}"
            },
            new Exercise
            {
                Id = 14,
                Name = "ArrayCount9.java",
                Size = 19,
                Techniques = new() { "Array.length", "Array.index", "arrays", "foreach-loops", "methods", "parameters", "return " },
                Instructions = "https://codingbat.com/prob/p184031\r\n"
                               + "Given an array of ints, return the number of 9's in the array.\r\n"
                               + "\r\n"
                               + "int[] firstArray = new int[]{1, 2, 9};\r\n"
                               + "arrayCount9(firstArray) → 1\r\n"
                               + "int[] secondArray = new int[]{1, 9, 9};\r\n"
                               + "arrayCount9(secondArray) → 2\r\n"
                               + "int[] thirdArray = new int[]{1, 9, 9, 3, 9};\r\n"
                               + "arrayCount9(thirdArray) → 3",
                Status = ExerciseStatus.Default,
                Solution = "public class ArrayCount9 {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        int[] firstArray = new int[]{1, 2, 9};\r\n"
                           + "        System.out.println(arrayCount9(firstArray));\r\n"
                           + "        int[] secondArray = new int[]{1, 9, 9};\r\n"
                           + "        System.out.println(arrayCount9(secondArray));\r\n"
                           + "        int[] thirdArray = new int[]{1, 9, 9, 3, 9};\r\n"
                           + "        System.out.println(arrayCount9(thirdArray));\r\n"
                           + "    }\r\n"
                           + "\r\n"
                           + "    private static int arrayCount9(int[] numbers) {\r\n"
                           + "        int count = 0;\r\n"
                           + "        for (int number : numbers) {\r\n"
                           + "            if (number == 9) {\r\n"
                           + "                count++;\r\n"
                           + "            }\r\n"
                           + "        }\r\n"
                           + "        return count;\r\n"
                           + "    }\r\n"
                           + "}"
            },
            new Exercise
            {
                Id = 15,
                Name = "ArrayFront9.java",
                Size = 15,
                Techniques = new() { "Array.index", "Array.length", "arrays", "boolean", "for-loops", "if", "methods", "operators - relational", "parameters", "return " },
                Instructions = "https://codingbat.com/prob/p186031\r\n"
                               + "Given an array of ints, return true if one of the first 4 elements in the array is a 9. The array length may be less than 4.\r\n"
                               + "\r\n"
                               + "arrayFront9(new int[]{1, 2, 9, 3, 4}) → true\r\n"
                               + "arrayFront9(new int[]{1, 2, 3, 4, 9}) → false\r\n"
                               + "arrayFront9(new int[]{1, 2, 3, 4, 5}) → false",
                Status = ExerciseStatus.Default,
                Solution = "public class ArrayFront9 {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        System.out.println(arrayFront9(new int[]{1, 2, 9, 3, 4}));\r\n"
                           + "        System.out.println(arrayFront9(new int[]{1, 2, 3, 4, 9}));\r\n"
                           + "        System.out.println(arrayFront9(new int[]{1, 2, 3, 4, 5}));\r\n"
                           + "    }\r\n"
                           + "\r\n"
                           + "    private static boolean arrayFront9(int[] numbers) {\r\n"
                           + "        // First figure the end for the loop\r\n"
                           + "        int end = numbers.length;\r\n"
                           + "        if (end > 4) end = 4;\r\n"
                           + "\r\n"
                           + "        for (int i = 0; i < end; i++) {\r\n"
                           + "            if (numbers[i] == 9) return true;\r\n"
                           + "        }\r\n"
                           + "\r\n"
                           + "        return false;\r\n"
                           + "    }\r\n"
                           + "}"
            },
            new Exercise
            {
                Id = 16,
                Name = "AverageOfThreeNumbers.java",
                Size = 13,
                Techniques = new() { "operators - arithmetic", "Scanner", "Scanner.nextInt()" },
                Instructions = "https://www.w3resource.com/java-exercises/basic/index.php\r\n"
                               + "Write a Java program that takes three numbers as input to calculate and print the average of the numbers",
                Status = ExerciseStatus.Default,
                Solution = "import java.util.Scanner;\r\n"
                           + "\r\n"
                           + "public class AverageOfThreeNumbers {\r\n"
                           + "\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        Scanner in = new Scanner(System.in);\r\n"
                           + "\r\n"
                           + "        System.out.print(\"Input first number: \");\r\n"
                           + "        int firstNumber = in.nextInt();\r\n"
                           + "\r\n"
                           + "        System.out.print(\"Input second number: \");\r\n"
                           + "        int secondNumber = in.nextInt();\r\n"
                           + "\r\n"
                           + "        System.out.print(\"Input third number: \");\r\n"
                           + "        int thirdNumber = in.nextInt();\r\n"
                           + "\r\n"
                           + "        System.out.println(\"The average of the three numbers is: \" + (firstNumber + secondNumber + thirdNumber) / 3);\r\n"
                           + "    }\r\n"
                           + "}"
            },
            new Exercise
            {
                Id = 17,
                Name = "BackAround.java",
                Size = 11,
                Techniques = new() { "methods", "parameters", "return ", "String", "String.length()", "String.substring", "String - concatenation" },
                Instructions = "https://codingbat.com/prob/p161642\r\n"
                               + "Given a string, take the last char and return a new string with the last char added at the front and back, so \"cat\" yields \"tcatt\". The original string will be length 1 or more.\r\n"
                               + "\r\n"
                               + "backAround(\"cat\") → \"tcatt\"\r\n"
                               + "backAround(\"Hello\") → \"oHelloo\"\r\n"
                               + "backAround(\"a\") → \"aaa\"",
                Status = ExerciseStatus.Default,
                Solution = "public class BackAround {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        System.out.println(backAround(\"cat\"));\r\n"
                           + "        System.out.println(backAround(\"Hello\"));\r\n"
                           + "        System.out.println(backAround(\"a\"));\r\n"
                           + "    }\r\n"
                           + "\r\n"
                           + "    private static String backAround(String text) {\r\n"
                           + "        String last = text.substring(text.length() - 1);\r\n"
                           + "        return last + text + last;\r\n"
                           + "    }\r\n"
                           + "}"
            },
            new Exercise
            {
                Id = 18,
                Name = "BigJava.java",
                Size = 9,
                Techniques = new() { "text_blocks" },
                Instructions = "https://www.w3resource.com/java-exercises/basic/index.php\r\n"
                               + "Write a Java program to display the following pattern. Go to the editor\r\n"
                               + "Sample Pattern :\r\n"
                               + "\r\n"
                               + "   J    a   v     v  a\r\n"
                               + "   J   a a   v   v  a a\r\n"
                               + "J  J  aaaaa   V V  aaaaa\r\n"
                               + " JJ  a     a   V  a     a",
                Status = ExerciseStatus.Default,
                Solution = "public class BigJava {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        System.out.println(\"\"\"\r\n"
                           + "                   J    a   v     v  a \r\n"
                           + "                   J   a a   v   v  a a\r\n"
                           + "                J  J  aaaaa   V V  aaaaa\r\n"
                           + "                 JJ  a     a   V  a     a\"\"\");\r\n"
                           + "        // note: this is called the \"text blocks feature\" in Java\r\n"
                           + "        // see also https://www.baeldung.com/java-multiline-string\r\n"
                           + "    }\r\n"
                           + "}"
            },
            new Exercise
            {
                Id = 19,
                Name = "BinaryFractions.java",
                Size = 18,
                Techniques = new() { "casting", "double", "final", "for-loops", "int", "operators - arithmetic", "StringBuilder", "StringBuilder.append()" },
                Instructions = "You may understand binary numbers by now: just like a decimal (base-10) number works like\r\n"
                               + "356 = 3 * 10 ^ 2 + 5 * 10 ^ 1 + 6 * 10 ^ 0 = 3 * 100 + 5 * 10 + 6 = 356\r\n"
                               + "a binary number like 11001 works like\r\n"
                               + "1 * 2 ^ 4 + 1 * 2 ^ 3 + 0 * 2 ^ 2 + 0 * 2 ^ 1 + 1 * 2 ^ 0 = 1 * 16 + 1 * 8 + 0 * 4 + 0 * 2 + 1 = 16 + 8 + 0 + 0 + 1 = 25\r\n"
                               + "\r\n"
                               + "But few people have thought about not-whole numbers. It is quite a logical extension, though...\r\n"
                               + "\r\n"
                               + "decimal: 12.35 = 1 * 10 ^ 1 + 2 * 10 ^ 0 + 3 * 10 ^ -1 + 5 * 10 ^ -2 = 1 * 10 + 2 * 1 + 3 * 0.1 + 5 * 0.01 =\r\n"
                               + "  10 + 2 + 0.3 + 0.05 = 12.35\r\nbinary: 10.1011 = 1 * 2 ^ 1 + 0 * 2 ^ 0 + 1 * 2 ^ -1 + 0 * 2 ^ -2 + 1 * 2 ^ 3 + 1 * 2 ^ 4\r\n"
                               + "  = 1 * 2 + 0 * 1 + 1 * 0.5 + 0 * 0.25 + 1 * 0.125 + 1 * 0.0625 = 2 + 0 + 0.5 + 0 + 0.125 + 0.0625 = 2.6875\r\n"
                               + "\r\n"
                               + "Converting a normal number to a binary is not that hard:\r\n"
                               + "    25 % 2 = 1, 25 / 2 = 12, so currentAnswer = \"1\" (last digit), now calculate 12 binary\r\n"
                               + "    12 % 2 = 0, 12 / 2 = 6, so currentAnswer = \"01\" (last digits), now calculate 6 binary\r\n"
                               + "    6 % 2 = 0, 6 / 2 = 3, so currentAnswer = \"001\" (last digits), now calculate 3 binary\r\n"
                               + "    3 % 2 = 1, 3 / 2 = 1, so currentAnswer = \"1001\" (last digits), now calculate 1 binary\r\n"
                               + "    1 % 2 = 1, 1 / 2 = 0, so currentAnswer = \"11001\" (last digits), and since 0 is left, we're done!\r\n"
                               + "\r\n"
                               + "What about a fraction? We can do the inverse (starting with \"0.\")\r\n"
                               + "    0.6875 * 2 = 1.375, 1.375 rounded down is 1, 1.375 - 1 = 0.375, so currentAnswer is \"0.1\", now calculate 0.375 binary\r\n"
                               + "    0.375 * 2 = 0.75, 0.75 rounded down is 0, 0.75 - 0 = 0.75, so currentAnswer is \"0.10\", now calculate 0.75 binary\r\n"
                               + "    0.75 * 2 = 1.5, 1.5 rounded down is 1, 1.5 - 1 = 0.5, so currentAnswer is \"0.101\", now calculate 0.5 binary\r\n"
                               + "    0.5 * 2 = 1, 1 rounded down is 1, 1 - 1 = 0, so currentAnswer is \"0.1011\", and since 0 is left, we're done!\r\n"
                               + "\r\n"
                               + "Of course, as in decimal notation, 1/3 never ends, binary notation can also produce \"unending\" fractions.\r\n"
                               + "\r\n"
                               + "Create a program that loops from 0.01 to 0.99 and calculates the binary representation of each number. Note that you\r\n"
                               + "may need to cut off the process at say 20 decimal digits, otherwise you can loop forever (or until the imprecision in a\r\n"
                               + "double)\r\n"
                               + "\r\n"
                               + "Note: you may need to tweak this a bit, as double precision addition does not work \"properly\" (0.01 + 0.01 is not\r\n"
                               + "necessarily equal to 0.02... Actually, since doubles are numbers represented by the computer in binary, this exercise\r\n"
                               + "actually explains why this is so!)\r\n"
                               + "\r\n"
                               + "Sample output:\r\n0.01 in binary is 0.00000010100011110101\r\n"
                               + "0.02 in binary is 0.00000101000111101011\r\n"
                               + "0.03 in binary is 0.00000111101011100001\r\n"
                               + "...\r\n"
                               + "0.97 in binary is 0.11111000010100011110\r\n"
                               + "0.98 in binary is 0.11111010111000010100\r\n"
                               + "0.99 in binary is 0.11111101011100001010\r\n"
                               + "\r\n"
                               + "Question: which binary fractions are short (way shorter than 20 digits)? Can you understand why?",
                Status = ExerciseStatus.Default,
                Solution = "public class BinaryFractions {\r\n"
                           + "    final static int MAX_PRECISION = 20;\r\n"
                           + "\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        for (int percentage = 1; percentage < 100; percentage++) {\r\n"
                           + "            StringBuilder numberAsString = new StringBuilder(\"0.\");\r\n"
                           + "            double number = percentage / 100.0;\r\n"
                           + "            double numberRemaining = number;\r\n"
                           + "            for (int precision = 1; precision <= MAX_PRECISION; precision++) {\r\n"
                           + "                if (numberRemaining == 0) break;\r\n"
                           + "                numberRemaining *= 2;\r\n"
                           + "                int digit = (int) numberRemaining;\r\n"
                           + "                numberAsString.append(digit);\r\n"
                           + "                numberRemaining -= digit;\r\n"
                           + "            }\r\n"
                           + "            System.out.println(number + \" in binary is \" + numberAsString);\r\n"
                           + "        }\r\n"
                           + "    }\r\n"
                           + "}"
            },
            new Exercise
            {
                Id = 20,
                Name = "BinaryToDecimal.java",
                Size = 10,
                Techniques = new() { "int", "Integer", "Integer.parseInt()", "Scanner", "Scanner.next()", "String" },
                Instructions = "https://www.w3resource.com/java-exercises/basic/index.php\r\n"
                               + "Write a Java program to convert a binary number to decimal number.\r\n"
                               + "Input Data:\r\n"
                               + "Input a binary number: 100\r\n"
                               + "Expected Output\r\n"
                               + "\r\n"
                               + "Decimal Number: 4\r\n"
                               + "** HINT: Check the Java standard library. You're working with whole numbers here, so Integer (the wrapper class of int,\r\n"
                               + "   as int is a primitive and therefore cannot have any methods) may be of use :)",
                Status = ExerciseStatus.Default,
                Solution = "import java.util.Scanner;\r\n"
                           + "\r\n"
                           + "public class BinaryToDecimal {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        Scanner in = new Scanner(System.in);\r\n"
                           + "\r\n"
                           + "        System.out.print(\"Input a binary number: \");\r\n"
                           + "        String binaryNumberAsString = in.next();\r\n"
                           + "\r\n"
                           + "        int number = Integer.parseInt(binaryNumberAsString, 2);\r\n"
                           + "\r\n"
                           + "        System.out.println(\"Decimal number: \" + number);\r\n"
                           + "    }\r\n"
                           + "}"
            },
            new Exercise
            {
                Id = 21,
                Name = "BinaryToHexadecimal.java",
                Size = 9,
                Techniques = new() { "int", "Integer", "Integer.parseInt()", "Integer.toHexString()", "Scanner", "Scanner.next()", "String", "String.toUpperCase()" },
                Instructions = "https://www.w3resource.com/java-exercises/basic/index.php\r\n"
                               + "Write a Java program to convert a binary number to hexadecimal number.\r\n"
                               + "Input Data:\r\n"
                               + "Input a Binary Number: 1101\r\n"
                               + "Expected Output\r\n"
                               + "\r\n"
                               + "Hexadecimal value: D\r\n"
                               + "** HINT: Check the Java standard library. You're working with whole numbers here, so Integer (the wrapper class of int,\r\n"
                               + "   as int is a primitive and therefore cannot have any methods) may be of use :)",
                Status = ExerciseStatus.Default,
                Solution = "import java.util.Scanner;\r\n"
                           + "\r\n"
                           + "public class BinaryToHexadecimal {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        Scanner in = new Scanner(System.in);\r\n"
                           + "\r\n"
                           + "        System.out.print(\"Input a binary number: \");\r\n"
                           + "        String binaryNumberAsString = in.next();\r\n"
                           + "\r\n"
                           + "        int number = Integer.parseInt(binaryNumberAsString, 2);\r\n"
                           + "\r\n"
                           + "        System.out.println(\"Hexadecimal value: \" + Integer.toHexString(number).toUpperCase());\r\n"
                           + "    }\r\n"
                           + "}"
            },
            new Exercise
            {
                Id = 22,
                Name = "BinaryToOctal.java",
                Size = 10,
                Techniques = new() { "int", "Integer", "Integer.parseInt()", "Integer.toOctalString()", "Scanner", "Scanner.next()", "String" },
                Instructions = "https://www.w3resource.com/java-exercises/basic/index.php\r\n"
                               + "Write a Java program to convert a binary number to a Octal number.\r\n"
                               + "Input Data:\r\n"
                               + "Input a Binary Number: 111\r\n"
                               + "Expected Output\r\n"
                               + "\r\n"
                               + "Octal number: 7\r\n"
                               + "** HINT: Check the Java standard library. You're working with whole numbers here, so Integer (the wrapper class of int,\r\n"
                               + "   as int is a primitive and therefore cannot have any methods) may be of use :)",
                Status = ExerciseStatus.Default,
                Solution = "import java.util.Scanner;\r\n"
                           + "\r\n"
                           + "public class BinaryToOctal {\r\n"
                           + "    public static void main(String[] args) {\r\n"
                           + "        Scanner in = new Scanner(System.in);\r\n"
                           + "\r\n"
                           + "        System.out.print(\"Input a Binary Number: \");\r\n"
                           + "        String binaryNumberAsString = in.next();\r\n"
                           + "\r\n"
                           + "        int number = Integer.parseInt(binaryNumberAsString, 2);\r\n"
                           + "\r\n"
                           + "        System.out.println(\"Octal number: \" + Integer.toOctalString(number));\r\n"
                           + "    }\r\n"
                           + "}"
            });
    }
}