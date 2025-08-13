namespace Portofolio.DAL.Entities;

public class Messages
{
    public int Id { get; set; }

    public string NameSurname { get; set; }
    
    public string Subject { get; set; }
    
    public string Email { get; set; }
    
    public string MessageDetail { get; set; }
    
    public bool IsRead  { get; set; }

    public DateTime SendDate { get; set; }
}