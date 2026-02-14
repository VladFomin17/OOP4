using Laba1.Src.Subject;

namespace Laba1.service;

public class ReportGenerator
{
    public string GenerateReport(HousingDepartment department, int debtors)
    {
        return $"ЖЭК №{department.HousingDepartmentNumber}\n" +
               $"Баланс: {department.Balance}\n" +
               $"Должников: {debtors}";
    }
}