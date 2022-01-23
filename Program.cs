var schools = new[] {
    new School(){ SchoolName = "firstClass", Students = new [] { new Student(){ Name="Bob"}, new Student(){ Name="Jack"} }},
    new School(){ SchoolName = "secondClass", Students = new [] { new Student(){ Name="Jim"}, new Student(){ Name="John"} }}
};

var allStudents = schools.SelectMany(p => p.Students,
                                  (parent, child) => new { parent.SchoolName, child.Name });

foreach (var student in allStudents)
{
    Console.WriteLine($"{student.SchoolName} : {student.Name}");
}

class School
{
    public string SchoolName { get; set; } = "@";
    public Student[] Students { get; set; }
}

class Student
{
    public string Name { get; set; } = "@";
}


