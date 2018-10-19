using UnityEngine;
using UnityEditor;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class CommandLineBuild {
	[MenuItem("GSN/Build/Build iOS")]
	public static void iOSBuild ()
	{
		BuildPlayerOptions options = new BuildPlayerOptions();
		options.targetGroup = BuildTargetGroup.iOS;
		options.target = BuildTarget.iOS;
		options.scenes = new string[] { "Assets/Scenes/Main.unity" };
		options.locationPathName = "Builds/iOS";
		
		BuildPipeline.BuildPlayer(options);
	}
}
