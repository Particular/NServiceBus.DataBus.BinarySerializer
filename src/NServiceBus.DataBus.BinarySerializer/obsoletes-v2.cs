#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace NServiceBus.DataBus
{
    using System;
    using System.IO;

    [ObsoleteEx(
        Message = "The BinaryFormatter is a security vulnerability and should not be used. Use the JsonDataBusSerializer instead.",
        TreatAsErrorFromVersion = "2.0",
        RemoveInVersion = "3.0")]

    public class BinaryFormatterDataBusSerializer : IDataBusSerializer
    {
        public void Serialize(object databusProperty, Stream stream)
        {
            throw new NotImplementedException();
        }

        public object Deserialize(Type propertyType, Stream stream)
        {
            throw new NotImplementedException();
        }

        public string ContentType { get; } = "application/octet-stream";
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member