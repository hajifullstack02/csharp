using System;
using System.Threading.Tasks;

namespace EmployeeAsyncContainer
{
    class EmployeeAsyncClass
    {
        public static async Task Main()
        {
            // Start calling async methods (all concurrent)
            Task<int> empIdTask = EmployeeAsyncClass.GetEmployeeID();
            Task<string> empNameTask = EmployeeAsyncClass.GetEmployeeName();
            Task<double> empSalaryTask = EmployeeAsyncClass.GetEmployeeSalary();
            Task<string> empDeptTask = EmployeeAsyncClass.GetEmployeeDepartment();

            // Wait for all tasks
            await Task.WhenAll(empIdTask, empNameTask, empSalaryTask, empDeptTask);

            int empId = empIdTask.Result;
            string empName = empNameTask.Result;
            double empSalary = empSalaryTask.Result;
            string empDept = empDeptTask.Result;

            Console.WriteLine("Results Received:");
            Console.WriteLine(empId);
            Console.WriteLine(empName);
            Console.WriteLine(empSalary);
            Console.WriteLine(empDept);
        }

        // Async Methods – simulating DB calls

        public static async Task<int> GetEmployeeID()
        {
            await Task.Delay(3000); // 3 sec
            return 501;
        }

        public static async Task<string> GetEmployeeName()
        {
            await Task.Delay(6000); // 6 sec
            return "David";
        }

        public static async Task<double> GetEmployeeSalary()
        {
            await Task.Delay(4000); // 4 sec
            return 55000.50;
        }

        public static async Task<string> GetEmployeeDepartment()
        {
            await Task.Delay(5000); // 5 sec
            return "Software Development";
        }

        // Sync method
        public static int GetEmployeeAge()
        {
            return 28;
        }
    }
}
