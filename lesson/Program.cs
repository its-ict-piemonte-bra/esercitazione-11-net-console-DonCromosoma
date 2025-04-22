using System.Runtime.InteropServices;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            // Write some code here...
            Student s = new Student("Mario");
            Student s2 = new Student("Luigi");

            Teacher t= new Teacher("Alessandro Sanino", "CS Teacher");

            ClassMember[] members = new ClassMember[] {s, s2, t };

            Class classe = new Class("ITS-DotNet", members);

            Console.WriteLine($"{classe}");

            /*foreach (ClassMember membri in  members) 
            {
                Console.WriteLine( $"{membri.Name}" );
            }*/
        }
    }
}
