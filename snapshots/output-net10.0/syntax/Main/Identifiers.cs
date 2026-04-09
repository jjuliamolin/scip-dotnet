  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/
  #pragma warning disable CS0219
  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Identifiers
//             ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Identifiers#
//                         documentation ```cs\nclass Identifiers\n```
//                         enclosing_range 4:0 19:1
  {
      void SpecialNames()
//         ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Identifiers#SpecialNames().
//                      documentation ```cs\nprivate void Identifiers.SpecialNames()\n```
//                      enclosing_range 7:4 18:5
      {
          var @const = 42;
//            ^^^^^^ definition local 0
//                   documentation ```cs\nint @const\n```
//                   enclosing_range 9:8 9:24
          int @var = @const;
//            ^^^^ definition local 1
//                 documentation ```cs\nint var\n```
//                 enclosing_range 10:8 10:26
//                   ^^^^^^ reference local 0
          var under_score = 0;
//            ^^^^^^^^^^^ definition local 2
//                        documentation ```cs\nint under_score\n```
//                        enclosing_range 11:8 11:28
          var with1number = 0;
//            ^^^^^^^^^^^ definition local 3
//                        documentation ```cs\nint with1number\n```
//                        enclosing_range 12:8 12:28
          var varæble = 0;
//            ^^^^^^^ definition local 4
//                    documentation ```cs\nint varæble\n```
//                    enclosing_range 13:8 13:24
          var Переменная = 0;
//            ^^^^^^^^^^ definition local 5
//                       documentation ```cs\nint Переменная\n```
//                       enclosing_range 14:8 14:27
          var first‿letter = 0;
//            ^^^^^^^^^^^^ definition local 6
//                         documentation ```cs\nint first‿letter\n```
//                         enclosing_range 15:8 15:29
          var ග්‍රහලෝකය = 0;
//            ^^^^^^^^^ definition local 7
//                      documentation ```cs\nint ග්රහලෝකය\n```
//                      enclosing_range 16:8 16:26
          var _كوكبxxx = 0;
//            ^^^^^^^^ definition local 8
//                     documentation ```cs\nint _كوكبxxx\n```
//                     enclosing_range 17:8 17:25
      }
  }
  #pragma warning restore CS0219
