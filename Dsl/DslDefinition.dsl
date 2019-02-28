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
        <DomainProperty Id="74902c3f-b848-4b69-868b-bff3729b552d" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModel.Has Default Constructor" Name="HasDefaultConstructor" DisplayName="Has Default Constructor" DefaultValue="true">
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="989a9706-3b2d-4409-bff0-87bfcd2d9d35" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModel.Has Known Types" Name="HasKnownTypes" DisplayName="Has Known Types" DefaultValue="false">
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="e7d5847a-2fea-4816-aa66-fc60b91d2cbe" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSModel.Folder Name" Name="FolderName" DisplayName="Folder Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
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
        <DomainProperty Id="2d411332-72ca-497e-9b2e-93bba3032d06" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ClassAttribute.Type" Name="Type" DisplayName="Type" DefaultValue="Float">
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
        <DomainProperty Id="f6be6a7b-5e44-43f2-ab97-c56c95242d17" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ClassAttribute.Model Code" Name="ModelCode" DisplayName="Model Code">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="386a150a-60f2-43dc-93ce-625a2f97e37e" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ClassAttribute.Measurement Type" Name="MeasurementType" DisplayName="Measurement Type" DefaultValue="None">
          <Type>
            <DomainEnumerationMoniker Name="MeasurementType" />
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
    <DomainClass Id="66aabeac-09c2-4ce5-9322-96b3248a8383" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.UIElement" Name="UIElement" DisplayName="UIElement" InheritanceModifier="Abstract" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="ModelType" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="bda40396-0863-4f18-ae95-019ccecc5213" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.UIElement.Should Generate" Name="ShouldGenerate" DisplayName="Should Generate" DefaultValue="true">
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="122c8e33-a382-4cd3-9f1c-1de20c059896" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Tab" Name="Tab" DisplayName="Tab" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="UIElement" />
      </BaseClass>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="TabAttribute" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>TabHasAttributes.Attributes</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="dbbae87e-0a21-474c-8c31-dcaf405fb63c" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.UIElementAttribute" Name="UIElementAttribute" DisplayName="UIElement Attribute" InheritanceModifier="Abstract" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="NamedElement" />
      </BaseClass>
    </DomainClass>
    <DomainClass Id="b78be496-b7e6-4883-84f6-7a38cd6a9680" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGrid" Name="DataGrid" DisplayName="Data Grid" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="UIElement" />
      </BaseClass>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="DataGridAttribute" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>DataGridHasAttributes.Attributes</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="ColumnAttribute" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>DataGridHasColumns.Columns</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="cf1c89dc-fb64-49d8-acaf-5fcf1fa77925" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ColumnAttribute" Name="ColumnAttribute" DisplayName="Column" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="UIElementAttribute" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="d48555ac-48a2-4fe7-baf0-b3ac93d9ccff" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ColumnAttribute.Binding" Name="Binding" DisplayName="Binding">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="fe3e5722-61fb-4a50-84f1-fde22328b0a7" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ColumnAttribute.Width" Name="Width" DisplayName="Width" DefaultValue="100">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="f1dc6219-44cf-4f11-99ee-457a241e9db3" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ColumnAttribute.Vertical Alignment" Name="VerticalAlignment" DisplayName="Vertical Alignment" DefaultValue="Center">
          <Type>
            <DomainEnumerationMoniker Name="VerticalAlignment" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="17d00c37-ce41-4d57-b562-35cf5ea0f4ff" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ColumnAttribute.Horizontal Alignment" Name="HorizontalAlignment" DisplayName="Horizontal Alignment" DefaultValue="Right">
          <Type>
            <DomainEnumerationMoniker Name="HorizontalAlignment" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="2af382ef-1bf9-4cf9-a527-f696c56cab9e" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ColumnAttribute.Header" Name="Header" DisplayName="Header">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="370bf9b5-4a84-4deb-8eab-9267ce36c6d2" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabAttribute" Name="TabAttribute" DisplayName="Tab Attribute" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="UIElementAttribute" />
      </BaseClass>
    </DomainClass>
    <DomainClass Id="c6c0e26a-2576-4220-8bb8-a997c3eb8320" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGridAttribute" Name="DataGridAttribute" DisplayName="Data Grid Attribute" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <BaseClass>
        <DomainClassMoniker Name="UIElementAttribute" />
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
        <DomainProperty Id="2b1cc60f-7173-476b-a920-8c111f9b04e1" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.Association.Model Code" Name="ModelCode" DisplayName="Model Code">
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
    <DomainRelationship Id="5b95880b-0ed6-4c12-8b04-4dc05aaaeeaa" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabReferencesTargetTabbed" Name="TabReferencesTargetTabbed" DisplayName="Tab References Target Tabbed" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <Source>
        <DomainRole Id="92c2ba81-a679-47bd-bbf0-b6c5db725397" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabReferencesTargetTabbed.SourceTab" Name="SourceTab" DisplayName="Source Tab" PropertyName="TargetTabbed" PropertyDisplayName="Target Tabbed">
          <RolePlayer>
            <DomainClassMoniker Name="Tab" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="b06f5450-03d5-4302-b6f5-00a7bddcaa29" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabReferencesTargetTabbed.TargetTab" Name="TargetTab" DisplayName="Target Tab" PropertyName="SourceTabbed" PropertyDisplayName="Source Tabbed">
          <RolePlayer>
            <DomainClassMoniker Name="Tab" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="508add89-35e2-4324-9825-1d67d0d43678" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabReferencesDataGrid" Name="TabReferencesDataGrid" DisplayName="Tab References Data Grid" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <Source>
        <DomainRole Id="216c2616-e332-49e9-8267-0407a36a459d" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabReferencesDataGrid.Tab" Name="Tab" DisplayName="Tab" PropertyName="DataGrid" Multiplicity="ZeroOne" PropertyDisplayName="Data Grid">
          <RolePlayer>
            <DomainClassMoniker Name="Tab" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="2282742b-83b5-4faf-9388-8eb27033a9fd" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabReferencesDataGrid.DataGrid" Name="DataGrid" DisplayName="Data Grid" PropertyName="Tab" Multiplicity="ZeroOne" PropertyDisplayName="Tab">
          <RolePlayer>
            <DomainClassMoniker Name="DataGrid" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="8db1a25a-0591-40f6-b67f-ec4527abb8ee" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabHasAttributes" Name="TabHasAttributes" DisplayName="Tab Has Attributes" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" IsEmbedding="true">
      <Source>
        <DomainRole Id="e603c66b-41d9-4075-99ca-f245da879fbe" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabHasAttributes.Tab" Name="Tab" DisplayName="Tab" PropertyName="Attributes" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Attributes">
          <RolePlayer>
            <DomainClassMoniker Name="Tab" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="ed158173-2feb-4efb-b2b4-b29e19acd9dc" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabHasAttributes.TabAttribute" Name="TabAttribute" DisplayName="Tab Attribute" PropertyName="Tab" Multiplicity="ZeroOne" PropagatesDelete="true" PropertyDisplayName="Tab">
          <RolePlayer>
            <DomainClassMoniker Name="TabAttribute" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="ef9946c4-2a1e-42f7-84cd-eb02957576ca" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGridHasAttributes" Name="DataGridHasAttributes" DisplayName="Data Grid Has Attributes" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" IsEmbedding="true">
      <Source>
        <DomainRole Id="fc49cc72-aff6-4b84-b7e0-4845682b0417" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGridHasAttributes.DataGrid" Name="DataGrid" DisplayName="Data Grid" PropertyName="Attributes" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Attributes">
          <RolePlayer>
            <DomainClassMoniker Name="DataGrid" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="eeaac050-be58-42cc-ba88-d147c9220d83" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGridHasAttributes.DataGridAttribute" Name="DataGridAttribute" DisplayName="Data Grid Attribute" PropertyName="DataGrid" Multiplicity="ZeroOne" PropagatesDelete="true" PropertyDisplayName="Data Grid">
          <RolePlayer>
            <DomainClassMoniker Name="DataGridAttribute" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="f693fce7-caf5-47c3-a524-39c9466b18b9" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGridHasColumns" Name="DataGridHasColumns" DisplayName="Data Grid Has Columns" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" IsEmbedding="true">
      <Source>
        <DomainRole Id="70bb8c67-4c2a-4783-b789-dbf491aa4f49" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGridHasColumns.DataGrid" Name="DataGrid" DisplayName="Data Grid" PropertyName="Columns" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Columns">
          <RolePlayer>
            <DomainClassMoniker Name="DataGrid" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="194c9b48-c6fa-464d-bca4-d5d48c2cc506" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGridHasColumns.ColumnAttribute" Name="ColumnAttribute" DisplayName="Column Attribute" PropertyName="DataGrid" Multiplicity="ZeroOne" PropagatesDelete="true" PropertyDisplayName="Data Grid">
          <RolePlayer>
            <DomainClassMoniker Name="ColumnAttribute" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="65ab45bd-1318-49bb-ae12-042d2aea3937" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGridJMSViewModel" Name="DataGridJMSViewModel" DisplayName="Data Grid JMSView Model" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL">
      <Source>
        <DomainRole Id="06ef3887-b487-45ca-9ffb-75bbe9fdccb6" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGridJMSViewModel.DataGrid" Name="DataGrid" DisplayName="Data Grid" PropertyName="JMSModel" Multiplicity="ZeroOne" PropertyDisplayName="JMSModel">
          <RolePlayer>
            <DomainClassMoniker Name="DataGrid" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="45b0af11-ef66-4525-bb6d-2923963ce3b2" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGridJMSViewModel.JMSModel" Name="JMSModel" DisplayName="JMSModel" PropertyName="DataGrid" PropertyDisplayName="Data Grid">
          <RolePlayer>
            <DomainClassMoniker Name="JMSModel" />
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
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.JMSResultType.Bean" Name="Bean" Value="3" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="ModelCodeTypes" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes">
      <Literals>
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Empty" Name="Empty" Value="0" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Byte" Name="Byte" Value="2" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Int32" Name="Int32" Value="3" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Int64" Name="Int64" Value="4" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Float" Name="Float" Value="5" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Double" Name="Double" Value="6" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.String" Name="String" Value="7" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.DateTime" Name="DateTime" Value="8" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Reference" Name="Reference" Value="9" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Bool" Name="Bool" Value="1" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Enum" Name="Enum" Value="10" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Struct" Name="Struct" Value="11" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.TimeSpan" Name="TimeSpan" Value="12" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Complex" Name="Complex" Value="13" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.BoolVector" Name="BoolVector" Value="17" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.DoubleVector" Name="DoubleVector" Value="22" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.StringVector" Name="StringVector" Value="23" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.DateTimeVector" Name="DateTimeVector" Value="24" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.ReferenceVector" Name="ReferenceVector" Value="25" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.EnumVector" Name="EnumVector" Value="26" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.StructVector" Name="StructVector" Value="27" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.TimeSpanVector" Name="TimeSpanVector" Value="28" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.ComplexVector" Name="ComplexVector" Value="29" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.ByteVector" Name="ByteVector" Value="18" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Int32Vector" Name="Int32Vector" Value="19" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Int64Vector" Name="Int64Vector" Value="20" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.FloatVector" Name="FloatVector" Value="21" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.BoolArray" Name="BoolArray" Value="33" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Int64Array" Name="Int64Array" Value="36" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.FloatArray" Name="FloatArray" Value="37" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.DoubleArray" Name="DoubleArray" Value="38" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.StringArray" Name="StringArray" Value="39" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.DateTimeArray" Name="DateTimeArray" Value="40" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.ReferenceArray" Name="ReferenceArray" Value="41" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.EnumArray" Name="EnumArray" Value="42" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.StructArray" Name="StructArray" Value="43" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.ByteArray" Name="ByteArray" Value="34" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.Int32Array" Name="Int32Array" Value="35" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.TimeSpanArray" Name="TimeSpanArray" Value="44" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ModelCodeTypes.ComplexArray" Name="ComplexArray" Value="45" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="MeasurementType" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType">
      <Literals>
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.Unitless" Name="Unitless" Value="0" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.Percent" Name="Percent" Value="27" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.RelativeVoltage" Name="RelativeVoltage" Value="29" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.Voltage" Name="Voltage" Value="1" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.Temperature" Name="Temperature" Value="7" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.ActiveEnergy" Name="ActiveEnergy" Value="8" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.ReactiveEnergy" Name="ReactiveEnergy" Value="9" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.ApparentPower" Name="ApparentPower" Value="10" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.VoltageAngle" Name="VoltageAngle" Value="11" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.Status" Name="Status" Value="12" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.Impedance" Name="Impedance" Value="22" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.Admittance" Name="Admittance" Value="24" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.Current" Name="Current" Value="2" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.ActivePower" Name="ActivePower" Value="3" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.ReactivePower" Name="ReactivePower" Value="4" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.CosPhi" Name="CosPhi" Value="5" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.Frequency" Name="Frequency" Value="6" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.EMSApparentPowerM" Name="EMSApparentPowerM" Value="39" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.EMSReactivePowerM" Name="EMSReactivePowerM" Value="40" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.EMSActivePowerM" Name="EMSActivePowerM" Value="41" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.MeasurementType.None" Name="None" Value="100" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="HorizontalAlignment" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.HorizontalAlignment">
      <Literals>
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.HorizontalAlignment.Center" Name="Center" Value="0" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.HorizontalAlignment.Left" Name="Left" Value="1" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.HorizontalAlignment.Right" Name="Right" Value="2" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.HorizontalAlignment.Stretch" Name="Stretch" Value="3" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="VerticalAlignment" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.VerticalAlignment">
      <Literals>
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.VerticalAlignment.Bottom" Name="Bottom" Value="0" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.VerticalAlignment.Center" Name="Center" Value="1" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.VerticalAlignment.Stretch" Name="Stretch" Value="2" />
        <EnumerationLiteral Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.VerticalAlignment.Top" Name="Top" Value="3" />
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
    <CompartmentShape Id="e66c55af-0348-48db-8963-eac7b1b01c4b" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabShape" Name="TabShape" DisplayName="Tab Shape" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Tab Shape" FillColor="Gray" InitialHeight="1" OutlineThickness="0.01" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopRight" HorizontalOffset="0" VerticalOffset="0">
        <ExpandCollapseDecorator Name="ExpandCollapseDecorator1" DisplayName="Expand Collapse Decorator1" />
      </ShapeHasDecorators>
      <Compartment Name="Attributes" Title="Attributes" />
    </CompartmentShape>
    <CompartmentShape Id="8e4295a4-5b61-47b1-a017-446368e00f65" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.UIElementShape" Name="UIElementShape" DisplayName="UIElement Shape" InheritanceModifier="Abstract" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="UIElement Shape" InitialHeight="1" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopRight" HorizontalOffset="0" VerticalOffset="0">
        <ExpandCollapseDecorator Name="ExpandCollapseDecorator1" DisplayName="Expand Collapse Decorator1" />
      </ShapeHasDecorators>
      <Compartment Name="Attributes" Title="Attributes" />
    </CompartmentShape>
    <CompartmentShape Id="47830df0-8582-4b3d-887f-91e93dd358af" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.DataGridShape" Name="DataGridShape" DisplayName="Data Grid Shape" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Data Grid Shape" FillColor="128, 255, 128" InitialHeight="1" OutlineThickness="0.01" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopRight" HorizontalOffset="0" VerticalOffset="0">
        <ExpandCollapseDecorator Name="ExpandCollapseDecorator1" DisplayName="Expand Collapse Decorator1" />
      </ShapeHasDecorators>
      <Compartment Name="Attributes" Title="Attributes" />
      <Compartment Name="Columns" Title="Columns" />
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
    <Connector Id="1ef5e009-fe1d-4e67-ae4c-d1bfcc970771" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.UIConnector" Name="UIConnector" DisplayName="UIConnector" InheritanceModifier="Abstract" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="UIConnector" Thickness="0.01" />
    <Connector Id="033d3a33-4f8f-4648-b18d-3536fb95ffec" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.TabConnector" Name="TabConnector" DisplayName="Tab Connector" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="Tab Connector" Color="Gray" Thickness="0.02">
      <BaseConnector>
        <ConnectorMoniker Name="UIConnector" />
      </BaseConnector>
    </Connector>
    <Connector Id="da3eab5c-4b1c-4274-8403-5a9bf475cb3f" Description="Description for SchneiderElectricDMS.PowerFunctionsReportDSL.ViewModelConnector" Name="ViewModelConnector" DisplayName="View Model Connector" Namespace="SchneiderElectricDMS.PowerFunctionsReportDSL" FixedTooltipText="View Model Connector" Color="128, 255, 128" Thickness="0.02">
      <BaseConnector>
        <ConnectorMoniker Name="UIConnector" />
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
          <XmlPropertyData XmlName="hasDefaultConstructor">
            <DomainPropertyMoniker Name="JMSModel/HasDefaultConstructor" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="hasKnownTypes">
            <DomainPropertyMoniker Name="JMSModel/HasKnownTypes" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="folderName">
            <DomainPropertyMoniker Name="JMSModel/FolderName" />
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
          <XmlPropertyData XmlName="modelCode">
            <DomainPropertyMoniker Name="ClassAttribute/ModelCode" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="measurementType">
            <DomainPropertyMoniker Name="ClassAttribute/MeasurementType" />
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
          <XmlPropertyData XmlName="modelCode">
            <DomainPropertyMoniker Name="Association/ModelCode" />
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
      <XmlClassData TypeName="UIElement" MonikerAttributeName="" SerializeId="true" MonikerElementName="uIElementMoniker" ElementName="uIElement" MonikerTypeName="UIElementMoniker">
        <DomainClassMoniker Name="UIElement" />
        <ElementData>
          <XmlPropertyData XmlName="shouldGenerate">
            <DomainPropertyMoniker Name="UIElement/ShouldGenerate" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Tab" MonikerAttributeName="" SerializeId="true" MonikerElementName="tabMoniker" ElementName="tab" MonikerTypeName="TabMoniker">
        <DomainClassMoniker Name="Tab" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="targetTabbed">
            <DomainRelationshipMoniker Name="TabReferencesTargetTabbed" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="dataGrid">
            <DomainRelationshipMoniker Name="TabReferencesDataGrid" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="attributes">
            <DomainRelationshipMoniker Name="TabHasAttributes" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="TabShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="tabShapeMoniker" ElementName="tabShape" MonikerTypeName="TabShapeMoniker">
        <CompartmentShapeMoniker Name="TabShape" />
      </XmlClassData>
      <XmlClassData TypeName="UIElementAttribute" MonikerAttributeName="" SerializeId="true" MonikerElementName="uIElementAttributeMoniker" ElementName="uIElementAttribute" MonikerTypeName="UIElementAttributeMoniker">
        <DomainClassMoniker Name="UIElementAttribute" />
      </XmlClassData>
      <XmlClassData TypeName="DataGrid" MonikerAttributeName="" SerializeId="true" MonikerElementName="dataGridMoniker" ElementName="dataGrid" MonikerTypeName="DataGridMoniker">
        <DomainClassMoniker Name="DataGrid" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="attributes">
            <DomainRelationshipMoniker Name="DataGridHasAttributes" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="columns">
            <DomainRelationshipMoniker Name="DataGridHasColumns" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="jMSModel">
            <DomainRelationshipMoniker Name="DataGridJMSViewModel" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="UIElementShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="uIElementShapeMoniker" ElementName="uIElementShape" MonikerTypeName="UIElementShapeMoniker">
        <CompartmentShapeMoniker Name="UIElementShape" />
      </XmlClassData>
      <XmlClassData TypeName="UIConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="uIConnectorMoniker" ElementName="uIConnector" MonikerTypeName="UIConnectorMoniker">
        <ConnectorMoniker Name="UIConnector" />
      </XmlClassData>
      <XmlClassData TypeName="TabConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="tabConnectorMoniker" ElementName="tabConnector" MonikerTypeName="TabConnectorMoniker">
        <ConnectorMoniker Name="TabConnector" />
      </XmlClassData>
      <XmlClassData TypeName="TabReferencesTargetTabbed" MonikerAttributeName="" SerializeId="true" MonikerElementName="tabReferencesTargetTabbedMoniker" ElementName="tabReferencesTargetTabbed" MonikerTypeName="TabReferencesTargetTabbedMoniker">
        <DomainRelationshipMoniker Name="TabReferencesTargetTabbed" />
      </XmlClassData>
      <XmlClassData TypeName="TabReferencesDataGrid" MonikerAttributeName="" SerializeId="true" MonikerElementName="tabReferencesDataGridMoniker" ElementName="tabReferencesDataGrid" MonikerTypeName="TabReferencesDataGridMoniker">
        <DomainRelationshipMoniker Name="TabReferencesDataGrid" />
      </XmlClassData>
      <XmlClassData TypeName="ColumnAttribute" MonikerAttributeName="" SerializeId="true" MonikerElementName="columnAttributeMoniker" ElementName="columnAttribute" MonikerTypeName="ColumnAttributeMoniker">
        <DomainClassMoniker Name="ColumnAttribute" />
        <ElementData>
          <XmlPropertyData XmlName="binding">
            <DomainPropertyMoniker Name="ColumnAttribute/Binding" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="width">
            <DomainPropertyMoniker Name="ColumnAttribute/Width" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="verticalAlignment">
            <DomainPropertyMoniker Name="ColumnAttribute/VerticalAlignment" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="horizontalAlignment">
            <DomainPropertyMoniker Name="ColumnAttribute/HorizontalAlignment" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="header">
            <DomainPropertyMoniker Name="ColumnAttribute/Header" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="TabAttribute" MonikerAttributeName="" SerializeId="true" MonikerElementName="tabAttributeMoniker" ElementName="tabAttribute" MonikerTypeName="TabAttributeMoniker">
        <DomainClassMoniker Name="TabAttribute" />
      </XmlClassData>
      <XmlClassData TypeName="DataGridAttribute" MonikerAttributeName="" SerializeId="true" MonikerElementName="dataGridAttributeMoniker" ElementName="dataGridAttribute" MonikerTypeName="DataGridAttributeMoniker">
        <DomainClassMoniker Name="DataGridAttribute" />
      </XmlClassData>
      <XmlClassData TypeName="TabHasAttributes" MonikerAttributeName="" SerializeId="true" MonikerElementName="tabHasAttributesMoniker" ElementName="tabHasAttributes" MonikerTypeName="TabHasAttributesMoniker">
        <DomainRelationshipMoniker Name="TabHasAttributes" />
      </XmlClassData>
      <XmlClassData TypeName="DataGridHasAttributes" MonikerAttributeName="" SerializeId="true" MonikerElementName="dataGridHasAttributesMoniker" ElementName="dataGridHasAttributes" MonikerTypeName="DataGridHasAttributesMoniker">
        <DomainRelationshipMoniker Name="DataGridHasAttributes" />
      </XmlClassData>
      <XmlClassData TypeName="DataGridHasColumns" MonikerAttributeName="" SerializeId="true" MonikerElementName="dataGridHasColumnsMoniker" ElementName="dataGridHasColumns" MonikerTypeName="DataGridHasColumnsMoniker">
        <DomainRelationshipMoniker Name="DataGridHasColumns" />
      </XmlClassData>
      <XmlClassData TypeName="DataGridShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="dataGridShapeMoniker" ElementName="dataGridShape" MonikerTypeName="DataGridShapeMoniker">
        <CompartmentShapeMoniker Name="DataGridShape" />
      </XmlClassData>
      <XmlClassData TypeName="ViewModelConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="viewModelConnectorMoniker" ElementName="viewModelConnector" MonikerTypeName="ViewModelConnectorMoniker">
        <ConnectorMoniker Name="ViewModelConnector" />
      </XmlClassData>
      <XmlClassData TypeName="DataGridJMSViewModel" MonikerAttributeName="" SerializeId="true" MonikerElementName="dataGridJMSViewModelMoniker" ElementName="dataGridJMSViewModel" MonikerTypeName="DataGridJMSViewModelMoniker">
        <DomainRelationshipMoniker Name="DataGridJMSViewModel" />
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
    <ConnectionBuilder Name="TabReferencesTargetTabbedBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="TabReferencesTargetTabbed" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Tab" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Tab" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
    <ConnectionBuilder Name="TabReferencesDataGridBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="TabReferencesDataGrid" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Tab" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="DataGrid" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
    <ConnectionBuilder Name="DataGridJMSViewModelBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="DataGridJMSViewModel" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="DataGrid" />
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
      <CompartmentShapeMap>
        <DomainClassMoniker Name="Tab" />
        <ParentElementPath>
          <DomainPath>ModelRootHasTypes.ModelRoot/!ModelRoot</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="UIElementShape/Name" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="NamedElement/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="TabShape/Name" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="NamedElement/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <CompartmentShapeMoniker Name="TabShape" />
        <CompartmentMap>
          <CompartmentMoniker Name="TabShape/Attributes" />
          <ElementsDisplayed>
            <DomainPath>TabHasAttributes.Attributes/!TabAttribute</DomainPath>
          </ElementsDisplayed>
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="NamedElement/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </CompartmentMap>
      </CompartmentShapeMap>
      <CompartmentShapeMap>
        <DomainClassMoniker Name="DataGrid" />
        <ParentElementPath>
          <DomainPath>ModelRootHasTypes.ModelRoot/!ModelRoot</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="DataGridShape/Name" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="NamedElement/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <CompartmentShapeMoniker Name="DataGridShape" />
        <CompartmentMap>
          <CompartmentMoniker Name="DataGridShape/Attributes" />
          <ElementsDisplayed>
            <DomainPath>DataGridHasAttributes.Attributes/!DataGridAttribute</DomainPath>
          </ElementsDisplayed>
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="NamedElement/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </CompartmentMap>
        <CompartmentMap>
          <CompartmentMoniker Name="DataGridShape/Columns" />
          <ElementsDisplayed>
            <DomainPath>DataGridHasColumns.Columns/!ColumnAttribute</DomainPath>
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
      <ConnectorMap>
        <ConnectorMoniker Name="TabConnector" />
        <DomainRelationshipMoniker Name="TabReferencesTargetTabbed" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="TabConnector" />
        <DomainRelationshipMoniker Name="TabReferencesDataGrid" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="ViewModelConnector" />
        <DomainRelationshipMoniker Name="DataGridJMSViewModel" />
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
      <ConnectionTool Name="UndirectionalAssociation" ToolboxIcon="Resources\UnidirectionTool.bmp" Caption="Association" Tooltip="Undirectional Association" HelpKeyword="UndirectionalAssociation">
        <ConnectionBuilderMoniker Name="PowerFunctionsReportDSL/UndirectionalAssociationBuilder" />
      </ConnectionTool>
      <ElementTool Name="Comment" ToolboxIcon="resources\exampleshapetoolbitmap.bmp" Caption="Comment" Tooltip="Comment" HelpKeyword="Comment">
        <DomainClassMoniker Name="Comment" />
      </ElementTool>
      <ConnectionTool Name="CommentRelationship" ToolboxIcon="resources\exampleconnectortoolbitmap.bmp" Caption="CommentRelationship" Tooltip="Comment Relationship" HelpKeyword="CommentRelationship">
        <ConnectionBuilderMoniker Name="PowerFunctionsReportDSL/CommentReferencesModelTypedBuilder" />
      </ConnectionTool>
      <ElementTool Name="Tab" ToolboxIcon="Resources\ClassTool.bmp" Caption="Tab" Tooltip="Tab" HelpKeyword="Tab">
        <DomainClassMoniker Name="Tab" />
      </ElementTool>
      <ElementTool Name="DataGrid" ToolboxIcon="Resources\ClassTool.bmp" Caption="Data Grid" Tooltip="Data Grid" HelpKeyword="DataGrid">
        <DomainClassMoniker Name="DataGrid" />
      </ElementTool>
      <ConnectionTool Name="TabTabReference" ToolboxIcon="Resources\AssociationTool.bmp" Caption="Tab-&gt;Tab" Tooltip="Tab Tab Reference" HelpKeyword="TabTabReference">
        <ConnectionBuilderMoniker Name="PowerFunctionsReportDSL/TabReferencesTargetTabbedBuilder" />
      </ConnectionTool>
      <ConnectionTool Name="TabDataGridReference" ToolboxIcon="Resources\AssociationTool.bmp" Caption="Tab-&gt;DataGrid" Tooltip="Tab Data Grid Reference" HelpKeyword="TabDataGridReference">
        <ConnectionBuilderMoniker Name="PowerFunctionsReportDSL/TabReferencesDataGridBuilder" />
      </ConnectionTool>
      <ConnectionTool Name="DataGridViewModel" ToolboxIcon="Resources\AssociationTool.bmp" Caption="DataGrid-&gt;ViewModel" Tooltip="Data Grid View Model" HelpKeyword="DataGridViewModel">
        <ConnectionBuilderMoniker Name="PowerFunctionsReportDSL/DataGridJMSViewModelBuilder" />
      </ConnectionTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="PowerFunctionsReportDSLDiagram" />
  </Designer>
  <Explorer ExplorerGuid="5c7fe4a1-755c-40cd-8227-ff738d5914d6" Title="PowerFunctionsReportDSL Explorer">
    <ExplorerBehaviorMoniker Name="PowerFunctionsReportDSL/PowerFunctionsReportDSLExplorer" />
  </Explorer>
</Dsl>