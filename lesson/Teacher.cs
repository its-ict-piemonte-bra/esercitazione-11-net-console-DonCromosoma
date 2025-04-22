using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    public class Teacher : ClassMember
    {
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public string Title
        {
            get
            {
                return this.title;
            }
        }

        private string name;
        private string title;

        public Teacher(string name, string title)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name can't be null or empty");
            }
            else if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("Title can't be null or empty");
            }
            this.Name = name;
            this.Title = name;
        }
    }
}
