// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Layer : ModuleRules
{
	public Layer(ReadOnlyTargetRules Target) : base(Target)
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
			"Layer",
			"Layer/Variant_Platforming",
			"Layer/Variant_Platforming/Animation",
			"Layer/Variant_Combat",
			"Layer/Variant_Combat/AI",
			"Layer/Variant_Combat/Animation",
			"Layer/Variant_Combat/Gameplay",
			"Layer/Variant_Combat/Interfaces",
			"Layer/Variant_Combat/UI",
			"Layer/Variant_SideScrolling",
			"Layer/Variant_SideScrolling/AI",
			"Layer/Variant_SideScrolling/Gameplay",
			"Layer/Variant_SideScrolling/Interfaces",
			"Layer/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
