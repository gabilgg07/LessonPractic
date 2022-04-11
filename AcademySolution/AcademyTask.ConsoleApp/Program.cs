using System;
using ClosedXML.Excel;

namespace AcademyTask.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            XLWorkbook workbook = new XLWorkbook();

            workbook.SaveAs("Student.xlsx");

            Console.ReadKey();

        }
    }
}
