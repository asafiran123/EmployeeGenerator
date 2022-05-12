using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Class
{
    class Employee
    {
        public string _Name;

        public string _IDNumber;

        

        public string _Department;

        public string _Position; 

        public  Employee (string Name, string IDNumber, string Department, string Position)
        {
            _Name = Name;

            _IDNumber = IDNumber;

            _Department = Department;

            _Position = Position; 
        }

        public string Name
        {
            get { return _Name; }

            set { _Name = value; }
        }

        public string IDNumber
        {
            get { return _IDNumber; }

            set { _IDNumber = value; }
        }   

        public string Department
        {
            get { return _Department; }

            set { _Department = value; }
        }

        public string Position
        {
            get { return _Position; }

            set { _Position = value; }
        }

        
    }
}
