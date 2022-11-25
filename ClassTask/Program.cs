using ClassTask.Model;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emploee emploee = new Emploee("Aftandil", false, 300);
            Asistans asistans = new Asistans();
            asistans.GetFeedBack(emploee);
            asistans.GetFeedBack(emploee);

        }
    }
}