using System;

class Student
{
    public int rollNo;
    public string name;
    public int age;
}

class StudentManager : Student
{
    public void addStudent()
    {
        Console.WriteLine("Enter Roll No:");
        rollNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Name:");
        name = Console.ReadLine();

        Console.WriteLine("Enter Age:");
        age = Convert.ToInt32(Console.ReadLine());
    }

    public void displayStudent()
    {
        if (name == null)
        {
            Console.WriteLine("No student record found.");
            return;
        }

        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    public void updateStudent()
    {
        if (name == null)
        {
            Console.WriteLine("No student record found for update.");
            return;
        }
        Console.WriteLine("Enter New Roll No:");
        rollNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter New Name:");
        name = Console.ReadLine();

        Console.WriteLine("Enter New Age:");
        age = Convert.ToInt32(Console.ReadLine());
    }

    public void deleteStudent()
    {
        rollNo = 0;
        name = null;
        age = 0;

        Console.WriteLine("Student deleted successfully.");
    }
}

class Program
{
    static void Main(String[] args)
    {
        StudentManager student1 = new StudentManager();
        int choice;

        do
        {
            Console.WriteLine("\n===== Student Menu =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Student");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");

            Console.WriteLine("Enter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    student1.addStudent();
                    break;

                case 2:
                    student1.displayStudent();
                    break;

                case 3:
                    student1.updateStudent();
                    break;

                case 4:
                    student1.deleteStudent();
                    break;

                case 5:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 5);
    }
}