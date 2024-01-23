using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.Write("Enter the city name: ");
        string cityName = Console.ReadLine();

        // Replace 'YOUR_API_KEY' with your OpenWeatherMap API key
        string apiKey = "6ef6511aae6d36dd094dd51f900fb31d";
        string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";

        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    DisplayWeatherInfo(data);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

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
