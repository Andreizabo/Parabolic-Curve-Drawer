/// Type: dewsen.Program
/// Assembly: dewsen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null, Configuration=x86, .Net Framework=4.5.2
/// MVID: 2643EC53-56EA-439A-A5FC-99806218DD4A

using System;
using System.Windows.Forms;

namespace dewsen
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
