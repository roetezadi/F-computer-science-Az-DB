﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KetabKhan.Linq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DBLab")]
	public partial class DBTest1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertExam(Exam instance);
    partial void UpdateExam(Exam instance);
    partial void DeleteExam(Exam instance);
    partial void InsertExamQuestion(ExamQuestion instance);
    partial void UpdateExamQuestion(ExamQuestion instance);
    partial void DeleteExamQuestion(ExamQuestion instance);
    partial void InsertExamChoice(ExamChoice instance);
    partial void UpdateExamChoice(ExamChoice instance);
    partial void DeleteExamChoice(ExamChoice instance);
    #endregion
		
		public DBTest1DataContext() : 
				base(global::KetabKhan.Properties.Settings.Default.DBLabConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBTest1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBTest1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBTest1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBTest1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Exam> Exams
		{
			get
			{
				return this.GetTable<Exam>();
			}
		}
		
		public System.Data.Linq.Table<ExamQuestion> ExamQuestions
		{
			get
			{
				return this.GetTable<ExamQuestion>();
			}
		}
		
		public System.Data.Linq.Table<ExamChoice> ExamChoices
		{
			get
			{
				return this.GetTable<ExamChoice>();
			}
		}
		
		public System.Data.Linq.Table<UserTakeExam> UserTakeExams
		{
			get
			{
				return this.GetTable<UserTakeExam>();
			}
		}
		
		public System.Data.Linq.Table<ExamDate> ExamDates
		{
			get
			{
				return this.GetTable<ExamDate>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Exam")]
	public partial class Exam : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ExamID;
		
		private string _ExamName;
		
		private System.Nullable<long> _UserID;
		
		private EntitySet<ExamQuestion> _ExamQuestions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExamIDChanging(long value);
    partial void OnExamIDChanged();
    partial void OnExamNameChanging(string value);
    partial void OnExamNameChanged();
    partial void OnUserIDChanging(System.Nullable<long> value);
    partial void OnUserIDChanged();
    #endregion
		
		public Exam()
		{
			this._ExamQuestions = new EntitySet<ExamQuestion>(new Action<ExamQuestion>(this.attach_ExamQuestions), new Action<ExamQuestion>(this.detach_ExamQuestions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExamID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long ExamID
		{
			get
			{
				return this._ExamID;
			}
			set
			{
				if ((this._ExamID != value))
				{
					this.OnExamIDChanging(value);
					this.SendPropertyChanging();
					this._ExamID = value;
					this.SendPropertyChanged("ExamID");
					this.OnExamIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExamName", DbType="NChar(10)")]
		public string ExamName
		{
			get
			{
				return this._ExamName;
			}
			set
			{
				if ((this._ExamName != value))
				{
					this.OnExamNameChanging(value);
					this.SendPropertyChanging();
					this._ExamName = value;
					this.SendPropertyChanged("ExamName");
					this.OnExamNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="BigInt")]
		public System.Nullable<long> UserID
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Exam_ExamQuestion", Storage="_ExamQuestions", ThisKey="ExamID", OtherKey="ExamID")]
		public EntitySet<ExamQuestion> ExamQuestions
		{
			get
			{
				return this._ExamQuestions;
			}
			set
			{
				this._ExamQuestions.Assign(value);
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
		
		private void attach_ExamQuestions(ExamQuestion entity)
		{
			this.SendPropertyChanging();
			entity.Exam = this;
		}
		
		private void detach_ExamQuestions(ExamQuestion entity)
		{
			this.SendPropertyChanging();
			entity.Exam = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExamQuestion")]
	public partial class ExamQuestion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _QuestionID;
		
		private System.Nullable<long> _ExamID;
		
		private string _Question;
		
		private string _RightAnswer;
		
		private EntitySet<ExamChoice> _ExamChoices;
		
		private EntityRef<Exam> _Exam;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuestionIDChanging(long value);
    partial void OnQuestionIDChanged();
    partial void OnExamIDChanging(System.Nullable<long> value);
    partial void OnExamIDChanged();
    partial void OnQuestionChanging(string value);
    partial void OnQuestionChanged();
    partial void OnRightAnswerChanging(string value);
    partial void OnRightAnswerChanged();
    #endregion
		
		public ExamQuestion()
		{
			this._ExamChoices = new EntitySet<ExamChoice>(new Action<ExamChoice>(this.attach_ExamChoices), new Action<ExamChoice>(this.detach_ExamChoices));
			this._Exam = default(EntityRef<Exam>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long QuestionID
		{
			get
			{
				return this._QuestionID;
			}
			set
			{
				if ((this._QuestionID != value))
				{
					this.OnQuestionIDChanging(value);
					this.SendPropertyChanging();
					this._QuestionID = value;
					this.SendPropertyChanged("QuestionID");
					this.OnQuestionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExamID", DbType="BigInt")]
		public System.Nullable<long> ExamID
		{
			get
			{
				return this._ExamID;
			}
			set
			{
				if ((this._ExamID != value))
				{
					if (this._Exam.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnExamIDChanging(value);
					this.SendPropertyChanging();
					this._ExamID = value;
					this.SendPropertyChanged("ExamID");
					this.OnExamIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Question", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Question
		{
			get
			{
				return this._Question;
			}
			set
			{
				if ((this._Question != value))
				{
					this.OnQuestionChanging(value);
					this.SendPropertyChanging();
					this._Question = value;
					this.SendPropertyChanged("Question");
					this.OnQuestionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RightAnswer", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string RightAnswer
		{
			get
			{
				return this._RightAnswer;
			}
			set
			{
				if ((this._RightAnswer != value))
				{
					this.OnRightAnswerChanging(value);
					this.SendPropertyChanging();
					this._RightAnswer = value;
					this.SendPropertyChanged("RightAnswer");
					this.OnRightAnswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ExamQuestion_ExamChoice", Storage="_ExamChoices", ThisKey="QuestionID", OtherKey="QuestionID")]
		public EntitySet<ExamChoice> ExamChoices
		{
			get
			{
				return this._ExamChoices;
			}
			set
			{
				this._ExamChoices.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Exam_ExamQuestion", Storage="_Exam", ThisKey="ExamID", OtherKey="ExamID", IsForeignKey=true)]
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
						previousValue.ExamQuestions.Remove(this);
					}
					this._Exam.Entity = value;
					if ((value != null))
					{
						value.ExamQuestions.Add(this);
						this._ExamID = value.ExamID;
					}
					else
					{
						this._ExamID = default(Nullable<long>);
					}
					this.SendPropertyChanged("Exam");
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
		
		private void attach_ExamChoices(ExamChoice entity)
		{
			this.SendPropertyChanging();
			entity.ExamQuestion = this;
		}
		
		private void detach_ExamChoices(ExamChoice entity)
		{
			this.SendPropertyChanging();
			entity.ExamQuestion = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExamChoices")]
	public partial class ExamChoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ChoiceID;
		
		private string _Choice;
		
		private System.Nullable<bool> _RightAnswer;
		
		private System.Nullable<long> _QuestionID;
		
		private EntityRef<ExamQuestion> _ExamQuestion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnChoiceIDChanging(long value);
    partial void OnChoiceIDChanged();
    partial void OnChoiceChanging(string value);
    partial void OnChoiceChanged();
    partial void OnRightAnswerChanging(System.Nullable<bool> value);
    partial void OnRightAnswerChanged();
    partial void OnQuestionIDChanging(System.Nullable<long> value);
    partial void OnQuestionIDChanged();
    #endregion
		
		public ExamChoice()
		{
			this._ExamQuestion = default(EntityRef<ExamQuestion>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChoiceID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long ChoiceID
		{
			get
			{
				return this._ChoiceID;
			}
			set
			{
				if ((this._ChoiceID != value))
				{
					this.OnChoiceIDChanging(value);
					this.SendPropertyChanging();
					this._ChoiceID = value;
					this.SendPropertyChanged("ChoiceID");
					this.OnChoiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Choice", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Choice
		{
			get
			{
				return this._Choice;
			}
			set
			{
				if ((this._Choice != value))
				{
					this.OnChoiceChanging(value);
					this.SendPropertyChanging();
					this._Choice = value;
					this.SendPropertyChanged("Choice");
					this.OnChoiceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RightAnswer", DbType="Bit")]
		public System.Nullable<bool> RightAnswer
		{
			get
			{
				return this._RightAnswer;
			}
			set
			{
				if ((this._RightAnswer != value))
				{
					this.OnRightAnswerChanging(value);
					this.SendPropertyChanging();
					this._RightAnswer = value;
					this.SendPropertyChanged("RightAnswer");
					this.OnRightAnswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionID", DbType="BigInt")]
		public System.Nullable<long> QuestionID
		{
			get
			{
				return this._QuestionID;
			}
			set
			{
				if ((this._QuestionID != value))
				{
					if (this._ExamQuestion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionIDChanging(value);
					this.SendPropertyChanging();
					this._QuestionID = value;
					this.SendPropertyChanged("QuestionID");
					this.OnQuestionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ExamQuestion_ExamChoice", Storage="_ExamQuestion", ThisKey="QuestionID", OtherKey="QuestionID", IsForeignKey=true)]
		public ExamQuestion ExamQuestion
		{
			get
			{
				return this._ExamQuestion.Entity;
			}
			set
			{
				ExamQuestion previousValue = this._ExamQuestion.Entity;
				if (((previousValue != value) 
							|| (this._ExamQuestion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ExamQuestion.Entity = null;
						previousValue.ExamChoices.Remove(this);
					}
					this._ExamQuestion.Entity = value;
					if ((value != null))
					{
						value.ExamChoices.Add(this);
						this._QuestionID = value.QuestionID;
					}
					else
					{
						this._QuestionID = default(Nullable<long>);
					}
					this.SendPropertyChanged("ExamQuestion");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserTakeExam")]
	public partial class UserTakeExam
	{
		
		private System.Nullable<long> _UserID;
		
		private System.Nullable<long> _ExamID;
		
		private System.Nullable<long> _QuestionID;
		
		private string _Answer;
		
		public UserTakeExam()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="BigInt")]
		public System.Nullable<long> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExamID", DbType="BigInt")]
		public System.Nullable<long> ExamID
		{
			get
			{
				return this._ExamID;
			}
			set
			{
				if ((this._ExamID != value))
				{
					this._ExamID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionID", DbType="BigInt")]
		public System.Nullable<long> QuestionID
		{
			get
			{
				return this._QuestionID;
			}
			set
			{
				if ((this._QuestionID != value))
				{
					this._QuestionID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Answer
		{
			get
			{
				return this._Answer;
			}
			set
			{
				if ((this._Answer != value))
				{
					this._Answer = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExamDate")]
	public partial class ExamDate
	{
		
		private System.Nullable<long> _ExamID;
		
		private System.Nullable<System.DateTime> _Time;
		
		public ExamDate()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExamID", DbType="BigInt")]
		public System.Nullable<long> ExamID
		{
			get
			{
				return this._ExamID;
			}
			set
			{
				if ((this._ExamID != value))
				{
					this._ExamID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="DateTime")]
		public System.Nullable<System.DateTime> Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this._Time = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
