  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Records
//             ^^^^^^^ definition scip-dotnet nuget . . Main/Records#
//                     documentation ```cs\nclass Records\n```
//                     enclosing_range 4:0 61:1
  {
      record Basic
//           ^^^^^ definition scip-dotnet nuget . . Main/Records#Basic#
//                 documentation ```cs\nrecord Basic\n```
//                 relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                 enclosing_range 7:4 10:5
      {
          int Age { get; init; }
//            ^^^ definition scip-dotnet nuget . . Main/Records#Basic#Age.
//                documentation ```cs\nprivate int Basic.Age { get; init; }\n```
//                enclosing_range 9:8 9:30
      }

      record struct Struct
//                  ^^^^^^ definition scip-dotnet nuget . . Main/Records#Struct#
//                         documentation ```cs\nrecord struct Struct\n```
//                         relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                         enclosing_range 12:4 15:5
      {
          int Age { get; init; }
//            ^^^ definition scip-dotnet nuget . . Main/Records#Struct#Age.
//                documentation ```cs\nprivate int Struct.Age { get; init; }\n```
//                enclosing_range 14:8 14:30
      }

      record class Class
//                 ^^^^^ definition scip-dotnet nuget . . Main/Records#Class#
//                       documentation ```cs\nrecord Class\n```
//                       relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                       enclosing_range 17:4 20:5
      {
          int Age { get; init; }
//            ^^^ definition scip-dotnet nuget . . Main/Records#Class#Age.
//                documentation ```cs\nprivate int Class.Age { get; init; }\n```
//                enclosing_range 19:8 19:30
      }

      public record TypeParameterConstraint<T> where T : struct
//                  ^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#TypeParameterConstraint#
//                                          documentation ```cs\nrecord TypeParameterConstraint<T> where T : struct\n```
//                                          relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                                          enclosing_range 22:4 24:5
//                                          ^ definition local 0
//                                            documentation ```cs\nT\n```
//                                            enclosing_range 22:42 22:43
//                                                   ^ reference local 0
      {
      }

      interface I1
//              ^^ definition scip-dotnet nuget . . Main/Records#I1#
//                 documentation ```cs\ninterface I1\n```
//                 enclosing_range 26:4 28:6
      {
      };

      interface I2
//              ^^ definition scip-dotnet nuget . . Main/Records#I2#
//                 documentation ```cs\ninterface I2\n```
//                 enclosing_range 30:4 32:6
      {
      };


      record Person(string FirstName, string LastName) : I1, I2
//           ^^^^^^ definition scip-dotnet nuget . . Main/Records#Person#
//                  documentation ```cs\nrecord Person\n```
//                  relationship implementation scip-dotnet nuget . . Main/Records#I1#
//                  relationship implementation scip-dotnet nuget . . Main/Records#I2#
//                  relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                  enclosing_range 35:4 40:6
//                         ^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Person#`.ctor`().(FirstName)
//                                   documentation ```cs\nstring FirstName\n```
//                                   enclosing_range 35:18 35:34
//                                           ^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Person#`.ctor`().(LastName)
//                                                    documentation ```cs\nstring LastName\n```
//                                                    enclosing_range 35:36 35:51
//                                                       ^^ reference scip-dotnet nuget . . Main/Records#I1#
//                                                           ^^ reference scip-dotnet nuget . . Main/Records#I2#
      {
          public Person(string FirstName) : this(FirstName, FirstName)
//               ^^^^^^ definition scip-dotnet nuget . . Main/Records#Person#`.ctor`(+1).
//                      documentation ```cs\npublic Person.Person(string FirstName)\n```
//                      enclosing_range 37:8 39:9
//                             ^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Person#`.ctor`(+1).(FirstName)
//                                       documentation ```cs\nstring FirstName\n```
//                                       enclosing_range 37:22 37:38
//                                               ^^^^^^^^^ reference scip-dotnet nuget . . Main/Records#Person#`.ctor`(+1).(FirstName)
//                                                          ^^^^^^^^^ reference scip-dotnet nuget . . Main/Records#Person#`.ctor`(+1).(FirstName)
          {
          }
      };

      record Teacher(string FirstName, string LastName, string Subject) : Person(FirstName, LastName), I1, I2;
//           ^^^^^^^ definition scip-dotnet nuget . . Main/Records#Teacher#
//                   documentation ```cs\nrecord Teacher\n```
//                   relationship implementation scip-dotnet nuget . . Main/Records#Person#
//                   relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                   relationship implementation scip-dotnet nuget . . Main/Records#I1#
//                   relationship implementation scip-dotnet nuget . . Main/Records#I2#
//                   relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                   enclosing_range 42:4 42:108
//                          ^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Teacher#`.ctor`().(FirstName)
//                                    documentation ```cs\nstring FirstName\n```
//                                    enclosing_range 42:19 42:35
//                                            ^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Teacher#`.ctor`().(LastName)
//                                                     documentation ```cs\nstring LastName\n```
//                                                     enclosing_range 42:37 42:52
//                                                             ^^^^^^^ definition scip-dotnet nuget . . Main/Records#Teacher#`.ctor`().(Subject)
//                                                                     documentation ```cs\nstring Subject\n```
//                                                                     enclosing_range 42:54 42:68
//                                                                        ^^^^^^ reference scip-dotnet nuget . . Main/Records#Person#
//                                                                               ^^^^^^^^^ reference scip-dotnet nuget . . Main/Records#Teacher#`.ctor`().(FirstName)
//                                                                                          ^^^^^^^^ reference scip-dotnet nuget . . Main/Records#Teacher#`.ctor`().(LastName)
//                                                                                                     ^^ reference scip-dotnet nuget . . Main/Records#I1#
//                                                                                                         ^^ reference scip-dotnet nuget . . Main/Records#I2#

      void UsingRecords()
//         ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#UsingRecords().
//                      documentation ```cs\nprivate void Records.UsingRecords()\n```
//                      enclosing_range 44:4 48:5
      {
          var person = new Person("a", "b");
//            ^^^^^^ definition local 1
//                   documentation ```cs\nPerson? person\n```
//                   enclosing_range 46:8 46:42
//                         ^^^^^^ reference scip-dotnet nuget . . Main/Records#Person#
          var teacher = new Teacher("a", "b", "c");
//            ^^^^^^^ definition local 2
//                    documentation ```cs\nTeacher? teacher\n```
//                    enclosing_range 47:8 47:49
//                          ^^^^^^^ reference scip-dotnet nuget . . Main/Records#Teacher#
      }

      record I3<T>;
//           ^^ definition scip-dotnet nuget . . Main/Records#I3#
//              documentation ```cs\nrecord I3<T>\n```
//              relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//              enclosing_range 50:4 50:17
//              ^ definition local 3
//                documentation ```cs\nT\n```
//                enclosing_range 50:14 50:15

      record Teacher2() : I3<Person>(), I1;
//           ^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Teacher2#
//                    documentation ```cs\nrecord Teacher2\n```
//                    relationship implementation scip-dotnet nuget . . Main/Records#I3#
//                    relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                    relationship implementation scip-dotnet nuget . . Main/Records#I1#
//                    relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                    enclosing_range 52:4 52:41
//                           ^^^^^^ reference scip-dotnet nuget . . Main/Records#Person#
//                                      ^^ reference scip-dotnet nuget . . Main/Records#I1#

      record SealedToString
//           ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#SealedToString#
//                          documentation ```cs\nrecord SealedToString\n```
//                          relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                          enclosing_range 54:4 60:5
      {
          public sealed override string ToString()
//                                      ^^^^^^^^ definition scip-dotnet nuget . . Main/Records#SealedToString#ToString().
//                                               documentation ```cs\npublic override sealed string SealedToString.ToString()\n```
//                                               relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ToString().
//                                               enclosing_range 56:8 59:9
          {
              return "";
          }
      }
  }
