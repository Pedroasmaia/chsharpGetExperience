//Todo
/*
Factors are numbers you can multiply together to get another number.

2 and 3 are factors of 6 because: 2 * 3 = 6

You can find a factor by dividing numbers. If the remainder is 0 then the number is a factor.
You can use the mod operator (%) in most languages to check for a remainder
For example 2 is not a factor of 7 because: 7 % 2 = 1

Note: base is a non-negative number, factor is a positive number.
*/
using System;

public class Kata
{
  public static bool CheckForFactor(int num, int factor)
  {
    return num % factor == 0 ? true:false;
  }
}
