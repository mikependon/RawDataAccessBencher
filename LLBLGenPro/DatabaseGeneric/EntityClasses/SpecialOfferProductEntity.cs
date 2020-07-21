﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.7.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'SpecialOfferProduct'.<br/><br/></summary>
	[Serializable]
	public partial class SpecialOfferProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<SalesOrderDetailEntity> _salesOrderDetails;
		private ProductEntity _product;
		private SpecialOfferEntity _specialOffer;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static SpecialOfferProductEntityStaticMetaData _staticMetaData = new SpecialOfferProductEntityStaticMetaData();
		private static SpecialOfferProductRelations _relationsFactory = new SpecialOfferProductRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name SpecialOffer</summary>
			public static readonly string SpecialOffer = "SpecialOffer";
			/// <summary>Member name SalesOrderDetails</summary>
			public static readonly string SalesOrderDetails = "SalesOrderDetails";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class SpecialOfferProductEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public SpecialOfferProductEntityStaticMetaData()
			{
				SetEntityCoreInfo("SpecialOfferProductEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.SpecialOfferProductEntity, typeof(SpecialOfferProductEntity), typeof(SpecialOfferProductEntityFactory), false);
				AddNavigatorMetaData<SpecialOfferProductEntity, EntityCollection<SalesOrderDetailEntity>>("SalesOrderDetails", a => a._salesOrderDetails, (a, b) => a._salesOrderDetails = b, a => a.SalesOrderDetails, () => new SpecialOfferProductRelations().SalesOrderDetailEntityUsingProductIdSpecialOfferId, typeof(SalesOrderDetailEntity), (int)AdventureWorks.Dal.Adapter.EntityType.SalesOrderDetailEntity);
				AddNavigatorMetaData<SpecialOfferProductEntity, ProductEntity>("Product", "SpecialOfferProducts", (a, b) => a._product = b, a => a._product, (a, b) => a.Product = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticSpecialOfferProductRelations.ProductEntityUsingProductIdStatic, ()=>new SpecialOfferProductRelations().ProductEntityUsingProductId, null, new int[] { (int)SpecialOfferProductFieldIndex.ProductId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.ProductEntity);
				AddNavigatorMetaData<SpecialOfferProductEntity, SpecialOfferEntity>("SpecialOffer", "SpecialOfferProducts", (a, b) => a._specialOffer = b, a => a._specialOffer, (a, b) => a.SpecialOffer = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticSpecialOfferProductRelations.SpecialOfferEntityUsingSpecialOfferIdStatic, ()=>new SpecialOfferProductRelations().SpecialOfferEntityUsingSpecialOfferId, null, new int[] { (int)SpecialOfferProductFieldIndex.SpecialOfferId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.SpecialOfferEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static SpecialOfferProductEntity()
		{
		}

		/// <summary> CTor</summary>
		public SpecialOfferProductEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SpecialOfferProductEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SpecialOfferProductEntity</param>
		public SpecialOfferProductEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="productId">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferId">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		public SpecialOfferProductEntity(System.Int32 productId, System.Int32 specialOfferId) : this(productId, specialOfferId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="productId">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferId">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="validator">The custom validator object for this SpecialOfferProductEntity</param>
		public SpecialOfferProductEntity(System.Int32 productId, System.Int32 specialOfferId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.ProductId = productId;
			this.SpecialOfferId = specialOfferId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SpecialOfferProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderDetail' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderDetails() { return CreateRelationInfoForNavigator("SalesOrderDetails"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProduct() { return CreateRelationInfoForNavigator("Product"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SpecialOffer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSpecialOffer() { return CreateRelationInfoForNavigator("SpecialOffer"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SpecialOfferProductEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static SpecialOfferProductRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderDetails { get { return _staticMetaData.GetPrefetchPathElement("SalesOrderDetails", CommonEntityBase.CreateEntityCollection<SalesOrderDetailEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct { get { return _staticMetaData.GetPrefetchPathElement("Product", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SpecialOffer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSpecialOffer { get { return _staticMetaData.GetPrefetchPathElement("SpecialOffer", CommonEntityBase.CreateEntityCollection<SpecialOfferEntity>()); } }

		/// <summary>The ModifiedDate property of the Entity SpecialOfferProduct<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SpecialOfferProductFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The ProductId property of the Entity SpecialOfferProduct<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."ProductID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)SpecialOfferProductFieldIndex.ProductId, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.ProductId, value); }
		}

		/// <summary>The Rowguid property of the Entity SpecialOfferProduct<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SpecialOfferProductFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.Rowguid, value); }
		}

		/// <summary>The SpecialOfferId property of the Entity SpecialOfferProduct<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."SpecialOfferID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SpecialOfferId
		{
			get { return (System.Int32)GetValue((int)SpecialOfferProductFieldIndex.SpecialOfferId, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.SpecialOfferId, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesOrderDetailEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderDetailEntity))]
		public virtual EntityCollection<SalesOrderDetailEntity> SalesOrderDetails { get { return GetOrCreateEntityCollection<SalesOrderDetailEntity, SalesOrderDetailEntityFactory>("SpecialOfferProduct", true, false, ref _salesOrderDetails); } }

		/// <summary>Gets / sets related entity of type 'ProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get { return _product; }
			set { SetSingleRelatedEntityNavigator(value, "Product"); }
		}

		/// <summary>Gets / sets related entity of type 'SpecialOfferEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual SpecialOfferEntity SpecialOffer
		{
			get { return _specialOffer; }
			set { SetSingleRelatedEntityNavigator(value, "SpecialOffer"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum SpecialOfferProductFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SpecialOfferId. </summary>
		SpecialOfferId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: SpecialOfferProduct. </summary>
	public partial class SpecialOfferProductRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and SalesOrderDetailEntity over the 1:n relation they have, using the relation between the fields: SpecialOfferProduct.ProductId - SalesOrderDetail.ProductId, SpecialOfferProduct.SpecialOfferId - SalesOrderDetail.SpecialOfferId</summary>
		public virtual IEntityRelation SalesOrderDetailEntityUsingProductIdSpecialOfferId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesOrderDetails", true, new[] { SpecialOfferProductFields.ProductId, SalesOrderDetailFields.ProductId, SpecialOfferProductFields.SpecialOfferId, SalesOrderDetailFields.SpecialOfferId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and ProductEntity over the m:1 relation they have, using the relation between the fields: SpecialOfferProduct.ProductId - Product.ProductId</summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Product", false, new[] { ProductFields.ProductId, SpecialOfferProductFields.ProductId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and SpecialOfferEntity over the m:1 relation they have, using the relation between the fields: SpecialOfferProduct.SpecialOfferId - SpecialOffer.SpecialOfferId</summary>
		public virtual IEntityRelation SpecialOfferEntityUsingSpecialOfferId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "SpecialOffer", false, new[] { SpecialOfferFields.SpecialOfferId, SpecialOfferProductFields.SpecialOfferId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSpecialOfferProductRelations
	{
		internal static readonly IEntityRelation SalesOrderDetailEntityUsingProductIdSpecialOfferIdStatic = new SpecialOfferProductRelations().SalesOrderDetailEntityUsingProductIdSpecialOfferId;
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new SpecialOfferProductRelations().ProductEntityUsingProductId;
		internal static readonly IEntityRelation SpecialOfferEntityUsingSpecialOfferIdStatic = new SpecialOfferProductRelations().SpecialOfferEntityUsingSpecialOfferId;

		/// <summary>CTor</summary>
		static StaticSpecialOfferProductRelations() { }
	}
}
