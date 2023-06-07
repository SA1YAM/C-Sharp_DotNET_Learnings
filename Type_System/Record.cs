using System;

namespace Type_System
{
    public record Book(string Name, string Author, string[] index);
    public class Record
    {
        public void RunRecord() 
        {
            string[] topics = new string[3] { "topic_1", "topic_2", "topic_3" };
            Book book1 = new Book("Enhance Learninig", "Carl  Marks", topics);
            Book book2 = new Book("Enhance Learninig", "Carl  Marks", topics);
            Console.WriteLine(book1 == book2);
            Console.WriteLine(ReferenceEquals(book1, book2));
        }
    }
}
