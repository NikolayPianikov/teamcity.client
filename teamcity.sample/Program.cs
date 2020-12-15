using System;
using System.Collections.Generic;
using System.Linq;
using TeamCity.Api;
using TeamCity.Client;
using TeamCity.Model;

namespace teamcity.sample
{
    class Program
    {
        static int Main(string[] args)
        {
            Configuration configuration;
            
            switch (args.Length)
            {
                case 2:
                    configuration = new Configuration
                    {
                        BasePath = args[0],
                        DefaultHeader = new Dictionary<string, string>
                        {
                            {
                                "Authorization",
                                $"Bearer {args[1]}"
                            }
                        }
                    };
                    break;
                
                case 3:
                    var cred = $"{args[1]}:{args[2]}";
                    var token = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(cred));
                    configuration = new Configuration
                    {
                        BasePath = new Uri(args[0]) + "httpAuth",
                        DefaultHeader = new Dictionary<string, string>
                        {
                            {
                                "Authorization",
                                $"Basic {token}"
                            }
                        }
                    };
                    break;

                default:
                    Console.Error.WriteLine("Invalid arguments.");
                    Console.WriteLine("Use as:");
                    Console.WriteLine("\tteamcity-fix <teamcity_address> <access_token>");
                    Console.WriteLine("\tteamcity-fix <teamcity_address> <user_name> <password>");
                    return 1;
            }
            
            var buildTypeApi = new BuildTypeApi(configuration);

            var toUpdate = from buildType in buildTypeApi.GetBuildTypes()?.BuildType ?? Enumerable.Empty<BuildTypeDto>()
                from step in buildTypeApi.GetSteps(buildType.Id)?.Step ?? Enumerable.Empty<StepDto>()
                where step.Type == "dotnet"
                where step.Properties?.Property.Any(property => property.Name == "command" && property.Value == "run") ?? false
                let property = step.Properties?.Property?.FirstOrDefault(property => property.Name == "args" && !string.IsNullOrWhiteSpace(property.Value) && !property.Value.Trim().StartsWith("--"))
                where property != null
                select new {buildType, step, property};

            foreach (var update in toUpdate)
            {
                var stepName = $"{update.buildType.Id}(\"{update.buildType.Name}\"): {update.step.Id}(\"{update.step.Name}\")";
                var newArgs = $"-- {update.property!.Value}";
                try
                {
                    Console.Write($"Updating {stepName}: {update.property.Value} -> {newArgs}");
                    update.property.Value = newArgs;
                    buildTypeApi.ReplaceStep(update.buildType.Id, update.step.Id, null, update.step);
                    Console.WriteLine(" - Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" - Fail({ex.Message})");
                }
            }

            return 0;
        }
    }
}
