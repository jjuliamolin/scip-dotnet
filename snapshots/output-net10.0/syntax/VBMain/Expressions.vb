  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
      Public Class Expressions
'                  ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#
'                              documentation ```vb\nClass Expressions\n```
'                              enclosing_range 3:4 242:13

          Private Sub AssignmentToPrefixUnaryExpressions()
'                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AssignmentToPrefixUnaryExpressions().
'                                                        documentation ```vb\nPrivate Sub Expressions.AssignmentToPrefixUnaryExpressions()\n```
'                                                        enclosing_range 6:8 15:15
              Dim A = 42
'                 ^ definition local 0
'                   documentation ```vb\nA As Integer\n```
'                   enclosing_range 7:12 7:22
              Dim B = 42
'                 ^ definition local 1
'                   documentation ```vb\nB As Integer\n```
'                   enclosing_range 8:12 8:22
              A = +A
'             ^ reference local 0
'                  ^ reference local 0
              A = -A
'             ^ reference local 0
'                  ^ reference local 0
              A = Not A
'             ^ reference local 0
'                     ^ reference local 0
              B = A
'             ^ reference local 1
'                 ^ reference local 0
              Dim C = True
'                 ^ definition local 2
'                   documentation ```vb\nC As Boolean\n```
'                   enclosing_range 13:12 13:24
              C = Not C
'             ^ reference local 2
'                     ^ reference local 2
          End Sub

          Private Sub AssignmentToPrefixBinaryExpressions()
'                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AssignmentToPrefixBinaryExpressions().
'                                                         documentation ```vb\nPrivate Sub Expressions.AssignmentToPrefixBinaryExpressions()\n```
'                                                         enclosing_range 17:8 31:15
              Dim A = 42
'                 ^ definition local 3
'                   documentation ```vb\nA As Integer\n```
'                   enclosing_range 18:12 18:22
              A = A + A
'             ^ reference local 3
'                 ^ reference local 3
'                     ^ reference local 3
              A = A - A
'             ^ reference local 3
'                 ^ reference local 3
'                     ^ reference local 3
              A = A * A
'             ^ reference local 3
'                 ^ reference local 3
'                     ^ reference local 3
              A = A / A
'             ^ reference local 3
'                 ^ reference local 3
'                     ^ reference local 3
              A = A \ A
'             ^ reference local 3
'                 ^ reference local 3
'                     ^ reference local 3
              A = A ^ A
'             ^ reference local 3
'                 ^ reference local 3
'                     ^ reference local 3
              A = A Mod A
'             ^ reference local 3
'                 ^ reference local 3
'                       ^ reference local 3
              A = A And A
'             ^ reference local 3
'                 ^ reference local 3
'                       ^ reference local 3
              A = A Or A
'             ^ reference local 3
'                 ^ reference local 3
'                      ^ reference local 3
              A = A Xor A
'             ^ reference local 3
'                 ^ reference local 3
'                       ^ reference local 3
              A = A << A
'             ^ reference local 3
'                 ^ reference local 3
'                      ^ reference local 3
              A = A >> A
'             ^ reference local 3
'                 ^ reference local 3
'                      ^ reference local 3
          End Sub

          Private Sub AssignmentToBinaryEqualityExpression()
'                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AssignmentToBinaryEqualityExpression().
'                                                          documentation ```vb\nPrivate Sub Expressions.AssignmentToBinaryEqualityExpression()\n```
'                                                          enclosing_range 33:8 44:15
              Dim A = True
'                 ^ definition local 4
'                   documentation ```vb\nA As Boolean\n```
'                   enclosing_range 34:12 34:24
              Dim B = True
'                 ^ definition local 5
'                   documentation ```vb\nB As Boolean\n```
'                   enclosing_range 35:12 35:24
              Dim C = 42
'                 ^ definition local 6
'                   documentation ```vb\nC As Integer\n```
'                   enclosing_range 36:12 36:22
              Dim D = 42
'                 ^ definition local 7
'                   documentation ```vb\nD As Integer\n```
'                   enclosing_range 37:12 37:22
              A = A = B
