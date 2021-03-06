﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace AbCoreData
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AbDomainEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AbDomainEntities object using the connection string found in the 'AbDomainEntities' section of the application configuration file.
        /// </summary>
        public AbDomainEntities() : base("name=AbDomainEntities", "AbDomainEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AbDomainEntities object.
        /// </summary>
        public AbDomainEntities(string connectionString) : base(connectionString, "AbDomainEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AbDomainEntities object.
        /// </summary>
        public AbDomainEntities(EntityConnection connection) : base(connection, "AbDomainEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Book> Books
        {
            get
            {
                if ((_Books == null))
                {
                    _Books = base.CreateObjectSet<Book>("Books");
                }
                return _Books;
            }
        }
        private ObjectSet<Book> _Books;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Books EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBooks(Book book)
        {
            base.AddObject("Books", book);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AbDomainModel", Name="Book")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static Book CreateBook(global::System.Int32 id)
        {
            Book book = new Book();
            book.ID = id;
            return book;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String BookName
        {
            get
            {
                return _BookName;
            }
            set
            {
                OnBookNameChanging(value);
                ReportPropertyChanging("BookName");
                _BookName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("BookName");
                OnBookNameChanged();
            }
        }
        private global::System.String _BookName;
        partial void OnBookNameChanging(global::System.String value);
        partial void OnBookNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AuthorName
        {
            get
            {
                return _AuthorName;
            }
            set
            {
                OnAuthorNameChanging(value);
                ReportPropertyChanging("AuthorName");
                _AuthorName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AuthorName");
                OnAuthorNameChanged();
            }
        }
        private global::System.String _AuthorName;
        partial void OnAuthorNameChanging(global::System.String value);
        partial void OnAuthorNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ISBN
        {
            get
            {
                return _ISBN;
            }
            set
            {
                OnISBNChanging(value);
                ReportPropertyChanging("ISBN");
                _ISBN = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ISBN");
                OnISBNChanged();
            }
        }
        private global::System.String _ISBN;
        partial void OnISBNChanging(global::System.String value);
        partial void OnISBNChanged();

        #endregion
    
    }

    #endregion
    
}
