// Copyright 2018 Pavlov Dmitriy

using UnrealBuildTool;

public class LevelGen : ModuleRules
{
	public LevelGen(ReadOnlyTargetRules ROTargetRules) : base(ROTargetRules)
    {
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs; // Enabel IWYU
		
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
