// Problem 1: Calculate the volume of a cylinder.
// Given the radius and height of a cylinder, calculate its volume.
// Formula: Volume = π * radius^2 * height
// In Python: volume = math.pi * radius**2 * height
// (Use Math.PI for π, Math.Pow for power)
double radius = 3.2;
double height = 7.5;

// Your code here:
double volume = 0; // Replace 0 with the correct calculation

Console.WriteLine($"The volume of a cylinder with r={radius}, h={height} is: {volume}");

// Problem 2: Calculate the area of a triangle (Heron's formula).
// Given the lengths of three sides of a triangle, calculate its area.
// Formula: s = (a + b + c) / 2; Area = sqrt(s(s-a)(s-b)(s-c))
// In Python: s = (a + b + c) / 2; area = (s*(s-a)*(s-b)*(s-c)) ** 0.5
// (Use Math.Sqrt for square root)
double a = 5;
double b = 6;
double c = 7;

// Your code here:
double s = 0; // Replace 0 with the correct calculation
double area = 0; // Replace 0 with the correct calculation

Console.WriteLine($"The area of the triangle is: {area}");

// Problem 3: Calculate the distance between two points in a 2D plane.
// Given the coordinates (x1, y1) and (x2, y2) of two points, calculate the distance between them.
// Formula: Distance = sqrt((x2 - x1)^2 + (y2 - y1)^2)
// In Python: distance = ((x2 - x1)**2 + (y2 - y1)**2)**0.5
double x1 = 1;
double y1 = 2;
double x2 = 4;
double y2 = 6;

// Your code here:
double distance = 0; // Replace 0 with the correct calculation

Console.WriteLine($"The distance between (1,2) and (4,6) is: {distance}");

// Problem 4: Calculate the remainder of a division and check if a number is even.
// Given two integers, calculate the remainder and check if the first number is even.
// Use the modulo operator (%)
// In Python: remainder = num1 % num2; is_even = num % 2 == 0
int num = 18;
int divisor = 4;

// Your code here:
int remainder = 0; // Replace 0 with the correct calculation
bool isEven = false; // Replace false with the correct evaluation

Console.WriteLine($"The remainder of {num} divided by {divisor} is {remainder}");
Console.WriteLine($"Is {remainder} even? {isEven}"); // Boolean output

// Problem 5: Swapping two integer variables without using a temporary variable.
// Given two integers, swap their values using arithmetic operations.
// In Python: a, b = b, a
int x = 10;
int y = 5;

// Your code here:
x = 0; // Replace 0 with the correct calculation
y = 0; // Replace 0 with the correct calculation
x = 0; // Replace 0 with the correct calculation

Console.WriteLine($"After swapping: x = {x}, y = {y}");
