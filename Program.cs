using System;
using RestSharp;
using RestSharpTests.Models;

namespace RestSharpTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "https://jsonplaceholder.typicode.com/posts";

            // Sets the BaseUrl for requests made by the client instance
            RestClient client = new RestClient(baseUrl);

            // Data used to make requests
            RestRequest request = new RestRequest();

            // This method ask the user to enter the data
            JsonObjectModel objectModel = GenerateJsonModel();

            // Give an object in the request body
            request.AddJsonBody(objectModel);

            // Execute the request using HTTP POST method
            IRestResponse response = client.Post(request);

            Console.WriteLine(response.StatusCode + Environment.NewLine + response.Content.ToString());

            Console.Read();
        }

        static JsonObjectModel GenerateJsonModel()
        {
            Console.WriteLine("Enter the User Id:");
            int userId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Body:");
            string body = Console.ReadLine();

            Console.WriteLine("Enter the title:");
            string title = Console.ReadLine();

            JsonObjectModel objectModel = new JsonObjectModel(userId, body, title);

            return objectModel;
        }
    }
}
