  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Operators
//             ^^^^^^^^^ definition scip-dotnet nuget . . Main/Operators#
//                       documentation ```cs\nclass Operators\n```
//                       enclosing_range 4:0 65:1
  {
      class PlusMinus
//          ^^^^^^^^^ definition scip-dotnet nuget . . Main/Operators#PlusMinus#
//                    documentation ```cs\nclass PlusMinus\n```
//                    enclosing_range 7:4 23:5
      {
          public static int operator +(PlusMinus a)
//                                     ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#PlusMinus#
//                                               ^ definition scip-dotnet nuget . . Main/Operators#PlusMinus#op_UnaryPlus().(a)
//                                                 documentation ```cs\nPlusMinus a\n```
//                                                 enclosing_range 9:37 9:48
          {
              return 0;
          }

          public static int operator +(PlusMinus a, PlusMinus b)
//                                     ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#PlusMinus#
//                                               ^ definition scip-dotnet nuget . . Main/Operators#PlusMinus#op_Addition().(a)
//                                                 documentation ```cs\nPlusMinus a\n```
//                                                 enclosing_range 14:37 14:48
//                                                  ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#PlusMinus#
//                                                            ^ definition scip-dotnet nuget . . Main/Operators#PlusMinus#op_Addition().(b)
//                                                              documentation ```cs\nPlusMinus b\n```
//                                                              enclosing_range 14:50 14:61
          {
              return 0;
          }

          public static int operator -(PlusMinus a)
//                                     ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#PlusMinus#
//                                               ^ definition scip-dotnet nuget . . Main/Operators#PlusMinus#op_UnaryNegation().(a)
//                                                 documentation ```cs\nPlusMinus a\n```
//                                                 enclosing_range 19:37 19:48
          {
              return 0;
          }
      }

      class TrueFalse
//          ^^^^^^^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#
//                    documentation ```cs\nclass TrueFalse\n```
//                    enclosing_range 25:4 64:5
      {
          protected bool Equals(TrueFalse other)
//                       ^^^^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#Equals().
//                              documentation ```cs\nprotected bool TrueFalse.Equals(TrueFalse other)\n```
//                              enclosing_range 27:8 30:9
//                              ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                        ^^^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#Equals().(other)
//                                              documentation ```cs\nTrueFalse other\n```
//                                              enclosing_range 27:30 27:45
          {
              throw new NotImplementedException();
//                      ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
          }

          public override bool Equals(object? obj)
//                             ^^^^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).
//                                    documentation ```cs\npublic override bool TrueFalse.Equals(object? obj)\n```
//                                    relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#Equals().
//                                    enclosing_range 32:8 38:9
//                                            ^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).(obj)
//                                                documentation ```cs\nobject? obj\n```
//                                                enclosing_range 32:36 32:47
          {
              if (ReferenceEquals(null, obj)) return false;
//                ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ReferenceEquals().
//                                      ^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).(obj)
              if (ReferenceEquals(this, obj)) return true;
//                ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ReferenceEquals().
//                                      ^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).(obj)
              if (obj.GetType() != this.GetType()) return false;
//                ^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).(obj)
//                    ^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetType().
//                                      ^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetType().
              return Equals((TrueFalse)obj);
//                   ^^^^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#Equals().
//                           ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                     ^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).(obj)
          }

          public override int GetHashCode()
//                            ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#GetHashCode().
//                                        documentation ```cs\npublic override int TrueFalse.GetHashCode()\n```
//                                        relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetHashCode().
//                                        enclosing_range 40:8 43:9
          {
              throw new NotImplementedException();
//                      ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
          }

          public static bool operator true(TrueFalse a)
//                                         ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                   ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_True().(a)
//                                                     documentation ```cs\nTrueFalse a\n```
//                                                     enclosing_range 45:41 45:52
          {
              return true;
          }

          public static bool operator false(TrueFalse a)
//                                          ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                    ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_False().(a)
//                                                      documentation ```cs\nTrueFalse a\n```
//                                                      enclosing_range 50:42 50:53
          {
              return false;
          }

          public static bool operator !=(TrueFalse a, TrueFalse b)
//                                       ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                 ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_Inequality().(a)
//                                                   documentation ```cs\nTrueFalse a\n```
//                                                   enclosing_range 55:39 55:50
//                                                    ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                              ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_Inequality().(b)
//                                                                documentation ```cs\nTrueFalse b\n```
//                                                                enclosing_range 55:52 55:63
          {
              return true;
          }

          public static bool operator ==(TrueFalse a, TrueFalse b)
//                                       ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                 ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_Equality().(a)
//                                                   documentation ```cs\nTrueFalse a\n```
//                                                   enclosing_range 60:39 60:50
//                                                    ^^^^^^^^^ reference scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                              ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_Equality().(b)
//                                                                documentation ```cs\nTrueFalse b\n```
//                                                                enclosing_range 60:52 60:63
          {
              return true;
          }
      }
  }