'             ^ reference local 4
'                 ^ reference local 4
'                     ^ reference local 5
              A = A <> B
'             ^ reference local 4
'                 ^ reference local 4
'                      ^ reference local 5
              A = C < D
'             ^ reference local 4
'                 ^ reference local 6
'                     ^ reference local 7
              A = C <= D
'             ^ reference local 4
'                 ^ reference local 6
'                      ^ reference local 7
              A = C > D
'             ^ reference local 4
'                 ^ reference local 6
'                     ^ reference local 7
              A = C >= D
'             ^ reference local 4
'                 ^ reference local 6
'                      ^ reference local 7
          End Sub

          Private Sub AssignmentToBinaryExpression()
'                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AssignmentToBinaryExpression().
'                                                  documentation ```vb\nPrivate Sub Expressions.AssignmentToBinaryExpression()\n```
'                                                  enclosing_range 46:8 57:15
              Dim A = 42
'                 ^ definition local 8
'                   documentation ```vb\nA As Integer\n```
'                   enclosing_range 47:12 47:22
              A += A
'             ^ reference local 8
'                  ^ reference local 8
              A -= A
'             ^ reference local 8
'                  ^ reference local 8
              A *= A
'             ^ reference local 8
'                  ^ reference local 8
              A /= A
'             ^ reference local 8
'                  ^ reference local 8
              A \= A
'             ^ reference local 8
'                  ^ reference local 8
              A &= A
'             ^ reference local 8
'                  ^ reference local 8
              A <<= A
'             ^ reference local 8
'                   ^ reference local 8
              A >>= A
'             ^ reference local 8
'                   ^ reference local 8
              A ^= A
'             ^ reference local 8
'                  ^ reference local 8
          End Sub

          Structure Struct
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Struct#
'                          documentation ```vb\nStructure Struct\n```
'                          enclosing_range 59:8 61:21
              Public [Property] As Integer
'                    ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Struct#Property.
'                               documentation ```vb\nPublic Struct.Property As Integer\n```
'                               enclosing_range 60:12 60:40
          End Structure

          Structure IndexedClass
'                   ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#
'                                documentation ```vb\nStructure IndexedClass\n```
'                                enclosing_range 63:8 74:21
              Public [Property] As Integer
'                    ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Property.
'                               documentation ```vb\nPublic IndexedClass.Property As Integer\n```
'                               enclosing_range 64:12 64:40

              Default Public Property Item(ByVal index As Integer) As Integer
'                                     ^^^^ definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Item.
'                                          documentation ```vb\nPublic Default Property IndexedClass.Item(index As Integer) As Integer\n```
'                                          enclosing_range 66:12 73:24
'                                                ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Item.(index)
'                                                      documentation ```vb\nindex As Integer\n```
'                                                      enclosing_range 66:41 66:63
                  Get
                      Return [Property]
'                            ^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Property.
                  End Get
                  Set(ByVal value As Integer)
'                           ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#set_Item().(value)
'                                 documentation ```vb\nvalue As Integer\n```
'                                 enclosing_range 70:20 70:42
                      [Property] = value
'                     ^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Property.
'                                  ^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#IndexedClass#set_Item().(value)
                  End Set
              End Property
          End Structure

          Private Sub AssignmentToLeftValueTypes()
'                     ^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AssignmentToLeftValueTypes().
'                                                documentation ```vb\nPrivate Sub Expressions.AssignmentToLeftValueTypes()\n```
'                                                enclosing_range 76:8 89:15
              Dim E As (A As Integer, B As Integer) = (1, 2)
'                 ^ definition local 9
'                   documentation ```vb\nE As (A As Integer, B As Integer)\n```
'                   enclosing_range 77:12 77:58
              Dim A = 1
'                 ^ definition local 10
'                   documentation ```vb\nA As Integer\n```
'                   enclosing_range 78:12 78:21
              Dim C = New Struct With {
'                 ^ definition local 11
'                   documentation ```vb\nC As Structure Struct\n```
'                   enclosing_range 79:12 81:13
'                         ^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Struct#
                  .[Property] = 42
'                  ^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Struct#Property.
              }
              C.[Property] = 1
