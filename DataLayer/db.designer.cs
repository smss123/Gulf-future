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

namespace DataLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Web_GulfFuture")]
	public partial class dbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAboutUs(AboutUs instance);
    partial void UpdateAboutUs(AboutUs instance);
    partial void DeleteAboutUs(AboutUs instance);
    partial void InsertContactUs(ContactUs instance);
    partial void UpdateContactUs(ContactUs instance);
    partial void DeleteContactUs(ContactUs instance);
    partial void InsertSilder(Silder instance);
    partial void UpdateSilder(Silder instance);
    partial void DeleteSilder(Silder instance);
    partial void InsertSoicalNetwork(SoicalNetwork instance);
    partial void UpdateSoicalNetwork(SoicalNetwork instance);
    partial void DeleteSoicalNetwork(SoicalNetwork instance);
    partial void InsertsysUser(sysUser instance);
    partial void UpdatesysUser(sysUser instance);
    partial void DeletesysUser(sysUser instance);
    #endregion
		
		public dbDataContext() : 
				base(global::DataLayer.Properties.Settings.Default.Web_GulfFutureConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AboutUs> AboutUs
		{
			get
			{
				return this.GetTable<AboutUs>();
			}
		}
		
		public System.Data.Linq.Table<OurService> OurServices
		{
			get
			{
				return this.GetTable<OurService>();
			}
		}
		
		public System.Data.Linq.Table<ContactUs> ContactUs
		{
			get
			{
				return this.GetTable<ContactUs>();
			}
		}
		
		public System.Data.Linq.Table<Silder> Silders
		{
			get
			{
				return this.GetTable<Silder>();
			}
		}
		
		public System.Data.Linq.Table<SiteInfo> SiteInfos
		{
			get
			{
				return this.GetTable<SiteInfo>();
			}
		}
		
		public System.Data.Linq.Table<SoicalNetwork> SoicalNetworks
		{
			get
			{
				return this.GetTable<SoicalNetwork>();
			}
		}
		
		public System.Data.Linq.Table<sysUser> sysUsers
		{
			get
			{
				return this.GetTable<sysUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AboutUs")]
	public partial class AboutUs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _AboutUsAr;
		
		private string _AboutEn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnAboutUsArChanging(string value);
    partial void OnAboutUsArChanged();
    partial void OnAboutEnChanging(string value);
    partial void OnAboutEnChanged();
    #endregion
		
		public AboutUs()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutUsAr", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string AboutUsAr
		{
			get
			{
				return this._AboutUsAr;
			}
			set
			{
				if ((this._AboutUsAr != value))
				{
					this.OnAboutUsArChanging(value);
					this.SendPropertyChanging();
					this._AboutUsAr = value;
					this.SendPropertyChanged("AboutUsAr");
					this.OnAboutUsArChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutEn", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string AboutEn
		{
			get
			{
				return this._AboutEn;
			}
			set
			{
				if ((this._AboutEn != value))
				{
					this.OnAboutEnChanging(value);
					this.SendPropertyChanging();
					this._AboutEn = value;
					this.SendPropertyChanged("AboutEn");
					this.OnAboutEnChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OurService")]
	public partial class OurService
	{
		
		private int _id;
		
		private string _OurServiceAr;
		
		private string _OurServiceEn;
		
		public OurService()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServiceAr", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string OurServiceAr
		{
			get
			{
				return this._OurServiceAr;
			}
			set
			{
				if ((this._OurServiceAr != value))
				{
					this._OurServiceAr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServiceEn", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string OurServiceEn
		{
			get
			{
				return this._OurServiceEn;
			}
			set
			{
				if ((this._OurServiceEn != value))
				{
					this._OurServiceEn = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ContactUs")]
	public partial class ContactUs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _PostBox;
		
		private string _PostKey;
		
		private string _AddressAr;
		
		private string _AdressEn;
		
		private string _DefaultSendEmail;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnPostBoxChanging(string value);
    partial void OnPostBoxChanged();
    partial void OnPostKeyChanging(string value);
    partial void OnPostKeyChanged();
    partial void OnAddressArChanging(string value);
    partial void OnAddressArChanged();
    partial void OnAdressEnChanging(string value);
    partial void OnAdressEnChanged();
    partial void OnDefaultSendEmailChanging(string value);
    partial void OnDefaultSendEmailChanged();
    #endregion
		
		public ContactUs()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostBox", DbType="NVarChar(50)")]
		public string PostBox
		{
			get
			{
				return this._PostBox;
			}
			set
			{
				if ((this._PostBox != value))
				{
					this.OnPostBoxChanging(value);
					this.SendPropertyChanging();
					this._PostBox = value;
					this.SendPropertyChanged("PostBox");
					this.OnPostBoxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostKey", DbType="NVarChar(50)")]
		public string PostKey
		{
			get
			{
				return this._PostKey;
			}
			set
			{
				if ((this._PostKey != value))
				{
					this.OnPostKeyChanging(value);
					this.SendPropertyChanging();
					this._PostKey = value;
					this.SendPropertyChanged("PostKey");
					this.OnPostKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressAr", DbType="NVarChar(MAX)")]
		public string AddressAr
		{
			get
			{
				return this._AddressAr;
			}
			set
			{
				if ((this._AddressAr != value))
				{
					this.OnAddressArChanging(value);
					this.SendPropertyChanging();
					this._AddressAr = value;
					this.SendPropertyChanged("AddressAr");
					this.OnAddressArChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdressEn", DbType="NVarChar(MAX)")]
		public string AdressEn
		{
			get
			{
				return this._AdressEn;
			}
			set
			{
				if ((this._AdressEn != value))
				{
					this.OnAdressEnChanging(value);
					this.SendPropertyChanging();
					this._AdressEn = value;
					this.SendPropertyChanged("AdressEn");
					this.OnAdressEnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DefaultSendEmail", DbType="NVarChar(150)")]
		public string DefaultSendEmail
		{
			get
			{
				return this._DefaultSendEmail;
			}
			set
			{
				if ((this._DefaultSendEmail != value))
				{
					this.OnDefaultSendEmailChanging(value);
					this.SendPropertyChanging();
					this._DefaultSendEmail = value;
					this.SendPropertyChanged("DefaultSendEmail");
					this.OnDefaultSendEmailChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Silders")]
	public partial class Silder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _SildeImagePathAr;
		
		private string _SileImagePathEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSildeImagePathArChanging(string value);
    partial void OnSildeImagePathArChanged();
    partial void OnSileImagePathENChanging(string value);
    partial void OnSileImagePathENChanged();
    #endregion
		
		public Silder()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SildeImagePathAr", DbType="NVarChar(500)")]
		public string SildeImagePathAr
		{
			get
			{
				return this._SildeImagePathAr;
			}
			set
			{
				if ((this._SildeImagePathAr != value))
				{
					this.OnSildeImagePathArChanging(value);
					this.SendPropertyChanging();
					this._SildeImagePathAr = value;
					this.SendPropertyChanged("SildeImagePathAr");
					this.OnSildeImagePathArChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SileImagePathEN", DbType="NVarChar(500)")]
		public string SileImagePathEN
		{
			get
			{
				return this._SileImagePathEN;
			}
			set
			{
				if ((this._SileImagePathEN != value))
				{
					this.OnSileImagePathENChanging(value);
					this.SendPropertyChanging();
					this._SileImagePathEN = value;
					this.SendPropertyChanged("SileImagePathEN");
					this.OnSileImagePathENChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SiteInfo")]
	public partial class SiteInfo
	{
		
		private string _SiteNameAr;
		
		private string _SiteNameEn;
		
		private string _SiteDescriptionAr;
		
		private string _SiteDescriptionEn;
		
		private string _Tags;
		
		private string _PhoneNumbers;
		
		private string _Emails;
		
		private int _ID;
		
		public SiteInfo()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteNameAr", DbType="NVarChar(50)")]
		public string SiteNameAr
		{
			get
			{
				return this._SiteNameAr;
			}
			set
			{
				if ((this._SiteNameAr != value))
				{
					this._SiteNameAr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteNameEn", DbType="NVarChar(50)")]
		public string SiteNameEn
		{
			get
			{
				return this._SiteNameEn;
			}
			set
			{
				if ((this._SiteNameEn != value))
				{
					this._SiteNameEn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteDescriptionAr", DbType="NVarChar(MAX)")]
		public string SiteDescriptionAr
		{
			get
			{
				return this._SiteDescriptionAr;
			}
			set
			{
				if ((this._SiteDescriptionAr != value))
				{
					this._SiteDescriptionAr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteDescriptionEn", DbType="NVarChar(MAX)")]
		public string SiteDescriptionEn
		{
			get
			{
				return this._SiteDescriptionEn;
			}
			set
			{
				if ((this._SiteDescriptionEn != value))
				{
					this._SiteDescriptionEn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tags", DbType="NVarChar(MAX)")]
		public string Tags
		{
			get
			{
				return this._Tags;
			}
			set
			{
				if ((this._Tags != value))
				{
					this._Tags = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumbers", DbType="NVarChar(150)")]
		public string PhoneNumbers
		{
			get
			{
				return this._PhoneNumbers;
			}
			set
			{
				if ((this._PhoneNumbers != value))
				{
					this._PhoneNumbers = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emails", DbType="NVarChar(150)")]
		public string Emails
		{
			get
			{
				return this._Emails;
			}
			set
			{
				if ((this._Emails != value))
				{
					this._Emails = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SoicalNetworks")]
	public partial class SoicalNetwork : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _SnameAr;
		
		private string _SAltAr;
		
		private string _SUrl;
		
		private string _SnameEn;
		
		private string _SaltEn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnSnameArChanging(string value);
    partial void OnSnameArChanged();
    partial void OnSAltArChanging(string value);
    partial void OnSAltArChanged();
    partial void OnSUrlChanging(string value);
    partial void OnSUrlChanged();
    partial void OnSnameEnChanging(string value);
    partial void OnSnameEnChanged();
    partial void OnSaltEnChanging(string value);
    partial void OnSaltEnChanged();
    #endregion
		
		public SoicalNetwork()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SnameAr", DbType="NVarChar(50)")]
		public string SnameAr
		{
			get
			{
				return this._SnameAr;
			}
			set
			{
				if ((this._SnameAr != value))
				{
					this.OnSnameArChanging(value);
					this.SendPropertyChanging();
					this._SnameAr = value;
					this.SendPropertyChanged("SnameAr");
					this.OnSnameArChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SAltAr", DbType="NVarChar(50)")]
		public string SAltAr
		{
			get
			{
				return this._SAltAr;
			}
			set
			{
				if ((this._SAltAr != value))
				{
					this.OnSAltArChanging(value);
					this.SendPropertyChanging();
					this._SAltAr = value;
					this.SendPropertyChanged("SAltAr");
					this.OnSAltArChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SUrl", DbType="NVarChar(150)")]
		public string SUrl
		{
			get
			{
				return this._SUrl;
			}
			set
			{
				if ((this._SUrl != value))
				{
					this.OnSUrlChanging(value);
					this.SendPropertyChanging();
					this._SUrl = value;
					this.SendPropertyChanged("SUrl");
					this.OnSUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SnameEn", DbType="NVarChar(50)")]
		public string SnameEn
		{
			get
			{
				return this._SnameEn;
			}
			set
			{
				if ((this._SnameEn != value))
				{
					this.OnSnameEnChanging(value);
					this.SendPropertyChanging();
					this._SnameEn = value;
					this.SendPropertyChanged("SnameEn");
					this.OnSnameEnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SaltEn", DbType="NVarChar(50)")]
		public string SaltEn
		{
			get
			{
				return this._SaltEn;
			}
			set
			{
				if ((this._SaltEn != value))
				{
					this.OnSaltEnChanging(value);
					this.SendPropertyChanging();
					this._SaltEn = value;
					this.SendPropertyChanged("SaltEn");
					this.OnSaltEnChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.sysUser")]
	public partial class sysUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _UserName;
		
		private string _Pwd;
		
		private string _Email;
		
		private string _FullName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPwdChanging(string value);
    partial void OnPwdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    #endregion
		
		public sysUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pwd", DbType="NVarChar(50)")]
		public string Pwd
		{
			get
			{
				return this._Pwd;
			}
			set
			{
				if ((this._Pwd != value))
				{
					this.OnPwdChanging(value);
					this.SendPropertyChanging();
					this._Pwd = value;
					this.SendPropertyChanged("Pwd");
					this.OnPwdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(150)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(500)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
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
