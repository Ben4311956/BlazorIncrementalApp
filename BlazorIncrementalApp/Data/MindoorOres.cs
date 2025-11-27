using System.ComponentModel.DataAnnotations;

public class MindoorOres
{
    [Key]
    public int MindoorOresID { get; set; }
    public int IronOre { get; set; }
    public bool IronOreUnlocked { get; set; }
}

