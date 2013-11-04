// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from dvdpost_mobile_api_ws on 2012-11-10 21:40:13Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace MobileDevicesService
{
	using System;
	using System.ComponentModel;
	using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	
	
	public partial class DVdPostMobileApIWS : DataContext
	{
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
		
		
		public DVdPostMobileApIWS(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public DVdPostMobileApIWS(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public DVdPostMobileApIWS(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<CtLGCentralMenu> CtLGCentralMenu
		{
			get
			{
				return this.GetTable<CtLGCentralMenu>();
			}
		}
		
		public Table<CtLGLeftMenu> CtLGLeftMenu
		{
			get
			{
				return this.GetTable<CtLGLeftMenu>();
			}
		}
		
		public Table<HpCategories> HpCategories
		{
			get
			{
				return this.GetTable<HpCategories>();
			}
		}
		
		public Table<HpMenu> HpMenu
		{
			get
			{
				return this.GetTable<HpMenu>();
			}
		}
		
		public Table<HpMovie> HpMovie
		{
			get
			{
				return this.GetTable<HpMovie>();
			}
		}
		
		public Table<HpTodayMovie> HpTodayMovie
		{
			get
			{
				return this.GetTable<HpTodayMovie>();
			}
		}
		
		public Table<HpTopTheme> HpTopTheme
		{
			get
			{
				return this.GetTable<HpTopTheme>();
			}
		}
		
		public Table<LandscapeOldImages> LandscapeOldImages
		{
			get
			{
				return this.GetTable<LandscapeOldImages>();
			}
		}
		
		public Table<MobileApplicationLog> MobileApplicationLog
		{
			get
			{
				return this.GetTable<MobileApplicationLog>();
			}
		}
		
		public Table<MobileLog> MobileLog
		{
			get
			{
				return this.GetTable<MobileLog>();
			}
		}
		
		public Table<MostRentedMovies> MostRentedMovies
		{
			get
			{
				return this.GetTable<MostRentedMovies>();
			}
		}
		
		public Table<MoviesRates> MoviesRates
		{
			get
			{
				return this.GetTable<MoviesRates>();
			}
		}
	}
	
	#region Start MONO_STRICT
#if MONO_STRICT

	public partial class DVdPostMobileApIWS
	{
		
		public DVdPostMobileApIWS(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
	#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT
	
	public partial class DVdPostMobileApIWS
	{
		
		public DVdPostMobileApIWS(IDbConnection connection) : 
				base(connection, new DbLinq.MySql.MySqlVendor())
		{
			this.OnCreated();
		}
		
		public DVdPostMobileApIWS(IDbConnection connection, IVendor sqlDialect) : 
				base(connection, sqlDialect)
		{
			this.OnCreated();
		}
		
		public DVdPostMobileApIWS(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
				base(connection, mappingSource, sqlDialect)
		{
			this.OnCreated();
		}
	}
	#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
	#endregion
	
	[Table(Name="dvdpost_mobile_api_ws.ctlg_central_menu")]
	public partial class CtLGCentralMenu : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<sbyte> _available;
		
		private int _id;
		
		private string _imG;
		
		private System.Nullable<int> _languageID;
		
		private string _methodUrl;
		
		private string _name;
		
		private System.Nullable<uint> _ordered;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAvailableChanged();
		
		partial void OnAvailableChanging(System.Nullable<sbyte> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnIMgChanged();
		
		partial void OnIMgChanging(string value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(System.Nullable<int> value);
		
		partial void OnMethodURLChanged();
		
		partial void OnMethodURLChanging(string value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnOrderedChanged();
		
		partial void OnOrderedChanging(System.Nullable<uint> value);
		#endregion
		
		
		public CtLGCentralMenu()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_available", Name="available", DbType="tinyint(4)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<sbyte> Available
		{
			get
			{
				return this._available;
			}
			set
			{
				if ((_available != value))
				{
					this.OnAvailableChanging(value);
					this.SendPropertyChanging();
					this._available = value;
					this.SendPropertyChanged("Available");
					this.OnAvailableChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_imG", Name="img", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string IMg
		{
			get
			{
				return this._imG;
			}
			set
			{
				if (((_imG == value) 
							== false))
				{
					this.OnIMgChanging(value);
					this.SendPropertyChanging();
					this._imG = value;
					this.SendPropertyChanged("IMg");
					this.OnIMgChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_methodUrl", Name="method_url", DbType="varchar(150)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MethodURL
		{
			get
			{
				return this._methodUrl;
			}
			set
			{
				if (((_methodUrl == value) 
							== false))
				{
					this.OnMethodURLChanging(value);
					this.SendPropertyChanging();
					this._methodUrl = value;
					this.SendPropertyChanged("MethodURL");
					this.OnMethodURLChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_ordered", Name="ordered", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> Ordered
		{
			get
			{
				return this._ordered;
			}
			set
			{
				if ((_ordered != value))
				{
					this.OnOrderedChanging(value);
					this.SendPropertyChanging();
					this._ordered = value;
					this.SendPropertyChanged("Ordered");
					this.OnOrderedChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dvdpost_mobile_api_ws.ctlg_left_menu")]
	public partial class CtLGLeftMenu : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<sbyte> _available;
		
		private int _id;
		
		private string _imG;
		
		private System.Nullable<int> _languageID;
		
		private string _methodUrl;
		
		private string _name;
		
		private System.Nullable<uint> _ordered;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAvailableChanged();
		
		partial void OnAvailableChanging(System.Nullable<sbyte> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnIMgChanged();
		
		partial void OnIMgChanging(string value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(System.Nullable<int> value);
		
		partial void OnMethodURLChanged();
		
		partial void OnMethodURLChanging(string value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnOrderedChanged();
		
		partial void OnOrderedChanging(System.Nullable<uint> value);
		#endregion
		
		
		public CtLGLeftMenu()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_available", Name="available", DbType="tinyint(4)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<sbyte> Available
		{
			get
			{
				return this._available;
			}
			set
			{
				if ((_available != value))
				{
					this.OnAvailableChanging(value);
					this.SendPropertyChanging();
					this._available = value;
					this.SendPropertyChanged("Available");
					this.OnAvailableChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_imG", Name="img", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string IMg
		{
			get
			{
				return this._imG;
			}
			set
			{
				if (((_imG == value) 
							== false))
				{
					this.OnIMgChanging(value);
					this.SendPropertyChanging();
					this._imG = value;
					this.SendPropertyChanged("IMg");
					this.OnIMgChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_methodUrl", Name="method_url", DbType="varchar(150)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MethodURL
		{
			get
			{
				return this._methodUrl;
			}
			set
			{
				if (((_methodUrl == value) 
							== false))
				{
					this.OnMethodURLChanging(value);
					this.SendPropertyChanging();
					this._methodUrl = value;
					this.SendPropertyChanged("MethodURL");
					this.OnMethodURLChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_ordered", Name="ordered", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> Ordered
		{
			get
			{
				return this._ordered;
			}
			set
			{
				if ((_ordered != value))
				{
					this.OnOrderedChanging(value);
					this.SendPropertyChanging();
					this._ordered = value;
					this.SendPropertyChanged("Ordered");
					this.OnOrderedChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dvdpost_mobile_api_ws.hp_categories")]
	public partial class HpCategories : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<sbyte> _available;
		
		private uint _id;
		
		private string _image;
		
		private System.Nullable<int> _languageID;
		
		private string _name;
		
		private System.Nullable<int> _ordered;
		
		private string _refClient;
		
		private System.Nullable<int> _refClientID;
		
		private string _refSource;
		
		private System.Nullable<int> _refSourceID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAvailableChanged();
		
		partial void OnAvailableChanging(System.Nullable<sbyte> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnImageChanged();
		
		partial void OnImageChanging(string value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(System.Nullable<int> value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnOrderedChanged();
		
		partial void OnOrderedChanging(System.Nullable<int> value);
		
		partial void OnRefClientChanged();
		
		partial void OnRefClientChanging(string value);
		
		partial void OnRefClientIDChanged();
		
		partial void OnRefClientIDChanging(System.Nullable<int> value);
		
		partial void OnRefSourceChanged();
		
		partial void OnRefSourceChanging(string value);
		
		partial void OnRefSourceIDChanged();
		
		partial void OnRefSourceIDChanging(System.Nullable<int> value);
		#endregion
		
		
		public HpCategories()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_available", Name="available", DbType="tinyint(4)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<sbyte> Available
		{
			get
			{
				return this._available;
			}
			set
			{
				if ((_available != value))
				{
					this.OnAvailableChanging(value);
					this.SendPropertyChanging();
					this._available = value;
					this.SendPropertyChanged("Available");
					this.OnAvailableChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_image", Name="image", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Image
		{
			get
			{
				return this._image;
			}
			set
			{
				if (((_image == value) 
							== false))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_ordered", Name="ordered", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Ordered
		{
			get
			{
				return this._ordered;
			}
			set
			{
				if ((_ordered != value))
				{
					this.OnOrderedChanging(value);
					this.SendPropertyChanging();
					this._ordered = value;
					this.SendPropertyChanged("Ordered");
					this.OnOrderedChanged();
				}
			}
		}
		
		[Column(Storage="_refClient", Name="ref_client", DbType="varchar(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RefClient
		{
			get
			{
				return this._refClient;
			}
			set
			{
				if (((_refClient == value) 
							== false))
				{
					this.OnRefClientChanging(value);
					this.SendPropertyChanging();
					this._refClient = value;
					this.SendPropertyChanged("RefClient");
					this.OnRefClientChanged();
				}
			}
		}
		
		[Column(Storage="_refClientID", Name="ref_client_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> RefClientID
		{
			get
			{
				return this._refClientID;
			}
			set
			{
				if ((_refClientID != value))
				{
					this.OnRefClientIDChanging(value);
					this.SendPropertyChanging();
					this._refClientID = value;
					this.SendPropertyChanged("RefClientID");
					this.OnRefClientIDChanged();
				}
			}
		}
		
		[Column(Storage="_refSource", Name="ref_source", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RefSource
		{
			get
			{
				return this._refSource;
			}
			set
			{
				if (((_refSource == value) 
							== false))
				{
					this.OnRefSourceChanging(value);
					this.SendPropertyChanging();
					this._refSource = value;
					this.SendPropertyChanged("RefSource");
					this.OnRefSourceChanged();
				}
			}
		}
		
		[Column(Storage="_refSourceID", Name="ref_source_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> RefSourceID
		{
			get
			{
				return this._refSourceID;
			}
			set
			{
				if ((_refSourceID != value))
				{
					this.OnRefSourceIDChanging(value);
					this.SendPropertyChanging();
					this._refSourceID = value;
					this.SendPropertyChanged("RefSourceID");
					this.OnRefSourceIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dvdpost_mobile_api_ws.hp_menu")]
	public partial class HpMenu : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<sbyte> _available;
		
		private int _id;
		
		private string _imG;
		
		private System.Nullable<int> _languageID;
		
		private string _methodUrl;
		
		private string _name;
		
		private System.Nullable<uint> _ordered;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAvailableChanged();
		
		partial void OnAvailableChanging(System.Nullable<sbyte> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnIMgChanged();
		
		partial void OnIMgChanging(string value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(System.Nullable<int> value);
		
		partial void OnMethodURLChanged();
		
		partial void OnMethodURLChanging(string value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnOrderedChanged();
		
		partial void OnOrderedChanging(System.Nullable<uint> value);
		#endregion
		
		
		public HpMenu()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_available", Name="available", DbType="tinyint(4)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<sbyte> Available
		{
			get
			{
				return this._available;
			}
			set
			{
				if ((_available != value))
				{
					this.OnAvailableChanging(value);
					this.SendPropertyChanging();
					this._available = value;
					this.SendPropertyChanged("Available");
					this.OnAvailableChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_imG", Name="img", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string IMg
		{
			get
			{
				return this._imG;
			}
			set
			{
				if (((_imG == value) 
							== false))
				{
					this.OnIMgChanging(value);
					this.SendPropertyChanging();
					this._imG = value;
					this.SendPropertyChanged("IMg");
					this.OnIMgChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_methodUrl", Name="method_url", DbType="varchar(150)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MethodURL
		{
			get
			{
				return this._methodUrl;
			}
			set
			{
				if (((_methodUrl == value) 
							== false))
				{
					this.OnMethodURLChanging(value);
					this.SendPropertyChanging();
					this._methodUrl = value;
					this.SendPropertyChanged("MethodURL");
					this.OnMethodURLChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_ordered", Name="ordered", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> Ordered
		{
			get
			{
				return this._ordered;
			}
			set
			{
				if ((_ordered != value))
				{
					this.OnOrderedChanging(value);
					this.SendPropertyChanging();
					this._ordered = value;
					this.SendPropertyChanged("Ordered");
					this.OnOrderedChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dvdpost_mobile_api_ws.hp_movie")]
	public partial class HpMovie
	{
		
		private string _awards;
		
		private string _broadcast;
		
		private string _dcRp;
		
		private System.Nullable<int> _diskID;
		
		private int _id;
		
		private System.Nullable<int> _imdBIdseRie;
		
		private string _imG;
		
		private string _kind;
		
		private System.Nullable<int> _lngID;
		
		private string _name;
		
		private System.Nullable<int> _ordered;
		
		private System.Nullable<decimal> _rate;
		
		private System.Nullable<int> _seasonID;
		
		private string _trailer;
		
		private System.Nullable<int> _voD;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAwardsChanged();
		
		partial void OnAwardsChanging(string value);
		
		partial void OnBroadcastChanged();
		
		partial void OnBroadcastChanging(string value);
		
		partial void OnDcRpChanged();
		
		partial void OnDcRpChanging(string value);
		
		partial void OnDiskIDChanged();
		
		partial void OnDiskIDChanging(System.Nullable<int> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnIMDbIDSErieChanged();
		
		partial void OnIMDbIDSErieChanging(System.Nullable<int> value);
		
		partial void OnIMgChanged();
		
		partial void OnIMgChanging(string value);
		
		partial void OnKindChanged();
		
		partial void OnKindChanging(string value);
		
		partial void OnLNGiDChanged();
		
		partial void OnLNGiDChanging(System.Nullable<int> value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnOrderedChanged();
		
		partial void OnOrderedChanging(System.Nullable<int> value);
		
		partial void OnRateChanged();
		
		partial void OnRateChanging(System.Nullable<decimal> value);
		
		partial void OnSeasonIDChanged();
		
		partial void OnSeasonIDChanging(System.Nullable<int> value);
		
		partial void OnTrailerChanged();
		
		partial void OnTrailerChanging(string value);
		
		partial void OnVOdChanged();
		
		partial void OnVOdChanging(System.Nullable<int> value);
		#endregion
		
		
		public HpMovie()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_awards", Name="awards", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Awards
		{
			get
			{
				return this._awards;
			}
			set
			{
				if (((_awards == value) 
							== false))
				{
					this.OnAwardsChanging(value);
					this._awards = value;
					this.OnAwardsChanged();
				}
			}
		}
		
		[Column(Storage="_broadcast", Name="broadcast", DbType="varchar(40)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Broadcast
		{
			get
			{
				return this._broadcast;
			}
			set
			{
				if (((_broadcast == value) 
							== false))
				{
					this.OnBroadcastChanging(value);
					this._broadcast = value;
					this.OnBroadcastChanged();
				}
			}
		}
		
		[Column(Storage="_dcRp", Name="dcrp", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DcRp
		{
			get
			{
				return this._dcRp;
			}
			set
			{
				if (((_dcRp == value) 
							== false))
				{
					this.OnDcRpChanging(value);
					this._dcRp = value;
					this.OnDcRpChanged();
				}
			}
		}
		
		[Column(Storage="_diskID", Name="disk_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> DiskID
		{
			get
			{
				return this._diskID;
			}
			set
			{
				if ((_diskID != value))
				{
					this.OnDiskIDChanging(value);
					this._diskID = value;
					this.OnDiskIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this._id = value;
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_imdBIdseRie", Name="imdb_id_serie", DbType="int(10)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IMDbIDSErie
		{
			get
			{
				return this._imdBIdseRie;
			}
			set
			{
				if ((_imdBIdseRie != value))
				{
					this.OnIMDbIDSErieChanging(value);
					this._imdBIdseRie = value;
					this.OnIMDbIDSErieChanged();
				}
			}
		}
		
		[Column(Storage="_imG", Name="img", DbType="varchar(50)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string IMg
		{
			get
			{
				return this._imG;
			}
			set
			{
				if (((_imG == value) 
							== false))
				{
					this.OnIMgChanging(value);
					this._imG = value;
					this.OnIMgChanged();
				}
			}
		}
		
		[Column(Storage="_kind", Name="kind", DbType="varchar(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				if (((_kind == value) 
							== false))
				{
					this.OnKindChanging(value);
					this._kind = value;
					this.OnKindChanged();
				}
			}
		}
		
		[Column(Storage="_lngID", Name="lngid", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LNGiD
		{
			get
			{
				return this._lngID;
			}
			set
			{
				if ((_lngID != value))
				{
					this.OnLNGiDChanging(value);
					this._lngID = value;
					this.OnLNGiDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_ordered", Name="ordered", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Ordered
		{
			get
			{
				return this._ordered;
			}
			set
			{
				if ((_ordered != value))
				{
					this.OnOrderedChanging(value);
					this._ordered = value;
					this.OnOrderedChanged();
				}
			}
		}
		
		[Column(Storage="_rate", Name="rate", DbType="decimal(2,1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Rate
		{
			get
			{
				return this._rate;
			}
			set
			{
				if ((_rate != value))
				{
					this.OnRateChanging(value);
					this._rate = value;
					this.OnRateChanged();
				}
			}
		}
		
		[Column(Storage="_seasonID", Name="season_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SeasonID
		{
			get
			{
				return this._seasonID;
			}
			set
			{
				if ((_seasonID != value))
				{
					this.OnSeasonIDChanging(value);
					this._seasonID = value;
					this.OnSeasonIDChanged();
				}
			}
		}
		
		[Column(Storage="_trailer", Name="trailer", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Trailer
		{
			get
			{
				return this._trailer;
			}
			set
			{
				if (((_trailer == value) 
							== false))
				{
					this.OnTrailerChanging(value);
					this._trailer = value;
					this.OnTrailerChanged();
				}
			}
		}
		
		[Column(Storage="_voD", Name="vod", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> VOd
		{
			get
			{
				return this._voD;
			}
			set
			{
				if ((_voD != value))
				{
					this.OnVOdChanging(value);
					this._voD = value;
					this.OnVOdChanged();
				}
			}
		}
	}
	
	[Table(Name="dvdpost_mobile_api_ws.hp_today_movie")]
	public partial class HpTodayMovie
	{
		
		private string _broadcast;
		
		private string _dcRp;
		
		private System.Nullable<long> _diskID;
		
		private int _id;
		
		private System.Nullable<int> _imdBIdseRie;
		
		private string _imG;
		
		private System.Nullable<int> _lngID;
		
		private string _name;
		
		private System.Nullable<int> _ordered;
		
		private System.Nullable<decimal> _rate;
		
		private System.Nullable<decimal> _seasonID;
		
		private string _trailer;
		
		private System.Nullable<int> _voD;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBroadcastChanged();
		
		partial void OnBroadcastChanging(string value);
		
		partial void OnDcRpChanged();
		
		partial void OnDcRpChanging(string value);
		
		partial void OnDiskIDChanged();
		
		partial void OnDiskIDChanging(System.Nullable<long> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnIMDbIDSErieChanged();
		
		partial void OnIMDbIDSErieChanging(System.Nullable<int> value);
		
		partial void OnIMgChanged();
		
		partial void OnIMgChanging(string value);
		
		partial void OnLNGiDChanged();
		
		partial void OnLNGiDChanging(System.Nullable<int> value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnOrderedChanged();
		
		partial void OnOrderedChanging(System.Nullable<int> value);
		
		partial void OnRateChanged();
		
		partial void OnRateChanging(System.Nullable<decimal> value);
		
		partial void OnSeasonIDChanged();
		
		partial void OnSeasonIDChanging(System.Nullable<decimal> value);
		
		partial void OnTrailerChanged();
		
		partial void OnTrailerChanging(string value);
		
		partial void OnVOdChanged();
		
		partial void OnVOdChanging(System.Nullable<int> value);
		#endregion
		
		
		public HpTodayMovie()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_broadcast", Name="broadcast", DbType="varchar(40)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Broadcast
		{
			get
			{
				return this._broadcast;
			}
			set
			{
				if (((_broadcast == value) 
							== false))
				{
					this.OnBroadcastChanging(value);
					this._broadcast = value;
					this.OnBroadcastChanged();
				}
			}
		}
		
		[Column(Storage="_dcRp", Name="dcrp", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DcRp
		{
			get
			{
				return this._dcRp;
			}
			set
			{
				if (((_dcRp == value) 
							== false))
				{
					this.OnDcRpChanging(value);
					this._dcRp = value;
					this.OnDcRpChanged();
				}
			}
		}
		
		[Column(Storage="_diskID", Name="disk_id", DbType="bigint", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> DiskID
		{
			get
			{
				return this._diskID;
			}
			set
			{
				if ((_diskID != value))
				{
					this.OnDiskIDChanging(value);
					this._diskID = value;
					this.OnDiskIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this._id = value;
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_imdBIdseRie", Name="imdb_id_serie", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IMDbIDSErie
		{
			get
			{
				return this._imdBIdseRie;
			}
			set
			{
				if ((_imdBIdseRie != value))
				{
					this.OnIMDbIDSErieChanging(value);
					this._imdBIdseRie = value;
					this.OnIMDbIDSErieChanged();
				}
			}
		}
		
		[Column(Storage="_imG", Name="img", DbType="varchar(50)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string IMg
		{
			get
			{
				return this._imG;
			}
			set
			{
				if (((_imG == value) 
							== false))
				{
					this.OnIMgChanging(value);
					this._imG = value;
					this.OnIMgChanged();
				}
			}
		}
		
		[Column(Storage="_lngID", Name="lngid", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LNGiD
		{
			get
			{
				return this._lngID;
			}
			set
			{
				if ((_lngID != value))
				{
					this.OnLNGiDChanging(value);
					this._lngID = value;
					this.OnLNGiDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_ordered", Name="ordered", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Ordered
		{
			get
			{
				return this._ordered;
			}
			set
			{
				if ((_ordered != value))
				{
					this.OnOrderedChanging(value);
					this._ordered = value;
					this.OnOrderedChanged();
				}
			}
		}
		
		[Column(Storage="_rate", Name="rate", DbType="decimal(2,1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Rate
		{
			get
			{
				return this._rate;
			}
			set
			{
				if ((_rate != value))
				{
					this.OnRateChanging(value);
					this._rate = value;
					this.OnRateChanged();
				}
			}
		}
		
		[Column(Storage="_seasonID", Name="season_id", DbType="decimal(11,0)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> SeasonID
		{
			get
			{
				return this._seasonID;
			}
			set
			{
				if ((_seasonID != value))
				{
					this.OnSeasonIDChanging(value);
					this._seasonID = value;
					this.OnSeasonIDChanged();
				}
			}
		}
		
		[Column(Storage="_trailer", Name="trailer", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Trailer
		{
			get
			{
				return this._trailer;
			}
			set
			{
				if (((_trailer == value) 
							== false))
				{
					this.OnTrailerChanging(value);
					this._trailer = value;
					this.OnTrailerChanged();
				}
			}
		}
		
		[Column(Storage="_voD", Name="vod", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> VOd
		{
			get
			{
				return this._voD;
			}
			set
			{
				if ((_voD != value))
				{
					this.OnVOdChanging(value);
					this._voD = value;
					this.OnVOdChanged();
				}
			}
		}
	}
	
	[Table(Name="dvdpost_mobile_api_ws.hp_top_theme")]
	public partial class HpTopTheme
	{
		
		private int _id;
		
		private string _kind;
		
		private System.Nullable<int> _lngID;
		
		private string _name;
		
		private System.Nullable<int> _ordered;
		
		private System.Nullable<int> _topThemeID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnKindChanged();
		
		partial void OnKindChanging(string value);
		
		partial void OnLNGiDChanged();
		
		partial void OnLNGiDChanging(System.Nullable<int> value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnOrderedChanged();
		
		partial void OnOrderedChanging(System.Nullable<int> value);
		
		partial void OnTopThemeIDChanged();
		
		partial void OnTopThemeIDChanging(System.Nullable<int> value);
		#endregion
		
		
		public HpTopTheme()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_id", Name="id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this._id = value;
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_kind", Name="kind", DbType="varchar(30)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				if (((_kind == value) 
							== false))
				{
					this.OnKindChanging(value);
					this._kind = value;
					this.OnKindChanged();
				}
			}
		}
		
		[Column(Storage="_lngID", Name="lngid", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LNGiD
		{
			get
			{
				return this._lngID;
			}
			set
			{
				if ((_lngID != value))
				{
					this.OnLNGiDChanging(value);
					this._lngID = value;
					this.OnLNGiDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_ordered", Name="ordered", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Ordered
		{
			get
			{
				return this._ordered;
			}
			set
			{
				if ((_ordered != value))
				{
					this.OnOrderedChanging(value);
					this._ordered = value;
					this.OnOrderedChanged();
				}
			}
		}
		
		[Column(Storage="_topThemeID", Name="topthemeid", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> TopThemeID
		{
			get
			{
				return this._topThemeID;
			}
			set
			{
				if ((_topThemeID != value))
				{
					this.OnTopThemeIDChanging(value);
					this._topThemeID = value;
					this.OnTopThemeIDChanged();
				}
			}
		}
	}
	
	[Table(Name="dvdpost_mobile_api_ws.landscape_old_images")]
	public partial class LandscapeOldImages : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _createdAt;
		
		private int _id;
		
		private string _image;
		
		private System.Nullable<int> _languageID;
		
		private string _refClient;
		
		private string _refEntity;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.Nullable<System.DateTime> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnImageChanged();
		
		partial void OnImageChanging(string value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(System.Nullable<int> value);
		
		partial void OnRefClientChanged();
		
		partial void OnRefClientChanging(string value);
		
		partial void OnRefEntityChanged();
		
		partial void OnRefEntityChanging(string value);
		#endregion
		
		
		public LandscapeOldImages()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="date", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_image", Name="image", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Image
		{
			get
			{
				return this._image;
			}
			set
			{
				if (((_image == value) 
							== false))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_refClient", Name="ref_client", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RefClient
		{
			get
			{
				return this._refClient;
			}
			set
			{
				if (((_refClient == value) 
							== false))
				{
					this.OnRefClientChanging(value);
					this.SendPropertyChanging();
					this._refClient = value;
					this.SendPropertyChanged("RefClient");
					this.OnRefClientChanged();
				}
			}
		}
		
		[Column(Storage="_refEntity", Name="ref_entity", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RefEntity
		{
			get
			{
				return this._refEntity;
			}
			set
			{
				if (((_refEntity == value) 
							== false))
				{
					this.OnRefEntityChanging(value);
					this.SendPropertyChanging();
					this._refEntity = value;
					this.SendPropertyChanged("RefEntity");
					this.OnRefEntityChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dvdpost_mobile_api_ws.mobile_application_log")]
	public partial class MobileApplicationLog : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _created;
		
		private System.Nullable<int> _customersID;
		
		private System.Nullable<int> _device;
		
		private uint _id;
		
		private string _message;
		
		private string _method;
		
		private string _parameters;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedChanged();
		
		partial void OnCreatedChanging(string value);
		
		partial void OnCustomersIDChanged();
		
		partial void OnCustomersIDChanging(System.Nullable<int> value);
		
		partial void OnDeviceChanged();
		
		partial void OnDeviceChanging(System.Nullable<int> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnMessageChanged();
		
		partial void OnMessageChanging(string value);
		
		partial void OnMethodChanged();
		
		partial void OnMethodChanging(string value);
		
		partial void OnParametersChanged();
		
		partial void OnParametersChanging(string value);
		#endregion
		
		
		public MobileApplicationLog()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_created", Name="created", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Created
		{
			get
			{
				return this._created;
			}
			set
			{
				if (((_created == value) 
							== false))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[Column(Storage="_customersID", Name="customers_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CustomersID
		{
			get
			{
				return this._customersID;
			}
			set
			{
				if ((_customersID != value))
				{
					this.OnCustomersIDChanging(value);
					this.SendPropertyChanging();
					this._customersID = value;
					this.SendPropertyChanged("CustomersID");
					this.OnCustomersIDChanged();
				}
			}
		}
		
		[Column(Storage="_device", Name="device", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Device
		{
			get
			{
				return this._device;
			}
			set
			{
				if ((_device != value))
				{
					this.OnDeviceChanging(value);
					this.SendPropertyChanging();
					this._device = value;
					this.SendPropertyChanged("Device");
					this.OnDeviceChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_message", Name="message", DbType="varchar(800)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Message
		{
			get
			{
				return this._message;
			}
			set
			{
				if (((_message == value) 
							== false))
				{
					this.OnMessageChanging(value);
					this.SendPropertyChanging();
					this._message = value;
					this.SendPropertyChanged("Message");
					this.OnMessageChanged();
				}
			}
		}
		
		[Column(Storage="_method", Name="method", DbType="varchar(200)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Method
		{
			get
			{
				return this._method;
			}
			set
			{
				if (((_method == value) 
							== false))
				{
					this.OnMethodChanging(value);
					this.SendPropertyChanging();
					this._method = value;
					this.SendPropertyChanged("Method");
					this.OnMethodChanged();
				}
			}
		}
		
		[Column(Storage="_parameters", Name="parameters", DbType="varchar(200)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Parameters
		{
			get
			{
				return this._parameters;
			}
			set
			{
				if (((_parameters == value) 
							== false))
				{
					this.OnParametersChanging(value);
					this.SendPropertyChanging();
					this._parameters = value;
					this.SendPropertyChanged("Parameters");
					this.OnParametersChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dvdpost_mobile_api_ws.mobile_log")]
	public partial class MobileLog : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _created;
		
		private System.Nullable<System.DateTime> _createdSystem;
		
		private System.Nullable<int> _customersID;
		
		private System.Nullable<int> _device;
		
		private uint _id;
		
		private string _method;
		
		private string _parameters;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedChanged();
		
		partial void OnCreatedChanging(string value);
		
		partial void OnCreatedSystemChanged();
		
		partial void OnCreatedSystemChanging(System.Nullable<System.DateTime> value);
		
		partial void OnCustomersIDChanged();
		
		partial void OnCustomersIDChanging(System.Nullable<int> value);
		
		partial void OnDeviceChanged();
		
		partial void OnDeviceChanging(System.Nullable<int> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnMethodChanged();
		
		partial void OnMethodChanging(string value);
		
		partial void OnParametersChanged();
		
		partial void OnParametersChanging(string value);
		#endregion
		
		
		public MobileLog()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_created", Name="created", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Created
		{
			get
			{
				return this._created;
			}
			set
			{
				if (((_created == value) 
							== false))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[Column(Storage="_createdSystem", Name="created_system", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedSystem
		{
			get
			{
				return this._createdSystem;
			}
			set
			{
				if ((_createdSystem != value))
				{
					this.OnCreatedSystemChanging(value);
					this.SendPropertyChanging();
					this._createdSystem = value;
					this.SendPropertyChanged("CreatedSystem");
					this.OnCreatedSystemChanged();
				}
			}
		}
		
		[Column(Storage="_customersID", Name="customers_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CustomersID
		{
			get
			{
				return this._customersID;
			}
			set
			{
				if ((_customersID != value))
				{
					this.OnCustomersIDChanging(value);
					this.SendPropertyChanging();
					this._customersID = value;
					this.SendPropertyChanged("CustomersID");
					this.OnCustomersIDChanged();
				}
			}
		}
		
		[Column(Storage="_device", Name="device", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Device
		{
			get
			{
				return this._device;
			}
			set
			{
				if ((_device != value))
				{
					this.OnDeviceChanging(value);
					this.SendPropertyChanging();
					this._device = value;
					this.SendPropertyChanged("Device");
					this.OnDeviceChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_method", Name="method", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Method
		{
			get
			{
				return this._method;
			}
			set
			{
				if (((_method == value) 
							== false))
				{
					this.OnMethodChanging(value);
					this.SendPropertyChanging();
					this._method = value;
					this.SendPropertyChanged("Method");
					this.OnMethodChanged();
				}
			}
		}
		
		[Column(Storage="_parameters", Name="parameters", DbType="varchar(200)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Parameters
		{
			get
			{
				return this._parameters;
			}
			set
			{
				if (((_parameters == value) 
							== false))
				{
					this.OnParametersChanging(value);
					this.SendPropertyChanging();
					this._parameters = value;
					this.SendPropertyChanged("Parameters");
					this.OnParametersChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dvdpost_mobile_api_ws.most_rented_movies")]
	public partial class MostRentedMovies
	{
		
		private string _broadcast;
		
		private string _dcRp;
		
		private System.Nullable<int> _diskID;
		
		private System.Nullable<uint> _imdBIdseRie;
		
		private string _imG;
		
		private System.Nullable<int> _languageID;
		
		private string _name;
		
		private System.Nullable<decimal> _rate;
		
		private System.Nullable<decimal> _seasonID;
		
		private string _trailer;
		
		private System.Nullable<int> _voD;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBroadcastChanged();
		
		partial void OnBroadcastChanging(string value);
		
		partial void OnDcRpChanged();
		
		partial void OnDcRpChanging(string value);
		
		partial void OnDiskIDChanged();
		
		partial void OnDiskIDChanging(System.Nullable<int> value);
		
		partial void OnIMDbIDSErieChanged();
		
		partial void OnIMDbIDSErieChanging(System.Nullable<uint> value);
		
		partial void OnIMgChanged();
		
		partial void OnIMgChanging(string value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(System.Nullable<int> value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnRateChanged();
		
		partial void OnRateChanging(System.Nullable<decimal> value);
		
		partial void OnSeasonIDChanged();
		
		partial void OnSeasonIDChanging(System.Nullable<decimal> value);
		
		partial void OnTrailerChanged();
		
		partial void OnTrailerChanging(string value);
		
		partial void OnVOdChanged();
		
		partial void OnVOdChanging(System.Nullable<int> value);
		#endregion
		
		
		public MostRentedMovies()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_broadcast", Name="broadcast", DbType="varchar(40)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Broadcast
		{
			get
			{
				return this._broadcast;
			}
			set
			{
				if (((_broadcast == value) 
							== false))
				{
					this.OnBroadcastChanging(value);
					this._broadcast = value;
					this.OnBroadcastChanged();
				}
			}
		}
		
		[Column(Storage="_dcRp", Name="dcrp", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DcRp
		{
			get
			{
				return this._dcRp;
			}
			set
			{
				if (((_dcRp == value) 
							== false))
				{
					this.OnDcRpChanging(value);
					this._dcRp = value;
					this.OnDcRpChanged();
				}
			}
		}
		
		[Column(Storage="_diskID", Name="disk_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> DiskID
		{
			get
			{
				return this._diskID;
			}
			set
			{
				if ((_diskID != value))
				{
					this.OnDiskIDChanging(value);
					this._diskID = value;
					this.OnDiskIDChanged();
				}
			}
		}
		
		[Column(Storage="_imdBIdseRie", Name="imdb_id_serie", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> IMDbIDSErie
		{
			get
			{
				return this._imdBIdseRie;
			}
			set
			{
				if ((_imdBIdseRie != value))
				{
					this.OnIMDbIDSErieChanging(value);
					this._imdBIdseRie = value;
					this.OnIMDbIDSErieChanged();
				}
			}
		}
		
		[Column(Storage="_imG", Name="img", DbType="varchar(500)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string IMg
		{
			get
			{
				return this._imG;
			}
			set
			{
				if (((_imG == value) 
							== false))
				{
					this.OnIMgChanging(value);
					this._imG = value;
					this.OnIMgChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this._languageID = value;
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_rate", Name="rate", DbType="decimal(2,1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Rate
		{
			get
			{
				return this._rate;
			}
			set
			{
				if ((_rate != value))
				{
					this.OnRateChanging(value);
					this._rate = value;
					this.OnRateChanged();
				}
			}
		}
		
		[Column(Storage="_seasonID", Name="season_id", DbType="decimal(11,0)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> SeasonID
		{
			get
			{
				return this._seasonID;
			}
			set
			{
				if ((_seasonID != value))
				{
					this.OnSeasonIDChanging(value);
					this._seasonID = value;
					this.OnSeasonIDChanged();
				}
			}
		}
		
		[Column(Storage="_trailer", Name="trailer", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Trailer
		{
			get
			{
				return this._trailer;
			}
			set
			{
				if (((_trailer == value) 
							== false))
				{
					this.OnTrailerChanging(value);
					this._trailer = value;
					this.OnTrailerChanged();
				}
			}
		}
		
		[Column(Storage="_voD", Name="vod", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> VOd
		{
			get
			{
				return this._voD;
			}
			set
			{
				if ((_voD != value))
				{
					this.OnVOdChanging(value);
					this._voD = value;
					this.OnVOdChanged();
				}
			}
		}
	}
	
	[Table(Name="dvdpost_mobile_api_ws.movies_rates")]
	public partial class MoviesRates : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _imdBID;
		
		private System.Nullable<decimal> _rate;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIMDbIDChanged();
		
		partial void OnIMDbIDChanging(int value);
		
		partial void OnRateChanged();
		
		partial void OnRateChanging(System.Nullable<decimal> value);
		#endregion
		
		
		public MoviesRates()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_imdBID", Name="imdb_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IMDbID
		{
			get
			{
				return this._imdBID;
			}
			set
			{
				if ((_imdBID != value))
				{
					this.OnIMDbIDChanging(value);
					this.SendPropertyChanging();
					this._imdBID = value;
					this.SendPropertyChanged("IMDbID");
					this.OnIMDbIDChanged();
				}
			}
		}
		
		[Column(Storage="_rate", Name="rate", DbType="decimal(3,2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Rate
		{
			get
			{
				return this._rate;
			}
			set
			{
				if ((_rate != value))
				{
					this.OnRateChanging(value);
					this.SendPropertyChanging();
					this._rate = value;
					this.SendPropertyChanged("Rate");
					this.OnRateChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
