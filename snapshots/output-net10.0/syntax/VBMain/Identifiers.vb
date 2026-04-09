  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Class Identifiers
'                  ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Identifiers#
'                              documentation ```vb\nClass Identifiers\n```
'                              enclosing_range 3:4 16:13
          Private Sub SpecialNames()
'                     ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Identifiers#SpecialNames().
'                                  documentation ```vb\nPrivate Sub Identifiers.SpecialNames()\n```
'                                  enclosing_range 5:8 15:15
              Dim [const] = 42
'                 ^^^^^^^ definition local 0
'                         documentation ```vb\n[const] As Integer\n```
'                         enclosing_range 6:12 6:28
              Dim var As Integer = [const]
'                 ^^^ definition local 1
'                     documentation ```vb\nvar As Integer\n```
'                     enclosing_range 7:12 7:40
'                                  ^^^^^^^ reference local 0
              Dim under_score = 0
'                 ^^^^^^^^^^^ definition local 2
'                             documentation ```vb\nunder_score As Integer\n```
'                             enclosing_range 8:12 8:31
              Dim with1number = 0
'                 ^^^^^^^^^^^ definition local 3
'                             documentation ```vb\nwith1number As Integer\n```
'                             enclosing_range 9:12 9:31
              Dim varæble = 0
'                 ^^^^^^^ definition local 4
'                         documentation ```vb\nvaræble As Integer\n```
'                         enclosing_range 10:12 10:27
              Dim Переменная = 0
'                 ^^^^^^^^^^ definition local 5
'                            documentation ```vb\nПеременная As Integer\n```
'                            enclosing_range 11:12 11:30
              Dim first‿letter = 0
'                 ^^^^^^^^^^^^ definition local 6
'                              documentation ```vb\nfirst‿letter As Integer\n```
'                              enclosing_range 12:12 12:32
              Dim ග්රහලෝකය = 0
'                 ^^^^^^^^ definition local 7
'                          documentation ```vb\nග්රහලෝකය As Integer\n```
'                          enclosing_range 13:12 13:28
              Dim _كوكبxxx = 0
'                 ^^^^^^^^ definition local 8
'                          documentation ```vb\n_كوكبxxx As Integer\n```
'                          enclosing_range 14:12 14:28
          End Sub
      End Class
  End Namespace
