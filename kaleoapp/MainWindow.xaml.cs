using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using kaleosoft.BLL;
using kaleosoft.Model;
using System.Runtime.InteropServices;
using System.IO;


namespace kaleoapp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //判断网络连接
        [DllImport("wininet")]
        private extern static bool InternetGetConnectedState(out int connectionDescription, int reservedValue);
        //获得操作数据库的方法
        kaleosoft.BLL.users user_bll = new kaleosoft.BLL.users();
        kaleosoft.BLL.user_localhost userlocalhost_bll = new kaleosoft.BLL.user_localhost();

        public MainWindow()
        {
            InitializeComponent();

            //判断是否联网
            int i = 0;
            if (InternetGetConnectedState(out i, 0))
            {
                //定义一个本地用户
                kaleosoft.Model.user_localhost userlocalhost_model=new kaleosoft.Model.user_localhost();
            
                //联网
                //取出本地的用户
                try
                {
               var userlocalhost_list = userlocalhost_bll.GetModelList("1=1");

              
               if (userlocalhost_list.Count>0)
               {

                    userlocalhost_model = userlocalhost_list.First();
                    //更新本地密码
                //查找网上相同的用户名的用户，取出数据，更改密码
                   kaleosoft.Model.users user_model=new kaleosoft.Model.users();//网上的操作用户
                    var user_list = user_bll.GetModelList("usersname='" + userlocalhost_model.username+"'");
                    if (user_list.Count>0)
                    {
                        user_model=user_list.First();
                        switch (user_model.operate)//操作类型
	                    {
                            //case 1://发送邮件，发送数据库
                            //        string excelpath = "footballmatch.mdb";
                            //        SendMail.SendMail sendmail = new SendMail.SendMail();
                            //       //判断文件是否存在
                            //        if (File.Exists(excelpath))
                            //        {
                            //            sendmail.sendmailtest1(excelpath, user_model.usersname + "数据库", user_model.value);
                            //        }
            
                            //    break;

                            case 2://上传ip地址
                                break;
                            case 3://
                                break;

		                    default:
                                //0，默认修改密码
                                if (userlocalhost_model.password != user_model.password)
                                {
                                    userlocalhost_model.password = user_model.password;
                                    userlocalhost_bll.Update(userlocalhost_model);
                                }
                                break;
                        }

                    }

                   
               }

                }
                catch (Exception e)
                {

                    //异常
                }

            }//enf 判断联网
            //else
            //{
            //    var model = userlocalhost_bll.GetModel(1);
            //    model.password = "lkjh";
            //    var re=userlocalhost_bll.Update(model);
            //    MessageBox.Show("改密码"+re);
            //}
                        
           
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (CheckLogin(TextBox_username.Text, PasswordBox_password.Password))
            {
                this.Hide();
                home index = new home();
                index.Show();
            }
            else
            {
                MessageBox.Show("登录失败，密码、用户名不正确或软件已过期");
            }

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="uname">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>结果1、成功2、失败</returns>
        public Boolean CheckLogin(string username, string password)
        {
            Boolean res = false;
            var name_str = "";
            var password_str = "";
            var username_localhost = userlocalhost_bll.GetModelList("1=1");
            if (username_localhost.Count > 0)
            {
                name_str = username_localhost.First().username;
                password_str = username_localhost.First().password;
                if (username == name_str && password == password_str)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }

            }
            return res;



        }
        /// <summary>
        /// enter 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click(sender, e);
            }
            //MessageBox.Show("您所按动的键是：" + e.Key.ToString());
        }




    }
}
