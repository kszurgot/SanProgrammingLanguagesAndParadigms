namespace Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var actorList = new List<Animal>
            { 
                new Dog(),
                new Bird(),
                new Fish() 
            };

            foreach (var animal in actorList)
            {
                animal.Move();
            }
        }
    }
}