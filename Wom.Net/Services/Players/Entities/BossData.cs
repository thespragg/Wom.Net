using JetBrains.Annotations;

namespace Wom.Net.Services.Players.Entities;

/// <summary>
/// Represents boss-specific data.
/// </summary>
[PublicAPI]
public sealed record BossesData
{
    /// <summary>Abyssal Sire boss data.</summary>
    public BossData AbyssalSire { get; init; } = null!;

    /// <summary>Alchemical Hydra boss data.</summary>
    public BossData AlchemicalHydra { get; init; } = null!;

    /// <summary>Amoxliatl boss data.</summary>
    public BossData Amoxliatl { get; init; } = null!;

    /// <summary>Araxxor boss data.</summary>
    public BossData Araxxor { get; init; } = null!;

    /// <summary>Artio boss data.</summary>
    public BossData Artio { get; init; } = null!;

    /// <summary>Barrows Chests boss data.</summary>
    public BossData BarrowsChests { get; init; } = null!;

    /// <summary>Bryophyta boss data.</summary>
    public BossData Bryophyta { get; init; } = null!;

    /// <summary>Callisto boss data.</summary>
    public BossData Callisto { get; init; } = null!;

    /// <summary>Calvarion boss data.</summary>
    public BossData Calvarion { get; init; } = null!;

    /// <summary>Cerberus boss data.</summary>
    public BossData Cerberus { get; init; } = null!;

    /// <summary>Chambers of Xeric boss data.</summary>
    public BossData ChambersOfXeric { get; init; } = null!;

    /// <summary>Chambers of Xeric Challenge Mode boss data.</summary>
    public BossData ChambersOfXericChallengeMode { get; init; } = null!;

    /// <summary>Chaos Elemental boss data.</summary>
    public BossData ChaosElemental { get; init; } = null!;

    /// <summary>Chaos Fanatic boss data.</summary>
    public BossData ChaosFanatic { get; init; } = null!;

    /// <summary>Commander Zilyana boss data.</summary>
    public BossData CommanderZilyana { get; init; } = null!;

    /// <summary>Corporeal Beast boss data.</summary>
    public BossData CorporealBeast { get; init; } = null!;

    /// <summary>Crazy Archaeologist boss data.</summary>
    public BossData CrazyArchaeologist { get; init; } = null!;

    /// <summary>Dagannoth Prime boss data.</summary>
    public BossData DagannothPrime { get; init; } = null!;

    /// <summary>Dagannoth Rex boss data.</summary>
    public BossData DagannothRex { get; init; } = null!;

    /// <summary>Dagannoth Supreme boss data.</summary>
    public BossData DagannothSupreme { get; init; } = null!;

    /// <summary>Deranged Archaeologist boss data.</summary>
    public BossData DerangedArchaeologist { get; init; } = null!;

    /// <summary>Duke Sucellus boss data.</summary>
    public BossData DukeSucellus { get; init; } = null!;

    /// <summary>General Graardor boss data.</summary>
    public BossData GeneralGraardor { get; init; } = null!;

    /// <summary>Giant Mole boss data.</summary>
    public BossData GiantMole { get; init; } = null!;

    /// <summary>Grotesque Guardians boss data.</summary>
    public BossData GrotesqueGuardians { get; init; } = null!;

    /// <summary>Hespori boss data.</summary>
    public BossData Hespori { get; init; } = null!;

    /// <summary>Kalphite Queen boss data.</summary>
    public BossData KalphiteQueen { get; init; } = null!;

    /// <summary>King Black Dragon boss data.</summary>
    public BossData KingBlackDragon { get; init; } = null!;

    /// <summary>Kraken boss data.</summary>
    public BossData Kraken { get; init; } = null!;

    /// <summary>Kree'Arra boss data.</summary>
    public BossData Kreearra { get; init; } = null!;

    /// <summary>K'ril Tsutsaroth boss data.</summary>
    public BossData KrilTsutsaroth { get; init; } = null!;

    /// <summary>Lunar Chests boss data.</summary>
    public BossData LunarChests { get; init; } = null!;

    /// <summary>Mimic boss data.</summary>
    public BossData Mimic { get; init; } = null!;

