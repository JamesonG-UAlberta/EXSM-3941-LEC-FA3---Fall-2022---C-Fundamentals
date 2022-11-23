namespace EXSM3941
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your date of birth, YYYY-MM-DD: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine().Trim());
            TimeSpan age = DateTime.Now.Subtract(birthDate);
            Console.WriteLine($"You are {age.Days/365} years, {age.Days%365} days, {age.Hours} hours and {age.Minutes} minutes old, if you were born at midnight!");

            Console.Write("Please enter someone else's date of birth, YYYY-MM-DD: ");
            DateTime birthDateTwo = DateTime.Parse(Console.ReadLine().Trim());
            TimeSpan ageTwo = DateTime.Now.Subtract(birthDateTwo);
            TimeSpan ageDifference = age.Subtract(ageTwo);

            Console.WriteLine($"Second person is {ageTwo.Days / 365} years, {ageTwo.Days % 365} days, {ageTwo.Hours} hours and {ageTwo.Minutes} minutes old, if you were born at midnight!");
            Console.WriteLine($"You are {ageDifference.Days / 365} years, {ageDifference.Days % 365} days, {ageDifference.Hours} hours and {ageDifference.Minutes} minutes older, if you were both born at midnight!");

        }
    }
}