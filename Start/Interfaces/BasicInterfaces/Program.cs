// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini
// Example file for implementing basic interfaces

namespace BasicInterfaces
{
    // TODO: Define an IStorable interface that provides the ability to load and
    // save the information for an object
    interface IStorable
    {
        void Save();
        void Load();
        bool NeedsSave { get; set; }
    }

    // TODO: Implement IStorable on the Document class
    class Document : IStorable
    {
        private string name;

        public Document(string s)
        {
            name = s;
            Console.WriteLine("Created a document with name '{0}'", s);
        }

        // TODO: Implement the IStorable interface methods and properties
        public void Save()
        {
            Console.WriteLine("Saving the Document");
        }

        public void Load()
        {
            Console.WriteLine("Loading the Document");
        }

        public bool NeedsSave { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");

            // TODO: Exercise the IStorable interface
            d.Load();
            d.Save();
            d.NeedsSave = false;
        }
    }
}
