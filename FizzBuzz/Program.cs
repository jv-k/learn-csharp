/*
FizzBuzz challenge

FizzBuzz is a popular coding challenge and interview question. It exercises your
understanding of the for statement, the if statement, the % remainder operator,
and your command of basic logic.

Code challenge - implement the FizzBuzz challenge rules

Here are the FizzBuzz rules that you need to implement in your code project:

- Output values from 1 to 100, one number per line, inside the code block of an
  iteration statement.

- When the current value is divisible by 3, print the term Fizz next to the
  number.

- When the current value is divisible by 5, print the term Buzz next to the
  number.

- When the current value is divisible by both 3 and 5, print the term FizzBuzz
  next to the number.
*/
for (int i = 1; i <= 100; i++) {
    string msg = "";
    if (i % 15 == 0) msg = " - FizzBuzz";
    else if (i % 3 == 0) msg = " - Fizz";
    else if (i % 5 == 0) msg = " - Buzz";
    Console.WriteLine($"{i}{msg}");
}
