  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
  public class Expressions
//             ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#
//                         documentation ```cs\nclass Expressions\n```
//                         enclosing_range 4:0 339:1
  {
      void AssignmentToPrefixUnaryExpressions()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToPrefixUnaryExpressions().
//                                            documentation ```cs\nprivate void Expressions.AssignmentToPrefixUnaryExpressions()\n```
//                                            enclosing_range 7:4 22:5
      {
          var a = 42;
//            ^ definition local 0
//              documentation ```cs\nint a\n```
//              enclosing_range 9:8 9:19
          var b = 42;
//            ^ definition local 1
//              documentation ```cs\nint b\n```
//              enclosing_range 10:8 10:19
          a = +a;
//        ^ reference local 0
//             ^ reference local 0
          a = -a;
//        ^ reference local 0
//             ^ reference local 0
          a = ~a;
//        ^ reference local 0
//             ^ reference local 0
          a = ++a;
//        ^ reference local 0
//              ^ reference local 0
          a = --a;
//        ^ reference local 0
//              ^ reference local 0
          a = a++;
//        ^ reference local 0
//            ^ reference local 0
          a = a--;
//        ^ reference local 0
//            ^ reference local 0
          b = a!;
//        ^ reference local 1
//            ^ reference local 0

          var c = true;
//            ^ definition local 2
//              documentation ```cs\nbool c\n```
//              enclosing_range 20:8 20:21
          c = !c;
//        ^ reference local 2
//             ^ reference local 2
      }

      void AssignmentToPrefixBinaryExpressions()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToPrefixBinaryExpressions().
//                                             documentation ```cs\nprivate void Expressions.AssignmentToPrefixBinaryExpressions()\n```
//                                             enclosing_range 24:4 38:5
      {
          var a = 42;
//            ^ definition local 3
//              documentation ```cs\nint a\n```
//              enclosing_range 26:8 26:19
          a = a + a;
//        ^ reference local 3
//            ^ reference local 3
//                ^ reference local 3
          a = a - a;
//        ^ reference local 3
//            ^ reference local 3
//                ^ reference local 3
          a = a * a;
//        ^ reference local 3
//            ^ reference local 3
//                ^ reference local 3
          a = a / a;
//        ^ reference local 3
//            ^ reference local 3
//                ^ reference local 3
          a = a % a;
//        ^ reference local 3
//            ^ reference local 3
//                ^ reference local 3
          a = a & a;
//        ^ reference local 3
//            ^ reference local 3
//                ^ reference local 3
          a = a | a;
//        ^ reference local 3
//            ^ reference local 3
//                ^ reference local 3
          a = a ^ a;
//        ^ reference local 3
//            ^ reference local 3
//                ^ reference local 3
          a = a >> a;
//        ^ reference local 3
//            ^ reference local 3
//                 ^ reference local 3
          a = a << a;
//        ^ reference local 3
//            ^ reference local 3
//                 ^ reference local 3
          a = a >>> a;
//        ^ reference local 3
//            ^ reference local 3
//                  ^ reference local 3
      }

      void AssignmentToBinaryEqualityExpression()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToBinaryEqualityExpression().
//                                              documentation ```cs\nprivate void Expressions.AssignmentToBinaryEqualityExpression()\n```
//                                              enclosing_range 40:4 52:5
      {
          var a = true;
//            ^ definition local 4
//              documentation ```cs\nbool a\n```
//              enclosing_range 42:8 42:21
          var b = true;
//            ^ definition local 5
//              documentation ```cs\nbool b\n```
//              enclosing_range 43:8 43:21
          var c = 42;
//            ^ definition local 6
//              documentation ```cs\nint c\n```
//              enclosing_range 44:8 44:19
          var d = 42;
//            ^ definition local 7
//              documentation ```cs\nint d\n```
//              enclosing_range 45:8 45:19
          a = a == b;
//        ^ reference local 4
//            ^ reference local 4
//                 ^ reference local 5
          a = a != b;
//        ^ reference local 4
//            ^ reference local 4
//                 ^ reference local 5
          a = c < d;
//        ^ reference local 4
//            ^ reference local 6
//                ^ reference local 7
          a = c <= d;
//        ^ reference local 4
//            ^ reference local 6
//                 ^ reference local 7
          a = c > d;
//        ^ reference local 4
//            ^ reference local 6
//                ^ reference local 7
          a = c >= d;
//        ^ reference local 4
//            ^ reference local 6
//                 ^ reference local 7
      }

      void AssignmentToBinaryExpression()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToBinaryExpression().
//                                      documentation ```cs\nprivate void Expressions.AssignmentToBinaryExpression()\n```
//                                      enclosing_range 54:4 67:5
      {
          var a = 42;
//            ^ definition local 8
//              documentation ```cs\nint a\n```
//              enclosing_range 56:8 56:19
          a += a;
//        ^ reference local 8
//             ^ reference local 8
          a -= a;
//        ^ reference local 8
//             ^ reference local 8
          a *= a;
//        ^ reference local 8
//             ^ reference local 8
          a /= a;
//        ^ reference local 8
//             ^ reference local 8
          a %= a;
//        ^ reference local 8
//             ^ reference local 8
          a++;
//        ^ reference local 8
          a--;
//        ^ reference local 8
          a <<= a;
//        ^ reference local 8
//              ^ reference local 8
          a >>= a;
//        ^ reference local 8
//              ^ reference local 8
          a >>>= a;
//        ^ reference local 8
//               ^ reference local 8
      }

      struct Struct
//           ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Struct#
//                  documentation ```cs\nstruct Struct\n```
//                  enclosing_range 69:4 72:5
      {
          public int Property;
//                   ^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Struct#Property.
//                            documentation ```cs\npublic int Struct.Property\n```
//                            enclosing_range 71:8 71:28
      }

      struct IndexedClass
//           ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#IndexedClass#
//                        documentation ```cs\nstruct IndexedClass\n```
//                        enclosing_range 74:4 83:5
      {
          public int Property;
//                   ^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#IndexedClass#Property.
//                            documentation ```cs\npublic int IndexedClass.Property\n```
//                            enclosing_range 76:8 76:28

          public int this[int index]
//                            ^^^^^ definition scip-dotnet nuget . . Main/Expressions#IndexedClass#`this[]`.(index)
//                                  documentation ```cs\nint index\n```
//                                  enclosing_range 78:24 78:33
          {
              get { return Property; }
//                         ^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#IndexedClass#Property.
              set { Property = value; }
//                  ^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#IndexedClass#Property.
//                             ^^^^^ reference scip-dotnet nuget . . Main/Expressions#IndexedClass#set_Item().(value)
          }
      }

      void AssignmentToLeftValueTypes()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToLeftValueTypes().
//                                    documentation ```cs\nprivate void Expressions.AssignmentToLeftValueTypes()\n```
//                                    enclosing_range 85:4 106:5
      {
          (var a, var b) = (1, 2);
//             ^ definition local 9
//               documentation ```cs\nint a\n```
//               enclosing_range 87:13 87:14
//                    ^ definition local 10
//                      documentation ```cs\nint b\n```
//                      enclosing_range 87:20 87:21
          a = 1;
//        ^ reference local 9
          var c = new Struct { Property = 42 };
//            ^ definition local 11
//              documentation ```cs\nStruct c\n```
//              enclosing_range 89:8 89:45
//                    ^^^^^^ reference scip-dotnet nuget . . Main/Expressions#Struct#
//                             ^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#Struct#Property.
          c.Property = 1;
//        ^ reference local 11
//          ^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#Struct#Property.
          var d = new IndexedClass();
//            ^ definition local 12
//              documentation ```cs\nIndexedClass d\n```
//              enclosing_range 91:8 91:35
//                    ^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#IndexedClass#
          d[b] = 1;
//        ^ reference local 12
//          ^ reference local 10
          (a, b) = (1, 2);
//         ^ reference local 9
//            ^ reference local 10
          var x = new IndexedClass
//            ^ definition local 13
//              documentation ```cs\nIndexedClass x\n```
//              enclosing_range 94:8 98:10
//                    ^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#IndexedClass#
          {
              Property = 1,
//            ^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#IndexedClass#Property.
              [b] = 1
//             ^ reference local 10
          };
          (a) = 1;
//         ^ reference local 9
          unsafe
          {
              int myInt = 5;
//                ^^^^^ definition local 14
//                      documentation ```cs\nint myInt\n```
//                      enclosing_range 102:12 102:26
              int* p = &myInt;
//                 ^ definition local 15
//                   documentation ```cs\nint* p\n```
//                   enclosing_range 103:12 103:28
//                      ^^^^^ reference local 14
              Console.WriteLine("myInt = {0}, *p = {1}", myInt, *p);
//            ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+14).
//                                                       ^^^^^ reference local 14
//                                                               ^ reference local 15
          }
      }

      void TernaryExpression()
//         ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TernaryExpression().
//                           documentation ```cs\nprivate void Expressions.TernaryExpression()\n```
//                           enclosing_range 108:4 114:5
      {
          var x = true;
//            ^ definition local 16
//              documentation ```cs\nbool x\n```
//              enclosing_range 110:8 110:21
          var y = x ? "foo" : "bar";
//            ^ definition local 17
//              documentation ```cs\nstring? y\n```
//              enclosing_range 111:8 111:34
//                ^ reference local 16
          object z = true;
//               ^ definition local 18
//                 documentation ```cs\nobject z\n```
//                 enclosing_range 112:8 112:24
          var t = z is bool ? 42 : 41;
//            ^ definition local 19
//              documentation ```cs\nint t\n```
//              enclosing_range 113:8 113:36
//                ^ reference local 18
      }

      class Cast
//          ^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#
//               documentation ```cs\nclass Cast\n```
//               enclosing_range 116:4 130:5
      {
          public Cast nested;
//               ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#
//                    ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#nested.
//                           documentation ```cs\npublic Cast Cast.nested\n```
//                           enclosing_range 118:8 118:27
          public Cast2 nested2;
//               ^^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#Cast2#
//                     ^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#nested2.
//                             documentation ```cs\npublic Cast2 Cast.nested2\n```
//                             enclosing_range 119:8 119:29

          public Cast plus(Cast other)
//               ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#
//                    ^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#plus().
//                         documentation ```cs\npublic Cast Cast.plus(Cast other)\n```
//                         enclosing_range 121:8 125:9
//                         ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#
//                              ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#plus().(other)
//                                    documentation ```cs\nCast other\n```
//                                    enclosing_range 121:25 121:35
          {
              nested = other;
//            ^^^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#nested.
//                     ^^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#plus().(other)
              return this;
          }

          public class Cast2
//                     ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#Cast2#
//                           documentation ```cs\nclass Cast2\n```
//                           enclosing_range 127:8 129:9
          {
          }
      }

      int CastExpressions()
//        ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#CastExpressions().
//                        documentation ```cs\nprivate int Expressions.CastExpressions()\n```
//                        enclosing_range 132:4 143:5
      {
          object a = new Cast();
//               ^ definition local 20
//                 documentation ```cs\nobject a\n```
//                 enclosing_range 134:8 134:30
//                       ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#
          object b = new Cast();
//               ^ definition local 21
//                 documentation ```cs\nobject b\n```
//                 enclosing_range 135:8 135:30
//                       ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#
          Cast c = ((Cast)a).plus((Cast)b);
//        ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#
//             ^ definition local 22
//               documentation ```cs\nCast c\n```
//               enclosing_range 136:8 136:41
//                   ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#
//                        ^ reference local 20
//                           ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#plus().
//                                 ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#
//                                      ^ reference local 21
          Cast d = (Cast)new object[] { a, b }[0];
//        ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#
//             ^ definition local 23
//               documentation ```cs\nCast d\n```
//               enclosing_range 137:8 137:48
//                  ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#
//                                      ^ reference local 20
//                                         ^ reference local 21
          var e = (Cast.Cast2)(c.nested.nested2);
//            ^ definition local 24
//              documentation ```cs\nCast2? e\n```
//              enclosing_range 138:8 138:47
//                 ^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#
//                      ^^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#Cast2#
//                             ^ reference local 22
//                               ^^^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#nested.
//                                      ^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#Cast#nested2.
          var f = (Int32)(1);
//            ^ definition local 25
//              documentation ```cs\nint f\n```
//              enclosing_range 139:8 139:27
//                 ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var g = (Int32)(1);
//            ^ definition local 26
//              documentation ```cs\nint g\n```
//              enclosing_range 140:8 140:27
//                 ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var h = (Int32)((1));
//            ^ definition local 27
//              documentation ```cs\nint h\n```
//              enclosing_range 141:8 141:29
//                 ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          return f + g + h;
//               ^ reference local 25
//                   ^ reference local 26
//                       ^ reference local 27
      }

      object AnonymousObject()
//           ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AnonymousObject().
//                           documentation ```cs\nprivate object Expressions.AnonymousObject()\n```
//                           enclosing_range 145:4 153:5
      {
          var x = new { Helper = "" };
//            ^ definition local 28
//              documentation ```cs\n<anonymous type: string Helper>? x\n```
//              enclosing_range 147:8 147:36
//                      ^^^^^^ reference local 30
          var y = new
//            ^ definition local 31
//              documentation ```cs\n<anonymous type: AnonymousType <anonymous type: string Helper> x>? y\n```
//              enclosing_range 148:8 151:10
          {
              x
//            ^ reference local 28
          };
          return y.x.Helper;
//               ^ reference local 31
//                 ^ reference local 33
//                   ^^^^^^ reference local 30
      }

      class TargetType
//          ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TargetType#
//                     documentation ```cs\nclass TargetType\n```
//                     enclosing_range 155:4 160:5
      {
          public TargetType(string name)
//               ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TargetType#`.ctor`().
//                          documentation ```cs\npublic TargetType.TargetType(string name)\n```
//                          enclosing_range 157:8 159:9
//                                 ^^^^ definition scip-dotnet nuget . . Main/Expressions#TargetType#`.ctor`().(name)
//                                      documentation ```cs\nstring name\n```
//                                      enclosing_range 157:26 157:37
          {
          }
      }

      TargetType TargetTypeNew()
//    ^^^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#TargetType#
//               ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TargetTypeNew().
//                             documentation ```cs\nprivate TargetType Expressions.TargetTypeNew()\n```
//                             enclosing_range 162:4 166:5
      {
          TargetType x = new("x");
//        ^^^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#TargetType#
//                   ^ definition local 34
//                     documentation ```cs\nTargetType x\n```
//                     enclosing_range 164:8 164:32
          return x;
//               ^ reference local 34
      }

      int Checked()
//        ^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Checked().
//                documentation ```cs\nprivate int Expressions.Checked()\n```
//                enclosing_range 168:4 172:5
      {
          var three = checked(1 + 2);
//            ^^^^^ definition local 35
//                  documentation ```cs\nint three\n```
//                  enclosing_range 170:8 170:35
          return three;
//               ^^^^^ reference local 35
      }

      class ObjectCreationClass
//          ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                              documentation ```cs\nclass ObjectCreationClass\n```
//                              enclosing_range 174:4 189:5
      {
          public D field;
//               ^ reference scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                 ^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#field.
//                       documentation ```cs\npublic D ObjectCreationClass.field\n```
//                       enclosing_range 176:8 176:23

          public ObjectCreationClass(D field)
//               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#`.ctor`().
//                                   documentation ```cs\npublic ObjectCreationClass.ObjectCreationClass(D field)\n```
//                                   enclosing_range 178:8 181:9
//                                   ^ reference scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                                     ^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#`.ctor`().(field)
//                                           documentation ```cs\nD field\n```
//                                           enclosing_range 178:35 178:42
          {
              this.field = field;
//                 ^^^^^ reference scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#field.
//                         ^^^^^ reference scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#`.ctor`().(field)
          }

          public class D
//                     ^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                       documentation ```cs\nclass D\n```
//                       enclosing_range 183:8 188:9
          {
              public D(int a, string b)
//                   ^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#`.ctor`().
//                     documentation ```cs\npublic D.D(int a, string b)\n```
//                     enclosing_range 185:12 187:13
//                         ^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#`.ctor`().(a)
//                           documentation ```cs\nint a\n```
//                           enclosing_range 185:21 185:26
//                                   ^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#`.ctor`().(b)
//                                     documentation ```cs\nstring b\n```
//                                     enclosing_range 185:28 185:36
              {
              }
          }
      }

      void ObjectCreation()
//         ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreation().
//                        documentation ```cs\nprivate void Expressions.ObjectCreation()\n```
//                        enclosing_range 191:4 200:5
      {
          var a = new ObjectCreationClass.D(1, "hi");
//            ^ definition local 36
//              documentation ```cs\nD? a\n```
//              enclosing_range 193:8 193:51
//                    ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                                        ^ reference scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
          var b = new ObjectCreationClass(a)
//            ^ definition local 37
//              documentation ```cs\nObjectCreationClass? b\n```
//              enclosing_range 194:8 197:10
//                    ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                                        ^ reference local 36
          {
              field = a,
//            ^^^^^ reference scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#field.
//                    ^ reference local 36
          };
          b = new ObjectCreationClass(a);
//        ^ reference local 37
//                ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                                    ^ reference local 36
          b = new ObjectCreationClass(a) { };
//        ^ reference local 37
//                ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                                    ^ reference local 36
      }

      class NamedParametersClass
//          ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#
//                               documentation ```cs\nclass NamedParametersClass\n```
//                               enclosing_range 202:4 218:5
      {
          public int A;
//                   ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#A.
//                     documentation ```cs\npublic int NamedParametersClass.A\n```
//                     enclosing_range 204:8 204:21
          public string B;
//                      ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#B.
//                        documentation ```cs\npublic string NamedParametersClass.B\n```
//                        enclosing_range 205:8 205:24

          public NamedParametersClass(int a, string b)
//               ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().
//                                    documentation ```cs\npublic NamedParametersClass.NamedParametersClass(int a, string b)\n```
//                                    enclosing_range 207:8 211:9
//                                        ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(a)
//                                          documentation ```cs\nint a\n```
//                                          enclosing_range 207:36 207:41
//                                                  ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(b)
//                                                    documentation ```cs\nstring b\n```
//                                                    enclosing_range 207:43 207:51
          {
              A = a;
//            ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#A.
//                ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(a)
              B = b;
//            ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#B.
//                ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(b)
          }

          public void Update(int a, string b)
//                    ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().
//                           documentation ```cs\npublic void NamedParametersClass.Update(int a, string b)\n```
//                           enclosing_range 213:8 217:9
//                               ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(a)
//                                 documentation ```cs\nint a\n```
//                                 enclosing_range 213:27 213:32
//                                         ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(b)
//                                           documentation ```cs\nstring b\n```
//                                           enclosing_range 213:34 213:42
          {
              A = a;
//            ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#A.
//                ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(a)
              B = b;
//            ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#B.
//                ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(b)
          }
      }

      NamedParametersClass NamedParameters()
//    ^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#
//                         ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#NamedParameters().
//                                         documentation ```cs\nprivate NamedParametersClass Expressions.NamedParameters()\n```
//                                         enclosing_range 220:4 225:5
      {
          var a = new NamedParametersClass(b: "hi", a: 1);
//            ^ definition local 38
//              documentation ```cs\nNamedParametersClass? a\n```
//              enclosing_range 222:8 222:56
//                    ^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#
//                                         ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(b)
//                                                  ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(a)
          a.Update(b: "foo", a: 42);
//        ^ reference local 38
//          ^^^^^^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().
//                 ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(b)
//                           ^ reference scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(a)
          return a;
//               ^ reference local 38
      }

      Func<int, int> AnonymousFunction()
//                   ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AnonymousFunction().
//                                     documentation ```cs\nprivate Func<int, int> Expressions.AnonymousFunction()\n```
//                                     enclosing_range 227:4 231:5
      {
          var d = delegate (int _, int _) { return 42; };
//            ^ definition local 39
//              documentation ```cs\nFunc<int, int, int>? d\n```
//              enclosing_range 229:8 229:55
//                              ^ definition local 41
//                                documentation ```cs\nint _\n```
//                                enclosing_range 229:26 229:31
//                                     ^ definition local 42
//                                       documentation ```cs\nint _\n```
//                                       enclosing_range 229:33 229:38
          return delegate (int a) { return a + d.Invoke(a, a); };
//                             ^ definition local 44
//                               documentation ```cs\nint a\n```
//                               enclosing_range 230:25 230:30
//                                         ^ reference local 44
//                                             ^ reference local 39
//                                               ^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Func#Invoke().
//                                                      ^ reference local 44
//                                                         ^ reference local 44
      }

      class Lambda
//          ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Lambda#
//                 documentation ```cs\nclass Lambda\n```
//                 enclosing_range 233:4 239:5
      {
          public string func(Lambda x)
//                      ^^^^ definition scip-dotnet nuget . . Main/Expressions#Lambda#func().
//                           documentation ```cs\npublic string Lambda.func(Lambda x)\n```
//                           enclosing_range 235:8 238:9
//                           ^^^^^^ reference scip-dotnet nuget . . Main/Expressions#Lambda#
//                                  ^ definition scip-dotnet nuget . . Main/Expressions#Lambda#func().(x)
//                                    documentation ```cs\nLambda x\n```
//                                    enclosing_range 235:27 235:35
          {
              return "";
          }
      }

      void LambdaExpressions()
//         ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#LambdaExpressions().
//                           documentation ```cs\nprivate void Expressions.LambdaExpressions()\n```
//                           enclosing_range 241:4 246:5
      {
          var a = (string x) => x + 1;
//            ^ definition local 45
//              documentation ```cs\nFunc<string, string>? a\n```
//              enclosing_range 243:8 243:36
//                        ^ definition local 47
//                          documentation ```cs\nstring x\n```
//                          enclosing_range 243:17 243:25
//                              ^ reference local 47
          var b = (Lambda a, Lambda b) => { return a.func(b); };
//            ^ definition local 48
//              documentation ```cs\nFunc<Lambda, Lambda, string>? b\n```
//              enclosing_range 244:8 244:62
//                 ^^^^^^ reference scip-dotnet nuget . . Main/Expressions#Lambda#
//                        ^ definition local 50
//                          documentation ```cs\nLambda a\n```
//                          enclosing_range 244:17 244:25
//                           ^^^^^^ reference scip-dotnet nuget . . Main/Expressions#Lambda#
//                                  ^ definition local 51
//                                    documentation ```cs\nLambda b\n```
//                                    enclosing_range 244:27 244:35
//                                                 ^ reference local 50
//                                                   ^^^^ reference scip-dotnet nuget . . Main/Expressions#Lambda#func().
//                                                        ^ reference local 51
          var c = string (Lambda a, Lambda _) => { return "hi"; };
//            ^ definition local 52
//              documentation ```cs\nFunc<Lambda, Lambda, string>? c\n```
//              enclosing_range 245:8 245:64
//                        ^^^^^^ reference scip-dotnet nuget . . Main/Expressions#Lambda#
//                               ^ definition local 54
//                                 documentation ```cs\nLambda a\n```
//                                 enclosing_range 245:24 245:32
//                                  ^^^^^^ reference scip-dotnet nuget . . Main/Expressions#Lambda#
//                                         ^ definition local 55
//                                           documentation ```cs\nLambda _\n```
//                                           enclosing_range 245:34 245:42
      }

      void TupleExpressions()
//         ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TupleExpressions().
//                          documentation ```cs\nprivate void Expressions.TupleExpressions()\n```
//                          enclosing_range 248:4 251:5
      {
          var a = (1, 2, "");
//            ^ definition local 56
//              documentation ```cs\n(int, int, string) a\n```
//              enclosing_range 250:8 250:27
      }

      void ArrayCreation()
//         ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#ArrayCreation().
//                       documentation ```cs\nprivate void Expressions.ArrayCreation()\n```
//                       enclosing_range 253:4 262:5
      {
          var a = new[,] { { 1, 1 }, { 2, 2 }, { 3, 3 } };
//            ^ definition local 57
//              documentation ```cs\nint[*,*]? a\n```
//              enclosing_range 255:8 255:56
          Span<int> b = stackalloc[] { 1, 2, 3 };
//                  ^ definition local 58
//                    documentation ```cs\nSpan<int> b\n```
//                    enclosing_range 256:8 256:47
          Span<int> c = stackalloc int[] { 1, 2, 3 };
//                  ^ definition local 59
//                    documentation ```cs\nSpan<int> c\n```
//                    enclosing_range 257:8 257:51
          var d = new int[3] { 1, 2, 3 };
//            ^ definition local 60
//              documentation ```cs\nint[]? d\n```
//              enclosing_range 258:8 258:39
          var e = new byte[,] { { 1, 2 }, { 2, 3 } };
//            ^ definition local 61
//              documentation ```cs\nbyte[*,*]? e\n```
//              enclosing_range 259:8 259:51
          var f = new int[3, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 } };
//            ^ definition local 62
//              documentation ```cs\nint[*,*]? f\n```
//              enclosing_range 260:8 260:63
          var g = new (string b, string c)[3];
//            ^ definition local 63
//              documentation ```cs\n(string b, string c)[]? g\n```
//              enclosing_range 261:8 261:44
      }

      void MakeRef()
