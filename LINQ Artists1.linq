<Query Kind="Statements">
  <Connection>
    <ID>0e8851e4-e675-4876-bc33-44b5162421f5</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from a in Artists
              orderby a.Name descending
			  select new
			  {
			     ID = a.ArtistId,
				 Name = a.Name
			};
results.Dump();