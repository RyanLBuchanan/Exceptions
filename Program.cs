namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            //int zero = 0;

            //try
            //{
            //    int a = 1 / zero;
            //}
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine("Dividing by zero is futile!");
            //    Console.WriteLine(ex.StackTrace);
            //}
            //catch(StackOverflowException)
            //{

            //}
            //finally
            //{
            //    Console.WriteLine("Let's print this anywho!");
            //}

            //Console.WriteLine("Alright!  Let's move on");
            #endregion

            methodOne();
        }

        static void methodOne()
        {
            methodTwo();
        }

        static void methodTwo()
        {
            throw new Exception();
        }
    }
}