'             ^ reference local 11
'               ^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Struct#Property.
              Dim D = New IndexedClass()
'                 ^ definition local 12
'                   documentation ```vb\nD As Structure IndexedClass\n```
'                   enclosing_range 83:12 83:38
'                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#IndexedClass#
              D(E.B) = 1
'             ^ reference local 12
'               ^ reference local 9
'                 ^ reference local 14
              Dim X = New IndexedClass With {
'                 ^ definition local 15
'                   documentation ```vb\nX As Structure IndexedClass\n```
'                   enclosing_range 85:12 87:13
'                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#IndexedClass#
                  .[Property] = 1
'                  ^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Property.
              }
              E.A = 1
'             ^ reference local 9
'               ^ reference local 16
          End Sub

          Private Sub TernaryExpression()
'                     ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#TernaryExpression().
'                                       documentation ```vb\nPrivate Sub Expressions.TernaryExpression()\n```
'                                       enclosing_range 91:8 96:15
              Dim X = True
'                 ^ definition local 17
'                   documentation ```vb\nX As Boolean\n```
'                   enclosing_range 92:12 92:24
              Dim Y = If(X, "foo", "bar")
'                 ^ definition local 18
'                   documentation ```vb\nY As String\n```
'                   enclosing_range 93:12 93:39
'                        ^ reference local 17
              Dim Z As Object = True
'                 ^ definition local 19
'                   documentation ```vb\nZ As Object\n```
'                   enclosing_range 94:12 94:34
              Dim T = If(TypeOf Z Is Boolean, 42, 41)
'                 ^ definition local 20
'                   documentation ```vb\nT As Integer\n```
'                   enclosing_range 95:12 95:51
'                               ^ reference local 19
          End Sub

          Class Cast
'               ^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#
'                    documentation ```vb\nClass Cast\n```
'                    enclosing_range 98:8 109:17
              Public Nested As Cast
'                    ^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#Nested.
'                           documentation ```vb\nPublic Cast.Nested As Cast\n```
'                           enclosing_range 99:12 99:33
'                              ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#
              Public Nested2 As Cast2
'                    ^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#Nested2.
'                            documentation ```vb\nPublic Cast.Nested2 As Cast2\n```
'                            enclosing_range 100:12 100:35
'                               ^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#Cast2#

              Public Function Plus(ByVal other As Cast) As Cast
'                             ^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#Plus().
'                                  documentation ```vb\nPublic Function Cast.Plus(other As Cast) As Cast\n```
'                                  enclosing_range 102:12 105:24
'                                        ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#Plus().(other)
'                                              documentation ```vb\nother As Cast\n```
'                                              enclosing_range 102:33 102:52
'                                                 ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                                          ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#
                  Nested = other
'                 ^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#Nested.
'                          ^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#Plus().(other)
                  Return Me
              End Function

              Public Class Cast2
'                          ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#Cast2#
'                                documentation ```vb\nClass Cast2\n```
'                                enclosing_range 107:12 108:21
              End Class
          End Class

          Private Function CastExpressions() As Integer
'                          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#CastExpressions().
'                                          documentation ```vb\nPrivate Function Expressions.CastExpressions() As Integer\n```
'                                          enclosing_range 111:8 121:20
              Dim A As Object = New Cast()
'                 ^ definition local 21
'                   documentation ```vb\nA As Object\n```
'                   enclosing_range 112:12 112:40
'                                   ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#
              Dim B As Object = New Cast()
'                 ^ definition local 22
'                   documentation ```vb\nB As Object\n```
'                   enclosing_range 113:12 113:40
'                                   ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#
              Dim C As Cast = (CType(A, Cast)).Plus(CType(B, Cast))
'                 ^ definition local 23
'                   documentation ```vb\nC As Class Cast\n```
'                   enclosing_range 114:12 114:65
'                      ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                    ^ reference local 21
'                                       ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                              ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#Plus().
'                                                         ^ reference local 22
'                                                            ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#
              Dim D As Cast = CType(New Object() {A, B}(0), Cast)
