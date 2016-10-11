using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.POS.Service.ServiceImplementation
{
    [System.Web.Services.WebService(Namespace = "http://ACME.POS.Service.ServiceContracts/2007/06", Name = "GetStates")]
    [System.Web.Services.WebServiceBindingAttribute(ConformsTo = System.Web.Services.WsiProfiles.BasicProfile1_1, EmitConformanceClaims = true)]
    public class GetStates : ACME.POS.Service.ServiceContracts.IGetStates
    {
        #region IGetStates Members

        public ACME.POS.Service.DataTypes.State[] GetStateList()
        {
            ACME.POS.Service.DataTypes.State[] states 
                = new ACME.POS.Service.DataTypes.State[56];

            #region Set State Values...
            states[0] = CreateState("AK", "Alaska");
            states[1] = CreateState("AL", "Alabama");
            states[2] = CreateState("AR", "Arkansas");
            states[3] = CreateState("AZ", "Arizona");
            states[4] = CreateState("CA", "California");
            states[5] = CreateState("CO", "Colorado");
            states[6] = CreateState("CT", "Connecticut");
            states[7] = CreateState("DE", "Delaware");
            states[8] = CreateState("FL", "Florida");
            states[9] = CreateState("GA", "Georgia");
            states[10] = CreateState("HI", "Hawaii");
            states[11] = CreateState("IA", "Iowa");
            states[12] = CreateState("ID", "Idaho");
            states[13] = CreateState("IL", "Illinois");
            states[14] = CreateState("IN", "Indiana");
            states[15] = CreateState("KS", "Kansas");
            states[16] = CreateState("KY", "Kentucky");
            states[17] = CreateState("LA", "Louisiana");
            states[18] = CreateState("MA", "Massachusetts");
            states[19] = CreateState("MD", "Maryland");
            states[20] = CreateState("ME", "Maine");
            states[21] = CreateState("MI", "Michigan");
            states[22] = CreateState("MN", "Minnesota");
            states[23] = CreateState("MO", "Missouri");
            states[24] = CreateState("MS", "Mississippi");
            states[25] = CreateState("MT", "Montana");
            states[26] = CreateState("NC", "North Carolina");
            states[27] = CreateState("ND", "North Dakota");
            states[28] = CreateState("NE", "Nebraska");
            states[29] = CreateState("NV", "Nevada");
            states[30] = CreateState("NH", "New Hampshire");
            states[31] = CreateState("NJ", "New Jersey");
            states[32] = CreateState("NM", "New Mexico");
            states[33] = CreateState("NY", "New York");
            states[34] = CreateState("OH", "Ohio");
            states[35] = CreateState("OK", "Oklahoma");
            states[36] = CreateState("OR", "Oregon");
            states[37] = CreateState("PA", "Pennsylvania");
            states[38] = CreateState("RI", "Rhode Island");
            states[39] = CreateState("SC", "South Carolina");
            states[40] = CreateState("SD", "South Dakota");
            states[41] = CreateState("TN", "Tennessee");
            states[42] = CreateState("TX", "Texas");
            states[43] = CreateState("UT", "Utah");
            states[44] = CreateState("VA", "Virginia");
            states[45] = CreateState("VT", "Vermont");
            states[46] = CreateState("WA", "Washington");
            states[47] = CreateState("WI", "Wisconsin");
            states[48] = CreateState("WV", "West Virginia");
            states[49] = CreateState("WY", "Wymoing");
            states[50] = CreateState("DC", "District Of Columbia");
            states[51] = CreateState("AS", "American Samoa");
            states[52] = CreateState("GU", "Guam");
            states[53] = CreateState("MP", "Northern Mariana Islands");
            states[54] = CreateState("PR", "Puerto Rico");
            states[55] = CreateState("VI", "U.S. Virgin Islands");
            #endregion

            return states;
        }

        #endregion

        private ACME.POS.Service.DataTypes.State CreateState(string abbrv, string name)
        {
            ACME.POS.Service.DataTypes.State state = new ACME.POS.Service.DataTypes.State();
            state.Abbrv = abbrv;
            state.Name = name;
            return state;
        }
    }
}
