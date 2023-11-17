using LabTask.Exceptions;

namespace LabTask
{
    public class User
    {
        public int Id { get; }
        public Status[] Statuses = new Status[0];
        public string Username { get; set; }


        public void ShareStatus(Status status)
        {
            Array.Resize(ref Statuses, Statuses.Length + 1);
            Statuses[Statuses.Length - 1] = status;
        }

        public string GetStatusById(int? id)
        {
            if (id == null)
                throw new ArgumentNullException("Null olmaz");
            else if(id >= Statuses.Length)
                throw new NotFoundException("Yoxdu qaqa");
            else
            {
                return Statuses[(int)id].GetStatusInfo();
            }
        }
    }
}
