  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
  Imports DiffPlex.DiffBuilder
  Imports DiffPlex.DiffBuilder.Model

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Class Packages
'                  ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Packages#
'                           documentation ```vb\nClass Packages\n```
'                           enclosing_range 5:4 10:13
          Private Function Diff() As DiffPaneModel
'                          ^^^^ definition scip-dotnet nuget . . VBMain/Packages#Diff().
'                               documentation ```vb\nPrivate Function Packages.Diff() As DiffPaneModel\n```
'                               enclosing_range 7:8 9:20
              Return InlineDiffBuilder.Diff("a", "b")
          End Function
      End Class
  End Namespace
