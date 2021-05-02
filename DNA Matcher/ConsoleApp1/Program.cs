using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] nucleotide;
            string Process = "eh";
            //string nucleotideSet;
            while (Process != "whatever")
            {
                string halfDNASequence = Console.ReadLine();
                string replicateChoice;
                //nucleotide = halfDNASequence.ToCharArray();
                if (IsValidSequence(halfDNASequence) == true)
                {
                    Console.WriteLine("Current half DNA sequence : {0}", halfDNASequence);
                    Console.Write("Do you want to replicate it? (Y/N):");
                    replicateChoice = Console.ReadLine();
                    while (replicateChoice != "Y" && replicateChoice != "N")
                    {
                        Console.WriteLine("Please input Y or N.");
                        replicateChoice = Console.ReadLine();
                    }
                    if (replicateChoice == "Y")
                    {
                        Console.WriteLine();
                        Console.Write("Replicated half DNA sequence: ");
                        Console.Write(ReplicateSeqeunce(halfDNASequence));
                        Console.WriteLine();
                        Console.Write("Do you want to process another sequence?");
                        replicateChoice = Console.ReadLine();
                        while (replicateChoice != "Y" && replicateChoice != "N")
                        {
                            Console.WriteLine("Please input Y or N.");
                            replicateChoice = Console.ReadLine();
                        }
                        if (replicateChoice == "Y")
                        {
                            continue;
                        }
                        if (replicateChoice == "N")
                        {
                            break;
                        }
                    }
                    if (replicateChoice == "N")
                    {
                        Console.Write("Do you want to process another sequence?");
                        replicateChoice = Console.ReadLine();
                        while (replicateChoice != "Y" && replicateChoice != "N")
                        {
                            Console.WriteLine("Please input Y or N.");
                            replicateChoice = Console.ReadLine();
                        }
                        if (replicateChoice == "Y")
                        {
                            continue;
                        }
                        if (replicateChoice == "N")
                        {
                            break;
                        }
                    }
                }
                if (IsValidSequence(halfDNASequence) == false)
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                    Console.Write("Do you want to process another sequence?");
                    replicateChoice = Console.ReadLine();
                    while (replicateChoice != "Y" && replicateChoice != "N")
                    {
                        Console.WriteLine("Please input Y or N.");
                        replicateChoice = Console.ReadLine();
                    }
                    if (replicateChoice == "Y")
                    {
                        continue;
                    }
                    if (replicateChoice == "N")
                    {
                        break;
                    }
                }
            }
        }

        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }

        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

    }
}
