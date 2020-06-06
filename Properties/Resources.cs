// Decompiled with JetBrains decompiler
// Type: dewsen.Properties.Resources
// Assembly: dewsen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2643EC53-56EA-439A-A5FC-99806218DD4A
// Assembly location: D:\Data\Downloads\dewsen.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace dewsen.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (dewsen.Properties.Resources.resourceMan == null)
          dewsen.Properties.Resources.resourceMan = new ResourceManager("dewsen.Properties.Resources", typeof (dewsen.Properties.Resources).Assembly);
        return dewsen.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return dewsen.Properties.Resources.resourceCulture;
      }
      set
      {
        dewsen.Properties.Resources.resourceCulture = value;
      }
    }
  }
}
