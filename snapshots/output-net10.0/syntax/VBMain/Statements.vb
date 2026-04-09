  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
  Imports System.IO
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^ reference scip-dotnet nuget . . IO/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Class Statements
'                  ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#
'                             documentation ```vb\nClass Statements\n```
'                             enclosing_range 4:4 67:13
          Private Sub [Try]()
'                     ^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Try().
'                           documentation ```vb\nPrivate Sub Statements.Try()\n```
'                           enclosing_range 6:8 12:15
              Try
                  File.ReadLines("asd")
'                 ^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                      ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#ReadLines().
              Catch err As Exception
'                   ^^^ definition local 0
'                       documentation ```vb\nerr As Class Exception\n```
'                       enclosing_range 9:12 10:38
'                   ^^^ reference local 0
'                          ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Exception#
                  Console.WriteLine(err)
'                 ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                         ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+9).
'                                   ^^^ reference local 0
              End Try
          End Sub

          Private Function [Default]() As (A As String, B As Boolean)
'                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Default().
'                                    documentation ```vb\nPrivate Function Statements.Default() As (A As String, B As Boolean)\n```
'                                    enclosing_range 14:8 17:20
              Dim C As (A As String, B As Boolean) = ("42", 42)
'                 ^ definition local 1
'                   documentation ```vb\nC As (A As String, B As Boolean)\n```
'                   enclosing_range 15:12 15:61
              Return C
'                    ^ reference local 1
          End Function

          Public Class Inferred
'                      ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#
'                               documentation ```vb\nClass Inferred\n```
'                               enclosing_range 19:8 22:17
              Property F1 As Int32
'                      ^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#F1.
'                         documentation ```vb\nPublic Property Inferred.F1 As Integer\n```
'                         enclosing_range 20:12 20:32
'                            ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Property F2 As Int32
'                      ^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#F2.
'                         documentation ```vb\nPublic Property Inferred.F2 As Integer\n```
'                         enclosing_range 21:12 21:32
'                            ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          End Class

          Private Sub InferredTuples()
'                     ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#InferredTuples().
'                                    documentation ```vb\nPrivate Sub Statements.InferredTuples()\n```
'                                    enclosing_range 24:8 27:15
              Dim List = New List(Of Inferred)()
'                 ^^^^ definition local 2
'                      documentation ```vb\nList As Class List(Of Inferred)\n```
'                      enclosing_range 25:12 25:46
'                                    ^^^^^^^^ reference scip-dotnet nuget . . VBMain/Statements#Inferred#
              Dim Result = List.Select(Function(c) (c.F1, c.F2)).Where(Function(t) t.F2 = 1)
'                 ^^^^^^ definition local 3
'                        documentation ```vb\nResult As Interface IEnumerable(Of (F1 As Integer, F2 As Integer))\n```
'                        enclosing_range 26:12 26:90
'                          ^^^^ reference local 2
'                               ^^^^^^ reference scip-dotnet nuget System.Linq 10.0.0.0 Linq/Enumerable#Select().
'                                               ^ definition local 5
'                                                 documentation ```vb\nc As Inferred\n```
'                                                 enclosing_range 26:46 26:47
'                                                   ^ reference local 5
'                                                     ^^ reference scip-dotnet nuget . . VBMain/Statements#Inferred#F1.
'                                                         ^ reference local 5
'                                                           ^^ reference scip-dotnet nuget . . VBMain/Statements#Inferred#F2.
'                                                                ^^^^^ reference scip-dotnet nuget System.Linq 10.0.0.0 Linq/Enumerable#Where().
'                                                                               ^ definition local 7
'                                                                                 documentation ```vb\nt As (F1 As Integer, F2 As Integer)\n```
'                                                                                 enclosing_range 26:78 26:79
'                                                                                  ^ reference local 7
'                                                                                    ^^ reference local 9
          End Sub

          Private Function MultipleInitializers() As Integer
'                          ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MultipleInitializers().
'                                               documentation ```vb\nPrivate Function Statements.MultipleInitializers() As Integer\n```
'                                               enclosing_range 29:8 32:20
              Dim a As Integer = 1, b As Integer = 2
'                 ^ definition local 10
'                   documentation ```vb\na As Integer\n```
'                   enclosing_range 30:12 30:50
'                                   ^ definition local 11
'                                     documentation ```vb\nb As Integer\n```
'                                     enclosing_range 30:12 30:50
              Return a + b
'                    ^ reference local 10
'                        ^ reference local 11
          End Function

          Class MyDisposable
'               ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                            documentation ```vb\nClass MyDisposable\n```
'                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
'                            enclosing_range 34:8 40:17
              Implements IDisposable
'                        ^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#

              Private Sub Dispose() Implements IDisposable.Dispose
'                         ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#Dispose().
'                                 documentation ```vb\nPrivate Sub MyDisposable.Dispose()\n```
'                                 relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#Dispose().
'                                 enclosing_range 37:12 39:19
'                                              ^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
'                                                          ^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#Dispose().
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
              End Sub
          End Class

          Private Function [Using]() As MyDisposable
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Using().
'                                  documentation ```vb\nPrivate Function Statements.Using() As MyDisposable\n```
'                                  enclosing_range 42:8 48:20
'                                       ^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Statements#MyDisposable#
              Dim b = New MyDisposable()
'                 ^ definition local 12
'                   documentation ```vb\nb As Class MyDisposable\n```
'                   enclosing_range 43:12 43:38
'                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Statements#MyDisposable#

              Using a = b
'                   ^ definition local 13
'                     documentation ```vb\na As Class MyDisposable\n```
'                     enclosing_range 45:12 45:23
'                       ^ reference local 12
                  Return a
'                        ^ reference local 13
              End Using
          End Function

          Private Function MultipleUsing() As Long
'                          ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MultipleUsing().
'                                        documentation ```vb\nPrivate Function Statements.MultipleUsing() As Long\n```
'                                        enclosing_range 50:8 54:20
              Using a As Stream = File.OpenRead("a"), b As Stream = File.OpenRead("a")
'                   ^ definition local 14
'                     documentation ```vb\na As Class Stream\n```
'                     enclosing_range 51:12 51:84
'                        ^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                                 ^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                                      ^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#OpenRead().
'                                                     ^ definition local 15
'                                                       documentation ```vb\nb As Class Stream\n```
'                                                       enclosing_range 51:12 51:84
'                                                          ^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                                                                   ^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                                                                        ^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#OpenRead().
                  Return a.Length + b.Length
'                        ^ reference local 14
'                          ^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#Length.
'                                   ^ reference local 15
'                                     ^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#Length.
              End Using
          End Function

          Private Function Foreach() As Integer
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Foreach().
'                                  documentation ```vb\nPrivate Function Statements.Foreach() As Integer\n```
'                                  enclosing_range 56:8 65:20
              Dim y = New Integer() {1}
'                 ^ definition local 16
'                   documentation ```vb\ny As Integer()\n```
'                   enclosing_range 57:12 57:37
              Dim z = 0
'                 ^ definition local 17
'                   documentation ```vb\nz As Integer\n```
'                   enclosing_range 58:12 58:21

              For Each x As Integer In y
'                      ^ definition local 18
'                        documentation ```vb\nx As Integer\n```
'                        enclosing_range 60:12 60:38
'                                      ^ reference local 16
                  z += x
'                 ^ reference local 17
'                      ^ reference local 18
              Next

              Return z
'                    ^ reference local 17
          End Function

      End Class
  End Namespace