//         ^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#MakeRef().
//                 documentation ```cs\nprivate void Expressions.MakeRef()\n```
//                 enclosing_range 264:4 268:5
      {
          var g = "";
//            ^ definition local 64
//              documentation ```cs\nstring? g\n```
//              enclosing_range 266:8 266:19
          var a = __makeref(g);
//            ^ definition local 65
//              documentation ```cs\nTypedReference a\n```
//              enclosing_range 267:8 267:29
//                          ^ reference local 64
      }

      void SizeOf()
//         ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#SizeOf().
//                documentation ```cs\nprivate void Expressions.SizeOf()\n```
//                enclosing_range 270:4 273:5
      {
          var a = sizeof(int);
//            ^ definition local 66
//              documentation ```cs\nint a\n```
//              enclosing_range 272:8 272:28
      }

      void TypeOf()
//         ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TypeOf().
//                documentation ```cs\nprivate void Expressions.TypeOf()\n```
//                enclosing_range 275:4 281:5
      {
          var a = typeof(int);
//            ^ definition local 67
//              documentation ```cs\nType? a\n```
//              enclosing_range 277:8 277:28
          var b = typeof(List<string>.Enumerator);
//            ^ definition local 68
//              documentation ```cs\nType? b\n```
//              enclosing_range 278:8 278:48
//                                    ^^^^^^^^^^ reference scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#Enumerator#
          var c = typeof(Dictionary<,>);
//            ^ definition local 69
//              documentation ```cs\nType? c\n```
//              enclosing_range 279:8 279:38
          var d = typeof(Tuple<,,,>);
//            ^ definition local 70
//              documentation ```cs\nType? d\n```
//              enclosing_range 280:8 280:35
      }

      interface IAnimal
