using ClassUser;

User user1 = new User("Piter", "Sasha", "Male");
User user2 = new User();
user2.CreateUser();
user1.PrintUser();
user2.PrintUser();
int size = 5;
User[] users = new User[size];
for (int i = 0; i < size; i++)
{
    users[i] = new User();
    users[i].ChangeId(i + 1);
    users[i].PrintUser();
}