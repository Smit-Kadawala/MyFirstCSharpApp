namespace MyCompany.HR
{
    public class Developer
    {
        public string TechStack { get; set; } = "C#";

        public void Code()
        {
            Console.WriteLine("Writing code in " + TechStack);
        }
    }
}
