<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="6a145a5d-3ec1-4a73-ae06-63c45873e65a" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSL" Name="PowerFunctionsReportDSL" DisplayName="PowerFunctionsReportDSL" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" ProductName="PowerFunctionsReportDSL" CompanyName="SchneiderElectricDMS" PackageGuid="36189604-6446-4d2c-be43-fbb6d87ba77e" PackageNamespace="SchneiderElectricDMS.PowerFunctionsReportDSL" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="aef2a647-767e-4030-baca-5460a0917757" Description="The root in which all other elements are embedded. Appears as a diagram." Name="ModelRoot" DisplayName="Model Root" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="NamedElement" />
      </BaseClass>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Comment" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>ModelRootHasComments.Comments</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="ModelType" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>ModelRootHasTypes.Types</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="a520ec55-a120-424f-a01d-898b3ec8ca2b" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Comment" Name="Comment" DisplayName="Comment" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" />
    <DomainClass Id="421dbe66-9213-4276-bd83-ef0213135ba7" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelType" Name="ModelType" DisplayName="Model Type" InheritanceModifier="Abstract" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="NamedElement" />
      </BaseClass>
    </DomainClass>
    <DomainClass Id="a212836d-9f43-4e78-8f88-00c2746927e5" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.NamedElement" Name="NamedElement" DisplayName="Named Element" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <Properties>
        <DomainProperty Id="d3fa6324-eda0-4d53-a9d4-24bcdc1cbcb6" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.NamedElement.Name" Name="Name" DisplayName="Name" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="3e7c72c4-2cc7-44ee-a947-e5f0baa15efe" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModel" Name="JMSModel" DisplayName="JMSModel" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="ModelType" />
      </BaseClass>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="ClassAttribute" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>JMSModelHasAttributes.Attributes</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="bf1070c6-59b9-4636-a65d-0ef5aa8713c4" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ClassModelElement" Name="ClassModelElement" DisplayName="Class Model Element" InheritanceModifier="Abstract" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="NamedElement" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="da967192-ef02-44c8-8c96-7e38fd4a43aa" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ClassModelElement.Description" Name="Description" DisplayName="Description">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="829a8092-5e51-41f1-bff5-977ee88c66a4" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ClassAttribute" Name="ClassAttribute" DisplayName="Class Attribute" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="ClassModelElement" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="d7772659-b67b-46e6-8e26-dcf405450964" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ClassAttribute.Initial Value" Name="InitialValue" DisplayName="Initial Value">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="d344130c-66a6-4642-ba30-96b8348db390" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelRootHasComments" Name="ModelRootHasComments" DisplayName="Model Root Has Comments" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" IsEmbedding="true">
      <Source>
        <DomainRole Id="c1882f48-e9ee-4820-a457-c4c142107f70" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelRootHasComments.ModelRoot" Name="ModelRoot" DisplayName="Model Root" PropertyName="Comments" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Comments">
          <RolePlayer>
            <DomainClassMoniker Name="ModelRoot" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="e6a974d3-0a35-44ca-9270-1199bcbbfa8a" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelRootHasComments.Comment" Name="Comment" DisplayName="Comment" PropertyName="ModelRoot" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Model Root">
          <RolePlayer>
            <DomainClassMoniker Name="Comment" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="607570c8-e442-4b21-9fb5-50ec13982fc7" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.CommentReferencesModelTyped" Name="CommentReferencesModelTyped" DisplayName="Comment References Model Typed" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <Source>
        <DomainRole Id="0b7bcd31-09d8-41ae-a7a9-e8ca36be12f6" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.CommentReferencesModelTyped.Comment" Name="Comment" DisplayName="Comment" PropertyName="ModelTyped" PropertyDisplayName="Model Typed">
          <RolePlayer>
            <DomainClassMoniker Name="Comment" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="8e02e08e-8dd4-4be4-a636-d41c916631fa" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.CommentReferencesModelTyped.ModelType" Name="ModelType" DisplayName="Model Type" PropertyName="Commented" PropertyDisplayName="Commented">
          <RolePlayer>
            <DomainClassMoniker Name="ModelType" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="4e4b5839-ccc1-4397-b205-323b48d8fb10" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelRootHasTypes" Name="ModelRootHasTypes" DisplayName="Model Root Has Types" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" IsEmbedding="true">
      <Source>
        <DomainRole Id="0ae701ba-c94b-43d1-be4f-07b3a5ec7c20" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelRootHasTypes.ModelRoot" Name="ModelRoot" DisplayName="Model Root" PropertyName="Types" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Types">
          <RolePlayer>
            <DomainClassMoniker Name="ModelRoot" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="7c256cee-4104-4ef5-93bf-db2c35e0a465" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelRootHasTypes.ModelType" Name="ModelType" DisplayName="Model Type" PropertyName="ModelRoot" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Model Root">
          <RolePlayer>
            <DomainClassMoniker Name="ModelType" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="66860efb-33a0-47f2-b3e4-db5037eb307e" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModelHasAttributes" Name="JMSModelHasAttributes" DisplayName="JMSModel Has Attributes" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" IsEmbedding="true">
      <Source>
        <DomainRole Id="94717ec5-b798-4924-9606-acd1c3777baa" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModelHasAttributes.JMSModel" Name="JMSModel" DisplayName="JMSModel" PropertyName="Attributes" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Attributes">
          <RolePlayer>
            <DomainClassMoniker Name="JMSModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="ba6dca6a-b9a3-4498-a624-5ef2c7239c55" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModelHasAttributes.ClassAttribute" Name="ClassAttribute" DisplayName="Class Attribute" PropertyName="JMSModel" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="JMSModel">
          <RolePlayer>
            <DomainClassMoniker Name="ClassAttribute" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
  </Types>
  <Shapes>
    <GeometryShape Id="feedcd67-3fec-445b-9525-554debbd5c43" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.CommentShape" Name="CommentShape" DisplayName="Comment Shape" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Comment Shape" InitialHeight="1" Geometry="Rectangle" />
    <CompartmentShape Id="280acf15-f2f1-4974-b446-8cb3f9f1da37" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModelShape" Name="JMSModelShape" DisplayName="JMSModel Shape" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="JMSModel Shape" FillColor="192, 255, 255" InitialHeight="1" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopRight" HorizontalOffset="0" VerticalOffset="0">
        <ExpandCollapseDecorator Name="ExpandCollapseDecorator" DisplayName="Expand Collapse Decorator" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
      <Compartment Name="AttributesCompartment" Title="Attributes" />
    </CompartmentShape>
  </Shapes>
  <Connectors>
    <Connector Id="1b439915-326b-456f-908a-103256c71915" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.CommentConnector" Name="CommentConnector" DisplayName="Comment Connector" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Comment Connector" />
  </Connectors>
  <XmlSerializationBehavior Name="PowerFunctionsReportDSLSerializationBehavior" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
    <ClassData>
      <XmlClassData TypeName="ModelRoot" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelRootMoniker" ElementName="modelRoot" MonikerTypeName="ModelRootMoniker">
        <DomainClassMoniker Name="ModelRoot" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="comments">
            <DomainRelationshipMoniker Name="ModelRootHasComments" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="types">
            <DomainRelationshipMoniker Name="ModelRootHasTypes" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="PowerFunctionsReportDSLDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="powerFunctionsReportDSLDiagramMoniker" ElementName="powerFunctionsReportDSLDiagram" MonikerTypeName="PowerFunctionsReportDSLDiagramMoniker">
        <DiagramMoniker Name="PowerFunctionsReportDSLDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="Comment" MonikerAttributeName="" SerializeId="true" MonikerElementName="commentMoniker" ElementName="comment" MonikerTypeName="CommentMoniker">
        <DomainClassMoniker Name="Comment" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="modelTyped">
            <DomainRelationshipMoniker Name="CommentReferencesModelTyped" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ModelRootHasComments" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelRootHasCommentsMoniker" ElementName="modelRootHasComments" MonikerTypeName="ModelRootHasCommentsMoniker">
        <DomainRelationshipMoniker Name="ModelRootHasComments" />
      </XmlClassData>
      <XmlClassData TypeName="ModelType" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelTypeMoniker" ElementName="modelType" MonikerTypeName="ModelTypeMoniker">
        <DomainClassMoniker Name="ModelType" />
      </XmlClassData>
      <XmlClassData TypeName="NamedElement" MonikerAttributeName="" SerializeId="true" MonikerElementName="namedElementMoniker" ElementName="namedElement" MonikerTypeName="NamedElementMoniker">
        <DomainClassMoniker Name="NamedElement" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="NamedElement/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="CommentReferencesModelTyped" MonikerAttributeName="" SerializeId="true" MonikerElementName="commentReferencesModelTypedMoniker" ElementName="commentReferencesModelTyped" MonikerTypeName="CommentReferencesModelTypedMoniker">
        <DomainRelationshipMoniker Name="CommentReferencesModelTyped" />
      </XmlClassData>
      <XmlClassData TypeName="ModelRootHasTypes" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelRootHasTypesMoniker" ElementName="modelRootHasTypes" MonikerTypeName="ModelRootHasTypesMoniker">
        <DomainRelationshipMoniker Name="ModelRootHasTypes" />
      </XmlClassData>
      <XmlClassData TypeName="CommentShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="commentShapeMoniker" ElementName="commentShape" MonikerTypeName="CommentShapeMoniker">
        <GeometryShapeMoniker Name="CommentShape" />
      </XmlClassData>
      <XmlClassData TypeName="CommentConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="commentConnectorMoniker" ElementName="commentConnector" MonikerTypeName="CommentConnectorMoniker">
        <ConnectorMoniker Name="CommentConnector" />
      </XmlClassData>
      <XmlClassData TypeName="JMSModel" MonikerAttributeName="" SerializeId="true" MonikerElementName="jMSModelMoniker" ElementName="jMSModel" MonikerTypeName="JMSModelMoniker">
        <DomainClassMoniker Name="JMSModel" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="attributes">
            <DomainRelationshipMoniker Name="JMSModelHasAttributes" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="JMSModelShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="jMSModelShapeMoniker" ElementName="jMSModelShape" MonikerTypeName="JMSModelShapeMoniker">
        <CompartmentShapeMoniker Name="JMSModelShape" />
      </XmlClassData>
      <XmlClassData TypeName="ClassModelElement" MonikerAttributeName="" SerializeId="true" MonikerElementName="classModelElementMoniker" ElementName="classModelElement" MonikerTypeName="ClassModelElementMoniker">
        <DomainClassMoniker Name="ClassModelElement" />
        <ElementData>
          <XmlPropertyData XmlName="description">
            <DomainPropertyMoniker Name="ClassModelElement/Description" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ClassAttribute" MonikerAttributeName="" SerializeId="true" MonikerElementName="classAttributeMoniker" ElementName="classAttribute" MonikerTypeName="ClassAttributeMoniker">
        <DomainClassMoniker Name="ClassAttribute" />
        <ElementData>
          <XmlPropertyData XmlName="initialValue">
            <DomainPropertyMoniker Name="ClassAttribute/InitialValue" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="JMSModelHasAttributes" MonikerAttributeName="" SerializeId="true" MonikerElementName="jMSModelHasAttributesMoniker" ElementName="jMSModelHasAttributes" MonikerTypeName="JMSModelHasAttributesMoniker">
        <DomainRelationshipMoniker Name="JMSModelHasAttributes" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="PowerFunctionsReportDSLExplorer" />
  <ConnectionBuilders>
    <ConnectionBuilder Name="CommentReferencesModelTypedBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="CommentReferencesModelTyped" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Comment" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="ModelType" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
  </ConnectionBuilders>
  <Diagram Id="9225a9df-bf9c-406d-a0e6-9bdd6dfde487" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSLDiagram" Name="PowerFunctionsReportDSLDiagram" DisplayName="Minimal Language Diagram" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
    <Class>
      <DomainClassMoniker Name="ModelRoot" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="Comment" />
        <ParentElementPath>
          <DomainPath>ModelRootHasComments.ModelRoot/!ModelRoot</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="CommentShape" />
      </ShapeMap>
      <CompartmentShapeMap>
        <DomainClassMoniker Name="JMSModel" />
        <ParentElementPath>
          <DomainPath>ModelRootHasTypes.ModelRoot/!ModelRoot</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="JMSModelShape/Name" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="NamedElement/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <CompartmentShapeMoniker Name="JMSModelShape" />
        <CompartmentMap>
          <CompartmentMoniker Name="JMSModelShape/AttributesCompartment" />
          <ElementsDisplayed>
            <DomainPath>JMSModelHasAttributes.Attributes/!ClassAttribute</DomainPath>
          </ElementsDisplayed>
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="NamedElement/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </CompartmentMap>
      </CompartmentShapeMap>
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="CommentConnector" />
        <DomainRelationshipMoniker Name="CommentReferencesModelTyped" />
      </ConnectorMap>
    </ConnectorMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="ui" EditorGuid="0f86ccf2-8107-445a-97dc-c2958521b825">
    <RootClass>
      <DomainClassMoniker Name="ModelRoot" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="PowerFunctionsReportDSLSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="PowerFunctionsReportDSL">
      <ElementTool Name="Comment" ToolboxIcon="resources\exampleshapetoolbitmap.bmp" Caption="Comment" Tooltip="Comment" HelpKeyword="Comment">
        <DomainClassMoniker Name="Comment" />
      </ElementTool>
      <ConnectionTool Name="CommentRelationship" ToolboxIcon="resources\exampleconnectortoolbitmap.bmp" Caption="CommentRelationship" Tooltip="Comment Relationship" HelpKeyword="CommentRelationship">
        <ConnectionBuilderMoniker Name="PowerFunctionsReportDSL/CommentReferencesModelTypedBuilder" />
      </ConnectionTool>
      <ElementTool Name="JMSModel" ToolboxIcon="Resources\ClassTool.bmp" Caption="JMS Model" Tooltip="JMSModel" HelpKeyword="JMSModel">
        <DomainClassMoniker Name="JMSModel" />
      </ElementTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="PowerFunctionsReportDSLDiagram" />
  </Designer>
  <Explorer ExplorerGuid="5c7fe4a1-755c-40cd-8227-ff738d5914d6" Title="PowerFunctionsReportDSL Explorer">
    <ExplorerBehaviorMoniker Name="PowerFunctionsReportDSL/PowerFunctionsReportDSLExplorer" />
  </Explorer>
</Dsl>