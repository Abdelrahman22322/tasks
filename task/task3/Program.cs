
using System.Text.Json;

using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
       
        string jsonData = await FetchJsonDataAsync();

        
        Post? post = JsonSerializer.Deserialize<Post>(jsonData);

        
        Console.WriteLine("Data received from the remote server:");
        Debug.Assert(post != null, nameof(post) + " != null");
        Console.WriteLine($"User ID: {post.UserId}");
        Console.WriteLine($"Post ID: {post.Id}");
        Console.WriteLine($"Title: {post.Title}");
        Console.WriteLine($"Body: {post.Body}");
    }

    static async Task<string> FetchJsonDataAsync()
    {
        using HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");

       
        response.EnsureSuccessStatusCode();

        
        return await response.Content.ReadAsStringAsync();
    }

    
    public class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Body { get; set; }
    }
}
