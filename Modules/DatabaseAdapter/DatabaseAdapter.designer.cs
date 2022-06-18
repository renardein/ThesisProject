﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThesisProject.Modules.DatabaseAdapter
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ktkCis")]
	public partial class DatabaseAdapterDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertProModule(ProModule instance);
    partial void UpdateProModule(ProModule instance);
    partial void DeleteProModule(ProModule instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertExam(Exam instance);
    partial void UpdateExam(Exam instance);
    partial void DeleteExam(Exam instance);
    partial void InsertExamMark(ExamMark instance);
    partial void UpdateExamMark(ExamMark instance);
    partial void DeleteExamMark(ExamMark instance);
    partial void InsertGroup(Group instance);
    partial void UpdateGroup(Group instance);
    partial void DeleteGroup(Group instance);
    partial void InsertMark(Mark instance);
    partial void UpdateMark(Mark instance);
    partial void DeleteMark(Mark instance);
    #endregion
		
		public DatabaseAdapterDataContext() : 
				base(global::ThesisProject.Properties.Settings.Default.ktkCisConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAdapterDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAdapterDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAdapterDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAdapterDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ExamView> ExamView
		{
			get
			{
				return this.GetTable<ExamView>();
			}
		}
		
		public System.Data.Linq.Table<StudentGroup> StudentGroup
		{
			get
			{
				return this.GetTable<StudentGroup>();
			}
		}
		
		public System.Data.Linq.Table<User> User
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<ProModule> ProModule
		{
			get
			{
				return this.GetTable<ProModule>();
			}
		}
		
		public System.Data.Linq.Table<Student> Student
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<Exam> Exam
		{
			get
			{
				return this.GetTable<Exam>();
			}
		}
		
		public System.Data.Linq.Table<ExamMark> ExamMark
		{
			get
			{
				return this.GetTable<ExamMark>();
			}
		}
		
		public System.Data.Linq.Table<Group> Group
		{
			get
			{
				return this.GetTable<Group>();
			}
		}
		
		public System.Data.Linq.Table<Mark> Mark
		{
			get
			{
				return this.GetTable<Mark>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExamView")]
	public partial class ExamView
	{
		
		private string _Группа;
		
		private string _Модуль;
		
		private string _Состав_комиссии;
		
		private System.DateTime _Дата;
		
		public ExamView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Группа", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Группа
		{
			get
			{
				return this._Группа;
			}
			set
			{
				if ((this._Группа != value))
				{
					this._Группа = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Модуль", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Модуль
		{
			get
			{
				return this._Модуль;
			}
			set
			{
				if ((this._Модуль != value))
				{
					this._Модуль = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Состав комиссии]", Storage="_Состав_комиссии", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Состав_комиссии
		{
			get
			{
				return this._Состав_комиссии;
			}
			set
			{
				if ((this._Состав_комиссии != value))
				{
					this._Состав_комиссии = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Дата", DbType="DateTime NOT NULL")]
		public System.DateTime Дата
		{
			get
			{
				return this._Дата;
			}
			set
			{
				if ((this._Дата != value))
				{
					this._Дата = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StudentGroup")]
	public partial class StudentGroup
	{
		
		private string _Student;
		
		private string _Group;
		
		public StudentGroup()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Student", DbType="NVarChar(117)")]
		public string Student
		{
			get
			{
				return this._Student;
			}
			set
			{
				if ((this._Student != value))
				{
					this._Student = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Group]", Storage="_Group", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Group
		{
			get
			{
				return this._Group;
			}
			set
			{
				if ((this._Group != value))
				{
					this._Group = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _Username;
		
		private string _Password;
		
		private string _Role;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnRoleChanging(string value);
    partial void OnRoleChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProModule")]
	public partial class ProModule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ModuleId;
		
		private string _Title;
		
		private EntitySet<Exam> _Exam;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnModuleIdChanging(int value);
    partial void OnModuleIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    #endregion
		
		public ProModule()
		{
			this._Exam = new EntitySet<Exam>(new Action<Exam>(this.attach_Exam), new Action<Exam>(this.detach_Exam));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ModuleId
		{
			get
			{
				return this._ModuleId;
			}
			set
			{
				if ((this._ModuleId != value))
				{
					this.OnModuleIdChanging(value);
					this.SendPropertyChanging();
					this._ModuleId = value;
					this.SendPropertyChanged("ModuleId");
					this.OnModuleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ProModule_Exam", Storage="_Exam", ThisKey="ModuleId", OtherKey="ModuleId")]
		public EntitySet<Exam> Exam
		{
			get
			{
				return this._Exam;
			}
			set
			{
				this._Exam.Assign(value);
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
		
		private void attach_Exam(Exam entity)
		{
			this.SendPropertyChanging();
			entity.ProModule = this;
		}
		
		private void detach_Exam(Exam entity)
		{
			this.SendPropertyChanging();
			entity.ProModule = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StudentId;
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private string _LastName;
		
		private int _GroupId;
		
		private EntitySet<Mark> _Mark;
		
		private EntityRef<Group> _Group;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudentIdChanging(int value);
    partial void OnStudentIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnMiddleNameChanging(string value);
    partial void OnMiddleNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnGroupIdChanging(int value);
    partial void OnGroupIdChanged();
    #endregion
		
		public Student()
		{
			this._Mark = new EntitySet<Mark>(new Action<Mark>(this.attach_Mark), new Action<Mark>(this.detach_Mark));
			this._Group = default(EntityRef<Group>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					this.OnStudentIdChanging(value);
					this.SendPropertyChanging();
					this._StudentId = value;
					this.SendPropertyChanged("StudentId");
					this.OnStudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="NVarChar(50)")]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this.OnMiddleNameChanging(value);
					this.SendPropertyChanging();
					this._MiddleName = value;
					this.SendPropertyChanged("MiddleName");
					this.OnMiddleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupId", DbType="Int NOT NULL")]
		public int GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					if (this._Group.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGroupIdChanging(value);
					this.SendPropertyChanging();
					this._GroupId = value;
					this.SendPropertyChanged("GroupId");
					this.OnGroupIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Mark", Storage="_Mark", ThisKey="StudentId", OtherKey="StudentId")]
		public EntitySet<Mark> Mark
		{
			get
			{
				return this._Mark;
			}
			set
			{
				this._Mark.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_Student", Storage="_Group", ThisKey="GroupId", OtherKey="GroupId", IsForeignKey=true)]
		public Group Group
		{
			get
			{
				return this._Group.Entity;
			}
			set
			{
				Group previousValue = this._Group.Entity;
				if (((previousValue != value) 
							|| (this._Group.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Group.Entity = null;
						previousValue.Student.Remove(this);
					}
					this._Group.Entity = value;
					if ((value != null))
					{
						value.Student.Add(this);
						this._GroupId = value.GroupId;
					}
					else
					{
						this._GroupId = default(int);
					}
					this.SendPropertyChanged("Group");
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
		
		private void attach_Mark(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Mark(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Exam")]
	public partial class Exam : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ExamId;
		
		private System.Nullable<int> _GroupId;
		
		private int _ModuleId;
		
		private System.DateTime _Date;
		
		private string _Examiner;
		
		private EntitySet<Mark> _Mark;
		
		private EntityRef<ProModule> _ProModule;
		
		private EntityRef<Group> _Group;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExamIdChanging(int value);
    partial void OnExamIdChanged();
    partial void OnGroupIdChanging(System.Nullable<int> value);
    partial void OnGroupIdChanged();
    partial void OnModuleIdChanging(int value);
    partial void OnModuleIdChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnExaminerChanging(string value);
    partial void OnExaminerChanged();
    #endregion
		
		public Exam()
		{
			this._Mark = new EntitySet<Mark>(new Action<Mark>(this.attach_Mark), new Action<Mark>(this.detach_Mark));
			this._ProModule = default(EntityRef<ProModule>);
			this._Group = default(EntityRef<Group>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExamId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ExamId
		{
			get
			{
				return this._ExamId;
			}
			set
			{
				if ((this._ExamId != value))
				{
					this.OnExamIdChanging(value);
					this.SendPropertyChanging();
					this._ExamId = value;
					this.SendPropertyChanged("ExamId");
					this.OnExamIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupId", DbType="Int")]
		public System.Nullable<int> GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					if (this._Group.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGroupIdChanging(value);
					this.SendPropertyChanging();
					this._GroupId = value;
					this.SendPropertyChanged("GroupId");
					this.OnGroupIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleId", DbType="Int NOT NULL")]
		public int ModuleId
		{
			get
			{
				return this._ModuleId;
			}
			set
			{
				if ((this._ModuleId != value))
				{
					if (this._ProModule.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnModuleIdChanging(value);
					this.SendPropertyChanging();
					this._ModuleId = value;
					this.SendPropertyChanged("ModuleId");
					this.OnModuleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Examiner", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Examiner
		{
			get
			{
				return this._Examiner;
			}
			set
			{
				if ((this._Examiner != value))
				{
					this.OnExaminerChanging(value);
					this.SendPropertyChanging();
					this._Examiner = value;
					this.SendPropertyChanged("Examiner");
					this.OnExaminerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Exam_Mark", Storage="_Mark", ThisKey="ExamId", OtherKey="ExamId")]
		public EntitySet<Mark> Mark
		{
			get
			{
				return this._Mark;
			}
			set
			{
				this._Mark.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ProModule_Exam", Storage="_ProModule", ThisKey="ModuleId", OtherKey="ModuleId", IsForeignKey=true)]
		public ProModule ProModule
		{
			get
			{
				return this._ProModule.Entity;
			}
			set
			{
				ProModule previousValue = this._ProModule.Entity;
				if (((previousValue != value) 
							|| (this._ProModule.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ProModule.Entity = null;
						previousValue.Exam.Remove(this);
					}
					this._ProModule.Entity = value;
					if ((value != null))
					{
						value.Exam.Add(this);
						this._ModuleId = value.ModuleId;
					}
					else
					{
						this._ModuleId = default(int);
					}
					this.SendPropertyChanged("ProModule");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_Exam", Storage="_Group", ThisKey="GroupId", OtherKey="GroupId", IsForeignKey=true)]
		public Group Group
		{
			get
			{
				return this._Group.Entity;
			}
			set
			{
				Group previousValue = this._Group.Entity;
				if (((previousValue != value) 
							|| (this._Group.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Group.Entity = null;
						previousValue.Exam.Remove(this);
					}
					this._Group.Entity = value;
					if ((value != null))
					{
						value.Exam.Add(this);
						this._GroupId = value.GroupId;
					}
					else
					{
						this._GroupId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Group");
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
		
		private void attach_Mark(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Exam = this;
		}
		
		private void detach_Mark(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Exam = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExamMark")]
	public partial class ExamMark : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ExamId;
		
		private int _MarkId;
		
		private int _StudentId;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExamIdChanging(int value);
    partial void OnExamIdChanged();
    partial void OnMarkIdChanging(int value);
    partial void OnMarkIdChanged();
    partial void OnStudentIdChanging(int value);
    partial void OnStudentIdChanged();
    #endregion
		
		public ExamMark()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExamId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ExamId
		{
			get
			{
				return this._ExamId;
			}
			set
			{
				if ((this._ExamId != value))
				{
					this.OnExamIdChanging(value);
					this.SendPropertyChanging();
					this._ExamId = value;
					this.SendPropertyChanged("ExamId");
					this.OnExamIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MarkId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MarkId
		{
			get
			{
				return this._MarkId;
			}
			set
			{
				if ((this._MarkId != value))
				{
					this.OnMarkIdChanging(value);
					this.SendPropertyChanging();
					this._MarkId = value;
					this.SendPropertyChanged("MarkId");
					this.OnMarkIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					this.OnStudentIdChanging(value);
					this.SendPropertyChanging();
					this._StudentId = value;
					this.SendPropertyChanged("StudentId");
					this.OnStudentIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Group]")]
	public partial class Group : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _GroupId;
		
		private string _Title;
		
		private EntitySet<Student> _Student;
		
		private EntitySet<Exam> _Exam;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGroupIdChanging(int value);
    partial void OnGroupIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    #endregion
		
		public Group()
		{
			this._Student = new EntitySet<Student>(new Action<Student>(this.attach_Student), new Action<Student>(this.detach_Student));
			this._Exam = new EntitySet<Exam>(new Action<Exam>(this.attach_Exam), new Action<Exam>(this.detach_Exam));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					this.OnGroupIdChanging(value);
					this.SendPropertyChanging();
					this._GroupId = value;
					this.SendPropertyChanged("GroupId");
					this.OnGroupIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_Student", Storage="_Student", ThisKey="GroupId", OtherKey="GroupId")]
		public EntitySet<Student> Student
		{
			get
			{
				return this._Student;
			}
			set
			{
				this._Student.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_Exam", Storage="_Exam", ThisKey="GroupId", OtherKey="GroupId")]
		public EntitySet<Exam> Exam
		{
			get
			{
				return this._Exam;
			}
			set
			{
				this._Exam.Assign(value);
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
		
		private void attach_Student(Student entity)
		{
			this.SendPropertyChanging();
			entity.Group = this;
		}
		
		private void detach_Student(Student entity)
		{
			this.SendPropertyChanging();
			entity.Group = null;
		}
		
		private void attach_Exam(Exam entity)
		{
			this.SendPropertyChanging();
			entity.Group = this;
		}
		
		private void detach_Exam(Exam entity)
		{
			this.SendPropertyChanging();
			entity.Group = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mark")]
	public partial class Mark : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MarkId;
		
		private int _ExamId;
		
		private int _StudentId;
		
		private int _Mark1;
		
		private EntityRef<Exam> _Exam;
		
		private EntityRef<Student> _Student;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMarkIdChanging(int value);
    partial void OnMarkIdChanged();
    partial void OnExamIdChanging(int value);
    partial void OnExamIdChanged();
    partial void OnStudentIdChanging(int value);
    partial void OnStudentIdChanged();
    partial void OnMark1Changing(int value);
    partial void OnMark1Changed();
    #endregion
		
		public Mark()
		{
			this._Exam = default(EntityRef<Exam>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MarkId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MarkId
		{
			get
			{
				return this._MarkId;
			}
			set
			{
				if ((this._MarkId != value))
				{
					this.OnMarkIdChanging(value);
					this.SendPropertyChanging();
					this._MarkId = value;
					this.SendPropertyChanged("MarkId");
					this.OnMarkIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExamId", DbType="Int NOT NULL")]
		public int ExamId
		{
			get
			{
				return this._ExamId;
			}
			set
			{
				if ((this._ExamId != value))
				{
					if (this._Exam.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnExamIdChanging(value);
					this.SendPropertyChanging();
					this._ExamId = value;
					this.SendPropertyChanged("ExamId");
					this.OnExamIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int NOT NULL")]
		public int StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentIdChanging(value);
					this.SendPropertyChanging();
					this._StudentId = value;
					this.SendPropertyChanged("StudentId");
					this.OnStudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Mark", Storage="_Mark1", DbType="Int NOT NULL")]
		public int Mark1
		{
			get
			{
				return this._Mark1;
			}
			set
			{
				if ((this._Mark1 != value))
				{
					this.OnMark1Changing(value);
					this.SendPropertyChanging();
					this._Mark1 = value;
					this.SendPropertyChanged("Mark1");
					this.OnMark1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Exam_Mark", Storage="_Exam", ThisKey="ExamId", OtherKey="ExamId", IsForeignKey=true)]
		public Exam Exam
		{
			get
			{
				return this._Exam.Entity;
			}
			set
			{
				Exam previousValue = this._Exam.Entity;
				if (((previousValue != value) 
							|| (this._Exam.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Exam.Entity = null;
						previousValue.Mark.Remove(this);
					}
					this._Exam.Entity = value;
					if ((value != null))
					{
						value.Mark.Add(this);
						this._ExamId = value.ExamId;
					}
					else
					{
						this._ExamId = default(int);
					}
					this.SendPropertyChanged("Exam");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Mark", Storage="_Student", ThisKey="StudentId", OtherKey="StudentId", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Mark.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Mark.Add(this);
						this._StudentId = value.StudentId;
					}
					else
					{
						this._StudentId = default(int);
					}
					this.SendPropertyChanged("Student");
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
