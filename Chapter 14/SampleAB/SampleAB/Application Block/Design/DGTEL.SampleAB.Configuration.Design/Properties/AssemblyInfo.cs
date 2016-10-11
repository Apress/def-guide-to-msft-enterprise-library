//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Application Block Software Factory
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System.Reflection;
using System.Security.Permissions;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DGTEL.SampleAB.Configuration.Design;

[assembly: Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ConfigurationDesignManager(typeof(DGTEL.SampleAB.Configuration.Design.ConfigurationDesignManager))]

[assembly: ReflectionPermission(SecurityAction.RequestMinimum, MemberAccess = true)]
[assembly: SecurityPermission(SecurityAction.RequestMinimum)]

[assembly: ComVisible(false)]

[assembly: AssemblyTitle("DGTEL.SampleAB Application Block Design-Time")]
[assembly: AssemblyDescription("DGTEL.SampleApplicationBlock")]
[assembly: AssemblyCompany("Keenan Newton")]
[assembly: AssemblyVersion("1.0.0.0")]