using ClinicManagement.Core.Entities;

namespace ClinicManagement.Application.Services;

public class PatientService
{
    public List<Patient> GetPatients()
    {
        return new List<Patient>
        {
            new Patient { ID = Guid.NewGuid(), Name = "John Doe" },
            new Patient { ID = Guid.NewGuid(), Name = "Mark Tower" }
        };
    }
}