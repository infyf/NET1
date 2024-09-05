namespace lr1.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Workers { get; set; }

        public Company(string name, string address, int workers)
        {
            Name = name;
            Address = address;
            Workers = workers;
        }
    }
}