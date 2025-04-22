using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    public class Class
    {
        public string Name 
        {
            get
            {
                return this.name;
            }
        }
        private string name;

        public ClassMember[] Members
        {
            get
            {
                return this.members;
            }
        }
        private ClassMember[] members;

        public Class(string name, ClassMember[] members) 
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name can't be null or empty");
            }
            else if (members.Length == 0) 
            {
                throw new ArgumentException("Members can't be empty");
            }
            this.name = name;
            this.members = members;
        }

    }
}
