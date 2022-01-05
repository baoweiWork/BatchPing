using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BatchPing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int ipAddStart1 = Convert.ToInt32(ipStart1.Text);
                int ipAddStart2 = Convert.ToInt32(ipStart2.Text);
                int ipAddStart3 = Convert.ToInt32(ipStart3.Text);
                int ipAddStart4 = Convert.ToInt32(ipStart4.Text);
                int ipAddEnd1 = Convert.ToInt32(ipEnd1.Text);
                int ipAddEnd2 = Convert.ToInt32(ipEnd2.Text);
                int ipAddEnd3 = Convert.ToInt32(ipEnd3.Text);
                int ipAddEnd4 = Convert.ToInt32(ipEnd4.Text);
                if (ipAddStart1 != ipAddEnd1 || ipAddStart2 != ipAddEnd2 || ipAddStart3 != ipAddEnd3 )
                {
                    MessageBox.Show("起始IP网关不一致!");
                    return;
                }
                if (ipAddEnd4 < ipAddStart4)
                {
                    MessageBox.Show("结束IP不能小于开始IP!");
                    return;
                }
                if (ipAddStart4 < 0)
                {
                    MessageBox.Show("开始IP不能小于0!");
                    return;
                }
                this.dataGridView1.Rows.Clear();


                Task task = new Task(() =>
                {
                    //*****以下是异步执行的代码*****
                    //30个一组验证,有几组
                    //int zu = 10;
                    //int group = (ipAddEnd4 - ipAddStart4) / zu;
                    //for (int j = 0; j <= group+1; j++)
                    //{
                    //    int startIp = ipAddStart4 + j * zu;
                    //    int k = j;
                    //    MethodInvoker mi = new MethodInvoker(() =>
                    //    {
                    //        TestMethod(startIp, k, zu, ipAddEnd4);
                    //    });
                    //    this.BeginInvoke(mi);
                    //}
                    for (int k = ipAddStart4; k <= ipAddEnd4; k++)
                    {
                        Ping p1 = new Ping();
                        string ip = ipStart1.Text + "." + ipStart2.Text + "." + ipStart3.Text + "." + k;
                        PingReply reply = p1.Send(ip, Convert.ToInt32(txtTime.Text));

                        MethodInvoker mi = new MethodInvoker(() =>
                        {
                            TestMethod(ip, reply);
                        });
                        this.BeginInvoke(mi);
                    }
                    //*****以上是异步执行的代码*****
                });
                task.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("IP地址格式输入错误!");
            }
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="startIp">开始Ip</param>
        /// <param name="page">第几组</param>
        /// <param name="group">每组多少个</param>
        /// <param name="stopIp">终止Ip</param>
        public void TestMethod(int startIp,int page,int group,int stopIp)
        {
            
            for (int i = 0; i <= group; i++)
            {
                if (startIp + i > stopIp)
                    break;
                string ip = ipStart1.Text + "." + ipStart2.Text + "." + ipStart3.Text + "." + (startIp + i).ToString();
               
                try
                {
                    Ping p1 = new Ping();
                    PingReply reply = p1.Send(ip, Convert.ToInt32(txtTime.Text));
                    StringBuilder sbuilder;
                    if (reply.Status == IPStatus.Success)
                    {
                        sbuilder = new StringBuilder();
                        sbuilder.Append(string.Format("往返时间: {0} ", reply.RoundtripTime + "ms "));
                        sbuilder.Append(string.Format("TTL: {0} ", reply.Options.Ttl));
                        sbuilder.Append(string.Format("字节: {0} ", reply.Buffer.Length));

                        dataGridView1.Rows.Add(reply.Address.ToString(), GetMACByIP(reply.Address.ToString()), sbuilder.ToString()); ;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(ip, "", "请求超时!");
                    }
                }
                catch (Exception ex)
                {
                    dataGridView1.Rows.Add(ip, "", "异常错误:" + ex.Message);
                }
            }
        }
        public void TestMethod(string ip, PingReply reply)
        {
            try
            {
                StringBuilder sbuilder;
                if (reply.Status == IPStatus.Success)
                {
                    sbuilder = new StringBuilder();
                    sbuilder.Append(string.Format("往返时间: {0} ", reply.RoundtripTime + "ms "));
                    sbuilder.Append(string.Format("TTL: {0} ", reply.Options.Ttl));
                    sbuilder.Append(string.Format("字节: {0} ", reply.Buffer.Length));


                    dataGridView1.Rows.Add(reply.Address.ToString(), GetMACByIP(reply.Address.ToString()), sbuilder.ToString()); ;
                }
                else
                {
                    dataGridView1.Rows.Add(ip, "", "请求超时!");
                }
            }
            catch (Exception ex)
            {
                dataGridView1.Rows.Add(ip, "", "异常错误:" + ex.Message);
            }
        }
        [DllImport("Iphlpapi.dll")]
        private static extern int SendARP(Int32 dest, Int32 host, byte[] mac, ref Int32 length);
        [DllImport("Ws2_32.dll")]
        private static extern Int32 inet_addr(string ip);

        /// <summary>
        /// 根据ip得到网卡mac地址
        /// </summary>
        /// <param name="ip">给出的ip地址</param>
        /// <returns>对应ip的网卡mac地址</returns>
        public static string GetMACByIP(string ip)
        {
            try
            {
                byte[] aa = new byte[6];

                Int32 ldest = inet_addr(ip); //目的地的ip
                Int32 len = 6;
                int res = SendARP(ldest, 0, aa, ref len);

                return BitConverter.ToString(aa, 0, 6); ;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                //获取本机IP
                string name = Dns.GetHostName();
                IPAddress[] ipadrlist = Dns.GetHostAddresses(name);
                string[] ipArr = ipadrlist[1].ToString().Split('.');
                ipStart1.Text = ipEnd1.Text = ipArr[0];
                ipStart2.Text = ipEnd2.Text = ipArr[1];
                ipStart3.Text = ipEnd3.Text = ipArr[2];
            }
            catch { }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnLogin")
            {
                try
                {
                    VbsClass vs = new VbsClass();
                    string ip = dataGridView1.Rows[e.RowIndex].Cells["IpAddress"].Value.ToString();
                    string userName = txtName.Text.Trim();
                    string pwd = txtPwd.Text.Trim();
                    if (userName == "" || pwd == "")
                    {
                        MessageBox.Show("用户名或密码不能为空!");
                        return;
                    }
                    int time = Convert.ToInt32(textBox3.Text);
                    string xplore = rdoIE.Checked ? "iexplore.exe" : "chrome.exe";
                    vs.RunVbs(ip, userName, pwd, time, xplore);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("异常错误:" + ex.Message);
                }
            }
        }
    }
}
