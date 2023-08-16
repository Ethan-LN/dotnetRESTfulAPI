namespace restfulapi.Contracts.ManageStaff;

public record UpsertManageStaffRequest(
  string FirstName,
  string LastName,
  int Age,
  string Email,
  string AcessLevel
);