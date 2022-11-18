namespace TEMAVINERI;

public class User1
{
   static void()
   {
       User1 username = new User1();
       User1 password = new User1();
       User1 email = new User1();
   }


   protected string username;
   protected string email;
    protected string password;
    public string GetMail()
    {
        return User1.email;
    }

    public static void ChangePassword(string newPassword)
    {
        User1.ChangePassword(newPassword);
    }

    public static void ToString()
    {
        return (User1.username,User1.email);//nu mi am dat seama cum sa returnez altfel 2 valori, decat sub forma de tuplu
    }
    
}