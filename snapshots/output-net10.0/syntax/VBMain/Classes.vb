  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Class Classes
'                  ^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#
'                          documentation ```vb\nClass Classes\n```
'                          enclosing_range 3:4 77:13

          Public Name As String
'                ^^^^ definition scip-dotnet nuget . . VBMain/Classes#Name.
'                     documentation ```vb\nPublic Classes.Name As String\n```
'                     enclosing_range 6:8 6:29
          Public Const IntConstant As Integer = 1
'                      ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#IntConstant.
'                                  documentation ```vb\nPublic Const Classes.IntConstant As Integer = 1\n```
'                                  enclosing_range 7:8 7:47
          Public Const StringConstant As String = "hello"
'                      ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#StringConstant.
'                                     documentation ```vb\nPublic Const Classes.StringConstant As String = "hello"\n```
'                                     enclosing_range 8:8 8:55

          Public Sub New(ByVal name As Integer)
'                    ^^^ definition scip-dotnet nuget . . VBMain/Classes#`.ctor`().
'                        documentation ```vb\nPublic Sub Classes.New(name As Integer)\n```
'                        enclosing_range 10:8 12:15
'                              ^^^^ definition scip-dotnet nuget . . VBMain/Classes#`.ctor`().(name)
'                                   documentation ```vb\nname As Integer\n```
'                                   enclosing_range 10:23 10:44
              Me.Name = "name"
'                ^^^^ reference scip-dotnet nuget . . VBMain/Classes#Name.
          End Sub

          Public Sub New(ByVal name As String)
'                    ^^^ definition scip-dotnet nuget . . VBMain/Classes#`.ctor`(+1).
'                        documentation ```vb\nPublic Sub Classes.New(name As String)\n```
'                        enclosing_range 14:8 16:15
'                              ^^^^ definition scip-dotnet nuget . . VBMain/Classes#`.ctor`(+1).(name)
'                                   documentation ```vb\nname As String\n```
'                                   enclosing_range 14:23 14:43
              Me.Name = name
'                ^^^^ reference scip-dotnet nuget . . VBMain/Classes#Name.
'                       ^^^^ reference scip-dotnet nuget . . VBMain/Classes#`.ctor`(+1).(name)
          End Sub

          Protected Overrides Sub Finalize()
'                                 ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#Finalize().
'                                          documentation ```vb\nProtected Overrides Sub Classes.Finalize()\n```
'                                          relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#Finalize().
'                                          enclosing_range 18:8 20:15
              Console.WriteLine(42)
'             ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                     ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+7).
          End Sub

          Public Class ObjectClass
'                      ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#ObjectClass#
'                                  documentation ```vb\nClass ObjectClass\n```
'                                  relationship implementation scip-dotnet nuget . . VBMain/Classes#SomeInterface#
'                                  enclosing_range 22:8 25:17
              Inherits Object
              Implements SomeInterface
'                        ^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Classes#SomeInterface#
          End Class

          Public Partial Class PartialClass
'                              ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#PartialClass#
'                                           documentation ```vb\nClass PartialClass\n```
'                                           enclosing_range 27:8 28:17
          End Class

          Class TypeParameterClass(Of T)
'               ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#TypeParameterClass#
'                                  documentation ```vb\nClass TypeParameterClass(Of T)\n```
'                                  enclosing_range 30:8 31:17
'                                     ^ definition local 0
'                                       documentation ```vb\nT\n```
'                                       enclosing_range 30:36 30:37
          End Class

          Friend Class InternalMultipleTypeParametersClass(Of T1, T2)
'                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#InternalMultipleTypeParametersClass#
'                                                          documentation ```vb\nClass InternalMultipleTypeParametersClass(Of T1, T2)\n```
'                                                          enclosing_range 33:8 34:17
'                                                             ^^ definition local 1
'                                                                documentation ```vb\nT1\n```
'                                                                enclosing_range 33:60 33:62
'                                                                 ^^ definition local 2
'                                                                    documentation ```vb\nT2\n```
'                                                                    enclosing_range 33:64 33:66
          End Class

          Interface ICovariantContravariant(Of In T1, Out T2)
'                   ^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#ICovariantContravariant#
'                                           documentation ```vb\nInterface ICovariantContravariant(Of In T1, Out T2)\n```
'                                           enclosing_range 36:8 41:21
'                                                 ^^ definition local 3
'                                                    documentation ```vb\nIn T1\n```
'                                                    enclosing_range 36:45 36:50
'                                                         ^^ definition local 4
'                                                            documentation ```vb\nOut T2\n```
'                                                            enclosing_range 36:52 36:58
              Sub Method1(ByVal t1 As T1)
'                 ^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#ICovariantContravariant#Method1().
'                         documentation ```vb\nSub ICovariantContravariant(Of In T1, Out T2).Method1(t1 As T1)\n```
'                         enclosing_range 37:12 37:39
'                               ^^ definition scip-dotnet nuget . . VBMain/Classes#ICovariantContravariant#Method1().(t1)
'                                  documentation ```vb\nt1 As T1\n```
'                                  enclosing_range 37:24 37:38
'                                     ^^ reference local 3

              Function Method2() As T2
