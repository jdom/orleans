using System.Net;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table.Protocol;
using Microsoft.WindowsAzure.Storage.Blob.Protocol;

namespace Orleans.Storage
{
    internal static class StorageExceptionExtensions
    {
        /// <summary>
        /// See https://msdn.microsoft.com/en-us/library/azure/dd179438.aspx
        /// </summary>
        internal static bool IsUpdateConditionNotSatisfiedError(this StorageException storageException)
        {
            return Matches(storageException, HttpStatusCode.PreconditionFailed, TableErrorCodeStrings.UpdateConditionNotSatisfied);
        }

        /// <summary>
        /// See https://msdn.microsoft.com/en-us/library/azure/microsoft.windowsazure.storage.blob.protocol.bloberrorcodestrings.aspx
        /// </summary>
        internal static bool IsSourceConditionNotMetError(this StorageException storageException)
        {
            return Matches(storageException, HttpStatusCode.PreconditionFailed, BlobErrorCodeStrings.SourceConditionNotMet);
        }

        internal static bool Matches(this StorageException storageException, HttpStatusCode statusCode, string errorCode)
        {
            return storageException?.RequestInformation?.HttpStatusCode == (int)HttpStatusCode.PreconditionFailed
                && (storageException.RequestInformation.ExtendedErrorInformation?.ErrorCode.Equals(errorCode) == true);
        }
    }
}
