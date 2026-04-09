  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Methods
//             ^^^^^^^ definition scip-dotnet nuget . . Main/Methods#
//                     documentation ```cs\nclass Methods\n```
//                     enclosing_range 4:0 112:1
  {
      int SingleParameter(int b)
//        ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#SingleParameter().
//                        documentation ```cs\nprivate int Methods.SingleParameter(int b)\n```
//                        enclosing_range 7:4 10:5
//                            ^ definition scip-dotnet nuget . . Main/Methods#SingleParameter().(b)
//                              documentation ```cs\nint b\n```
//                              enclosing_range 7:24 7:29
      {
          return b;
//               ^ reference scip-dotnet nuget . . Main/Methods#SingleParameter().(b)
      }

      int TwoParameters(int a, int b)
//        ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#TwoParameters().
//                      documentation ```cs\nprivate int Methods.TwoParameters(int a, int b)\n```
//                      enclosing_range 12:4 15:5
//                          ^ definition scip-dotnet nuget . . Main/Methods#TwoParameters().(a)
//                            documentation ```cs\nint a\n```
//                            enclosing_range 12:22 12:27
//                                 ^ definition scip-dotnet nuget . . Main/Methods#TwoParameters().(b)
//                                   documentation ```cs\nint b\n```
//                                   enclosing_range 12:29 12:34
      {
          return a + b;
//               ^ reference scip-dotnet nuget . . Main/Methods#TwoParameters().(a)
//                   ^ reference scip-dotnet nuget . . Main/Methods#TwoParameters().(b)
      }

      int Overload1(int a)
//        ^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#Overload1().
//                  documentation ```cs\nprivate int Methods.Overload1(int a)\n```
//                  enclosing_range 17:4 20:5
//                      ^ definition scip-dotnet nuget . . Main/Methods#Overload1().(a)
//                        documentation ```cs\nint a\n```
//                        enclosing_range 17:18 17:23
      {
          return a;
//               ^ reference scip-dotnet nuget . . Main/Methods#Overload1().(a)
      }

      int Overload1(int a, int b)
//        ^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#Overload1(+1).
//                  documentation ```cs\nprivate int Methods.Overload1(int a, int b)\n```
//                  enclosing_range 22:4 25:5
//                      ^ definition scip-dotnet nuget . . Main/Methods#Overload1(+1).(a)
//                        documentation ```cs\nint a\n```
//                        enclosing_range 22:18 22:23
//                             ^ definition scip-dotnet nuget . . Main/Methods#Overload1(+1).(b)
//                               documentation ```cs\nint b\n```
//                               enclosing_range 22:25 22:30
      {
          return a + b;
//               ^ reference scip-dotnet nuget . . Main/Methods#Overload1(+1).(a)
//                   ^ reference scip-dotnet nuget . . Main/Methods#Overload1(+1).(b)
      }

      T Generic<T>(T param)
//    ^ reference local 0
//      ^^^^^^^ definition scip-dotnet nuget . . Main/Methods#Generic().
//              documentation ```cs\nprivate T Methods.Generic<T>(T param)\n```
//              enclosing_range 27:4 30:5
//              ^ definition local 0
//                documentation ```cs\nT\n```
//                enclosing_range 27:14 27:15
//                 ^ reference local 0
//                   ^^^^^ definition scip-dotnet nuget . . Main/Methods#Generic().(param)
//                         documentation ```cs\nT param\n```
//                         enclosing_range 27:17 27:24
      {
          return param;
//               ^^^^^ reference scip-dotnet nuget . . Main/Methods#Generic().(param)
      }

      T GenericConstraint<T>(T param) where T : new()
//    ^ reference local 1
//      ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#GenericConstraint().
//                        documentation ```cs\nprivate T Methods.GenericConstraint<T>(T param) where T : new()\n```
//                        enclosing_range 32:4 35:5
//                        ^ definition local 1
//                          documentation ```cs\nT\n```
//                          enclosing_range 32:24 32:25
//                           ^ reference local 1
//                             ^^^^^ definition scip-dotnet nuget . . Main/Methods#GenericConstraint().(param)
//                                   documentation ```cs\nT param\n```
//                                   enclosing_range 32:27 32:34
//                                          ^ reference local 1
      {
          return param;
//               ^^^^^ reference scip-dotnet nuget . . Main/Methods#GenericConstraint().(param)
      }

      void DefaultParameter(int a = 5)
//         ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#DefaultParameter().
//                          documentation ```cs\nprivate void Methods.DefaultParameter([int a = 5])\n```
//                          enclosing_range 37:4 39:5
//                              ^ definition scip-dotnet nuget . . Main/Methods#DefaultParameter().(a)
//                                documentation ```cs\n[int a = 5]\n```
//                                enclosing_range 37:26 37:35
      {
      }

      int DefaultParameterOverload(int a = 5)
//        ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#DefaultParameterOverload().
//                                 documentation ```cs\nprivate int Methods.DefaultParameterOverload([int a = 5])\n```
//                                 enclosing_range 41:4 44:5
//                                     ^ definition scip-dotnet nuget . . Main/Methods#DefaultParameterOverload().(a)
//                                       documentation ```cs\n[int a = 5]\n```
//                                       enclosing_range 41:33 41:42
      {
          return DefaultParameterOverload(a, a);
//               ^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#DefaultParameterOverload(+1).
//                                        ^ reference scip-dotnet nuget . . Main/Methods#DefaultParameterOverload().(a)
//                                           ^ reference scip-dotnet nuget . . Main/Methods#DefaultParameterOverload().(a)
      }

      int DefaultParameterOverload(int a, int b)
//        ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#DefaultParameterOverload(+1).
//                                 documentation ```cs\nprivate int Methods.DefaultParameterOverload(int a, int b)\n```
//                                 enclosing_range 46:4 49:5
//                                     ^ definition scip-dotnet nuget . . Main/Methods#DefaultParameterOverload(+1).(a)
//                                       documentation ```cs\nint a\n```
//                                       enclosing_range 46:33 46:38
//                                            ^ definition scip-dotnet nuget . . Main/Methods#DefaultParameterOverload(+1).(b)
//                                              documentation ```cs\nint b\n```
//                                              enclosing_range 46:40 46:45
      {
          return DefaultParameterOverload();
//               ^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#DefaultParameterOverload().
      }

      interface IHello
//              ^^^^^^ definition scip-dotnet nuget . . Main/Methods#IHello#
//                     documentation ```cs\ninterface IHello\n```
//                     enclosing_range 51:4 54:5
      {
          string Hello();
//               ^^^^^ definition scip-dotnet nuget . . Main/Methods#IHello#Hello().
//                     documentation ```cs\nstring IHello.Hello()\n```
//                     enclosing_range 53:8 53:23
      }

      class ImplementsHello : IHello
//          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#ImplementsHello#
//                          documentation ```cs\nclass ImplementsHello\n```
//                          relationship implementation scip-dotnet nuget . . Main/Methods#IHello#
//                          enclosing_range 56:4 62:5
//                            ^^^^^^ reference scip-dotnet nuget . . Main/Methods#IHello#
      {
          string IHello.Hello()
//               ^^^^^^ reference scip-dotnet nuget . . Main/Methods#IHello#
//                      ^^^^^ definition scip-dotnet nuget . . Main/Methods#ImplementsHello#`Main.Methods.IHello.Hello`().
//                            documentation ```cs\nprivate string ImplementsHello.IHello.Hello()\n```
//                            relationship implementation reference scip-dotnet nuget . . Main/Methods#IHello#Hello().
//                            enclosing_range 58:8 61:9
          {
              return "";
          }
      }

      class InheritedOverloads1
//          ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads1#
//                              documentation ```cs\nclass InheritedOverloads1\n```
//                              enclosing_range 64:4 69:5
      {
          public void Method()
//                    ^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads1#Method().
//                           documentation ```cs\npublic void InheritedOverloads1.Method()\n```
//                           enclosing_range 66:8 68:9
          {
          }
      }

      class InheritedOverloads2 : InheritedOverloads1
//          ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads2#
//                              documentation ```cs\nclass InheritedOverloads2\n```
//                              relationship implementation scip-dotnet nuget . . Main/Methods#InheritedOverloads1#
//                              enclosing_range 71:4 77:5
//                                ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads1#
      {
          public int Method(int parameter)
//                   ^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads2#Method().
//                          documentation ```cs\npublic int InheritedOverloads2.Method(int parameter)\n```
//                          enclosing_range 73:8 76:9
//                              ^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads2#Method().(parameter)
//                                        documentation ```cs\nint parameter\n```
//                                        enclosing_range 73:26 73:39
          {
              return parameter;
//                   ^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads2#Method().(parameter)
          }
      }

      class InheritedOverloads3 : InheritedOverloads2
//          ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads3#
//                              documentation ```cs\nclass InheritedOverloads3\n```
//                              relationship implementation scip-dotnet nuget . . Main/Methods#InheritedOverloads2#
//                              relationship implementation scip-dotnet nuget . . Main/Methods#InheritedOverloads1#
//                              enclosing_range 79:4 85:5
//                                ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads2#
      {
          public string Method(string parameter)
//                      ^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads3#Method().
//                             documentation ```cs\npublic string InheritedOverloads3.Method(string parameter)\n```
//                             enclosing_range 81:8 84:9
//                                    ^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads3#Method().(parameter)
//                                              documentation ```cs\nstring parameter\n```
//                                              enclosing_range 81:29 81:45
          {
              return parameter;
//                   ^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads3#Method().(parameter)
          }
      }

      public static void InheritedOverloads()
//                       ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads().
//                                          documentation ```cs\npublic static void Methods.InheritedOverloads()\n```
//                                          enclosing_range 87:4 95:5
      {
          new InheritedOverloads1().Method();
//            ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads1#
//                                  ^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads1#Method().
          new InheritedOverloads2().Method();
//            ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads2#
//                                  ^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads1#Method().
          new InheritedOverloads2().Method(42);
//            ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads2#
//                                  ^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads2#Method().
          new InheritedOverloads3().Method();
//            ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads3#
//                                  ^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads1#Method().
          new InheritedOverloads3().Method(42);
//            ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads3#
//                                  ^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads2#Method().
          new InheritedOverloads3().Method("42");
//            ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads3#
//                                  ^^^^^^ reference scip-dotnet nuget . . Main/Methods#InheritedOverloads3#Method().
      }

      public class LocalFunction
//                 ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#LocalFunction#
//                               documentation ```cs\nclass LocalFunction\n```
//                               enclosing_range 97:4 111:5
      {
          public static void Method()
//                           ^^^^^^ definition scip-dotnet nuget . . Main/Methods#LocalFunction#Method().
//                                  documentation ```cs\npublic static void LocalFunction.Method()\n```
//                                  enclosing_range 99:8 110:9
          {
              var myWorld = GetWorld();
//                ^^^^^^^ definition local 2
//                        documentation ```cs\nstring? myWorld\n```
//                        enclosing_range 101:12 101:37
//                          ^^^^^^^^ reference local 3
              SayHi(myWorld);
//            ^^^^^ reference local 4
//                  ^^^^^^^ reference local 2

              string GetWorld() => "world";
//                   ^^^^^^^^ definition local 3
//                            documentation ```cs\nstring GetWorld()\n```
//                            enclosing_range 104:12 104:41

              void SayHi(string world)
//                 ^^^^^ definition local 4
//                       documentation ```cs\nvoid SayHi(string world)\n```
//                       enclosing_range 106:12 109:13
//                              ^^^^^ definition local 5
//                                    documentation ```cs\nstring world\n```
//                                    enclosing_range 106:23 106:35
              {
                  Console.WriteLine($"Hello {world}!");
//                ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                        ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
//                                           ^^^^^ reference local 5
              }
          }
      }
  }
