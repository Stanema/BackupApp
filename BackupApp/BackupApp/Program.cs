// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using Newtonsoft.Json;





Console.WriteLine("Hello, World!");

void LoadJson()
{
using (StreamReader r = new StreamReader("file.json"))
{
string json = r.ReadToEnd();
List<Config> items = JsonConvert.DeserializeObject<List<Config>>(json);
}
}

public class Config
{
    public List<string> sources;
    public List<string> targets;
    public DateTime timing;
    public string methods;
    public List<string> retention;
}