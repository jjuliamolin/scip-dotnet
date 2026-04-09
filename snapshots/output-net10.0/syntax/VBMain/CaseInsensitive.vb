  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      Public Class CaseInsensitive
'                  ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/CaseInsensitive#
'                                  documentation ```vb\nClass CaseInsensitive\n```
'                                  enclosing_range 1:4 5:13
          Public Sub DifferentCase(wEiRdCaSiNg As String)
'                    ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/CaseInsensitive#DifferentCase().
'                                  documentation ```vb\nPublic Sub CaseInsensitive.DifferentCase(wEiRdCaSiNg As String)\n```
'                                  enclosing_range 2:8 4:15
'                                  ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/CaseInsensitive#DifferentCase().(wEiRdCaSiNg)
'                                              documentation ```vb\nwEiRdCaSiNg As String\n```
'                                              enclosing_range 2:33 2:54
              Console.WriteLine(WeIrDcAsInG)
'             ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                     ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
'                               ^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/CaseInsensitive#DifferentCase().(wEiRdCaSiNg)
          End Sub
      End Class
  End Namespace
