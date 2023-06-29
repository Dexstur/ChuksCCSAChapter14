using From1;

Student student1 = new Student();
Student student2 = new Student("Mary");
Student student3 = new Student("James", "james@decagon.dev", "08912335246");
Console.WriteLine(student1.Name);
Console.WriteLine(Student.Count);
Student.GetInfo(student3);
