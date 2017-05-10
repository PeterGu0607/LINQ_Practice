<Query Kind="Statements">
  <Connection>
    <ID>8504840d-2e7a-4f86-8713-caa3531e5b25</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              orderby g.Name
			  select new
			  {
			    Genre = g.Name,
				TracksCount = g.Tracks.Count()
			};
results.Dump("Query Math 1");