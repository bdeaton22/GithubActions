Brando Calrissian
brayjaycs
Online

Brando Calrissian — 2/18/2025 1:37 PM
Brando Calrissian — 2/20/2025 12:54 AM
Image
Brando Calrissian — 2/20/2025 5:13 PM
Brando Calrissian — 2/22/2025 12:17 AM
Image
Brando Calrissian — 2/23/2025 2:25 AM
En general, ¿cómo fue tu conversación? (al menos 50 palabras)

Mi conversación no fue mal, pero no pienso que haya sido bueno. Era difícil entender la persona a veces. La persona era simpático y me ayudó cuando yo necesitaba ayuda. Yo estaba nervioso durante mi conversación. Estoy menos nervioso para mi segundo conversación. Espero que mi segundo conversación es bien. 

¿Qué porcentaje de lo que dijo tu compañero de conversación entendiste? (al menos 50 palabras)

Creo que yo entendí ochenta o setenta y cinco porcentaje de lo que dijo mi compañero de conversación. Era difícil de entender a veces porque estaba nervioso y mi compañero habló rápido. No hablo español con un compañero tipícamente. Era difícil y estaba nervioso, pero creo que hice bien y entendí ochenta porcentaje.

¿Cuáles son tres cosas que dirías o expresarías de manera diferente después de haber escuchado tu conversación?

Cuando hago ejercicio porque dije invierno y no dije verano.
Cuando no entiendo porque dije "no escucho" y no dije "no entendí."
De donde soy porque no dije "estado de Nebraska" cuando mi compañero preguntó.

Enumera tres cosas interesantes que aprendiste sobre tu compañero de conversación según sus respuestas a tus preguntas.

Mi compañero es de Argentina.
Mi compañero le gusta escuchar música para aliviar el estrés.
Mi compañero es de Buenos Aires.

Enumera tres palabras nuevas que aprendiste de esta conversación. 

Estado

2. 

3. 

¿Qué tipo de inferencias o comparaciones culturales puedes hacer sobre tu interacción con tu compañero? Si no hay evidencia suficiente, ¿qué comparaciones puedes hacer entre tus puntos de vista sobre la vivienda? (al menos 50 palabras)




¿Hay algo más sobre el lenguaje que hayas notado? (al menos 50 palabras)




¿Qué puedes hacer para prepararte mejor para tu próxima conversación? (al menos 50 palabras)
Brando Calrissian — 2/24/2025 8:42 PM
Image
Brando Calrissian — 2/24/2025 10:17 PM
Image
Brando Calrissian — 2/25/2025 7:32 PM
Brando Calrissian — 2/28/2025 9:15 PM
Image
Brando Calrissian — 2/28/2025 9:23 PM
Image
Brando Calrissian — 2/28/2025 9:55 PM
Image
Brando Calrissian — 2/28/2025 10:07 PM
Image
Brando Calrissian — 3/3/2025 10:35 PM
Image
Brando Calrissian — 3/7/2025 2:01 PM
Brando Calrissian — 3/9/2025 5:08 PM
-6456721601671910559
Brando Calrissian — 3/10/2025 3:26 PM
Image
Brando Calrissian — 3/10/2025 6:19 PM
6:19
Brando Calrissian — 3/11/2025 7:49 PM
Brando Calrissian — 3/14/2025 1:11 AM
aiofluff dredjir notevilfox whisperfoot
Brando Calrissian — 3/14/2025 4:38 PM
Brando Calrissian — 3/16/2025 9:53 PM
SELECT

Order.OrderNumber,

Product.ProductName,

OrderItem.Quantity,

OrderItem.UnitPrice

FROM Order

JOIN OrderItem ON Order.Id = OrderItem.OrderId

