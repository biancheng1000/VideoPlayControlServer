using CustomCode;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlayControlServer.Common
{
    /// <summary>
    /// 网络共享文件夹访问类
    /// </summary>
    public class FileShare
    {

        static string shareHostIP;
        static string userName;
        static string password;

        static FileShare()
        {
            shareHostIP = ReadConfig("PlayerHostIP");
            userName = ReadConfig("PlayerHostUser");
            password = ReadConfig("PlayerHostPwd");
        }
       
                                             
        /// <summary>
        /// 读取制定key的配置文件
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string ReadConfig(string key)
        {
            if (System.Configuration.ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                return System.Configuration.ConfigurationManager.AppSettings[key];
            }
            else
            {
                LogText.Error("ReadConfig", $"配置文件中缺少key:{key}");
            }
            return string.Empty;
        }

        public static bool connectState(string path)
        {
            return connectState(path, userName, password);
        }

        public static bool connectState(string path, string userName, string passWord)
        {
            bool Flag = false;

            Process proc = new Process();

            try
            {

                proc.StartInfo.FileName = "cmd.exe";

                proc.StartInfo.UseShellExecute = false;

                proc.StartInfo.RedirectStandardInput = true;

                proc.StartInfo.RedirectStandardOutput = true;

                proc.StartInfo.RedirectStandardError = true;

                proc.StartInfo.CreateNoWindow = true;

                proc.Start();

                string dosLine = @"net use " + path + " /User:" + userName + " " + passWord + " /PERSISTENT:YES";

                proc.StandardInput.WriteLine(dosLine);

                proc.StandardInput.WriteLine("exit");

                while (!proc.HasExited)
                {
                    proc.WaitForExit(1000);
                }

                string errormsg = proc.StandardError.ReadToEnd();

                proc.StandardError.Close();

                if (string.IsNullOrEmpty(errormsg))
                {
                    Flag = true;
                }
                else
                {
                    throw new Exception(errormsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }
            return Flag;
        }
    }
}
