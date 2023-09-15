namespace ClassUser
{
    internal class User
    {
        public int user_id { get; set; }
        public string? sity { get; set; }
        public string? nick { get; set; }
        public string? gender { get; set; }
        public void ChangeId(int new_id)
        {
            this.user_id = new_id;
        }
        public User()
        {
            this.user_id = 99;
        }
        public User(string sity)
        {
            this.sity = sity;
        }
        public User(string sity, string nick) : this(sity)
        {
            this.nick = nick;
        }
        public User(string sity, string nick, string gender) :
        this("Moscow", nick)
        {
            this.gender = gender;
        }
        public void CreateUser()
        {
            Console.Write("Enter user sity: ");
            this.sity = Console.ReadLine();
            Console.Write("Enter user nick: ");
            this.nick = Console.ReadLine();
            Console.Write("Enter user gender: ");
            this.gender = Console.ReadLine();
        }
        public void PrintUser()
        {
            string output = "User id: " + user_id + "\t";
            if (!string.IsNullOrWhiteSpace(sity)) output += "Sity: " + sity + "\t";
            if (!string.IsNullOrWhiteSpace(nick)) output += "Nick: " + nick + "\t";
            if (!string.IsNullOrWhiteSpace(gender)) output += "Gender: " + gender + "\t";
            Console.WriteLine(output);
        }
    }
}