JOIN Product ON OrderItem.ProdMCtld = Product.ProdMCtld;
SELECT PRODUCT.ProductName, ORDERITEM.Quantity, ORDERITEM.UnitPrice FROM ORDER
The three approaches are the SOLID principles, separation of concerns, and iDesign. The SOLID principles are guidelines for creating well designed code. Separation of concerns ensures that each part of the program has one responsibility, and it ensures that responsibilities don't overlap. IDesign is a type of architechture and design paradigm that anticipates change. All 3 ensure low coupling and high cohesion.
The goal is to have low coupling with high cohesion, so that modifying and scaling the code is easier and less risky. It also makes the code easier to maintain and understand.
Cohesion describes how well each class belongs with each other. It ensures that each class works together towards a single purpose. A project should have high cohesion. However, coupling describes how tightly each class is dependent on each other. A project should have low coupling, since modifying one class in a system with high coupling could break the functionality of the program.
One reason could be to store a lot of data that has little to no structure. This allows for more flexibiliy and scalability. A regular SQL database requires very strictly structured data. The second reason could be rapid development. Nosql allows for more rapid development since there is no need for strict data structures or complex schemas.
One complication is the resources and budget. Projects can become strained because of poor budgeting or a lack of resources. It can lead to projects being unfinished or the end product being incomplete and low quality. Another complication is time. A project might be very difficult to finish within a deadline, and in turn the final product will be incomplete or low quality. A third complication is what the requirements or specifications are for a project. Poorly defined requirements can cause incomplete and poorly implemented features, and some can be missed entirely. Any of these three things can cause a project to fail.
Brando Calrissian — 3/20/2025 7:45 PM
lukiro
Brando Calrissian — 3/20/2025 8:06 PM
therita3k youjomodoki pantimimi joooji 
554KetyzeChipped
Brando Calrissian — 3/20/2025 8:13 PM
akanin
Brando Calrissian — 3/20/2025 8:24 PM
dainendog
Brando Calrissian — 3/23/2025 1:43 AM
Image
Brando Calrissian — 3/26/2025 7:01 PM
Image
Image
Image
Image
Image
Image
Image
Image
Brando Calrissian — 3/26/2025 7:09 PM
Image
Image
Image
Image
Image
Image
Image
Image
Image
Brando Calrissian — 4:22 PM
namespace GithubActionsLab;

[TestClass]
public class Addition
{
[TestMethod]
public void Add_Valid_Deaton()
{
Assert.AreEqual(3, Program.Add("1", "2"));
Assert.AreEqual(5, Program.Add("3", "2"));
Assert.AreEqual(12, Program.Add("5", "7"));
}

[TestMethod]
public void Add_Invalid_Deaton()
{
Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
}

[TestMethod]
public void Add_Null_Deaton()
{
Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
}

    [TestMethod]
    public void Subtract_Valid_Deaton()
    {
        Assert.AreEqual(-1, Program.Subtract("1", "2"));
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(-2, Program.Subtract("5", "7"));
    }

    [TestMethod]
    public void Subtract_Invalid_Deaton()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }
    [TestMethod]
    public void Subtract_Null_Deaton()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }
    [TestMethod]
    public void Multiply_Valid_Deaton()
    {
        Assert.AreEqual(2, Program.Multiply("1", "2"));
        Assert.AreEqual(6, Program.Multiply("3", "2"));
        Assert.AreEqual(35, Program.Multiply("5", "7"));
    }

    [TestMethod]
    public void Multiply_Invalid_Deaton()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
    }
    [TestMethod]
    public void Multiply_Null_Deaton()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }

    [TestMethod]
    public void Divide_Valid_Deaton()
    {
        Assert.AreEqual(0.5, Program.Divide("1", "2"));
        Assert.AreEqual(1.5, Program.Divide("3", "2"));
        Assert.AreEqual(5, Program.Divide("25", "5"));
    }

    [TestMethod]
    public void Divide_Invalid_Deaton()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
    }
    [TestMethod]
    public void Divide_Null_Deaton()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }
    [TestMethod]
    public void Power_Valid_Deaton()
    {
        Assert.AreEqual(2, Program.Power("1", "2"));
... (19 lines left)
Collapse
message.txt
5 KB
return Math.Pow(double.Parse(x), double.Parse(y));
﻿
namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Deaton()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Deaton()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Deaton()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}

    [TestMethod]
    public void Subtract_Valid_Deaton()
    {
        Assert.AreEqual(-1, Program.Subtract("1", "2"));
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(-2, Program.Subtract("5", "7"));
    }

    [TestMethod]
    public void Subtract_Invalid_Deaton()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }
    [TestMethod]
    public void Subtract_Null_Deaton()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }
    [TestMethod]
    public void Multiply_Valid_Deaton()
    {
        Assert.AreEqual(2, Program.Multiply("1", "2"));
        Assert.AreEqual(6, Program.Multiply("3", "2"));
        Assert.AreEqual(35, Program.Multiply("5", "7"));
    }

    [TestMethod]
    public void Multiply_Invalid_Deaton()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
    }
    [TestMethod]
    public void Multiply_Null_Deaton()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }

    [TestMethod]
    public void Divide_Valid_Deaton()
    {
        Assert.AreEqual(0.5, Program.Divide("1", "2"));
        Assert.AreEqual(1.5, Program.Divide("3", "2"));
        Assert.AreEqual(5, Program.Divide("25", "5"));
    }

    [TestMethod]
    public void Divide_Invalid_Deaton()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
    }
    [TestMethod]
    public void Divide_Null_Deaton()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }
    [TestMethod]
    public void Power_Valid_Deaton()
    {
        Assert.AreEqual(2, Program.Power("1", "2"));
        Assert.AreEqual(9, Program.Power("3", "2"));
        Assert.AreEqual(78125, Program.Power("5", "7"));
    }

    [TestMethod]
    public void Power_Invalid_Deaton()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
    }
    [TestMethod]
    public void Power_Null_Deaton()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}
