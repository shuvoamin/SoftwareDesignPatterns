﻿namespace DesignPatterns.BusinessDelegatePattern
{
    public class BusinessDelegatePatternDemo
    {
        public BusinessDelegate BusinessDelegate
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public ClientBusiness Client
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    
        public static void Output()
        {
            var businessDelegate = new BusinessDelegate();
            businessDelegate.SetServiceType("EJB");

            var client = new ClientBusiness(businessDelegate);
            client.DoTask();

            businessDelegate.SetServiceType("JMS");
            client.DoTask();
        }
    }
}
