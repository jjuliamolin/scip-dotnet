  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Events
//             ^^^^^^ definition scip-dotnet nuget . . Main/Events#
//                    documentation ```cs\nclass Events\n```
//                    enclosing_range 4:0 28:1
  {
      public event EventHandler<int> Event1
//                                   ^^^^^^ definition scip-dotnet nuget . . Main/Events#Event1#
//                                          documentation ```cs\npublic event EventHandler<int> Events.Event1\n```
//                                          enclosing_range 7:4 11:5
      {
          add { }
          remove { }
      }

      public event EventHandler Event2
//                 ^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
//                              ^^^^^^ definition scip-dotnet nuget . . Main/Events#Event2#
//                                     documentation ```cs\npublic event EventHandler Events.Event2\n```
//                                     enclosing_range 13:4 17:5
      {
          add => addSomething();
//               ^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Events#addSomething().
          remove => removeSomething();
//                  ^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Events#removeSomething().
      }

      private void removeSomething()
//                 ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Events#removeSomething().
//                                 documentation ```cs\nprivate void Events.removeSomething()\n```
//                                 enclosing_range 19:4 22:5
      {
          throw new NotImplementedException();
//                  ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
      }

      private void addSomething()
//                 ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Events#addSomething().
//                              documentation ```cs\nprivate void Events.addSomething()\n```
//                              enclosing_range 24:4 27:5
      {
          throw new NotImplementedException();
//                  ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
      }
  }
