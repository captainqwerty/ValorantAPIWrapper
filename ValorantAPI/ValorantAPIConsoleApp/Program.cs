Console.WriteLine("Valorant API Testing");

do
{
    Console.WriteLine("Agents Name:");
    string agentName = Console.ReadLine();
    var test = ValorantAPI.ValorantAPI.GetAgentByName(agentName);

    Console.WriteLine($"{test.displayName} is a {test.role.displayName} and their developer was {test.developerName}. {test.displayName} has the following abilties:");
    Console.WriteLine("");
    foreach (var ability in test.abilities)
    {
        Console.WriteLine(ability.displayName);
        Console.WriteLine(ability.description);
        Console.WriteLine("");
    }
    Console.WriteLine(" ");
} while (true);
