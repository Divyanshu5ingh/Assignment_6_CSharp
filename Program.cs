using System;
using System.Net.Http;


namespace Assignment_6
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            // Asking user to input the URL
            Console.Write("Enter the URL: ");
            var url = Console.ReadLine();

            // Here I am using HttpClient() instance
            using var client = new HttpClient();
            var content = await client.GetStringAsync(url);

            // Writing the content in A.txt file
            await File.WriteAllTextAsync("A.txt", content);

            // Printing the success message
            Console.WriteLine("Successfully written to A.txt file");

        }
    }

}