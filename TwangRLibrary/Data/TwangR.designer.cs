﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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
    partial void InsertFriendDB(FriendDB instance);
    partial void UpdateFriendDB(FriendDB instance);
    partial void DeleteFriendDB(FriendDB instance);
    partial void InsertStatusDB(StatusDB instance);
    partial void UpdateStatusDB(StatusDB instance);
    partial void DeleteStatusDB(StatusDB instance);
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
		
		public System.Data.Linq.Table<FriendDB> FriendDBs
		{
			get
			{
				return this.GetTable<FriendDB>();
			}
		}
		
		public System.Data.Linq.Table<StatusDB> StatusDBs
		{
			get
			{
				return this.GetTable<StatusDB>();
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
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TwangR_user_GetFriendList")]
		public ISingleResult<LoginDB> TwangR_user_GetFriendList([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> userId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userId);
			return ((ISingleResult<LoginDB>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TwangR_data_acceptfriendrequest", IsComposable=true)]
		public object TwangR_data_acceptfriendrequest([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> sender, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> requestee)
		{
			return ((object)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sender, requestee).ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TwangR_data_logfriendrequest", IsComposable=true)]
		public object TwangR_data_logfriendrequest([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> sender, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> requestee)
		{
			return ((object)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sender, requestee).ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TwangR_data_insertnewpost", IsComposable=true)]
		public System.Nullable<int> TwangR_data_insertnewpost([global::System.Data.Linq.Mapping.ParameterAttribute(Name="StatusContent", DbType="VarChar(MAX)")] string statusContent, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserID", DbType="Int")] System.Nullable<int> userID)
		{
			return ((System.Nullable<int>)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), statusContent, userID).ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TwangR_data_getallpostsbyuser")]
		public ISingleResult<StatusDB> TwangR_data_getallpostsbyuser([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserID", DbType="Int")] System.Nullable<int> userID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userID);
			return ((ISingleResult<StatusDB>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TwangR_data_getnewsfeed")]
		public ISingleResult<StatusDB> TwangR_data_getnewsfeed([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> userID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userID);
			return ((ISingleResult<StatusDB>)(result.ReturnValue));
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
		
		private EntitySet<FriendDB> _TwangR_data_Friends;
		
		private EntitySet<FriendDB> _FriendDBs;
		
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
			this._TwangR_data_Friends = new EntitySet<FriendDB>(new Action<FriendDB>(this.attach_TwangR_data_Friends), new Action<FriendDB>(this.detach_TwangR_data_Friends));
			this._FriendDBs = new EntitySet<FriendDB>(new Action<FriendDB>(this.attach_FriendDBs), new Action<FriendDB>(this.detach_FriendDBs));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginDB_FriendDB", Storage="_TwangR_data_Friends", ThisKey="UserID", OtherKey="User1")]
		public EntitySet<FriendDB> TwangR_data_Friends
		{
			get
			{
				return this._TwangR_data_Friends;
			}
			set
			{
				this._TwangR_data_Friends.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginDB_FriendDB1", Storage="_FriendDBs", ThisKey="UserID", OtherKey="User2")]
		public EntitySet<FriendDB> FriendDBs
		{
			get
			{
				return this._FriendDBs;
			}
			set
			{
				this._FriendDBs.Assign(value);
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
		
		private void attach_TwangR_data_Friends(FriendDB entity)
		{
			this.SendPropertyChanging();
			entity.LoginDB = this;
		}
		
		private void detach_TwangR_data_Friends(FriendDB entity)
		{
			this.SendPropertyChanging();
			entity.LoginDB = null;
		}
		
		private void attach_FriendDBs(FriendDB entity)
		{
			this.SendPropertyChanging();
			entity.LoginDB1 = this;
		}
		
		private void detach_FriendDBs(FriendDB entity)
		{
			this.SendPropertyChanging();
			entity.LoginDB1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TwangR_data_Friends")]
	public partial class FriendDB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _User1;
		
		private int _User2;
		
		private System.DateTime _RequstDate;
		
		private System.Nullable<System.DateTime> _AcceptDate;
		
		private System.Nullable<int> _Sender;
		
		private EntityRef<LoginDB> _LoginDB;
		
		private EntityRef<LoginDB> _LoginDB1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser1Changing(int value);
    partial void OnUser1Changed();
    partial void OnUser2Changing(int value);
    partial void OnUser2Changed();
    partial void OnRequstDateChanging(System.DateTime value);
    partial void OnRequstDateChanged();
    partial void OnAcceptDateChanging(System.Nullable<System.DateTime> value);
    partial void OnAcceptDateChanged();
    partial void OnSenderChanging(System.Nullable<int> value);
    partial void OnSenderChanged();
    #endregion
		
		public FriendDB()
		{
			this._LoginDB = default(EntityRef<LoginDB>);
			this._LoginDB1 = default(EntityRef<LoginDB>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User1", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int User1
		{
			get
			{
				return this._User1;
			}
			set
			{
				if ((this._User1 != value))
				{
					if (this._LoginDB.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser1Changing(value);
					this.SendPropertyChanging();
					this._User1 = value;
					this.SendPropertyChanged("User1");
					this.OnUser1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User2", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int User2
		{
			get
			{
				return this._User2;
			}
			set
			{
				if ((this._User2 != value))
				{
					if (this._LoginDB1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser2Changing(value);
					this.SendPropertyChanging();
					this._User2 = value;
					this.SendPropertyChanged("User2");
					this.OnUser2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RequstDate", DbType="DateTime NOT NULL")]
		public System.DateTime RequstDate
		{
			get
			{
				return this._RequstDate;
			}
			set
			{
				if ((this._RequstDate != value))
				{
					this.OnRequstDateChanging(value);
					this.SendPropertyChanging();
					this._RequstDate = value;
					this.SendPropertyChanged("RequstDate");
					this.OnRequstDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AcceptDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> AcceptDate
		{
			get
			{
				return this._AcceptDate;
			}
			set
			{
				if ((this._AcceptDate != value))
				{
					this.OnAcceptDateChanging(value);
					this.SendPropertyChanging();
					this._AcceptDate = value;
					this.SendPropertyChanged("AcceptDate");
					this.OnAcceptDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sender", DbType="Int")]
		public System.Nullable<int> Sender
		{
			get
			{
				return this._Sender;
			}
			set
			{
				if ((this._Sender != value))
				{
					this.OnSenderChanging(value);
					this.SendPropertyChanging();
					this._Sender = value;
					this.SendPropertyChanged("Sender");
					this.OnSenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginDB_FriendDB", Storage="_LoginDB", ThisKey="User1", OtherKey="UserID", IsForeignKey=true)]
		public LoginDB LoginDB
		{
			get
			{
				return this._LoginDB.Entity;
			}
			set
			{
				LoginDB previousValue = this._LoginDB.Entity;
				if (((previousValue != value) 
							|| (this._LoginDB.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoginDB.Entity = null;
						previousValue.TwangR_data_Friends.Remove(this);
					}
					this._LoginDB.Entity = value;
					if ((value != null))
					{
						value.TwangR_data_Friends.Add(this);
						this._User1 = value.UserID;
					}
					else
					{
						this._User1 = default(int);
					}
					this.SendPropertyChanged("LoginDB");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginDB_FriendDB1", Storage="_LoginDB1", ThisKey="User2", OtherKey="UserID", IsForeignKey=true)]
		public LoginDB LoginDB1
		{
			get
			{
				return this._LoginDB1.Entity;
			}
			set
			{
				LoginDB previousValue = this._LoginDB1.Entity;
				if (((previousValue != value) 
							|| (this._LoginDB1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoginDB1.Entity = null;
						previousValue.FriendDBs.Remove(this);
					}
					this._LoginDB1.Entity = value;
					if ((value != null))
					{
						value.FriendDBs.Add(this);
						this._User2 = value.UserID;
					}
					else
					{
						this._User2 = default(int);
					}
					this.SendPropertyChanged("LoginDB1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TwangR_data_Status")]
	public partial class StatusDB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StatusID;
		
		private string _StatusContent;
		
		private int _StatusAuthorID;
		
		private string _StatusAuthor;
		
		private int _StatusLikes;
		
		private System.DateTime _Logdate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStatusIDChanging(int value);
    partial void OnStatusIDChanged();
    partial void OnStatusContentChanging(string value);
    partial void OnStatusContentChanged();
    partial void OnStatusAuthorIDChanging(int value);
    partial void OnStatusAuthorIDChanged();
    partial void OnStatusAuthorChanging(string value);
    partial void OnStatusAuthorChanged();
    partial void OnStatusLikesChanging(int value);
    partial void OnStatusLikesChanged();
    partial void OnLogdateChanging(System.DateTime value);
    partial void OnLogdateChanged();
    #endregion
		
		public StatusDB()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int StatusID
		{
			get
			{
				return this._StatusID;
			}
			set
			{
				if ((this._StatusID != value))
				{
					this.OnStatusIDChanging(value);
					this.SendPropertyChanging();
					this._StatusID = value;
					this.SendPropertyChanged("StatusID");
					this.OnStatusIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusContent", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string StatusContent
		{
			get
			{
				return this._StatusContent;
			}
			set
			{
				if ((this._StatusContent != value))
				{
					this.OnStatusContentChanging(value);
					this.SendPropertyChanging();
					this._StatusContent = value;
					this.SendPropertyChanged("StatusContent");
					this.OnStatusContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusAuthorID", DbType="Int NOT NULL")]
		public int StatusAuthorID
		{
			get
			{
				return this._StatusAuthorID;
			}
			set
			{
				if ((this._StatusAuthorID != value))
				{
					this.OnStatusAuthorIDChanging(value);
					this.SendPropertyChanging();
					this._StatusAuthorID = value;
					this.SendPropertyChanged("StatusAuthorID");
					this.OnStatusAuthorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusAuthor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string StatusAuthor
		{
			get
			{
				return this._StatusAuthor;
			}
			set
			{
				if ((this._StatusAuthor != value))
				{
					this.OnStatusAuthorChanging(value);
					this.SendPropertyChanging();
					this._StatusAuthor = value;
					this.SendPropertyChanged("StatusAuthor");
					this.OnStatusAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusLikes", DbType="Int NOT NULL")]
		public int StatusLikes
		{
			get
			{
				return this._StatusLikes;
			}
			set
			{
				if ((this._StatusLikes != value))
				{
					this.OnStatusLikesChanging(value);
					this.SendPropertyChanging();
					this._StatusLikes = value;
					this.SendPropertyChanged("StatusLikes");
					this.OnStatusLikesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Logdate", DbType="DateTime NOT NULL")]
		public System.DateTime Logdate
		{
			get
			{
				return this._Logdate;
			}
			set
			{
				if ((this._Logdate != value))
				{
					this.OnLogdateChanging(value);
					this.SendPropertyChanging();
					this._Logdate = value;
					this.SendPropertyChanged("Logdate");
					this.OnLogdateChanged();
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
