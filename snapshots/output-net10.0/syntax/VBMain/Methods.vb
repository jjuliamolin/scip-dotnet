  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Class Methods
'                  ^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#
'                          documentation ```vb\nClass Methods\n```
'                          enclosing_range 3:4 85:13
          Private Function SingleParameter(ByVal b As Integer) As Integer
'                          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#SingleParameter().
'                                          documentation ```vb\nPrivate Function Methods.SingleParameter(b As Integer) As Integer\n```
'                                          enclosing_range 5:8 7:20
'                                                ^ definition scip-dotnet nuget . . VBMain/Methods#SingleParameter().(b)
'                                                  documentation ```vb\nb As Integer\n```
'                                                  enclosing_range 5:41 5:59
              Return b
'                    ^ reference scip-dotnet nuget . . VBMain/Methods#SingleParameter().(b)
          End Function

          Private Function TwoParameters(ByVal a As Integer, ByVal b As Integer) As Integer
'                          ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#TwoParameters().
'                                        documentation ```vb\nPrivate Function Methods.TwoParameters(a As Integer, b As Integer) As Integer\n```
'                                        enclosing_range 9:8 11:20
'                                              ^ definition scip-dotnet nuget . . VBMain/Methods#TwoParameters().(a)
'                                                documentation ```vb\na As Integer\n```
'                                                enclosing_range 9:39 9:57
'                                                                  ^ definition scip-dotnet nuget . . VBMain/Methods#TwoParameters().(b)
'                                                                    documentation ```vb\nb As Integer\n```
'                                                                    enclosing_range 9:59 9:77
              Return a + b
'                    ^ reference scip-dotnet nuget . . VBMain/Methods#TwoParameters().(a)
'                        ^ reference scip-dotnet nuget . . VBMain/Methods#TwoParameters().(b)
          End Function

          Private Function Overload1(ByVal a As Integer) As Integer
'                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#Overload1().
'                                    documentation ```vb\nPrivate Function Methods.Overload1(a As Integer) As Integer\n```
'                                    enclosing_range 13:8 15:20
'                                          ^ definition scip-dotnet nuget . . VBMain/Methods#Overload1().(a)
'                                            documentation ```vb\na As Integer\n```
'                                            enclosing_range 13:35 13:53
              Return a
'                    ^ reference scip-dotnet nuget . . VBMain/Methods#Overload1().(a)
          End Function

          Private Function Overload1(ByVal a As Integer, ByVal b As Integer) As Integer
'                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#Overload1(+1).
'                                    documentation ```vb\nPrivate Function Methods.Overload1(a As Integer, b As Integer) As Integer\n```
'                                    enclosing_range 17:8 19:20
'                                          ^ definition scip-dotnet nuget . . VBMain/Methods#Overload1(+1).(a)
'                                            documentation ```vb\na As Integer\n```
'                                            enclosing_range 17:35 17:53
'                                                              ^ definition scip-dotnet nuget . . VBMain/Methods#Overload1(+1).(b)
'                                                                documentation ```vb\nb As Integer\n```
'                                                                enclosing_range 17:55 17:73
              Return a + b
'                    ^ reference scip-dotnet nuget . . VBMain/Methods#Overload1(+1).(a)
'                        ^ reference scip-dotnet nuget . . VBMain/Methods#Overload1(+1).(b)
          End Function

          Private Function Generic(Of T)(ByVal param As T) As T
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#Generic().
'                                  documentation ```vb\nPrivate Function Methods.Generic(Of T)(param As T) As T\n```
'                                  enclosing_range 21:8 23:20
'                                     ^ definition local 0
'                                       documentation ```vb\nT\n```
'                                       enclosing_range 21:36 21:37
'                                              ^^^^^ definition scip-dotnet nuget . . VBMain/Methods#Generic().(param)
'                                                    documentation ```vb\nparam As T\n```
'                                                    enclosing_range 21:39 21:55
'                                                       ^ reference local 0
'                                                             ^ reference local 0
              Return param
'                    ^^^^^ reference scip-dotnet nuget . . VBMain/Methods#Generic().(param)
          End Function

          Private Function GenericConstraint(Of T As New)(ByVal param As T) As T
'                          ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#GenericConstraint().
'                                            documentation ```vb\nPrivate Function Methods.GenericConstraint(Of T As New)(param As T) As T\n```
'                                            enclosing_range 25:8 27:20
'                                               ^ definition local 1
'                                                 documentation ```vb\nT\n```
'                                                 enclosing_range 25:46 25:54
'                                                               ^^^^^ definition scip-dotnet nuget . . VBMain/Methods#GenericConstraint().(param)
'                                                                     documentation ```vb\nparam As T\n```
'                                                                     enclosing_range 25:56 25:72
'                                                                        ^ reference local 1
'                                                                              ^ reference local 1
              Return param
'                    ^^^^^ reference scip-dotnet nuget . . VBMain/Methods#GenericConstraint().(param)
          End Function

          Private Sub DefaultParameter(ByVal Optional a As Integer = 5)
'                     ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameter().
'                                      documentation ```vb\nPrivate Sub Methods.DefaultParameter([a As Integer = 5])\n```
'                                      enclosing_range 29:8 30:15
'                                                     ^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameter().(a)
'                                                       documentation ```vb\n[a As Integer = 5]\n```
'                                                       enclosing_range 29:37 29:68
          End Sub

          Private Function DefaultParameterOverload(ByVal Optional a As Integer = 5) As Integer
'                          ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload().
'                                                   documentation ```vb\nPrivate Function Methods.DefaultParameterOverload([a As Integer = 5]) As Integer\n```
'                                                   enclosing_range 32:8 34:20
'                                                                  ^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload().(a)
'                                                                    documentation ```vb\n[a As Integer = 5]\n```
'                                                                    enclosing_range 32:50 32:81
              Return DefaultParameterOverload(a, a)
