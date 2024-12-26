// Problem 1: Comparing two integers.
// Given two integers, determine if they are equal, not equal, greater than, less than, greater than or equal to, or less than or equal to each other.
// In Python: ==, !=, >, <, >=, <=
int num1 = 10;
int num2 = 5;

// Your code here:
bool isEqual = false; // Replace false with the correct evaluation
bool isNotEqual = false; // Replace false with the correct evaluation
bool isGreaterThan = false; // Replace false with the correct evaluation
bool isLessThan = false; // Replace false with the correct evaluation
bool isGreaterThanOrEqual = false; // Replace false with the correct evaluation
bool isLessThanOrEqual = false; // Replace false with the correct evaluation

Console.WriteLine($"{num1} is equal to {num2}: {isEqual}");
Console.WriteLine($"{num1} is not equal to {num2}: {isNotEqual}");
Console.WriteLine($"{num1} is greater than {num2}: {isGreaterThan}");
Console.WriteLine($"{num1} is less than {num2}: {isLessThan}");
Console.WriteLine($"{num1} is greater than or equal to {num2}: {isGreaterThanOrEqual}");
Console.WriteLine($"{num1} is less than or equal to {num2}: {isLessThanOrEqual}");

// Problem 2: Comparing two doubles with tolerance.
// Due to floating-point representation, direct comparison of doubles can be problematic.
// Use a tolerance (epsilon) to check for "near equality."
// In Python, you might use abs(a - b) < tolerance.
// (Use Math.Abs for absolute)
double double1 = 0.1 + 0.2; // This will not be exactly 0.3 due to floating point representation
double double2 = 0.3;
double tolerance = 0.000001; // Define a small tolerance

// Your code here:
bool doublesAreEqual = false; // Replace false with the correct evaluation

Console.WriteLine($"{double1} == {double2}: {doublesAreEqual}");

// Problem 3: Comparing strings.
// Compare two strings for equality (case-sensitive and case-insensitive).
// In Python: == (case-sensitive), string1.lower() == string2.lower() (case-insensitive)
string str1 = "Hello";
string str2 = "hello";

// Your code here:
bool stringsAreEqualCaseSensitive = false; // Replace false with the correct evaluation
bool stringsAreEqualCaseInsensitive = false; // Replace false with the correct evaluation

Console.WriteLine($"\"{str1}\" == \"{str2}\" (Case-sensitive): {stringsAreEqualCaseSensitive}");
Console.WriteLine($"\"{str1}\" == \"{str2}\" (Case-insensitive): {stringsAreEqualCaseInsensitive}");

// Problem 4: Combining comparisons with logical operators.
// Use AND (&&) and OR (||) operators to combine comparisons.
// In Python: and, or
int age = 25;
int legalDrivingAge = 18;
bool hasLicense = true;

// Your code here:
bool canDrive = false; // Replace false with the correct evaluation

Console.WriteLine($"If your age is {age} and you have license you can drive: {canDrive}");

// Problem 5: Type checking with `is`.
// First check if it is a string, then check if it is an integer.
// Check the type of a variable using the `is` operator.
object obj = "This is a string";

// Your code here:
bool isString = false; // Replace false with the correct evaluation
bool isInt = false; // Replace false with the correct evaluation

Console.WriteLine($"Is obj a string? {isString}");
Console.WriteLine($"Is obj an int? {isInt}");
