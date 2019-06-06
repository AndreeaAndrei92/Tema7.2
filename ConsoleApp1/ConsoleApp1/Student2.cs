using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student2
    {
        private string firstName;
        private string lastName;
        private string FN;
        private string tel;
        private string email;
        private List<double> marks;
        private Group groupNumber;

        public Student2(string firstName, string lastName, string FN, string tel, string email, List<double> marks, Group group)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.FN = FN;
            this.tel = tel;
            this.email = email;
            this.marks = new List<double>(marks);
            this.groupNumber = group;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name empty");
                }
                this.lastName = value;
            }
        }

        public string Tel
        {
            get { return this.tel; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Tel empty");
                }
                this.tel = tel;
            }
        }

        public string Email
        {
            get { return this.email; }
            private set
            {
                if (!this.email.Contains('@') || !this.email.Contains('.'))
                {
                    throw new ArgumentException("Invalid email");
                }
                this.email = value;
            }
        }

        public List<double> Marks
        {
            get { return this.marks; }
            private set { this.marks = value; }
        }

        public Group GroupNumber
        {
            get { return this.groupNumber; }
            private set { this.groupNumber = value; }
        }

        public string FacNumber
        {
            get { return this.FN; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("FN empty");
                }
                this.FN = value;
            }
        }


    }
}

