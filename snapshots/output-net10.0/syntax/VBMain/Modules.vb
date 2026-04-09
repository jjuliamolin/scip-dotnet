  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Module Modules
'                   ^^^^^^^ definition scip-dotnet nuget . . VBMain/Modules#
'                           documentation ```vb\nModule Modules\n```
'                           enclosing_range 3:4 12:14
          Private Function [Function](ByVal b As Integer) As Integer
'                          ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Modules#Function().
'                                     documentation ```vb\nPrivate Function Modules.Function(b As Integer) As Integer\n```
'                                     enclosing_range 5:8 7:20
'                                           ^ definition scip-dotnet nuget . . VBMain/Modules#Function().(b)
'                                             documentation ```vb\nb As Integer\n```
'                                             enclosing_range 5:36 5:54
              Return b
'                    ^ reference scip-dotnet nuget . . VBMain/Modules#Function().(b)
          End Function

          Private Sub [Sub](ByVal Optional a As Integer = 5)
'                     ^^^^^ definition scip-dotnet nuget . . VBMain/Modules#Sub().
'                           documentation ```vb\nPrivate Sub Modules.Sub([a As Integer = 5])\n```
'                           enclosing_range 9:8 10:15
'                                          ^ definition scip-dotnet nuget . . VBMain/Modules#Sub().(a)
'                                            documentation ```vb\n[a As Integer = 5]\n```
'                                            enclosing_range 9:26 9:57
          End Sub

      End Module
  End Namespace
