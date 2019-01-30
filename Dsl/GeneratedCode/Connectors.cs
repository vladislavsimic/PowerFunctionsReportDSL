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
	/// DomainClass CommentConnector
	/// Description for SchneiderElectricDMS.PowerFunctionsReportDSL.CommentConnector
	/// </summary>
	[DslDesign::DisplayNameResource("SchneiderElectricDMS.PowerFunctionsReportDSL.CommentConnector.DisplayName", typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSLDomainModel), "SchneiderElectricDMS.PowerFunctionsReportDSL.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("SchneiderElectricDMS.PowerFunctionsReportDSL.CommentConnector.Description", typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSLDomainModel), "SchneiderElectricDMS.PowerFunctionsReportDSL.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSLDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("1b439915-326b-456f-908a-103256c71915")]
	public partial class CommentConnector : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with CommentConnector.
		/// </summary>
		public static DslDiagrams::Decorator FindCommentConnectorDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// CommentConnector domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x1b439915, 0x326b, 0x456f, 0x90, 0x8a, 0x10, 0x32, 0x56, 0xc7, 0x19, 0x15);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public CommentConnector(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public CommentConnector(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
