using System;


namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cars = new string[] { "100", "110", "010", "011", "100" };
            var similar = new int[cars.Length];
            
            for (int i = 0; i < cars.Length; i++)
            {
                var car = cars[i];
                Console.WriteLine("Car number: " + car);

                for (int k = 0; k < cars.Length; k++)
                {
                    var similars = 0;

                    if (k != i)
                    {
                        var carPossibleSimilar = cars[k];
                        if (car == carPossibleSimilar)
                        {
                            similars++;       
                        }
                        else
                        {
                            var carArray = car.ToCharArray();
                            var possibleSimilarArray = carPossibleSimilar.ToCharArray();
                            var numberOfDifferentComponents = 0;

                            for (int p = 0; p < carArray.Length; p++)
                            {
                                if (carArray[p] != possibleSimilarArray[p])
                                    numberOfDifferentComponents++;
                                else if (numberOfDifferentComponents > 1)
                                {
                                    similars = 0;
                                    break;
                                }
                                else if (numberOfDifferentComponents <= 1)
                                {
                                    similars++;
                                }
                            }
                            similar[i] += similars;
                        }
                    }
                }
            }


            //var text = "axxaxa";
            //var letters = text.ToCharArray();
            //var distinctLetters = letters.Distinct().ToList();
            //var toBeDeleted = 0;

            //distinctLetters.ForEach(letter =>
            //{
            //    var numberOfLetterInText = letters.Count(x => x == letter);

            //    while( (numberOfLetterInText % 2) > 0)
            //    {
            //        toBeDeleted++;
            //        numberOfLetterInText -= 1;
            //    }
            //});


            //var n = 14;
            //var digitSum = ConvertStringToDigitSum(n);

            //var result = FindDigitSumForInteger(digitSum);

        }

        private static int ConvertStringToDigitSum(int n)
        {
            var stringN = n.ToString().ToCharArray();
            var digitSum = 0;

            digitSum += GetSum(n);

            digitSum = digitSum * 2;
            return digitSum;
        }

        public static int GetSum(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        public static int FindDigitSumForInteger(int N)
        {
            int i = 1;
            while (1 != 0)
            {
                if (GetSum(i) == N)
                {
                    return i;
                }
                i++;
            }
        }
    }
}
