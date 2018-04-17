﻿using System.Threading;

namespace FLAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomationBase ab = new AutomationBase();
            ab.TestInitialize();
            AddApprovalGroups apg = new AddApprovalGroups();
            apg.InsertApprover();
            apg.AddWorkflow();
            apg.AddWorkflow2();
            Thread.Sleep(1000);
            ab.TestCleanup();   
            //Initiral Commit
        }
    }
}
