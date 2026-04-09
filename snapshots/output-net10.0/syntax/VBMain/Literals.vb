  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Class Literals
'                  ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Literals#
'                           documentation ```vb\nClass Literals\n```
'                           enclosing_range 3:4 12:13
          Private Function Interpolation() As String
'                          ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Literals#Interpolation().
'                                        documentation ```vb\nPrivate Function Literals.Interpolation() As String\n```
'                                        enclosing_range 5:8 11:20
              Dim a = 1
'                 ^ definition local 0
'                   documentation ```vb\na As Integer\n```
'                   enclosing_range 6:12 6:21
              Dim b = 2
'                 ^ definition local 1
'                   documentation ```vb\nb As Integer\n```
'                   enclosing_range 7:12 7:21
              Dim c = 3
'                 ^ definition local 2
'                   documentation ```vb\nc As Integer\n```
'                   enclosing_range 8:12 8:21
              Dim d = 3
'                 ^ definition local 3
'                   documentation ```vb\nd As Integer\n```
'                   enclosing_range 9:12 9:21
              Return $"a={a} b={b} c={c} d={d}"
'                         ^ reference local 0
'                               ^ reference local 1
'                                     ^ reference local 2
'                                           ^ reference local 3
          End Function
      End Class
  End Namespace
