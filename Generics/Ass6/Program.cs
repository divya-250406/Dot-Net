using System;
using System.Collections.Generic;
using System.Linq;

namespace TokenManagementSystem
{
    class ServiceToken
    {
        public int TokenID { get; set; }
        public int Position { get; set; }
        public DateTime TicketDateTime { get; set; }
        public string Status { get; set; }
        public ServiceToken(int id,int position)
        {
            TokenID=id;
            Position=position;
            TicketDateTime=DateTime.Now;
            Status="Waiting";
        }
    }
    class TicketManager
    {
        public Queue<ServiceToken> Queue { get; set; }
        private List<ServiceToken> AllTokens;
        private int tokenCounter;
        public TicketManager()
        {
            Queue=new Queue<ServiceToken>();
            AllTokens=new List<ServiceToken>();
            tokenCounter=1;
        }
        public void GenerateServiceToken()
        {
            ServiceToken token=new ServiceToken(tokenCounter,Queue.Count+1);
            Queue.Enqueue(token);
            AllTokens.Add(token);
            Console.WriteLine("Token Generated Successfully.");
            Console.WriteLine("Token ID : "+token.TokenID);
            tokenCounter++;
        }
        public void GetNextToken()
        {
            if(Queue.Count==0)
            {
                Console.WriteLine("No Tokens Available.");
                return;
            }
            ServiceToken token=Queue.Peek();
            Console.WriteLine("Next Token");
            Console.WriteLine("Token ID :"+token.TokenID);
            Console.WriteLine("Position :"+token.Position);
            Console.WriteLine("Status :"+token.Status);
        }
        public void UpdateToken(int tokenID)
        {
            ServiceToken token=AllTokens.Find(t=>t.TokenID==tokenID);
            if(token!=null)
            {
                token.Status="Completed";
                if(Queue.Count>0 && Queue.Peek().TokenID==tokenID)
                {
                    Queue.Dequeue();
                    int pos=1;
                    foreach(ServiceToken t in Queue)
                    {
                        t.Position=pos++;
                    }
                }
                Console.WriteLine("Token Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Token Not Found.");
            }
        }
        public void SkipToken()
        {
            if(Queue.Count<=1)
            {
                Console.WriteLine("Cannot Skip Token.");
                return;
            }
            ServiceToken skipped=Queue.Dequeue();
            Queue.Enqueue(skipped);
            int pos=1;
            foreach (ServiceToken token in Queue)
            {
                token.Position=pos++;
            }
            Console.WriteLine("Token Skipped Successfully.");
        }
        public void ListTokens()
        {
            if(AllTokens.Count==0)
            {
                Console.WriteLine("No Tokens Available.");
                return;
            }
            Console.WriteLine("\nToken Details");
            foreach(ServiceToken token in AllTokens)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Token ID :"+token.TokenID);
                Console.WriteLine("Position :"+token.Position);
                Console.WriteLine("Date :"+token.TicketDateTime);
                Console.WriteLine("Status :"+token.Status);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TicketManager manager=new TicketManager();
            while(true)
            {
                Console.WriteLine("\n******** TOKEN MANAGEMENT SYSTEM ********");
                Console.WriteLine("1.Create Token");
                Console.WriteLine("2.Get Next Token");
                Console.WriteLine("3.Update Token");
                Console.WriteLine("4.Skip Token");
                Console.WriteLine("5.List all Tokens");
                Console.WriteLine("6.Exit");
                Console.Write("Enter your Choice: ");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        manager.GenerateServiceToken();
                        break;
                    case 2:
                        manager.GetNextToken();
                        break;
                    case 3:
                        Console.Write("Enter Token ID: ");
                        int id=Convert.ToInt32(Console.ReadLine());
                        manager.UpdateToken(id);
                        break;
                    case 4:
                        manager.SkipToken();
                        break;
                    case 5:
                        manager.ListTokens();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }
    }
}