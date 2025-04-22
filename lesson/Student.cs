using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    public class Student : ClassMember 
    {
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        private string name;

        public Student(string name) 
        {
            if (string.IsNullOrEmpty(name)) 
            {
                throw new ArgumentNullException("Name can't be null or empty");
            }
            this.Name = name;
        }
    }
}
