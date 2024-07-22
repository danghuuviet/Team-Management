using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TeamManager.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImgUrl { get; set; }
    public decimal Salary { get; set; }
    public EmployeeType Type { get; set; }
    public Position Position { get; set; }
}

public enum EmployeeType
{
    [Display(Name = "Freelance")]
    Freelance,

    [Display(Name = "Casual")]
    Casual,

    [Display(Name = "Part Time")]
    PartTime,

    [Display(Name = "Full Time")]
    FullTime
}

public enum Position
{
    [Display(Name = "CEO")]
    CEO,

    [Display(Name = "Operations Manager")]
    OperationsManager,

    [Display(Name = "Fleet Manager")]
    FleetManager,

    [Display(Name = "Safety Manager")]
    SafetyManager,

    [Display(Name = "Environmental Compliance Manager")]
    EnvironmentalComplianceManager,

    [Display(Name = "Garbage Truck Driver")]
    GarbageTruckDriver,

    [Display(Name = "Recycling Technician")]
    RecyclingTechnician,

    [Display(Name = "Customer Service Representative")]
    CustomerServiceRepresentative,

    [Display(Name = "Maintenance Technician")]
    MaintenanceTechnician,

    [Display(Name = "Environmental Engineer")]
    EnvironmentalEngineer,

}

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum enumValue)
    {
        return enumValue.GetType()
          .GetMember(enumValue.ToString())
          .First()
          .GetCustomAttribute<DisplayAttribute>()
          ?.GetName();
    }
}
