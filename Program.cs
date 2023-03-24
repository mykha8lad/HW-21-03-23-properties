namespace HW_21_03_23_properties
{
    class Program
    {
        static void Main(string[] args)
        {

            Group group1 = new Group();
            Group group2 = new Group();
            group2.StudentsInGroup = 5;

            Console.WriteLine(group1);
            Console.WriteLine(group2);

        }
    }
}