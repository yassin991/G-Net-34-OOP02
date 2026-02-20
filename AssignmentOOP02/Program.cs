using System.Collections.Generic;
using System.ComponentModel;
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
            #region Q02
            //Q02: What is the difference between a field and a property in C#?
            //          1. Field
            //            A field is a variable declared inside a class.
            //            It directly stores data.
            //            It usually has no built-in control over how the value is accessed or modified.
            //            Fields are typically marked private
            //         2.  Property
            //         property provides controlled access to a field.
            //         It uses get and/or set accessors.
            //         It allows validation, logic, or restrictions when reading or writing data.
            //         It is part of the class’s public interface.

            //    Can a property contain logic?
            //          A property can contain logic inside its get and set accessors
            //
            //          
            // Example of a read-only property that returns a calculated value
        //   public class Rectangle
        //{
        //    private double width;
        //    private double height;

        //    public Rectangle(double width, double height)
        //    {
        //        this.width = width;
        //        this.height = height;
        //    }

        //    public double Area
        //    {
        //        get { return width * height; }
        //    }
        //}

        #endregion


    }
}
}
