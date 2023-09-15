using ClassUser;

User user1 = new User("Piter", "Sasha", "Male");
User user2 = new User();
user2.CreateUser();
user1.PrintUser();
user2.PrintUser();

int size = 5;
List<User> users = new List<User>();

for (int i = 0; i < size; i++)
{
    User temp = new User();
    temp.ChangeId(i + 1);
    users.Add(temp);
}
foreach (User user in users) user.PrintUser();