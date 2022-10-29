<h1>Jenerikler (Generics)</h1>
Farklı veri türleri ile kullanabilmek için birçok kez overload etmek zorunda kalmadan, fonksiyonları bağımsız olarak veya bir sınıf içinde yazma tekniği. System.Collections.Generic jeneriklerin birçoğunu System.Collections veri yapıları için uygular.


<h1>Jenerik Programlama</h1>
OOP ile ilgili sorunlardan biri “kod şişkinliği” adı verilen bir durumdur. Bir tür kod şişmesi, yöntemin parametrelerinin olası tüm veri türlerini hesaba katmak için bir yöntemi veya bir dizi yöntemi override etmeniz gerektiğinde ortaya çıkar. Kod şişkinliği için bir çözüm, bir değerin birden çok veri türünü üstlenebilmesi ve bu değerin yalnızca bir tanımının sağlamasıdır. Bu tekniğe jenerik (genel) programlama denir. Jenerik bir program, derleme zamanında belirli bir veri türü tarafından doldurulan bir "yer tutucu" sağlar. Bu yer tutucu, köşeli ayraçlar (< >) arasına yerleştirilmiş bir tanımlayıcı ile temsil edilir. Bir örneğe bakalım.


Jenerik programlama için standart bir ilk örnek, değiştirme yöntemidir. C#’ta jenerik bir değiştirme yönteminin tanımı şu şekilde olabilir:


<img src="https://user-images.githubusercontent.com/107070882/198851967-18743710-5894-4c2f-a863-4fcc35d017d1.png" alt="Swap">


Veri türü için yer tutucu, yöntem adından hemen sonraya yerleştirilir. Köşeli parantezlerin içine yerleştirilen tanımlayıcı, artık genel bir veri türü gerektiğinde kullanılmaktadır. Parametrelerin her birine, takas yapmak için kullanılan geçici değişken gibi genel bir veri türü atanır. Bu kodu test eden bir program:


Jenerikler, fonksiyon tanımlarıyla sınırlı değildir; jenerik sınıflar da oluşturabilirsiniz. Jenerik bir sınıf tanımı, sınıf adından sonra jenerik bir tür yer tutucusu içerecektir. Tanımda sınıf adına her başvuru yapıldığında, tür yer tutucusu sağlanmalıdır. Aşağıdaki sınıf tanımı, jenerik bir sınıfın nasıl oluşturulacağını gösteriyor:


<img src="https://user-images.githubusercontent.com/107070882/198852120-8311687e-3b38-48f5-bf02-26d180f12e1f.png" alt="Node">


Bu sınıf aşağıfaki gibi kullanılabilir.


<img src="https://user-images.githubusercontent.com/107070882/198852211-97fd8b5b-b331-4820-a767-fc0d1ecf4b4a.png" alt="NodeType">


Jenerik programlamanın bu kullanımı oldukça yararlı olsa da, C# zaten kullanıma hazır jenerik veri yapılarından oluşan bir kitaplık sağlar. Bu veri yapıları System.Collection.Generics ad alanında bulunur ve bu ad alanının parçası olan bir veri yapısını diğer repositories'lerimde kullanımını inceleyeceğiz. Genel olarak, bu sınıflar, jenerik olmayan veri yapısı sınıflarıyla aynı işlevselliğe sahiptir, bu nedenle, diğer yöntemler ve kullanımları farklı olmadığından, jenerik sınıfla ilgili değerlendirmeleri genellikle o sınıfın bir nesnesinin nasıl başlatılacağıyla sınırlayacağız.
