using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Caching;
using ACME.POS.Service.Client;
using ACME.POS.Service.Client.ACMEStateWebService;


namespace ACME.POS.UI.Model
{
   public class ACMEModel
   {
        private CacheManager m_StaticDataCache;

        public ACMEModel()
        {
          m_StaticDataCache = CacheFactory.GetCacheManager("StaticData");
        }

        public State[] GetStates()
        {
            if (m_StaticDataCache == null)
                throw new ApplicationException("Static Data Cache is Null") ;

            State[] stateList = m_StaticDataCache["STATES"] as State[];

            if(stateList == null)
            {
             //Attempt to retrieve the data form the web service and reset the cache 
             //using the StateCacheRefreshAction class
             StateCacheRefreshAction refreshAction = new StateCacheRefreshAction();
             refreshAction.Refresh("STATES", null, CacheItemRemovedReason.Unknown);
             stateList = m_StaticDataCache["STATES"] as State[];
            }

            return stateList;
        }
   }
}
