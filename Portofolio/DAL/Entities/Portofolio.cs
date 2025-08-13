using Microsoft.AspNetCore.Components.Web;

namespace Portofolio.DAL.Entities;

public class Project
{
    public int Id  { get; set; }

    public string Title { get; set; }

    public string Subtitle { get; set; }

    public string Url { get; set; }

    public string ImageUrl { get; set; }

    public string  Description { get; set; }
    
    
}