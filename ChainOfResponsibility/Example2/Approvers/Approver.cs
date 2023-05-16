namespace Example2.Approvers;

public abstract class Approver
{
    protected Approver successor;
    public void SetSuccessor(Approver successor)
    {
        this.successor = successor;
    }

    public abstract void ProcessRequest(Loan loan);
}