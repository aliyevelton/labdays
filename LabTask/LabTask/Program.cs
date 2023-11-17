using LabTask;
using LabTask.Exceptions;




Status status = new Status("salam", "zor title");
Status status1 = new Status("salam111", "zor title111");
Status status2 = new Status("salam222", "zor title222"); 

Console.WriteLine(status.GetStatusInfo());
Console.WriteLine(status1.GetStatusInfo());
Console.WriteLine(status2.GetStatusInfo());

User user = new User();

user.ShareStatus(status);
user.ShareStatus(status1);
user.ShareStatus(status2);


int id = Int32.Parse(Console.ReadLine());

try
{
    Console.WriteLine(user.GetStatusById(id));
}
catch(NotFoundException ex)
{
    Console.WriteLine(ex.Message);
}