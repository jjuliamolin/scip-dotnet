  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      <AttributeUsage(AttributeTargets.[Class], AllowMultiple:=True, Inherited:=True)>
'      ^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#`.ctor`().
'                     ^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeTargets#
'                                      ^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeTargets#Class.
'                                               ^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#AllowMultiple.
'                                                                    ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#Inherited.
      Public Class GlobalAttributes
'                  ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#
'                                   documentation ```vb\nClass GlobalAttributes\n```
'                                   relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
'                                   enclosing_range 3:4 37:13
          Inherits Attribute
'                  ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#

          Class AuthorAttribute
'               ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#
'                               documentation ```vb\nClass AuthorAttribute\n```
'                               relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
'                               enclosing_range 8:8 13:17
              Inherits Attribute
'                      ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#

              Public Sub New(ByVal name As String)
'                        ^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                            documentation ```vb\nPublic Sub AuthorAttribute.New(name As String)\n```
'                            enclosing_range 11:12 12:19
'                                  ^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().(name)
'                                       documentation ```vb\nname As String\n```
'                                       enclosing_range 11:27 11:47
              End Sub
          End Class

          <Author("PropertyAttribute")>
'          ^^^^^^ reference scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
          Public Z As Integer
'                ^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#Z.
'                  documentation ```vb\nPublic GlobalAttributes.Z As Integer\n```
'                  enclosing_range 15:8 16:27

          <Author("MethodAttribute")>
'          ^^^^^^ reference scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
          Private Function Method1() As Integer
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#Method1().
'                                  documentation ```vb\nPrivate Function GlobalAttributes.Method1() As Integer\n```
'                                  enclosing_range 18:8 21:20
              Return 0
          End Function

          <Author("EnumAttribute")>
'          ^^^^^^ reference scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
          Enum A
'              ^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#A#
'                documentation ```vb\nEnum A\n```
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
'                enclosing_range 23:8 27:16
              B
'             ^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#A#B.
'               documentation ```vb\nA.B = 0\n```
'               enclosing_range 25:12 25:13
              C
'             ^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#A#C.
'               documentation ```vb\nA.C = 1\n```
'               enclosing_range 26:12 26:13
          End Enum

          <Author("EventAttribute")>
'          ^^^^^^ reference scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
          Public Event SomeEvent As EventHandler
'                      ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#SomeEvent#
'                                documentation ```vb\nPublic Event GlobalAttributes.SomeEvent As EventHandler\n```
'                                enclosing_range 29:8 30:46
'                                   ^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#

          <Author("TypeParameterAttribute")>
'          ^^^^^^ reference scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
          Public Class InnerClass(Of T)
'                      ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#InnerClass#
'                                 documentation ```vb\nClass InnerClass(Of T)\n```
'                                 enclosing_range 32:8 36:17
'                                    ^ definition local 0
'                                      documentation ```vb\nT\n```
'                                      enclosing_range 33:35 33:36
              Private Sub Method(Of T2)()
'                         ^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#InnerClass#Method().
'                                documentation ```vb\nPrivate Sub InnerClass(Of T).Method(Of T2)()\n```
'                                enclosing_range 34:12 35:19
'                                   ^^ definition local 1
'                                      documentation ```vb\nT2\n```
'                                      enclosing_range 34:34 34:36
              End Sub
          End Class
      End Class
  End Namespace
