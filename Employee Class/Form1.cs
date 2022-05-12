using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            string[] EmpArray;
            
            Employee employee  = new Employee("Susan Meyers", "47899", "Accounting", "Vice President");

            Employee employee1 = new Employee("Mark Jones", "39119", "IT", "Programmer");

            Employee employee2 = new Employee("Joy Roger", "81774", "Manufacturing", "Engineer");

            //Names
            NameEmployeeLbl.Text = employee.Name;

            NameEmployee1Lbl.Text = employee1.Name;

            EmployeeNameLbl2 . Text = employee2.Name;

            //Department Numbers

            EmpID.Text = employee.IDNumber; 

            Emp1ID.Text = employee1.IDNumber;

            Emp2ID.Text = employee2.IDNumber;

            //Departments

            EmpDept.Text = employee._Department;
            Emp1Dept.Text = employee1._Department;
            Emp2Dept.Text = employee2._Department;

            //Positions

            PositionEmp.Text = employee._Position;
            PositionEmp1.Text = employee1._Position;
            PositionEmp2.Text = employee2._Position;




        }
    }

}
