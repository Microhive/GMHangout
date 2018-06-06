using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Shared
{
    public enum Race
    {
        [Display(Name = "None")]
        None,
        [Display(Name = "Human")]
        Human,
        [Display(Name = "Dwarf")]
        Dwarf,
        [Display(Name = "Halfling")]
        Halfling,
        [Display(Name = "Gnome")]
        Gnome,
        [Display(Name = "Half-Orc")]
        Half_Orc,
        [Display(Name = "Wood Elf")]
        Elf_Wood,
        [Display(Name = "High Elf")]
        Elf_High,
        [Display(Name = "Drow")]
        Drow,
        [Display(Name = "Dragonborn")]
        Dragonborn,
        [Display(Name = "Goliath")]
        Goliath,
    }
}
