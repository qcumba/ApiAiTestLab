using System;
using System.Configuration;
using ApiAiSDK;
using ApiAiSDK.Model;

namespace ApiAiTestLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var testBot = new ApiAiBot();
            var continueTalking = true;
            while (continueTalking)
            {
                Console.Write("You: ");
                var userRequest = Console.ReadLine();
                if (userRequest == "exit")
                {
                    continueTalking = false;
                    break;
                }
                var botResponse = testBot.GetResponse(userRequest);
                Console.WriteLine("Bot: {0}", botResponse);
            }
        }
    }
}
