using Microsoft.Extensions.DependencyInjection;
using Wom.Net;
using Wom.Net.Extensions;

var sc = new ServiceCollection();
sc.AddWiseOldMan();

var sp = sc.BuildServiceProvider();
var client = sp.GetRequiredService<IWiseOldManService>();

var teams = new Dictionary<string, List<string>>
{
    {
        "tom", [
            "enjoy it",
            "hynry",
            "speccy jay",
            "mjaaau",
            "im sebaa",
            "king auddie"
        ]
    },
    {
        "jester", [
            "angoose",
            "ressi",
            "tzsock",
            "baby woodsy",
            "broder karl",
            "exia222"
        ]
    },
    {
        "dave", [
            "im kas",
            "garamasalsa",
            "xnanoghostx",
            "bawsu i",
            "k28",
            "avarai"
        ]
    },
    {
        "spragg", [
            "dupelicates",
            "haraambwan",
            "rise aga1nst",
            "im a bean",
            "tom hosidius",
            "oldschoolgod"
        ]
    },
    {
        "juan", [
            "headwipe",
            "iron bumble",
            "skldmark",
            "xtristen",
            "knowledge",
            "pvmwithzim"
        ]
    }
};

var stats = new List<(string Username, float EHB, float EHP)>();

foreach (var name in teams)
{
    var s = new List<(float EHB, float EHP)>();

    foreach (var user in name.Value)
    {
        var res = await client
            .Players
            .PlayerDetails(user);

        if (res.Match(_ => false, _ => true))
        {
            res = await client
                .Players
                .PlayerDetails(user);

            if (res.Match(_ => false, _ => true))
            {
                Console.WriteLine($"failed to get player {user}");
            }
        }

        res.OnSuccess(val => s.Add((val.Ehb, val.Ehp)));
        Thread.Sleep(20);
    }

    stats.Add((name.Key, s.Sum(x => x.EHB), s.Sum(x => x.EHP)));
}

var orderedByEhb = stats.OrderByDescending(x => x.EHB);
Console.WriteLine("Top for EHB");
foreach (var (item, ehb, _) in orderedByEhb)
{
    Console.WriteLine($"{item} - {ehb}");
}

Console.WriteLine();
var orderedByEhp = stats.OrderByDescending(x => x.EHP);
Console.WriteLine("Top for EHP");
foreach (var (item, _, ehp) in orderedByEhp)
{
    Console.WriteLine($"{item} - {ehp}");
}

Console.WriteLine();
var orderedByCombined = stats.OrderByDescending(x => x.EHB + x.EHP);
Console.WriteLine("Top for combined");
foreach (var (item, ehb, ehp) in orderedByCombined)
{
    Console.WriteLine($"{item} - {ehb + ehp}");
}