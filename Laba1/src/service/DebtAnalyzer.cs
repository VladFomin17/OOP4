using Laba1.Src.Subject;

namespace Laba1.service;

public class DebtAnalyzer
{
    public int GetDebtorsCount(HousingDepartment department)
    {
        return department.Residents.Length - department.PaidResidentsCount;
    }
}