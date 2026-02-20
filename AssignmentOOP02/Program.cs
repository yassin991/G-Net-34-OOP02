using System.Collections.Generic;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
        //    a) Identify at least two problems with this design from an encapsulation perspective
        //        1.Public fields(Violation of Encapsulation) 
        //        This breaks encapsulation because the internal state of the object is not protected.
        //        2.No validation in the Withdraw method
        //         There is no validation to check:
        //         If amount is negative
        //         If the balance is sufficient
        //         If the withdrawal is valid
        //        3.No control over modifying Owner
        //    b) How to fix the class to follow proper encapsulation principles
        //    public class BankAccount
        //{
        //    private string owner;
        //    private double balance;
        //    public void Withdraw(double amount)
        //    {
        //        if (amount <= 0)
        //            Console.WriteLine("Invalid amount");

        //        if (amount > balance)
        //            Console.WriteLine("Insufficient balance");

        //        balance -= amount;
        //    }
        //}
        //c) Why exposing fields directly(as public) is bad practice in OOP
        //    Breaks encapsulation
        //    No control over data integrity
        //    Harder maintenance
        //    Reduces flexibility
        #endregion



    }
    }
}
