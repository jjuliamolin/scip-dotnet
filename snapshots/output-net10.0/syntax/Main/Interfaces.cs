  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Interfaces
//             ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#
//                        documentation ```cs\nclass Interfaces\n```
//                        enclosing_range 4:0 69:1
  {
      public interface IOne
//                     ^^^^ definition scip-dotnet nuget . . Main/Interfaces#IOne#
//                          documentation ```cs\ninterface IOne\n```
//                          enclosing_range 7:4 9:6
      {
      };

      public interface ITwo
//                     ^^^^ definition scip-dotnet nuget . . Main/Interfaces#ITwo#
//                          documentation ```cs\ninterface ITwo\n```
//                          enclosing_range 11:4 13:6
      {
      };

      public interface IThree
//                     ^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IThree#
//                            documentation ```cs\ninterface IThree\n```
//                            enclosing_range 15:4 17:6
      {
      };

      public interface IProperties
//                     ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IProperties#
//                                 documentation ```cs\ninterface IProperties\n```
//                                 enclosing_range 19:4 25:5
      {
          byte Get { get; }
//             ^^^ definition scip-dotnet nuget . . Main/Interfaces#IProperties#Get.
//                 documentation ```cs\nbyte IProperties.Get { get; }\n```
//                 enclosing_range 21:8 21:25
          char Set { set; }
//             ^^^ definition scip-dotnet nuget . . Main/Interfaces#IProperties#Set.
//                 documentation ```cs\nchar IProperties.Set { set; }\n```
//                 enclosing_range 22:8 22:25
          uint GetSet { get; set; }
//             ^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IProperties#GetSet.
//                    documentation ```cs\nuint IProperties.GetSet { get; set; }\n```
//                    enclosing_range 23:8 23:33
          long SetGet { set; get; }
//             ^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IProperties#SetGet.
//                    documentation ```cs\nlong IProperties.SetGet { get; set; }\n```
//                    enclosing_range 24:8 24:33
      }

      interface IMethods
//              ^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IMethods#
//                       documentation ```cs\ninterface IMethods\n```
//                       enclosing_range 27:4 33:6
      {
          void Nothing();
//             ^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IMethods#Nothing().
//                     documentation ```cs\nvoid IMethods.Nothing()\n```
//                     enclosing_range 29:8 29:23
          int Output();
//            ^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IMethods#Output().
//                   documentation ```cs\nint IMethods.Output()\n```
//                   enclosing_range 30:8 30:21
          void Input(string a);
//             ^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IMethods#Input().
//                   documentation ```cs\nvoid IMethods.Input(string a)\n```
//                   enclosing_range 31:8 31:29
//                          ^ definition scip-dotnet nuget . . Main/Interfaces#IMethods#Input().(a)
//                            documentation ```cs\nstring a\n```
//                            enclosing_range 31:19 31:27
          int InputOutput(string a);
//            ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IMethods#InputOutput().
//                        documentation ```cs\nint IMethods.InputOutput(string a)\n```
//                        enclosing_range 32:8 32:34
//                               ^ definition scip-dotnet nuget . . Main/Interfaces#IMethods#InputOutput().(a)
//                                 documentation ```cs\nstring a\n```
//                                 enclosing_range 32:24 32:32
      };

      interface IEvent
//              ^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IEvent#
//                     documentation ```cs\ninterface IEvent\n```
//                     enclosing_range 35:4 38:5
      {
          event EventHandler<int> SomeEvent;
//                                ^^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IEvent#SomeEvent#
//                                          documentation ```cs\nevent EventHandler<int> IEvent.SomeEvent\n```
//                                          enclosing_range 37:8 37:42
      }

      interface IIndex
//              ^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IIndex#
//                     documentation ```cs\ninterface IIndex\n```
//                     enclosing_range 40:4 43:5
      {
          bool this[int index] { get; set; }
//                      ^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IIndex#`this[]`.(index)
//                            documentation ```cs\nint index\n```
//                            enclosing_range 42:18 42:27
      }

      interface IDefault
//              ^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IDefault#
//                       documentation ```cs\ninterface IDefault\n```
//                       enclosing_range 45:4 51:5
      {
          void Log(string message)
//             ^^^ definition scip-dotnet nuget . . Main/Interfaces#IDefault#Log().
//                 documentation ```cs\nvoid IDefault.Log(string message)\n```
//                 enclosing_range 47:8 50:9
//                        ^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IDefault#Log().(message)
//                                documentation ```cs\nstring message\n```
//                                enclosing_range 47:17 47:31
          {
              Console.WriteLine(message);
//            ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
//                              ^^^^^^^ reference scip-dotnet nuget . . Main/Interfaces#IDefault#Log().(message)
          }
      }


      private interface IInherit : IOne, ITwo
//                      ^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IInherit#
//                               documentation ```cs\ninterface IInherit\n```
//                               relationship implementation scip-dotnet nuget . . Main/Interfaces#IOne#
//                               relationship implementation scip-dotnet nuget . . Main/Interfaces#ITwo#
//                               enclosing_range 54:4 56:5
//                                 ^^^^ reference scip-dotnet nuget . . Main/Interfaces#IOne#
//                                       ^^^^ reference scip-dotnet nuget . . Main/Interfaces#ITwo#
      {
      }

      public interface IGetNext<T> where T : IGetNext<T>
//                     ^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IGetNext#
//                              documentation ```cs\ninterface IGetNext<T> where T : IGetNext<T>\n```
//                              enclosing_range 58:4 64:5
//                              ^ definition local 0
//                                documentation ```cs\nT\n```
//                                enclosing_range 58:30 58:31
//                                       ^ reference local 0
//                                                    ^ reference local 0
      {
          static IGetNext<T> operator ++(IGetNext<T> other)
//                        ^ reference local 0
//                                                ^ reference local 0
//                                                   ^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IGetNext#op_Increment().(other)
//                                                         documentation ```cs\nIGetNext<T> other\n```
//                                                         enclosing_range 60:39 60:56
          {
              throw new NotImplementedException();
//                      ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
          }
      }

      private interface ITypeParameter<T1, T2> : ITwo where T1 : IOne where T2 : IThree
//                      ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#ITypeParameter#
//                                     documentation ```cs\ninterface ITypeParameter<T1, T2> where T1 : IOne where T2 : IThree\n```
//                                     relationship implementation scip-dotnet nuget . . Main/Interfaces#ITwo#
//                                     enclosing_range 66:4 68:5
//                                     ^^ definition local 1
//                                        documentation ```cs\nT1\n```
//                                        enclosing_range 66:37 66:39
//                                         ^^ definition local 2
//                                            documentation ```cs\nT2\n```
//                                            enclosing_range 66:41 66:43
//                                               ^^^^ reference scip-dotnet nuget . . Main/Interfaces#ITwo#
//                                                          ^^ reference local 1
//                                                               ^^^^ reference scip-dotnet nuget . . Main/Interfaces#IOne#
//                                                                          ^^ reference local 2
//                                                                               ^^^^^^ reference scip-dotnet nuget . . Main/Interfaces#IThree#
      {
      }
  }
