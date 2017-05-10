<Query Kind="Statements">
  <Connection>
    <ID>8504840d-2e7a-4f86-8713-caa3531e5b25</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
              select new
			  {
			  Name = m.Name,
              Tracks = from t in m.Tracks
			           select new
				{
				   TrackName = t.Name,
				   Album = t.Album.Title,
				   Artist = t.Album.Artist.Name,
				   ReleaseYear = t.Album.ReleaseYear,
				   ReleaseLabel = t.Album.ReleaseLabel,
				   Genre = t.Genre.Name 
				   }
			  };
results.Dump("Media Metal 1");