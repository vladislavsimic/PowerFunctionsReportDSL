<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="70fa60d4-ac1d-4b71-a9a7-fa3687e76a5c" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSL" Name="PowerFunctionsReportDSL" DisplayName="PowerFunctionsReportDSL" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" ProductName="PowerFunctionsReportDSL" CompanyName="SchneiderElectricDMS" PackageGuid="70351ecb-93e9-4b2a-b34c-8f45a72a8e37" PackageNamespace="SchneiderElectricDMS.PowerFunctionsReportDSL" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="a0ca513b-3c35-4cad-be79-7c31553c2c4e" Description="The root in which all other elements are embedded. Appears as a diagram." Name="ModelRoot" DisplayName="Model Root" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Notes>Creates an embedding link when an element is dropped onto a model. </Notes>
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
    <DomainClass Id="43bdfdff-371a-424d-ac0c-9959740460fe" Description="Elements embedded in the model. Appear as boxes on the diagram." Name="Comment" DisplayName="Comment" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <Properties>
        <DomainProperty Id="01f2fc47-3395-4157-8047-d2a90728f6de" Description="" Name="Text" DisplayName="Text" DefaultValue="" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="3b35dfe1-46ef-4bd7-8e10-e78324d59949" Description="" Name="ModelType" DisplayName="Model Type" InheritanceModifier="Abstract" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="/Microsoft.VisualStudio.Modeling/ModelElement" />
      </BaseClass>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="200b88e4-1d0e-4f28-ae56-281001f3873e" Description="Embedding relationship between the Model and Elements" Name="ModelRootHasComments" DisplayName="Model Root Has Comments" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" IsEmbedding="true">
      <Source>
        <DomainRole Id="9dcf299a-fcf0-48a2-8309-ef0e5e8d33bf" Description="" Name="ModelRoot" DisplayName="Model Root" PropertyName="Comments" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Comments">
          <RolePlayer>
            <DomainClassMoniker Name="ModelRoot" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="de674ce7-eb3d-4b16-adae-c7098e629e92" Description="" Name="Element" DisplayName="Element" PropertyName="ModelRoot" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Model Root">
          <RolePlayer>
            <DomainClassMoniker Name="Comment" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="7eb5eb7d-c9e6-45fc-a949-bb4adddd93a5" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.CommentReferencesSubjects" Name="CommentReferencesSubjects" DisplayName="Comment References Subjects" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <Source>
        <DomainRole Id="f9471e5c-0aef-4a2e-8821-9e03ba24a1d7" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.CommentReferencesSubjects.Comment" Name="Comment" DisplayName="Comment" PropertyName="Subjects" PropertyDisplayName="Subjects">
          <RolePlayer>
            <DomainClassMoniker Name="Comment" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="03901ccb-9eae-4970-9994-496f25d76969" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.CommentReferencesSubjects.Subject" Name="Subject" DisplayName="Subject" PropertyName="Comments" PropertyDisplayName="Comments">
          <RolePlayer>
            <DomainClassMoniker Name="ModelType" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="5903c980-bde9-4ced-be18-2dbffbae0cb1" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelRootHasTypes" Name="ModelRootHasTypes" DisplayName="Model Root Has Types" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" IsEmbedding="true">
      <Source>
        <DomainRole Id="4835a2de-b894-453c-a988-4dbd3be8c2a0" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelRootHasTypes.ModelRoot" Name="ModelRoot" DisplayName="Model Root" PropertyName="Types" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Types">
          <RolePlayer>
            <DomainClassMoniker Name="ModelRoot" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="e30f8ade-d624-42f8-a971-c2883ae423b6" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelRootHasTypes.ModelType" Name="ModelType" DisplayName="Model Type" PropertyName="ModelRoot" Multiplicity="ZeroOne" PropagatesDelete="true" PropertyDisplayName="Model Root">
          <RolePlayer>
            <DomainClassMoniker Name="ModelType" />
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
    <GeometryShape Id="60721541-4918-4400-89bc-9ab10a51117a" Description="Shape used to represent ExampleElements on a Diagram." Name="CommentBoxShape" DisplayName="Comment Box Shape" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Comment Box Shape" FillColor="PaleGoldenrod" OutlineColor="192, 192, 0" InitialWidth="2" InitialHeight="0.75" OutlineThickness="0.01" FillGradientMode="None" Geometry="Rectangle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Comment" DisplayName="Comment" DefaultText="Comment" />
      </ShapeHasDecorators>
    </GeometryShape>
  </Shapes>
  <Connectors>
    <Connector Id="e57364a1-b502-49b2-aae0-8791da4397ca" Description="Connector between the ExampleShapes. Represents ExampleRelationships on the Diagram." Name="CommentConnector" DisplayName="Comment Connector" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Comment Connector" Color="113, 111, 110" Thickness="0.01" RoutingStyle="Straight" />
  </Connectors>
  <XmlSerializationBehavior Name="PowerFunctionsReportDSLSerializationBehavior" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
    <ClassData>
      <XmlClassData TypeName="ModelRoot" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelRootMoniker" ElementName="modelRoot" MonikerTypeName="ModelRootMoniker">
        <DomainClassMoniker Name="ModelRoot" />
        <ElementData>
          <XmlRelationshipData RoleElementName="comments">
            <DomainRelationshipMoniker Name="ModelRootHasComments" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="types">
            <DomainRelationshipMoniker Name="ModelRootHasTypes" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Comment" MonikerAttributeName="text" SerializeId="true" MonikerElementName="commentMoniker" ElementName="comment" MonikerTypeName="CommentMoniker">
        <DomainClassMoniker Name="Comment" />
        <ElementData>
          <XmlPropertyData XmlName="text" IsMonikerKey="true">
            <DomainPropertyMoniker Name="Comment/Text" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="subjects">
            <DomainRelationshipMoniker Name="CommentReferencesSubjects" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ModelRootHasComments" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelRootHasCommentsMoniker" ElementName="modelRootHasComments" MonikerTypeName="ModelRootHasCommentsMoniker">
        <DomainRelationshipMoniker Name="ModelRootHasComments" />
      </XmlClassData>
      <XmlClassData TypeName="CommentBoxShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="commentBoxShapeMoniker" ElementName="commentBoxShape" MonikerTypeName="CommentBoxShapeMoniker">
        <GeometryShapeMoniker Name="CommentBoxShape" />
      </XmlClassData>
      <XmlClassData TypeName="CommentConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="commentConnectorMoniker" ElementName="commentConnector" MonikerTypeName="CommentConnectorMoniker">
        <ConnectorMoniker Name="CommentConnector" />
      </XmlClassData>
      <XmlClassData TypeName="PowerFunctionsReportDSLDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="powerFunctionsReportDSLDiagramMoniker" ElementName="powerFunctionsReportDSLDiagram" MonikerTypeName="PowerFunctionsReportDSLDiagramMoniker">
        <DiagramMoniker Name="PowerFunctionsReportDSLDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="ModelType" MonikerAttributeName="" MonikerElementName="modelTypeMoniker" ElementName="modelType" MonikerTypeName="ModelTypeMoniker">
        <DomainClassMoniker Name="ModelType" />
      </XmlClassData>
      <XmlClassData TypeName="CommentReferencesSubjects" MonikerAttributeName="" SerializeId="true" MonikerElementName="commentReferencesSubjectsMoniker" ElementName="commentReferencesSubjects" MonikerTypeName="CommentReferencesSubjectsMoniker">
        <DomainRelationshipMoniker Name="CommentReferencesSubjects" />
      </XmlClassData>
      <XmlClassData TypeName="ModelRootHasTypes" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelRootHasTypesMoniker" ElementName="modelRootHasTypes" MonikerTypeName="ModelRootHasTypesMoniker">
        <DomainRelationshipMoniker Name="ModelRootHasTypes" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="PowerFunctionsReportDSLExplorer" />
  <ConnectionBuilders>
    <ConnectionBuilder Name="CommentReferencesSubjectsBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="CommentReferencesSubjects" />
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
  <Diagram Id="ec384617-dd3c-4ff2-9055-d8ba3510c79f" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.PowerFunctionsReportDSLDiagram" Name="PowerFunctionsReportDSLDiagram" DisplayName="Minimal Language Diagram" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
    <Class>
      <DomainClassMoniker Name="ModelRoot" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="Comment" />
        <ParentElementPath>
          <DomainPath>ModelRootHasComments.ModelRoot/!ModelRoot</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="CommentBoxShape/Comment" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Comment/Text" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="CommentBoxShape" />
      </ShapeMap>
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="CommentConnector" />
        <DomainRelationshipMoniker Name="CommentReferencesSubjects" />
      </ConnectorMap>
    </ConnectorMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="ui" Icon="Resources\File.ico" EditorGuid="7d7406f9-ee01-4a77-804a-bf591476ce84">
    <RootClass>
      <DomainClassMoniker Name="ModelRoot" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="PowerFunctionsReportDSLSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="Class Elements">
      <ElementTool Name="Comment" ToolboxIcon="resources\exampleshapetoolbitmap.bmp" Caption="Comment" Tooltip="Create a Comment" HelpKeyword="CreateCommentF1Keyword">
        <DomainClassMoniker Name="Comment" />
      </ElementTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="PowerFunctionsReportDSLDiagram" />
  </Designer>
  <Explorer ExplorerGuid="18de1779-9172-4a19-b541-326f320c5a4f" Title="PowerFunctionsReportDSL Explorer">
    <ExplorerBehaviorMoniker Name="PowerFunctionsReportDSL/PowerFunctionsReportDSLExplorer" />
  </Explorer>
</Dsl>