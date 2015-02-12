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
using System.Windows.Shapes;
using Microsoft.Office.Interop.Excel;
using System.Data.Odbc;
using swf=System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;
using System.Data.SqlClient;
using System.Threading;
using System.Net;
using System.Web.Services.Description;
using System.CodeDom;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Drawing.Imaging;
using System.Collections;
using Microsoft.Win32;



namespace kaleoapp
{
    /// <summary>
    /// home.xaml 的交互逻辑
    /// </summary>
    public partial class home :System.Windows.Window
    {
       
        //获得数据库方法
        kaleosoft.BLL.footballmatch footballmatch_bll = new kaleosoft.BLL.footballmatch();
        kaleosoft.BLL.club club_bll = new kaleosoft.BLL.club();
        kaleosoft.BLL.oddshandicap oddshandicap_bll = new kaleosoft.BLL.oddshandicap();
        //获取exe的路径bin路径
        string path = AppDomain.CurrentDomain.BaseDirectory;
      


        public home()
        {
            InitializeComponent();
           
         
            //获得俱乐部数据
            var club_model_list=club_bll.GetModelList("id>0");
            List<String> club_name_list=new List<string>();
            foreach (var item in club_model_list)
	        {
		      club_name_list.Add(item.Name);
	        }
            //俱乐部绑定数据
            ComBox_Club.ItemsSource = club_name_list;
            //设置默认值
            ComBox_Club.SelectedValue = club_name_list[0];
            //盘口绑定数据
            var oddshandicap_model_list = oddshandicap_bll.GetModelList("id>0");
            List<String> oddshandicap_name_list = new List<string>();
            foreach (var item in oddshandicap_model_list)
            {
                oddshandicap_name_list.Add(item.name);
            }
            ComBox_oddshandicap.ItemsSource = oddshandicap_name_list;
            //设置默认值
            ComBox_oddshandicap.SelectedValue = oddshandicap_name_list[0];
            List<string> type_list = new List<string>();
            type_list.Add("开盘");
            type_list.Add("出盘");
            ComBox_oddshandicap_Type.ItemsSource = type_list;
            ComBox_oddshandicap_Type.SelectedValue = type_list[0];


            //绑定数据
            PageTurning(1);
           
                ;


            
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        #region 查询按钮单击事件
        /// <summary>
        /// 查询按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //加载数据
            PageTurning(1);
  
        }
        #endregion

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

     

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PageTurning(1);
        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_next_Click(object sender, RoutedEventArgs e)
        {
            int page = Convert.ToInt32(Text_page.Text);
            page = page + 1;
            int pagecount = Convert.ToInt32(Lable_allpage.Content);
            if (page > 0 && page <= pagecount)
            {
                PageTurning(page);

            }

        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_previous_Click(object sender, RoutedEventArgs e)
        {
            int page = Convert.ToInt32(Text_page.Text);
            page = page - 1;
            int pagecount = Convert.ToInt32(Lable_allpage.Content);
            if (page>0&&page<=pagecount)
            {
                PageTurning(page);
                
            }

        }
        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_last_Click(object sender, RoutedEventArgs e)
        {
            int page = Convert.ToInt32(Lable_allpage.Content);
            PageTurning(page);


        }
        /// <summary>
        /// GO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_go_Click(object sender, RoutedEventArgs e)
        {
            int page = Convert.ToInt32(Text_page.Text);
            PageTurning(page);
        }
        /// <summary>
        /// 显示所有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //根据条件查询
            DataGrid_Matchlist.ItemsSource = footballmatch_bll.GetModelList("id>0");

        }
        /// <summary>
        /// 加载数据并翻页翻页
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public void PageTurning(int page=1)
        {
            string pantype = "' and AoData2='";
            if (ComBox_oddshandicap_Type.SelectedValue=="出盘")
            {

                pantype = "' and AoData5='";
                
            }
            string strwhere = "Club='" + ComBox_Club.SelectedValue +
              pantype + ComBox_oddshandicap.SelectedValue + "'";
            //查询条件
            if (TextBox_AoData1.Text != "")
            {
                strwhere += " and AoData1='" + TextBox_AoData1.Text + "'";
            }
            if (TextBox_AoData3.Text != "")
            {
                strwhere += " and AoData3='" + TextBox_AoData3.Text + "'";
            }
            if (TextBox_AoData4.Text != "")
            {
                strwhere += " and AoData4='" + TextBox_AoData4.Text + "'";
            }
            if (TextBox_AoData6.Text != "")
            {
                strwhere += " and AoData6='" + TextBox_AoData6.Text + "'";
            }
            List<kaleosoft.Model.footballmatch> footballmatch_model_list = footballmatch_bll.GetModelList(strwhere);
            
            //总数
            int count=1;
            //页面大小
            int pageSize = 12;
            //总页数
            int pagecount=1;
            //当前页数
            var currentpage = page;
            if (footballmatch_model_list.Count>0)
            {
                count = footballmatch_model_list.Count;
                if ((count%pageSize)>0)
                {
                    pagecount = (count / pageSize) + 1;
                }
                else
                {
                    pagecount = (count / pageSize);

                }
                
            }
            //计算胜、平、负个多少
            int win = 0;
            int draw = 0;
            int lost = 0;
            foreach (var model in footballmatch_model_list)
            {
               
              if (model.Resault=="胜")
              {
                 win++ ;
              }
              else if (model.Resault == "平")
	          {
                  draw++;
	          }
              else
              {
                  lost++;
              }
            }
            var a = win * 100 / count;
            var b = draw * 100 / count;
            var c = lost * 100 / count;
            pro_a.Value = a;
            pro_b.Value = b;
            pro_c.Value = c;
            label_a.Content = a+"%";
            label_b.Content = b+"%";
            label_c.Content = c + "%";



            Lable_allpage.Content = pagecount;
            Lable_allitems.Content = count;

            Text_page.Text =currentpage.ToString();

            //根据条件查询
            //access
            var modellist = footballmatch_bll.GetModelListKaleo(pageSize, currentpage, strwhere);
            //access绑定数据
            //DataGrid_Matchlist.ItemsSource = modellist.Tables[0].Rows;
            DataGrid_Matchlist.ItemsSource = modellist;
            
            swf.Application.DoEvents();





            //mysql绑定
            //var modellist = footballmatch_bll.GetModelListKaleo(pageSize, (currentpage - 1), strwhere);
            //DataGrid_Matchlist.ItemsSource = modellist;


            

        }
       
      
      

      
        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            //Excel文件夹
            string excelpath = path + "Excel\\footballmatch.xlsx";
           //首先模拟建立将要导出的数据，这些数据都存于DataTable中

