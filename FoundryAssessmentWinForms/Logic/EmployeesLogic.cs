using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FoundryAssessmentWinForms.Data;

namespace FoundryAssessmentWinForms.Logic
{
    class EmployeesLogic
    {
        EmployeesDAL employeesDAL = new EmployeesDAL();

        public DataTable Read()
        {
            DataTable employeesDataTable = employeesDAL.Read();
            return employeesDataTable;
        }

        public DataTable Read(int Id)
        {
            DataTable employeesDataTable = employeesDAL.Read(Id);
            return employeesDataTable;
        }

        public void Add(string name)
        {
            employeesDAL.Add(name);
        }

        public void Delete(Guid Id)
        {
            employeesDAL.Delete(Id);
        }

        public void Update(Guid Id, string newName)
        {
            employeesDAL.Update(Id, newName);
        }
    }
}
