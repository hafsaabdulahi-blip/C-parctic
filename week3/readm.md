Chapter 03 – Making Decisions

Week 3 – C# Decision Structures Practice

Overview

This practice demonstrates how to:

- Use "if" statements to make decisions.
- Use "if-else" statements.
- Compare values using relational operators.
- Use logical operators.
- Validate user input.
- Display messages using a MessageBox control.

---

1. Creating Variables

In this step, variables are created to store the user's information.

For example, an integer variable is used to store the student's marks.

The following code shows how the variable is declared in C#.

int marks;

The variable "marks" stores the student's marks.

---

2. Using the if Statement

In this step, the "if" statement is used to check a condition.

If the condition is true, the statements inside the "if" block will execute.

The following code checks whether the student's marks are greater than Chapter 03 – Making Decisions

Week 3 – C# Decision Structures Practice

Overview

This practice demonstrates how to:

Use if statements to make decisions.

Use if-else statements.

Compare values using relational operators.

Use logical operators.

Validate user input.

Display messages using a MessageBox control.

￼

1. Creating Variables

In this step, variables are created to store the user's information.

For example, an integer variable is used to store the student's marks.

The following code shows how the variable is declared in C#.

￼

The variable marks stores the student's marks.

￼

2. Using the if Statement

In this step, the if statement is used to check a condition.

If the condition is true, the statements inside the if block will execute.

The following code checks whether the student's marks are greater than or equal to 50.

￼

If the marks are 50 or above, the program displays "Pass".

￼

3. Using the if-else Statement

In this step, the if-else statement is used to make a decision between two alternatives.

If the condition is true, the if block executes. Otherwise, the else block executes.

￼

The program displays "Pass" if the marks are 50 or above. Otherwise, it displays "Fail".

￼

4. Using Logical Operators

In this step, logical operators are used to combine conditions.

The && operator requires both conditions to be true.

￼

The program displays "Valid Marks" when the marks are between 50 and 100, inclusive.

￼

5. Validating User Input

In this step, the int.TryParse() method is used to check whether the input can be converted into an integer.

￼

The program checks the value entered in textBox1. If it can be converted into an integer, it displays "Valid Number".

Otherwise, it displays an error message.

￼

6. Displaying the Result

After checking the user's input and evaluating the condition, the program displays the result using the MessageBox.Show() method.

For example:

￼

This displays a message box containing the text "Pass".

￼

Conclusion

This practice demonstrates how to use decision structures in C#. It explains how to create variables, use if and if-else statements, apply logical operators, validate input, and display results using a MessageBox control.or equal to 50.

if (marks >= 50)
{
    MessageBox.Show("Pass");
}

If the marks are 50 or above, the program displays "Pass".

---

3. Using the if-else Statement

In this step, the "if-else" statement is used to make a decision between two alternatives.

If the condition is true, the "if" block executes. Otherwise, the "else" block executes.

if (marks >= 50)
{
    MessageBox.Show("Pass");
}
else
{
    MessageBox.Show("Fail");
}

The program displays "Pass" if the marks are 50 or above. Otherwise, it displays "Fail".

---

4. Using Logical Operators

In this step, logical operators are used to combine conditions.

The "&&" operator requires both conditions to be true.

if (marks >= 50 && marks <= 100)
{
    MessageBox.Show("Valid Marks");
}

The program displays "Valid Marks" when the marks are between 50 and 100, inclusive.

---

5. Validating User Input

In this step, the "int.TryParse()" method is used to check whether the input can be converted into an integer.

int marks;

if (int.TryParse(textBox1.Text, out marks))
{
    MessageBox.Show("Valid Number");
}
else
{
    MessageBox.Show("Please Enter a Valid Number");
}

The program checks the value entered in "textBox1". If it can be converted into an integer, it displays "Valid Number".

Otherwise, it displays an error message.

---

6. Displaying the Result

After checking the user's input and evaluating the condition, the program displays the result using the "MessageBox.Show()" method.

For example:

MessageBox.Show("Pass");

This displays a message box containing the text "Pass".

---

Conclusion

This practice demonstrates how to use decision structures in C#. It explains how to create variables, use "if" and "if-else" statements, apply logical operators, validate input, and display results using a MessageBox control.