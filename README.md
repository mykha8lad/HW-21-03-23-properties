# Дз от 21/03/23. Properties
## Для типов Student и Group все сеттеры и геттеры поменять на свойства
## Свойства класса Student
```cs
public int Id
{
    set
    {
        this.id = value;
    }
    get
    {
        return this.id;
    }
}
public string Name
{
    set
    {
        if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) throw new StringException();
        this.name = value;
    }
    get
    {
        return this.name;
    }
}
public string Lastname
{
    set
    {
        if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) throw new StringException();
        this.lastname = value;
    }
    get
    {
        return this.lastname;
    }
}
public string Surname
{
    set
    {
        if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) throw new StringException();
        this.surname = value;
    }
    get
    {
        return this.surname;
    }
}
public string PhoneNumber
{
    set
    {
        string phoneRegexp = @"^\(\d{3}\)\d{3}\-\d{4}$";
        if (Regex.IsMatch(value, phoneRegexp)) this.phoneNumber = value;
        else this.phoneNumber = "(000)000-0000";
    }
    get
    {
        return this.phoneNumber;
    }
}
public DateTime Birthday
{
    set
    {
        this.birthday = value;
    }
    get
    {
        return this.birthday;
    }
}
public Address Address
{
    set
    {
        this.address = value;
    }
    get
    {
        return this.address;
    }
}

public List<int> Offsets
{
    set
    {
        if (value == null)                
            throw new ArgumentException();
        this.offsets = value;
    }
    get
    {
        return this.offsets;
    }
}
public List<int> Hometasks
{
    set
    {
        if (value == null)                
            throw new ArgumentException();
        this.hometasks = value;
    }
    get
    {
        return this.hometasks;
    }
}
public List<int> Exams
{
    set
    {
        if (value == null)                
            throw new ArgumentException();
        this.exams = value;
    }
    get
    {
        return this.exams;
    }
}
```
# [Весь код класса Student](https://github.com/mykha8lad/HW-21-03-23-properties/blob/main/Student.cs)
## Свойства класса Group
```cs
public List<Student> Students
{
    set
    {
        if (value == null)                
            throw new ArgumentException();
        students = value;
    }
    get
    {
        return this.students;
    }
}

public int StudentsInGroup
{
    set
    {
        if (value < 5 || value > 15) throw new CountStudentsException();

        if (value > this.StudentsInGroup)
        {
            for (int student = value; student != StudentsInGroup; --student)
            {
                string phoneRegexp = @"^\(\d{3}\)\d{3}\-\d{4}$";
                string phoneNumber;
                do
                {
                    phoneNumber = Faker.Phone.Number();
                } while (!Regex.IsMatch(phoneNumber, phoneRegexp));
                Random random = new Random();
                DateTime birthday = new DateTime(random.Next(2003, 2007), random.Next(1, 13), random.Next(1, 29));
                Students.Add(new Student(Faker.Name.First(), Faker.Name.Last(), Faker.Name.Middle(), birthday, phoneNumber, Faker.Address.City(), Faker.Address.StreetName(), Faker.Address.ZipCode()));
            }
        }
        else if (value < this.StudentsInGroup)
        {
            for (int student = StudentsInGroup; student != value; --student)
            {
                Students.RemoveAt(student - 1);
            }
        }

        this.studentsInGroup = value;
    }
    get
    {
        return this.studentsInGroup;
    }
}
public string GroupName
{
    set
    {
        if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) throw new StringException();
        this.groupName = value;
    }
    get
    {
        return this.groupName;
    }
}
public string GroupSpecialization
{
    set
    {
        if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) throw new StringException();
        this.groupSpecialization = value;
    }
    get
    {
        return this.groupSpecialization;
    }
}
public int CourseNumber
{
    set
    {
        if (value < 1 || value > 5) throw new CourseNumberException();
        this.courseNumber = value;
    }
    get
    {
        return this.courseNumber;
    }
}        
```
# [Весь код класса Group](https://github.com/mykha8lad/HW-21-03-23-properties/blob/main/Group.cs)
