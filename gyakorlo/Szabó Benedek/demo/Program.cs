// Demo
// Ha ready és timer lejárt utána mindenkinek a " kártyája megfordul és mindenkinek az értéke látható lesz . "

using System.Reflection.Metadata;
using System.Runtime.InteropServices;

public class User {
    public string Name;
    public bool Ready;
    public int Card;
    public bool CardVisible;

    public User(string name, bool ready, int card, bool cardVisisble) {
        Name = name;
        Ready = ready;
        Card = card;
        CardVisible = cardVisisble;
    }
}

public class Round {
    static void Main() {
        // Teszt Userek
        User user1 = new User("testUsr1", true, 5, false);
        User user2 = new User("testUsr2", true, 6, false);
        User user3 = new User("testUsr3", true, 7, false);
        User[] users = new User[3];
        users[0] = user1;
        users[1] = user2;
        users[2] = user3;

        // Hány User Ready
        int readyUsers = 0;
        foreach (var user in users) {
            if (user.Ready.Equals(true)) {
                readyUsers ++;
            }
        }

        // Ha minden User Ready
        if (readyUsers == users.Length) {
            revealCards(3, users);
        }
    }
    static void revealCards(int timer, User[] users) {
        // Timer leforgása
        for (int i = timer; i > 0; i--) {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        // Minden User kártyája látható
        foreach (var user in users)
        {
            user.CardVisible = true;
        }
    }
}