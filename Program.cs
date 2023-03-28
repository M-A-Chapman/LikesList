namespace LikesList;
class Program
{
    static void Main(string[] args)
    {
        var names = new List<string>();

        while (true)
        {
            Console.Write("enter a name or hit ENTER to quit: ");
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
                break;
            names.Add(name);
        }

        switch (names.Count)
        {
            case > 2:
                Console.WriteLine("{0}, {1}, and {2} others like your post", names[0], names[1], names.Count - 2);
                break;
            case 2:
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                break;
            case 1:
                Console.WriteLine("{0} likes your post", names[0]);
                break;
            case 0:
            default:
                Console.WriteLine();
                break;
        }

    }
}
