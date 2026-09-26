<!-- Version 2: revised and expanded Week 2 README -->
# Discourse Chapter 2

# Week 2 - C# Processing Data

## Overview
This week's practice and lessons introduce processing data in C# Windows
Forms. We learned how to receive information from users, store it in
variables, perform calculations, display results, handle unexpected
input, and use Visual Studio's debugging tools.

Topics covered:

-   Read input with TextBox controls
-   Declare and use variables
-   Work with string and numeric data types
-   Perform arithmetic calculations
-   Convert input strings to numeric values
-   Display and format numeric output
-   Handle exceptions with `try-catch`
-   Use named constants and class-level fields
-   Use the `Math` class
-   Configure GUI controls and tab order
-   Find logic errors with the Visual Studio debugger

------------------------------------------------------------------------

## 1. Reading Input with TextBox Controls

A `TextBox` is a Windows Forms control that lets a user enter
information using the keyboard. The value entered by the user is stored
in the control's `Text` property.

For example, the following statement clears a TextBox:

``` csharp
textBox1.Clear();
```

We can also clear it by assigning an empty string:

``` csharp
textBox1.Text = string.Empty;
```

**Key point:** A TextBox stores its input as a string, even when the
user types digits.

------------------------------------------------------------------------

## 2. Creating and Using Variables

A variable is a named storage location in memory. We declare a variable
before using it, and its data type specifies what kind of value it can
hold.

General syntax:

``` csharp
DataType variableName;
```

For example:

``` csharp
string firstName;
```

A variable should have a meaningful name. Names begin with a letter or
underscore, cannot contain spaces, and cannot be reserved C# keywords.

### Initializing variables

Initializing means assigning a starting value to a variable. A local
variable must be assigned a value before it is used.

``` csharp
string productDescription = "Jamhuuriya University";
```

We can declare multiple variables of the same type in one statement:

``` csharp
string firstName, lastName, middleName;
```

### String variables and concatenation

A `string` stores a sequence of characters, such as a name or
description. The `+` operator joins strings together; this is called
concatenation.

``` csharp
string firstName = "Amina";
string lastName = "Ali";
string fullName = firstName + " " + lastName;

fullNameLabel.Text = fullName;
```

The space string (`" "`) separates the two names. A string can also be
shown in a message box:

``` csharp
MessageBox.Show(fullName);
```

### Local variable scope

A local variable is declared inside a method and can only be accessed
within that method. Its scope is the part of the program where it can be
used. A local variable exists while its method is executing.

------------------------------------------------------------------------

## 3. Numeric Data Types

When a program needs to store numbers for calculations, it uses a
numeric data type. The slides introduce these commonly used types:

  ------------------------------------------------------------------------------
  Type                    What it stores          Example
  ----------------------- ----------------------- ------------------------------
  `int`                   Whole numbers           `int hoursWorked = 40;`

  `double`                Real numbers, including `double temperature = 87.6;`
                          fractional values       

  `decimal`               Real numbers with       `decimal payRate = 28.75m;`
                          greater precision,      
                          often used for          
                          financial values        
  ------------------------------------------------------------------------------

A numeric literal is a number written directly in code. Integer literals
such as `40` are treated as `int`; a number with a decimal point, such
as `87.6`, is treated as `double`. A `decimal` literal uses the suffix
`m` or `M`.

### Assignment compatibility and type casting

Values assigned to variables must be compatible with the variable's data
type. The lecture explains that `int` accepts integer values; `double`
accepts `int` and `double`; and `decimal` accepts `int` and `decimal`.
Directly assigning a `double` to a `decimal`, or a `decimal` to a
`double`, is not allowed.

A cast explicitly converts a value to another type:

``` csharp
decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;
```

The `var` keyword can be used for a local variable when it is
initialized. The compiler infers the variable's type from the assigned
value:

``` csharp
var interestRate = 12.0;
var stockCode = "D465U";
```

------------------------------------------------------------------------

## 4. Performing Calculations

C# uses arithmetic operators to perform calculations.

  Operator   Operation        Description
  ---------- ---------------- ----------------------------------
  `+`        Addition         Adds values
  `-`        Subtraction      Subtracts one value from another
  `*`        Multiplication   Multiplies values
  `/`        Division         Divides and returns the quotient
  `%`        Modulus          Returns the remainder

Example:

``` csharp
int x = 5;
int y = 4;
int total = x + y;
```

Use parentheses when needed to control the order of operations:

``` csharp
result = (a + b) / 4;
```

### Integer division

When both operands are integers, division produces an integer result,
dropping the fractional part. For example, `7 / 3` results in `2`.

To get a fractional result, at least one operand must be a
floating-point value:

``` csharp
double result = (double)7 / 3;
```

------------------------------------------------------------------------

## 5. Inputting and Outputting Numeric Values

Because a TextBox's `Text` property contains a string, numeric input
must be converted before it can be used in a numeric calculation. The
slides introduce `Parse` methods for this purpose:

``` csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
decimal price = decimal.Parse(priceTextBox.Text);
```

A cast operator is not used to convert a string into a number.

To display a numeric value in a Label or TextBox, convert it to a string
with `ToString()`:

``` csharp
decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();
```

A number can also be joined with text using `+`:

``` csharp
int idNumber = 1044;
string output = "Your ID number is " + idNumber;
```

------------------------------------------------------------------------