'                    ^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload(+1).
'                                             ^ reference scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload().(a)
'                                                ^ reference scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload().(a)
          End Function

          Private Function DefaultParameterOverload(ByVal a As Integer, ByVal b As Integer) As Integer
'                          ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload(+1).
'                                                   documentation ```vb\nPrivate Function Methods.DefaultParameterOverload(a As Integer, b As Integer) As Integer\n```
'                                                   enclosing_range 36:8 38:20
'                                                         ^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload(+1).(a)
'                                                           documentation ```vb\na As Integer\n```
'                                                           enclosing_range 36:50 36:68
'                                                                             ^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload(+1).(b)
'                                                                               documentation ```vb\nb As Integer\n```
'                                                                               enclosing_range 36:70 36:88
              Return DefaultParameterOverload()
'                    ^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload().
          End Function

          Interface IHello
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#IHello#
'                          documentation ```vb\nInterface IHello\n```
'                          enclosing_range 40:8 42:21
              Function Hello() As String
'                      ^^^^^ definition scip-dotnet nuget . . VBMain/Methods#IHello#Hello().
'                            documentation ```vb\nFunction IHello.Hello() As String\n```
'                            enclosing_range 41:12 41:38
          End Interface

          Class ImplementsHello
'               ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#ImplementsHello#
'                               documentation ```vb\nClass ImplementsHello\n```
'                               relationship implementation scip-dotnet nuget . . VBMain/Methods#IHello#
'                               enclosing_range 44:8 51:17
              Implements IHello
'                        ^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#IHello#

              Private Function Hello() As String Implements IHello.Hello
'                              ^^^^^ definition scip-dotnet nuget . . VBMain/Methods#ImplementsHello#Hello().
'                                    documentation ```vb\nPrivate Function ImplementsHello.Hello() As String\n```
'                                    relationship implementation reference scip-dotnet nuget . . VBMain/Methods#IHello#Hello().
'                                    enclosing_range 47:12 49:24
'                                                           ^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#IHello#
'                                                                  ^^^^^ reference scip-dotnet nuget . . VBMain/Methods#IHello#Hello().
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
              End Function

          End Class

          Class InheritedOverloads1
'               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                   documentation ```vb\nClass InheritedOverloads1\n```
'                                   enclosing_range 53:8 56:17
              Public Sub Method()
'                        ^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#Method().
'                               documentation ```vb\nPublic Sub InheritedOverloads1.Method()\n```
'                               enclosing_range 54:12 55:19
              End Sub
          End Class

          Class InheritedOverloads2
'               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
'                                   documentation ```vb\nClass InheritedOverloads2\n```
'                                   relationship implementation scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                   enclosing_range 58:8 64:17
              Inherits InheritedOverloads1
'                      ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#

              Public Function Method(ByVal parameter As Integer) As Integer
'                             ^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#Method().
'                                    documentation ```vb\nPublic Function InheritedOverloads2.Method(parameter As Integer) As Integer\n```
'                                    enclosing_range 61:12 63:24
'                                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#Method().(parameter)
'                                                    documentation ```vb\nparameter As Integer\n```
'                                                    enclosing_range 61:35 61:61
                  Return parameter
'                        ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#Method().(parameter)
              End Function
          End Class

          Class InheritedOverloads3
'               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#
'                                   documentation ```vb\nClass InheritedOverloads3\n```
'                                   relationship implementation scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
'                                   relationship implementation scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                   enclosing_range 66:8 72:17
              Inherits InheritedOverloads2
'                      ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#

              Public Function Method(ByVal parameter As String) As String
'                             ^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#Method().
'                                    documentation ```vb\nPublic Function InheritedOverloads3.Method(parameter As String) As String\n```
'                                    enclosing_range 69:12 71:24
'                                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#Method().(parameter)
'                                                    documentation ```vb\nparameter As String\n```
'                                                    enclosing_range 69:35 69:60
                  Return parameter
'                        ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#Method().(parameter)
              End Function
          End Class

          Public Shared Sub InheritedOverloads()
'                           ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads().
'                                              documentation ```vb\nPublic Shared Sub Methods.InheritedOverloads()\n```
'                                              enclosing_range 74:8 84:15
              Dim a As InheritedOverloads1 = New InheritedOverloads1
'                 ^ definition local 2
'                   documentation ```vb\na As Class InheritedOverloads1\n```
'                   enclosing_range 75:12 75:66
'                      ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                                ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
              a.Method()
'             ^ reference local 2
'               ^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#Method().
              Dim b As InheritedOverloads2 = New InheritedOverloads2
'                 ^ definition local 3
'                   documentation ```vb\nb As Class InheritedOverloads2\n```
'                   enclosing_range 77:12 77:66
'                      ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
'                                                ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
              DirectCast(b, InheritedOverloads1).Method()
'                        ^ reference local 3
'                           ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                                ^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#Method().
              b.Method(42)
'             ^ reference local 3
'               ^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#Method().
              Dim c As InheritedOverloads3 = New InheritedOverloads3
'                 ^ definition local 4
'                   documentation ```vb\nc As Class InheritedOverloads3\n```
'                   enclosing_range 80:12 80:66
'                      ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#
'                                                ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#
              DirectCast(c, InheritedOverloads1).Method()
'                        ^ reference local 4
'                           ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                                ^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#Method().
              DirectCast(c, InheritedOverloads2).Method(42)
'                        ^ reference local 4
'                           ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
'                                                ^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#Method().
              c.Method("42")
'             ^ reference local 4
'               ^^^^^^ reference scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#Method().
          End Sub
      End Class
  End Namespace
