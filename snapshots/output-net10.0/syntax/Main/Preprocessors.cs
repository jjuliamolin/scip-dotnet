  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Preprocessors
//             ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Preprocessors#
//                           documentation ```cs\nclass Preprocessors\n```
//                           enclosing_range 4:0 20:1
  {
      string OS()
//           ^^ definition scip-dotnet nuget . . Main/Preprocessors#OS().
//              documentation ```cs\nprivate string Preprocessors.OS()\n```
//              enclosing_range 7:4 19:5
      {
  #if WIN32
          string os = "Win32";
  #warning This class is bad.
  #error Okay, just stop.
  #elif MACOS
          string os = "MacOS";
  #else
          string os = "Unknown";
//               ^^ definition local 0
//                  documentation ```cs\nstring os\n```
//                  enclosing_range 16:8 16:30
  #endif
          return os;
//               ^^ reference local 0
      }
  }
