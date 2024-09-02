


using MVC.Budget;

var app = Setup.CreateWebApplication();

if(app is null)
{
    Console.WriteLine("App could not start. Exiting");
    Environment.Exit(1);
}

app.Run();
