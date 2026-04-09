  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Properties
//             ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Properties#
//                        documentation ```cs\nclass Properties\n```
//                        enclosing_range 4:0 18:1
  {
      byte Get { get; }
//         ^^^ definition scip-dotnet nuget . . Main/Properties#Get.
//             documentation ```cs\nprivate byte Properties.Get { get; }\n```
//             enclosing_range 7:4 7:21

      char Set
//         ^^^ definition scip-dotnet nuget . . Main/Properties#Set.
//             documentation ```cs\nprivate char Properties.Set { set; }\n```
//             enclosing_range 9:4 12:5
      {
          set { throw new NotImplementedException(); }
//                        ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
      }

      uint GetSet { get; set; }
//         ^^^^^^ definition scip-dotnet nuget . . Main/Properties#GetSet.
//                documentation ```cs\nprivate uint Properties.GetSet { get; set; }\n```
//                enclosing_range 14:4 14:29
      long SetGet { set; get; }
//         ^^^^^^ definition scip-dotnet nuget . . Main/Properties#SetGet.
//                documentation ```cs\nprivate long Properties.SetGet { get; set; }\n```
//                enclosing_range 15:4 15:29

      string? Init { get; init; }
//            ^^^^ definition scip-dotnet nuget . . Main/Properties#Init.
//                 documentation ```cs\nprivate string? Properties.Init { get; init; }\n```
//                 enclosing_range 17:4 17:31
  }
