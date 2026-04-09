  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
  using DiffPlex.DiffBuilder;
  using DiffPlex.DiffBuilder.Model;

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Packages
//             ^^^^^^^^ definition scip-dotnet nuget . . Main/Packages#
//                      documentation ```cs\nclass Packages\n```
//                      enclosing_range 6:0 13:1
  {
      DiffPaneModel Diff()
//                  ^^^^ definition scip-dotnet nuget . . Main/Packages#Diff().
//                       documentation ```cs\nprivate DiffPaneModel Packages.Diff()\n```
//                       enclosing_range 9:4 12:5
      {
          return InlineDiffBuilder.Diff("a", "b");
      }
  }