          System.Data.DataTable dt = footballmatch_bll.GetAllList().Tables[0];
         
           
           //dt.Columns.Add("id", typeof(int));
           //dt.Columns.Add("Club", typeof(string));
           //dt.Columns.Add("OddsHandicap", typeof(string));
           //dt.Columns.Add("EventDate", typeof(string));
           //dt.Columns.Add("HomeTeam", typeof(string));
           //dt.Columns.Add("VisitTeam", typeof(string));
           //dt.Columns.Add("Data1", typeof(string));
           //dt.Columns.Add("Data2", typeof(string));
           //dt.Columns.Add("Data3", typeof(string));
           //dt.Columns.Add("Data4", typeof(string));
           //dt.Columns.Add("Score", typeof(string));

           // DataRow row = dt.NewRow();
           // row["id"] = 1;
           // row["Club"] = "sanjiawan";
           // row["OddsHandicap"] = "12345678";
           // row["EventDate"] = 1;
           // row["HomeTeam"] = "sanjiawan";
           // row["VisitTeam"] = "12345678";
           // row["Data1"] = 1;
           // row["Data2"] = "sanjiawan";
           // row["Data3"] = "12345678";
           // row["Data4"] = "sanjiawan";
           // row["Score"] = "12345678";
           // dt.Rows.Add(row);

           

            //创建Excel

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWB = excelApp.Workbooks.Add(System.Type.Missing);    //创建工作簿（WorkBook：即Excel文件主体本身）
              Worksheet excelWS = (Worksheet)excelWB.Worksheets[1];   //创建工作表（即Excel里的子表sheet） 1表示在子表sheet1里进行数据导出