'                      ^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#ICovariantContravariant#Method2().
'                              documentation ```vb\nFunction ICovariantContravariant(Of In T1, Out T2).Method2() As T2\n```
'                              enclosing_range 39:12 39:36
'                                   ^^ reference local 4

          End Interface

          Public Class StructConstraintClass(Of T As Structure)
'                      ^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#StructConstraintClass#
'                                            documentation ```vb\nClass StructConstraintClass(Of T As Structure)\n```
'                                            enclosing_range 43:8 44:17
'                                               ^ definition local 5
'                                                 documentation ```vb\nT\n```
'                                                 enclosing_range 43:46 43:60
          End Class

          Public Class ClassConstraintClass(Of T As Class)
'                      ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#ClassConstraintClass#
'                                           documentation ```vb\nClass ClassConstraintClass(Of T As Class)\n```
'                                           enclosing_range 46:8 47:17
'                                              ^ definition local 6
'                                                documentation ```vb\nT\n```
'                                                enclosing_range 46:45 46:55
          End Class

          Public Class NewConstraintClass(Of T As New)
'                      ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#NewConstraintClass#
'                                         documentation ```vb\nClass NewConstraintClass(Of T As New)\n```
'                                         enclosing_range 49:8 50:17
'                                            ^ definition local 7
'                                              documentation ```vb\nT\n```
'                                              enclosing_range 49:43 49:51
          End Class

          Public Class TypeParameterConstraintClass(Of T As SomeInterface)
'                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#TypeParameterConstraintClass#
'                                                   documentation ```vb\nClass TypeParameterConstraintClass(Of T As SomeInterface)\n```
'                                                   enclosing_range 52:8 53:17
'                                                      ^ definition local 8
'                                                        documentation ```vb\nT\n```
'                                                        enclosing_range 52:53 52:71
'                                                           ^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Classes#SomeInterface#
          End Class

          Private Class MultipleTypeParameterConstraintsClass(Of T1 As {SomeInterface, SomeInterface2, New}, T2 As SomeInterface2)
'                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#MultipleTypeParameterConstraintsClass#
'                                                             documentation ```vb\nClass MultipleTypeParameterConstraintsClass(Of T1 As {SomeInterface, SomeInterface2, New}, T2 As SomeInterface2)\n```
'                                                             enclosing_range 55:8 56:17
'                                                                ^^ definition local 9
'                                                                   documentation ```vb\nT1\n```
'                                                                   enclosing_range 55:63 55:105
'                                                                       ^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Classes#SomeInterface#
'                                                                                      ^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Classes#SomeInterface2#
'                                                                                                            ^^ definition local 10
'                                                                                                               documentation ```vb\nT2\n```
'                                                                                                               enclosing_range 55:107 55:127
'                                                                                                                  ^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Classes#SomeInterface2#
          End Class

          Class IndexClass
'               ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#IndexClass#
'                          documentation ```vb\nClass IndexClass\n```
'                          enclosing_range 58:8 69:17
              Private a As Boolean
'                     ^ definition scip-dotnet nuget . . VBMain/Classes#IndexClass#a.
'                       documentation ```vb\nPrivate IndexClass.a As Boolean\n```
'                       enclosing_range 59:12 59:32

              Default Public Property Item(ByVal index As Integer) As Boolean
'                                     ^^^^ definition scip-dotnet nuget . . VBMain/Classes#IndexClass#Item.
'                                          documentation ```vb\nPublic Default Property IndexClass.Item(index As Integer) As Boolean\n```
'                                          enclosing_range 61:12 68:24
'                                                ^^^^^ definition scip-dotnet nuget . . VBMain/Classes#IndexClass#Item.(index)
'                                                      documentation ```vb\nindex As Integer\n```
'                                                      enclosing_range 61:41 61:63
                  Get
                      Return a
'                            ^ reference scip-dotnet nuget . . VBMain/Classes#IndexClass#a.
                  End Get
                  Set(ByVal value As Boolean)
'                           ^^^^^ definition scip-dotnet nuget . . VBMain/Classes#IndexClass#set_Item().(value)
'                                 documentation ```vb\nvalue As Boolean\n```
'                                 enclosing_range 65:20 65:42
                      a = value
'                     ^ reference scip-dotnet nuget . . VBMain/Classes#IndexClass#a.
'                         ^^^^^ reference scip-dotnet nuget . . VBMain/Classes#IndexClass#set_Item().(value)
                  End Set
              End Property
          End Class

          Interface SomeInterface
'                   ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#SomeInterface#
'                                 documentation ```vb\nInterface SomeInterface\n```
'                                 enclosing_range 71:8 72:21
          End Interface

          Friend Interface SomeInterface2
'                          ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#SomeInterface2#
'                                         documentation ```vb\nInterface SomeInterface2\n```
'                                         enclosing_range 74:8 75:21
          End Interface

      End Class

  End Namespace
