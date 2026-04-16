using Microsoft.AspNetCore.Mvc;
using ClinicManagement.Application.Services;
using ClinicManagement.Core.Entities;

namespace ClinicManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientsController : ControllerBase
{
    private readonly PatientService _patientService;

    public PatientsController()
    {
        _patientService = new PatientService();
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Patient> patients = _patientService.GetPatients();
        return Ok(patients);
    }
}