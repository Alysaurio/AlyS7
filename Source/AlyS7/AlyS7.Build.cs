// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AlyS7 : ModuleRules
{
	public AlyS7(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"AlyS7",
			"AlyS7/Variant_Platforming",
			"AlyS7/Variant_Platforming/Animation",
			"AlyS7/Variant_Combat",
			"AlyS7/Variant_Combat/AI",
			"AlyS7/Variant_Combat/Animation",
			"AlyS7/Variant_Combat/Gameplay",
			"AlyS7/Variant_Combat/Interfaces",
			"AlyS7/Variant_Combat/UI",
			"AlyS7/Variant_SideScrolling",
			"AlyS7/Variant_SideScrolling/AI",
			"AlyS7/Variant_SideScrolling/Gameplay",
			"AlyS7/Variant_SideScrolling/Interfaces",
			"AlyS7/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
