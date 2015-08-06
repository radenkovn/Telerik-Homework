namespace StudentClass.Classes
{
    using System;

    using StudentClass.Classes.Enums;
    class Student : ICloneable, IComparable<Student>
    {
        public Student(string firstName,
                       string middleName,
                       string lastName,
                       ulong ssn,
                       string address,
                       string mobilePhone,
                       string eMail,
                       int course,
                       Specialties specialty,
                       Universities university,
                       Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string EMail { get; set; }
        public int Course { get; set; }
        public Specialties Specialty { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }
        public override bool Equals(object obj)
        {
            var compared = obj as Student;
            if (this.GetHashCode() == compared.GetHashCode())
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} - {3}", this.FirstName, this.MiddleName, this.LastName, this.SSN);
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + this.FirstName.GetHashCode();
            hash = (hash * 7) + this.MiddleName.GetHashCode();
            hash = (hash * 7) + this.LastName.GetHashCode();
            hash = (hash * 7) + this.SSN.GetHashCode();
            return hash;
        }
        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Equals(s2);
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return !s1.Equals(s2);
        }

        public object Clone()
        {
            var result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone, this.EMail, this.Course, this.Specialty, this.University, this.Faculty);
            return result;
        }
        public int CompareTo(Student other)
        {
            if (this.Equals(other))
            {
                return 0;
            }
            var lastName = this.LastName.CompareTo(other.LastName);
            var middleName = this.MiddleName.CompareTo(other.MiddleName);
            var firstName = this.FirstName.CompareTo(other.FirstName);
            var ssn = this.SSN.CompareTo(other.SSN);
            if (lastName == 0)
            {
                if (middleName == 0)
                {
                    if (firstName == 0)
                    {
                        return (-ssn);
                    }
                    return firstName;
                }
                return middleName;
            }
            return lastName;
        }
    }
}
