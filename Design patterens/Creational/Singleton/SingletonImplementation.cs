﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Singleton
{
    /*
 Goal: ensure that a class only has one instance. 
       Provide a global point of access to the Class. 
 pattern type: Creational. 
 idea: make the class responsible for ensuring only one instance of itself exists. 

    when to use: 
    when there is needs to ony be one instance of a class. bust be accessible to a client from a well know access point
    sole instance should be extensible by subclassing, should extend instance without modding code
    
    Examples of when to use: 
    managing a database connection pool
    Caching frequently 
    managing application configuration settings 
    resource management 


    related: abstract, builder, Prototype, state

 */

    /*Singleton*/
    public class Logger
    {
        private static Logger? _instance;
        protected Logger()
        {

        }
        /*helps with thread safe
         https://learn.microsoft.com/en-us/dotnet/framework/performance/lazy-initialization
         */
        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

        /*Instance , is replaced by the lazy logger above */
        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;
                //if (_instance == null)
                //{
                //    _instance = new Logger();
                //}
                //return _instance;
            }

        }

        //with all the above, this will insure that there is only one instance. 

        //SingletonOperation
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }

    }
}
