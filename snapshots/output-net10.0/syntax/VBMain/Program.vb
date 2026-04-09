  Module Program
'        ^^^^^^^ definition scip-dotnet nuget . . VBMain/Program#
'                documentation ```vb\nModule Program\n```
'                enclosing_range 0:0 5:10
      Sub Main(args As String())
'         ^^^^ definition scip-dotnet nuget . . VBMain/Program#Main().
'              documentation ```vb\nPublic Sub Program.Main(args As String())\n```
'              enclosing_range 1:4 4:11
'              ^^^^ definition scip-dotnet nuget . . VBMain/Program#Main().(args)
'                   documentation ```vb\nargs As String()\n```
'                   enclosing_range 1:13 1:29

          Console.WriteLine("Hello, World!")
'         ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                 ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
      End Sub
  End Module
