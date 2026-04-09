  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class QuerySyntax
//             ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#
//                         documentation ```cs\nclass QuerySyntax\n```
//                         enclosing_range 4:0 77:1
  {
      List<IGeneric> sourceA = new List<IGeneric>();
//         ^^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#
//                   ^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#sourceA.
//                           documentation ```cs\nprivate List<IGeneric> QuerySyntax.sourceA\n```
//                           enclosing_range 7:4 7:50
//                                      ^^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#
      List<IGeneric> sourceB = new List<IGeneric>();
//         ^^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#
//                   ^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#sourceB.
//                           documentation ```cs\nprivate List<IGeneric> QuerySyntax.sourceB\n```
//                           enclosing_range 8:4 8:50
//                                      ^^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#

      interface IGeneric
//              ^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#IGeneric#
//                       documentation ```cs\ninterface IGeneric\n```
//                       enclosing_range 10:4 13:5
      {
          string Method();
//               ^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                      documentation ```cs\nstring IGeneric.Method()\n```
//                      enclosing_range 12:8 12:24
      }

      void Select()
//         ^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Select().
//                documentation ```cs\nprivate void QuerySyntax.Select()\n```
//                enclosing_range 15:4 18:5
      {
          var x = from a in sourceA select a.Method();
//            ^ definition local 0
//              documentation ```cs\nIEnumerable<string>? x\n```
//              enclosing_range 17:8 17:52
//                     ^ definition local 1
//                       documentation ```cs\n? a\n```
//                       enclosing_range 17:16 17:33
//                          ^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#sourceA.
//                                         ^ reference local 1
//                                           ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
      }

      void Projection()
//         ^^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Projection().
//                    documentation ```cs\nprivate void QuerySyntax.Projection()\n```
//                    enclosing_range 20:4 24:5
      {
          var x = from a in sourceA select new { Name = a.Method() };
//            ^ definition local 2
//              documentation ```cs\nIEnumerable<<anonymous type: string Name>>? x\n```
//              enclosing_range 22:8 22:67
//                     ^ definition local 3
//                       documentation ```cs\n? a\n```
//                       enclosing_range 22:16 22:33
//                          ^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#sourceA.
//                                               ^^^^ reference local 5
//                                                      ^ reference local 3
//                                                        ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
          var b = from a in x select a.Name;
//            ^ definition local 6
//              documentation ```cs\nIEnumerable<string>? b\n```
//              enclosing_range 23:8 23:42
//                     ^ definition local 7
//                       documentation ```cs\n? a\n```
//                       enclosing_range 23:16 23:27
//                          ^ reference local 2
//                                   ^ reference local 7
//                                     ^^^^ reference local 5
      }

      void Where()
//         ^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Where().
//               documentation ```cs\nprivate void QuerySyntax.Where()\n```
//               enclosing_range 26:4 29:5
      {
          var x = from a in sourceA where a.Method().StartsWith("a") select a;
//            ^ definition local 8
//              documentation ```cs\nIEnumerable<IGeneric>? x\n```
//              enclosing_range 28:8 28:76
//                     ^ definition local 9
//                       documentation ```cs\n? a\n```
//                       enclosing_range 28:16 28:33
//                          ^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#sourceA.
//                                        ^ reference local 9
//                                          ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                                   ^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/String#StartsWith(+1).
//                                                                          ^ reference local 9
      }

      void Let()
//         ^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Let().
//             documentation ```cs\nprivate void QuerySyntax.Let()\n```
//             enclosing_range 31:4 36:5
      {
          var x = from a in sourceA
//            ^ definition local 10
//              documentation ```cs\nIEnumerable<<anonymous type: string A, string B>>? x\n```
//              enclosing_range 33:8 35:25
//                     ^ definition local 11
//                       documentation ```cs\n? a\n```
//                       enclosing_range 33:16 33:33
//                          ^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#sourceA.
                  let z = new { A = a.Method(), B = a.Method() }
//                    ^ definition local 12
//                      documentation ```cs\n? z\n```
//                      enclosing_range 34:16 34:62
//                              ^ reference local 14
//                                  ^ reference local 11
//                                    ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                              ^ reference local 15
//                                                  ^ reference local 11
//                                                    ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
                  select z;
//                       ^ reference local 12
      }

      void Join()
//         ^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Join().
//              documentation ```cs\nprivate void QuerySyntax.Join()\n```
//              enclosing_range 38:4 43:5
      {
          var x = from a in sourceA
//            ^ definition local 16
//              documentation ```cs\nIEnumerable<<anonymous type: string A, string B>>? x\n```
//              enclosing_range 40:8 42:62
//                     ^ definition local 17
//                       documentation ```cs\n? a\n```
//                       enclosing_range 40:16 40:33
//                          ^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#sourceA.
                  join b in sourceB on a.Method() equals b.Method()
//                     ^ definition local 18
//                       documentation ```cs\n? b\n```
//                       enclosing_range 41:16 41:65
//                          ^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#sourceB.
//                                     ^ reference local 17
//                                       ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                                       ^ reference local 18
//                                                         ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
                  select new { A = a.Method(), B = b.Method() };
//                             ^ reference local 14
//                                 ^ reference local 17
//                                   ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                             ^ reference local 15
//                                                 ^ reference local 18
//                                                   ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
      }

      void MultipleFrom()
//         ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#MultipleFrom().
//                      documentation ```cs\nprivate void QuerySyntax.MultipleFrom()\n```
//                      enclosing_range 45:4 51:5
      {
          var x = from a in sourceA
//            ^ definition local 19
//              documentation ```cs\nIEnumerable<<anonymous type: string A, string B>>? x\n```
//              enclosing_range 47:8 50:62
//                     ^ definition local 20
//                       documentation ```cs\n? a\n```
//                       enclosing_range 47:16 47:33
//                          ^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#sourceA.
                  from b in sourceB
//                     ^ definition local 21
//                       documentation ```cs\n? b\n```
//                       enclosing_range 48:16 48:33
//                          ^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#sourceB.
                  where a.Method() == b.Method()
//                      ^ reference local 20
//                        ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                    ^ reference local 21
//                                      ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
                  select new { A = a.Method(), B = b.Method() };
//                             ^ reference local 14
//                                 ^ reference local 20
//                                   ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                             ^ reference local 15
//                                                 ^ reference local 21
//                                                   ^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
      }

      void JoinInto(List<Student> students1, List<Student> students2)
//         ^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#JoinInto().
//                  documentation ```cs\nprivate void QuerySyntax.JoinInto(List<Student> students1, List<Student> students2)\n```
//                  enclosing_range 53:4 59:5
//                       ^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#Student#
//                                ^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#JoinInto().(students1)
//                                          documentation ```cs\nList<Student> students1\n```
//                                          enclosing_range 53:18 53:41
//                                                ^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#Student#
//                                                         ^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#JoinInto().(students2)
//                                                                   documentation ```cs\nList<Student> students2\n```
//                                                                   enclosing_range 53:43 53:66
      {
          var innerGroupJoinQuery =
//            ^^^^^^^^^^^^^^^^^^^ definition local 22
//                                documentation ```cs\nIEnumerable<<anonymous type: string Student, interface IEnumerable<Student> Students>>? innerGroupJoinQuery\n```
//                                enclosing_range 55:8 58:77
              from student1 in students1
//                 ^^^^^^^^ definition local 23
//                          documentation ```cs\n? student1\n```
//                          enclosing_range 56:12 56:38
//                             ^^^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#JoinInto().(students1)
              join student2 in students2 on student1.ID equals student2.ID into studentGroup
//                 ^^^^^^^^ definition local 24
//                          documentation ```cs\n? student2\n```
//                          enclosing_range 57:12 57:90
//                             ^^^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#JoinInto().(students2)
//                                          ^^^^^^^^ reference local 23
//                                                   ^^ reference scip-dotnet nuget . . Main/QuerySyntax#Student#ID.
//                                                             ^^^^^^^^ reference local 24
//                                                                      ^^ reference scip-dotnet nuget . . Main/QuerySyntax#Student#ID.
//                                                                              ^^^^^^^^^^^^ definition local 25
//                                                                                           documentation ```cs\n? studentGroup\n```
//                                                                                           enclosing_range 57:73 57:90
              select new { Student = student1.First, Students = studentGroup };
//                         ^^^^^^^ reference local 27
//                                   ^^^^^^^^ reference local 23
//                                            ^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#Student#First.
//                                                   ^^^^^^^^ reference local 28
//                                                              ^^^^^^^^^^^^ reference local 25
      }

      void Continuation(List<Student> students)
//         ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Continuation().
//                      documentation ```cs\nprivate void QuerySyntax.Continuation(List<Student> students)\n```
//                      enclosing_range 61:4 69:5
//                           ^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#Student#
//                                    ^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Continuation().(students)
//                                             documentation ```cs\nList<Student> students\n```
//                                             enclosing_range 61:22 61:44
      {
          var sortedGroups =
//            ^^^^^^^^^^^^ definition local 29
//                         documentation ```cs\nIOrderedEnumerable<IGrouping<char, Student>>? sortedGroups\n```
//                         enclosing_range 63:8 68:28
              from student in students
//                 ^^^^^^^ definition local 30
//                         documentation ```cs\n? student\n```
//                         enclosing_range 64:12 64:36
//                            ^^^^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#Continuation().(students)
              orderby student.Last, student.First
//                    ^^^^^^^ reference local 30
//                            ^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#Student#Last.
//                                  ^^^^^^^ reference local 30
//                                          ^^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#Student#First.
              group student by student.Last[0] into newGroup
//                  ^^^^^^^ reference local 30
//                             ^^^^^^^ reference local 30
//                                     ^^^^ reference scip-dotnet nuget . . Main/QuerySyntax#Student#Last.
//                                                  ^^^^^^^^ definition local 31
//                                                           documentation ```cs\n? newGroup\n```
//                                                           enclosing_range 66:45 68:27
              orderby newGroup.Key
//                    ^^^^^^^^ reference local 31
//                             ^^^ reference scip-dotnet nuget System.Linq 10.0.0.0 Linq/IGrouping#Key.
              select newGroup;
//                   ^^^^^^^^ reference local 31
      }

      private class Student
//                  ^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Student#
//                          documentation ```cs\nclass Student\n```
//                          enclosing_range 71:4 76:5
      {
          public string First { get; set; }
//                      ^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Student#First.
//                            documentation ```cs\npublic string Student.First { get; set; }\n```
//                            enclosing_range 73:8 73:41
          public string Last { get; set; }
//                      ^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Student#Last.
//                           documentation ```cs\npublic string Student.Last { get; set; }\n```
//                           enclosing_range 74:8 74:40
          public int ID { get; set; }
//                   ^^ definition scip-dotnet nuget . . Main/QuerySyntax#Student#ID.
//                      documentation ```cs\npublic int Student.ID { get; set; }\n```
//                      enclosing_range 75:8 75:35
      }
  }
