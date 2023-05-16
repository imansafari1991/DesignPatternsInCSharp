using Example1;

Console.WriteLine("***Chain of Responsibility Pattern Demo * **\n");
//Different handlers
Receiver emailHandler = new EmailErrorHandler();
Receiver faxHandler = new FaxErrorHandler();
Receiver unknownHandler = new UnknownErrorHandler();
/*
Making the chain :
FaxErrorhandler->EmailErrorHandler->UnknownErrorHandler.
*/
faxHandler.NextReceiver(emailHandler);
emailHandler.NextReceiver(unknownHandler);
Message msg = new Message("The fax is reaching late to the destination.", MessagePriority.Normal);

faxHandler.HandleMessage(msg);
msg = new Message("The emails are not reaching to the destinations.", MessagePriority.High);

faxHandler.HandleMessage(msg);
msg = new Message("In email, CC field is disabled always.",
MessagePriority.Normal);
faxHandler.HandleMessage(msg);
msg = new Message("The fax is not reaching to the destination.", MessagePriority.High);

faxHandler.HandleMessage(msg);
msg = new Message("Cannot login into the system.",
MessagePriority.High);
faxHandler.HandleMessage(msg);
msg = new Message("Neither fax nor email are working.",
MessagePriority.High);
faxHandler.HandleMessage(msg);
Console.ReadKey();