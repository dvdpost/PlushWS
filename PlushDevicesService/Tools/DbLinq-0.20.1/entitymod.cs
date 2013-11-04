// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from new_dvdpost_be_test on 2011-10-25 22:51:46Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace entitymod
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
	
	
	public partial class NewDVdPostBeTest : DataContext
	{
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
		
		
		public NewDVdPostBeTest(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public NewDVdPostBeTest(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public NewDVdPostBeTest(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<Actors> Actors
		{
			get
			{
				return this.GetTable<Actors>();
			}
		}
		
		public Table<ActorsMovies> ActorsMovies
		{
			get
			{
				return this.GetTable<ActorsMovies>();
			}
		}
		
		public Table<Directors> Directors
		{
			get
			{
				return this.GetTable<Directors>();
			}
		}
		
		public Table<Languages> Languages
		{
			get
			{
				return this.GetTable<Languages>();
			}
		}
		
		public Table<LanguagesProducts> LanguagesProducts
		{
			get
			{
				return this.GetTable<LanguagesProducts>();
			}
		}
		
		public Table<MovieDescriptions> MovieDescriptions
		{
			get
			{
				return this.GetTable<MovieDescriptions>();
			}
		}
		
		public Table<MovieKind> MovieKind
		{
			get
			{
				return this.GetTable<MovieKind>();
			}
		}
		
		public Table<Movies> Movies
		{
			get
			{
				return this.GetTable<Movies>();
			}
		}
		
		public Table<MovieTypes> MovieTypes
		{
			get
			{
				return this.GetTable<MovieTypes>();
			}
		}
		
		public Table<ProductDisks> ProductDisks
		{
			get
			{
				return this.GetTable<ProductDisks>();
			}
		}
		
		public Table<ProductDVdStatus> ProductDVdStatus
		{
			get
			{
				return this.GetTable<ProductDVdStatus>();
			}
		}
		
		public Table<ProductDVdWhere> ProductDVdWhere
		{
			get
			{
				return this.GetTable<ProductDVdWhere>();
			}
		}
		
		public Table<ProductQualities> ProductQualities
		{
			get
			{
				return this.GetTable<ProductQualities>();
			}
		}
		
		public Table<Products> Products
		{
			get
			{
				return this.GetTable<Products>();
			}
		}
		
		public Table<ProductsSubtitles> ProductsSubtitles
		{
			get
			{
				return this.GetTable<ProductsSubtitles>();
			}
		}
		
		public Table<ProductStatus> ProductStatus
		{
			get
			{
				return this.GetTable<ProductStatus>();
			}
		}
		
		public Table<ProductSupports> ProductSupports
		{
			get
			{
				return this.GetTable<ProductSupports>();
			}
		}
		
		public Table<ProductTypes> ProductTypes
		{
			get
			{
				return this.GetTable<ProductTypes>();
			}
		}
		
		public Table<Studios> Studios
		{
			get
			{
				return this.GetTable<Studios>();
			}
		}
		
		public Table<Subtitles> Subtitles
		{
			get
			{
				return this.GetTable<Subtitles>();
			}
		}
		
		public Table<TMovie> TMovie
		{
			get
			{
				return this.GetTable<TMovie>();
			}
		}
		
		public Table<VOdMovie> VOdMovie
		{
			get
			{
				return this.GetTable<VOdMovie>();
			}
		}
	}
	
	#region Start MONO_STRICT
#if MONO_STRICT

	public partial class NewDVdPostBeTest
	{
		
		public NewDVdPostBeTest(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
	#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT
	
	public partial class NewDVdPostBeTest
	{
		
		public NewDVdPostBeTest(IDbConnection connection) : 
				base(connection, new DbLinq.MySql.MySqlVendor())
		{
			this.OnCreated();
		}
		
		public NewDVdPostBeTest(IDbConnection connection, IVendor sqlDialect) : 
				base(connection, sqlDialect)
		{
			this.OnCreated();
		}
		
		public NewDVdPostBeTest(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
				base(connection, mappingSource, sqlDialect)
		{
			this.OnCreated();
		}
	}
	#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
	#endregion
	
	[Table(Name="new_dvdpost_be_test.actors")]
	public partial class Actors : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _birthday;
		
		private System.DateTime _createdAt;
		
		private string _description;
		
		private uint _id;
		
		private string _name;
		
		private string _picture;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBirthdayChanged();
		
		partial void OnBirthdayChanging(string value);
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnPictureChanged();
		
		partial void OnPictureChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Actors()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_birthday", Name="birthday", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Birthday
		{
			get
			{
				return this._birthday;
			}
			set
			{
				if (((_birthday == value) 
							== false))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_description", Name="description", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_picture", Name="picture", DbType="varchar(145)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if (((_picture == value) 
							== false))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.actors_movies")]
	public partial class ActorsMovies : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private uint _actorID;
		
		private System.DateTime _createdAt;
		
		private uint _movieID;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActorIDChanged();
		
		partial void OnActorIDChanging(uint value);
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnMovieIDChanged();
		
		partial void OnMovieIDChanging(uint value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ActorsMovies()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_actorID", Name="actor_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ActorID
		{
			get
			{
				return this._actorID;
			}
			set
			{
				if ((_actorID != value))
				{
					this.OnActorIDChanging(value);
					this.SendPropertyChanging();
					this._actorID = value;
					this.SendPropertyChanged("ActorID");
					this.OnActorIDChanged();
				}
			}
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_movieID", Name="movie_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint MovieID
		{
			get
			{
				return this._movieID;
			}
			set
			{
				if ((_movieID != value))
				{
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._movieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.directors")]
	public partial class Directors : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _awards;
		
		private string _birthday;
		
		private System.DateTime _createdAt;
		
		private string _description;
		
		private uint _id;
		
		private string _name;
		
		private string _picture;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAwardsChanged();
		
		partial void OnAwardsChanging(string value);
		
		partial void OnBirthdayChanged();
		
		partial void OnBirthdayChanging(string value);
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnPictureChanged();
		
		partial void OnPictureChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Directors()
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
					this.SendPropertyChanging();
					this._awards = value;
					this.SendPropertyChanged("Awards");
					this.OnAwardsChanged();
				}
			}
		}
		
		[Column(Storage="_birthday", Name="birthday", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Birthday
		{
			get
			{
				return this._birthday;
			}
			set
			{
				if (((_birthday == value) 
							== false))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_description", Name="description", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
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
		
		[Column(Storage="_name", Name="name", DbType="varchar(60)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_picture", Name="picture", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if (((_picture == value) 
							== false))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.languages")]
	public partial class Languages : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private string _short;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnShortChanged();
		
		partial void OnShortChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Languages()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_short", Name="short", DbType="varchar(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Short
		{
			get
			{
				return this._short;
			}
			set
			{
				if (((_short == value) 
							== false))
				{
					this.OnShortChanging(value);
					this.SendPropertyChanging();
					this._short = value;
					this.SendPropertyChanged("Short");
					this.OnShortChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.languages_products")]
	public partial class LanguagesProducts : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _languageID;
		
		private uint _productID;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(uint value);
		
		partial void OnProductIDChanged();
		
		partial void OnProductIDChanging(uint value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public LanguagesProducts()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_languageID", Name="language_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint LanguageID
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
		
		[Column(Storage="_productID", Name="product_id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ProductID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((_productID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.movie_descriptions")]
	public partial class MovieDescriptions : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _award;
		
		private System.DateTime _createdAt;
		
		private string _description;
		
		private ushort _languageID;
		
		private uint _movieID;
		
		private string _name;
		
		private string _picture;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAwardChanged();
		
		partial void OnAwardChanging(string value);
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(ushort value);
		
		partial void OnMovieIDChanged();
		
		partial void OnMovieIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnPictureChanged();
		
		partial void OnPictureChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public MovieDescriptions()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_award", Name="award", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Award
		{
			get
			{
				return this._award;
			}
			set
			{
				if (((_award == value) 
							== false))
				{
					this.OnAwardChanging(value);
					this.SendPropertyChanging();
					this._award = value;
					this.SendPropertyChanged("Award");
					this.OnAwardChanged();
				}
			}
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_description", Name="description", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="smallint(5) unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public ushort LanguageID
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
		
		[Column(Storage="_movieID", Name="movie_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint MovieID
		{
			get
			{
				return this._movieID;
			}
			set
			{
				if ((_movieID != value))
				{
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._movieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(70)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_picture", Name="picture", DbType="varchar(70)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if (((_picture == value) 
							== false))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.movie_kind")]
	public partial class MovieKind : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.Nullable<System.DateTime> _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.Nullable<System.DateTime> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.Nullable<System.DateTime> value);
		#endregion
		
		
		public MovieKind()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never)]
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
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.movies")]
	public partial class Movies : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private System.Nullable<uint> _directorID;
		
		private System.Nullable<uint> _diskID;
		
		private uint _id;
		
		private uint _imdBID;
		
		private uint _movieKindID;
		
		private uint _movieTypeID;
		
		private string _name;
		
		private System.Nullable<uint> _seasonID;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDirectorIDChanged();
		
		partial void OnDirectorIDChanging(System.Nullable<uint> value);
		
		partial void OnDiskIDChanged();
		
		partial void OnDiskIDChanging(System.Nullable<uint> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnIMDbIDChanged();
		
		partial void OnIMDbIDChanging(uint value);
		
		partial void OnMovieKindIDChanged();
		
		partial void OnMovieKindIDChanging(uint value);
		
		partial void OnMovieTypeIDChanged();
		
		partial void OnMovieTypeIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnSeasonIDChanged();
		
		partial void OnSeasonIDChanging(System.Nullable<uint> value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Movies()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_directorID", Name="director_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> DirectorID
		{
			get
			{
				return this._directorID;
			}
			set
			{
				if ((_directorID != value))
				{
					this.OnDirectorIDChanging(value);
					this.SendPropertyChanging();
					this._directorID = value;
					this.SendPropertyChanged("DirectorID");
					this.OnDirectorIDChanged();
				}
			}
		}
		
		[Column(Storage="_diskID", Name="disk_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> DiskID
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
					this.SendPropertyChanging();
					this._diskID = value;
					this.SendPropertyChanged("DiskID");
					this.OnDiskIDChanged();
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
		
		[Column(Storage="_imdBID", Name="imdb_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint IMDbID
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
		
		[Column(Storage="_movieKindID", Name="movie_kind_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint MovieKindID
		{
			get
			{
				return this._movieKindID;
			}
			set
			{
				if ((_movieKindID != value))
				{
					this.OnMovieKindIDChanging(value);
					this.SendPropertyChanging();
					this._movieKindID = value;
					this.SendPropertyChanged("MovieKindID");
					this.OnMovieKindIDChanged();
				}
			}
		}
		
		[Column(Storage="_movieTypeID", Name="movie_type_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint MovieTypeID
		{
			get
			{
				return this._movieTypeID;
			}
			set
			{
				if ((_movieTypeID != value))
				{
					this.OnMovieTypeIDChanging(value);
					this.SendPropertyChanging();
					this._movieTypeID = value;
					this.SendPropertyChanged("MovieTypeID");
					this.OnMovieTypeIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(145)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_seasonID", Name="season_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> SeasonID
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
					this.SendPropertyChanging();
					this._seasonID = value;
					this.SendPropertyChanged("SeasonID");
					this.OnSeasonIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.movie_types")]
	public partial class MovieTypes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public MovieTypes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.product_disks")]
	public partial class ProductDisks : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _boxID;
		
		private uint _boxPoS;
		
		private System.DateTime _createdAt;
		
		private uint _dvDID;
		
		private uint _productID;
		
		private uint _status;
		
		private System.DateTime _updatedAt;
		
		private uint _whereID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBoxIDChanged();
		
		partial void OnBoxIDChanging(int value);
		
		partial void OnBoxPOsChanged();
		
		partial void OnBoxPOsChanging(uint value);
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDVdIDChanged();
		
		partial void OnDVdIDChanging(uint value);
		
		partial void OnProductIDChanged();
		
		partial void OnProductIDChanging(uint value);
		
		partial void OnStatusChanged();
		
		partial void OnStatusChanging(uint value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		
		partial void OnWhereIDChanged();
		
		partial void OnWhereIDChanging(uint value);
		#endregion
		
		
		public ProductDisks()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_boxID", Name="box_id", DbType="int(10)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BoxID
		{
			get
			{
				return this._boxID;
			}
			set
			{
				if ((_boxID != value))
				{
					this.OnBoxIDChanging(value);
					this.SendPropertyChanging();
					this._boxID = value;
					this.SendPropertyChanged("BoxID");
					this.OnBoxIDChanged();
				}
			}
		}
		
		[Column(Storage="_boxPoS", Name="box_pos", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint BoxPOs
		{
			get
			{
				return this._boxPoS;
			}
			set
			{
				if ((_boxPoS != value))
				{
					this.OnBoxPOsChanging(value);
					this.SendPropertyChanging();
					this._boxPoS = value;
					this.SendPropertyChanged("BoxPOs");
					this.OnBoxPOsChanged();
				}
			}
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_dvDID", Name="dvd_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint DVdID
		{
			get
			{
				return this._dvDID;
			}
			set
			{
				if ((_dvDID != value))
				{
					this.OnDVdIDChanging(value);
					this.SendPropertyChanging();
					this._dvDID = value;
					this.SendPropertyChanged("DVdID");
					this.OnDVdIDChanged();
				}
			}
		}
		
		[Column(Storage="_productID", Name="product_id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ProductID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((_productID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[Column(Storage="_status", Name="status", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((_status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_whereID", Name="where_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint WhereID
		{
			get
			{
				return this._whereID;
			}
			set
			{
				if ((_whereID != value))
				{
					this.OnWhereIDChanging(value);
					this.SendPropertyChanging();
					this._whereID = value;
					this.SendPropertyChanged("WhereID");
					this.OnWhereIDChanged();
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
	
	[Table(Name="new_dvdpost_be_test.product_dvd_status")]
	public partial class ProductDVdStatus : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ProductDVdStatus()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.product_dvd_where")]
	public partial class ProductDVdWhere : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ProductDVdWhere()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.product_qualities")]
	public partial class ProductQualities : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private uint _id;
		
		private string _name;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		#endregion
		
		
		public ProductQualities()
		{
			this.OnCreated();
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
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
	
	[Table(Name="new_dvdpost_be_test.products")]
	public partial class Products : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private System.Nullable<System.DateTime> _dateEnd;
		
		private System.Nullable<System.DateTime> _dateStart;
		
		private uint _id;
		
		private uint _movieID;
		
		private System.Nullable<uint> _oldProductID;
		
		private System.Nullable<uint> _productQualityID;
		
		private uint _productStatusID;
		
		private uint _productSupportID;
		
		private System.Nullable<uint> _studioID;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDateEndChanged();
		
		partial void OnDateEndChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDateStartChanged();
		
		partial void OnDateStartChanging(System.Nullable<System.DateTime> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnMovieIDChanged();
		
		partial void OnMovieIDChanging(uint value);
		
		partial void OnOldProductIDChanged();
		
		partial void OnOldProductIDChanging(System.Nullable<uint> value);
		
		partial void OnProductQualityIDChanged();
		
		partial void OnProductQualityIDChanging(System.Nullable<uint> value);
		
		partial void OnProductStatusIDChanged();
		
		partial void OnProductStatusIDChanging(uint value);
		
		partial void OnProductSupportIDChanged();
		
		partial void OnProductSupportIDChanging(uint value);
		
		partial void OnStudioIDChanged();
		
		partial void OnStudioIDChanging(System.Nullable<uint> value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Products()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_dateEnd", Name="date_end", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateEnd
		{
			get
			{
				return this._dateEnd;
			}
			set
			{
				if ((_dateEnd != value))
				{
					this.OnDateEndChanging(value);
					this.SendPropertyChanging();
					this._dateEnd = value;
					this.SendPropertyChanged("DateEnd");
					this.OnDateEndChanged();
				}
			}
		}
		
		[Column(Storage="_dateStart", Name="date_start", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateStart
		{
			get
			{
				return this._dateStart;
			}
			set
			{
				if ((_dateStart != value))
				{
					this.OnDateStartChanging(value);
					this.SendPropertyChanging();
					this._dateStart = value;
					this.SendPropertyChanged("DateStart");
					this.OnDateStartChanged();
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
		
		[Column(Storage="_movieID", Name="movie_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint MovieID
		{
			get
			{
				return this._movieID;
			}
			set
			{
				if ((_movieID != value))
				{
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._movieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[Column(Storage="_oldProductID", Name="old_product_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> OldProductID
		{
			get
			{
				return this._oldProductID;
			}
			set
			{
				if ((_oldProductID != value))
				{
					this.OnOldProductIDChanging(value);
					this.SendPropertyChanging();
					this._oldProductID = value;
					this.SendPropertyChanged("OldProductID");
					this.OnOldProductIDChanged();
				}
			}
		}
		
		[Column(Storage="_productQualityID", Name="product_quality_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> ProductQualityID
		{
			get
			{
				return this._productQualityID;
			}
			set
			{
				if ((_productQualityID != value))
				{
					this.OnProductQualityIDChanging(value);
					this.SendPropertyChanging();
					this._productQualityID = value;
					this.SendPropertyChanged("ProductQualityID");
					this.OnProductQualityIDChanged();
				}
			}
		}
		
		[Column(Storage="_productStatusID", Name="product_status_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ProductStatusID
		{
			get
			{
				return this._productStatusID;
			}
			set
			{
				if ((_productStatusID != value))
				{
					this.OnProductStatusIDChanging(value);
					this.SendPropertyChanging();
					this._productStatusID = value;
					this.SendPropertyChanged("ProductStatusID");
					this.OnProductStatusIDChanged();
				}
			}
		}
		
		[Column(Storage="_productSupportID", Name="product_support_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ProductSupportID
		{
			get
			{
				return this._productSupportID;
			}
			set
			{
				if ((_productSupportID != value))
				{
					this.OnProductSupportIDChanging(value);
					this.SendPropertyChanging();
					this._productSupportID = value;
					this.SendPropertyChanged("ProductSupportID");
					this.OnProductSupportIDChanged();
				}
			}
		}
		
		[Column(Storage="_studioID", Name="studio_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> StudioID
		{
			get
			{
				return this._studioID;
			}
			set
			{
				if ((_studioID != value))
				{
					this.OnStudioIDChanging(value);
					this.SendPropertyChanging();
					this._studioID = value;
					this.SendPropertyChanged("StudioID");
					this.OnStudioIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.products_subtitles")]
	public partial class ProductsSubtitles : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _productID;
		
		private uint _subtitleID;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnProductIDChanged();
		
		partial void OnProductIDChanging(uint value);
		
		partial void OnSubtitleIDChanged();
		
		partial void OnSubtitleIDChanging(uint value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ProductsSubtitles()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_productID", Name="product_id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ProductID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((_productID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[Column(Storage="_subtitleID", Name="subtitle_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint SubtitleID
		{
			get
			{
				return this._subtitleID;
			}
			set
			{
				if ((_subtitleID != value))
				{
					this.OnSubtitleIDChanging(value);
					this.SendPropertyChanging();
					this._subtitleID = value;
					this.SendPropertyChanged("SubtitleID");
					this.OnSubtitleIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.product_status")]
	public partial class ProductStatus : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ProductStatus()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.product_supports")]
	public partial class ProductSupports : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ProductSupports()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.product_types")]
	public partial class ProductTypes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _createdAt;
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<System.DateTime> _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.Nullable<System.DateTime> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.Nullable<System.DateTime> value);
		#endregion
		
		
		public ProductTypes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never)]
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
		
		[Column(Storage="_id", Name="id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
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
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.studios")]
	public partial class Studios : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Studios()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.subtitles")]
	public partial class Subtitles : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private string _short;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnShortChanged();
		
		partial void OnShortChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Subtitles()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
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
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_short", Name="short", DbType="varchar(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Short
		{
			get
			{
				return this._short;
			}
			set
			{
				if (((_short == value) 
							== false))
				{
					this.OnShortChanging(value);
					this.SendPropertyChanging();
					this._short = value;
					this.SendPropertyChanged("Short");
					this.OnShortChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
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
	
	[Table(Name="new_dvdpost_be_test.tmovie")]
	public partial class TMovie
	{
		
		private string _actorList;
		
		private string _categoryList;
		
		private string _countryList;
		
		private string _director;
		
		private System.Nullable<uint> _diskID;
		
		private uint _imdBID;
		
		private uint _imdBIdseRie;
		
		private string _languages;
		
		private System.Nullable<int> _lenGht;
		
		private string _movieID;
		
		private string _movieType;
		
		private string _name;
		
		private string _officialWebSite;
		
		private string _picture;
		
		private System.Nullable<uint> _productDirectorsID;
		
		private System.Nullable<uint> _productFicheTypeID;
		
		private string _public;
		
		private System.Nullable<uint> _seasonID;
		
		private string _soundDetailsList;
		
		private string _studio;
		
		private string _subtitlesList;
		
		private string _sysNoPsiS;
		
		private string _trIleR;
		
		private System.Nullable<int> _typeID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActorListChanged();
		
		partial void OnActorListChanging(string value);
		
		partial void OnCategoryListChanged();
		
		partial void OnCategoryListChanging(string value);
		
		partial void OnCountryListChanged();
		
		partial void OnCountryListChanging(string value);
		
		partial void OnDirectorChanged();
		
		partial void OnDirectorChanging(string value);
		
		partial void OnDiskIDChanged();
		
		partial void OnDiskIDChanging(System.Nullable<uint> value);
		
		partial void OnIMDbIDChanged();
		
		partial void OnIMDbIDChanging(uint value);
		
		partial void OnIMDbIDSErieChanged();
		
		partial void OnIMDbIDSErieChanging(uint value);
		
		partial void OnLanguagesChanged();
		
		partial void OnLanguagesChanging(string value);
		
		partial void OnLenGHTChanged();
		
		partial void OnLenGHTChanging(System.Nullable<int> value);
		
		partial void OnMovieIDChanged();
		
		partial void OnMovieIDChanging(string value);
		
		partial void OnMovieTypeChanged();
		
		partial void OnMovieTypeChanging(string value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnOfficialWebSiteChanged();
		
		partial void OnOfficialWebSiteChanging(string value);
		
		partial void OnPictureChanged();
		
		partial void OnPictureChanging(string value);
		
		partial void OnProductDirectorsIDChanged();
		
		partial void OnProductDirectorsIDChanging(System.Nullable<uint> value);
		
		partial void OnProductFicheTypeIDChanged();
		
		partial void OnProductFicheTypeIDChanging(System.Nullable<uint> value);
		
		partial void OnPublicChanged();
		
		partial void OnPublicChanging(string value);
		
		partial void OnSeasonIDChanged();
		
		partial void OnSeasonIDChanging(System.Nullable<uint> value);
		
		partial void OnSoundDetailsListChanged();
		
		partial void OnSoundDetailsListChanging(string value);
		
		partial void OnStudioChanged();
		
		partial void OnStudioChanging(string value);
		
		partial void OnSubtitlesListChanged();
		
		partial void OnSubtitlesListChanging(string value);
		
		partial void OnSysNoPsiSChanged();
		
		partial void OnSysNoPsiSChanging(string value);
		
		partial void OnTRileRChanged();
		
		partial void OnTRileRChanging(string value);
		
		partial void OnTypeIDChanged();
		
		partial void OnTypeIDChanging(System.Nullable<int> value);
		#endregion
		
		
		public TMovie()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_actorList", Name="actor_list", DbType="varchar(400)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ActorList
		{
			get
			{
				return this._actorList;
			}
			set
			{
				if (((_actorList == value) 
							== false))
				{
					this.OnActorListChanging(value);
					this._actorList = value;
					this.OnActorListChanged();
				}
			}
		}
		
		[Column(Storage="_categoryList", Name="category_list", DbType="varchar(445)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CategoryList
		{
			get
			{
				return this._categoryList;
			}
			set
			{
				if (((_categoryList == value) 
							== false))
				{
					this.OnCategoryListChanging(value);
					this._categoryList = value;
					this.OnCategoryListChanged();
				}
			}
		}
		
		[Column(Storage="_countryList", Name="country_list", DbType="varchar(445)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CountryList
		{
			get
			{
				return this._countryList;
			}
			set
			{
				if (((_countryList == value) 
							== false))
				{
					this.OnCountryListChanging(value);
					this._countryList = value;
					this.OnCountryListChanged();
				}
			}
		}
		
		[Column(Storage="_director", Name="director", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Director
		{
			get
			{
				return this._director;
			}
			set
			{
				if (((_director == value) 
							== false))
				{
					this.OnDirectorChanging(value);
					this._director = value;
					this.OnDirectorChanged();
				}
			}
		}
		
		[Column(Storage="_diskID", Name="disk_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> DiskID
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
		
		[Column(Storage="_imdBID", Name="imdb_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint IMDbID
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
					this._imdBID = value;
					this.OnIMDbIDChanged();
				}
			}
		}
		
		[Column(Storage="_imdBIdseRie", Name="imdb_id_serie", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint IMDbIDSErie
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
		
		[Column(Storage="_languages", Name="languages", DbType="varchar(145)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Languages
		{
			get
			{
				return this._languages;
			}
			set
			{
				if (((_languages == value) 
							== false))
				{
					this.OnLanguagesChanging(value);
					this._languages = value;
					this.OnLanguagesChanged();
				}
			}
		}
		
		[Column(Storage="_lenGht", Name="lenght", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> LenGHT
		{
			get
			{
				return this._lenGht;
			}
			set
			{
				if ((_lenGht != value))
				{
					this.OnLenGHTChanging(value);
					this._lenGht = value;
					this.OnLenGHTChanged();
				}
			}
		}
		
		[Column(Storage="_movieID", Name="movie_id", DbType="varchar(35)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieID
		{
			get
			{
				return this._movieID;
			}
			set
			{
				if (((_movieID == value) 
							== false))
				{
					this.OnMovieIDChanging(value);
					this._movieID = value;
					this.OnMovieIDChanged();
				}
			}
		}
		
		[Column(Storage="_movieType", Name="movie_type", DbType="varchar(145)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieType
		{
			get
			{
				return this._movieType;
			}
			set
			{
				if (((_movieType == value) 
							== false))
				{
					this.OnMovieTypeChanging(value);
					this._movieType = value;
					this.OnMovieTypeChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(145)", AutoSync=AutoSync.Never, CanBeNull=false)]
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
		
		[Column(Storage="_officialWebSite", Name="official_web_site", DbType="varchar(1145)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OfficialWebSite
		{
			get
			{
				return this._officialWebSite;
			}
			set
			{
				if (((_officialWebSite == value) 
							== false))
				{
					this.OnOfficialWebSiteChanging(value);
					this._officialWebSite = value;
					this.OnOfficialWebSiteChanged();
				}
			}
		}
		
		[Column(Storage="_picture", Name="picture", DbType="varchar(145)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if (((_picture == value) 
							== false))
				{
					this.OnPictureChanging(value);
					this._picture = value;
					this.OnPictureChanged();
				}
			}
		}
		
		[Column(Storage="_productDirectorsID", Name="product_directors_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> ProductDirectorsID
		{
			get
			{
				return this._productDirectorsID;
			}
			set
			{
				if ((_productDirectorsID != value))
				{
					this.OnProductDirectorsIDChanging(value);
					this._productDirectorsID = value;
					this.OnProductDirectorsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productFicheTypeID", Name="product_fiche_type_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> ProductFicheTypeID
		{
			get
			{
				return this._productFicheTypeID;
			}
			set
			{
				if ((_productFicheTypeID != value))
				{
					this.OnProductFicheTypeIDChanging(value);
					this._productFicheTypeID = value;
					this.OnProductFicheTypeIDChanged();
				}
			}
		}
		
		[Column(Storage="_public", Name="public", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Public
		{
			get
			{
				return this._public;
			}
			set
			{
				if (((_public == value) 
							== false))
				{
					this.OnPublicChanging(value);
					this._public = value;
					this.OnPublicChanged();
				}
			}
		}
		
		[Column(Storage="_seasonID", Name="season_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> SeasonID
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
		
		[Column(Storage="_soundDetailsList", Name="sound_details_list", DbType="varchar(145)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SoundDetailsList
		{
			get
			{
				return this._soundDetailsList;
			}
			set
			{
				if (((_soundDetailsList == value) 
							== false))
				{
					this.OnSoundDetailsListChanging(value);
					this._soundDetailsList = value;
					this.OnSoundDetailsListChanged();
				}
			}
		}
		
		[Column(Storage="_studio", Name="studio", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Studio
		{
			get
			{
				return this._studio;
			}
			set
			{
				if (((_studio == value) 
							== false))
				{
					this.OnStudioChanging(value);
					this._studio = value;
					this.OnStudioChanged();
				}
			}
		}
		
		[Column(Storage="_subtitlesList", Name="subtitles_list", DbType="varchar(145)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubtitlesList
		{
			get
			{
				return this._subtitlesList;
			}
			set
			{
				if (((_subtitlesList == value) 
							== false))
				{
					this.OnSubtitlesListChanging(value);
					this._subtitlesList = value;
					this.OnSubtitlesListChanged();
				}
			}
		}
		
		[Column(Storage="_sysNoPsiS", Name="sysnopsis", DbType="varchar(8000)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SysNoPsiS
		{
			get
			{
				return this._sysNoPsiS;
			}
			set
			{
				if (((_sysNoPsiS == value) 
							== false))
				{
					this.OnSysNoPsiSChanging(value);
					this._sysNoPsiS = value;
					this.OnSysNoPsiSChanged();
				}
			}
		}
		
		[Column(Storage="_trIleR", Name="triler", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string TRileR
		{
			get
			{
				return this._trIleR;
			}
			set
			{
				if (((_trIleR == value) 
							== false))
				{
					this.OnTRileRChanging(value);
					this._trIleR = value;
					this.OnTRileRChanged();
				}
			}
		}
		
		[Column(Storage="_typeID", Name="type_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> TypeID
		{
			get
			{
				return this._typeID;
			}
			set
			{
				if ((_typeID != value))
				{
					this.OnTypeIDChanging(value);
					this._typeID = value;
					this.OnTypeIDChanged();
				}
			}
		}
	}
	
	[Table(Name="new_dvdpost_be_test.vodmovie")]
	public partial class VOdMovie
	{
		
		private System.Nullable<byte> _available;
		
		private System.Nullable<System.DateTime> _availableFrom;
		
		private System.Nullable<uint> _diskID;
		
		private System.DateTime _expireAt;
		
		private uint _imdBID;
		
		private System.Nullable<uint> _imdBIdseRie;
		
		private string _languages;
		
		private string _movieActorsList;
		
		private string _movieCategoriesList;
		
		private string _movieCoUtRylIst;
		
		private string _movieDirector;
		
		private System.Nullable<int> _movieDirectorID;
		
		private string _movieID;
		
		private string _movieLangSubtitlePairs;
		
		private System.Nullable<int> _movieLength;
		
		private string _movieName;
		
		private string _movieOfficialWebSite;
		
		private System.Nullable<int> _moviePublic;
		
		private string _movieStudio;
		
		private string _movieSubTitIlEs;
		
		private string _movieType;
		
		private System.Nullable<long> _movieTypeID;
		
		private string _picture;
		
		private int _productFicheTypeID;
		
		private System.Nullable<uint> _seasonID;
		
		private string _soundDetails;
		
		private string _status;
		
		private string _synopsis;
		
		private System.Nullable<byte> _triler;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAvailableChanged();
		
		partial void OnAvailableChanging(System.Nullable<byte> value);
		
		partial void OnAvailableFromChanged();
		
		partial void OnAvailableFromChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDiskIDChanged();
		
		partial void OnDiskIDChanging(System.Nullable<uint> value);
		
		partial void OnExpireAtChanged();
		
		partial void OnExpireAtChanging(System.DateTime value);
		
		partial void OnIMDbIDChanged();
		
		partial void OnIMDbIDChanging(uint value);
		
		partial void OnIMDbIDSErieChanged();
		
		partial void OnIMDbIDSErieChanging(System.Nullable<uint> value);
		
		partial void OnLanguagesChanged();
		
		partial void OnLanguagesChanging(string value);
		
		partial void OnMovieActorsListChanged();
		
		partial void OnMovieActorsListChanging(string value);
		
		partial void OnMovieCategoriesListChanged();
		
		partial void OnMovieCategoriesListChanging(string value);
		
		partial void OnMovieCOutRYListChanged();
		
		partial void OnMovieCOutRYListChanging(string value);
		
		partial void OnMovieDirectorChanged();
		
		partial void OnMovieDirectorChanging(string value);
		
		partial void OnMovieDirectorIDChanged();
		
		partial void OnMovieDirectorIDChanging(System.Nullable<int> value);
		
		partial void OnMovieIDChanged();
		
		partial void OnMovieIDChanging(string value);
		
		partial void OnMovieLangSubtitlePairsChanged();
		
		partial void OnMovieLangSubtitlePairsChanging(string value);
		
		partial void OnMovieLengthChanged();
		
		partial void OnMovieLengthChanging(System.Nullable<int> value);
		
		partial void OnMovieNameChanged();
		
		partial void OnMovieNameChanging(string value);
		
		partial void OnMovieOfficialWebSiteChanged();
		
		partial void OnMovieOfficialWebSiteChanging(string value);
		
		partial void OnMoviePublicChanged();
		
		partial void OnMoviePublicChanging(System.Nullable<int> value);
		
		partial void OnMovieStudioChanged();
		
		partial void OnMovieStudioChanging(string value);
		
		partial void OnMovieSubTitIlEsChanged();
		
		partial void OnMovieSubTitIlEsChanging(string value);
		
		partial void OnMovieTypeChanged();
		
		partial void OnMovieTypeChanging(string value);
		
		partial void OnMovieTypeIDChanged();
		
		partial void OnMovieTypeIDChanging(System.Nullable<long> value);
		
		partial void OnPictureChanged();
		
		partial void OnPictureChanging(string value);
		
		partial void OnProductFicheTypeIDChanged();
		
		partial void OnProductFicheTypeIDChanging(int value);
		
		partial void OnSeasonIDChanged();
		
		partial void OnSeasonIDChanging(System.Nullable<uint> value);
		
		partial void OnSoundDetailsChanged();
		
		partial void OnSoundDetailsChanging(string value);
		
		partial void OnStatusChanged();
		
		partial void OnStatusChanging(string value);
		
		partial void OnSynopsisChanged();
		
		partial void OnSynopsisChanging(string value);
		
		partial void OnTrilerChanged();
		
		partial void OnTrilerChanging(System.Nullable<byte> value);
		#endregion
		
		
		public VOdMovie()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_available", Name="available", DbType="tinyint(1) unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<byte> Available
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
					this._available = value;
					this.OnAvailableChanged();
				}
			}
		}
		
		[Column(Storage="_availableFrom", Name="available_from", DbType="date", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> AvailableFrom
		{
			get
			{
				return this._availableFrom;
			}
			set
			{
				if ((_availableFrom != value))
				{
					this.OnAvailableFromChanging(value);
					this._availableFrom = value;
					this.OnAvailableFromChanged();
				}
			}
		}
		
		[Column(Storage="_diskID", Name="disk_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> DiskID
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
		
		[Column(Storage="_expireAt", Name="expire_at", DbType="date", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime ExpireAt
		{
			get
			{
				return this._expireAt;
			}
			set
			{
				if ((_expireAt != value))
				{
					this.OnExpireAtChanging(value);
					this._expireAt = value;
					this.OnExpireAtChanged();
				}
			}
		}
		
		[Column(Storage="_imdBID", Name="imdb_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint IMDbID
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
					this._imdBID = value;
					this.OnIMDbIDChanged();
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
		
		[Column(Storage="_languages", Name="languages", DbType="varchar(8000)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Languages
		{
			get
			{
				return this._languages;
			}
			set
			{
				if (((_languages == value) 
							== false))
				{
					this.OnLanguagesChanging(value);
					this._languages = value;
					this.OnLanguagesChanged();
				}
			}
		}
		
		[Column(Storage="_movieActorsList", Name="movie_actors_list", DbType="varchar(400)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieActorsList
		{
			get
			{
				return this._movieActorsList;
			}
			set
			{
				if (((_movieActorsList == value) 
							== false))
				{
					this.OnMovieActorsListChanging(value);
					this._movieActorsList = value;
					this.OnMovieActorsListChanged();
				}
			}
		}
		
		[Column(Storage="_movieCategoriesList", Name="movie_categories_list", DbType="varchar(8000)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieCategoriesList
		{
			get
			{
				return this._movieCategoriesList;
			}
			set
			{
				if (((_movieCategoriesList == value) 
							== false))
				{
					this.OnMovieCategoriesListChanging(value);
					this._movieCategoriesList = value;
					this.OnMovieCategoriesListChanged();
				}
			}
		}
		
		[Column(Storage="_movieCoUtRylIst", Name="movie_coutry_list", DbType="varchar(50)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieCOutRYList
		{
			get
			{
				return this._movieCoUtRylIst;
			}
			set
			{
				if (((_movieCoUtRylIst == value) 
							== false))
				{
					this.OnMovieCOutRYListChanging(value);
					this._movieCoUtRylIst = value;
					this.OnMovieCOutRYListChanged();
				}
			}
		}
		
		[Column(Storage="_movieDirector", Name="movie_director", DbType="varchar(50)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieDirector
		{
			get
			{
				return this._movieDirector;
			}
			set
			{
				if (((_movieDirector == value) 
							== false))
				{
					this.OnMovieDirectorChanging(value);
					this._movieDirector = value;
					this.OnMovieDirectorChanged();
				}
			}
		}
		
		[Column(Storage="_movieDirectorID", Name="movie_director_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MovieDirectorID
		{
			get
			{
				return this._movieDirectorID;
			}
			set
			{
				if ((_movieDirectorID != value))
				{
					this.OnMovieDirectorIDChanging(value);
					this._movieDirectorID = value;
					this.OnMovieDirectorIDChanged();
				}
			}
		}
		
		[Column(Storage="_movieID", Name="movie_id", DbType="varchar(26)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieID
		{
			get
			{
				return this._movieID;
			}
			set
			{
				if (((_movieID == value) 
							== false))
				{
					this.OnMovieIDChanging(value);
					this._movieID = value;
					this.OnMovieIDChanged();
				}
			}
		}
		
		[Column(Storage="_movieLangSubtitlePairs", Name="movie_langsubtitlepairs", DbType="varchar(8000)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieLangSubtitlePairs
		{
			get
			{
				return this._movieLangSubtitlePairs;
			}
			set
			{
				if (((_movieLangSubtitlePairs == value) 
							== false))
				{
					this.OnMovieLangSubtitlePairsChanging(value);
					this._movieLangSubtitlePairs = value;
					this.OnMovieLangSubtitlePairsChanged();
				}
			}
		}
		
		[Column(Storage="_movieLength", Name="movie_length", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MovieLength
		{
			get
			{
				return this._movieLength;
			}
			set
			{
				if ((_movieLength != value))
				{
					this.OnMovieLengthChanging(value);
					this._movieLength = value;
					this.OnMovieLengthChanged();
				}
			}
		}
		
		[Column(Storage="_movieName", Name="moviename", DbType="varchar(200)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieName
		{
			get
			{
				return this._movieName;
			}
			set
			{
				if (((_movieName == value) 
							== false))
				{
					this.OnMovieNameChanging(value);
					this._movieName = value;
					this.OnMovieNameChanged();
				}
			}
		}
		
		[Column(Storage="_movieOfficialWebSite", Name="movie_official_web_site", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieOfficialWebSite
		{
			get
			{
				return this._movieOfficialWebSite;
			}
			set
			{
				if (((_movieOfficialWebSite == value) 
							== false))
				{
					this.OnMovieOfficialWebSiteChanging(value);
					this._movieOfficialWebSite = value;
					this.OnMovieOfficialWebSiteChanged();
				}
			}
		}
		
		[Column(Storage="_moviePublic", Name="movie_public", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> MoviePublic
		{
			get
			{
				return this._moviePublic;
			}
			set
			{
				if ((_moviePublic != value))
				{
					this.OnMoviePublicChanging(value);
					this._moviePublic = value;
					this.OnMoviePublicChanged();
				}
			}
		}
		
		[Column(Storage="_movieStudio", Name="movie_studio", DbType="varchar(50)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieStudio
		{
			get
			{
				return this._movieStudio;
			}
			set
			{
				if (((_movieStudio == value) 
							== false))
				{
					this.OnMovieStudioChanging(value);
					this._movieStudio = value;
					this.OnMovieStudioChanged();
				}
			}
		}
		
		[Column(Storage="_movieSubTitIlEs", Name="movie_subtitiles", DbType="varchar(342)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieSubTitIlEs
		{
			get
			{
				return this._movieSubTitIlEs;
			}
			set
			{
				if (((_movieSubTitIlEs == value) 
							== false))
				{
					this.OnMovieSubTitIlEsChanging(value);
					this._movieSubTitIlEs = value;
					this.OnMovieSubTitIlEsChanged();
				}
			}
		}
		
		[Column(Storage="_movieType", Name="movie_type", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MovieType
		{
			get
			{
				return this._movieType;
			}
			set
			{
				if (((_movieType == value) 
							== false))
				{
					this.OnMovieTypeChanging(value);
					this._movieType = value;
					this.OnMovieTypeChanged();
				}
			}
		}
		
		[Column(Storage="_movieTypeID", Name="movie_type_id", DbType="bigint", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> MovieTypeID
		{
			get
			{
				return this._movieTypeID;
			}
			set
			{
				if ((_movieTypeID != value))
				{
					this.OnMovieTypeIDChanging(value);
					this._movieTypeID = value;
					this.OnMovieTypeIDChanged();
				}
			}
		}
		
		[Column(Storage="_picture", Name="picture", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if (((_picture == value) 
							== false))
				{
					this.OnPictureChanging(value);
					this._picture = value;
					this.OnPictureChanged();
				}
			}
		}
		
		[Column(Storage="_productFicheTypeID", Name="product_fiche_type_id", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductFicheTypeID
		{
			get
			{
				return this._productFicheTypeID;
			}
			set
			{
				if ((_productFicheTypeID != value))
				{
					this.OnProductFicheTypeIDChanging(value);
					this._productFicheTypeID = value;
					this.OnProductFicheTypeIDChanged();
				}
			}
		}
		
		[Column(Storage="_seasonID", Name="season_id", DbType="int(12) unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> SeasonID
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
		
		[Column(Storage="_soundDetails", Name="sound_details", DbType="varchar(8000)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SoundDetails
		{
			get
			{
				return this._soundDetails;
			}
			set
			{
				if (((_soundDetails == value) 
							== false))
				{
					this.OnSoundDetailsChanging(value);
					this._soundDetails = value;
					this.OnSoundDetailsChanged();
				}
			}
		}
		
		[Column(Storage="_status", Name="status", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value) 
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}
		
		[Column(Storage="_synopsis", Name="synopsis", DbType="varchar(8000)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Synopsis
		{
			get
			{
				return this._synopsis;
			}
			set
			{
				if (((_synopsis == value) 
							== false))
				{
					this.OnSynopsisChanging(value);
					this._synopsis = value;
					this.OnSynopsisChanged();
				}
			}
		}
		
		[Column(Storage="_triler", Name="Triler", DbType="tinyint(1) unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<byte> Triler
		{
			get
			{
				return this._triler;
			}
			set
			{
				if ((_triler != value))
				{
					this.OnTrilerChanging(value);
					this._triler = value;
					this.OnTrilerChanged();
				}
			}
		}
	}
}
