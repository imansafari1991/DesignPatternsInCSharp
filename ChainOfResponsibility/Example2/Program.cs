using Example2;
using Example2.Approvers;

// Setup Chain of Responsibility
Approver alex = new Clerk();
Approver sam = new VicePresident();
Approver tammy = new President();

alex.SetSuccessor(sam);
sam.SetSuccessor(tammy);

// Generate and process purchase requests

Loan l = new Loan(100, 2500.0, "Buy Stuff");
alex.ProcessRequest(l);

l = new Loan(101, 32590.10, "Buy a Car");
alex.ProcessRequest(l);

l = new Loan(102, 122100.00, "Buy a House");
alex.ProcessRequest(l);

// Wait for user

Console.ReadKey();