using Microsoft.AspNetCore.Mvc;
using restfulapi.Contracts.ManageStaff;

namespace restfulapi.Controllers;

[ApiController]
[Route("Restfulapi")]
public class RestfulapiController : ControllerBase
{
  [HttpPost()]
  public IActionResult CreateStaff(CreateManageStaffRequest request)
  {
    return Ok(request);
  }

  [HttpGet("{id:guid}")]
  public IActionResult GetStaff(Guid id)
  {
    return Ok(id);
  }

  [HttpPut("{id:guid}")]
  public IActionResult UpsertStaff(Guid id, UpsertManageStaffRequest request)
  {
    return Ok(request);
  }

  [HttpDelete("{id:guid}")]
  public IActionResult DeleteStaff(Guid id)
  {
    return Ok(id);
  }


}
