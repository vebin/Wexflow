﻿using System;
using System.Configuration;
using Wexflow.Core.MongoDB;
using Wexflow.Scripts.Core;

namespace Wexflow.Scripts.MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Db db = new Db(ConfigurationManager.AppSettings["connectionString"]);
                Helper.InsertWorkflowsAndUser(db);
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occured: {0}", e);
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
