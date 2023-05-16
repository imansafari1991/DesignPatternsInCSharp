namespace Example2.Approvers;

public class President:Approver
{
    public override void ProcessRequest(Loan loan)
    {
        if (loan.Amount < 100000.0)
        {
            Console.WriteLine("{0} approved request# {1}",
                this.GetType().Name, loan.Number);
        }
        else
        {
            Console.WriteLine(
                "Request# {0} requires an executive meeting!",
                loan.Number);
        }
    }
}
