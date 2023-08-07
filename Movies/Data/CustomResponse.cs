using System;
namespace Movies.Data
{
	public class CustomResponse<T>
	{
		public T? Data { get; set; }
		public bool Success { get; set; } = true;
		public string Message { get; set; } = "Request processed successfully";
		public CustomResponse()
		{
		}
	}
}

