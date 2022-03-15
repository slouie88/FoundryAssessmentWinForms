using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FoundryAssessmentWinForms.Logic;

namespace FoundryAssessmentWinForms
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            DisplayEmployees();
        }

        private void DisplayEmployees()
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();
            EmployeesDataGridView.DataSource = employeesLogic.Read();
        } 
        
        private void DisplayEmployee(int Id)
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();
            EmployeesDataGridView.DataSource = employeesLogic.Read(Id);
        }

        private void AddEmployee(string name)
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();
            employeesLogic.Add(name);
        }

        private void DeleteEmployee(Guid Id)
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();
            employeesLogic.Delete(Id);
        }

        private void UpdateEmployee(Guid Id, string newName)
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();
            employeesLogic.Update(Id, newName);
        }
    }
}
