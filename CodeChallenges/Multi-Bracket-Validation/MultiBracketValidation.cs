

namespace DataStructures
{
  public class MultBracketValidation
  {
    /// <summary>
    /// This will determine if the brackets in a string are balanced, meaning open and closing are sequenced correctly.
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static bool MultiBracketValidation(string str)
    {

      Stack<char> checkStack = new Stack<char>();
      foreach (char c in str)
      {
        //Adds the opening brackets to the Stack.
        if (c == '[' || c == '(' || c == '{')
        {
          checkStack.Push(c);
          System.Console.WriteLine("checkStackPeek: " + checkStack.Peek());
        }
        else
        {
          //This will look for closing brackets.  If the closing bracket matches it's opening bracket in the stack.  It will pop it off the stack.
          switch (c)
          {
            case ']':
              if (checkStack.Peek() == '[')
              {
                if (checkStack.Top != null) checkStack.Pop();
              }
              break;
            case '}':
              if (checkStack.Peek() == '{')
              {
                if (checkStack.Top != null) checkStack.Pop();
              }
              break;
            case ')':
              if (checkStack.Peek() == '(')
              {
                if (checkStack.Top != null) checkStack.Pop();
              }
              break;
            default:

              break;
          }
        }
      }
      //After iteration of the string is complete. check the stack and see if it is empty.  if it is Empty = true.  Not empty = false.
      if (checkStack.Top != null) return false;
      return true;
    }
  }
}

