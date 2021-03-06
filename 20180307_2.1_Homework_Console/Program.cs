﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180307_2._1_Homework_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "_20180307_2.1_Homework_Console";

            string CreateAStringMessage()
            {
                return "This is a string message from a method defined within the Program class";
            }

            // using the CreateAStringMessage method defined within the Program class
            string message = CreateAStringMessage();
            Console.WriteLine(message);
            Console.ReadLine();


            // using the CreateAStringMessageStatic method defined within the Program class but outside the Main method
            message = CreateAStringMessageStatic();
            Console.WriteLine(message);
            Console.ReadLine();


            Messages messages = new Messages();     //  I have to create an object instance of the Messages class
            message = messages.CreateAStringMessage();
            Console.WriteLine("1 - " + message);
            Console.WriteLine("2 - " + messages.CreateAStringMessage());
            Console.ReadLine();


            Console.WriteLine(messages.CreateAStringMessageOverloadApproach(1));
            Console.WriteLine(messages.CreateAStringMessageOverloadApproach(1, 2));
            Console.WriteLine(messages.CreateAStringMessageOverloadApproach(1, 2, 3));
            Console.ReadLine();


            message = Messages.CreateAStringMessageFromStaticMethod();      // Note that I am NOT using the messages instance created earlier.
            Console.WriteLine("1 - " + message);
            Console.WriteLine("2 - " + Messages.CreateAStringMessageFromStaticMethod());
            Console.ReadLine();


            messages.FirstHalfOfMessage = "To Be ";                 // setting property values in the messages instance of Messages
            messages.SecondHalfOfMessage = "Or Not to Be";          // setting property values in the messages instance of Messages
            Console.WriteLine(messages.MessagePropertyGetOnly);     // note that I am 'getting' a property value, not calling a method.  There are no trailing ()
            Console.ReadLine();


            Console.WriteLine(messages.MessagePropertyGetOnlyUsingPrivateMethod);   // note that I am 'getting' a property value, not calling a method.  There are no trailing ()
            Console.ReadLine();
        }


        static string CreateAStringMessageStatic()
        {
            return "This is a string message from a STATIC method defined within the Program class";
        }



        class Messages
        {
            public string CreateAStringMessage()
            {
                return "This is a string message from the CreateAStringMessage method defined within the Message class";
            }


            public string CreateAStringMessageOverloadApproach(int firstNumber)
            {
                return "This is a string message from the CreateAStringMessageOverloadApproach method defined within the Messages class - input parameter - " + firstNumber.ToString();
            }


            public string CreateAStringMessageOverloadApproach(int firstNumber, int secondNumber)
            {
                return "This is a string message from the CreateAStringMessageOverloadApproach method defined within the Messages class - input parameters - " 
                    + firstNumber.ToString() + " "
                    + secondNumber.ToString();
            }


            public string CreateAStringMessageOverloadApproach(int firstNumber, int secondNumber, int thirdNumber)
            {
                return "This is a string message from the CreateAStringMessageOverloadApproach method defined within the Messages class - input parameters - "
                    + firstNumber.ToString() + " "
                    + secondNumber.ToString() + " "
                    + thirdNumber.ToString();
            }


            public static string CreateAStringMessageFromStaticMethod()
            {
                return "This is a string message from the CreateAStringMessageFromStaticMethod method defined within the Messages class" ;
            }


            public string FirstHalfOfMessage { get; set; }
            public string SecondHalfOfMessage { get; set; }
            public string MessagePropertyGetOnly
            {
                get
                {
                    return "message from the MessagePropertyGetOnly property of the Messages Class - " + FirstHalfOfMessage + SecondHalfOfMessage;
                }
            }


            public string MessagePropertyGetOnlyUsingPrivateMethod
            {
                get
                {
                    return BuildMessagePropertyGetOnlyValue();
                }
            }


            private string BuildMessagePropertyGetOnlyValue()
            {
                //nothing outside of the Messages class can see this method - it is private
                return "a private method called BuildMessagePropertyGetOnlyValue created this message string *****" + FirstHalfOfMessage + "*****" + SecondHalfOfMessage + "*****";
            }
        }
    }
}
