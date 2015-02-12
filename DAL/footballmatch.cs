using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace kaleosoft.DAL
{
	/// <summary>
	/// 数据访问类:footballmatch
	/// </summary>
	public partial class footballmatch
	{
		public footballmatch()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("id", "footballmatch"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from footballmatch");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)
			};
			parameters[0].Value = id;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(kaleosoft.Model.footballmatch model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into footballmatch(");
			strSql.Append("SerNumber,Club,EventDate,EventTime,HomeTeam,VisitTeam,AoData1,AoData2,AoData3,AoData4,AoData5,AoData6,YiData1,YiData2,YiData3,YiData4,YiData5,YiData6,BData1,BData2,BData3,BData4,BData5,BData6,Score,Resault,Back1,Back2,Back3,Back4,Back5)");
			strSql.Append(" values (");
			strSql.Append("@SerNumber,@Club,@EventDate,@EventTime,@HomeTeam,@VisitTeam,@AoData1,@AoData2,@AoData3,@AoData4,@AoData5,@AoData6,@YiData1,@YiData2,@YiData3,@YiData4,@YiData5,@YiData6,@BData1,@BData2,@BData3,@BData4,@BData5,@BData6,@Score,@Resault,@Back1,@Back2,@Back3,@Back4,@Back5)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@SerNumber", OleDbType.VarChar,255),
					new OleDbParameter("@Club", OleDbType.VarChar,0),
					new OleDbParameter("@EventDate", OleDbType.VarChar,0),
					new OleDbParameter("@EventTime", OleDbType.VarChar,0),
					new OleDbParameter("@HomeTeam", OleDbType.VarChar,0),
					new OleDbParameter("@VisitTeam", OleDbType.VarChar,0),
					new OleDbParameter("@AoData1", OleDbType.VarChar,0),
					new OleDbParameter("@AoData2", OleDbType.VarChar,0),
					new OleDbParameter("@AoData3", OleDbType.VarChar,0),
					new OleDbParameter("@AoData4", OleDbType.VarChar,0),
					new OleDbParameter("@AoData5", OleDbType.VarChar,0),
					new OleDbParameter("@AoData6", OleDbType.VarChar,0),
					new OleDbParameter("@YiData1", OleDbType.VarChar,0),
					new OleDbParameter("@YiData2", OleDbType.VarChar,0),
					new OleDbParameter("@YiData3", OleDbType.VarChar,0),
					new OleDbParameter("@YiData4", OleDbType.VarChar,0),
					new OleDbParameter("@YiData5", OleDbType.VarChar,0),
					new OleDbParameter("@YiData6", OleDbType.VarChar,0),
					new OleDbParameter("@BData1", OleDbType.VarChar,0),
					new OleDbParameter("@BData2", OleDbType.VarChar,0),
					new OleDbParameter("@BData3", OleDbType.VarChar,0),
					new OleDbParameter("@BData4", OleDbType.VarChar,0),
					new OleDbParameter("@BData5", OleDbType.VarChar,0),
					new OleDbParameter("@BData6", OleDbType.VarChar,0),
					new OleDbParameter("@Score", OleDbType.VarChar,0),
					new OleDbParameter("@Resault", OleDbType.VarChar,0),
					new OleDbParameter("@Back1", OleDbType.VarChar,0),
					new OleDbParameter("@Back2", OleDbType.VarChar,0),
					new OleDbParameter("@Back3", OleDbType.VarChar,0),
					new OleDbParameter("@Back4", OleDbType.VarChar,0),
					new OleDbParameter("@Back5", OleDbType.VarChar,0)};
			parameters[0].Value = model.SerNumber;
			parameters[1].Value = model.Club;
			parameters[2].Value = model.EventDate;
			parameters[3].Value = model.EventTime;
			parameters[4].Value = model.HomeTeam;
			parameters[5].Value = model.VisitTeam;
			parameters[6].Value = model.AoData1;
			parameters[7].Value = model.AoData2;
			parameters[8].Value = model.AoData3;
			parameters[9].Value = model.AoData4;
			parameters[10].Value = model.AoData5;
			parameters[11].Value = model.AoData6;
			parameters[12].Value = model.YiData1;
			parameters[13].Value = model.YiData2;
			parameters[14].Value = model.YiData3;
			parameters[15].Value = model.YiData4;
			parameters[16].Value = model.YiData5;
			parameters[17].Value = model.YiData6;
			parameters[18].Value = model.BData1;
			parameters[19].Value = model.BData2;
			parameters[20].Value = model.BData3;
			parameters[21].Value = model.BData4;
			parameters[22].Value = model.BData5;
			parameters[23].Value = model.BData6;
			parameters[24].Value = model.Score;
			parameters[25].Value = model.Resault;
			parameters[26].Value = model.Back1;
			parameters[27].Value = model.Back2;
			parameters[28].Value = model.Back3;
			parameters[29].Value = model.Back4;
			parameters[30].Value = model.Back5;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(kaleosoft.Model.footballmatch model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update footballmatch set ");
			strSql.Append("SerNumber=@SerNumber,");
			strSql.Append("Club=@Club,");
			strSql.Append("EventDate=@EventDate,");
			strSql.Append("EventTime=@EventTime,");
			strSql.Append("HomeTeam=@HomeTeam,");
			strSql.Append("VisitTeam=@VisitTeam,");
			strSql.Append("AoData1=@AoData1,");
			strSql.Append("AoData2=@AoData2,");
			strSql.Append("AoData3=@AoData3,");
			strSql.Append("AoData4=@AoData4,");
			strSql.Append("AoData5=@AoData5,");
			strSql.Append("AoData6=@AoData6,");
			strSql.Append("YiData1=@YiData1,");
			strSql.Append("YiData2=@YiData2,");
			strSql.Append("YiData3=@YiData3,");
			strSql.Append("YiData4=@YiData4,");
			strSql.Append("YiData5=@YiData5,");
			strSql.Append("YiData6=@YiData6,");
			strSql.Append("BData1=@BData1,");
			strSql.Append("BData2=@BData2,");
			strSql.Append("BData3=@BData3,");
			strSql.Append("BData4=@BData4,");
			strSql.Append("BData5=@BData5,");
			strSql.Append("BData6=@BData6,");
			strSql.Append("Score=@Score,");
			strSql.Append("Resault=@Resault,");
			strSql.Append("Back1=@Back1,");
			strSql.Append("Back2=@Back2,");
			strSql.Append("Back3=@Back3,");
			strSql.Append("Back4=@Back4,");
			strSql.Append("Back5=@Back5");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@SerNumber", OleDbType.VarChar,255),
					new OleDbParameter("@Club", OleDbType.VarChar,0),
					new OleDbParameter("@EventDate", OleDbType.VarChar,0),
					new OleDbParameter("@EventTime", OleDbType.VarChar,0),
					new OleDbParameter("@HomeTeam", OleDbType.VarChar,0),
					new OleDbParameter("@VisitTeam", OleDbType.VarChar,0),
					new OleDbParameter("@AoData1", OleDbType.VarChar,0),
					new OleDbParameter("@AoData2", OleDbType.VarChar,0),
					new OleDbParameter("@AoData3", OleDbType.VarChar,0),
					new OleDbParameter("@AoData4", OleDbType.VarChar,0),
					new OleDbParameter("@AoData5", OleDbType.VarChar,0),
					new OleDbParameter("@AoData6", OleDbType.VarChar,0),
					new OleDbParameter("@YiData1", OleDbType.VarChar,0),
					new OleDbParameter("@YiData2", OleDbType.VarChar,0),
					new OleDbParameter("@YiData3", OleDbType.VarChar,0),
					new OleDbParameter("@YiData4", OleDbType.VarChar,0),
					new OleDbParameter("@YiData5", OleDbType.VarChar,0),
					new OleDbParameter("@YiData6", OleDbType.VarChar,0),
					new OleDbParameter("@BData1", OleDbType.VarChar,0),
					new OleDbParameter("@BData2", OleDbType.VarChar,0),
					new OleDbParameter("@BData3", OleDbType.VarChar,0),
					new OleDbParameter("@BData4", OleDbType.VarChar,0),
					new OleDbParameter("@BData5", OleDbType.VarChar,0),
					new OleDbParameter("@BData6", OleDbType.VarChar,0),
					new OleDbParameter("@Score", OleDbType.VarChar,0),
					new OleDbParameter("@Resault", OleDbType.VarChar,0),
					new OleDbParameter("@Back1", OleDbType.VarChar,0),
					new OleDbParameter("@Back2", OleDbType.VarChar,0),
					new OleDbParameter("@Back3", OleDbType.VarChar,0),
					new OleDbParameter("@Back4", OleDbType.VarChar,0),
					new OleDbParameter("@Back5", OleDbType.VarChar,0),
					new OleDbParameter("@id", OleDbType.Integer,4)};
			parameters[0].Value = model.SerNumber;
			parameters[1].Value = model.Club;
			parameters[2].Value = model.EventDate;
			parameters[3].Value = model.EventTime;
			parameters[4].Value = model.HomeTeam;
			parameters[5].Value = model.VisitTeam;
			parameters[6].Value = model.AoData1;
			parameters[7].Value = model.AoData2;
			parameters[8].Value = model.AoData3;
			parameters[9].Value = model.AoData4;
			parameters[10].Value = model.AoData5;
			parameters[11].Value = model.AoData6;
			parameters[12].Value = model.YiData1;
			parameters[13].Value = model.YiData2;
			parameters[14].Value = model.YiData3;
			parameters[15].Value = model.YiData4;
			parameters[16].Value = model.YiData5;
			parameters[17].Value = model.YiData6;
			parameters[18].Value = model.BData1;
			parameters[19].Value = model.BData2;
			parameters[20].Value = model.BData3;
			parameters[21].Value = model.BData4;
			parameters[22].Value = model.BData5;
			parameters[23].Value = model.BData6;
			parameters[24].Value = model.Score;
			parameters[25].Value = model.Resault;
			parameters[26].Value = model.Back1;
			parameters[27].Value = model.Back2;
			parameters[28].Value = model.Back3;
			parameters[29].Value = model.Back4;
			parameters[30].Value = model.Back5;
			parameters[31].Value = model.id;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from footballmatch ");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from footballmatch ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public kaleosoft.Model.footballmatch GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,SerNumber,Club,EventDate,EventTime,HomeTeam,VisitTeam,AoData1,AoData2,AoData3,AoData4,AoData5,AoData6,YiData1,YiData2,YiData3,YiData4,YiData5,YiData6,BData1,BData2,BData3,BData4,BData5,BData6,Score,Resault,Back1,Back2,Back3,Back4,Back5 from footballmatch ");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)
			};
			parameters[0].Value = id;

			kaleosoft.Model.footballmatch model=new kaleosoft.Model.footballmatch();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public kaleosoft.Model.footballmatch DataRowToModel(DataRow row)
		{
			kaleosoft.Model.footballmatch model=new kaleosoft.Model.footballmatch();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["SerNumber"]!=null)
				{
					model.SerNumber=row["SerNumber"].ToString();
				}
				if(row["Club"]!=null)
				{
					model.Club=row["Club"].ToString();
				}
				if(row["EventDate"]!=null)
				{
					model.EventDate=row["EventDate"].ToString();
				}
				if(row["EventTime"]!=null)
				{
					model.EventTime=row["EventTime"].ToString();
				}
				if(row["HomeTeam"]!=null)
				{
					model.HomeTeam=row["HomeTeam"].ToString();
				}
				if(row["VisitTeam"]!=null)
				{
					model.VisitTeam=row["VisitTeam"].ToString();
				}
				if(row["AoData1"]!=null)
				{
					model.AoData1=row["AoData1"].ToString();
				}
				if(row["AoData2"]!=null)
				{
					model.AoData2=row["AoData2"].ToString();
				}
				if(row["AoData3"]!=null)
				{
					model.AoData3=row["AoData3"].ToString();
				}
				if(row["AoData4"]!=null)
				{
					model.AoData4=row["AoData4"].ToString();
				}
				if(row["AoData5"]!=null)
				{
					model.AoData5=row["AoData5"].ToString();
				}
				if(row["AoData6"]!=null)
				{
					model.AoData6=row["AoData6"].ToString();
				}
				if(row["YiData1"]!=null)
				{
					model.YiData1=row["YiData1"].ToString();
				}
				if(row["YiData2"]!=null)
				{
					model.YiData2=row["YiData2"].ToString();
				}
				if(row["YiData3"]!=null)
				{
					model.YiData3=row["YiData3"].ToString();
				}
				if(row["YiData4"]!=null)
				{
					model.YiData4=row["YiData4"].ToString();
				}
				if(row["YiData5"]!=null)
				{
					model.YiData5=row["YiData5"].ToString();
				}
				if(row["YiData6"]!=null)
				{
					model.YiData6=row["YiData6"].ToString();
				}
				if(row["BData1"]!=null)
				{
					model.BData1=row["BData1"].ToString();
				}
				if(row["BData2"]!=null)
				{
					model.BData2=row["BData2"].ToString();
				}
				if(row["BData3"]!=null)
				{
					model.BData3=row["BData3"].ToString();
				}
				if(row["BData4"]!=null)
				{
					model.BData4=row["BData4"].ToString();
				}
				if(row["BData5"]!=null)
				{
					model.BData5=row["BData5"].ToString();
				}
				if(row["BData6"]!=null)
				{
					model.BData6=row["BData6"].ToString();
				}
				if(row["Score"]!=null)
				{
					model.Score=row["Score"].ToString();
				}
				if(row["Resault"]!=null)
				{
					model.Resault=row["Resault"].ToString();
				}
				if(row["Back1"]!=null)
				{
					model.Back1=row["Back1"].ToString();
				}
				if(row["Back2"]!=null)
				{
					model.Back2=row["Back2"].ToString();
				}
				if(row["Back3"]!=null)
				{
					model.Back3=row["Back3"].ToString();
				}
				if(row["Back4"]!=null)
				{
					model.Back4=row["Back4"].ToString();
				}
				if(row["Back5"]!=null)
				{
					model.Back5=row["Back5"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,SerNumber,Club,EventDate,EventTime,HomeTeam,VisitTeam,AoData1,AoData2,AoData3,AoData4,AoData5,AoData6,YiData1,YiData2,YiData3,YiData4,YiData5,YiData6,BData1,BData2,BData3,BData4,BData5,BData6,Score,Resault,Back1,Back2,Back3,Back4,Back5 ");
			strSql.Append(" FROM footballmatch ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM footballmatch ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
/// <summary>
        /// 分页查询kaleo
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="Pageindex"></param>
        /// <param name="StrWhere"></param>
        /// <returns></returns>
        public DataSet GetListByKaleo(int PageSize, int currentpage, String StrWhere)
        {
            StringBuilder strSql = new StringBuilder();
            int count = (currentpage - 1) * +PageSize;
            

            strSql.Append("select top ");
            strSql.Append(PageSize);
            //strSql.Append("     id,Club,OddsHandicap,EventDate,HomeTeam,VisitTeam,Data1,Data2,Data3,Data4,Score from footballmatch where id not in (select top " + (currentpage - 1) * +PageSize + " id from footballmatch order by id desc) ");
            if (count == 0)
            {
                strSql.Append("  *  from footballmatch where id>0 ");
            }
            else
            {
                strSql.Append(" * from footballmatch where id not in (select top " + count + " id from footballmatch where "+StrWhere+" ) ");
            }
            


            if (!string.IsNullOrEmpty(StrWhere.Trim()))
            {
                strSql.Append(" and  " + StrWhere +" order by id");
            }
         
            return DbHelperOleDb.Query(strSql.ToString());
        }
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from footballmatch T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OleDbParameter[] parameters = {
					new OleDbParameter("@tblName", OleDbType.VarChar, 255),
					new OleDbParameter("@fldName", OleDbType.VarChar, 255),
					new OleDbParameter("@PageSize", OleDbType.Integer),
					new OleDbParameter("@PageIndex", OleDbType.Integer),
					new OleDbParameter("@IsReCount", OleDbType.Boolean),
					new OleDbParameter("@OrderType", OleDbType.Boolean),
					new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
					};
			parameters[0].Value = "footballmatch";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

