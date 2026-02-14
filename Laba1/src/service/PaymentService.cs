using Laba1.Src.Subject;

namespace Laba1.service;

public class PaymentService
{
    public void AcceptPayment(HousingDepartment department, decimal amount)
    {
        department.Balance += amount;
    }
}