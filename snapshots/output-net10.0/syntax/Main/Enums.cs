  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Enums
//             ^^^^^ definition scip-dotnet nuget . . Main/Enums#
//                   documentation ```cs\nclass Enums\n```
//                   enclosing_range 4:0 18:1
  {
      enum EnumWithIntValues
//         ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithIntValues#
//                           documentation ```cs\nenum EnumWithIntValues\n```
//                           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
//                           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
//                           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
//                           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
//                           enclosing_range 7:4 11:5
      {
          Ten = 10,
//        ^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithIntValues#Ten.
//            documentation ```cs\nEnumWithIntValues.Ten = 10\n```
//            enclosing_range 9:8 9:16
          Twenty = 20
//        ^^^^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithIntValues#Twenty.
//               documentation ```cs\nEnumWithIntValues.Twenty = 20\n```
//               enclosing_range 10:8 10:19
      }

      enum EnumWithByteValues
//         ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithByteValues#
//                            documentation ```cs\nenum EnumWithByteValues\n```
//                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
//                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
//                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
//                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
//                            enclosing_range 13:4 17:5
      {
          Five = 0x05,
//        ^^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithByteValues#Five.
//             documentation ```cs\nEnumWithByteValues.Five = 5\n```
//             enclosing_range 15:8 15:19
          Fifteen = 0x0F
//        ^^^^^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithByteValues#Fifteen.
//                documentation ```cs\nEnumWithByteValues.Fifteen = 15\n```
//                enclosing_range 16:8 16:22
      }
  }
