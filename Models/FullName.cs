namespace Models
{
    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }

        public FullName() { }

        public FullName(string fullName)
        {
            var data = fullName?.Split(' ');
            FirstName = data[data.Length - 1];
            LastName = data[0];
            var mid = "";
            for (int i = 1; i < data.Length - 1; i++)
            {
                mid += data[i] + " ";
            }
            MidName = mid.TrimEnd();
        }

        public FullName(string firstName, string lastName, string midName)
        {
            FirstName = firstName;
            LastName = lastName;
            MidName = midName;
        }
    }
}
