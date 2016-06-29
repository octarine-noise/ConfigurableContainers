﻿//   AssemblyInfo.cs
//
//  Author:
//       Allis Tauri <allista@gmail.com>
//
//  Copyright (c) 2016 Allis Tauri

using System;
using System.Reflection;
using AT_Utils;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.

[assembly: AssemblyTitle("ConfigurableContainers")]
[assembly: AssemblyDescription("Plugin for the Kerbal Space Program")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("Allis Tauri")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("1.0.*")]
[assembly: KSPAssembly("ConfigurableContainers", 1, 0)]

// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

namespace AT_Utils
{
	public class ModInfo : KSP_AVC_Info //FIXME: fill in ConfigurableContainers credentials
	{
		public ModInfo()
		{
			MinKSPVersion = new Version(1,0,4);
			MaxKSPVersion = new Version(1,0,4);

			VersionURL   = "https://raw.githubusercontent.com/allista/hangar/master/GameData/Hangar/Hangar.version";
			UpgradeURL   = "https://kerbalstuff.com/mod/270/Hangar";
			ChangeLogURL = "https://github.com/allista/hangar/blob/master/ChangeLog.md";
		}
	}
}