using System.Drawing;

namespace Assignment04CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 1st Question
            ////Add a private string password = "secret"; field to a Book class. Try to print it from Main  (outside the class). What happens, and why?
            //Book book = new Book();

            //Console.WriteLine(book.password); // This will cause a compilation error because private members can only be accessed inside the same class. 
            //#endregion

            //#region 2nd Question
            ////Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why ? 
            //Book book = new Book();

            //Console.WriteLine(book.copiesInStock);// This will compile successfully because internal members can be accessed from any code within the same assembly.
            //#endregion

            //#region 3rd Question
            //// Add a public string Title; field to Book.Set it and print it from Main.
            //Book book = new Book();

            //book.Title = "Clean Code";

            //Console.WriteLine(book.Title);// This will compile successfully because public members can be accessed from any code, regardless of the assembly.


            //#endregion

        }
    }
}
