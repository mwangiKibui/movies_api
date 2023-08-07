using System;
namespace Movies.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string? name { get; set; }
		public string? description { get; set; }
		public string? staring { get; set; }
		public Movie()
		{
		}
	}
}