'                 ^ definition local 24
'                   documentation ```vb\nD As Class Cast\n```
'                   enclosing_range 115:12 115:63
'                      ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                                 ^ reference local 21
'                                                    ^ reference local 22
'                                                           ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#
              Dim E = CType((C.Nested.Nested2), Cast.Cast2)
'                 ^ definition local 25
'                   documentation ```vb\nE As Class Cast2\n```
'                   enclosing_range 116:12 116:57
'                            ^ reference local 23
'                              ^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#Nested.
'                                     ^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#Nested2.
'                                               ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                                    ^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Cast#Cast2#
              Dim F = CType((1), Int32)
'                 ^ definition local 26
'                   documentation ```vb\nF As Integer\n```
'                   enclosing_range 117:12 117:37
'                                ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim G = CType((1), Int32)
'                 ^ definition local 27
'                   documentation ```vb\nG As Integer\n```
'                   enclosing_range 118:12 118:37
'                                ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim H = CType(((1)), Int32)
'                 ^ definition local 28
'                   documentation ```vb\nH As Integer\n```
'                   enclosing_range 119:12 119:39
'                                  ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return F + G + H
'                    ^ reference local 26
'                        ^ reference local 27
'                            ^ reference local 28
          End Function

          Private Function AnonymousObject() As Object
'                          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AnonymousObject().
'                                          documentation ```vb\nPrivate Function Expressions.AnonymousObject() As Object\n```
'                                          enclosing_range 123:8 127:20
              Dim X = New With {Key .Helper = ""}
'                 ^ definition local 29
'                   documentation ```vb\nX As AnonymousType <anonymous type: Key Helper As String>\n```
'                   enclosing_range 124:12 124:47
'                                    ^^^^^^ reference local 31
              Dim Y = New With {X}
'                 ^ definition local 32
'                   documentation ```vb\nY As AnonymousType <anonymous type: X As AnonymousType <anonymous type: Key Helper As String>>\n```
'                   enclosing_range 125:12 125:32
'                               ^ reference local 29
              Return Y.x.Helper
'                    ^ reference local 32
'                      ^ reference local 34
'                        ^^^^^^ reference local 31
          End Function

          Class ObjectCreationClass
'               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#
'                                   documentation ```vb\nClass ObjectCreationClass\n```
'                                   enclosing_range 129:8 140:17
              Public Field As D
'                    ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#Field.
'                          documentation ```vb\nPublic ObjectCreationClass.Field As D\n```
'                          enclosing_range 130:12 130:29
'                             ^ reference scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#

              Public Sub New(ByVal field As D)
'                        ^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#`.ctor`().
'                            documentation ```vb\nPublic Sub ObjectCreationClass.New(field As D)\n```
'                            enclosing_range 132:12 134:19
'                                  ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#`.ctor`().(field)
'                                        documentation ```vb\nfield As D\n```
'                                        enclosing_range 132:27 132:43
'                                           ^ reference scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#
                  Me.Field = field
'                    ^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#Field.
'                            ^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#`.ctor`().(field)
              End Sub

              Public Class D
'                          ^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#
'                            documentation ```vb\nClass D\n```
'                            enclosing_range 136:12 139:21
                  Public Sub New(ByVal a As Integer, ByVal b As String)
'                            ^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#`.ctor`().
'                                documentation ```vb\nPublic Sub D.New(a As Integer, b As String)\n```
'                                enclosing_range 137:16 138:23
'                                      ^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#`.ctor`().(a)
'                                        documentation ```vb\na As Integer\n```
'                                        enclosing_range 137:31 137:49
'                                                          ^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#`.ctor`().(b)
'                                                            documentation ```vb\nb As String\n```
'                                                            enclosing_range 137:51 137:68
                  End Sub
              End Class
          End Class

          Private Sub ObjectCreation()
'                     ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreation().
'                                    documentation ```vb\nPrivate Sub Expressions.ObjectCreation()\n```
'                                    enclosing_range 142:8 148:15
              Dim A = New ObjectCreationClass.D(1, "hi")
