using Microsoft.Extensions.DependencyInjection;
using Wom.Net;
using Wom.Net.Extensions;

var sc = new ServiceCollection();
sc.AddWiseOldMan(opts =>
{
    opts.ApiKey = "My-key"; // optional
    opts.DiscordUsername = "MyUsername"; // optional
});

sc.AddWiseOldMan(); // also acceptable

var sp = sc.BuildServiceProvider();
var client = sp.GetRequiredService<IWiseOldManService>();


var player = await client.Players.Search("baby spragg");
Console.WriteLine();