using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;
using ApiAiSDK;
using ApiAiSDK.Model;

namespace ApiAiTestLab
{
    public class ApiAiBot
    {
        readonly NameValueCollection appSettings;
        readonly AIConfiguration apiAiConfiguration;
        readonly ApiAi apiAi;
        public ApiAiBot()
        {
            appSettings = ConfigurationManager.AppSettings;
            apiAiConfiguration = new AIConfiguration(appSettings["ClientToken"], SupportedLanguage.English);
            apiAi = new ApiAi(apiAiConfiguration);
        }
        public string GetResponse(string userPhrase)
        {
            var response = apiAi.TextRequest(userPhrase);
            return response.Result.Fulfillment.Speech;
        }
    }
}
