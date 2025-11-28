using System.ComponentModel.DataAnnotations;



public class PersonalDetails
{
    [Key]
    public string PlayerID { get; set; }
    public string Email { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }
}

