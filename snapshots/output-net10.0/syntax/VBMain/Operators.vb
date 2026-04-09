  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Class Operators
'                  ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#
'                            documentation ```vb\nClass Operators\n```
'                            enclosing_range 3:4 48:13
          Public Class PlusMinus
'                      ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                documentation ```vb\nClass PlusMinus\n```
'                                enclosing_range 5:8 17:17
              Public Shared Operator +(A As PlusMinus)
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_UnaryPlus().(A)
'                                        documentation ```vb\nA As PlusMinus\n```
'                                        enclosing_range 6:37 6:51
'                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#PlusMinus#
                  Return 0
              End Operator

              Public Shared Operator +(A As PlusMinus, B As PlusMinus)
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_Addition().(A)
'                                        documentation ```vb\nA As PlusMinus\n```
'                                        enclosing_range 10:37 10:51
'                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_Addition().(B)
'                                                        documentation ```vb\nB As PlusMinus\n```
'                                                        enclosing_range 10:53 10:67
'                                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#PlusMinus#
                  Return 0
              End Operator

              Public Shared Operator -(A As PlusMinus)
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_UnaryNegation().(A)
'                                        documentation ```vb\nA As PlusMinus\n```
'                                        enclosing_range 14:37 14:51
'                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#PlusMinus#
                  Return 0
              End Operator
          End Class

          Public Class TrueFalse
'                      ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                documentation ```vb\nClass TrueFalse\n```
'                                enclosing_range 19:8 47:17
              Public Shared Operator IsTrue(A As TrueFalse) As Boolean
'                                           ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_True().(A)
'                                             documentation ```vb\nA As TrueFalse\n```
'                                             enclosing_range 20:42 20:56
'                                                ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
                  Return True
              End Operator

              Public Shared Operator IsFalse(A As TrueFalse) As Boolean
'                                            ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_False().(A)
'                                              documentation ```vb\nA As TrueFalse\n```
'                                              enclosing_range 24:43 24:57
'                                                 ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
                  Return False
              End Operator

              Public Shared Operator =(A As TrueFalse, B As TrueFalse) As Boolean
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Equality().(A)
'                                        documentation ```vb\nA As TrueFalse\n```
'                                        enclosing_range 28:37 28:51
'                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                      ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Equality().(B)
'                                                        documentation ```vb\nB As TrueFalse\n```
'                                                        enclosing_range 28:53 28:67
'                                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
                  Return True
              End Operator

              Public Shared Operator <>(A As TrueFalse, B As TrueFalse) As Boolean
'                                       ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Inequality().(A)
'                                         documentation ```vb\nA As TrueFalse\n```
'                                         enclosing_range 32:38 32:52
'                                            ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                       ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Inequality().(B)
'                                                         documentation ```vb\nB As TrueFalse\n```
'                                                         enclosing_range 32:54 32:68
'                                                            ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
                  Return True
              End Operator

              Public Overrides Function Equals(obj As Object) As Boolean
'                                       ^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().
'                                              documentation ```vb\nPublic Overrides Function TrueFalse.Equals(obj As Object) As Boolean\n```
'                                              relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#Equals().
'                                              enclosing_range 36:12 41:24
'                                              ^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                                                  documentation ```vb\nobj As Object\n```
'                                                  enclosing_range 36:45 36:58
                  If ReferenceEquals(Nothing, obj) Then Return False
'                    ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ReferenceEquals().
'                                             ^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
                  If ReferenceEquals(Me, obj) Then Return True
'                    ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ReferenceEquals().
'                                        ^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
                  If obj.GetType() <> Me.GetType() Then Return False
'                    ^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                        ^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetType().
'                                        ^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetType().
                  Return Equals(CType(obj, TrueFalse))
'                        ^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().
'                                     ^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                                          ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
              End Function

              Public Overrides Function GetHashCode() As Integer
'                                       ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#GetHashCode().
'                                                   documentation ```vb\nPublic Overrides Function TrueFalse.GetHashCode() As Integer\n```
'                                                   relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetHashCode().
'                                                   enclosing_range 43:12 45:24
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
              End Function

          End Class
      End Class
  End Namespace
