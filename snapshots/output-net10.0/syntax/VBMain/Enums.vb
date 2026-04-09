  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Class Enums
'                  ^^^^^ definition scip-dotnet nuget . . VBMain/Enums#
'                        documentation ```vb\nClass Enums\n```
'                        enclosing_range 3:4 14:13
          Enum EnumWithIntValues
'              ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Enums#EnumWithIntValues#
'                                documentation ```vb\nEnum EnumWithIntValues\n```
'                                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
'                                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
'                                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
'                                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
'                                enclosing_range 5:8 8:16
              Ten = 10
'             ^^^ definition scip-dotnet nuget . . VBMain/Enums#EnumWithIntValues#Ten.
'                 documentation ```vb\nEnumWithIntValues.Ten = 10\n```
'                 enclosing_range 6:12 6:20
              Twenty = 20
'             ^^^^^^ definition scip-dotnet nuget . . VBMain/Enums#EnumWithIntValues#Twenty.
'                    documentation ```vb\nEnumWithIntValues.Twenty = 20\n```
'                    enclosing_range 7:12 7:23
          End Enum

          Enum EnumWithByteValues
'              ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Enums#EnumWithByteValues#
'                                 documentation ```vb\nEnum EnumWithByteValues\n```
'                                 relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
'                                 relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
'                                 relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
'                                 relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
'                                 enclosing_range 10:8 13:16
              Five = &H5
'             ^^^^ definition scip-dotnet nuget . . VBMain/Enums#EnumWithByteValues#Five.
'                  documentation ```vb\nEnumWithByteValues.Five = 5\n```
'                  enclosing_range 11:12 11:22
              Fifteen = &HF
'             ^^^^^^^ definition scip-dotnet nuget . . VBMain/Enums#EnumWithByteValues#Fifteen.
'                     documentation ```vb\nEnumWithByteValues.Fifteen = 15\n```
'                     enclosing_range 12:12 12:25
          End Enum
      End Class
  End Namespace
