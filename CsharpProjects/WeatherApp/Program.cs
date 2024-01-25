// Importing necessary namespaces
using System;
using System.Net.Http;
using System.Threading.Tasks;

// Define the main program class
class Program
{
    // Main asynchronous method
    static async Task Main()
    {
        // Prompt the user to enter the city name
        Console.Write("Enter the city name: ");
        string cityName = Console.ReadLine();

        // Replace 'YOUR_API_KEY' with your OpenWeatherMap API key
        string apiKey = "6ef6511aae6d36dd094dd51f900fb31d";
        // Construct the OpenWeatherMap API URL with the provided city name and API key
        string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";

        try
        {
            // Using HttpClient to make asynchronous HTTP requests
            using (HttpClient client = new HttpClient())
            {
                // Send an HTTP GET request to the OpenWeatherMap API
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Check if the response indicates success
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
                    string data = await response.Content.ReadAsStringAsync();
                    // Display weather information using the parsed data
                    DisplayWeatherInfo(data);
                }
                else
                {
                    // Display an error message for unsuccessful responses
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
        }
        catch (Exception ex)
        {
            // Display an error message for exceptions
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Method to display weather information (needs modification based on API response structure)
    static void DisplayWeatherInfo(string data)
    {
        // Parse and display weather information
        // Modify this part based on the structure of the API response
        // For OpenWeatherMap, you can refer to their API documentation

        // Example: Displaying temperature
        // Note: You should handle the data parsing based on the actual API response structure
        // For OpenWeatherMap, you may need to deserialize the JSON response
        Console.WriteLine("Weather Information:");

        // Display the parsed information
        Console.WriteLine($"Temperature: {data}");
    }
}
