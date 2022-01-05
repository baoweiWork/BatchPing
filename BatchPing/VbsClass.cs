/**************************************************
 * 版权所有: 鲍威
 * 文件描述: 
 * 备注说明: 
 * 创建时间: 2021/12/29 17:03:40          
***************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchPing
{
    public class VbsClass
    {
        public void RunVbs(string ip,string userName,string pwd,int time,string xplore)
        {
            //更新vbs脚本
            System.IO.StreamReader myReader = new System.IO.StreamReader("../../BatchPing.vbs");
            string strFile = myReader.ReadToEnd();
            myReader.Close();

            strFile = "Dim a"+"\r\n"+
                        "Set a=Wscript.CreateObject(\"Wscript.Shell\")"+"\r\n"+
                        "a.run \""+ xplore + " "+ ip + "\"" + "\r\n" +
                        "Wscript.Sleep "+ time + "" + "\r\n" +
                        "a.SendKeys \""+ userName + "\" '用户名" + "\r\n" +
                        "Wscript.Sleep 600" + "\r\n" +
                        //"a.SendKeys \"{ENTER}\"" + "\r\n" +
                        //"Wscript.Sleep 600" + "\r\n" +
                        "a.SendKeys \"{TAB}\"" + "\r\n" +
                        "a.SendKeys \""+ pwd + "\" '密码" + "\r\n" +
                        "Wscript.Sleep 600" + "\r\n" +
                        "a.SendKeys \"{ENTER}\"";
            //写
            System.IO.StreamWriter myWriter = new System.IO.StreamWriter("../../BatchPing.vbs", false);
            myWriter.Write(strFile);
            myWriter.Close();
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "wscript";
            proc.StartInfo.Arguments = "../../BatchPing.vbs";
            proc.StartInfo.UseShellExecute = false;
            proc.Start();
            proc.Close();
        }
    }
}
