﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using NLog;
using NLog.LogReceiverService;
using NLog.Wcf;


namespace CIAService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CIAService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CIAService.svc or CIAService.svc.cs at the Solution Explorer and start debugging.
    public class CiaService : ICiaService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void ProcessLogMessages(NLogEvents nevents)
        {
            var events = nevents.ToEventInfo("db");
            Console.WriteLine("in: {0} {1}", nevents.Events.Length, events.Count);

            foreach (var ev in events)
            {
                var logger = LogManager.GetLogger(ev.LoggerName);
                logger.Log(ev);
            }
        }
        
    }
}
