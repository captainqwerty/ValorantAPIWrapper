using ValorantAPI;

Console.WriteLine("Valorant API Wrapper Demo");

// Map Example
Console.WriteLine("Map Name:");
string mapName = Console.ReadLine();
var map = Maps.GetMapByName(mapName);

Console.WriteLine($"Following callouts");

foreach (var callout in map.callouts)
{
    Console.WriteLine(callout.regionName);
}


// Agent Example
Console.WriteLine("Agents Name:");
string agentName = Console.ReadLine();
var agent = Agents.GetAgentByName(agentName);

Console.WriteLine($"{agent.displayName} is a {agent.role.displayName} and their developer was {agent.developerName}. {agent.displayName} has the following abilties:");
Console.WriteLine("");
foreach (var ability in agent.abilities)
{
    Console.WriteLine(ability.displayName);
    Console.WriteLine(ability.description);
    Console.WriteLine("");
}
Console.WriteLine(" ");

// Weapon Example
Console.WriteLine("Weapon Name:");
string weaponName = Console.ReadLine();
var weapon = Weapons.GetWeaponByName(weaponName);

Console.WriteLine($"{weapon.displayName}");
Console.WriteLine("");
foreach (var skin in weapon.skins)
{
    Console.WriteLine(skin.displayName);
    foreach (var chroma in skin.chromas)
    {
        Console.WriteLine(chroma.displayName);
    }
    Console.WriteLine("");
}