'                 ^ definition local 35
'                   documentation ```vb\nA As Class D\n```
'                   enclosing_range 143:12 143:54
'                         ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#
'                                             ^ reference scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#
              Dim B = New ObjectCreationClass(A) With {
'                 ^ definition local 36
'                   documentation ```vb\nB As Class ObjectCreationClass\n```
'                   enclosing_range 144:12 146:13
'                         ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#
'                                             ^ reference local 35
                  .Field = A
'                  ^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#Field.
'                          ^ reference local 35
              }
              B = New ObjectCreationClass(A)
'             ^ reference local 36
'                     ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#
'                                         ^ reference local 35
          End Sub

          Class NamedParametersClass
'               ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#
'                                    documentation ```vb\nClass NamedParametersClass\n```
'                                    enclosing_range 150:8 163:17
              Public A As Integer
'                    ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#A.
'                      documentation ```vb\nPublic NamedParametersClass.A As Integer\n```
'                      enclosing_range 151:12 151:31
              Public B As String
'                    ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#B.
'                      documentation ```vb\nPublic NamedParametersClass.B As String\n```
'                      enclosing_range 152:12 152:30

              Public Sub New(ByVal a As Integer, ByVal b As String)
'                        ^^^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().
'                            documentation ```vb\nPublic Sub NamedParametersClass.New(a As Integer, b As String)\n```
'                            enclosing_range 154:12 157:19
'                                  ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(a)
'                                    documentation ```vb\na As Integer\n```
'                                    enclosing_range 154:27 154:45
'                                                      ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(b)
'                                                        documentation ```vb\nb As String\n```
'                                                        enclosing_range 154:47 154:64
                  Me.A = a
'                    ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#A.
'                        ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(a)
                  Me.B = b
'                    ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#B.
'                        ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(b)
              End Sub

              Public Sub Update(ByVal a As Integer, ByVal b As String)
'                        ^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().
'                               documentation ```vb\nPublic Sub NamedParametersClass.Update(a As Integer, b As String)\n```
'                               enclosing_range 159:12 162:19
'                                     ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(a)
'                                       documentation ```vb\na As Integer\n```
'                                       enclosing_range 159:30 159:48
'                                                         ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(b)
'                                                           documentation ```vb\nb As String\n```
'                                                           enclosing_range 159:50 159:67
                  Me.A = a
'                    ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#A.
'                        ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(a)
                  Me.B = b
'                    ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#B.
'                        ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(b)
              End Sub
          End Class

          Private Function NamedParameters() As NamedParametersClass
'                          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParameters().
'                                          documentation ```vb\nPrivate Function Expressions.NamedParameters() As NamedParametersClass\n```
'                                          enclosing_range 165:8 169:20
'                                               ^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#
              Dim A = New NamedParametersClass(b:="hi", a:=1)
'                 ^ definition local 37
'                   documentation ```vb\nA As Class NamedParametersClass\n```
'                   enclosing_range 166:12 166:59
'                         ^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#
'                                              ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(b)
'                                                       ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(a)
              A.Update(b:="foo", a:=42)
'             ^ reference local 37
'               ^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().
'                      ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(b)
'                                ^ reference scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(a)
              Return A
'                    ^ reference local 37
          End Function

          Private Function AnonymousFunction() As Func(Of Integer, Integer)
'                          ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AnonymousFunction().
'                                            documentation ```vb\nPrivate Function Expressions.AnonymousFunction() As Func(Of Integer, Integer)\n```
'                                            enclosing_range 171:8 174:20
              Dim d = Function(ByVal __ As Integer, ByVal ___ As Integer) 42
'                 ^ definition local 38
'                   documentation ```vb\nd As AnonymousType Function <generated method>(__ As Integer, ___ As Integer) As Integer\n```
'                   enclosing_range 172:12 172:74
'                                    ^^ definition local 40
'                                       documentation ```vb\n__ As Integer\n```
'                                       enclosing_range 172:29 172:48
'                                                         ^^^ definition local 41
'                                                             documentation ```vb\n___ As Integer\n```
'                                                             enclosing_range 172:50 172:70
              Return Function(ByVal a As Integer) a + d.Invoke(a, a)