//              ^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#IAnimal#
//                      documentation ```cs\ninterface IAnimal\n```
//                      enclosing_range 283:4 286:5
      {
          string Sound();
//               ^^^^^ definition scip-dotnet nuget . . Main/Expressions#IAnimal#Sound().
//                     documentation ```cs\nstring IAnimal.Sound()\n```
//                     enclosing_range 285:8 285:23
      }

      public class Dog : IAnimal
//                 ^^^ definition scip-dotnet nuget . . Main/Expressions#Dog#
//                     documentation ```cs\nclass Dog\n```
//                     relationship implementation scip-dotnet nuget . . Main/Expressions#IAnimal#
//                     enclosing_range 288:4 294:5
//                       ^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#IAnimal#
      {
          public string Sound()
//                      ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Dog#Sound().
//                            documentation ```cs\npublic string Dog.Sound()\n```
//                            relationship implementation reference scip-dotnet nuget . . Main/Expressions#IAnimal#Sound().
//                            enclosing_range 290:8 293:9
          {
              return "woof";
          }
      }

      public class Cat : IAnimal
//                 ^^^ definition scip-dotnet nuget . . Main/Expressions#Cat#
//                     documentation ```cs\nclass Cat\n```
//                     relationship implementation scip-dotnet nuget . . Main/Expressions#IAnimal#
//                     enclosing_range 296:4 302:5
//                       ^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#IAnimal#
      {
          public string Sound()
//                      ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cat#Sound().
//                            documentation ```cs\npublic string Cat.Sound()\n```
//                            relationship implementation reference scip-dotnet nuget . . Main/Expressions#IAnimal#Sound().
//                            enclosing_range 298:8 301:9
          {
              return "meow";
          }
      }

      void Switch()
