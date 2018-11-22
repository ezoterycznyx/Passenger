using System;

namespace Passenger.Core.Domain
{
public class User{
public Guid Id {get; protected set;}
    public string Email {get;private set;}
    public string Password{get; private set;}
    public string Salt {get; private set;}
    public string UserName {get; private set;}
    public string FullName {get;private set;}
public DateTime CreateAt {get;private set;}

protected User(){

}

public User(string email, string userName, string password, string salt){
    Id = Guid.NewGuid();
    Email=email;
    UserName=userName;
    Password=password;
Salt=salt;
CreateAt = DateTime.UtcNow;
}

}
}