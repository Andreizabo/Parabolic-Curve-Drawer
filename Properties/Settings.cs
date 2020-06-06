// Decompiled with JetBrains decompiler
// Type: dewsen.Properties.Settings
// Assembly: dewsen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2643EC53-56EA-439A-A5FC-99806218DD4A
// Assembly location: D:\Data\Downloads\dewsen.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace dewsen.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