//         ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Switch().
//                documentation ```cs\nprivate void Expressions.Switch()\n```
//                enclosing_range 304:4 320:5
      {
          int some = 42;
//            ^^^^ definition local 71
//                 documentation ```cs\nint some\n```
//                 enclosing_range 306:8 306:22
          var a = some switch
//            ^ definition local 72
//              documentation ```cs\nstring? a\n```
//              enclosing_range 307:8 312:10
//                ^^^^ reference local 71
          {
              1 => "one",
              2 => "two",
              _ => "more"
          };
          IAnimal dog = new Dog();
//        ^^^^^^^ reference scip-dotnet nuget . . Main/Expressions#IAnimal#
//                ^^^ definition local 73
//                    documentation ```cs\nIAnimal dog\n```
//                    enclosing_range 313:8 313:32
//                          ^^^ reference scip-dotnet nuget . . Main/Expressions#Dog#
          var b = dog switch
//            ^ definition local 74
//              documentation ```cs\nstring? b\n```
//              enclosing_range 314:8 319:10
//                ^^^ reference local 73
          {
              Cat c => c.Sound(),
//            ^^^ reference scip-dotnet nuget . . Main/Expressions#Cat#
//                ^ definition local 75
//                  documentation ```cs\nCat c\n```
//                  enclosing_range 316:16 316:17
//                     ^ reference local 75
//                       ^^^^^ reference scip-dotnet nuget . . Main/Expressions#Cat#Sound().
              Dog c => c.Sound(),
//            ^^^ reference scip-dotnet nuget . . Main/Expressions#Dog#
//                ^ definition local 76
//                  documentation ```cs\nDog c\n```
//                  enclosing_range 317:16 317:17
//                     ^ reference local 76
//                       ^^^^^ reference scip-dotnet nuget . . Main/Expressions#Dog#Sound().
              _ => throw new ArgumentOutOfRangeException()
//                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/ArgumentOutOfRangeException#
          };
      }

      void Dictionary()
