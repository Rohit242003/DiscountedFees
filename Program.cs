namespace Day_03_StudentFee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscountedFees();
        }

        public static double[] DiscountedFees()
        {
            int[] fees = new int[5];
            double[] discounted_fees = new double[fees.Length];

            int count = 0;
            int temp = 0;

            
            

            while (count < fees.Length)
            {
                Console.WriteLine("Enter the Fees");

                temp = Convert.ToInt32(Console.ReadLine());

                if (temp < 5000 || temp > 10000)
                {
                    Console.WriteLine("error: Enter the correct amount");
                    
                }
                else
                {
                    for (int i = 0; i < fees.Length; i++)
                    {

                        fees[count] = temp;
                        
                    }
                    count++;
                }
            }
            
            for(int i = 0 ;i < fees.Length;i++)
            {
                Console.WriteLine("Fees of Student "+i + ":"+fees[i]);
            }

            for (int i = 0; i < fees.Length; i++)
            {
                discounted_fees[i] = fees[i];
                if(fees[i] >= 7000)
                {
                    discounted_fees[i] = fees[i] - fees[i] * 0.1;

                }
            }

            for (int i = 0; i < fees.Length; i++)
            {
                Console.WriteLine("Discounted Fees of Student " + i + ":" + discounted_fees[i]);
            }

            return discounted_fees;
        }
    }
}
