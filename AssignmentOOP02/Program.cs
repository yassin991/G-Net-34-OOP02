using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Xml.Linq;
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
            #region Q03
            //    a) What is this[int index] called? Explain its purpose.
            //        This is indexer
            //        Purpose is  allowing an object to be accessed like an array using square brackets[].

            //        b) What happens if someone writes register[10] = "Ali";?                        
            //        it causes error IndexOutOfRangeException because index 10 does not exist.

            //        How would you make the indexer safer ?
            //        Add validation inside the get and set:
            //        invalid indexes are checked before accessing the array.

            //        c) Can a class have more than one indexer?       
            //         Yes class can have multiple indexers 
            //    as long as they have different parameter types or different parameter lists.
            //           EX:
            //    public string this[int index] { get; set; }

            //public string this[string name]
            //{
            //    get
            //    {
            //        foreach (var student in names)
            //        {
            //            if (student == name)
            //                return student;
            //        }
            //        return null;
            //    }
            //}
            #endregion
            #region Q04
            //            a) What does the static keyword mean on TotalOrders?
            //                The static keyword means that TotalOrders:
            //                Belongs to the class itself, not to individual objects.
            //                There is only one shared copy of it.
            //                All instances of Order share the same variable.
            //                The same shared variable increases for every object.

            //                How is it different from the `Item` field?
            //      TotalOrders                                 Item
            //Static (class-level)	                        Non-static (instance-level)
            //Shared by all objects                           Each object has its own copy
            //Accessed using Order.TotalOrders	               Accessed using object reference


            //        Can a static method inside Order access the Item field directly? Why or why not?
            //     No   A static method belongs to the class, not to a specific object.
            //    But Item is an instance field, meaning it belongs to a specific object.
            //   Since a static method does not have a reference to a specific object, it cannot access instance members directly.
            #endregion
            #region Practical
            Cinema cinema = new Cinema();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nEnter data for Ticket {i + 1}");

                Console.Write("Movie Name: ");
                string name = Console.ReadLine();

                Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                TicketType type = (TicketType)int.Parse(Console.ReadLine());

                Console.Write("Seat Row (A-Z): ");
                char row = char.Parse(Console.ReadLine());

                Console.Write("Seat Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                SeatLocation seat = new SeatLocation(row, number);
                Ticket ticket = new Ticket(name, type, seat, price);

                cinema.AddTicket(ticket);
            }

            Console.WriteLine("\n======= All Tickets =======");

            for (int i = 0; i < 3; i++)
            {
                Ticket t = cinema[i];
                if (t != null)
                {
                    Console.WriteLine(
                        $"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | Seat: {t.Seat} | " +
                        $"Price: {t.Price} | After Tax: {t.PriceAfterTax}");
                }
            }

            Console.Write("\nEnter movie name to search: ");
            string searchName = Console.ReadLine();

            Ticket found = cinema[searchName];

            if (found != null)
                Console.WriteLine($"Found: Ticket #{found.TicketId} | {found.MovieName}");
            else
                Console.WriteLine("Movie not found.");

            Console.WriteLine($"\nTotal Tickets Sold: {Ticket.GetTotalTicketsSold()}");

            Console.WriteLine("\nBooking References:");
            Console.WriteLine(BookingHelper.GenerateBookingReference());
            Console.WriteLine(BookingHelper.GenerateBookingReference());

            double discounted = BookingHelper.CalcGroupDiscount(5, 80);
            Console.WriteLine($"\nGroup Discount (5 tickets x 80 EGP): {discounted} EGP");








            #endregion
        }
    }
}
