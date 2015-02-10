﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwangRLibrary.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TwangR")]
	public partial class TwangRDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChatDB(ChatDB instance);
    partial void UpdateChatDB(ChatDB instance);
    partial void DeleteChatDB(ChatDB instance);
    partial void InsertLoginDB(LoginDB instance);
    partial void UpdateLoginDB(LoginDB instance);
    partial void DeleteLoginDB(LoginDB instance);
    #endregion
		
		public TwangRDataContext() : 
				base(global::TwangRLibrary.Properties.Settings.Default.TwangRConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TwangRDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TwangRDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TwangRDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TwangRDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ChatDB> ChatDBs
		{
			get
			{
				return this.GetTable<ChatDB>();
			}
		}
		
		public System.Data.Linq.Table<LoginDB> LoginDBs
		{
			get
			{
				return this.GetTable<LoginDB>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TwangR_user_login")]
		public ISingleResult<LoginDB> TwangR_user_login([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] ref string status)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password, status);
			status = ((string)(result.GetParameterValue(2)));
			return ((ISingleResult<LoginDB>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TwangR_user_register")]
		public ISingleResult<LoginDB> TwangR_user_register([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string userpassword, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string userRealName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string userEmail, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string userNickName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] ref string status)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, userpassword, userRealName, userEmail, userNickName, status);
			status = ((string)(result.GetParameterValue(5)));
			return ((ISingleResult<LoginDB>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TwangR_data_chatlogs")]
	public partial class ChatDB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MessageID;
		
		private string _MessageSender;
		
		private string _MessageContent;
		
		private string _MessageChat;
		
		private System.DateTime _MessageTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMessageIDChanging(string value);
    partial void OnMessageIDChanged();
    partial void OnMessageSenderChanging(string value);
    partial void OnMessageSenderChanged();
    partial void OnMessageContentChanging(string value);
    partial void OnMessageContentChanged();
    partial void OnMessageChatChanging(string value);
    partial void OnMessageChatChanged();
    partial void OnMessageTimeChanging(System.DateTime value);
    partial void OnMessageTimeChanged();
    #endregion
		
		public ChatDB()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MessageID
		{
			get
			{
				return this._MessageID;
			}
			set
			{
				if ((this._MessageID != value))
				{
					this.OnMessageIDChanging(value);
					this.SendPropertyChanging();
					this._MessageID = value;
					this.SendPropertyChanged("MessageID");
					this.OnMessageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageSender", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MessageSender
		{
			get
			{
				return this._MessageSender;
			}
			set
			{
				if ((this._MessageSender != value))
				{
					this.OnMessageSenderChanging(value);
					this.SendPropertyChanging();
					this._MessageSender = value;
					this.SendPropertyChanged("MessageSender");
					this.OnMessageSenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageContent", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MessageContent
		{
			get
			{
				return this._MessageContent;
			}
			set
			{
				if ((this._MessageContent != value))
				{
					this.OnMessageContentChanging(value);
					this.SendPropertyChanging();
					this._MessageContent = value;
					this.SendPropertyChanged("MessageContent");
					this.OnMessageContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageChat", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MessageChat
		{
			get
			{
				return this._MessageChat;
			}
			set
			{
				if ((this._MessageChat != value))
				{
					this.OnMessageChatChanging(value);
					this.SendPropertyChanging();
					this._MessageChat = value;
					this.SendPropertyChanged("MessageChat");
					this.OnMessageChatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageTime", DbType="DateTime NOT NULL")]
		public System.DateTime MessageTime
		{
			get
			{
				return this._MessageTime;
			}
			set
			{
				if ((this._MessageTime != value))
				{
					this.OnMessageTimeChanging(value);
					this.SendPropertyChanging();
					this._MessageTime = value;
					this.SendPropertyChanged("MessageTime");
					this.OnMessageTimeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TwangR_user_logindata")]
	public partial class LoginDB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _UserName;
		
		private string _PasswordHash;
		
		private string _UserEmail;
		
		private string _UserRealName;
		
		private string _UserNickName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordHashChanging(string value);
    partial void OnPasswordHashChanged();
    partial void OnUserEmailChanging(string value);
    partial void OnUserEmailChanged();
    partial void OnUserRealNameChanging(string value);
    partial void OnUserRealNameChanged();
    partial void OnUserNickNameChanging(string value);
    partial void OnUserNickNameChanged();
    #endregion
		
		public LoginDB()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordHash", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string PasswordHash
		{
			get
			{
				return this._PasswordHash;
			}
			set
			{
				if ((this._PasswordHash != value))
				{
					this.OnPasswordHashChanging(value);
					this.SendPropertyChanging();
					this._PasswordHash = value;
					this.SendPropertyChanged("PasswordHash");
					this.OnPasswordHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserEmail", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserEmail
		{
			get
			{
				return this._UserEmail;
			}
			set
			{
				if ((this._UserEmail != value))
				{
					this.OnUserEmailChanging(value);
					this.SendPropertyChanging();
					this._UserEmail = value;
					this.SendPropertyChanged("UserEmail");
					this.OnUserEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserRealName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserRealName
		{
			get
			{
				return this._UserRealName;
			}
			set
			{
				if ((this._UserRealName != value))
				{
					this.OnUserRealNameChanging(value);
					this.SendPropertyChanging();
					this._UserRealName = value;
					this.SendPropertyChanged("UserRealName");
					this.OnUserRealNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserNickName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserNickName
		{
			get
			{
				return this._UserNickName;
			}
			set
			{
				if ((this._UserNickName != value))
				{
					this.OnUserNickNameChanging(value);
					this.SendPropertyChanging();
					this._UserNickName = value;
					this.SendPropertyChanged("UserNickName");
					this.OnUserNickNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
