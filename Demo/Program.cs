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


        }
    }
}
