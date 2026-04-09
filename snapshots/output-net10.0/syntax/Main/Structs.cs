  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Structs
//             ^^^^^^^ definition scip-dotnet nuget . . Main/Structs#
//                     documentation ```cs\nclass Structs\n```
//                     enclosing_range 4:0 16:1
  {
      struct BasicStruct
//           ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Structs#BasicStruct#
//                       documentation ```cs\nstruct BasicStruct\n```
//                       enclosing_range 7:4 15:5
      {
          public int Property1;
//                   ^^^^^^^^^ definition scip-dotnet nuget . . Main/Structs#BasicStruct#Property1.
//                             documentation ```cs\npublic int BasicStruct.Property1\n```
//                             enclosing_range 9:8 9:29

          public BasicStruct(int field1)
//               ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Structs#BasicStruct#`.ctor`().
//                           documentation ```cs\npublic BasicStruct.BasicStruct(int field1)\n```
//                           enclosing_range 11:8 14:9
//                               ^^^^^^ definition scip-dotnet nuget . . Main/Structs#BasicStruct#`.ctor`().(field1)
//                                      documentation ```cs\nint field1\n```
//                                      enclosing_range 11:27 11:37
          {
              Property1 = field1;
//            ^^^^^^^^^ reference scip-dotnet nuget . . Main/Structs#BasicStruct#Property1.
//                        ^^^^^^ reference scip-dotnet nuget . . Main/Structs#BasicStruct#`.ctor`().(field1)
          }
      }
  }