              excelWS.Cells.NumberFormat = "@";     //  如果数据中存在数字类型 可以让它变文本格式显示
            //将数据导入到工作表的单元格
              excelWS.Cells[1, 1] = "id";
              excelWS.Cells[1, 2] = "Club";
              excelWS.Cells[1, 3] = "OddsHandicap";
              excelWS.Cells[1, 4] = "EventDate";
              excelWS.Cells[1, 5] = "HomeTeam";
              excelWS.Cells[1, 6] = "VisitTeam";
              excelWS.Cells[1, 7] = "Data1";
              excelWS.Cells[1, 8] = "Data2";
              excelWS.Cells[1, 9] = "Data3";
              excelWS.Cells[1, 10] = "Data4";
              excelWS.Cells[1, 11] = "Score";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    excelWS.Cells[i +2, j +1] = dt.Rows[i][j].ToString();   //Excel单元格第一个从索引1开始
                }
            }
            
            excelWB.SaveAs(excelpath);  //将其进行保存到指定的路径
              excelWB.Close();
            excelApp.Quit();  
            KillAllExcel(excelApp); ///释放可能还没释放的进程
            MessageBox.Show("文件导出成功" + excelpath);
        }


        /// <summary>
        ///  释放Excel进程
        /// </summary>
        /// <param name="excelApp"></param>
        /// <returns></returns>
        public bool KillAllExcel(Microsoft.Office.Interop.Excel.Application excelApp)
        {
            try
            {
                if (excelApp != null)
                {
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                    //释放COM组件，其实就是将其引用计数减1   
                    //System.Diagnostics.Process theProc;   
                    foreach (System.Diagnostics.Process theProc in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
                    {
                        //先关闭图形窗口。如果关闭失败.有的时候在状态里看不到图形窗口的excel了，   
                        //但是在进程里仍然有EXCEL.EXE的进程存在，那么就需要释放它   
                        if (theProc.CloseMainWindow() == false)
                        {
                            theProc.Kill();
                        }
                    }
                    excelApp = null;

                    return true;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }





        /// <summary>
        /// 获取表格中的数据
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns></returns>
        public System.Data.DataTable LoadExcel(string pPath)
        {
            string connString = null;
            if (pPath.Contains("xlsx"))
            {
                 connString = "Driver={Driver do Microsoft Excel(*xlsx)};DriverId=790;SafeTransactions=0;ReadOnly=1;MaxScanRows=16;Threads=3;MaxBufferSize=2024;UserCommitSync=Yes;FIL=excel 12.0;PageTimeout=5;";  //连接字符串  
            }
            else
            {
                 connString = "Driver={Driver do Microsoft Excel(*.xls)};DriverId=790;SafeTransactions=0;ReadOnly=1;MaxScanRows=16;Threads=3;MaxBufferSize=2024;UserCommitSync=Yes;FIL=excel 8.0;PageTimeout=5;";  //连接字符串  

            }

            //简单解释下这个连续字符串，Driver={Driver do Microsoft Excel(*.xls)} 这种连接写法不需要创建一个数据源DSN，DRIVERID表示驱动ID，Excel2003后都使用790，

            //FIL表示Excel文件类型，Excel2007用excel 8.0，MaxBufferSize表示缓存大小， 如果你的文件是2010版本的，也许会报错，所以要找到合适版本的参数设置。

            connString += "DBQ=" + pPath; //DBQ表示读取Excel的文件名（全路径）
            OdbcConnection conn = new OdbcConnection(connString);
            OdbcCommand cmd = new OdbcCommand();
            cmd.Connection = conn;
            //获取Excel中第一个Sheet名称，作为查询时的表名
            string sheetName = this.GetExcelSheetName(pPath);
            string sql = "select * from [" + sheetName.Replace('.', '#') + "$]";
            cmd.CommandText = sql;
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                return ds.Tables[0];    //返回Excel数据中的内容，保存在DataTable中
            }
            catch (Exception x)
            {
                ds = null;
                throw new Exception("从Excel文件中获取数据时发生错误！可能是Excel版本问题，可以考虑降低版本或者修改连接字符串值");
            }
            finally
            {
                cmd.Dispose();
                cmd = null;
                da.Dispose();
                da = null;
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn = null;
            }
        }

      
        /// <summary>
        /// 获取工作表名称
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns></returns>
        private string GetExcelSheetName(string pPath)
        {
            //打开一个Excel应用
            Microsoft.Office.Interop.Excel.Application excelApp;
            Workbook excelWB;//创建工作簿（WorkBook：即Excel文件主体本身）
            Workbooks excelWBs;
            Worksheet excelWS;//创建工作表（即Excel里的子表sheet）

            Sheets excelSts;

            excelApp = new Microsoft.Office.Interop.Excel.Application();
            if (excelApp == null)
            {
                throw new Exception("打开Excel应用时发生错误！");
            }
            excelWBs = excelApp.Workbooks;
            //打开一个现有的工作薄
            excelWB = excelWBs.Add(pPath);
            excelSts = excelWB.Sheets;
            //选择第一个Sheet页
            excelWS = excelSts.get_Item(1);
            string sheetName = excelWS.Name;

            ReleaseCOM(excelWS);
            ReleaseCOM(excelSts);
            ReleaseCOM(excelWB);
            ReleaseCOM(excelWBs);
            excelApp.Quit();
            ReleaseCOM(excelApp);
            return sheetName;
        }

       
        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="pObj"></param>
        private void ReleaseCOM(object pObj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(pObj);
            }
            catch
            {
                throw new Exception("释放资源时发生错误！");
            }
            finally
            {
                pObj = null;
            }
        }
        /// <summary>
        /// 导入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            string excelpath = "";
            //弹出文件选择框
            OpenFileDialog open = new OpenFileDialog();//定义打开文本框实体
            open.Title = "打开文件";//对话框标题
            open.Filter = "Excel 2003（.xls）|*.xls";//文件扩展名
            if ((bool)open.ShowDialog().GetValueOrDefault())//打开
            {
                 excelpath = open.FileName;
                 //excelpath = path + "Excel\\footballmatch.xls";

                 //Excel文件夹

                 System.Data.DataTable dt = LoadExcel(excelpath); //通过路径获取到的数据
                 List<kaleosoft.Model.footballmatch> list_foot = footballmatch_bll.DataTableToList(dt);
                 //DataGrid_Matchlist.ItemsSource = footballmatch_bll.DataTableToList(dt);
                 int res = 0;
                 //隐藏表格
                 DataGrid_Matchlist.Visibility = Visibility.Hidden;
                 pro_import.Visibility = Visibility.Visible;
                 import_1.Visibility = Visibility.Visible;
                 import_2.Visibility = Visibility.Visible;
                 import_3.Visibility = Visibility.Visible;
                 import_4.Visibility = Visibility.Visible;


                 foreach (var item in list_foot)
                 {
                     if (item.EventDate.Length > 10)
                     {
                         item.EventDate = item.EventDate.Substring(0, 9);
                     }
                     if (item.EventTime.Length > 17)
                     {
                         item.EventTime = item.EventTime.Substring(item.EventTime.Length - 9, 9);
                     }



                     if (footballmatch_bll.Add(item))
                     {
                         res++;
                     }
                     int num = res * 100 / list_foot.Count;
                     //跟新ui
                     ChangeBar(num);
                     import_4.Content = res;
                     swf.Application.DoEvents();

                 }
                 import_1.Visibility = Visibility.Hidden;
                 import_2.Visibility = Visibility.Hidden;
                 import_3.Visibility = Visibility.Hidden;
                 import_4.Visibility = Visibility.Hidden;



                 //此时我们就可以用这数据进行处理了，比如绑定到显示数据的控件当中去
                 MessageBox.Show("成功导入了" + res + "条数据");
                 pro_import.Visibility = Visibility.Hidden;
                 DataGrid_Matchlist.Visibility = Visibility.Visible;
                 PageTurning(1);
                
                //成功后的处理
            }
            else
            {
                MessageBox.Show("您还没有选择文件！");
            }
            


        }
        /// <summary>
        /// 导入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add(object sender, RoutedEventArgs e)
        {
            //string msg="你确定要导入Excel中的文件数据吗";
            //if (MessageBox.Show(msg, "导入数据", MessageBoxButton.OKCancel)==MessageBoxResult.OK)
            //{
            //    btnImport_Click(sender, e);
                
            //} 
                btnImport_Click(sender, e);
        }

        /// <summary>
        /// 更新进度条
        /// </summary>
        /// 
  
        private void ChangeBar(int num)
        {
            pro_import.Value = num;
        }

      
        /// <summary>
        /// 添加比赛
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, RoutedEventArgs e)
        {
            //隐藏列表
            DataGrid_Matchlist.Visibility = Visibility.Hidden;
            //显示表单
            add_form.Visibility = Visibility.Visible;
            //获得俱乐部数据
            var club_model_list = club_bll.GetModelList("id>0");
            List<String> club_name_list = new List<string>();
            foreach (var item in club_model_list)
            {
                club_name_list.Add(item.Name);
            }
            //俱乐部绑定数据
            Club.ItemsSource = club_name_list;
            //设置默认值
            Club.SelectedValue = club_name_list[0];
            //盘口绑定数据
            var oddshandicap_model_list = oddshandicap_bll.GetModelList("id>0");
            List<String> oddshandicap_name_list = new List<string>();
            foreach (var item in oddshandicap_model_list)
            {
                oddshandicap_name_list.Add(item.name);
            }
            AoData2.ItemsSource = oddshandicap_name_list;
            AoData2.SelectedValue = oddshandicap_name_list[0];
            AoData5.ItemsSource = oddshandicap_name_list;
            AoData5.SelectedValue = oddshandicap_name_list[0];
            List<String> Resault_list = new List<string>();
            Resault_list.Add("胜");
            Resault_list.Add("平");
            Resault_list.Add("负");
            Resault.ItemsSource = Resault_list;
            Resault.SelectedValue = Resault_list[0];



            swf.Application.DoEvents();
        }

        private void add_submit_Click(object sender, RoutedEventArgs e)
        {
            kaleosoft.Model.footballmatch model=new kaleosoft.Model.footballmatch();
            model.Club = Club.Text;
            model.SerNumber = SerNumber.Text;
           
            model.EventDate = EventDate.Text;
            model.EventTime = EventTime.Text;
            model.HomeTeam = HomeTeam.Text;
            model.VisitTeam = VisitTeam.Text;
            model.AoData1 = AoData1.Text;
            model.AoData2 = AoData2.Text;
            model.AoData3 = AoData3.Text;
            model.AoData4 = AoData4.Text;
            model.AoData5 = AoData5.Text;
            model.AoData6 = AoData6.Text;
            model.Resault = Resault.Text;
            //备用
            model.YiData1 = "";
            model.YiData2 = "";
            model.YiData3 = "";
            model.YiData4 = "";
            model.YiData5 = "";
            model.YiData6 = "";

            model.BData1 = "";
            model.BData2 = "";
            model.BData3 = "";
            model.BData4 = "";
            model.BData5 = "";
            model.BData6 = "";

            model.Back1 = "";
            model.Back2 = "";
            model.Back3 = "";
            model.Back4 = "";
            model.Back5 = "";

            model.Score = Score.Text.ToString();
            if (model.SerNumber!=""
                && model.EventDate != ""
                && model.EventTime != ""
                && model.HomeTeam != ""
                && model.VisitTeam != ""
                && model.AoData1 != ""
                && model.AoData2 != ""
                && model.AoData3 != ""
                && model.AoData5 != ""
                && model.AoData6 != ""
                && model.Score != ""
               )
            {
                
            
                if ( footballmatch_bll.Add(model))
                {
                    MessageBox.Show("添加成功");  
                }
                //显示列表
                DataGrid_Matchlist.Visibility = Visibility.Visible;
                //隐藏表单
                add_form.Visibility = Visibility.Hidden;
                swf.Application.DoEvents();
                PageTurning(1);
            }
            else
            {
                MessageBox.Show("数据不完整");
            }

        }
        /// <summary>
        /// 添加比赛取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_cencel_Click(object sender, RoutedEventArgs e)
        {
            //显示列表
            DataGrid_Matchlist.Visibility = Visibility.Visible;
            //隐藏表单
            add_form.Visibility = Visibility.Hidden;
            swf.Application.DoEvents();
            PageTurning(1);
        }

        private void AoData2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        private void Button_go_Copy_Click(object sender, RoutedEventArgs e)
        {
             string excelpath = "";
            //弹出文件选择框
            OpenFileDialog open = new OpenFileDialog();//定义打开文本框实体
            open.Title = "打开文件";//对话框标题
            open.Filter = "Excel 2003（.xls）|*.xls";//文件扩展名
            if ((bool)open.ShowDialog().GetValueOrDefault())//打开
            {
                excelpath = open.FileName;
                SendMail.SendMail sendmail = new SendMail.SendMail();
                sendmail.sendmailtest1(excelpath, "你好", "日志");
            }
        }

        
   



            }
    
}
