  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Fields
//             ^^^^^^ definition scip-dotnet nuget . . Main/Fields#
//                    documentation ```cs\nclass Fields\n```
//                    enclosing_range 4:0 31:1
  {
      class Fields1
//          ^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#
//                  documentation ```cs\nclass Fields1\n```
//                  enclosing_range 7:4 20:5
      {
          private readonly int Property1;
//                             ^^^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#Property1.
//                                       documentation ```cs\nprivate readonly int Fields1.Property1\n```
//                                       enclosing_range 9:8 9:39
          private Int64 Property2, Property3;
//                ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
//                      ^^^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#Property2.
//                                documentation ```cs\nprivate long Fields1.Property2\n```
//                                enclosing_range 10:8 10:43
//                                 ^^^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#Property3.
//                                           documentation ```cs\nprivate long Fields1.Property3\n```
//                                           enclosing_range 10:8 10:43
          private Tuple<char, Nullable<int>> Property4;
//                                           ^^^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#Property4.
//                                                     documentation ```cs\nprivate Tuple<char, int?> Fields1.Property4\n```
//                                                     enclosing_range 11:8 11:53

          public Fields1(long field2, long field3, Tuple<char, int?> field4, int field1)
//               ^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().
//                       documentation ```cs\npublic Fields1.Fields1(long field2, long field3, Tuple<char, int?> field4, int field1)\n```
//                       enclosing_range 13:8 19:9
//                            ^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field2)
//                                   documentation ```cs\nlong field2\n```
//                                   enclosing_range 13:23 13:34
//                                         ^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field3)
//                                                documentation ```cs\nlong field3\n```
//                                                enclosing_range 13:36 13:47
//                                                                   ^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field4)
//                                                                          documentation ```cs\nTuple<char, int?> field4\n```
//                                                                          enclosing_range 13:49 13:73
//                                                                               ^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field1)
//                                                                                      documentation ```cs\nint field1\n```
//                                                                                      enclosing_range 13:75 13:85
          {
              Property2 = field2;
//            ^^^^^^^^^ reference scip-dotnet nuget . . Main/Fields#Fields1#Property2.
//                        ^^^^^^ reference scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field2)
              Property3 = field3;
//            ^^^^^^^^^ reference scip-dotnet nuget . . Main/Fields#Fields1#Property3.
//                        ^^^^^^ reference scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field3)
              Property4 = field4;
//            ^^^^^^^^^ reference scip-dotnet nuget . . Main/Fields#Fields1#Property4.
//                        ^^^^^^ reference scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field4)
              Property1 = field1;
//            ^^^^^^^^^ reference scip-dotnet nuget . . Main/Fields#Fields1#Property1.
//                        ^^^^^^ reference scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field1)
          }
      }

      class Fields2
//          ^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields2#
//                  documentation ```cs\nclass Fields2\n```
//                  enclosing_range 22:4 30:5
      {
          // Function pointer equivalent without calling convention
          unsafe delegate*<string, int> a;
//                                      ^ definition scip-dotnet nuget . . Main/Fields#Fields2#a.
//                                        documentation ```cs\nprivate delegate*<string, int> Fields2.a\n```
//                                        enclosing_range 25:8 25:40
          unsafe delegate*<delegate*<in string, int>, delegate*<ref string, ref readonly int>> b;
//                                                                                             ^ definition scip-dotnet nuget . . Main/Fields#Fields2#b.
//                                                                                               documentation ```cs\nprivate delegate*<delegate*<in string, int>, delegate*<ref string, ref readonly int>> Fields2.b\n```
//                                                                                               enclosing_range 26:8 26:95

          // Function pointer equivalent with calling convention
          unsafe delegate* managed<string, int> c;
//                                              ^ definition scip-dotnet nuget . . Main/Fields#Fields2#c.
//                                                documentation ```cs\nprivate delegate*<string, int> Fields2.c\n```
//                                                enclosing_range 29:8 29:48
      }
  }
