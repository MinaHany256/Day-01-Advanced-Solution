namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic SWAP - Example 01
            // In Case The GenericType "T" is Declared On Method Level Not (Class, Struct, Interface)
            // Compiler Can Detect The GenericType "T" based on the Method Input Parameter Types.

            /// int A = 3; int B = 5;
            /// Console.WriteLine($"A = {A}");
            /// Console.WriteLine($"B = {B}");
            /// Helper.SWAP/*<int>*/(ref A, ref B );
            /// Console.WriteLine($"A = {A}");
            /// Console.WriteLine($"B = {B}");

            /// double k = 3.3, L = 5.5;
            /// Console.WriteLine($"k = {k}");
            /// Console.WriteLine($"L = {L}");
            /// Helper.SWAP<double>(ref k, ref L);
            /// Console.WriteLine($"K = {k}");
            /// Console.WriteLine($"L = {L}");

            /// Point P1 = new Point(1,2);
            /// Point P2 = new Point(5,6);
            /// Console.WriteLine($"P1 = {P1}");
            /// Console.WriteLine($"P2 = {P2}");
            /// Helper.SWAP<Point>(ref P1, ref P2);
            /// Console.WriteLine($"P1 = {P1}");
            /// Console.WriteLine($"P2 = {P2}"); 
            #endregion

            #region Generic Search - Example 02
            //int[] numbers = [4, 10, 5, 3, 11, 8, 1, 7];

            //int index = Helper<int>.Search(numbers, 11);

            //Console.WriteLine($"Position = {index}"); 
            #endregion

            #region Equality
            //Employee employee01 = new Employee(id: 10, name: "Ahmed", salary: 6_000);
            //Employee employee02 = new Employee(id:10, name: "Ahmed", salary: 6_000);

            ////if(employee01 == employee02)
            //if (employee01.Equals(employee02))
            //    Console.WriteLine("Equals");
            //else
            //    Console.WriteLine("Not Euals"); 
            #endregion

            #region Bubble Sort
            //int[] numbers = [7, 2, 10, 9, 1, 8, 5, 3, 6, 4];
            //Helper<int>.Sort(numbers);
            //foreach (int i in numbers) 
            //    Console.WriteLine(i);

            //Employee[] employees =
            //{
            //    new Employee (10,name:"Ahmed",salary:6000),
            //    new Employee (20,name:"Omnia",salary:2000),
            //    new Employee (40,name:"Omars",salary:10000),
            //    new Employee (50,name:"Nadia",salary:4000),
            //};

            //Helper<Employee>.Sort(employees);
            //foreach (Employee employee in employees) 
            //    Console.WriteLine(employee); 
            #endregion

        }
    }
}
