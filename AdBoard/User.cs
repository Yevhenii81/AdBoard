public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public DateTime BirthDate { get; set; }        
    public DateTime RegistrationDate { get; set; } 
    public int RoleId { get; set; }

    public Role Role { get; set; }
}

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<User> Users { get; set; }
}