'                                   ^ definition local 43
'                                     documentation ```vb\na As Integer\n```
'                                     enclosing_range 173:28 173:46
'                                                 ^ reference local 43
'                                                     ^ reference local 38
'                                                       ^^^^^^ reference local 45
'                                                              ^ reference local 43
'                                                                 ^ reference local 43
          End Function

          Class Lambda
'               ^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                      documentation ```vb\nClass Lambda\n```
'                      enclosing_range 176:8 180:17
              Public Function func(ByVal x As Lambda) As String
'                             ^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Lambda#func().
'                                  documentation ```vb\nPublic Function Lambda.func(x As Lambda) As String\n```
'                                  enclosing_range 177:12 179:24
'                                        ^ definition scip-dotnet nuget . . VBMain/Expressions#Lambda#func().(x)
'                                          documentation ```vb\nx As Lambda\n```
'                                          enclosing_range 177:33 177:50
'                                             ^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Lambda#
                  Return ""
              End Function
          End Class

          Private Sub LambdaExpressions()
'                     ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#LambdaExpressions().
'                                       documentation ```vb\nPrivate Sub Expressions.LambdaExpressions()\n```
'                                       enclosing_range 182:8 190:15
              Dim a = Function(ByVal x As String) x & 1
'                 ^ definition local 46
'                   documentation ```vb\na As AnonymousType Function <generated method>(x As String) As String\n```
'                   enclosing_range 183:12 183:53
'                                    ^ definition local 48
'                                      documentation ```vb\nx As String\n```
'                                      enclosing_range 183:29 183:46
'                                                 ^ reference local 48
              Dim b = Function(ByVal aa As Lambda, ByVal bb As Lambda) aa.func(bb)
'                 ^ definition local 49
'                   documentation ```vb\nb As AnonymousType Function <generated method>(aa As Lambda, bb As Lambda) As String\n```
'                   enclosing_range 184:12 184:80
'                                    ^^ definition local 51
'                                       documentation ```vb\naa As Lambda\n```
'                                       enclosing_range 184:29 184:47
'                                          ^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                                        ^^ definition local 52
'                                                           documentation ```vb\nbb As Lambda\n```
'                                                           enclosing_range 184:49 184:67
'                                                              ^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                                                      ^^ reference local 51
'                                                                         ^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Lambda#func().
'                                                                              ^^ reference local 52
              Dim c = Function(aaa As Lambda, __ As Lambda)
'                 ^ definition local 53
'                   documentation ```vb\nc As AnonymousType Function <generated method>(aaa As Lambda, __ As Lambda) As String\n```
'                   enclosing_range 185:12 189:32
'                              ^^^ definition local 55
'                                  documentation ```vb\naaa As Lambda\n```
'                                  enclosing_range 185:29 185:42
'                                     ^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                             ^^ definition local 56
'                                                documentation ```vb\n__ As Lambda\n```
'                                                enclosing_range 185:44 185:56
'                                                   ^^^^^^ reference scip-dotnet nuget . . VBMain/Expressions#Lambda#
                          If True Then
                              Return "hi"
                          End If
                      End Function
          End Sub

          Private Sub TupleExpression()
'                     ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#TupleExpression().
'                                     documentation ```vb\nPrivate Sub Expressions.TupleExpression()\n```
'                                     enclosing_range 192:8 194:15
              Dim A = (1, 2, "")
'                 ^ definition local 57
'                   documentation ```vb\nA As (Integer, Integer, String)\n```
'                   enclosing_range 193:12 193:30
          End Sub

          Private Sub ArrayCreation()
'                     ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#ArrayCreation().
'                                   documentation ```vb\nPrivate Sub Expressions.ArrayCreation()\n```
'                                   enclosing_range 196:8 217:15
              Dim a = {
'                 ^ definition local 58
'                   documentation ```vb\na As Integer(*,*)\n```
'                   enclosing_range 197:12 200:19
              {1, 1},
              {2, 2},
              {3, 3}}
              Dim d = New Integer(2) {1, 2, 3}
