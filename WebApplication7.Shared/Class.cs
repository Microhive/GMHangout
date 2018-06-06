using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Shared
{
    public enum Class
    {
        [Display(Name = "None")]
        None,
        [Display(Name = "Fighter")]
        Fighter,
        [Display(Name = "Paladin")]
        Paladin,
        [Display(Name = "Cleric")]
        Cleric,
        [Display(Name = "Warlock")]
        Warlock,
        [Display(Name = "Wizard")]
        Wizard,
        [Display(Name = "Sorcerer")]
        Sorcerer,
        [Display(Name = "Hunter")]
        Hunter,
        [Display(Name = "Rogue")]
        Rogue,
        [Display(Name = "Barbarian")]
        Barbarian,
        [Display(Name = "Druid")]
        Druid,
        [Display(Name = "Gunslinger")]
        Gunslinger,
        [Display(Name = "Bard")]
        Bard
    }
}
