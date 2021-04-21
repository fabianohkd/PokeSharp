using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PokeSharp
{
    class Program
    {
        readonly static string endpoint = "https://pokeapi.co/api/v2/";
        readonly static HttpClient clientHttp = new HttpClient();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            clientHttp.DefaultRequestHeaders.Clear();
            clientHttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var stringTask = clientHttp.GetStringAsync($"{endpoint}pokemon/ditto").Result;


        }
    }
}
