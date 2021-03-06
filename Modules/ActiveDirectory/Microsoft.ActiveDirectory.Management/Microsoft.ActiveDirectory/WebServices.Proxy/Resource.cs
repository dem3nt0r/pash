using System.CodeDom.Compiler;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Microsoft.ActiveDirectory.WebServices.Proxy
{
	[GeneratedCode("System.ServiceModel", "3.0.0.0")]
	[ServiceContract(Namespace="http://schemas.xmlsoap.org/ws/2004/09/transfer", ConfigurationName="Resource", SessionMode=SessionMode.Required)]
	internal interface Resource
	{
		[FaultContract(typeof(FaultDetail), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="AccessDenied", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.xmlsoap.org/ws/2004/08/addressing/fault", Name="DestinationUnreachable", Namespace="http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.microsoft.com/2006/11/IdentityManagement/DirectoryAccess/fault", Name="UnwillingToPerform", Namespace="http://schemas.microsoft.com/2006/11/IdentityManagement/DirectoryAccess")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="SchemaValidationError", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.xmlsoap.org/ws/2004/08/addressing/fault", Name="EndpointUnavailable", Namespace="http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		[OperationContract(Action="http://schemas.xmlsoap.org/ws/2004/09/transfer/Delete", ReplyAction="http://schemas.xmlsoap.org/ws/2004/09/transfer/DeleteResponse")]
		[XmlSerializerFormat(SupportFaults=true)]
		Message Delete(Message request);

		[FaultContract(typeof(FragmentDialect), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="FragmentDialectNotSupported", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.xmlsoap.org/ws/2004/08/addressing/fault", Name="EndpointUnavailable", Namespace="http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.xmlsoap.org/ws/2004/08/addressing/fault", Name="DestinationUnreachable", Namespace="http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		[FaultContract(typeof(AttributeTypeNotValid), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="CannotProcessFilter", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="SchemaValidationError", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[FaultContract(typeof(FaultDetail1), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="EncodingLimit", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.microsoft.com/2006/11/IdentityManagement/DirectoryAccess/fault", Name="UnwillingToPerform", Namespace="http://schemas.microsoft.com/2006/11/IdentityManagement/DirectoryAccess")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="AccessDenied", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[OperationContract(Action="http://schemas.xmlsoap.org/ws/2004/09/transfer/Get", ReplyAction="http://schemas.xmlsoap.org/ws/2004/09/transfer/GetResponse")]
		[XmlSerializerFormat(SupportFaults=true)]
		Message Get(Message request);

		[FaultContract(typeof(FaultDetail1), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="EncodingLimit", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.xmlsoap.org/ws/2004/08/addressing/fault", Name="DestinationUnreachable", Namespace="http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="SchemaValidationError", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.microsoft.com/2006/11/IdentityManagement/DirectoryAccess/fault", Name="UnwillingToPerform", Namespace="http://schemas.microsoft.com/2006/11/IdentityManagement/DirectoryAccess")]
		[FaultContract(typeof(FragmentDialect), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="FragmentDialectNotSupported", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.xmlsoap.org/ws/2004/08/addressing/fault", Name="EndpointUnavailable", Namespace="http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.xmlsoap.org/ws/2004/09/transfer/fault", Name="InvalidRepresentation")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="AccessDenied", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[FaultContract(typeof(FaultDetail), Action="http://schemas.xmlsoap.org/ws/2004/08/addressing/fault", Name="ActionNotSupportedFault", Namespace="http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		[FaultContract(typeof(AttributeTypeNotValid), Action="http://schemas.dmtf.org/wbem/wsman/1/wsman/fault", Name="CannotProcessFilter", Namespace="http://schemas.dmtf.org/wbem/wsman/1/wsman.xsd")]
		[OperationContract(Action="http://schemas.xmlsoap.org/ws/2004/09/transfer/Put", ReplyAction="http://schemas.xmlsoap.org/ws/2004/09/transfer/PutResponse")]
		[XmlSerializerFormat(SupportFaults=true)]
		Message Put(Message request);
	}
}