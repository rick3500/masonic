﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Guidance.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MasonicEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MasonicEntities object using the connection string found in the 'MasonicEntities' section of the application configuration file.
        /// </summary>
        public MasonicEntities() : base("name=MasonicEntities", "MasonicEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MasonicEntities object.
        /// </summary>
        public MasonicEntities(string connectionString) : base(connectionString, "MasonicEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MasonicEntities object.
        /// </summary>
        public MasonicEntities(EntityConnection connection) : base(connection, "MasonicEntities")
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
        public ObjectSet<Dinner> Dinners
        {
            get
            {
                if ((_Dinners == null))
                {
                    _Dinners = base.CreateObjectSet<Dinner>("Dinners");
                }
                return _Dinners;
            }
        }
        private ObjectSet<Dinner> _Dinners;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Dinners EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDinners(Dinner dinner)
        {
            base.AddObject("Dinners", dinner);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MasonicModel", Name="Dinner")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Dinner : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Dinner object.
        /// </summary>
        /// <param name="dinnerID">Initial value of the DinnerID property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="eventDate">Initial value of the EventDate property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="hostedBy">Initial value of the HostedBy property.</param>
        /// <param name="contactPhone">Initial value of the ContactPhone property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        /// <param name="country">Initial value of the Country property.</param>
        /// <param name="latitude">Initial value of the Latitude property.</param>
        /// <param name="longitude">Initial value of the Longitude property.</param>
        public static Dinner CreateDinner(global::System.Int32 dinnerID, global::System.String title, global::System.DateTime eventDate, global::System.String description, global::System.String hostedBy, global::System.String contactPhone, global::System.String address, global::System.String country, global::System.Double latitude, global::System.Double longitude)
        {
            Dinner dinner = new Dinner();
            dinner.DinnerID = dinnerID;
            dinner.Title = title;
            dinner.EventDate = eventDate;
            dinner.Description = description;
            dinner.HostedBy = hostedBy;
            dinner.ContactPhone = contactPhone;
            dinner.Address = address;
            dinner.Country = country;
            dinner.Latitude = latitude;
            dinner.Longitude = longitude;
            return dinner;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DinnerID
        {
            get
            {
                return _DinnerID;
            }
            set
            {
                if (_DinnerID != value)
                {
                    OnDinnerIDChanging(value);
                    ReportPropertyChanging("DinnerID");
                    _DinnerID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DinnerID");
                    OnDinnerIDChanged();
                }
            }
        }
        private global::System.Int32 _DinnerID;
        partial void OnDinnerIDChanging(global::System.Int32 value);
        partial void OnDinnerIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime EventDate
        {
            get
            {
                return _EventDate;
            }
            set
            {
                OnEventDateChanging(value);
                ReportPropertyChanging("EventDate");
                _EventDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EventDate");
                OnEventDateChanged();
            }
        }
        private global::System.DateTime _EventDate;
        partial void OnEventDateChanging(global::System.DateTime value);
        partial void OnEventDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String HostedBy
        {
            get
            {
                return _HostedBy;
            }
            set
            {
                OnHostedByChanging(value);
                ReportPropertyChanging("HostedBy");
                _HostedBy = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("HostedBy");
                OnHostedByChanged();
            }
        }
        private global::System.String _HostedBy;
        partial void OnHostedByChanging(global::System.String value);
        partial void OnHostedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ContactPhone
        {
            get
            {
                return _ContactPhone;
            }
            set
            {
                OnContactPhoneChanging(value);
                ReportPropertyChanging("ContactPhone");
                _ContactPhone = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ContactPhone");
                OnContactPhoneChanged();
            }
        }
        private global::System.String _ContactPhone;
        partial void OnContactPhoneChanging(global::System.String value);
        partial void OnContactPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Country
        {
            get
            {
                return _Country;
            }
            set
            {
                OnCountryChanging(value);
                ReportPropertyChanging("Country");
                _Country = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Country");
                OnCountryChanged();
            }
        }
        private global::System.String _Country;
        partial void OnCountryChanging(global::System.String value);
        partial void OnCountryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double Latitude
        {
            get
            {
                return _Latitude;
            }
            set
            {
                OnLatitudeChanging(value);
                ReportPropertyChanging("Latitude");
                _Latitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Latitude");
                OnLatitudeChanged();
            }
        }
        private global::System.Double _Latitude;
        partial void OnLatitudeChanging(global::System.Double value);
        partial void OnLatitudeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double Longitude
        {
            get
            {
                return _Longitude;
            }
            set
            {
                OnLongitudeChanging(value);
                ReportPropertyChanging("Longitude");
                _Longitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Longitude");
                OnLongitudeChanged();
            }
        }
        private global::System.Double _Longitude;
        partial void OnLongitudeChanging(global::System.Double value);
        partial void OnLongitudeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String HostedById
        {
            get
            {
                return _HostedById;
            }
            set
            {
                OnHostedByIdChanging(value);
                ReportPropertyChanging("HostedById");
                _HostedById = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("HostedById");
                OnHostedByIdChanged();
            }
        }
        private global::System.String _HostedById;
        partial void OnHostedByIdChanging(global::System.String value);
        partial void OnHostedByIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> LocationType
        {
            get
            {
                return _LocationType;
            }
            set
            {
                OnLocationTypeChanging(value);
                ReportPropertyChanging("LocationType");
                _LocationType = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LocationType");
                OnLocationTypeChanged();
            }
        }
        private Nullable<global::System.Int32> _LocationType;
        partial void OnLocationTypeChanging(Nullable<global::System.Int32> value);
        partial void OnLocationTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String WebSite
        {
            get
            {
                return _WebSite;
            }
            set
            {
                OnWebSiteChanging(value);
                ReportPropertyChanging("WebSite");
                _WebSite = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("WebSite");
                OnWebSiteChanged();
            }
        }
        private global::System.String _WebSite;
        partial void OnWebSiteChanging(global::System.String value);
        partial void OnWebSiteChanged();

        #endregion

    
    }

    #endregion

    
}