using System;

namespace DNArepeat
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            while (true)
            {
                string DNAinput = Console.ReadLine();

                if (IsValidSequence(DNAinput) == true)
                {
                    Console.WriteLine("Current half DNA sequence : "+DNAinput);
                    if(checkYN("Do you want to replicate it ? (Y/N) : ") == true)
                    {
                       Console.WriteLine ("Replicated half DNA sequence : "+ ReplicateSeqeunce(DNAinput));
                    }
                   

                }
                else
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }
                
                if (checkYN("Do you want to process another sequence ? (Y/N) : ") == true)
                {
                   
                }
                else
                {
                   break;
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
        static bool checkYN(string text)
        {
            bool YN = true;
            bool checkLoop = true;
            while (checkLoop == true)
            {
                Console.WriteLine(text);
                string YesNoOk = Console.ReadLine();
                if (YesNoOk == "Y")
                {
                    checkLoop = false;
                    YN = true;
                }
                else if (YesNoOk == "N")
                {
                    checkLoop = false;
                    YN = false;
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                }
            }
            return YN;
        }

    }
}
