// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using Microsoft.Extensions.Logging;

namespace PdfSharp.Pdf.Signatures
{
    /// <summary>
    /// PDFsharp cryptography message.
    /// </summary>
    readonly struct PsCryptoMsg(PsCryptoMsgId id, string message)
    {
        public PsCryptoMsgId Id { get; init; } = id;

        public string Message { get; init; } = message;

        public EventId EventId => new((int)Id, EventName);

        public string EventName => Id.ToString();
    }
}