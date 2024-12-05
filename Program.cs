using System.Runtime.ConstrainedExecution;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peoplesInQueue;
            int minutesPerPerson = 10;
            int waitingTime;
            int waitingTimeInMinutes;
            int waitingTimeInHours;
            int minutesPerHour = 60;

            Console.Write("Введите количество людей в очереди: ");
            peoplesInQueue = Convert.ToInt32(Console.ReadLine());

            waitingTime = peoplesInQueue * minutesPerPerson;
            waitingTimeInMinutes = waitingTime % minutesPerHour;
            waitingTimeInHours = waitingTime / minutesPerHour;

            Console.WriteLine($"Время ожидания {waitingTimeInHours} час {waitingTimeInMinutes} минут.");
        }
    }
}