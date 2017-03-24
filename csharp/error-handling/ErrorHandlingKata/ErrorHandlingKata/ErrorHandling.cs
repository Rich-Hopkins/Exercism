using System;

namespace ErrorHandlingKata
{
  public class ErrorHandling
  {
    public static void HandleErrorByThrowingException()
    {
      throw new Exception();
    }

    public static int? HandleErrorByReturningNullableType(string s)
    {
      if (s == "1") return 1;
      else return null;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
      result = 1;
      if (input == "1") return true;
      else return false;
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableResource)
    {
      using (disposableResource)
        throw new Exception();
    }
  }
}
