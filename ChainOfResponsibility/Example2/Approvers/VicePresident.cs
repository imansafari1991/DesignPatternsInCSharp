namespace Example2.Approvers;

public class VicePresident:Approver
{
    public override void ProcessRequest(Loan loan)
    {
        if (loan.Amount < 35000.0)
        {
            Console.WriteLine("{0} approved request# {1}",
                this.GetType().Name, loan.Number);
        }
        else if (successor != null)
        {
            successor.ProcessRequest(loan);
        }
    }
}