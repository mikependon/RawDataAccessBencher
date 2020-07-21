﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.7.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Linq;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AdventureWorks.Dal.Adapter.EntityClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;

namespace AdventureWorks.Dal.Adapter.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData: ILinqMetaData
	{
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null) { }
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null) { }

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			this.AdapterToUse = adapterToUse;
			this.CustomFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			switch((AdventureWorks.Dal.Adapter.EntityType)typeOfEntity)
			{
				case AdventureWorks.Dal.Adapter.EntityType.AddressEntity:
					return this.Address;
				case AdventureWorks.Dal.Adapter.EntityType.AddressTypeEntity:
					return this.AddressType;
				case AdventureWorks.Dal.Adapter.EntityType.BillOfMaterialEntity:
					return this.BillOfMaterial;
				case AdventureWorks.Dal.Adapter.EntityType.BusinessEntityEntity:
					return this.BusinessEntity;
				case AdventureWorks.Dal.Adapter.EntityType.BusinessEntityAddressEntity:
					return this.BusinessEntityAddress;
				case AdventureWorks.Dal.Adapter.EntityType.BusinessEntityContactEntity:
					return this.BusinessEntityContact;
				case AdventureWorks.Dal.Adapter.EntityType.ContactCreditCardEntity:
					return this.ContactCreditCard;
				case AdventureWorks.Dal.Adapter.EntityType.ContactTypeEntity:
					return this.ContactType;
				case AdventureWorks.Dal.Adapter.EntityType.CountryRegionEntity:
					return this.CountryRegion;
				case AdventureWorks.Dal.Adapter.EntityType.CountryRegionCurrencyEntity:
					return this.CountryRegionCurrency;
				case AdventureWorks.Dal.Adapter.EntityType.CreditCardEntity:
					return this.CreditCard;
				case AdventureWorks.Dal.Adapter.EntityType.CultureEntity:
					return this.Culture;
				case AdventureWorks.Dal.Adapter.EntityType.CurrencyEntity:
					return this.Currency;
				case AdventureWorks.Dal.Adapter.EntityType.CurrencyRateEntity:
					return this.CurrencyRate;
				case AdventureWorks.Dal.Adapter.EntityType.CustomerEntity:
					return this.Customer;
				case AdventureWorks.Dal.Adapter.EntityType.DepartmentEntity:
					return this.Department;
				case AdventureWorks.Dal.Adapter.EntityType.DocumentEntity:
					return this.Document;
				case AdventureWorks.Dal.Adapter.EntityType.EmailAddressEntity:
					return this.EmailAddress;
				case AdventureWorks.Dal.Adapter.EntityType.EmployeeEntity:
					return this.Employee;
				case AdventureWorks.Dal.Adapter.EntityType.EmployeeDepartmentHistoryEntity:
					return this.EmployeeDepartmentHistory;
				case AdventureWorks.Dal.Adapter.EntityType.EmployeePayHistoryEntity:
					return this.EmployeePayHistory;
				case AdventureWorks.Dal.Adapter.EntityType.IllustrationEntity:
					return this.Illustration;
				case AdventureWorks.Dal.Adapter.EntityType.JobCandidateEntity:
					return this.JobCandidate;
				case AdventureWorks.Dal.Adapter.EntityType.LocationEntity:
					return this.Location;
				case AdventureWorks.Dal.Adapter.EntityType.PasswordEntity:
					return this.Password;
				case AdventureWorks.Dal.Adapter.EntityType.PersonEntity:
					return this.Person;
				case AdventureWorks.Dal.Adapter.EntityType.PersonPhoneEntity:
					return this.PersonPhone;
				case AdventureWorks.Dal.Adapter.EntityType.PhoneNumberTypeEntity:
					return this.PhoneNumberType;
				case AdventureWorks.Dal.Adapter.EntityType.ProductEntity:
					return this.Product;
				case AdventureWorks.Dal.Adapter.EntityType.ProductCategoryEntity:
					return this.ProductCategory;
				case AdventureWorks.Dal.Adapter.EntityType.ProductCostHistoryEntity:
					return this.ProductCostHistory;
				case AdventureWorks.Dal.Adapter.EntityType.ProductDescriptionEntity:
					return this.ProductDescription;
				case AdventureWorks.Dal.Adapter.EntityType.ProductDocumentEntity:
					return this.ProductDocument;
				case AdventureWorks.Dal.Adapter.EntityType.ProductInventoryEntity:
					return this.ProductInventory;
				case AdventureWorks.Dal.Adapter.EntityType.ProductListPriceHistoryEntity:
					return this.ProductListPriceHistory;
				case AdventureWorks.Dal.Adapter.EntityType.ProductModelEntity:
					return this.ProductModel;
				case AdventureWorks.Dal.Adapter.EntityType.ProductModelIllustrationEntity:
					return this.ProductModelIllustration;
				case AdventureWorks.Dal.Adapter.EntityType.ProductModelProductDescriptionCultureEntity:
					return this.ProductModelProductDescriptionCulture;
				case AdventureWorks.Dal.Adapter.EntityType.ProductPhotoEntity:
					return this.ProductPhoto;
				case AdventureWorks.Dal.Adapter.EntityType.ProductProductPhotoEntity:
					return this.ProductProductPhoto;
				case AdventureWorks.Dal.Adapter.EntityType.ProductReviewEntity:
					return this.ProductReview;
				case AdventureWorks.Dal.Adapter.EntityType.ProductSubcategoryEntity:
					return this.ProductSubcategory;
				case AdventureWorks.Dal.Adapter.EntityType.ProductVendorEntity:
					return this.ProductVendor;
				case AdventureWorks.Dal.Adapter.EntityType.PurchaseOrderDetailEntity:
					return this.PurchaseOrderDetail;
				case AdventureWorks.Dal.Adapter.EntityType.PurchaseOrderHeaderEntity:
					return this.PurchaseOrderHeader;
				case AdventureWorks.Dal.Adapter.EntityType.SalesOrderDetailEntity:
					return this.SalesOrderDetail;
				case AdventureWorks.Dal.Adapter.EntityType.SalesOrderHeaderEntity:
					return this.SalesOrderHeader;
				case AdventureWorks.Dal.Adapter.EntityType.SalesOrderHeaderSalesReasonEntity:
					return this.SalesOrderHeaderSalesReason;
				case AdventureWorks.Dal.Adapter.EntityType.SalesPersonEntity:
					return this.SalesPerson;
				case AdventureWorks.Dal.Adapter.EntityType.SalesPersonQuotaHistoryEntity:
					return this.SalesPersonQuotaHistory;
				case AdventureWorks.Dal.Adapter.EntityType.SalesReasonEntity:
					return this.SalesReason;
				case AdventureWorks.Dal.Adapter.EntityType.SalesTaxRateEntity:
					return this.SalesTaxRate;
				case AdventureWorks.Dal.Adapter.EntityType.SalesTerritoryEntity:
					return this.SalesTerritory;
				case AdventureWorks.Dal.Adapter.EntityType.SalesTerritoryHistoryEntity:
					return this.SalesTerritoryHistory;
				case AdventureWorks.Dal.Adapter.EntityType.ScrapReasonEntity:
					return this.ScrapReason;
				case AdventureWorks.Dal.Adapter.EntityType.ShiftEntity:
					return this.Shift;
				case AdventureWorks.Dal.Adapter.EntityType.ShipMethodEntity:
					return this.ShipMethod;
				case AdventureWorks.Dal.Adapter.EntityType.ShoppingCartItemEntity:
					return this.ShoppingCartItem;
				case AdventureWorks.Dal.Adapter.EntityType.SpecialOfferEntity:
					return this.SpecialOffer;
				case AdventureWorks.Dal.Adapter.EntityType.SpecialOfferProductEntity:
					return this.SpecialOfferProduct;
				case AdventureWorks.Dal.Adapter.EntityType.StateProvinceEntity:
					return this.StateProvince;
				case AdventureWorks.Dal.Adapter.EntityType.StoreEntity:
					return this.Store;
				case AdventureWorks.Dal.Adapter.EntityType.TransactionHistoryEntity:
					return this.TransactionHistory;
				case AdventureWorks.Dal.Adapter.EntityType.TransactionHistoryArchiveEntity:
					return this.TransactionHistoryArchive;
				case AdventureWorks.Dal.Adapter.EntityType.UnitMeasureEntity:
					return this.UnitMeasure;
				case AdventureWorks.Dal.Adapter.EntityType.VendorEntity:
					return this.Vendor;
				case AdventureWorks.Dal.Adapter.EntityType.WorkOrderEntity:
					return this.WorkOrder;
				case AdventureWorks.Dal.Adapter.EntityType.WorkOrderRoutingEntity:
					return this.WorkOrderRouting;
				default:
					return null;
			}
		}

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="TEntity">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public DataSource2<TEntity> GetQueryableForEntity<TEntity>()
				where TEntity : class
		{
			return new DataSource2<TEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse);
		}

		/// <summary>returns the datasource to use in a Linq query when targeting AddressEntity instances in the database.</summary>
		public DataSource2<AddressEntity> Address {	get { return new DataSource2<AddressEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting AddressTypeEntity instances in the database.</summary>
		public DataSource2<AddressTypeEntity> AddressType {	get { return new DataSource2<AddressTypeEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting BillOfMaterialEntity instances in the database.</summary>
		public DataSource2<BillOfMaterialEntity> BillOfMaterial {	get { return new DataSource2<BillOfMaterialEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting BusinessEntityEntity instances in the database.</summary>
		public DataSource2<BusinessEntityEntity> BusinessEntity {	get { return new DataSource2<BusinessEntityEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting BusinessEntityAddressEntity instances in the database.</summary>
		public DataSource2<BusinessEntityAddressEntity> BusinessEntityAddress {	get { return new DataSource2<BusinessEntityAddressEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting BusinessEntityContactEntity instances in the database.</summary>
		public DataSource2<BusinessEntityContactEntity> BusinessEntityContact {	get { return new DataSource2<BusinessEntityContactEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ContactCreditCardEntity instances in the database.</summary>
		public DataSource2<ContactCreditCardEntity> ContactCreditCard {	get { return new DataSource2<ContactCreditCardEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ContactTypeEntity instances in the database.</summary>
		public DataSource2<ContactTypeEntity> ContactType {	get { return new DataSource2<ContactTypeEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting CountryRegionEntity instances in the database.</summary>
		public DataSource2<CountryRegionEntity> CountryRegion {	get { return new DataSource2<CountryRegionEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting CountryRegionCurrencyEntity instances in the database.</summary>
		public DataSource2<CountryRegionCurrencyEntity> CountryRegionCurrency {	get { return new DataSource2<CountryRegionCurrencyEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting CreditCardEntity instances in the database.</summary>
		public DataSource2<CreditCardEntity> CreditCard {	get { return new DataSource2<CreditCardEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting CultureEntity instances in the database.</summary>
		public DataSource2<CultureEntity> Culture {	get { return new DataSource2<CultureEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting CurrencyEntity instances in the database.</summary>
		public DataSource2<CurrencyEntity> Currency {	get { return new DataSource2<CurrencyEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting CurrencyRateEntity instances in the database.</summary>
		public DataSource2<CurrencyRateEntity> CurrencyRate {	get { return new DataSource2<CurrencyRateEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerEntity instances in the database.</summary>
		public DataSource2<CustomerEntity> Customer {	get { return new DataSource2<CustomerEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting DepartmentEntity instances in the database.</summary>
		public DataSource2<DepartmentEntity> Department {	get { return new DataSource2<DepartmentEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting DocumentEntity instances in the database.</summary>
		public DataSource2<DocumentEntity> Document {	get { return new DataSource2<DocumentEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmailAddressEntity instances in the database.</summary>
		public DataSource2<EmailAddressEntity> EmailAddress {	get { return new DataSource2<EmailAddressEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource2<EmployeeEntity> Employee {	get { return new DataSource2<EmployeeEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeDepartmentHistoryEntity instances in the database.</summary>
		public DataSource2<EmployeeDepartmentHistoryEntity> EmployeeDepartmentHistory {	get { return new DataSource2<EmployeeDepartmentHistoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeePayHistoryEntity instances in the database.</summary>
		public DataSource2<EmployeePayHistoryEntity> EmployeePayHistory {	get { return new DataSource2<EmployeePayHistoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting IllustrationEntity instances in the database.</summary>
		public DataSource2<IllustrationEntity> Illustration {	get { return new DataSource2<IllustrationEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting JobCandidateEntity instances in the database.</summary>
		public DataSource2<JobCandidateEntity> JobCandidate {	get { return new DataSource2<JobCandidateEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting LocationEntity instances in the database.</summary>
		public DataSource2<LocationEntity> Location {	get { return new DataSource2<LocationEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting PasswordEntity instances in the database.</summary>
		public DataSource2<PasswordEntity> Password {	get { return new DataSource2<PasswordEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting PersonEntity instances in the database.</summary>
		public DataSource2<PersonEntity> Person {	get { return new DataSource2<PersonEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting PersonPhoneEntity instances in the database.</summary>
		public DataSource2<PersonPhoneEntity> PersonPhone {	get { return new DataSource2<PersonPhoneEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting PhoneNumberTypeEntity instances in the database.</summary>
		public DataSource2<PhoneNumberTypeEntity> PhoneNumberType {	get { return new DataSource2<PhoneNumberTypeEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductEntity instances in the database.</summary>
		public DataSource2<ProductEntity> Product {	get { return new DataSource2<ProductEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductCategoryEntity instances in the database.</summary>
		public DataSource2<ProductCategoryEntity> ProductCategory {	get { return new DataSource2<ProductCategoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductCostHistoryEntity instances in the database.</summary>
		public DataSource2<ProductCostHistoryEntity> ProductCostHistory {	get { return new DataSource2<ProductCostHistoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductDescriptionEntity instances in the database.</summary>
		public DataSource2<ProductDescriptionEntity> ProductDescription {	get { return new DataSource2<ProductDescriptionEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductDocumentEntity instances in the database.</summary>
		public DataSource2<ProductDocumentEntity> ProductDocument {	get { return new DataSource2<ProductDocumentEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductInventoryEntity instances in the database.</summary>
		public DataSource2<ProductInventoryEntity> ProductInventory {	get { return new DataSource2<ProductInventoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductListPriceHistoryEntity instances in the database.</summary>
		public DataSource2<ProductListPriceHistoryEntity> ProductListPriceHistory {	get { return new DataSource2<ProductListPriceHistoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductModelEntity instances in the database.</summary>
		public DataSource2<ProductModelEntity> ProductModel {	get { return new DataSource2<ProductModelEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductModelIllustrationEntity instances in the database.</summary>
		public DataSource2<ProductModelIllustrationEntity> ProductModelIllustration {	get { return new DataSource2<ProductModelIllustrationEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductModelProductDescriptionCultureEntity instances in the database.</summary>
		public DataSource2<ProductModelProductDescriptionCultureEntity> ProductModelProductDescriptionCulture {	get { return new DataSource2<ProductModelProductDescriptionCultureEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductPhotoEntity instances in the database.</summary>
		public DataSource2<ProductPhotoEntity> ProductPhoto {	get { return new DataSource2<ProductPhotoEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductProductPhotoEntity instances in the database.</summary>
		public DataSource2<ProductProductPhotoEntity> ProductProductPhoto {	get { return new DataSource2<ProductProductPhotoEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductReviewEntity instances in the database.</summary>
		public DataSource2<ProductReviewEntity> ProductReview {	get { return new DataSource2<ProductReviewEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductSubcategoryEntity instances in the database.</summary>
		public DataSource2<ProductSubcategoryEntity> ProductSubcategory {	get { return new DataSource2<ProductSubcategoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductVendorEntity instances in the database.</summary>
		public DataSource2<ProductVendorEntity> ProductVendor {	get { return new DataSource2<ProductVendorEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting PurchaseOrderDetailEntity instances in the database.</summary>
		public DataSource2<PurchaseOrderDetailEntity> PurchaseOrderDetail {	get { return new DataSource2<PurchaseOrderDetailEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting PurchaseOrderHeaderEntity instances in the database.</summary>
		public DataSource2<PurchaseOrderHeaderEntity> PurchaseOrderHeader {	get { return new DataSource2<PurchaseOrderHeaderEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesOrderDetailEntity instances in the database.</summary>
		public DataSource2<SalesOrderDetailEntity> SalesOrderDetail {	get { return new DataSource2<SalesOrderDetailEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesOrderHeaderEntity instances in the database.</summary>
		public DataSource2<SalesOrderHeaderEntity> SalesOrderHeader {	get { return new DataSource2<SalesOrderHeaderEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesOrderHeaderSalesReasonEntity instances in the database.</summary>
		public DataSource2<SalesOrderHeaderSalesReasonEntity> SalesOrderHeaderSalesReason {	get { return new DataSource2<SalesOrderHeaderSalesReasonEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesPersonEntity instances in the database.</summary>
		public DataSource2<SalesPersonEntity> SalesPerson {	get { return new DataSource2<SalesPersonEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesPersonQuotaHistoryEntity instances in the database.</summary>
		public DataSource2<SalesPersonQuotaHistoryEntity> SalesPersonQuotaHistory {	get { return new DataSource2<SalesPersonQuotaHistoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesReasonEntity instances in the database.</summary>
		public DataSource2<SalesReasonEntity> SalesReason {	get { return new DataSource2<SalesReasonEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesTaxRateEntity instances in the database.</summary>
		public DataSource2<SalesTaxRateEntity> SalesTaxRate {	get { return new DataSource2<SalesTaxRateEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesTerritoryEntity instances in the database.</summary>
		public DataSource2<SalesTerritoryEntity> SalesTerritory {	get { return new DataSource2<SalesTerritoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesTerritoryHistoryEntity instances in the database.</summary>
		public DataSource2<SalesTerritoryHistoryEntity> SalesTerritoryHistory {	get { return new DataSource2<SalesTerritoryHistoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ScrapReasonEntity instances in the database.</summary>
		public DataSource2<ScrapReasonEntity> ScrapReason {	get { return new DataSource2<ScrapReasonEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ShiftEntity instances in the database.</summary>
		public DataSource2<ShiftEntity> Shift {	get { return new DataSource2<ShiftEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ShipMethodEntity instances in the database.</summary>
		public DataSource2<ShipMethodEntity> ShipMethod {	get { return new DataSource2<ShipMethodEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ShoppingCartItemEntity instances in the database.</summary>
		public DataSource2<ShoppingCartItemEntity> ShoppingCartItem {	get { return new DataSource2<ShoppingCartItemEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SpecialOfferEntity instances in the database.</summary>
		public DataSource2<SpecialOfferEntity> SpecialOffer {	get { return new DataSource2<SpecialOfferEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SpecialOfferProductEntity instances in the database.</summary>
		public DataSource2<SpecialOfferProductEntity> SpecialOfferProduct {	get { return new DataSource2<SpecialOfferProductEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting StateProvinceEntity instances in the database.</summary>
		public DataSource2<StateProvinceEntity> StateProvince {	get { return new DataSource2<StateProvinceEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting StoreEntity instances in the database.</summary>
		public DataSource2<StoreEntity> Store {	get { return new DataSource2<StoreEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting TransactionHistoryEntity instances in the database.</summary>
		public DataSource2<TransactionHistoryEntity> TransactionHistory {	get { return new DataSource2<TransactionHistoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting TransactionHistoryArchiveEntity instances in the database.</summary>
		public DataSource2<TransactionHistoryArchiveEntity> TransactionHistoryArchive {	get { return new DataSource2<TransactionHistoryArchiveEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting UnitMeasureEntity instances in the database.</summary>
		public DataSource2<UnitMeasureEntity> UnitMeasure {	get { return new DataSource2<UnitMeasureEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting VendorEntity instances in the database.</summary>
		public DataSource2<VendorEntity> Vendor {	get { return new DataSource2<VendorEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderEntity instances in the database.</summary>
		public DataSource2<WorkOrderEntity> WorkOrder {	get { return new DataSource2<WorkOrderEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderRoutingEntity instances in the database.</summary>
		public DataSource2<WorkOrderRoutingEntity> WorkOrderRouting {	get { return new DataSource2<WorkOrderRoutingEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		

		/// <summary>returns the datasource to use in a Linq query when targeting SohLinqPoco instances in the database.</summary>
		public DataSource2<AdventureWorks.Dal.Adapter.TypedViewClasses.SohLinqPocoRow> SohLinqPoco
		{
			get { return new DataSource2<AdventureWorks.Dal.Adapter.TypedViewClasses.SohLinqPocoRow>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.SohLinqPocoTypedView }; }
		}


		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse { get; set; }
		
		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings { get; set; }
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse { get; set; }
	}
}