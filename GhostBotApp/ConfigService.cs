using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;

namespace GhostBotApp
{
    public static class ConfigService
    {
        public static UserConfigOptionsModel LoadConfigData()
        {
            var response = new UserConfigOptionsModel();

            var configFilename = ConfigurationManager.AppSettings["UserConfigFileName"];
            var currentDir = Directory.GetCurrentDirectory();

            var di = new DirectoryInfo(currentDir).GetFiles().Where(x => x.Name == configFilename).ToList();

            if (!di.Any())
            {
                response = GetDefaultUserOptions(currentDir);

                using (var fileStream = new FileStream(String.Format("{0}\\{1}", currentDir, configFilename), FileMode.Create))
                using (var fileWriter = new StreamWriter(fileStream))
                {
                    fileWriter.Write(response.ToXML());
                }
            }
            else
            {
                using (var fileStream = new FileStream(String.Format("{0}\\{1}", currentDir, configFilename), FileMode.Open))
                using (var fileReader = new StreamReader(fileStream))
                {
                    var xmlData = fileReader.ReadToEnd();

                    response = UserConfigOptionsModel.LoadFromXMLString(xmlData);
                    response.CurrentWorkingDirectory = currentDir;
                }
            }

            return response;
        }

        public static void SaveUserConfigOptions(UserConfigOptionsModel userConfigOptions)
        {
            var configFilename = ConfigurationManager.AppSettings["UserConfigFileName"];

            using (var fileStream = new FileStream(String.Format("{0}\\{1}", userConfigOptions.CurrentWorkingDirectory, configFilename), FileMode.Create))
            using (var fileWriter = new StreamWriter(fileStream))
            {
                fileWriter.Write(userConfigOptions.ToXML());
            }
        }

        public static void CheckResourceDirectoryExists(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        public static void WriteToSlackApiLog(UserConfigOptionsModel userConfigOptions, HttpResponseMessage errorResponse, Exception ex)
        {
            var logFile = ConfigurationManager.AppSettings["GhostBotLogFileName"];

            var di = new DirectoryInfo(userConfigOptions.CurrentWorkingDirectory).GetFiles().Where(x => x.Name == logFile).ToList();

            if (di.Any())
            {
                WriteToLog(userConfigOptions, errorResponse, ex, FileMode.Append, logFile);
            }
            else
            {
                WriteToLog(userConfigOptions, errorResponse, ex, FileMode.Create, logFile);
            }
        }

        private static void WriteToLog(UserConfigOptionsModel userConfigOptions, HttpResponseMessage errorResponse, Exception ex, FileMode fm, string logFile)
        {
            using (var fileStream = new FileStream(String.Format("{0}\\{1}", userConfigOptions.CurrentWorkingDirectory, logFile), fm))
            using (var fileWriter = new StreamWriter(fileStream))
            {
                if (errorResponse != null)
                {
                    fileWriter.WriteLine(String.Format("{0}: HTTP Error {1} {2}. Request Message: {3}. Response Content: {4} Exception: {5}", DateTime.Now.ToString(), (int)errorResponse.StatusCode, errorResponse.StatusCode, errorResponse.RequestMessage, errorResponse.Content.ReadAsStringAsync().Result, WriteAllExceptionMessages(ex)));
                }
                else
                {
                    fileWriter.WriteLine(String.Format("{0}: {1}", DateTime.Now.ToString(), WriteAllExceptionMessages(ex)));
                }
            }
        }

        private static UserConfigOptionsModel GetDefaultUserOptions(string currentWorkingDirectory)
        {
            var response = new UserConfigOptionsModel();

            response.CurrentWorkingDirectory = currentWorkingDirectory;

            response.ResourceLocation = String.Format("{0}\\{1}", currentWorkingDirectory, ConfigurationManager.AppSettings["DefaultBaseResourceLocation"]);
            response.SingleScreenLocation = ConfigurationManager.AppSettings["DefaultSingleScreenResources"];
            response.MultiScreenLocation = ConfigurationManager.AppSettings["DefaultMultiScreenResources"];
            response.MenuLocation = ConfigurationManager.AppSettings["DefaultStartMenuLocation"];

            response.SlackBaseUrl = ConfigurationManager.AppSettings["DefaultSlackBaseUrl"];
            response.SlackChannel = ConfigurationManager.AppSettings["DefaultTargetSlackChannel"];
            response.GhostBotMessage = ConfigurationManager.AppSettings["DefaultGhostBotBaseMessage"];

            response.PauseTimeBetweenScansSec = int.Parse(ConfigurationManager.AppSettings["DefaultPauseTimeInSec"]);
            response.IdleThresholdSec = int.Parse(ConfigurationManager.AppSettings["DefaultIdleThresholdInSec"]);

            response.TestingFlag = ConfigurationManager.AppSettings["DefaultTestingFlag"];

            return response;
        }

        private static string WriteAllExceptionMessages(Exception ex)
        {
            StringBuilder msgBuilder = new StringBuilder();

            msgBuilder.Append(String.Format("Exception Message : {0}  ", ex.Message));

            if (ex.InnerException != null)
            {
                msgBuilder.Append(WriteAllExceptionMessages(ex.InnerException));
            }

            return msgBuilder.ToString();
        }
    }
}
