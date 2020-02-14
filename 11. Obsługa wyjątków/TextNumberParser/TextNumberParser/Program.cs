using System;

namespace TextNumberParser
{
    public sealed class Program
    {
        public static void Main()
        {
            try
            {
                // ..
                throw new InvalidOperationException(
                    "Dowolny wyjątek");
                // ..
            }
            catch (Win32Exception exception)
                when (exception.ErrorCode == 42)
            {
                // Obsługa wyjątku typu Win32Exception
                // pole error code ma wartość 42
            }
            catch (NullReferenceException exception)
            {
                // Obsługa wyjątku NullReferenceException
            }
            catch (ArgumentException exception)
            {
                // Obsługa wyjątku typu ArgumentException
            }
            catch (InvalidOperationException exception)
            {
                bool exceptionHandled = false;
                // Obsługa wyjątku typu InvalidOperationException
                // ..
                if (!exceptionHandled)
                {
                    throw;
                }
            }
            catch (SystemException)
            {
                // Obsługa wyjątku typu SystemException
            }
            catch (Exception exception)
            {
                // Obsługa wyjątku typu Exception
            }
            finally
            {
                // tu umieść kod porządkujący zasoby. Ten kod
                // jest wykonywany niezależnie od tego, czy wystąpił wyjątek.
            }
        }
    }
}
