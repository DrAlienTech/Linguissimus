// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Linguissimus : ModuleRules
{
	public Linguissimus(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"HeadMountedDisplay",
            "UMG",
            "Slate",
            "SlateCore"
		});

        MinFilesUsingPrecompiledHeaderOverride = 1;
        bUseUnity = true;
	}
}
