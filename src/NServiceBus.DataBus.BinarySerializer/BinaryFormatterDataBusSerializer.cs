namespace NServiceBus.DataBus
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

#pragma warning disable IDE0079
#pragma warning disable SYSLIB0011
    /// <summary>
    /// Data bus serialization using <see cref="BinaryFormatter" />.
    /// </summary>
    [ObsoleteEx(
        Message = "The BinaryFormatter is a security vurnerability and should not be used. Use the JsonDataBusSerializer instead.",
        TreatAsErrorFromVersion = "1.0",
        RemoveInVersion = "2.0")]
    public class BinaryFormatterDataBusSerializer : IDataBusSerializer
    {
        /// <summary>
        /// Serializes the property.
        /// </summary>
        public void Serialize(object databusProperty, Stream stream)
        {
            formatter.Serialize(stream, databusProperty);
        }

        /// <summary>
        /// Deserializes the property.
        /// </summary>
        public object Deserialize(Type propertyType, Stream stream)
        {
            return formatter.Deserialize(stream);
        }

        /// <summary>
        /// The content type this serializer handles. Used to populate the <see cref="Headers.DataBusContentType"/> header.
        /// </summary>
        public string ContentType { get; } = "application/octet-stream";

        static BinaryFormatter formatter = new BinaryFormatter();
    }
#pragma warning restore SYSLIB0011
#pragma warning restore IDE0079
}