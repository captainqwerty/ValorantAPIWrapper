using ValorantAPI;

Console.WriteLine("Valorant API Testing");

//Console.WriteLine("Amount of Agents:");
//string amount = Console.ReadLine();

//var agents = Agents.GetRandomAgents(Convert.ToInt32(amount));
//foreach (var agent in agents)
//{
//    Console.WriteLine(agent.displayName);
//}
//Console.ReadLine();

//var agents = Agents.GetRandomAgent();

// Console.WriteLine(agents.displayName);

//Console.ReadLine();


//do
//{
//    Console.WriteLine("Map Name:");
//    string mapName = Console.ReadLine();
//    var test = ValorantAPI.ValorantAPI.GetMapByName(mapName);

//    Console.WriteLine($"Following callouts");

//    foreach ( var item in test.callouts )
//    {
//        Console.WriteLine(item.regionName);
//    }

//    Console.WriteLine(" ");
//} while (true);

do
{
    Console.WriteLine("Agents Name:");
    string agentName = Console.ReadLine();
    var test = Agents.GetAgentByUUID(agentName);

    Console.WriteLine($"{test.displayName} is a {test.role.displayName} and their developer was {test.developerName}. {test.displayName} has the following abilties:");
    Console.WriteLine($"{test.uuid}");
    Console.WriteLine("");
    foreach (var ability in test.abilities)
    {
        Console.WriteLine(ability.displayName);
        Console.WriteLine(ability.description);
        Console.WriteLine("");
    }
    Console.WriteLine(" ");
} while (true);

//do
//{
//    Console.WriteLine("Weapon Name:");
//    string agentName = Console.ReadLine();
//    var test = ValorantAPI.Weapons.GetWeaponByName(agentName);

//    Console.WriteLine($"{test.displayName}");
//    Console.WriteLine("");
//    foreach (var ability in test.skins)
//    {
//        Console.WriteLine(ability.displayName);
//        foreach (var wtf in ability.chromas)
//        {
//            Console.WriteLine(wtf.displayName);
//        }
//        Console.WriteLine("");
//    }
//    Console.WriteLine(" ");
//} while (true);
