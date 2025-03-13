using Microsoft.Extensions.DependencyInjection;
using Wom.Net;
using Wom.Net.Extensions;

var sc = new ServiceCollection();
sc.AddWiseOldMan();

var sp = sc.BuildServiceProvider();
var client = sp.GetRequiredService<IWiseOldManService>();

// var player = await client.Players.Search("zezima");
// var playerUpdate = await client.Players.Update("zezima");
//var assertPlayerType = await client.Players.AssertType("zezima");
//var playerDetails = await client.Players.PlayerDetails(1135);
// var playerDetails = await client.Players.PlayerDetails("zezima");
//var achievements = await client.Players.Achievements("zezima");
//var achievementProgress = await client.Players.AchievementsProgress("zezima");
Console.WriteLine();