//         ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Dictionary().
//                    documentation ```cs\nprivate void Expressions.Dictionary()\n```
//                    enclosing_range 322:4 325:5
      {
          var a = new Dictionary<string, int> { ["a"] = 65 };
//            ^ definition local 77
//              documentation ```cs\nDictionary<string, int>? a\n```
//              enclosing_range 324:8 324:59
      }

      void Is()
//         ^^ definition scip-dotnet nuget . . Main/Expressions#Is().
//            documentation ```cs\nprivate void Expressions.Is()\n```
//            enclosing_range 327:4 338:5
      {
          object s = "s";
//               ^ definition local 78
//                 documentation ```cs\nobject s\n```
//                 enclosing_range 329:8 329:23
          if (s is string s2)
//            ^ reference local 78
//                        ^^ definition local 79
//                           documentation ```cs\nstring s2\n```
//                           enclosing_range 330:24 330:26
          {
              Console.WriteLine(s2);
//            ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
//                              ^^ reference local 79
          }

          var c = s is "test";
//            ^ definition local 80
//              documentation ```cs\nbool c\n```
//              enclosing_range 335:8 335:28
//                ^ reference local 78
          var a = s is int.MaxValue;
//            ^ definition local 81
//              documentation ```cs\nbool a\n```
//              enclosing_range 336:8 336:34
//                ^ reference local 78
//                         ^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#MaxValue.
          var d = s is nameof(a);
//            ^ definition local 82
//              documentation ```cs\nbool d\n```
//              enclosing_range 337:8 337:31
//                ^ reference local 78
//                            ^ reference local 81
      }
  }
