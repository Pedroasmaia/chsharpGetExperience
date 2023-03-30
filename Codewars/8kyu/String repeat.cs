/*
Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.
*/
namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      string repeat ="";
      for(int x = 0;x < n;x++){
        repeat += s;
      }
      return repeat;
    }
  }
}