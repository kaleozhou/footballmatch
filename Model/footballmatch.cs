using System;
namespace kaleosoft.Model
{
	/// <summary>
	/// footballmatch:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class footballmatch
	{
		public footballmatch()
		{}
		#region Model
		private int _id;
		private string _sernumber;
		private string _club;
		private string _eventdate;
		private string _eventtime;
		private string _hometeam;
		private string _visitteam;
		private string _aodata1;
		private string _aodata2;
		private string _aodata3;
		private string _aodata4;
		private string _aodata5;
		private string _aodata6;
		private string _yidata1;
		private string _yidata2;
		private string _yidata3;
		private string _yidata4;
		private string _yidata5;
		private string _yidata6;
		private string _bdata1;
		private string _bdata2;
		private string _bdata3;
		private string _bdata4;
		private string _bdata5;
		private string _bdata6;
		private string _score;
		private string _resault;
		private string _back1;
		private string _back2;
		private string _back3;
		private string _back4;
		private string _back5;
		/// <summary>
		/// 序号
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 轮次
		/// </summary>
		public string SerNumber
		{
			set{ _sernumber=value;}
			get{return _sernumber;}
		}
		/// <summary>
		/// 联赛
		/// </summary>
		public string Club
		{
			set{ _club=value;}
			get{return _club;}
		}
		/// <summary>
		/// 比赛日期
		/// </summary>
		public string EventDate
		{
			set{ _eventdate=value;}
			get{return _eventdate;}
		}
		/// <summary>
		/// 比赛时间
		/// </summary>
		public string EventTime
		{
			set{ _eventtime=value;}
			get{return _eventtime;}
		}
		/// <summary>
		/// 主队
		/// </summary>
		public string HomeTeam
		{
			set{ _hometeam=value;}
			get{return _hometeam;}
		}
		/// <summary>
		/// 客队
		/// </summary>
		public string VisitTeam
		{
			set{ _visitteam=value;}
			get{return _visitteam;}
		}
		/// <summary>
		/// 出盘主队数据
		/// </summary>
		public string AoData1
		{
			set{ _aodata1=value;}
			get{return _aodata1;}
		}
		/// <summary>
		/// 出盘盘口
		/// </summary>
		public string AoData2
		{
			set{ _aodata2=value;}
			get{return _aodata2;}
		}
		/// <summary>
		/// 出盘客队数据
		/// </summary>
		public string AoData3
		{
			set{ _aodata3=value;}
			get{return _aodata3;}
		}
		/// <summary>
		/// 入盘主队数据
		/// </summary>
		public string AoData4
		{
			set{ _aodata4=value;}
			get{return _aodata4;}
		}
		/// <summary>
		/// 入盘盘口
		/// </summary>
		public string AoData5
		{
			set{ _aodata5=value;}
			get{return _aodata5;}
		}
		/// <summary>
		/// 入盘客队数据
		/// </summary>
		public string AoData6
		{
			set{ _aodata6=value;}
			get{return _aodata6;}
		}
		/// <summary>
		/// 出盘主队数据
		/// </summary>
		public string YiData1
		{
			set{ _yidata1=value;}
			get{return _yidata1;}
		}
		/// <summary>
		/// 出盘盘口
		/// </summary>
		public string YiData2
		{
			set{ _yidata2=value;}
			get{return _yidata2;}
		}
		/// <summary>
		/// 出盘客队数据
		/// </summary>
		public string YiData3
		{
			set{ _yidata3=value;}
			get{return _yidata3;}
		}
		/// <summary>
		/// 入盘主队数据
		/// </summary>
		public string YiData4
		{
			set{ _yidata4=value;}
			get{return _yidata4;}
		}
		/// <summary>
		/// 入盘盘口
		/// </summary>
		public string YiData5
		{
			set{ _yidata5=value;}
			get{return _yidata5;}
		}
		/// <summary>
		/// 入盘客队数据
		/// </summary>
		public string YiData6
		{
			set{ _yidata6=value;}
			get{return _yidata6;}
		}
		/// <summary>
		/// 出盘主队数据
		/// </summary>
		public string BData1
		{
			set{ _bdata1=value;}
			get{return _bdata1;}
		}
		/// <summary>
		/// 出盘盘口
		/// </summary>
		public string BData2
		{
			set{ _bdata2=value;}
			get{return _bdata2;}
		}
		/// <summary>
		/// 出盘客队数据
		/// </summary>
		public string BData3
		{
			set{ _bdata3=value;}
			get{return _bdata3;}
		}
		/// <summary>
		/// 入盘主队数据
		/// </summary>
		public string BData4
		{
			set{ _bdata4=value;}
			get{return _bdata4;}
		}
		/// <summary>
		/// 入盘盘口
		/// </summary>
		public string BData5
		{
			set{ _bdata5=value;}
			get{return _bdata5;}
		}
		/// <summary>
		/// 入盘客队数据
		/// </summary>
		public string BData6
		{
			set{ _bdata6=value;}
			get{return _bdata6;}
		}
		/// <summary>
		/// 比分
		/// </summary>
		public string Score
		{
			set{ _score=value;}
			get{return _score;}
		}
		/// <summary>
		/// 赛果
		/// </summary>
		public string Resault
		{
			set{ _resault=value;}
			get{return _resault;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Back1
		{
			set{ _back1=value;}
			get{return _back1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Back2
		{
			set{ _back2=value;}
			get{return _back2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Back3
		{
			set{ _back3=value;}
			get{return _back3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Back4
		{
			set{ _back4=value;}
			get{return _back4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Back5
		{
			set{ _back5=value;}
			get{return _back5;}
		}
		#endregion Model

	}
}

