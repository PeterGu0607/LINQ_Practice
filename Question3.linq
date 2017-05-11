<Query Kind="Statements">
  <Connection>
    <ID>87f14d95-1fd2-45b4-a2f3-633135b409c2</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var results = from s in Skills
		where s.RequiresTicket==true
              select new
			  {
			  Description = s.Description,
			  Employees= from t in s.EmployeeSkills
			  orderby t.YearsOfExperience descending
			  select new
				{
					Name = t.Employee.FirstName +" "+t.Employee.LastName,
					Level = t.Level,
					YearsOfExperience = t.YearsOfExperience
				}
			};
  
results.Dump("IOrderedQueryable");