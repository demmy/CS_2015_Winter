namespace ClinicProject
{
    public interface IHuman
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        InsuranceAccount Insurance { get; set; }
    }
}