'                 ^ definition local 59
'                   documentation ```vb\nd As Integer()\n```
'                   enclosing_range 201:12 201:44
              Dim e = New Byte(,) {
'                 ^ definition local 60
'                   documentation ```vb\ne As Byte(*,*)\n```
'                   enclosing_range 202:12 204:19
              {1, 2},
              {2, 3}}
              Dim f = New Integer(2, 1) {
'                 ^ definition local 61
'                   documentation ```vb\nf As Integer(*,*)\n```
'                   enclosing_range 205:12 208:19
              {1, 1},
              {2, 2},
              {3, 3}}

              Dim numbers(4) As Integer
'                 ^^^^^^^ definition local 62
'                         documentation ```vb\nnumbers As Integer()\n```
'                         enclosing_range 210:12 210:37
              Dim numbers2 = New Integer() {1, 2, 4, 8}
'                 ^^^^^^^^ definition local 63
'                          documentation ```vb\nnumbers2 As Integer()\n```
'                          enclosing_range 211:12 211:53
              ReDim Preserve numbers(15)
'                            ^^^^^^^ reference local 62
              ReDim numbers(15)
'                   ^^^^^^^ reference local 62
              Dim matrix(5, 5) As Double
'                 ^^^^^^ definition local 64
'                        documentation ```vb\nmatrix As Double(*,*)\n```
'                        enclosing_range 214:12 214:38
              Dim matrix2 = New Integer(,) {{1, 2, 3}, {2, 3, 4}, {3, 4, 5}, {4, 5, 6}}
'                 ^^^^^^^ definition local 65
'                         documentation ```vb\nmatrix2 As Integer(*,*)\n```
'                         enclosing_range 215:12 215:85
              Dim sales()() As Double = New Double(11)() {}
'                 ^^^^^ definition local 66
'                       documentation ```vb\nsales As Double()()\n```
'                       enclosing_range 216:12 216:57
          End Sub

          Private Sub [TypeOf]()
'                     ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#TypeOf().
'                              documentation ```vb\nPrivate Sub Expressions.TypeOf()\n```
'                              enclosing_range 219:8 224:15
              Dim a = GetType(Integer)
'                 ^ definition local 67
'                   documentation ```vb\na As Class Type\n```
'                   enclosing_range 220:12 220:36
              Dim b = GetType(List(Of String).Enumerator)
'                 ^ definition local 68
'                   documentation ```vb\nb As Class Type\n```
'                   enclosing_range 221:12 221:55
'                                             ^^^^^^^^^^ reference scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#Enumerator#
              Dim c = GetType(Dictionary(Of,))
'                 ^ definition local 69
'                   documentation ```vb\nc As Class Type\n```
'                   enclosing_range 222:12 222:44
              Dim d = GetType(Tuple(Of,,,))
'                 ^ definition local 70
'                   documentation ```vb\nd As Class Type\n```
'                   enclosing_range 223:12 223:41
          End Sub

          Private Sub SelectCase()
'                     ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#SelectCase().
'                                documentation ```vb\nPrivate Sub Expressions.SelectCase()\n```
'                                enclosing_range 226:8 236:15
              Dim Some = 42
'                 ^^^^ definition local 71
'                      documentation ```vb\nSome As Integer\n```
'                      enclosing_range 227:12 227:25
              Select Case Some
'                         ^^^^ reference local 71
                  Case 1
                      Debug.WriteLine("One")
'                     ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#
'                           ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#WriteLine(+2).
                  Case 2
                      Debug.WriteLine("One")
'                     ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#
'                           ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#WriteLine(+2).
                  Case Else
                      Debug.WriteLine("More")
'                     ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#
'                           ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#WriteLine(+2).
              End Select
          End Sub

          Private Sub Dictionary()
'                     ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Dictionary().
'                                documentation ```vb\nPrivate Sub Expressions.Dictionary()\n```
'                                enclosing_range 238:8 240:15
              Dim A = New Dictionary(Of String, Integer) From {{1, "Test1"}, {2, "Test1"}}
'                 ^ definition local 72
'                   documentation ```vb\nA As Class Dictionary(Of String, Integer)\n```
'                   enclosing_range 239:12 239:88
          End Sub

      End Class
  End Namespace
