Console.WriteLine("Valorant API Testing");
//add6443a-41bd-e414-f6ad-e58d267f4e95

//var test = await ValorantAPI.ValorantAPI.GetAgentAsync("add6443a-41bd-e414-f6ad-e58d267f4e95");

var test = ValorantAPI.ValorantAPI.GetAgentByName("Jett");

Console.WriteLine(test.description);

//var test = ValorantAPI.ValorantAPI.GetAllAgents();

//foreach (var agent in test)
//{
//    Console.WriteLine(agent.displayName);
//    Console.WriteLine(agent.description);
//    Console.WriteLine(agent.uuid);
//    foreach (var ability in agent.abilities)
//    {
//        Console.WriteLine(ability.displayName);
//        Console.WriteLine(ability.description);
//    }
//    Console.WriteLine("----");
//}