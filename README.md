<h1>C# 1 lab</h1>

 Вариант: 19
 
 Реализовать функцию возведения в куб суммы двух  целых чисел 


<p>Вопросы: 20,15,10,5,24</p>
<p>20.Какое пространство имен использует системная библиотека C#?
<pre>system</pre>
 </p>
<p>15.Приведите синтаксис оператора выбора в общем виде. Проиллюстрируйте его фрагментом программы на языке C#. 
<pre>using System;

public enum Color { Red, Green, Blue }

public class Example
{
   public static void Main()
   {
      Color c = (Color) (new Random()).Next(0, 3);
      if (c == Color.Red)
         Console.WriteLine("The color is red");
      else if (c == Color.Green)
         Console.WriteLine("The color is green");
      else if (c == Color.Blue)
         Console.WriteLine("The color is blue");   
      else
         Console.WriteLine("The color is unknown.");
   }
}
 </pre></p>
<p><pre>10) Перечислите пять простых типов языка C#.
int, float, decimal, bool, char</pre></p>

<p>5) Является ли среда CLR многоязычной?
<pre>Да</pre>
 </p>
<p>24. Приведите синтаксис описания пространства имен в общем виде. Проиллюстрируйте его фрагментом программы на языке C#. 
<pre>namespace имя { члены_пространства_имен}</pre></p>
