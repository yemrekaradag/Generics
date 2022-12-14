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
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198852120-8311687e-3b38-48f5-bf02-26d180f12e1f.png" alt="Node">
<hr>
This class can be used as follows.
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198853125-3e9017a7-8ff6-465d-8354-00c76a58171b.png" alt="NodeType">
<hr>
While this use of generic programming is quite useful, C# already provides a library of ready-to-use generic data structures. These data structures are located in the System.Collection.Generics namespace, and we will examine the use of a data structure that is part of this namespace in my other repositories. In general, these classes have the same functionality as non-generic data structure classes, so we will generally limit considerations of the generic class to how to instantiate an object of that class, as other methods and their usage are not different.
<hr>
<h1>Jenerikler (Generics)</h1>
Farkl?? veri t??rleri ile kullanabilmek i??in bir??ok kez overload etmek zorunda kalmadan, fonksiyonlar?? ba????ms??z olarak veya bir s??n??f i??inde yazma tekni??i. System.Collections.Generic jeneriklerin bir??o??unu System.Collections veri yap??lar?? i??in uygular.
<hr>
<h1>Jenerik Programlama</h1>
OOP ile ilgili sorunlardan biri ???kod ??i??kinli??i??? ad?? verilen bir durumdur. Bir t??r kod ??i??mesi, y??ntemin parametrelerinin olas?? t??m veri t??rlerini hesaba katmak i??in bir y??ntemi veya bir dizi y??ntemi override etmeniz gerekti??inde ortaya ????kar. Kod ??i??kinli??i i??in bir ????z??m, bir de??erin birden ??ok veri t??r??n?? ??stlenebilmesi ve bu de??erin yaln??zca bir tan??m??n??n sa??lamas??d??r. Bu tekni??e jenerik (genel) programlama denir. Jenerik bir program, derleme zaman??nda belirli bir veri t??r?? taraf??ndan doldurulan bir "yer tutucu" sa??lar. Bu yer tutucu, k????eli ayra??lar (< >) aras??na yerle??tirilmi?? bir tan??mlay??c?? ile temsil edilir. Bir ??rne??e bakal??m.
<hr>
Jenerik programlama i??in standart bir ilk ??rnek, de??i??tirme y??ntemidir. C#???ta jenerik bir de??i??tirme y??nteminin tan??m?? ??u ??ekilde olabilir:
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198851967-18743710-5894-4c2f-a863-4fcc35d017d1.png" alt="Swap">
<hr>
Veri t??r?? i??in yer tutucu, y??ntem ad??ndan hemen sonraya yerle??tirilir. K????eli parantezlerin i??ine yerle??tirilen tan??mlay??c??, art??k genel bir veri t??r?? gerekti??inde kullan??lmaktad??r. Parametrelerin her birine, takas yapmak i??in kullan??lan ge??ici de??i??ken gibi genel bir veri t??r?? atan??r. Bu kodu test eden bir program:
<hr>
Jenerikler, fonksiyon tan??mlar??yla s??n??rl?? de??ildir; jenerik s??n??flar da olu??turabilirsiniz. Jenerik bir s??n??f tan??m??, s??n??f ad??ndan sonra jenerik bir t??r yer tutucusu i??erecektir. Tan??mda s??n??f ad??na her ba??vuru yap??ld??????nda, t??r yer tutucusu sa??lanmal??d??r. A??a????daki s??n??f tan??m??, jenerik bir s??n??f??n nas??l olu??turulaca????n?? g??steriyor:
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198852120-8311687e-3b38-48f5-bf02-26d180f12e1f.png" alt="Node">
<hr>
Bu s??n??f a??a????faki gibi kullan??labilir.
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198853125-3e9017a7-8ff6-465d-8354-00c76a58171b.png" alt="NodeType">
<hr>
Jenerik programlaman??n bu kullan??m?? olduk??a yararl?? olsa da, C# zaten kullan??ma haz??r jenerik veri yap??lar??ndan olu??an bir kitapl??k sa??lar. Bu veri yap??lar?? System.Collection.Generics ad alan??nda bulunur ve bu ad alan??n??n par??as?? olan bir veri yap??s??n?? di??er repositories'lerimde kullan??m??n?? inceleyece??iz. Genel olarak, bu s??n??flar, jenerik olmayan veri yap??s?? s??n??flar??yla ayn?? i??levselli??e sahiptir, bu nedenle, di??er y??ntemler ve kullan??mlar?? farkl?? olmad??????ndan, jenerik s??n??fla ilgili de??erlendirmeleri genellikle o s??n??f??n bir nesnesinin nas??l ba??lat??laca????yla s??n??rlayaca????z.
