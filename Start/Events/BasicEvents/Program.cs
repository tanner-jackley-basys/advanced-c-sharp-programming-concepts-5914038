﻿// LinkedIn Learning Course exercise file for Advanced C# Programmin by Joe Marini
// Example file for basic events

namespace BasicEvents
{
    // define the delegate for the event handler
    public delegate void MyEventHandler(string value);

    class EventPublisher
    {
        private string TheVal = "";

        // TODO: declare the event
        public event MyEventHandler ValueChanged;
        public string Val
        {
            set
            {
                this.TheVal = value;
                // TODO: when the value changes, fire the event
                this.ValueChanged(TheVal);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher obj = new EventPublisher();
            // TODO: use a named function as an event handler
            // obj.ValueChanged += new MyEventHandler(ObjValueChanged);
            // TODO: use an anonymous delegate as an event handler
            obj.ValueChanged += delegate (string val)
            {
                Console.WriteLine($"The Value changed to {val}");
            };

            string? str = "";
            do
            {
                Console.WriteLine("Enter a value: ");
                str = Console.ReadLine();
                if (!str!.Equals("exit"))
                {
                    obj.Val = str;
                }
            } while (!str.Equals("exit"));
            Console.WriteLine("Goodbye!");
        }

        // This function will be called when the value changes in the EventPublisher class
        static void ObjValueChanged(string value)
        {
            Console.WriteLine("The value changed to {0}", value);
        }
    }
}
