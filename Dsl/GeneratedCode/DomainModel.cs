﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
namespace SchneiderElectricDMS.PowerFunctionsReportDSL
{
	/// <summary>
	/// DomainModel PowerFunctionsReportDSLDomainModel
	/// Description for
	/// SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSL
	/// </summary>
	[DslDesign::DisplayNameResource("SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSLDomainModel.DisplayName", typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSLDomainModel), "SchneiderElectricDMS.PowerFunctionsReportDSL.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSLDomainModel.Description", typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSLDomainModel), "SchneiderElectricDMS.PowerFunctionsReportDSL.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("6a145a5d-3ec1-4a73-ae06-63c45873e65a")]
	public partial class PowerFunctionsReportDSLDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// PowerFunctionsReportDSLDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0x6a145a5d, 0x3ec1, 0x4a73, 0xae, 0x06, 0x63, 0xc4, 0x58, 0x73, 0xe6, 0x5a);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public PowerFunctionsReportDSLDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(ModelRoot),
				typeof(Comment),
				typeof(ModelType),
				typeof(NamedElement),
				typeof(JMSModel),
				typeof(ClassModelElement),
				typeof(ClassAttribute),
				typeof(ModelRootHasComments),
				typeof(CommentReferencesModelTyped),
				typeof(ModelRootHasTypes),
				typeof(JMSModelHasAttributes),
				typeof(PowerFunctionsReportDSLDiagram),
				typeof(CommentConnector),
				typeof(CommentShape),
				typeof(JMSModelShape),
				typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.FixUpDiagram),
				typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.ConnectorRolePlayerChanged),
				typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemAddRule),
				typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemDeleteRule),
				typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemRolePlayerChangeRule),
				typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemRolePlayerPositionChangeRule),
				typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemChangeRule),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(NamedElement), "Name", NamedElement.NameDomainPropertyId, typeof(NamedElement.NamePropertyHandler)),
				new DomainMemberInfo(typeof(ClassModelElement), "Description", ClassModelElement.DescriptionDomainPropertyId, typeof(ClassModelElement.DescriptionPropertyHandler)),
				new DomainMemberInfo(typeof(ClassAttribute), "InitialValue", ClassAttribute.InitialValueDomainPropertyId, typeof(ClassAttribute.InitialValuePropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(ModelRootHasComments), "ModelRoot", ModelRootHasComments.ModelRootDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelRootHasComments), "Comment", ModelRootHasComments.CommentDomainRoleId),
				new DomainRolePlayerInfo(typeof(CommentReferencesModelTyped), "Comment", CommentReferencesModelTyped.CommentDomainRoleId),
				new DomainRolePlayerInfo(typeof(CommentReferencesModelTyped), "ModelType", CommentReferencesModelTyped.ModelTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelRootHasTypes), "ModelRoot", ModelRootHasTypes.ModelRootDomainRoleId),
				new DomainRolePlayerInfo(typeof(ModelRootHasTypes), "ModelType", ModelRootHasTypes.ModelTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(JMSModelHasAttributes), "JMSModel", JMSModelHasAttributes.JMSModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(JMSModelHasAttributes), "ClassAttribute", JMSModelHasAttributes.ClassAttributeDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(11);
				createElementMap.Add(typeof(ModelRoot), 0);
				createElementMap.Add(typeof(Comment), 1);
				createElementMap.Add(typeof(NamedElement), 2);
				createElementMap.Add(typeof(JMSModel), 3);
				createElementMap.Add(typeof(ClassAttribute), 4);
				createElementMap.Add(typeof(PowerFunctionsReportDSLDiagram), 5);
				createElementMap.Add(typeof(CommentConnector), 6);
				createElementMap.Add(typeof(CommentShape), 7);
				createElementMap.Add(typeof(JMSModelShape), 8);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSLDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new ModelRoot(partition, propertyAssignments);
				case 1: return new Comment(partition, propertyAssignments);
				case 2: return new NamedElement(partition, propertyAssignments);
				case 3: return new JMSModel(partition, propertyAssignments);
				case 4: return new ClassAttribute(partition, propertyAssignments);
				case 5: return new PowerFunctionsReportDSLDiagram(partition, propertyAssignments);
				case 6: return new CommentConnector(partition, propertyAssignments);
				case 7: return new CommentShape(partition, propertyAssignments);
				case 8: return new JMSModelShape(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(4);
				createElementLinkMap.Add(typeof(ModelRootHasComments), 0);
				createElementLinkMap.Add(typeof(CommentReferencesModelTyped), 1);
				createElementLinkMap.Add(typeof(ModelRootHasTypes), 2);
				createElementLinkMap.Add(typeof(JMSModelHasAttributes), 3);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSLDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new ModelRootHasComments(partition, roleAssignments, propertyAssignments);
				case 1: return new CommentReferencesModelTyped(partition, roleAssignments, propertyAssignments);
				case 2: return new ModelRootHasTypes(partition, roleAssignments, propertyAssignments);
				case 3: return new JMSModelHasAttributes(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "SchneiderElectricDMS.PowerFunctionsReportDSL.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return PowerFunctionsReportDSLDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (PowerFunctionsReportDSLDomainModel.resourceManager == null)
				{
					PowerFunctionsReportDSLDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(PowerFunctionsReportDSLDomainModel).Assembly);
				}
				return PowerFunctionsReportDSLDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return PowerFunctionsReportDSLDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return PowerFunctionsReportDSLDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (PowerFunctionsReportDSLDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new PowerFunctionsReportDSLCopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					PowerFunctionsReportDSLDomainModel.copyClosure = copyFilter;
				}
				return PowerFunctionsReportDSLDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (PowerFunctionsReportDSLDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new PowerFunctionsReportDSLDeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					PowerFunctionsReportDSLDomainModel.removeClosure = removeFilter;
				}
				return PowerFunctionsReportDSLDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.ConnectorRolePlayerChanged));
			ruleManager.EnableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemAddRule));
			ruleManager.EnableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemDeleteRule));
			ruleManager.EnableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemRolePlayerChangeRule));
			ruleManager.EnableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.EnableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemChangeRule));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.ConnectorRolePlayerChanged));
			ruleManager.DisableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemAddRule));
			ruleManager.DisableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemDeleteRule));
			ruleManager.DisableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemRolePlayerChangeRule));
			ruleManager.DisableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.DisableRule(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.CompartmentItemChangeRule));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class PowerFunctionsReportDSLDeleteClosure : PowerFunctionsReportDSLDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public PowerFunctionsReportDSLDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class PowerFunctionsReportDSLDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public PowerFunctionsReportDSLDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::SchneiderElectricDMS.PowerFunctionsReportDSL.ModelRootHasComments.CommentDomainRoleId, true);
			DomainRoles.Add(global::SchneiderElectricDMS.PowerFunctionsReportDSL.ModelRootHasTypes.ModelTypeDomainRoleId, true);
			DomainRoles.Add(global::SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModelHasAttributes.ClassAttributeDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class PowerFunctionsReportDSLCopyClosure : PowerFunctionsReportDSLCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public PowerFunctionsReportDSLCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class PowerFunctionsReportDSLCopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public PowerFunctionsReportDSLCopyClosureBase():base()
		{
		}
	}
	#endregion
		
}

