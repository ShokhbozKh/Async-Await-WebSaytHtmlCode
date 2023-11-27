namespace ConsoleApp6
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello world");
            string path = "https://www.kun.com";
            var result = await DownloadDataAsync(path);

            Console.WriteLine("Natija:" + result);
        }
        static async Task<string> DownloadDataAsync(string path)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(path);
            var response = await client.GetStringAsync("");
            
            
            return response;
        }
    }
}