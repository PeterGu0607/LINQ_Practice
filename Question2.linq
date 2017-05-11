<Query Kind="Statements">
  <Connection>
    <ID>87f14d95-1fd2-45b4-a2f3-633135b409c2</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var results = from s in Skills
    where s.EmployeeSkills.Count()==0
	select new
	{
	  Description = s.Description
	  };
	  results.Dump("IOrderedQueryable");