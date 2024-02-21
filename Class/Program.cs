//string name1 = "Emiraslan";
//string surname1 = "Miriyev";
//int age1 = 33;

//string name2 = "Sirac";
//string surname2 = "Memmedov";
//int age2 = 22;

//string name3 = "Elmir";
//string surname3 = "Qafarzade";
//int age3 = 21;

//Console.WriteLine($"{name2} {surname2} {age2}");

//var stu1 = new
//{
//    name = "Emiraslan",
//    surname = "Miriyev",
//    age = 33
//};

//var stu2 = new
//{
//    name = "Sirac",
//    surname = "Memmedov",
//    age = 22
//};

//Console.WriteLine( stu1.name);


using Class;
//Student stu1 = new();

Student stu1 = new Student();
stu1.name = "Ismayil";
stu1.surname = "Ceferli";
stu1.age = 24;
stu1.address = "Ehmedli";


Student stu2 = new Student();
stu2.name = "Test";
stu2.surname = "Testov";
stu2.age = 70;
stu2.address = "Xetai";
stu2.phone = "1234567890";


string fullName = stu2.name + " " + stu2.surname + " " + stu2.age;

//Console.WriteLine(fullName);

Student stu3 = new()
{
    name = "Sirac",
    surname = "Memmedov",
     age=22
};

//Console.WriteLine(stu3.phone);

//stu1.ShowText("salam");


//Console.WriteLine( stu3.GetFullData());


//Student[] students = {stu1,stu2, stu3};
//foreach (var item in students)
//{
//    // Console.WriteLine(item.name+" "+ item.surname);
//    Console.WriteLine(item.GetFullData());
//}

//Student[] students = {stu1,stu2, stu3}; 
//void ShowAll(Student[] students)
//{
//    foreach (var item in students)
//    {
//        Console.WriteLine(item.GetFullData());
//    }
//}



Student[] students = { stu1, stu2, stu3 };


//Student GetByAge(Student[] datas, int age)
//{
  //  Student founStudent = new();
    //foreach (var item in datas)
    //{
      //  if (item.age == age)
        //{
          //  founStudent= item;
        //}    
   // }
    //return founStudent;
//}
//var result = GetByAge(students, 24);
//Console.WriteLine(result.GetFullData());

//Student GetByAge(Student[] datas,  int age)
//{  
//    var result= datas.FirstOrDefault(m => m.age == age);
//    return result!=null ? result : new Student();
//}
//var result = GetByAge(students, 27);
//Console.WriteLine(result.GetFullData());

Book book = new Book("start");
Console.WriteLine(book.name);




































