namespace generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyAnswer<int> answer = new MyAnswer<int>();
            answer.Add(4);
            answer.Add(5);
            answer.Add(3);
            answer.Add(1);
            answer.Add(2);
            answer.Add(6);
            Console.WriteLine(string.Join(",",answer.GetOrderList()));
        }
    }

}