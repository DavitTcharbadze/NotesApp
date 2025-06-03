using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models;

public class Note
{
    public Note(string name, string description)
    {
        Name = name;
        Description = description;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

}
