// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LTU_rolnor_lab1_4EditorTarget : TargetRules
{
	public LTU_rolnor_lab1_4EditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "LTU_rolnor_lab1_4" } );
	}
}
