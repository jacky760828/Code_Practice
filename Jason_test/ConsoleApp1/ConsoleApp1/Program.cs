// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ConsoleApp1;
using System.Text.Json;

var client =new HttpClient();

var responce = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/19");
var todo = JsonSerializer.Deserialize<Todo>(responce);

var jso=new JsonSerializerOptions { WriteIndented = true };
var jsonstr= JsonSerializer.Serialize(todo, jso);

var ListResponce = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
var Todos = JsonSerializer.Deserialize<List<Todo>>(ListResponce,
    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
    );
return;

