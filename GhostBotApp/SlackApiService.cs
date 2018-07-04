using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Configuration;

namespace GhostBotApp
{
    public class SlackApiService
    {
        public static UserConfigOptionsModel UserConfigOptions { get; set; }

        public SlackApiService(UserConfigOptionsModel userConfigOptions)
        {
            UserConfigOptions = userConfigOptions;
        }

        public void SendMessage(string nameOfSkypeMessageSender)
        {
            var message = UserConfigOptions.GhostBotMessage;

            if (!String.IsNullOrEmpty(nameOfSkypeMessageSender))
            {
                // will eventually add the name of the person who sent the message
                message = String.Format("{0} from {1}", message, nameOfSkypeMessageSender);
            }

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(UserConfigOptions.SlackBaseUrl);

            var data = new { text = message };

            for (var messageTryCount = 0; messageTryCount < 5; messageTryCount++)
            {
                HttpResponseMessage response = null;

                try
                {
                    response = client.PostAsJsonAsync(UserConfigOptions.SlackChannel, data).Result;

                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    ConfigService.WriteToSlackApiLog(UserConfigOptions, response, ex);
                    Thread.Sleep(3000);
                    continue;
                }
            }
        }
    }
}
