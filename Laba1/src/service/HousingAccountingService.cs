using Laba1.Src.Subject;

namespace Laba1.service;

public class HousingAccountingService
{
    private BillingService billingService;
    private PaymentService paymentService;
    private DebtAnalyzer debtAnalyzer;
    private ReportGenerator reportGenerator;

    public HousingAccountingService()
    {
        billingService = new BillingService();
        paymentService = new PaymentService();
        debtAnalyzer = new DebtAnalyzer();
        reportGenerator = new ReportGenerator();
    }

    public string ProcessMonth(HousingDepartment department)
    {
        decimal charge = billingService.CalculateCharge(department);

        department.Balance -= charge;

        decimal payment = department.PaidResidentsCount * (decimal)department.Tariff;

        paymentService.AcceptPayment(department, payment);

        int debtors = debtAnalyzer.GetDebtorsCount(department);
        
        string report = reportGenerator.GenerateReport(department, debtors);
        return PDFBuilder.BuildPDFReport(report);
    }
}