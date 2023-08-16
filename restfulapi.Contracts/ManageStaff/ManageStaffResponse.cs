namespace restfulapi.Contracts.ManageStaff;

public record ManageStaffResponse(
  Guid Id,
  string FirstName,
  string LastName,
  int Age,
  string Email,
  string AcessLevel
);