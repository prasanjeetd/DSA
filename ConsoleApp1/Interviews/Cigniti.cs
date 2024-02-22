//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Interviews
//{
//    public class Cigniti
//    {
//    }
//}

////My name is yogesh power

////yM emane si


//string sentence = "My name is yogesh power";

//var words = sentence.Split(' ');

//var builder = new StringBuilder();

//foreach (var word in words)
//{
//    for (int i = word.Length; i >= 0; i--)
//    {
//        builder.Append(word[i]);
//    }

//    builder.AppendLine();
//}

//Console.WriteLine(builder.ToString());

//foreach (var word in words)
//{
//    foreach (var ch in word)
//    {
//        if (char.IsUpper(ch))
//        {

//        }
//    }
//}

////words.SelectMany(x => char.IsUpper(x));

///*
// * ID
// * Name
// * mangagerId 
// * 
// * 1 ABC null
// * 2 xyz 1
// * 
// */

//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int? MangagerId { get; set; }
//}



//var emp = new List<Employee>();

//from e in emp
//join e1 in emp
//into emp2
//from e1 in emp2.DefaultIfEmpty()
//select new
//{

//    Id = e.Id,
//    Name = e.Name,
//    Manager = e1 == null ? "No Manager" : e1.Name
//}
//;

