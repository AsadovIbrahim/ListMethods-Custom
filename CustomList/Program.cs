using CustomList.Models;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            GenericList<int>genericList = new GenericList<int>();
            genericList.Add(1);
            genericList.Add(1);
            genericList.Add(1);
            genericList.Add(1);

            genericList.Find(p=>p==1);
            //genericList.RemoveAll(p => p == 1);

            foreach (int item in genericList._values)
            {
                Console.WriteLine(item);
            }
        }   
    }
}