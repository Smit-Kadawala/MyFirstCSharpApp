namespace MyCompany.HR
{
    public class Employee
    {
        public string Name { get; set; } = "Unknown";
        public int Experience { get; set; } = 0;

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} - {Experience} years");
        }
    }
}
