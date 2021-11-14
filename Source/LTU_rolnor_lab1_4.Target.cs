// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LTU_rolnor_lab1_4Target : TargetRules
{
	public LTU_rolnor_lab1_4Target( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "LTU_rolnor_lab1_4" } );
	}
}
