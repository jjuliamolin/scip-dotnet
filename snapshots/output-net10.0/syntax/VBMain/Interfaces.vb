  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Class Interfaces
'                  ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#
'                             documentation ```vb\nClass Interfaces\n```
'                             enclosing_range 3:4 39:13
          Interface IOne
'                   ^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IOne#
'                        documentation ```vb\nInterface IOne\n```
'                        enclosing_range 5:8 6:21
          End Interface

          Interface ITwo
'                   ^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#ITwo#
'                        documentation ```vb\nInterface ITwo\n```
'                        enclosing_range 8:8 9:21
          End Interface

          Interface IThree
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IThree#
'                          documentation ```vb\nInterface IThree\n```
'                          enclosing_range 11:8 12:21
          End Interface

          Interface IProperties
'                   ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IProperties#
'                               documentation ```vb\nInterface IProperties\n```
'                               enclosing_range 14:8 19:21
              ReadOnly Property [Get] As Byte
'                               ^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IProperties#Get.
'                                     documentation ```vb\nReadOnly Property IProperties.Get As Byte\n```
'                                     enclosing_range 15:12 15:43
              WriteOnly Property [Set] As Char
'                                ^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IProperties#Set.
'                                      documentation ```vb\nWriteOnly Property IProperties.Set As Char\n```
'                                      enclosing_range 16:12 16:44
              Property GetSet As UInteger
'                      ^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IProperties#GetSet.
'                             documentation ```vb\nProperty IProperties.GetSet As UInteger\n```
'                             enclosing_range 17:12 17:39
              Property SetGet As Long
'                      ^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IProperties#SetGet.
'                             documentation ```vb\nProperty IProperties.SetGet As Long\n```
'                             enclosing_range 18:12 18:35
          End Interface

          Interface IMethods
'                   ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#
'                            documentation ```vb\nInterface IMethods\n```
'                            enclosing_range 21:8 26:21
              Sub [Nothing]()
'                 ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#Nothing().
'                           documentation ```vb\nSub IMethods.Nothing()\n```
'                           enclosing_range 22:12 22:27
              Function Output() As Integer
'                      ^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#Output().
'                             documentation ```vb\nFunction IMethods.Output() As Integer\n```
'                             enclosing_range 23:12 23:40
              Sub Input(ByVal a As String)
'                 ^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#Input().
'                       documentation ```vb\nSub IMethods.Input(a As String)\n```
'                       enclosing_range 24:12 24:40
'                             ^ definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#Input().(a)
'                               documentation ```vb\na As String\n```
'                               enclosing_range 24:22 24:39
              Function InputOutput(ByVal a As String) As Integer
'                      ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#InputOutput().
'                                  documentation ```vb\nFunction IMethods.InputOutput(a As String) As Integer\n```
'                                  enclosing_range 25:12 25:62
'                                        ^ definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#InputOutput().(a)
'                                          documentation ```vb\na As String\n```
'                                          enclosing_range 25:33 25:50
          End Interface

          Interface IEvent
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IEvent#
'                          documentation ```vb\nInterface IEvent\n```
'                          enclosing_range 28:8 30:21
              Event SomeEvent As EventHandler(Of Integer)
'                   ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IEvent#SomeEvent#
'                             documentation ```vb\nEvent IEvent.SomeEvent As EventHandler(Of Integer)\n```
'                             enclosing_range 29:12 29:55
          End Interface

          Interface IIndex
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IIndex#
'                          documentation ```vb\nInterface IIndex\n```
'                          enclosing_range 32:8 34:21
              Default Property Item(ByVal index As Integer) As Boolean
'                              ^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IIndex#Item.
'                                   documentation ```vb\nDefault Property IIndex.Item(index As Integer) As Boolean\n```
'                                   enclosing_range 33:12 33:68
'                                         ^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IIndex#Item.(index)
'                                               documentation ```vb\nindex As Integer\n```
'                                               enclosing_range 33:34 33:56
          End Interface

          Private Interface IInherit
'                           ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IInherit#
'                                    documentation ```vb\nInterface IInherit\n```
'                                    relationship implementation scip-dotnet nuget . . VBMain/Interfaces#IOne#
'                                    relationship implementation scip-dotnet nuget . . VBMain/Interfaces#ITwo#
'                                    enclosing_range 36:8 38:21
              Inherits IOne, ITwo
'                      ^^^^ reference scip-dotnet nuget . . VBMain/Interfaces#IOne#
'                            ^^^^ reference scip-dotnet nuget . . VBMain/Interfaces#ITwo#
          End Interface
      End Class
  End Namespace
