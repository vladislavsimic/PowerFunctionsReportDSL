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
        <DomainProperty Id="ad15ec76-7156-4597-b0b2-85c3ad76bb53" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.NamedElement.Alias" Name="Alias" DisplayName="Alias">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="3e7c72c4-2cc7-44ee-a947-e5f0baa15efe" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModel" Name="JMSModel" DisplayName="JMSModel" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="ModelClass" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="0548378e-ee6e-4b3a-98a4-2044dc1ee840" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModel.Is Data Contract" Name="IsDataContract" DisplayName="Is Data Contract" DefaultValue="true">
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="c8bce15c-99a2-4a4f-bab2-5b43c12f804a" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModel.Type" Name="Type" DisplayName="Type" DefaultValue="Record">
          <Type>
            <DomainEnumerationMoniker Name="JMSResultType" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="74902c3f-b848-4b69-868b-bff3729b552d" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModel.Has Default Constructor" Name="HasDefaultConstructor" DisplayName="Has Default Constructor" DefaultValue="true">
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="989a9706-3b2d-4409-bff0-87bfcd2d9d35" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModel.Main Report Class" Name="MainReportClass" DisplayName="Main Report Class" DefaultValue="false">
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
      </Properties>
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
        <DomainProperty Id="2d411332-72ca-497e-9b2e-93bba3032d06" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ClassAttribute.Type" Name="Type" DisplayName="Type" DefaultValue="Int">
          <Type>
            <DomainEnumerationMoniker Name="Types" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="19612026-e782-4521-8341-654acd1d33ff" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ClassAttribute.Access Modifier" Name="AccessModifier" DisplayName="Access Modifier" DefaultValue="Public">
          <Type>
            <DomainEnumerationMoniker Name="TypeAccessModifier" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="9a5402cf-296d-429d-b28b-d95981fc0472" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ClassAttribute.Is Data Member" Name="IsDataMember" DisplayName="Is Data Member" DefaultValue="true">
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="8ddb44cf-3b06-4b91-b747-b1eec2bc30b4" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelClass" Name="ModelClass" DisplayName="Model Class" InheritanceModifier="Abstract" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="ModelType" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="49e6db7c-b6b1-4cda-8d31-c5bad8b5a7c2" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelClass.Should Generate" Name="ShouldGenerate" DisplayName="Should Generate" DefaultValue="true">
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="cccc1a1d-067f-4adb-a360-85a9fb4f5b2b" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Enum" Name="Enum" DisplayName="Enum" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="ModelClass" />
      </BaseClass>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="EnumAttribute" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>EnumHasValues.Values</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="2cbf3442-ee61-4c37-b0c7-44b126765931" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.EnumAttribute" Name="EnumAttribute" DisplayName="Enum Attribute" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="ClassModelElement" />
      </BaseClass>
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
    <DomainRelationship Id="c5c2de26-3dfe-4142-a437-ac3d7b943cc9" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Generalization" Name="Generalization" DisplayName="Generalization" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <Source>
        <DomainRole Id="45d4cb8d-17c7-4e87-be5e-109d52bcc144" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Generalization.Superclass" Name="Superclass" DisplayName="Superclass" PropertyName="Subclasses" PropertyDisplayName="Subclasses">
          <RolePlayer>
            <DomainClassMoniker Name="JMSModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="6c56ddcf-4479-4a69-bfdf-96a1899fff66" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Generalization.Subclasses" Name="Subclasses" DisplayName="Subclasses" PropertyName="Superclass" Multiplicity="ZeroOne" PropertyDisplayName="Superclass">
          <RolePlayer>
            <DomainClassMoniker Name="JMSModel" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="57c335cd-3f14-4ef0-ae24-fbe7d2e033d5" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Association" Name="Association" DisplayName="Association" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" AllowsDuplicates="true">
      <Properties>
        <DomainProperty Id="54f889b9-9aa0-4e16-9924-897cc3436e4f" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Association.Source Multiplicity" Name="SourceMultiplicity" DisplayName="Source Multiplicity" DefaultValue="One">
          <Type>
            <DomainEnumerationMoniker Name="Multiplicity" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="14e315b7-eb1b-4ac0-bd7d-224e032508f9" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Association.Source Role Name" Name="SourceRoleName" DisplayName="Source Role Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="626e99f1-35e9-4685-8486-1a1499962aca" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Association.Target Multiplicity" Name="TargetMultiplicity" DisplayName="Target Multiplicity" DefaultValue="One">
          <Type>
            <DomainEnumerationMoniker Name="Multiplicity" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="e6a22dce-47d9-45ac-802d-12221dd88876" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Association.Target Role Name" Name="TargetRoleName" DisplayName="Target Role Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="c8658a42-92e8-4b75-941e-6bc9b10bdd7d" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Association.Access Modifier" Name="AccessModifier" DisplayName="Access Modifier" DefaultValue="Public">
          <Type>
            <DomainEnumerationMoniker Name="TypeAccessModifier" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="2f64272b-8bb2-4372-92b4-03eeeab8f29a" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Association.Is Data Member" Name="IsDataMember" DisplayName="Is Data Member" DefaultValue="true">
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="a6cbfb75-9b32-4369-913b-d0375219a757" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Association.Description" Name="Description" DisplayName="Description">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <Source>
        <DomainRole Id="fed48ede-60f8-4569-94f2-11252da1c3d4" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Association.Source" Name="Source" DisplayName="Source" PropertyName="Targets" PropertyDisplayName="Targets">
          <RolePlayer>
            <DomainClassMoniker Name="JMSModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="b93aeaa7-9048-4e6d-8e36-740254a11e67" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Association.Target" Name="Target" DisplayName="Target" PropertyName="Sources" PropertyDisplayName="Sources">
          <RolePlayer>
            <DomainClassMoniker Name="ModelClass" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="959ee0a7-917f-4557-9086-fdc3709798e1" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.UndirectionalAssociation" Name="UndirectionalAssociation" DisplayName="Undirectional Association" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseRelationship>
        <DomainRelationshipMoniker Name="Association" />
      </BaseRelationship>
      <Source>
        <DomainRole Id="38be2565-7015-4c78-ad01-b3cb9e404102" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.UndirectionalAssociation.JMSModel" Name="JMSModel" DisplayName="JMSModel" PropertyName="UndirectionalAssociationTargets" PropertyDisplayName="Undirectional Association Targets">
          <RolePlayer>
            <DomainClassMoniker Name="JMSModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="4a85f170-6e8e-412a-bb96-b8b2b5899ac2" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.UndirectionalAssociation.ModelClass" Name="ModelClass" DisplayName="Model Class" PropertyName="UndirectionalAssociationSources" PropertyDisplayName="Undirectional Association Sources">
          <RolePlayer>
            <DomainClassMoniker Name="ModelClass" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="79613aa9-9394-44e8-bed4-a86f5cf31be9" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.EnumHasValues" Name="EnumHasValues" DisplayName="Enum Has Values" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" IsEmbedding="true">
      <Source>
        <DomainRole Id="8e8acfb2-6417-4e13-8b91-613ef13455f7" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.EnumHasValues.Enum" Name="Enum" DisplayName="Enum" PropertyName="Values" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Values">
          <RolePlayer>
            <DomainClassMoniker Name="Enum" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="1af0f984-b645-47fd-b193-d86a85fb5c22" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.EnumHasValues.EnumAttribute" Name="EnumAttribute" DisplayName="Enum Attribute" PropertyName="Enum" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Enum">
          <RolePlayer>
            <DomainClassMoniker Name="EnumAttribute" />
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
    <DomainEnumeration Name="Types" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types">
      <Literals>
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.Bool" Name="Bool" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.Float" Name="Float" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.GID" Name="GID" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.Int" Name="Int" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.LID" Name="LID" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.Long" Name="Long" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.Short" Name="Short" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.String" Name="String" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.UInt" Name="UInt" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.Byte" Name="Byte" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.Char" Name="Char" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.DateTime" Name="DateTime" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.Double" Name="Double" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.UShort" Name="UShort" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.ULong" Name="ULong" Value="" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Types.ELimitViolation" Name="ELimitViolation" Value="" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="TypeAccessModifier" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TypeAccessModifier">
      <Literals>
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TypeAccessModifier.Private" Name="Private" Value="1" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TypeAccessModifier.Public" Name="Public" Value="0" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TypeAccessModifier.Protected" Name="Protected" Value="2" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="Multiplicity" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Multiplicity">
      <Literals>
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Multiplicity.One" Name="One" Value="1" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Multiplicity.ZeroMany" Name="ZeroMany" Value="0" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Multiplicity.ZeroOne" Name="ZeroOne" Value="2" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Multiplicity.OneMany" Name="OneMany" Value="3" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="JMSResultType" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSResultType">
      <Literals>
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSResultType.Record" Name="Record" Value="0" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSResultType.Job" Name="Job" Value="2" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSResultType.Results" Name="Results" Value="1" />
      </Literals>
    </DomainEnumeration>
  </Types>
  <Shapes>
    <GeometryShape Id="feedcd67-3fec-445b-9525-554debbd5c43" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.CommentShape" Name="CommentShape" DisplayName="Comment Shape" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Comment Shape" InitialHeight="1" Geometry="Rectangle" />
    <CompartmentShape Id="280acf15-f2f1-4974-b446-8cb3f9f1da37" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModelShape" Name="JMSModelShape" DisplayName="JMSModel Shape" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="JMSModel Shape" FillColor="192, 255, 255" InitialHeight="1" OutlineThickness="0.01" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopRight" HorizontalOffset="0" VerticalOffset="0">
        <ExpandCollapseDecorator Name="ExpandCollapseDecorator" DisplayName="Expand Collapse Decorator" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
      <Compartment Name="AttributesCompartment" Title="Attributes" />
    </CompartmentShape>
    <CompartmentShape Id="66b09fe4-0a78-43b4-9f09-385e4e2dfb29" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.EnumShape" Name="EnumShape" DisplayName="Enum Shape" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Enum Shape" FillColor="LemonChiffon" InitialWidth="2" InitialHeight="0.5" OutlineThickness="0.01" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopRight" HorizontalOffset="0" VerticalOffset="0">
        <ExpandCollapseDecorator Name="ExpandCollapseDecorator" DisplayName="Expand Collapse Decorator" />
      </ShapeHasDecorators>
      <Compartment Name="EnumAttributes" Title="Values" />
    </CompartmentShape>
  </Shapes>
  <Connectors>
    <Connector Id="1b439915-326b-456f-908a-103256c71915" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.CommentConnector" Name="CommentConnector" DisplayName="Comment Connector" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Comment Connector" />
    <Connector Id="b91f45a0-d2a1-45d2-b6ef-0a772fec5da0" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.GeneralizationConnector" Name="GeneralizationConnector" DisplayName="Generalization Connector" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Generalization Connector" Color="Gray" SourceEndStyle="HollowArrow" Thickness="0.01" />
    <Connector Id="7b6e4cfe-10af-45f0-a678-c32d07d5df4e" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.AssociationConnector" Name="AssociationConnector" DisplayName="Association Connector" InheritanceModifier="Abstract" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Association Connector" Color="113, 111, 110" Thickness="0.01">
      <ConnectorHasDecorators Position="TargetBottom" OffsetFromShape="0" OffsetFromLine="0">
        <TextDecorator Name="TargetMultiplicity" DisplayName="Target Multiplicity" DefaultText="TargetMultiplicity" />
      </ConnectorHasDecorators>
      <ConnectorHasDecorators Position="SourceBottom" OffsetFromShape="0" OffsetFromLine="0">
        <TextDecorator Name="SourceMultiplicity" DisplayName="Source Multiplicity" DefaultText="SourceMultiplicity" />
      </ConnectorHasDecorators>
      <ConnectorHasDecorators Position="TargetTop" OffsetFromShape="0" OffsetFromLine="0">
        <TextDecorator Name="TargetRoleName" DisplayName="Target Role Name" DefaultText="TargetRoleName" />
      </ConnectorHasDecorators>
      <ConnectorHasDecorators Position="SourceTop" OffsetFromShape="0" OffsetFromLine="0">
        <TextDecorator Name="SourceRoleName" DisplayName="Source Role Name" DefaultText="SourceRoleName" />
      </ConnectorHasDecorators>
    </Connector>
    <Connector Id="df4ce4b9-a7da-41ab-bed9-e546e3de2059" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.UndirectionalConnector" Name="UndirectionalConnector" DisplayName="Undirectional Connector" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Undirectional Connector" TargetEndStyle="EmptyArrow">
      <BaseConnector>
        <ConnectorMoniker Name="AssociationConnector" />
      </BaseConnector>
    </Connector>
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
          <XmlPropertyData XmlName="alias">
            <DomainPropertyMoniker Name="NamedElement/Alias" />
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
          <XmlPropertyData XmlName="isDataContract">
            <DomainPropertyMoniker Name="JMSModel/IsDataContract" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="subclasses">
            <DomainRelationshipMoniker Name="Generalization" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="targets">
            <DomainRelationshipMoniker Name="Association" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="undirectionalAssociationTargets">
            <DomainRelationshipMoniker Name="UndirectionalAssociation" />
          </XmlRelationshipData>
          <XmlPropertyData XmlName="type">
            <DomainPropertyMoniker Name="JMSModel/Type" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="hasDefaultConstructor">
            <DomainPropertyMoniker Name="JMSModel/HasDefaultConstructor" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="mainReportClass">
            <DomainPropertyMoniker Name="JMSModel/MainReportClass" />
          </XmlPropertyData>
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
          <XmlPropertyData XmlName="type">
            <DomainPropertyMoniker Name="ClassAttribute/Type" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="accessModifier">
            <DomainPropertyMoniker Name="ClassAttribute/AccessModifier" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="isDataMember">
            <DomainPropertyMoniker Name="ClassAttribute/IsDataMember" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="JMSModelHasAttributes" MonikerAttributeName="" SerializeId="true" MonikerElementName="jMSModelHasAttributesMoniker" ElementName="jMSModelHasAttributes" MonikerTypeName="JMSModelHasAttributesMoniker">
        <DomainRelationshipMoniker Name="JMSModelHasAttributes" />
      </XmlClassData>
      <XmlClassData TypeName="Generalization" MonikerAttributeName="" SerializeId="true" MonikerElementName="generalizationMoniker" ElementName="generalization" MonikerTypeName="GeneralizationMoniker">
        <DomainRelationshipMoniker Name="Generalization" />
      </XmlClassData>
      <XmlClassData TypeName="GeneralizationConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="generalizationConnectorMoniker" ElementName="generalizationConnector" MonikerTypeName="GeneralizationConnectorMoniker">
        <ConnectorMoniker Name="GeneralizationConnector" />
      </XmlClassData>
      <XmlClassData TypeName="ModelClass" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelClassMoniker" ElementName="modelClass" MonikerTypeName="ModelClassMoniker">
        <DomainClassMoniker Name="ModelClass" />
        <ElementData>
          <XmlPropertyData XmlName="shouldGenerate">
            <DomainPropertyMoniker Name="ModelClass/ShouldGenerate" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Association" MonikerAttributeName="" SerializeId="true" MonikerElementName="associationMoniker" ElementName="association" MonikerTypeName="AssociationMoniker">
        <DomainRelationshipMoniker Name="Association" />
        <ElementData>
          <XmlPropertyData XmlName="sourceMultiplicity">
            <DomainPropertyMoniker Name="Association/SourceMultiplicity" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="sourceRoleName">
            <DomainPropertyMoniker Name="Association/SourceRoleName" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="targetMultiplicity">
            <DomainPropertyMoniker Name="Association/TargetMultiplicity" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="targetRoleName">
            <DomainPropertyMoniker Name="Association/TargetRoleName" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="accessModifier">
            <DomainPropertyMoniker Name="Association/AccessModifier" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="isDataMember">
            <DomainPropertyMoniker Name="Association/IsDataMember" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="description">
            <DomainPropertyMoniker Name="Association/Description" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="AssociationConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="associationConnectorMoniker" ElementName="associationConnector" MonikerTypeName="AssociationConnectorMoniker">
        <ConnectorMoniker Name="AssociationConnector" />
      </XmlClassData>
      <XmlClassData TypeName="UndirectionalConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="undirectionalConnectorMoniker" ElementName="undirectionalConnector" MonikerTypeName="UndirectionalConnectorMoniker">
        <ConnectorMoniker Name="UndirectionalConnector" />
      </XmlClassData>
      <XmlClassData TypeName="UndirectionalAssociation" MonikerAttributeName="" SerializeId="true" MonikerElementName="undirectionalAssociationMoniker" ElementName="undirectionalAssociation" MonikerTypeName="UndirectionalAssociationMoniker">
        <DomainRelationshipMoniker Name="UndirectionalAssociation" />
      </XmlClassData>
      <XmlClassData TypeName="Enum" MonikerAttributeName="" SerializeId="true" MonikerElementName="enumMoniker" ElementName="enum" MonikerTypeName="EnumMoniker">
        <DomainClassMoniker Name="Enum" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="values">
            <DomainRelationshipMoniker Name="EnumHasValues" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="EnumAttribute" MonikerAttributeName="" SerializeId="true" MonikerElementName="enumAttributeMoniker" ElementName="enumAttribute" MonikerTypeName="EnumAttributeMoniker">
        <DomainClassMoniker Name="EnumAttribute" />
      </XmlClassData>
      <XmlClassData TypeName="EnumHasValues" MonikerAttributeName="" SerializeId="true" MonikerElementName="enumHasValuesMoniker" ElementName="enumHasValues" MonikerTypeName="EnumHasValuesMoniker">
        <DomainRelationshipMoniker Name="EnumHasValues" />
      </XmlClassData>
      <XmlClassData TypeName="EnumShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="enumShapeMoniker" ElementName="enumShape" MonikerTypeName="EnumShapeMoniker">
        <CompartmentShapeMoniker Name="EnumShape" />
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
    <ConnectionBuilder Name="GeneralizationBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="Generalization" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="JMSModel" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="JMSModel" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
    <ConnectionBuilder Name="AssociationBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="Association" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="JMSModel" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="ModelClass" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
    <ConnectionBuilder Name="UndirectionalAssociationBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="UndirectionalAssociation" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="JMSModel" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="ModelClass" />
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
      <CompartmentShapeMap>
        <DomainClassMoniker Name="Enum" />
        <ParentElementPath>
          <DomainPath>ModelRootHasTypes.ModelRoot/!ModelRoot</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="EnumShape/Name" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="NamedElement/Name" />
              <DomainPath />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <CompartmentShapeMoniker Name="EnumShape" />
        <CompartmentMap>
          <CompartmentMoniker Name="EnumShape/EnumAttributes" />
          <ElementsDisplayed>
            <DomainPath>EnumHasValues.Values/!EnumAttribute</DomainPath>
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
      <ConnectorMap>
        <ConnectorMoniker Name="GeneralizationConnector" />
        <DomainRelationshipMoniker Name="Generalization" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="UndirectionalConnector" />
        <DomainRelationshipMoniker Name="UndirectionalAssociation" />
        <DecoratorMap>
          <TextDecoratorMoniker Name="AssociationConnector/SourceMultiplicity" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Association/SourceMultiplicity" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="AssociationConnector/SourceRoleName" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Association/SourceRoleName" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="AssociationConnector/TargetMultiplicity" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Association/TargetMultiplicity" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="AssociationConnector/TargetRoleName" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Association/TargetRoleName" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
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
      <ElementTool Name="Enum" ToolboxIcon="Resources\ClassTool.bmp" Caption="Enum" Tooltip="Enum" HelpKeyword="Enum">
        <DomainClassMoniker Name="Enum" />
      </ElementTool>
      <ElementTool Name="JMSModel" ToolboxIcon="Resources\ClassTool.bmp" Caption="JMS Model" Tooltip="JMSModel" HelpKeyword="JMSModel">
        <DomainClassMoniker Name="JMSModel" />
      </ElementTool>
      <ConnectionTool Name="Generalization" ToolboxIcon="Resources\GeneralizationTool.bmp" Caption="Inheritance" Tooltip="Generalization" HelpKeyword="Generalization" ReversesDirection="true">
        <ConnectionBuilderMoniker Name="PowerFunctionsReportDSL/GeneralizationBuilder" />
      </ConnectionTool>
      <ConnectionTool Name="UndirectionalAssociation" ToolboxIcon="Resources\UnidirectionTool.bmp" Caption="Undirectional Association" Tooltip="Undirectional Association" HelpKeyword="UndirectionalAssociation">
        <ConnectionBuilderMoniker Name="PowerFunctionsReportDSL/UndirectionalAssociationBuilder" />
      </ConnectionTool>
      <ElementTool Name="Comment" ToolboxIcon="resources\exampleshapetoolbitmap.bmp" Caption="Comment" Tooltip="Comment" HelpKeyword="Comment">
        <DomainClassMoniker Name="Comment" />
      </ElementTool>
      <ConnectionTool Name="CommentRelationship" ToolboxIcon="resources\exampleconnectortoolbitmap.bmp" Caption="CommentRelationship" Tooltip="Comment Relationship" HelpKeyword="CommentRelationship">
        <ConnectionBuilderMoniker Name="PowerFunctionsReportDSL/CommentReferencesModelTypedBuilder" />
      </ConnectionTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="PowerFunctionsReportDSLDiagram" />
  </Designer>
  <Explorer ExplorerGuid="5c7fe4a1-755c-40cd-8227-ff738d5914d6" Title="PowerFunctionsReportDSL Explorer">
    <ExplorerBehaviorMoniker Name="PowerFunctionsReportDSL/PowerFunctionsReportDSLExplorer" />
  </Explorer>
</Dsl>