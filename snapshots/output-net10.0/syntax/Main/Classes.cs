  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Classes
//             ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#
//                     documentation ```cs\nclass Classes\n```
//                     enclosing_range 4:0 92:1
  {
      public string Name;
//                  ^^^^ definition scip-dotnet nuget . . Main/Classes#Name.
//                       documentation ```cs\npublic string Classes.Name\n```
//                       enclosing_range 7:4 7:23
      public const int IntConstant = 1;
//                     ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#IntConstant.
//                                 documentation ```cs\npublic const int Classes.IntConstant = 1\n```
//                                 enclosing_range 8:4 8:37
      public const string StringConstant = $"hello";
//                        ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#StringConstant.
//                                       documentation ```cs\npublic const string Classes.StringConstant = "hello"\n```
//                                       enclosing_range 9:4 9:50

      public Classes(int name)
//           ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#`.ctor`().
//                   documentation ```cs\npublic Classes.Classes(int name)\n```
//                   enclosing_range 11:4 14:5
//                       ^^^^ definition scip-dotnet nuget . . Main/Classes#`.ctor`().(name)
//                            documentation ```cs\nint name\n```
//                            enclosing_range 11:19 11:27
      {
          Name = "name";
//        ^^^^ reference scip-dotnet nuget . . Main/Classes#Name.
      }

      public Classes(string name) => Name = name;
//           ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#`.ctor`(+1).
//                   documentation ```cs\npublic Classes.Classes(string name)\n```
//                   enclosing_range 16:4 16:47
//                          ^^^^ definition scip-dotnet nuget . . Main/Classes#`.ctor`(+1).(name)
//                               documentation ```cs\nstring name\n```
//                               enclosing_range 16:19 16:30
//                                   ^^^^ reference scip-dotnet nuget . . Main/Classes#Name.
//                                          ^^^^ reference scip-dotnet nuget . . Main/Classes#`.ctor`(+1).(name)

      ~Classes()
//     ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#Finalize().
//             documentation ```cs\nprotected Classes.~Classes()\n```
//             enclosing_range 18:4 21:5
      {
          Console.WriteLine(42);
//        ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+7).
      }

      public class ObjectClass : object, SomeInterface
//                 ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#ObjectClass#
//                             documentation ```cs\nclass ObjectClass\n```
//                             relationship implementation scip-dotnet nuget . . Main/SomeInterface#
//                             enclosing_range 23:4 25:5
//                                       ^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/SomeInterface#
      {
      }

      public partial class PartialClass
//                         ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#PartialClass#
//                                      documentation ```cs\nclass PartialClass\n```
//                                      enclosing_range 27:4 29:5
      {
      }

      class TypeParameterClass<T>
//          ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#TypeParameterClass#
//                             documentation ```cs\nclass TypeParameterClass<T>\n```
//                             enclosing_range 31:4 33:5
//                             ^ definition local 0
//                               documentation ```cs\nT\n```
//                               enclosing_range 31:29 31:30
      {
      }

      internal class InternalMultipleTypeParametersClass<T1, T2>
//                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#InternalMultipleTypeParametersClass#
//                                                       documentation ```cs\nclass InternalMultipleTypeParametersClass<T1, T2>\n```
//                                                       enclosing_range 35:4 37:5
//                                                       ^^ definition local 1
//                                                          documentation ```cs\nT1\n```
//                                                          enclosing_range 35:55 35:57
//                                                           ^^ definition local 2
//                                                              documentation ```cs\nT2\n```
//                                                              enclosing_range 35:59 35:61
      {
      }

      interface ICovariantContravariant<in T1, out T2>
//              ^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#ICovariantContravariant#
//                                      documentation ```cs\ninterface ICovariantContravariant<in T1, out T2>\n```
//                                      enclosing_range 39:4 50:5
//                                         ^^ definition local 3
//                                            documentation ```cs\nin T1\n```
//                                            enclosing_range 39:38 39:43
//                                                 ^^ definition local 4
//                                                    documentation ```cs\nout T2\n```
//                                                    enclosing_range 39:45 39:51
      {
          public void Method1(T1 t1)
//                    ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#ICovariantContravariant#Method1().
//                            documentation ```cs\nvoid ICovariantContravariant<in T1, out T2>.Method1(T1 t1)\n```
//                            enclosing_range 41:8 44:9
//                            ^^ reference local 3
//                               ^^ definition scip-dotnet nuget . . Main/Classes#ICovariantContravariant#Method1().(t1)
//                                  documentation ```cs\nT1 t1\n```
//                                  enclosing_range 41:28 41:33
          {
              Console.WriteLine(t1);
//            ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+9).
//                              ^^ reference scip-dotnet nuget . . Main/Classes#ICovariantContravariant#Method1().(t1)
          }

          public T2? Method2()
//               ^^ reference local 4
//                   ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#ICovariantContravariant#Method2().
//                           documentation ```cs\nT2? ICovariantContravariant<in T1, out T2>.Method2()\n```
//                           enclosing_range 46:8 49:9
          {
              return default(T2);
//                           ^^ reference local 4
          }
      }

      public class StructConstraintClass<T> where T : struct
//                 ^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#StructConstraintClass#
//                                       documentation ```cs\nclass StructConstraintClass<T> where T : struct\n```
//                                       enclosing_range 52:4 54:5
//                                       ^ definition local 5
//                                         documentation ```cs\nT\n```
//                                         enclosing_range 52:39 52:40
//                                                ^ reference local 5
      {
      }

      public class UnmanagedConstraintClass<T> where T : unmanaged
//                 ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#UnmanagedConstraintClass#
//                                          documentation ```cs\nclass UnmanagedConstraintClass<T> where T : unmanaged\n```
//                                          enclosing_range 56:4 58:5
//                                          ^ definition local 6
//                                            documentation ```cs\nT\n```
//                                            enclosing_range 56:42 56:43
//                                                   ^ reference local 6
      {
      }

      public class ClassConstraintClass<T> where T : class
//                 ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#ClassConstraintClass#
//                                      documentation ```cs\nclass ClassConstraintClass<T> where T : class\n```
//                                      enclosing_range 60:4 62:5
//                                      ^ definition local 7
//                                        documentation ```cs\nT\n```
//                                        enclosing_range 60:38 60:39
//                                               ^ reference local 7
      {
      }

      public class NonNullableConstraintClass<T> where T : notnull
//                 ^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#NonNullableConstraintClass#
//                                            documentation ```cs\nclass NonNullableConstraintClass<T> where T : notnull\n```
//                                            enclosing_range 64:4 66:5
//                                            ^ definition local 8
//                                              documentation ```cs\nT\n```
//                                              enclosing_range 64:44 64:45
//                                                     ^ reference local 8
      {
      }

      public class NewConstraintClass<T> where T : new()
//                 ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#NewConstraintClass#
//                                    documentation ```cs\nclass NewConstraintClass<T> where T : new()\n```
//                                    enclosing_range 68:4 70:5
//                                    ^ definition local 9
//                                      documentation ```cs\nT\n```
//                                      enclosing_range 68:36 68:37
//                                             ^ reference local 9
      {
      }

      public class TypeParameterConstraintClass<T> where T : SomeInterface
//                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#TypeParameterConstraintClass#
//                                              documentation ```cs\nclass TypeParameterConstraintClass<T> where T : SomeInterface\n```
//                                              enclosing_range 72:4 74:5
//                                              ^ definition local 10
//                                                documentation ```cs\nT\n```
//                                                enclosing_range 72:46 72:47
//                                                       ^ reference local 10
//                                                           ^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/SomeInterface#
      {
      }

      private class MultipleTypeParameterConstraintsClass<T1, T2> where T1 : SomeInterface, SomeInterface2, new()
//                  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#MultipleTypeParameterConstraintsClass#
//                                                        documentation ```cs\nclass MultipleTypeParameterConstraintsClass<T1, T2> where T1 : SomeInterface, SomeInterface2, new() where T2 : SomeInterface2\n```
//                                                        enclosing_range 76:4 79:5
//                                                        ^^ definition local 11
//                                                           documentation ```cs\nT1\n```
//                                                           enclosing_range 76:56 76:58
//                                                            ^^ definition local 12
//                                                               documentation ```cs\nT2\n```
//                                                               enclosing_range 76:60 76:62
//                                                                      ^^ reference local 11
//                                                                           ^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/SomeInterface#
//                                                                                          ^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/SomeInterface2#
          where T2 : SomeInterface2
//              ^^ reference local 12
//                   ^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/SomeInterface2#
      {
      }

      class IndexClass
//          ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#IndexClass#
//                     documentation ```cs\nclass IndexClass\n```
//                     enclosing_range 81:4 90:5
      {
          private bool a;
//                     ^ definition scip-dotnet nuget . . Main/Classes#IndexClass#a.
//                       documentation ```cs\nprivate bool IndexClass.a\n```
//                       enclosing_range 83:8 83:23

          public bool this[int index]
//                             ^^^^^ definition scip-dotnet nuget . . Main/Classes#IndexClass#`this[]`.(index)
//                                   documentation ```cs\nint index\n```
//                                   enclosing_range 85:25 85:34
          {
              get { return a; }
//                         ^ reference scip-dotnet nuget . . Main/Classes#IndexClass#a.
              set { a = value; }
//                  ^ reference scip-dotnet nuget . . Main/Classes#IndexClass#a.
//                      ^^^^^ reference scip-dotnet nuget . . Main/Classes#IndexClass#set_Item().(value)
          }
      }

  }

  public interface SomeInterface
//                 ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/SomeInterface#
//                               documentation ```cs\ninterface SomeInterface\n```
//                               enclosing_range 94:0 96:1
  {
  }

  internal interface SomeInterface2
//                   ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/SomeInterface2#
//                                  documentation ```cs\ninterface SomeInterface2\n```
//                                  enclosing_range 98:0 100:1
  {
  }
