<h1>Generics</h1>
The technique of writing functions independently or within a class, without having to overload them many times to be able to use them with different data types. System.Collections.Generic implements many of the generics for System.Collections data structures.
<hr>
<h1>Generic Programming</h1>
One of the problems with OOP is a condition called "code bloat". A kind of code bloat occurs when you need to override a method or a set of methods to account for all possible data types of the method's parameters. One solution to code bloat is that a value can assume multiple data types and provide only one definition of that value. This technique is called generic programming. A generic program provides a "placeholder" that is populated by a particular data type at compile time. This placeholder is represented by an identifier placed between square brackets (< >). Let's look at an example.
<hr>
A standard first example for generic programming is the substitution method. The definition of a generic replacement method in C# could be:
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198851967-18743710-5894-4c2f-a863-4fcc35d017d1.png" alt="Swap">
<hr>
The placeholder for the data type is placed immediately after the method name. The identifier enclosed in square brackets is now used when a generic data type is required. Each of the parameters is assigned a generic data type, such as the temporary variable used for swapping. A program that tests this code:
<hr>
Generics are not limited to function definitions; you can also create generic classes. A generic class definition will contain a generic type placeholder after the class name. The type placeholder must be provided each time a reference is made to the class name in the definition. The following class definition shows how to create a generic class:


<img src="https://user-images.githubusercontent.com/107070882/198852120-8311687e-3b38-48f5-bf02-26d180f12e1f.png" alt="Node">


This class can be used as follows.


<img src="https://user-images.githubusercontent.com/107070882/198853125-3e9017a7-8ff6-465d-8354-00c76a58171b.png" alt="NodeType">


While this use of generic programming is quite useful, C# already provides a library of ready-to-use generic data structures. These data structures are located in the System.Collection.Generics namespace, and we will examine the use of a data structure that is part of this namespace in my other repositories. In general, these classes have the same functionality as non-generic data structure classes, so we will generally limit considerations of the generic class to how to instantiate an object of that class, as other methods and their usage are not different.
<hr>
<h1>Jenerikler (Generics)</h1>
Farklı veri türleri ile kullanabilmek için birçok kez overload etmek zorunda kalmadan, fonksiyonları bağımsız olarak veya bir sınıf içinde yazma tekniği. System.Collections.Generic jeneriklerin birçoğunu System.Collections veri yapıları için uygular.
<hr>
<h1>Jenerik Programlama</h1>
OOP ile ilgili sorunlardan biri “kod şişkinliği” adı verilen bir durumdur. Bir tür kod şişmesi, yöntemin parametrelerinin olası tüm veri türlerini hesaba katmak için bir yöntemi veya bir dizi yöntemi override etmeniz gerektiğinde ortaya çıkar. Kod şişkinliği için bir çözüm, bir değerin birden çok veri türünü üstlenebilmesi ve bu değerin yalnızca bir tanımının sağlamasıdır. Bu tekniğe jenerik (genel) programlama denir. Jenerik bir program, derleme zamanında belirli bir veri türü tarafından doldurulan bir "yer tutucu" sağlar. Bu yer tutucu, köşeli ayraçlar (< >) arasına yerleştirilmiş bir tanımlayıcı ile temsil edilir. Bir örneğe bakalım.
<hr>
Jenerik programlama için standart bir ilk örnek, değiştirme yöntemidir. C#’ta jenerik bir değiştirme yönteminin tanımı şu şekilde olabilir:
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198851967-18743710-5894-4c2f-a863-4fcc35d017d1.png" alt="Swap">
<hr>
Veri türü için yer tutucu, yöntem adından hemen sonraya yerleştirilir. Köşeli parantezlerin içine yerleştirilen tanımlayıcı, artık genel bir veri türü gerektiğinde kullanılmaktadır. Parametrelerin her birine, takas yapmak için kullanılan geçici değişken gibi genel bir veri türü atanır. Bu kodu test eden bir program:
<hr>
Jenerikler, fonksiyon tanımlarıyla sınırlı değildir; jenerik sınıflar da oluşturabilirsiniz. Jenerik bir sınıf tanımı, sınıf adından sonra jenerik bir tür yer tutucusu içerecektir. Tanımda sınıf adına her başvuru yapıldığında, tür yer tutucusu sağlanmalıdır. Aşağıdaki sınıf tanımı, jenerik bir sınıfın nasıl oluşturulacağını gösteriyor:
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198852120-8311687e-3b38-48f5-bf02-26d180f12e1f.png" alt="Node">
<hr>
Bu sınıf aşağıfaki gibi kullanılabilir.
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198853125-3e9017a7-8ff6-465d-8354-00c76a58171b.png" alt="NodeType">
<hr>
Jenerik programlamanın bu kullanımı oldukça yararlı olsa da, C# zaten kullanıma hazır jenerik veri yapılarından oluşan bir kitaplık sağlar. Bu veri yapıları System.Collection.Generics ad alanında bulunur ve bu ad alanının parçası olan bir veri yapısını diğer repositories'lerimde kullanımını inceleyeceğiz. Genel olarak, bu sınıflar, jenerik olmayan veri yapısı sınıflarıyla aynı işlevselliğe sahiptir, bu nedenle, diğer yöntemler ve kullanımları farklı olmadığından, jenerik sınıfla ilgili değerlendirmeleri genellikle o sınıfın bir nesnesinin nasıl başlatılacağıyla sınırlayacağız.
