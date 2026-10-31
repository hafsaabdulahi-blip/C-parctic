Discourse Chapter 4

Week 4 - C# Loops, Files, and Random Numbers Practice

Overview

This practice demonstrates how to:

- Use the "while" loop to repeat statements.
- Use the "for" loop to control the number of repetitions.
- Use the "do-while" loop to execute statements before testing a condition.
- Use increment and decrement operators.
- Write data to a text file and read data from a text file.
- Generate random numbers.
- Use the Load event in a Windows Form application.

---

1. Using the While Loop

In this step, a "while" loop is used to repeat a statement as long as a Boolean expression is true.

The loop checks the condition before executing the statements inside the loop.

The following C# code demonstrates how the "while" loop works.

int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}

In this example, the message box displays "Hello" five times because the counter starts at 0 and increases by 1 each time the loop executes.

---

2. Using Increment and Decrement Operators

In this step, the increment ("++") and decrement ("--") operators are used to increase or decrease the value of a variable.

The following C# code demonstrates these operators.

int count = 0;

count++;

count--;


The "count++" statement increases the value of "count" by 1, while "count--" decreases its value by 1.

---

3. Using the For Loop

In this step, a "for" loop is used when the number of repetitions is controlled by a counter variable.

The "for" loop contains three expressions:

- Initialization: sets the initial value of the counter.
- Test: checks whether the condition is true.
- Update: changes the counter value.

The following C# code demonstrates the "for" loop.

for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}

In this example, the message box displays "Hello" five times.

---

4. Using the Do-While Loop

In this step, a "do-while" loop is used to execute statements before checking the Boolean expression.

Unlike the "while" loop, the "do-while" loop executes its statements at least once.

The following C# code demonstrates the "do-while" loop.

int number = 1;

do
{
    MessageBox.Show(number.ToString());
}
while (number < 0);

In this example, the message box displays the number 1 once because the condition is checked after the statement executes.

---

5. Writing Data to a Text File

In this step, a "StreamWriter" object is used to write data to a text file.

The "File.CreateText()" method creates the file, and the "WriteLine()" method writes data to the file.

The following C# code demonstrates how to write data to a text file.

StreamWriter outputFile;

outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");

outputFile.Close();

In this example, three course names are written to the "courses.txt" file. The file is then closed.

---

6. Reading Data from a Text File

In this step, a "StreamReader" object is used to read data from a text file.

The "File.OpenText()" method opens the file, and the "ReadLine()" method reads a line of text.

The following C# code demonstrates how to open a text file.

StreamReader inputFile;

inputFile = File.OpenText("students.txt");

string line = inputFile.ReadLine();

inputFile.Close();

In this example, the program opens the "students.txt" file, reads one line, and closes the file.

---

7. Generating Random Numbers

In this step, the "Random" class is used to generate random numbers.

The "Next()" method generates a random integer, while the "NextDouble()" method generates a random floating-point number between 0.0 and 1.0.

The following C# code demonstrates how to generate random numbers.

Random rand = new Random();

int number1 = rand.Next();

double number2 = rand.NextDouble();

In this example, "number1" stores a random integer, and "number2" stores a random floating-point number.

---

8. Using the Load Event

In this step, the Load event is used to execute code when the Windows Form is loaded.

The following C# code demonstrates how to display a message when the form starts.

private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}

In this example, the message box appears when the form is launched.

---

Conclusion

This practice demonstrates how to use loops, increment and decrement operators, text files, random numbers, and the Load event in C#.

These concepts help programmers repeat statements, store and retrieve data, generate random values, and execute code when a form starts.