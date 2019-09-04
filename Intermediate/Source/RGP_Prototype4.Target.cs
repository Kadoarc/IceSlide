using UnrealBuildTool;

public class RGP_Prototype4Target : TargetRules
{
	public RGP_Prototype4Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("RGP_Prototype4");
	}
}
