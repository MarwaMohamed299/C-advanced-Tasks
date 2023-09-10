namespace WebApplication_Day1
{
    public class task1
    {

        public static void Main(string[] args)
        {

            int[] urarray = new int[12];

            Console.WriteLine("enter  ur array");
            for (int l = 0; l < urarray.Length; l++)
                urarray[l] = int.Parse(Console.ReadLine());

            int lDistance = 0;

            for (int l = 0; l < urarray.Length; l++)
            {
                for (int k = l + 1; k < urarray.Length; k++)
                {
                    if (urarray[l] == urarray[k])
                    {
                        int distance = k - (l + 1);

                        if (distance > lDistance)
                        {
                            lDistance = distance;
                        }
                    }

                };

            }
            Console.WriteLine($"The longest distance is {lDistance}.");

            ////////task2//////////////
            
            Console.WriteLine("Enter ur sentence ");
            string input = Console.ReadLine();
            string[] sentence = input.Split(' ');
            Array.Reverse(sentence);
            string output = string.Join(' ', sentence);
            Console.WriteLine(output);


            ///////task3/////


            int count = 0;
            for (int i = 1; i < 100000000; i++)
            {
                count += i.ToString().Split('1').Length - 1;
            }
            Console.WriteLine(count);

        }


    }
}
    
