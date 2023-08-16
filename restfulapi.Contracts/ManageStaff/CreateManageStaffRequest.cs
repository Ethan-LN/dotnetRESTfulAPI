namespace restfulapi.Contracts.ManageStaff;

public record CreateManageStaffRequest(
  string FirstName,
  string LastName,
  int Age,
  string Email,
  string AcessLevel
);