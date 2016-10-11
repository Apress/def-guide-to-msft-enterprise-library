using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Caching;
using Microsoft.Practices.EnterpriseLibrary.Caching.Expirations;



namespace ACME.POS.Service.Client
{
    [Serializable]
    public class StateCacheRefreshAction : ICacheItemRefreshAction
    {

        #region ICacheItemRefreshAction Members

        public void Refresh(string removedKey,
           object expiredValue, CacheItemRemovedReason removalReason)
        {
            ACMEStateWebService.GetStates webService = new ACMEStateWebService.GetStates();
            ACMEStateWebService.State[] states = webService.GetStateList();

            CacheManager staticData = CacheFactory.GetCacheManager("StaticData");
            staticData.Add("STATES", states, CacheItemPriority.NotRemovable,
               new StateCacheRefreshAction(),
               new AbsoluteTime(DateTime.Now.AddDays(1)));
        }

        #endregion
    }
}
