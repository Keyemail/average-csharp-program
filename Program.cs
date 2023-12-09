using System;
using System.Collections.Generic;

namespace Average;

class Program
{
    static void Main(string[] args)
    {
        int userInput;
        int averageNumber;
        List<int> userNumbers = [];

        Console.WriteLine("Please enter numbers, type -1 to stop.");
        
        while(true)
        {
            userInput = Convert.ToInt32(Console.ReadLine());

            if(userInput == -1) break;

            userNumbers.Add(userInput);
        }

        averageNumber = Average(userNumbers);

        Console.Write("The average number is: " + averageNumber);
    }

    static int Average(List<int> userNumberInput)
    {
        int sum = 0;
        int average;

        for(int i = 0; i < userNumberInput.Count; i++){
            sum += userNumberInput[i];
        }

        average = sum / userNumberInput.Count;

        return average;
    }
}
