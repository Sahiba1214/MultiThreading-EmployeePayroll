using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Multithreading_PayrollService;
using System;

namespace ThreadTest
{
    [TestClass]
    public class PayrollTest
    {
        [TestMethod]
        public void GivenEmployeeDetail_WhenAnalyze_ShouldReturnDifferenceBetweenDate()
        {

            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(Id: 1, Name: "Sahiba", Phone: 9876548642, Address: "Mumbai", Department: "DDAA", Gender: "F", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(Id: 2, Name: "Mantashsa", Phone: 6206305575, Address: "Bihar", Department: "CCAA", Gender: "F", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(Id: 3, Name: "Kashish", Phone: 987654324, Address: "Bihar", Department: "AABB", Gender: "F", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(Id: 4, Name: "Enayat", Phone: 1487625372, Address: "Kolkata", Department: "AADD", Gender: "F", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(Id: 5, Name: "Ayat", Phone: 94736478379, Address: "Banglore", Department: "ABCC", Gender: "F", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));

            ThreadConfig threadConfig = new ThreadConfig();
            DateTime startDateTime = DateTime.Now;
            threadConfig.AddEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            threadConfig.AddEmployeeToPayroll(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread: " + (stopDateTimeThread - startDateTimeThread));
        }
    }
}
