  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Class Properties
'                  ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Properties#
'                             documentation ```vb\nClass Properties\n```
'                             enclosing_range 3:4 15:13
          Private ReadOnly Property [Get] As Byte
'                                   ^^^^^ definition scip-dotnet nuget . . VBMain/Properties#Get.
'                                         documentation ```vb\nPrivate ReadOnly Property Properties.Get As Byte\n```
'                                         enclosing_range 5:8 5:47

          Private WriteOnly Property [Set] As Char
'                                    ^^^^^ definition scip-dotnet nuget . . VBMain/Properties#Set.
'                                          documentation ```vb\nPrivate WriteOnly Property Properties.Set As Char\n```
'                                          enclosing_range 7:8 11:20
              Set(ByVal value As Char)
'                       ^^^^^ definition scip-dotnet nuget . . VBMain/Properties#set_Set().(value)
'                             documentation ```vb\nvalue As Char\n```
'                             enclosing_range 8:16 8:35
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
              End Set
          End Property

          Private Property GetSet As UInteger
'                          ^^^^^^ definition scip-dotnet nuget . . VBMain/Properties#GetSet.
'                                 documentation ```vb\nPrivate Property Properties.GetSet As UInteger\n```
'                                 enclosing_range 13:8 13:43
          Private Property SetGet As Long
'                          ^^^^^^ definition scip-dotnet nuget . . VBMain/Properties#SetGet.
'                                 documentation ```vb\nPrivate Property Properties.SetGet As Long\n```
'                                 enclosing_range 14:8 14:39
      End Class
  End Namespace
