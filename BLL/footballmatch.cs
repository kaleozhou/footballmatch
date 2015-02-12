using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using kaleosoft.Model;
namespace kaleosoft.BLL
{
	/// <summary>
	/// footballmatch
	/// </summary>
	public partial class footballmatch
	{
		private readonly kaleosoft.DAL.footballmatch dal=new kaleosoft.DAL.footballmatch();
		public footballmatch()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(kaleosoft.Model.footballmatch model)
		{
			return dal.Add(model);
		}
        /// <summary>
        /// 获得modellist kaleo
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<kaleosoft.Model.footballmatch> GetModelListKaleo(int PageSize, int PageIndex, string Strwhere)
        {
            DataSet ds = dal.GetListByKaleo(PageSize, PageIndex, Strwhere);
            return DataTableToList(ds.Tables[0]);
        }

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(kaleosoft.Model.footballmatch model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public kaleosoft.Model.footballmatch GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public kaleosoft.Model.footballmatch GetModelByCache(int id)
		{
			
			string CacheKey = "footballmatchModel-" + id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (kaleosoft.Model.footballmatch)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<kaleosoft.Model.footballmatch> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<kaleosoft.Model.footballmatch> DataTableToList(DataTable dt)
		{
			List<kaleosoft.Model.footballmatch> modelList = new List<kaleosoft.Model.footballmatch>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				kaleosoft.Model.footballmatch model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

