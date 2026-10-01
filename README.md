# Task 1
***********
# 1-why the output of this Equation = $30.00?
X + Y equals 30.
The :C is a Currency Format Specifier. It tells C# to display the number as a currency value.

# 2-what is its benefit?
The benefit of Standard Numeric Format Specifiers is that they allow us to display numeric values in a clear and suitable format for the user without changing the actual value.

They are useful for:

- Displaying prices and financial values.
- Formatting large numbers with separators.
- Controlling the number of decimal places.
- Displaying percentages.

- For example:
  double price = 1234567.5;
Console.WriteLine($"{price:N2}");
output==> 1,234,567.50

# 3-try another example with a different specifier with a screenshot of the output.

double number = 1234567.5;
Console.WriteLine($"Number: {number:N2}");
output==> Number: 1,234,567.50

------------------------- ملخص بسيط ---------------------------
:C   → Currency
:N2  → Number with 2 decimal places
:N3  → Number with 3 decimal places