## 6. Formatting Numbers with `ToString()`

The `ToString()` method can format a numeric value for display. The
format string indicates how the value should appear.

  Format   Purpose              Example
  -------- -------------------- ------------------------
  `"N"`    Number format        `value.ToString("N3")`
  `"F"`    Fixed-point format   `value.ToString("F2")`
  `"E"`    Exponential format   `value.ToString("E3")`
  `"C"`    Currency format      `value.ToString("C")`
  `"P"`    Percentage format    `value.ToString("P")`

The number after the format letter specifies decimal places in examples
such as `"N3"` or `"F2"`. Currency and number appearance can depend on
the computer's regional settings.

------------------------------------------------------------------------

## 7. Simple Exception Handling

An exception is an unexpected error that occurs while a program is
running. Examples from the lecture include invalid user input, dividing
by zero, and trying to open a file that does not exist. If an exception
is not handled, the application may stop unexpectedly.

### Using `try-catch`

The `try` block contains statements that may cause an exception. If an
exception occurs, execution moves to the `catch` block, where the
program can respond.

``` csharp
try
{
    double miles = double.Parse(milesTextBox.Text);
    double gallons = double.Parse(gallonsTextBox.Text);
    double mpg = miles / gallons;

    mpgLabel.Text = mpg.ToString();
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}
```

This example catches an exception from invalid numeric input and
displays a message. (Additional checks, such as ensuring gallons is not
zero, are also important for a complete calculation.)

To display the exception's message, the lecture shows catching an
`Exception` object:

``` csharp
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

------------------------------------------------------------------------

## 8. Using Named Constants

A named constant is a name that represents a value that cannot be
changed during program execution. In C#, declare a constant with the
`const` keyword.

``` csharp
const double INTEREST_RATE = 0.129;
```

Using uppercase letters for constant names is a common convention, but
it is not required.

------------------------------------------------------------------------

## 9. Declaring Variables as Fields

A field is a variable declared inside a class but outside its methods. A
field can be accessed throughout its class, subject to its access
modifier.

``` csharp
public partial class Form1 : Form
{
    private string name = "Charles";

    private void showNameButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show(name);
    }
}
```

Unlike a local variable, a class-level field can be used by different
methods in the same class.

------------------------------------------------------------------------

## 10. Using the `Math` Class

The .NET `Math` class provides methods and constants for mathematical
operations.

  Member             Purpose
  ------------------ -----------------------------------------
  `Math.Sqrt(x)`     Returns the square root of `x`
  `Math.Pow(x, y)`   Returns `x` raised to the power of `y`
  `Math.Max(x, y)`   Returns the greater of two values
  `Math.Min(x, y)`   Returns the lesser of two values
  `Math.Round(x)`    Rounds a value to the nearest integer
  `Math.PI`          Represents pi
  `Math.E`           Represents the natural logarithmic base

Example:

``` csharp
double squareRoot = Math.Sqrt(25);
double power = Math.Pow(2, 3);
```

------------------------------------------------------------------------

## 11. More GUI Details

### Tab order and focus

Focus means that a control is currently receiving keyboard input. The
tab order is the sequence in which controls receive focus when the user
presses the Tab key. The `TabIndex` property determines a control's
position in this order, starting at `0`.

A control can be given focus in code using its `Focus()` method:

``` csharp
nameTextBox.Focus();
```

Labels do not accept keyboard input, so they cannot receive focus.

### Keyboard access keys

An access key (also called a mnemonic) lets the user activate a control
using the Alt key together with a designated letter. Add an ampersand
(`&`) before the letter in the button's `Text` property to set an access
key.

### Colors and form background images

Forms and most controls have a `BackColor` property. Controls that
display text also have a `ForeColor` property.

``` csharp
messageLabel.BackColor = Color.Black;
messageLabel.ForeColor = Color.Yellow;
```

A Form also has `BackgroundImage` and `BackgroundImageLayout`
properties. The layout choices described in the slides are `None`,
`Tile`, `Center`, `Stretch`, and `Zoom`.

### GroupBox and Panel

Both `GroupBox` and `Panel` are container controls that can hold other
controls. A GroupBox can display a title through its `Text` property. A
Panel does not have a `Text` property, and its border can be set with
`BorderStyle`.

------------------------------------------------------------------------

## 12. Using the Debugger to Locate Logic Errors

A logic error is a mistake that allows an application to run but causes
it to produce an incorrect result. Examples include using the wrong
variable or assigning an incorrect value.

Visual Studio provides debugging tools to help locate these errors.

### Breakpoints and break mode

A breakpoint is a selected line of code where execution pauses when the
program reaches it. While paused in break mode, you can inspect variable
values and control properties.

### Locals and Watch windows

-   **Locals window:** Displays variables in the current procedure,
    including their values and data types.
-   **Watch window:** Displays variables or expressions that you choose
    to monitor.

### Single-stepping

Single-stepping runs the program one statement at a time after execution
has paused at a breakpoint. You can inspect values after each statement.
The lecture describes using **F11** or the **Step Into** command to step
through code.

------------------------------------------------------------------------

## Summary

In Week 2, we learned how C# Windows Forms applications read user input,
store and process data, calculate results, and show output. We also
studied formatting, exception handling, constants, fields, Math methods,
GUI properties, and debugging techniques.

These topics provide a foundation for building interactive applications
that process user-provided data.
