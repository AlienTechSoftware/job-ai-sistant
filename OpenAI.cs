using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class OpenAI
{
    private readonly string apiKey;
    private readonly HttpClient httpClient;

    public OpenAI(string apiKey)
    {
        this.apiKey = apiKey;
        this.httpClient = new HttpClient();
    }

    public async Task<string> Complete(string prompt, string model, double temperature = 0.5, int maxTokens = 50)
    {
        var requestBody = new { prompt = prompt, temperature = temperature, max_tokens = maxTokens };
        var json = JsonConvert.SerializeObject(requestBody);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        var endpoint = $"https://api.openai.com/v1/engines/{model}/completions";

        httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);

        var response = await httpClient.PostAsync(endpoint, data);

        if (response.IsSuccessStatusCode)
        {
            var resultJson = await response.Content.ReadAsStringAsync();
            dynamic resultObject = JsonConvert.DeserializeObject(resultJson);
            var completion = resultObject.choices[0].text;
            return completion;
        }
        else
        {
            var errorPayload = await response.Content.ReadAsStringAsync();
            dynamic errorObject = JsonConvert.DeserializeObject(errorPayload);
            var errorMessage = errorObject.error.message;
            Console.WriteLine($"OpenAI API Error: {errorMessage}");
            throw new Exception(errorMessage);
        }
    }
}