    /// <summary>Nex boss data.</summary>
    public BossData Nex { get; init; } = null!;

    /// <summary>Nightmare boss data.</summary>
    public BossData Nightmare { get; init; } = null!;

    /// <summary>Phosani's Nightmare boss data.</summary>
    public BossData PhosanisNightmare { get; init; } = null!;

    /// <summary>Obor boss data.</summary>
    public BossData Obor { get; init; } = null!;

    /// <summary>Phantom Muspah boss data.</summary>
    public BossData PhantomMuspah { get; init; } = null!;

    /// <summary>Sarachnis boss data.</summary>
    public BossData Sarachnis { get; init; } = null!;

    /// <summary>Scorpia boss data.</summary>
    public BossData Scorpia { get; init; } = null!;

    /// <summary>Scurrius boss data.</summary>
    public BossData Scurrius { get; init; } = null!;

    /// <summary>Skotizo boss data.</summary>
    public BossData Skotizo { get; init; } = null!;

    /// <summary>Sol Heredit boss data.</summary>
    public BossData SolHeredit { get; init; } = null!;

    /// <summary>Spindel boss data.</summary>
    public BossData Spindel { get; init; } = null!;

    /// <summary>Tempoross boss data.</summary>
    public BossData Tempoross { get; init; } = null!;

    /// <summary>The Gauntlet boss data.</summary>
    public BossData TheGauntlet { get; init; } = null!;

    /// <summary>The Corrupted Gauntlet boss data.</summary>
    public BossData TheCorruptedGauntlet { get; init; } = null!;

    /// <summary>The Hueycoatl boss data.</summary>
    public BossData TheHueycoatl { get; init; } = null!;

    /// <summary>The Leviathan boss data.</summary>
    public BossData TheLeviathan { get; init; } = null!;

    /// <summary>The Royal Titans boss data.</summary>
    public BossData TheRoyalTitans { get; init; } = null!;

    /// <summary>The Whisperer boss data.</summary>
    public BossData TheWhisperer { get; init; } = null!;

    /// <summary>Theatre of Blood boss data.</summary>
    public BossData TheatreOfBlood { get; init; } = null!;

    /// <summary>Theatre of Blood Hard Mode boss data.</summary>
    public BossData TheatreOfBloodHardMode { get; init; } = null!;

    /// <summary>Thermonuclear Smoke Devil boss data.</summary>
    public BossData ThermonuclearSmokeDevil { get; init; } = null!;

    /// <summary>Tombs of Amascut boss data.</summary>
    public BossData TombsOfAmascut { get; init; } = null!;

    /// <summary>Tombs of Amascut Expert boss data.</summary>
    public BossData TombsOfAmascutExpert { get; init; } = null!;

    /// <summary>TzKal-Zuk boss data.</summary>
    public BossData TzkalZuk { get; init; } = null!;

    /// <summary>TzTok-Jad boss data.</summary>
    public BossData TztokJad { get; init; } = null!;

    /// <summary>Vardorvis boss data.</summary>
    public BossData Vardorvis { get; init; } = null!;

    /// <summary>Venenatis boss data.</summary>
    public BossData Venenatis { get; init; } = null!;

    /// <summary>Vet'ion boss data.</summary>
    public BossData Vetion { get; init; } = null!;

    /// <summary>Vorkath boss data.</summary>
    public BossData Vorkath { get; init; } = null!;

    /// <summary>Wintertodt boss data.</summary>
    public BossData Wintertodt { get; init; } = null!;

    /// <summary>Zalcano boss data.</summary>
    public BossData Zalcano { get; init; } = null!;

    /// <summary>Zulrah boss data.</summary>
    public BossData Zulrah { get; init; } = null!;
}

/// <summary>
/// Represents a boss's data.
/// </summary>
[PublicAPI]
public sealed record BossData
{
    /// <summary>The boss's metric name.</summary>
    public string Metric { get; init; } = null!;

    /// <summary>The boss's Efficient Hours Bossed (EHB).</summary>
    public double Ehb { get; init; }

    /// <summary>The boss's rank.</summary>
    public int Rank { get; init; }

    /// <summary>The boss's kill count.</summary>
    public int Kills { get; init; }
}