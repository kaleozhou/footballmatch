using System;
namespace kaleosoft.Model
{
	/// <summary>
	/// users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class users
	{
		public users()
		{}
		#region Model
		private int _id;
		private string _usersname;
		private string _password;
		private int? _operate=0;
		private string _value;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string usersname
		{
			set{ _usersname=value;}
			get{return _usersname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? operate
		{
			set{ _operate=value;}
			get{return _operate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string value
		{
			set{ _value=value;}
			get{return _value;}
		}
		#endregion Model

	}
}

