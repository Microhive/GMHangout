using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Shared
{
    public enum Status
    {
        [Display(Name = "Unknown")]
        Unknown,
        [Display(Name = "Alive")]
        Alive,
        [Display(Name = "Dead")]
        Dead,
        [Display(Name = "Retired")]
        Retired
    }
}
