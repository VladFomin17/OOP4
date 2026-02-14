using Laba1.Src.Subject;

namespace Laba1.service;

public class BillingService
{
    public decimal CalculateCharge(HousingDepartment department)
    {
        return (decimal)department.Tariff * department.Residents.Length;
    }
}