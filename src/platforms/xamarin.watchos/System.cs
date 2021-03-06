// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Win32.SafeHandles
{
    public sealed partial class SafeProcessHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        public SafeProcessHandle(System.IntPtr existingHandle, bool ownsHandle) : base (default(bool)) { }
        protected override bool ReleaseHandle() { throw null; }
    }
    public sealed partial class SafeX509ChainHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        internal SafeX509ChainHandle() : base (default(bool)) { }
        protected override bool ReleaseHandle() { throw null; }
    }
}
namespace Mono.Security.Cryptography
{
    public sealed partial class PKCS8
    {
        internal PKCS8() { }
        public static Mono.Security.Cryptography.PKCS8.KeyInfo GetType(byte[] data) { throw null; }
        public partial class EncryptedPrivateKeyInfo
        {
            public EncryptedPrivateKeyInfo() { }
            public EncryptedPrivateKeyInfo(byte[] data) { }
            public string Algorithm { get { throw null; } set { } }
            public byte[] EncryptedData { get { throw null; } set { } }
            public int IterationCount { get { throw null; } set { } }
            public byte[] Salt { get { throw null; } set { } }
            public byte[] GetBytes() { throw null; }
        }
        public enum KeyInfo
        {
            PrivateKey = 0,
            EncryptedPrivateKey = 1,
            Unknown = 2,
        }
        public partial class PrivateKeyInfo
        {
            public PrivateKeyInfo() { }
            public PrivateKeyInfo(byte[] data) { }
            public string Algorithm { get { throw null; } set { } }
            public System.Collections.ArrayList Attributes { get { throw null; } }
            public byte[] PrivateKey { get { throw null; } set { } }
            public int Version { get { throw null; } set { } }
            public static System.Security.Cryptography.DSA DecodeDSA(byte[] privateKey, System.Security.Cryptography.DSAParameters dsaParameters) { throw null; }
            public static System.Security.Cryptography.RSA DecodeRSA(byte[] keypair) { throw null; }
            public static byte[] Encode(System.Security.Cryptography.AsymmetricAlgorithm aa) { throw null; }
            public static byte[] Encode(System.Security.Cryptography.DSA dsa) { throw null; }
            public static byte[] Encode(System.Security.Cryptography.RSA rsa) { throw null; }
            public byte[] GetBytes() { throw null; }
        }
    }
}
namespace System
{
    public partial class FileStyleUriParser : System.UriParser
    {
        public FileStyleUriParser() { }
    }
    public partial class FtpStyleUriParser : System.UriParser
    {
        public FtpStyleUriParser() { }
    }
    public partial class GenericUriParser : System.UriParser
    {
        public GenericUriParser(System.GenericUriParserOptions options) { }
    }
    [System.FlagsAttribute]
    public enum GenericUriParserOptions
    {
        Default = 0,
        GenericAuthority = 1,
        AllowEmptyAuthority = 2,
        NoUserInfo = 4,
        NoPort = 8,
        NoQuery = 16,
        NoFragment = 32,
        DontConvertPathBackslashes = 64,
        DontCompressPath = 128,
        DontUnescapePathDotsAndSlashes = 256,
        Idn = 512,
        IriParsing = 1024,
    }
    public partial class GopherStyleUriParser : System.UriParser
    {
        public GopherStyleUriParser() { }
    }
    public partial class HttpStyleUriParser : System.UriParser
    {
        public HttpStyleUriParser() { }
    }
    public partial class LdapStyleUriParser : System.UriParser
    {
        public LdapStyleUriParser() { }
    }
    public partial class NetPipeStyleUriParser : System.UriParser
    {
        public NetPipeStyleUriParser() { }
    }
    public partial class NetTcpStyleUriParser : System.UriParser
    {
        public NetTcpStyleUriParser() { }
    }
    public partial class NewsStyleUriParser : System.UriParser
    {
        public NewsStyleUriParser() { }
    }
    public static partial class StringNormalizationExtensions
    {
        public static bool IsNormalized(this string strInput) { throw null; }
        public static bool IsNormalized(this string strInput, System.Text.NormalizationForm normalizationForm) { throw null; }
        public static string Normalize(this string strInput) { throw null; }
        public static string Normalize(this string strInput, System.Text.NormalizationForm normalizationForm) { throw null; }
    }
    public partial class Uri : System.Runtime.Serialization.ISerializable
    {
        public static readonly string SchemeDelimiter;
        public static readonly string UriSchemeFile;
        public static readonly string UriSchemeFtp;
        public static readonly string UriSchemeGopher;
        public static readonly string UriSchemeHttp;
        public static readonly string UriSchemeHttps;
        public static readonly string UriSchemeMailto;
        public static readonly string UriSchemeNetPipe;
        public static readonly string UriSchemeNetTcp;
        public static readonly string UriSchemeNews;
        public static readonly string UriSchemeNntp;
        protected Uri(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public Uri(string uriString) { }
        [System.ObsoleteAttribute("The constructor has been deprecated. Please use new Uri(string). The dontEscape parameter is deprecated and is always false. http://go.microsoft.com/fwlink/?linkid=14202")]
        public Uri(string uriString, bool dontEscape) { }
        public Uri(string uriString, System.UriKind uriKind) { }
        public Uri(System.Uri baseUri, string relativeUri) { }
        [System.ObsoleteAttribute("The constructor has been deprecated. Please new Uri(Uri, string). The dontEscape parameter is deprecated and is always false. http://go.microsoft.com/fwlink/?linkid=14202")]
        public Uri(System.Uri baseUri, string relativeUri, bool dontEscape) { }
        public Uri(System.Uri baseUri, System.Uri relativeUri) { }
        public string AbsolutePath { get { throw null; } }
        public string AbsoluteUri { get { throw null; } }
        public string Authority { get { throw null; } }
        public string DnsSafeHost { get { throw null; } }
        public string Fragment { get { throw null; } }
        public string Host { get { throw null; } }
        public System.UriHostNameType HostNameType { get { throw null; } }
        public string IdnHost { get { throw null; } }
        public bool IsAbsoluteUri { get { throw null; } }
        public bool IsDefaultPort { get { throw null; } }
        public bool IsFile { get { throw null; } }
        public bool IsLoopback { get { throw null; } }
        public bool IsUnc { get { throw null; } }
        public string LocalPath { get { throw null; } }
        public string OriginalString { get { throw null; } }
        public string PathAndQuery { get { throw null; } }
        public int Port { get { throw null; } }
        public string Query { get { throw null; } }
        public string Scheme { get { throw null; } }
        public string[] Segments { get { throw null; } }
        public bool UserEscaped { get { throw null; } }
        public string UserInfo { get { throw null; } }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void Canonicalize() { }
        public static System.UriHostNameType CheckHostName(string name) { throw null; }
        public static bool CheckSchemeName(string schemeName) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void CheckSecurity() { }
        public static int Compare(System.Uri uri1, System.Uri uri2, System.UriComponents partsToCompare, System.UriFormat compareFormat, System.StringComparison comparisonType) { throw null; }
        public override bool Equals(object comparand) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void Escape() { }
        public static string EscapeDataString(string stringToEscape) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. Please use GetComponents() or static EscapeUriString() to escape a Uri component or a string. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected static string EscapeString(string str) { throw null; }
        public static string EscapeUriString(string stringToEscape) { throw null; }
        public static int FromHex(char digit) { throw null; }
        public string GetComponents(System.UriComponents components, System.UriFormat format) { throw null; }
        public override int GetHashCode() { throw null; }
        public string GetLeftPart(System.UriPartial part) { throw null; }
        protected void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public static string HexEscape(char character) { throw null; }
        public static char HexUnescape(string pattern, ref int index) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual bool IsBadFileSystemCharacter(char character) { throw null; }
        public bool IsBaseOf(System.Uri uri) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected static bool IsExcludedCharacter(char character) { throw null; }
        public static bool IsHexDigit(char character) { throw null; }
        public static bool IsHexEncoding(string pattern, int index) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual bool IsReservedCharacter(char character) { throw null; }
        public bool IsWellFormedOriginalString() { throw null; }
        public static bool IsWellFormedUriString(string uriString, System.UriKind uriKind) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. Please use MakeRelativeUri(Uri uri). http://go.microsoft.com/fwlink/?linkid=14202")]
        public string MakeRelative(System.Uri toUri) { throw null; }
        public System.Uri MakeRelativeUri(System.Uri uri) { throw null; }
        public static bool operator ==(System.Uri uri1, System.Uri uri2) { throw null; }
        public static bool operator !=(System.Uri uri1, System.Uri uri2) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void Parse() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override string ToString() { throw null; }
        public static bool TryCreate(string uriString, System.UriKind uriKind, out System.Uri result) { throw null; }
        public static bool TryCreate(System.Uri baseUri, string relativeUri, out System.Uri result) { throw null; }
        public static bool TryCreate(System.Uri baseUri, System.Uri relativeUri, out System.Uri result) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. Please use GetComponents() or static UnescapeDataString() to unescape a Uri component or a string. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual string Unescape(string path) { throw null; }
        public static string UnescapeDataString(string stringToUnescape) { throw null; }
    }
    public partial class UriBuilder
    {
        public UriBuilder() { }
        public UriBuilder(string uri) { }
        public UriBuilder(string schemeName, string hostName) { }
        public UriBuilder(string scheme, string host, int portNumber) { }
        public UriBuilder(string scheme, string host, int port, string pathValue) { }
        public UriBuilder(string scheme, string host, int port, string path, string extraValue) { }
        public UriBuilder(System.Uri uri) { }
        public string Fragment { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public int Port { get { throw null; } set { } }
        public string Query { get { throw null; } set { } }
        public string Scheme { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } }
        public string UserName { get { throw null; } set { } }
        public override bool Equals(object rparam) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum UriComponents
    {
        SerializationInfoString = -2147483648,
        Scheme = 1,
        UserInfo = 2,
        Host = 4,
        Port = 8,
        SchemeAndServer = 13,
        Path = 16,
        Query = 32,
        PathAndQuery = 48,
        HttpRequestUrl = 61,
        Fragment = 64,
        AbsoluteUri = 127,
        StrongPort = 128,
        HostAndPort = 132,
        StrongAuthority = 134,
        NormalizedHost = 256,
        KeepDelimiter = 1073741824,
    }
    public enum UriFormat
    {
        UriEscaped = 1,
        Unescaped = 2,
        SafeUnescaped = 3,
    }
    public partial class UriFormatException : System.FormatException, System.Runtime.Serialization.ISerializable
    {
        public UriFormatException() { }
        protected UriFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public UriFormatException(string textString) { }
        public UriFormatException(string textString, System.Exception e) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public enum UriHostNameType
    {
        Unknown = 0,
        Basic = 1,
        Dns = 2,
        IPv4 = 3,
        IPv6 = 4,
    }
    public enum UriIdnScope
    {
        None = 0,
        AllExceptIntranet = 1,
        All = 2,
    }
    public enum UriKind
    {
        RelativeOrAbsolute = 0,
        Absolute = 1,
        Relative = 2,
    }
    public abstract partial class UriParser
    {
        protected UriParser() { }
        protected virtual string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format) { throw null; }
        protected virtual void InitializeAndValidate(System.Uri uri, out System.UriFormatException parsingError) { throw null; }
        protected virtual bool IsBaseOf(System.Uri baseUri, System.Uri relativeUri) { throw null; }
        public static bool IsKnownScheme(string schemeName) { throw null; }
        protected virtual bool IsWellFormedOriginalString(System.Uri uri) { throw null; }
        protected virtual System.UriParser OnNewUri() { throw null; }
        protected virtual void OnRegister(string schemeName, int defaultPort) { }
        public static void Register(System.UriParser uriParser, string schemeName, int defaultPort) { }
        protected virtual string Resolve(System.Uri baseUri, System.Uri relativeUri, out System.UriFormatException parsingError) { throw null; }
    }
    public enum UriPartial
    {
        Scheme = 0,
        Authority = 1,
        Path = 2,
        Query = 3,
    }
    public partial class UriTypeConverter : System.ComponentModel.TypeConverter
    {
        public UriTypeConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
}
namespace System.CodeDom.Compiler
{
    [System.AttributeUsageAttribute(System.AttributeTargets.All, Inherited=false, AllowMultiple=false)]
    public sealed partial class GeneratedCodeAttribute : System.Attribute
    {
        public GeneratedCodeAttribute(string tool, string version) { }
        public string Tool { get { throw null; } }
        public string Version { get { throw null; } }
    }
    public partial class IndentedTextWriter : System.IO.TextWriter
    {
        public const string DefaultTabString = "    ";
        public IndentedTextWriter(System.IO.TextWriter writer) { }
        public IndentedTextWriter(System.IO.TextWriter writer, string tabString) { }
        public override System.Text.Encoding Encoding { get { throw null; } }
        public int Indent { get { throw null; } set { } }
        public System.IO.TextWriter InnerWriter { get { throw null; } }
        public override string NewLine { get { throw null; } set { } }
        public override void Close() { }
        public override void Flush() { }
        protected virtual void OutputTabs() { }
        public override void Write(bool value) { }
        public override void Write(char value) { }
        public override void Write(char[] buffer) { }
        public override void Write(char[] buffer, int index, int count) { }
        public override void Write(double value) { }
        public override void Write(int value) { }
        public override void Write(long value) { }
        public override void Write(object value) { }
        public override void Write(float value) { }
        public override void Write(string s) { }
        public override void Write(string format, object arg0) { }
        public override void Write(string format, object arg0, object arg1) { }
        public override void Write(string format, params object[] arg) { }
        public override void WriteLine() { }
        public override void WriteLine(bool value) { }
        public override void WriteLine(char value) { }
        public override void WriteLine(char[] buffer) { }
        public override void WriteLine(char[] buffer, int index, int count) { }
        public override void WriteLine(double value) { }
        public override void WriteLine(int value) { }
        public override void WriteLine(long value) { }
        public override void WriteLine(object value) { }
        public override void WriteLine(float value) { }
        public override void WriteLine(string s) { }
        public override void WriteLine(string format, object arg0) { }
        public override void WriteLine(string format, object arg0, object arg1) { }
        public override void WriteLine(string format, params object[] arg) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteLine(uint value) { }
        public void WriteLineNoTabs(string s) { }
    }
}
namespace System.Collections.Concurrent
{
    public partial class BlockingCollection<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.IDisposable
    {
        public BlockingCollection() { }
        public BlockingCollection(System.Collections.Concurrent.IProducerConsumerCollection<T> collection) { }
        public BlockingCollection(System.Collections.Concurrent.IProducerConsumerCollection<T> collection, int boundedCapacity) { }
        public BlockingCollection(int boundedCapacity) { }
        public int BoundedCapacity { get { throw null; } }
        public int Count { get { throw null; } }
        public bool IsAddingCompleted { get { throw null; } }
        public bool IsCompleted { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public void Add(T item) { }
        public void Add(T item, System.Threading.CancellationToken cancellationToken) { }
        public static int AddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item) { throw null; }
        public static int AddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void CompleteAdding() { }
        public void CopyTo(T[] array, int index) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.Collections.Generic.IEnumerable<T> GetConsumingEnumerable() { throw null; }
        public System.Collections.Generic.IEnumerable<T> GetConsumingEnumerable(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public T Take() { throw null; }
        public T Take(System.Threading.CancellationToken cancellationToken) { throw null; }
        public static int TakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item) { throw null; }
        public static int TakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item, System.Threading.CancellationToken cancellationToken) { throw null; }
        public T[] ToArray() { throw null; }
        public bool TryAdd(T item) { throw null; }
        public bool TryAdd(T item, int millisecondsTimeout) { throw null; }
        public bool TryAdd(T item, int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public bool TryAdd(T item, System.TimeSpan timeout) { throw null; }
        public static int TryAddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item) { throw null; }
        public static int TryAddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item, int millisecondsTimeout) { throw null; }
        public static int TryAddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item, int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static int TryAddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item, System.TimeSpan timeout) { throw null; }
        public bool TryTake(out T item) { throw null; }
        public bool TryTake(out T item, int millisecondsTimeout) { throw null; }
        public bool TryTake(out T item, int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public bool TryTake(out T item, System.TimeSpan timeout) { throw null; }
        public static int TryTakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item) { throw null; }
        public static int TryTakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item, int millisecondsTimeout) { throw null; }
        public static int TryTakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static int TryTakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item, System.TimeSpan timeout) { throw null; }
    }
    public partial class ConcurrentBag<T> : System.Collections.Concurrent.IProducerConsumerCollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.ICollection, System.Collections.IEnumerable
    {
        public ConcurrentBag() { }
        public ConcurrentBag(System.Collections.Generic.IEnumerable<T> collection) { }
        public int Count { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public void Add(T item) { }
        public void Clear() { }
        public void CopyTo(T[] array, int index) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item) { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public T[] ToArray() { throw null; }
        public bool TryPeek(out T result) { throw null; }
        public bool TryTake(out T result) { throw null; }
    }
}
namespace System.Collections.Generic
{
    public partial interface ISet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        new bool Add(T item);
        void ExceptWith(System.Collections.Generic.IEnumerable<T> other);
        void IntersectWith(System.Collections.Generic.IEnumerable<T> other);
        bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other);
        bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other);
        bool IsSubsetOf(System.Collections.Generic.IEnumerable<T> other);
        bool IsSupersetOf(System.Collections.Generic.IEnumerable<T> other);
        bool Overlaps(System.Collections.Generic.IEnumerable<T> other);
        bool SetEquals(System.Collections.Generic.IEnumerable<T> other);
        void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other);
        void UnionWith(System.Collections.Generic.IEnumerable<T> other);
    }
    public sealed partial class LinkedListNode<T>
    {
        public LinkedListNode(T value) { }
        public System.Collections.Generic.LinkedList<T> List { get { throw null; } }
        public System.Collections.Generic.LinkedListNode<T> Next { get { throw null; } }
        public System.Collections.Generic.LinkedListNode<T> Previous { get { throw null; } }
        public T Value { get { throw null; } set { } }
    }
    public partial class LinkedList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        public LinkedList() { }
        public LinkedList(System.Collections.Generic.IEnumerable<T> collection) { }
        protected LinkedList(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public int Count { get { throw null; } }
        public System.Collections.Generic.LinkedListNode<T> First { get { throw null; } }
        public System.Collections.Generic.LinkedListNode<T> Last { get { throw null; } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public void AddAfter(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }
        public System.Collections.Generic.LinkedListNode<T> AddAfter(System.Collections.Generic.LinkedListNode<T> node, T value) { throw null; }
        public void AddBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }
        public System.Collections.Generic.LinkedListNode<T> AddBefore(System.Collections.Generic.LinkedListNode<T> node, T value) { throw null; }
        public void AddFirst(System.Collections.Generic.LinkedListNode<T> node) { }
        public System.Collections.Generic.LinkedListNode<T> AddFirst(T value) { throw null; }
        public void AddLast(System.Collections.Generic.LinkedListNode<T> node) { }
        public System.Collections.Generic.LinkedListNode<T> AddLast(T value) { throw null; }
        public void Clear() { }
        public bool Contains(T value) { throw null; }
        public void CopyTo(T[] array, int index) { }
        public System.Collections.Generic.LinkedListNode<T> Find(T value) { throw null; }
        public System.Collections.Generic.LinkedListNode<T> FindLast(T value) { throw null; }
        public System.Collections.Generic.LinkedList<T>.Enumerator GetEnumerator() { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual void OnDeserialization(object sender) { }
        public void Remove(System.Collections.Generic.LinkedListNode<T> node) { }
        public bool Remove(T value) { throw null; }
        public void RemoveFirst() { }
        public void RemoveLast() { }
        void System.Collections.Generic.ICollection<T>.Add(T value) { }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
        {
            private T _current;
            private object _dummy;
            private int _dummyPrimitive;
            public T Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
            void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
            void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        }
    }
    public partial class SortedDictionary<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        public SortedDictionary() { }
        public SortedDictionary(System.Collections.Generic.IComparer<TKey> comparer) { }
        public SortedDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public SortedDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IComparer<TKey> comparer) { }
        public System.Collections.Generic.IComparer<TKey> Comparer { get { throw null; } }
        public int Count { get { throw null; } }
        public TValue this[TKey key] { get { throw null; } set { } }
        public System.Collections.Generic.SortedDictionary<TKey, TValue>.KeyCollection Keys { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get { throw null; } }
        System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get { throw null; } }
        System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get { throw null; } }
        System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get { throw null; } }
        System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IDictionary.IsFixedSize { get { throw null; } }
        bool System.Collections.IDictionary.IsReadOnly { get { throw null; } }
        object System.Collections.IDictionary.this[object key] { get { throw null; } set { } }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get { throw null; } }
        System.Collections.ICollection System.Collections.IDictionary.Values { get { throw null; } }
        public System.Collections.Generic.SortedDictionary<TKey, TValue>.ValueCollection Values { get { throw null; } }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool ContainsKey(TKey key) { throw null; }
        public bool ContainsValue(TValue value) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int index) { }
        public System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator GetEnumerator() { throw null; }
        public bool Remove(TKey key) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { throw null; }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        void System.Collections.IDictionary.Add(object key, object value) { }
        bool System.Collections.IDictionary.Contains(object key) { throw null; }
        System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { throw null; }
        void System.Collections.IDictionary.Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(TKey key, out TValue value) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator, System.IDisposable
        {
            private object _dummy;
            private int _dummyPrimitive;
            public System.Collections.Generic.KeyValuePair<TKey, TValue> Current { get { throw null; } }
            System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get { throw null; } }
            object System.Collections.IDictionaryEnumerator.Key { get { throw null; } }
            object System.Collections.IDictionaryEnumerator.Value { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
        }
        public sealed partial class KeyCollection : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.Generic.IReadOnlyCollection<TKey>, System.Collections.ICollection, System.Collections.IEnumerable
        {
            public KeyCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary) { }
            public int Count { get { throw null; } }
            bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get { throw null; } }
            bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
            object System.Collections.ICollection.SyncRoot { get { throw null; } }
            public void CopyTo(TKey[] array, int index) { }
            public System.Collections.Generic.SortedDictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator() { throw null; }
            void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
            void System.Collections.Generic.ICollection<TKey>.Clear() { }
            bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { throw null; }
            bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { throw null; }
            System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { throw null; }
            void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
            [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
            public partial struct Enumerator : System.Collections.Generic.IEnumerator<TKey>, System.Collections.IEnumerator, System.IDisposable
            {
                private object _dummy;
                private int _dummyPrimitive;
                public TKey Current { get { throw null; } }
                object System.Collections.IEnumerator.Current { get { throw null; } }
                public void Dispose() { }
                public bool MoveNext() { throw null; }
                void System.Collections.IEnumerator.Reset() { }
            }
        }
        public sealed partial class ValueCollection : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.Generic.IReadOnlyCollection<TValue>, System.Collections.ICollection, System.Collections.IEnumerable
        {
            public ValueCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary) { }
            public int Count { get { throw null; } }
            bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get { throw null; } }
            bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
            object System.Collections.ICollection.SyncRoot { get { throw null; } }
            public void CopyTo(TValue[] array, int index) { }
            public System.Collections.Generic.SortedDictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator() { throw null; }
            void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
            void System.Collections.Generic.ICollection<TValue>.Clear() { }
            bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { throw null; }
            bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { throw null; }
            System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { throw null; }
            void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
            [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
            public partial struct Enumerator : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
            {
                private object _dummy;
                private int _dummyPrimitive;
                public TValue Current { get { throw null; } }
                object System.Collections.IEnumerator.Current { get { throw null; } }
                public void Dispose() { }
                public bool MoveNext() { throw null; }
                void System.Collections.IEnumerator.Reset() { }
            }
        }
    }
    public partial class SortedList<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        public SortedList() { }
        public SortedList(System.Collections.Generic.IComparer<TKey> comparer) { }
        public SortedList(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public SortedList(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IComparer<TKey> comparer) { }
        public SortedList(int capacity) { }
        public SortedList(int capacity, System.Collections.Generic.IComparer<TKey> comparer) { }
        public int Capacity { get { throw null; } set { } }
        public System.Collections.Generic.IComparer<TKey> Comparer { get { throw null; } }
        public int Count { get { throw null; } }
        public TValue this[TKey key] { get { throw null; } set { } }
        public System.Collections.Generic.IList<TKey> Keys { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get { throw null; } }
        System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get { throw null; } }
        System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get { throw null; } }
        System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get { throw null; } }
        System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IDictionary.IsFixedSize { get { throw null; } }
        bool System.Collections.IDictionary.IsReadOnly { get { throw null; } }
        object System.Collections.IDictionary.this[object key] { get { throw null; } set { } }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get { throw null; } }
        System.Collections.ICollection System.Collections.IDictionary.Values { get { throw null; } }
        public System.Collections.Generic.IList<TValue> Values { get { throw null; } }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool ContainsKey(TKey key) { throw null; }
        public bool ContainsValue(TValue value) { throw null; }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { throw null; }
        public int IndexOfKey(TKey key) { throw null; }
        public int IndexOfValue(TValue value) { throw null; }
        public bool Remove(TKey key) { throw null; }
        public void RemoveAt(int index) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        void System.Collections.IDictionary.Add(object key, object value) { }
        bool System.Collections.IDictionary.Contains(object key) { throw null; }
        System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { throw null; }
        void System.Collections.IDictionary.Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public void TrimExcess() { }
        public bool TryGetValue(TKey key, out TValue value) { throw null; }
    }
    public partial class SortedSet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.ISet<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        public SortedSet() { }
        public SortedSet(System.Collections.Generic.IComparer<T> comparer) { }
        public SortedSet(System.Collections.Generic.IEnumerable<T> collection) { }
        public SortedSet(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IComparer<T> comparer) { }
        protected SortedSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Collections.Generic.IComparer<T> Comparer { get { throw null; } }
        public int Count { get { throw null; } }
        public T Max { get { throw null; } }
        public T Min { get { throw null; } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public bool Add(T item) { throw null; }
        public virtual void Clear() { }
        public virtual bool Contains(T item) { throw null; }
        public void CopyTo(T[] array) { }
        public void CopyTo(T[] array, int index) { }
        public void CopyTo(T[] array, int index, int count) { }
        public static System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>> CreateSetComparer() { throw null; }
        public static System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>> CreateSetComparer(System.Collections.Generic.IEqualityComparer<T> memberEqualityComparer) { throw null; }
        public void ExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
        public System.Collections.Generic.SortedSet<T>.Enumerator GetEnumerator() { throw null; }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual System.Collections.Generic.SortedSet<T> GetViewBetween(T lowerValue, T upperValue) { throw null; }
        public virtual void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }
        public bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other) { throw null; }
        public bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other) { throw null; }
        public bool IsSubsetOf(System.Collections.Generic.IEnumerable<T> other) { throw null; }
        public bool IsSupersetOf(System.Collections.Generic.IEnumerable<T> other) { throw null; }
        protected virtual void OnDeserialization(object sender) { }
        public bool Overlaps(System.Collections.Generic.IEnumerable<T> other) { throw null; }
        public bool Remove(T item) { throw null; }
        public int RemoveWhere(System.Predicate<T> match) { throw null; }
        public System.Collections.Generic.IEnumerable<T> Reverse() { throw null; }
        public bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { throw null; }
        public void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public bool TryGetValue(T equalValue, out T actualValue) { throw null; }
        public void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
        {
            private object _dummy;
            private int _dummyPrimitive;
            public T Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
            void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
            void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        }
    }
}
namespace System.Collections.ObjectModel
{
    public partial class ObservableCollection<T> : System.Collections.ObjectModel.Collection<T>, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
    {
        public ObservableCollection() { }
        public ObservableCollection(System.Collections.Generic.IEnumerable<T> collection) { }
        public ObservableCollection(System.Collections.Generic.List<T> list) { }
        public virtual event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { add { } remove { } }
        protected virtual event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
        event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged { add { } remove { } }
        protected System.IDisposable BlockReentrancy() { throw null; }
        protected void CheckReentrancy() { }
        protected override void ClearItems() { }
        protected override void InsertItem(int index, T item) { }
        public void Move(int oldIndex, int newIndex) { }
        protected virtual void MoveItem(int oldIndex, int newIndex) { }
        protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, T item) { }
    }
    public partial class ReadOnlyObservableCollection<T> : System.Collections.ObjectModel.ReadOnlyCollection<T>, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
    {
        public ReadOnlyObservableCollection(System.Collections.ObjectModel.ObservableCollection<T> list) : base (default(System.Collections.Generic.IList<T>)) { }
        protected virtual event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { add { } remove { } }
        protected virtual event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
        event System.Collections.Specialized.NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged { add { } remove { } }
        event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged { add { } remove { } }
        protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs args) { }
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args) { }
    }
}
namespace System.Collections.Specialized
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct BitVector32
    {
        private int _dummyPrimitive;
        public BitVector32(System.Collections.Specialized.BitVector32 value) { throw null; }
        public BitVector32(int data) { throw null; }
        public int Data { get { throw null; } }
        public int this[System.Collections.Specialized.BitVector32.Section section] { get { throw null; } set { } }
        public bool this[int bit] { get { throw null; } set { } }
        public static int CreateMask() { throw null; }
        public static int CreateMask(int previous) { throw null; }
        public static System.Collections.Specialized.BitVector32.Section CreateSection(short maxValue) { throw null; }
        public static System.Collections.Specialized.BitVector32.Section CreateSection(short maxValue, System.Collections.Specialized.BitVector32.Section previous) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
        public static string ToString(System.Collections.Specialized.BitVector32 value) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly partial struct Section
        {
            private readonly int _dummyPrimitive;
            public short Mask { get { throw null; } }
            public short Offset { get { throw null; } }
            public bool Equals(System.Collections.Specialized.BitVector32.Section obj) { throw null; }
            public override bool Equals(object o) { throw null; }
            public override int GetHashCode() { throw null; }
            public static bool operator ==(System.Collections.Specialized.BitVector32.Section a, System.Collections.Specialized.BitVector32.Section b) { throw null; }
            public static bool operator !=(System.Collections.Specialized.BitVector32.Section a, System.Collections.Specialized.BitVector32.Section b) { throw null; }
            public override string ToString() { throw null; }
            public static string ToString(System.Collections.Specialized.BitVector32.Section value) { throw null; }
        }
    }
    public partial class CollectionsUtil
    {
        public CollectionsUtil() { }
        public static System.Collections.Hashtable CreateCaseInsensitiveHashtable() { throw null; }
        public static System.Collections.Hashtable CreateCaseInsensitiveHashtable(System.Collections.IDictionary d) { throw null; }
        public static System.Collections.Hashtable CreateCaseInsensitiveHashtable(int capacity) { throw null; }
        public static System.Collections.SortedList CreateCaseInsensitiveSortedList() { throw null; }
    }
    public partial class HybridDictionary : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        public HybridDictionary() { }
        public HybridDictionary(bool caseInsensitive) { }
        public HybridDictionary(int initialSize) { }
        public HybridDictionary(int initialSize, bool caseInsensitive) { }
        public int Count { get { throw null; } }
        public bool IsFixedSize { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public object this[object key] { get { throw null; } set { } }
        public System.Collections.ICollection Keys { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public System.Collections.ICollection Values { get { throw null; } }
        public void Add(object key, object value) { }
        public void Clear() { }
        public bool Contains(object key) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IDictionaryEnumerator GetEnumerator() { throw null; }
        public void Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial interface INotifyCollectionChanged
    {
        event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
    }
    public partial interface IOrderedDictionary : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        object this[int index] { get; set; }
        new System.Collections.IDictionaryEnumerator GetEnumerator();
        void Insert(int index, object key, object value);
        void RemoveAt(int index);
    }
    public partial class ListDictionary : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        public ListDictionary() { }
        public ListDictionary(System.Collections.IComparer comparer) { }
        public int Count { get { throw null; } }
        public bool IsFixedSize { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public object this[object key] { get { throw null; } set { } }
        public System.Collections.ICollection Keys { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public System.Collections.ICollection Values { get { throw null; } }
        public void Add(object key, object value) { }
        public void Clear() { }
        public bool Contains(object key) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IDictionaryEnumerator GetEnumerator() { throw null; }
        public void Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public partial class DictionaryNode
        {
            public object key;
            public System.Collections.Specialized.ListDictionary.DictionaryNode next;
            public object value;
            public DictionaryNode() { }
        }
    }
    public abstract partial class NameObjectCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        protected NameObjectCollectionBase() { }
        protected NameObjectCollectionBase(System.Collections.IEqualityComparer equalityComparer) { }
        [System.ObsoleteAttribute("Please use NameObjectCollectionBase(IEqualityComparer) instead.")]
        protected NameObjectCollectionBase(System.Collections.IHashCodeProvider hashProvider, System.Collections.IComparer comparer) { }
        protected NameObjectCollectionBase(int capacity) { }
        protected NameObjectCollectionBase(int capacity, System.Collections.IEqualityComparer equalityComparer) { }
        [System.ObsoleteAttribute("Please use NameObjectCollectionBase(Int32, IEqualityComparer) instead.")]
        protected NameObjectCollectionBase(int capacity, System.Collections.IHashCodeProvider hashProvider, System.Collections.IComparer comparer) { }
        protected NameObjectCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual int Count { get { throw null; } }
        protected bool IsReadOnly { get { throw null; } set { } }
        public virtual System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        protected void BaseAdd(string name, object value) { }
        protected void BaseClear() { }
        protected object BaseGet(int index) { throw null; }
        protected object BaseGet(string name) { throw null; }
        protected string[] BaseGetAllKeys() { throw null; }
        protected object[] BaseGetAllValues() { throw null; }
        protected object[] BaseGetAllValues(System.Type type) { throw null; }
        protected string BaseGetKey(int index) { throw null; }
        protected bool BaseHasKeys() { throw null; }
        protected void BaseRemove(string name) { }
        protected void BaseRemoveAt(int index) { }
        protected void BaseSet(int index, object value) { }
        protected void BaseSet(string name, object value) { }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual void OnDeserialization(object sender) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        public partial class KeysCollection : System.Collections.ICollection, System.Collections.IEnumerable
        {
            internal KeysCollection() { }
            public int Count { get { throw null; } }
            public string this[int index] { get { throw null; } }
            bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
            object System.Collections.ICollection.SyncRoot { get { throw null; } }
            public virtual string Get(int index) { throw null; }
            public System.Collections.IEnumerator GetEnumerator() { throw null; }
            void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        }
    }
    public partial class NameValueCollection : System.Collections.Specialized.NameObjectCollectionBase
    {
        public NameValueCollection() { }
        public NameValueCollection(System.Collections.IEqualityComparer equalityComparer) { }
        [System.ObsoleteAttribute("Please use NameValueCollection(IEqualityComparer) instead.")]
        public NameValueCollection(System.Collections.IHashCodeProvider hashProvider, System.Collections.IComparer comparer) { }
        public NameValueCollection(System.Collections.Specialized.NameValueCollection col) { }
        public NameValueCollection(int capacity) { }
        public NameValueCollection(int capacity, System.Collections.IEqualityComparer equalityComparer) { }
        [System.ObsoleteAttribute("Please use NameValueCollection(Int32, IEqualityComparer) instead.")]
        public NameValueCollection(int capacity, System.Collections.IHashCodeProvider hashProvider, System.Collections.IComparer comparer) { }
        public NameValueCollection(int capacity, System.Collections.Specialized.NameValueCollection col) { }
        protected NameValueCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual string[] AllKeys { get { throw null; } }
        public string this[int index] { get { throw null; } }
        public string this[string name] { get { throw null; } set { } }
        public void Add(System.Collections.Specialized.NameValueCollection c) { }
        public virtual void Add(string name, string value) { }
        public virtual void Clear() { }
        public void CopyTo(System.Array dest, int index) { }
        public virtual string Get(int index) { throw null; }
        public virtual string Get(string name) { throw null; }
        public virtual string GetKey(int index) { throw null; }
        public virtual string[] GetValues(int index) { throw null; }
        public virtual string[] GetValues(string name) { throw null; }
        public bool HasKeys() { throw null; }
        protected void InvalidateCachedArrays() { }
        public virtual void Remove(string name) { }
        public virtual void Set(string name, string value) { }
    }
    public enum NotifyCollectionChangedAction
    {
        Add = 0,
        Remove = 1,
        Replace = 2,
        Move = 3,
        Reset = 4,
    }
    public partial class NotifyCollectionChangedEventArgs : System.EventArgs
    {
        public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action) { }
        public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems) { }
        public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems) { }
        public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex) { }
        public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems, int startingIndex) { }
        public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems, int index, int oldIndex) { }
        public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object changedItem) { }
        public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object changedItem, int index) { }
        public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex) { }
        public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object newItem, object oldItem) { }
        public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }
        public System.Collections.Specialized.NotifyCollectionChangedAction Action { get { throw null; } }
        public System.Collections.IList NewItems { get { throw null; } }
        public int NewStartingIndex { get { throw null; } }
        public System.Collections.IList OldItems { get { throw null; } }
        public int OldStartingIndex { get { throw null; } }
    }
    public delegate void NotifyCollectionChangedEventHandler(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
    public partial class OrderedDictionary : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.Collections.Specialized.IOrderedDictionary, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        public OrderedDictionary() { }
        public OrderedDictionary(System.Collections.IEqualityComparer comparer) { }
        public OrderedDictionary(int capacity) { }
        public OrderedDictionary(int capacity, System.Collections.IEqualityComparer comparer) { }
        protected OrderedDictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public object this[int index] { get { throw null; } set { } }
        public object this[object key] { get { throw null; } set { } }
        public System.Collections.ICollection Keys { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IDictionary.IsFixedSize { get { throw null; } }
        public System.Collections.ICollection Values { get { throw null; } }
        public void Add(object key, object value) { }
        public System.Collections.Specialized.OrderedDictionary AsReadOnly() { throw null; }
        public void Clear() { }
        public bool Contains(object key) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public void Insert(int index, object key, object value) { }
        protected virtual void OnDeserialization(object sender) { }
        public void Remove(object key) { }
        public void RemoveAt(int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
    }
    public partial class StringCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public StringCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public string this[int index] { get { throw null; } set { } }
        public object SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public int Add(string value) { throw null; }
        public void AddRange(string[] value) { }
        public void Clear() { }
        public bool Contains(string value) { throw null; }
        public void CopyTo(string[] array, int index) { }
        public System.Collections.Specialized.StringEnumerator GetEnumerator() { throw null; }
        public int IndexOf(string value) { throw null; }
        public void Insert(int index, string value) { }
        public void Remove(string value) { }
        public void RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
    }
    public partial class StringDictionary : System.Collections.IEnumerable
    {
        public StringDictionary() { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual string this[string key] { get { throw null; } set { } }
        public virtual System.Collections.ICollection Keys { get { throw null; } }
        public virtual object SyncRoot { get { throw null; } }
        public virtual System.Collections.ICollection Values { get { throw null; } }
        public virtual void Add(string key, string value) { }
        public virtual void Clear() { }
        public virtual bool ContainsKey(string key) { throw null; }
        public virtual bool ContainsValue(string value) { throw null; }
        public virtual void CopyTo(System.Array array, int index) { }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual void Remove(string key) { }
    }
    public partial class StringEnumerator
    {
        internal StringEnumerator() { }
        public string Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
}
namespace System.ComponentModel
{
    public partial class AddingNewEventArgs : System.EventArgs
    {
        public AddingNewEventArgs() { }
        public AddingNewEventArgs(object newObject) { }
        public object NewObject { get { throw null; } set { } }
    }
    public delegate void AddingNewEventHandler(object sender, System.ComponentModel.AddingNewEventArgs e);
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class AmbientValueAttribute : System.Attribute
    {
        public AmbientValueAttribute(bool value) { }
        public AmbientValueAttribute(byte value) { }
        public AmbientValueAttribute(char value) { }
        public AmbientValueAttribute(double value) { }
        public AmbientValueAttribute(short value) { }
        public AmbientValueAttribute(int value) { }
        public AmbientValueAttribute(long value) { }
        public AmbientValueAttribute(object value) { }
        public AmbientValueAttribute(float value) { }
        public AmbientValueAttribute(string value) { }
        public AmbientValueAttribute(System.Type type, string value) { }
        public object Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class ArrayConverter : System.ComponentModel.CollectionConverter
    {
        public ArrayConverter() { }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
        public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { throw null; }
        public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class AsyncCompletedEventArgs : System.EventArgs
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public AsyncCompletedEventArgs() { }
        public AsyncCompletedEventArgs(System.Exception error, bool cancelled, object userState) { }
        public bool Cancelled { get { throw null; } }
        public System.Exception Error { get { throw null; } }
        public object UserState { get { throw null; } }
        protected void RaiseExceptionIfNecessary() { }
    }
    public delegate void AsyncCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    public sealed partial class AsyncOperation
    {
        internal AsyncOperation() { }
        public System.Threading.SynchronizationContext SynchronizationContext { get { throw null; } }
        public object UserSuppliedState { get { throw null; } }
        ~AsyncOperation() { }
        public void OperationCompleted() { }
        public void Post(System.Threading.SendOrPostCallback d, object arg) { }
        public void PostOperationCompleted(System.Threading.SendOrPostCallback d, object arg) { }
    }
    public static partial class AsyncOperationManager
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Threading.SynchronizationContext SynchronizationContext { get { throw null; } set { } }
        public static System.ComponentModel.AsyncOperation CreateOperation(object userSuppliedState) { throw null; }
    }
    public partial class AttributeCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public static readonly System.ComponentModel.AttributeCollection Empty;
        protected AttributeCollection() { }
        public AttributeCollection(params System.Attribute[] attributes) { }
        protected virtual System.Attribute[] Attributes { get { throw null; } }
        public int Count { get { throw null; } }
        public virtual System.Attribute this[int index] { get { throw null; } }
        public virtual System.Attribute this[System.Type attributeType] { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public bool Contains(System.Attribute attribute) { throw null; }
        public bool Contains(System.Attribute[] attributes) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public static System.ComponentModel.AttributeCollection FromExisting(System.ComponentModel.AttributeCollection existing, params System.Attribute[] newAttributes) { throw null; }
        protected System.Attribute GetDefaultAttribute(System.Type attributeType) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public bool Matches(System.Attribute attribute) { throw null; }
        public bool Matches(System.Attribute[] attributes) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property)]
    public partial class AttributeProviderAttribute : System.Attribute
    {
        public AttributeProviderAttribute(string typeName) { }
        public AttributeProviderAttribute(string typeName, string propertyName) { }
        public AttributeProviderAttribute(System.Type type) { }
        public string PropertyName { get { throw null; } }
        public string TypeName { get { throw null; } }
    }
    [System.ComponentModel.DefaultEventAttribute("DoWork")]
    public partial class BackgroundWorker : System.ComponentModel.Component
    {
        public BackgroundWorker() { }
        public bool CancellationPending { get { throw null; } }
        public bool IsBusy { get { throw null; } }
        public bool WorkerReportsProgress { get { throw null; } set { } }
        public bool WorkerSupportsCancellation { get { throw null; } set { } }
        public event System.ComponentModel.DoWorkEventHandler DoWork { add { } remove { } }
        public event System.ComponentModel.ProgressChangedEventHandler ProgressChanged { add { } remove { } }
        public event System.ComponentModel.RunWorkerCompletedEventHandler RunWorkerCompleted { add { } remove { } }
        public void CancelAsync() { }
        protected override void Dispose(bool disposing) { }
        protected virtual void OnDoWork(System.ComponentModel.DoWorkEventArgs e) { }
        protected virtual void OnProgressChanged(System.ComponentModel.ProgressChangedEventArgs e) { }
        protected virtual void OnRunWorkerCompleted(System.ComponentModel.RunWorkerCompletedEventArgs e) { }
        public void ReportProgress(int percentProgress) { }
        public void ReportProgress(int percentProgress, object userState) { }
        public void RunWorkerAsync() { }
        public void RunWorkerAsync(object argument) { }
    }
    public abstract partial class BaseNumberConverter : System.ComponentModel.TypeConverter
    {
        internal BaseNumberConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class BindableAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.BindableAttribute Default;
        public static readonly System.ComponentModel.BindableAttribute No;
        public static readonly System.ComponentModel.BindableAttribute Yes;
        public BindableAttribute(bool bindable) { }
        public BindableAttribute(bool bindable, System.ComponentModel.BindingDirection direction) { }
        public BindableAttribute(System.ComponentModel.BindableSupport flags) { }
        public BindableAttribute(System.ComponentModel.BindableSupport flags, System.ComponentModel.BindingDirection direction) { }
        public bool Bindable { get { throw null; } }
        public System.ComponentModel.BindingDirection Direction { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public enum BindableSupport
    {
        No = 0,
        Yes = 1,
        Default = 2,
    }
    public enum BindingDirection
    {
        OneWay = 0,
        TwoWay = 1,
    }
    public partial class BindingList<T> : System.Collections.ObjectModel.Collection<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList, System.ComponentModel.ICancelAddNew, System.ComponentModel.IRaiseItemChangedEvents
    {
        public BindingList() { }
        public BindingList(System.Collections.Generic.IList<T> list) { }
        public bool AllowEdit { get { throw null; } set { } }
        public bool AllowNew { get { throw null; } set { } }
        public bool AllowRemove { get { throw null; } set { } }
        protected virtual bool IsSortedCore { get { throw null; } }
        public bool RaiseListChangedEvents { get { throw null; } set { } }
        protected virtual System.ComponentModel.ListSortDirection SortDirectionCore { get { throw null; } }
        protected virtual System.ComponentModel.PropertyDescriptor SortPropertyCore { get { throw null; } }
        protected virtual bool SupportsChangeNotificationCore { get { throw null; } }
        protected virtual bool SupportsSearchingCore { get { throw null; } }
        protected virtual bool SupportsSortingCore { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowEdit { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowNew { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowRemove { get { throw null; } }
        bool System.ComponentModel.IBindingList.IsSorted { get { throw null; } }
        System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection { get { throw null; } }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsChangeNotification { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSearching { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSorting { get { throw null; } }
        bool System.ComponentModel.IRaiseItemChangedEvents.RaisesItemChangedEvents { get { throw null; } }
        public event System.ComponentModel.AddingNewEventHandler AddingNew { add { } remove { } }
        public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
        public T AddNew() { throw null; }
        protected virtual object AddNewCore() { throw null; }
        protected virtual void ApplySortCore(System.ComponentModel.PropertyDescriptor prop, System.ComponentModel.ListSortDirection direction) { }
        public virtual void CancelNew(int itemIndex) { }
        protected override void ClearItems() { }
        public virtual void EndNew(int itemIndex) { }
        protected virtual int FindCore(System.ComponentModel.PropertyDescriptor prop, object key) { throw null; }
        protected override void InsertItem(int index, T item) { }
        protected virtual void OnAddingNew(System.ComponentModel.AddingNewEventArgs e) { }
        protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
        protected override void RemoveItem(int index) { }
        protected virtual void RemoveSortCore() { }
        public void ResetBindings() { }
        public void ResetItem(int position) { }
        protected override void SetItem(int index, T item) { }
        void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor prop) { }
        object System.ComponentModel.IBindingList.AddNew() { throw null; }
        void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor prop, System.ComponentModel.ListSortDirection direction) { }
        int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor prop, object key) { throw null; }
        void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor prop) { }
        void System.ComponentModel.IBindingList.RemoveSort() { }
    }
    public partial class BooleanConverter : System.ComponentModel.TypeConverter
    {
        public BooleanConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class BrowsableAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.BrowsableAttribute Default;
        public static readonly System.ComponentModel.BrowsableAttribute No;
        public static readonly System.ComponentModel.BrowsableAttribute Yes;
        public BrowsableAttribute(bool browsable) { }
        public bool Browsable { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public partial class ByteConverter : System.ComponentModel.BaseNumberConverter
    {
        public ByteConverter() { }
    }
    public partial class CancelEventArgs : System.EventArgs
    {
        public CancelEventArgs() { }
        public CancelEventArgs(bool cancel) { }
        public bool Cancel { get { throw null; } set { } }
    }
    public delegate void CancelEventHandler(object sender, System.ComponentModel.CancelEventArgs e);
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public partial class CategoryAttribute : System.Attribute
    {
        public CategoryAttribute() { }
        public CategoryAttribute(string category) { }
        public static System.ComponentModel.CategoryAttribute Action { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute Appearance { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute Asynchronous { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute Behavior { get { throw null; } }
        public string Category { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute Data { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute Default { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute Design { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute DragDrop { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute Focus { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute Format { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute Key { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute Layout { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute Mouse { get { throw null; } }
        public static System.ComponentModel.CategoryAttribute WindowStyle { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        protected virtual string GetLocalizedString(string value) { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public partial class CharConverter : System.ComponentModel.TypeConverter
    {
        public CharConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    public enum CollectionChangeAction
    {
        Add = 1,
        Remove = 2,
        Refresh = 3,
    }
    public partial class CollectionChangeEventArgs : System.EventArgs
    {
        public CollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction action, object element) { }
        public virtual System.ComponentModel.CollectionChangeAction Action { get { throw null; } }
        public virtual object Element { get { throw null; } }
    }
    public delegate void CollectionChangeEventHandler(object sender, System.ComponentModel.CollectionChangeEventArgs e);
    public partial class CollectionConverter : System.ComponentModel.TypeConverter
    {
        public CollectionConverter() { }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
        public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { throw null; }
        public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class ComplexBindingPropertiesAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.ComplexBindingPropertiesAttribute Default;
        public ComplexBindingPropertiesAttribute() { }
        public ComplexBindingPropertiesAttribute(string dataSource) { }
        public ComplexBindingPropertiesAttribute(string dataSource, string dataMember) { }
        public string DataMember { get { throw null; } }
        public string DataSource { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("Component")]
    public partial class Component : System.MarshalByRefObject, System.ComponentModel.IComponent, System.IDisposable
    {
        public Component() { }
        protected virtual bool CanRaiseEvents { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.ComponentModel.IContainer Container { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        protected bool DesignMode { get { throw null; } }
        protected System.ComponentModel.EventHandlerList Events { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual System.ComponentModel.ISite Site { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public event System.EventHandler Disposed { add { } remove { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~Component() { }
        protected virtual object GetService(System.Type service) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ComponentCollection : System.Collections.ReadOnlyCollectionBase
    {
        public ComponentCollection(System.ComponentModel.IComponent[] components) { }
        public virtual System.ComponentModel.IComponent this[int index] { get { throw null; } }
        public virtual System.ComponentModel.IComponent this[string name] { get { throw null; } }
        public void CopyTo(System.ComponentModel.IComponent[] array, int index) { }
    }
    public partial class ComponentConverter : System.ComponentModel.ReferenceConverter
    {
        public ComponentConverter(System.Type type) : base (default(System.Type)) { }
        public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { throw null; }
        public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public abstract partial class ComponentEditor
    {
        protected ComponentEditor() { }
        public abstract bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object component);
        public bool EditComponent(object component) { throw null; }
    }
    public partial class ComponentResourceManager : System.Resources.ResourceManager
    {
        public ComponentResourceManager() { }
        public ComponentResourceManager(System.Type t) { }
        public void ApplyResources(object value, string objectName) { }
        public virtual void ApplyResources(object value, string objectName, System.Globalization.CultureInfo culture) { }
    }
    public partial class Container : System.ComponentModel.IContainer, System.IDisposable
    {
        public Container() { }
        public virtual System.ComponentModel.ComponentCollection Components { get { throw null; } }
        public virtual void Add(System.ComponentModel.IComponent component) { }
        public virtual void Add(System.ComponentModel.IComponent component, string name) { }
        protected virtual System.ComponentModel.ISite CreateSite(System.ComponentModel.IComponent component, string name) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~Container() { }
        protected virtual object GetService(System.Type service) { throw null; }
        public virtual void Remove(System.ComponentModel.IComponent component) { }
        protected void RemoveWithoutUnsiting(System.ComponentModel.IComponent component) { }
        protected virtual void ValidateName(System.ComponentModel.IComponent component, string name) { }
    }
    public abstract partial class ContainerFilterService
    {
        protected ContainerFilterService() { }
        public virtual System.ComponentModel.ComponentCollection FilterComponents(System.ComponentModel.ComponentCollection components) { throw null; }
    }
    public partial class CultureInfoConverter : System.ComponentModel.TypeConverter
    {
        public CultureInfoConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
        protected virtual string GetCultureName(System.Globalization.CultureInfo culture) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public abstract partial class CustomTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor
    {
        protected CustomTypeDescriptor() { }
        protected CustomTypeDescriptor(System.ComponentModel.ICustomTypeDescriptor parent) { }
        public virtual System.ComponentModel.AttributeCollection GetAttributes() { throw null; }
        public virtual string GetClassName() { throw null; }
        public virtual string GetComponentName() { throw null; }
        public virtual System.ComponentModel.TypeConverter GetConverter() { throw null; }
        public virtual System.ComponentModel.EventDescriptor GetDefaultEvent() { throw null; }
        public virtual System.ComponentModel.PropertyDescriptor GetDefaultProperty() { throw null; }
        public virtual object GetEditor(System.Type editorBaseType) { throw null; }
        public virtual System.ComponentModel.EventDescriptorCollection GetEvents() { throw null; }
        public virtual System.ComponentModel.EventDescriptorCollection GetEvents(System.Attribute[] attributes) { throw null; }
        public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties() { throw null; }
        public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes) { throw null; }
        public virtual object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { throw null; }
    }
    public partial class DataErrorsChangedEventArgs : System.EventArgs
    {
        public DataErrorsChangedEventArgs(string propertyName) { }
        public virtual string PropertyName { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class DataObjectAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.DataObjectAttribute DataObject;
        public static readonly System.ComponentModel.DataObjectAttribute Default;
        public static readonly System.ComponentModel.DataObjectAttribute NonDataObject;
        public DataObjectAttribute() { }
        public DataObjectAttribute(bool isDataObject) { }
        public bool IsDataObject { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property)]
    public sealed partial class DataObjectFieldAttribute : System.Attribute
    {
        public DataObjectFieldAttribute(bool primaryKey) { }
        public DataObjectFieldAttribute(bool primaryKey, bool isIdentity) { }
        public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable) { }
        public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length) { }
        public bool IsIdentity { get { throw null; } }
        public bool IsNullable { get { throw null; } }
        public int Length { get { throw null; } }
        public bool PrimaryKey { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method)]
    public sealed partial class DataObjectMethodAttribute : System.Attribute
    {
        public DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType methodType) { }
        public DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType methodType, bool isDefault) { }
        public bool IsDefault { get { throw null; } }
        public System.ComponentModel.DataObjectMethodType MethodType { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool Match(object obj) { throw null; }
    }
    public enum DataObjectMethodType
    {
        Fill = 0,
        Select = 1,
        Update = 2,
        Insert = 3,
        Delete = 4,
    }
    public partial class DateTimeConverter : System.ComponentModel.TypeConverter
    {
        public DateTimeConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    public partial class DateTimeOffsetConverter : System.ComponentModel.TypeConverter
    {
        public DateTimeOffsetConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    public partial class DecimalConverter : System.ComponentModel.BaseNumberConverter
    {
        public DecimalConverter() { }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class DefaultBindingPropertyAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.DefaultBindingPropertyAttribute Default;
        public DefaultBindingPropertyAttribute() { }
        public DefaultBindingPropertyAttribute(string name) { }
        public string Name { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class DefaultEventAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.DefaultEventAttribute Default;
        public DefaultEventAttribute(string name) { }
        public string Name { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class DefaultPropertyAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.DefaultPropertyAttribute Default;
        public DefaultPropertyAttribute(string name) { }
        public string Name { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public partial class DefaultValueAttribute : System.Attribute
    {
        public DefaultValueAttribute(bool value) { }
        public DefaultValueAttribute(byte value) { }
        public DefaultValueAttribute(char value) { }
        public DefaultValueAttribute(double value) { }
        public DefaultValueAttribute(short value) { }
        public DefaultValueAttribute(int value) { }
        public DefaultValueAttribute(long value) { }
        public DefaultValueAttribute(object value) { }
        [System.CLSCompliantAttribute(false)]
        public DefaultValueAttribute(sbyte value) { }
        public DefaultValueAttribute(float value) { }
        public DefaultValueAttribute(string value) { }
        public DefaultValueAttribute(System.Type type, string value) { }
        [System.CLSCompliantAttribute(false)]
        public DefaultValueAttribute(ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public DefaultValueAttribute(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public DefaultValueAttribute(ulong value) { }
        public virtual object Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        protected void SetValue(object value) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public partial class DescriptionAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.DescriptionAttribute Default;
        public DescriptionAttribute() { }
        public DescriptionAttribute(string description) { }
        public virtual string Description { get { throw null; } }
        protected string DescriptionValue { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface, AllowMultiple=true, Inherited=true)]
    [System.Diagnostics.ConditionalAttribute("FALSE")]
    public sealed partial class DesignerAttribute : System.Attribute
    {
        public DesignerAttribute(string designerTypeName) { }
        public DesignerAttribute(string designerTypeName, string designerBaseTypeName) { }
        public DesignerAttribute(string designerTypeName, System.Type designerBaseType) { }
        public DesignerAttribute(System.Type designerType) { }
        public DesignerAttribute(System.Type designerType, System.Type designerBaseType) { }
        public string DesignerBaseTypeName { get { throw null; } }
        public string DesignerTypeName { get { throw null; } }
        public override object TypeId { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public sealed partial class DesignerCategoryAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.DesignerCategoryAttribute Component;
        public static readonly System.ComponentModel.DesignerCategoryAttribute Default;
        public static readonly System.ComponentModel.DesignerCategoryAttribute Form;
        public static readonly System.ComponentModel.DesignerCategoryAttribute Generic;
        public DesignerCategoryAttribute() { }
        public DesignerCategoryAttribute(string category) { }
        public string Category { get { throw null; } }
        public override object TypeId { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public enum DesignerSerializationVisibility
    {
        Hidden = 0,
        Visible = 1,
        Content = 2,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Event | System.AttributeTargets.Field | System.AttributeTargets.Method | System.AttributeTargets.Property)]
    public sealed partial class DesignerSerializationVisibilityAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Content;
        public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Default;
        public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Hidden;
        public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Visible;
        public DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility visibility) { }
        public System.ComponentModel.DesignerSerializationVisibility Visibility { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class DesignOnlyAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.DesignOnlyAttribute Default;
        public static readonly System.ComponentModel.DesignOnlyAttribute No;
        public static readonly System.ComponentModel.DesignOnlyAttribute Yes;
        public DesignOnlyAttribute(bool isDesignOnly) { }
        public bool IsDesignOnly { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface)]
    public sealed partial class DesignTimeVisibleAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.DesignTimeVisibleAttribute Default;
        public static readonly System.ComponentModel.DesignTimeVisibleAttribute No;
        public static readonly System.ComponentModel.DesignTimeVisibleAttribute Yes;
        public DesignTimeVisibleAttribute() { }
        public DesignTimeVisibleAttribute(bool visible) { }
        public bool Visible { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Event | System.AttributeTargets.Method | System.AttributeTargets.Property)]
    public partial class DisplayNameAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.DisplayNameAttribute Default;
        public DisplayNameAttribute() { }
        public DisplayNameAttribute(string displayName) { }
        public virtual string DisplayName { get { throw null; } }
        protected string DisplayNameValue { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public partial class DoubleConverter : System.ComponentModel.BaseNumberConverter
    {
        public DoubleConverter() { }
    }
    public partial class DoWorkEventArgs : System.ComponentModel.CancelEventArgs
    {
        public DoWorkEventArgs(object argument) { }
        public object Argument { get { throw null; } }
        public object Result { get { throw null; } set { } }
    }
    public delegate void DoWorkEventHandler(object sender, System.ComponentModel.DoWorkEventArgs e);
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true, Inherited=true)]
    public sealed partial class EditorAttribute : System.Attribute
    {
        public EditorAttribute() { }
        public EditorAttribute(string typeName, string baseTypeName) { }
        public EditorAttribute(string typeName, System.Type baseType) { }
        public EditorAttribute(System.Type type, System.Type baseType) { }
        public string EditorBaseTypeName { get { throw null; } }
        public string EditorTypeName { get { throw null; } }
        public override object TypeId { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Event | System.AttributeTargets.Field | System.AttributeTargets.Interface | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Struct)]
    public sealed partial class EditorBrowsableAttribute : System.Attribute
    {
        public EditorBrowsableAttribute() { }
        public EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState state) { }
        public System.ComponentModel.EditorBrowsableState State { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public enum EditorBrowsableState
    {
        Always = 0,
        Never = 1,
        Advanced = 2,
    }
    public partial class EnumConverter : System.ComponentModel.TypeConverter
    {
        public EnumConverter(System.Type type) { }
        protected virtual System.Collections.IComparer Comparer { get { throw null; } }
        protected System.Type EnumType { get { throw null; } }
        protected System.ComponentModel.TypeConverter.StandardValuesCollection Values { get { throw null; } set { } }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) { throw null; }
    }
    public abstract partial class EventDescriptor : System.ComponentModel.MemberDescriptor
    {
        protected EventDescriptor(System.ComponentModel.MemberDescriptor descr) : base (default(string)) { }
        protected EventDescriptor(System.ComponentModel.MemberDescriptor descr, System.Attribute[] attrs) : base (default(string)) { }
        protected EventDescriptor(string name, System.Attribute[] attrs) : base (default(string)) { }
        public abstract System.Type ComponentType { get; }
        public abstract System.Type EventType { get; }
        public abstract bool IsMulticast { get; }
        public abstract void AddEventHandler(object component, System.Delegate value);
        public abstract void RemoveEventHandler(object component, System.Delegate value);
    }
    public partial class EventDescriptorCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public static readonly System.ComponentModel.EventDescriptorCollection Empty;
        public EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events) { }
        public EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events, bool readOnly) { }
        public int Count { get { throw null; } }
        public virtual System.ComponentModel.EventDescriptor this[int index] { get { throw null; } }
        public virtual System.ComponentModel.EventDescriptor this[string name] { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public int Add(System.ComponentModel.EventDescriptor value) { throw null; }
        public void Clear() { }
        public bool Contains(System.ComponentModel.EventDescriptor value) { throw null; }
        public virtual System.ComponentModel.EventDescriptor Find(string name, bool ignoreCase) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.ComponentModel.EventDescriptor value) { throw null; }
        public void Insert(int index, System.ComponentModel.EventDescriptor value) { }
        protected void InternalSort(System.Collections.IComparer sorter) { }
        protected void InternalSort(string[] names) { }
        public void Remove(System.ComponentModel.EventDescriptor value) { }
        public void RemoveAt(int index) { }
        public virtual System.ComponentModel.EventDescriptorCollection Sort() { throw null; }
        public virtual System.ComponentModel.EventDescriptorCollection Sort(System.Collections.IComparer comparer) { throw null; }
        public virtual System.ComponentModel.EventDescriptorCollection Sort(string[] names) { throw null; }
        public virtual System.ComponentModel.EventDescriptorCollection Sort(string[] names, System.Collections.IComparer comparer) { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
    public sealed partial class EventHandlerList : System.IDisposable
    {
        public EventHandlerList() { }
        public System.Delegate this[object key] { get { throw null; } set { } }
        public void AddHandler(object key, System.Delegate value) { }
        public void AddHandlers(System.ComponentModel.EventHandlerList listToAddFrom) { }
        public void Dispose() { }
        public void RemoveHandler(object key, System.Delegate value) { }
    }
    public partial class ExpandableObjectConverter : System.ComponentModel.TypeConverter
    {
        public ExpandableObjectConverter() { }
        public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { throw null; }
        public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class ExtenderProvidedPropertyAttribute : System.Attribute
    {
        public ExtenderProvidedPropertyAttribute() { }
        public System.ComponentModel.PropertyDescriptor ExtenderProperty { get { throw null; } }
        public System.ComponentModel.IExtenderProvider Provider { get { throw null; } }
        public System.Type ReceiverType { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public partial class GuidConverter : System.ComponentModel.TypeConverter
    {
        public GuidConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    public partial class HandledEventArgs : System.EventArgs
    {
        public HandledEventArgs() { }
        public HandledEventArgs(bool defaultHandledValue) { }
        public bool Handled { get { throw null; } set { } }
    }
    public delegate void HandledEventHandler(object sender, System.ComponentModel.HandledEventArgs e);
    public partial interface IBindingList : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        bool AllowEdit { get; }
        bool AllowNew { get; }
        bool AllowRemove { get; }
        bool IsSorted { get; }
        System.ComponentModel.ListSortDirection SortDirection { get; }
        System.ComponentModel.PropertyDescriptor SortProperty { get; }
        bool SupportsChangeNotification { get; }
        bool SupportsSearching { get; }
        bool SupportsSorting { get; }
        event System.ComponentModel.ListChangedEventHandler ListChanged;
        void AddIndex(System.ComponentModel.PropertyDescriptor property);
        object AddNew();
        void ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction);
        int Find(System.ComponentModel.PropertyDescriptor property, object key);
        void RemoveIndex(System.ComponentModel.PropertyDescriptor property);
        void RemoveSort();
    }
    public partial interface IBindingListView : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList
    {
        string Filter { get; set; }
        System.ComponentModel.ListSortDescriptionCollection SortDescriptions { get; }
        bool SupportsAdvancedSorting { get; }
        bool SupportsFiltering { get; }
        void ApplySort(System.ComponentModel.ListSortDescriptionCollection sorts);
        void RemoveFilter();
    }
    public partial interface ICancelAddNew
    {
        void CancelNew(int itemIndex);
        void EndNew(int itemIndex);
    }
    public partial interface IChangeTracking
    {
        bool IsChanged { get; }
        void AcceptChanges();
    }
    [System.ObsoleteAttribute("This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
    public partial interface IComNativeDescriptorHandler
    {
        System.ComponentModel.AttributeCollection GetAttributes(object component);
        string GetClassName(object component);
        System.ComponentModel.TypeConverter GetConverter(object component);
        System.ComponentModel.EventDescriptor GetDefaultEvent(object component);
        System.ComponentModel.PropertyDescriptor GetDefaultProperty(object component);
        object GetEditor(object component, System.Type baseEditorType);
        System.ComponentModel.EventDescriptorCollection GetEvents(object component);
        System.ComponentModel.EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes);
        string GetName(object component);
        System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes);
        object GetPropertyValue(object component, int dispid, ref bool success);
        object GetPropertyValue(object component, string propertyName, ref bool success);
    }
    public partial interface IComponent : System.IDisposable
    {
        System.ComponentModel.ISite Site { get; set; }
        event System.EventHandler Disposed;
    }
    public partial interface IContainer : System.IDisposable
    {
        System.ComponentModel.ComponentCollection Components { get; }
        void Add(System.ComponentModel.IComponent component);
        void Add(System.ComponentModel.IComponent component, string name);
        void Remove(System.ComponentModel.IComponent component);
    }
    public partial interface ICustomTypeDescriptor
    {
        System.ComponentModel.AttributeCollection GetAttributes();
        string GetClassName();
        string GetComponentName();
        System.ComponentModel.TypeConverter GetConverter();
        System.ComponentModel.EventDescriptor GetDefaultEvent();
        System.ComponentModel.PropertyDescriptor GetDefaultProperty();
        object GetEditor(System.Type editorBaseType);
        System.ComponentModel.EventDescriptorCollection GetEvents();
        System.ComponentModel.EventDescriptorCollection GetEvents(System.Attribute[] attributes);
        System.ComponentModel.PropertyDescriptorCollection GetProperties();
        System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
        object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
    }
    public partial interface IDataErrorInfo
    {
        string Error { get; }
        string this[string columnName] { get; }
    }
    public partial interface IEditableObject
    {
        void BeginEdit();
        void CancelEdit();
        void EndEdit();
    }
    public partial interface IExtenderProvider
    {
        bool CanExtend(object extendee);
    }
    public partial interface IIntellisenseBuilder
    {
        string Name { get; }
        bool Show(string language, string value, ref string newValue);
    }
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public partial interface IListSource
    {
        bool ContainsListCollection { get; }
        System.Collections.IList GetList();
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class ImmutableObjectAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.ImmutableObjectAttribute Default;
        public static readonly System.ComponentModel.ImmutableObjectAttribute No;
        public static readonly System.ComponentModel.ImmutableObjectAttribute Yes;
        public ImmutableObjectAttribute(bool immutable) { }
        public bool Immutable { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public partial interface INestedContainer : System.ComponentModel.IContainer, System.IDisposable
    {
        System.ComponentModel.IComponent Owner { get; }
    }
    public partial interface INestedSite : System.ComponentModel.ISite, System.IServiceProvider
    {
        string FullName { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Event | System.AttributeTargets.Field | System.AttributeTargets.Property)]
    public sealed partial class InheritanceAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.InheritanceAttribute Default;
        public static readonly System.ComponentModel.InheritanceAttribute Inherited;
        public static readonly System.ComponentModel.InheritanceAttribute InheritedReadOnly;
        public static readonly System.ComponentModel.InheritanceAttribute NotInherited;
        public InheritanceAttribute() { }
        public InheritanceAttribute(System.ComponentModel.InheritanceLevel inheritanceLevel) { }
        public System.ComponentModel.InheritanceLevel InheritanceLevel { get { throw null; } }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
        public override string ToString() { throw null; }
    }
    public enum InheritanceLevel
    {
        Inherited = 1,
        InheritedReadOnly = 2,
        NotInherited = 3,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class InitializationEventAttribute : System.Attribute
    {
        public InitializationEventAttribute(string eventName) { }
        public string EventName { get { throw null; } }
    }
    public partial interface INotifyDataErrorInfo
    {
        bool HasErrors { get; }
        event System.EventHandler<System.ComponentModel.DataErrorsChangedEventArgs> ErrorsChanged;
        System.Collections.IEnumerable GetErrors(string propertyName);
    }
    public partial interface INotifyPropertyChanged
    {
        event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    }
    public partial interface INotifyPropertyChanging
    {
        event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public partial class InstallerTypeAttribute : System.Attribute
    {
        public InstallerTypeAttribute(string typeName) { }
        public InstallerTypeAttribute(System.Type installerType) { }
        public virtual System.Type InstallerType { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public abstract partial class InstanceCreationEditor
    {
        protected InstanceCreationEditor() { }
        public virtual string Text { get { throw null; } }
        public abstract object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Type instanceType);
    }
    public partial class Int16Converter : System.ComponentModel.BaseNumberConverter
    {
        public Int16Converter() { }
    }
    public partial class Int32Converter : System.ComponentModel.BaseNumberConverter
    {
        public Int32Converter() { }
    }
    public partial class Int64Converter : System.ComponentModel.BaseNumberConverter
    {
        public Int64Converter() { }
    }
    public partial class InvalidAsynchronousStateException : System.ArgumentException
    {
        public InvalidAsynchronousStateException() { }
        protected InvalidAsynchronousStateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidAsynchronousStateException(string message) { }
        public InvalidAsynchronousStateException(string message, System.Exception innerException) { }
    }
    public partial class InvalidEnumArgumentException : System.ArgumentException
    {
        public InvalidEnumArgumentException() { }
        protected InvalidEnumArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidEnumArgumentException(string message) { }
        public InvalidEnumArgumentException(string message, System.Exception innerException) { }
        public InvalidEnumArgumentException(string argumentName, int invalidValue, System.Type enumClass) { }
    }
    public partial interface IRaiseItemChangedEvents
    {
        bool RaisesItemChangedEvents { get; }
    }
    public partial interface IRevertibleChangeTracking : System.ComponentModel.IChangeTracking
    {
        void RejectChanges();
    }
    public partial interface ISite : System.IServiceProvider
    {
        System.ComponentModel.IComponent Component { get; }
        System.ComponentModel.IContainer Container { get; }
        bool DesignMode { get; }
        string Name { get; set; }
    }
    public partial interface ISupportInitialize
    {
        void BeginInit();
        void EndInit();
    }
    public partial interface ISupportInitializeNotification : System.ComponentModel.ISupportInitialize
    {
        bool IsInitialized { get; }
        event System.EventHandler Initialized;
    }
    public partial interface ISynchronizeInvoke
    {
        bool InvokeRequired { get; }
        System.IAsyncResult BeginInvoke(System.Delegate method, object[] args);
        object EndInvoke(System.IAsyncResult result);
        object Invoke(System.Delegate method, object[] args);
    }
    public partial interface ITypeDescriptorContext : System.IServiceProvider
    {
        System.ComponentModel.IContainer Container { get; }
        object Instance { get; }
        System.ComponentModel.PropertyDescriptor PropertyDescriptor { get; }
        void OnComponentChanged();
        bool OnComponentChanging();
    }
    public partial interface ITypedList
    {
        System.ComponentModel.PropertyDescriptorCollection GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors);
        string GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors);
    }
    public abstract partial class License : System.IDisposable
    {
        protected License() { }
        public abstract string LicenseKey { get; }
        public abstract void Dispose();
    }
    public partial class LicenseContext : System.IServiceProvider
    {
        public LicenseContext() { }
        public virtual System.ComponentModel.LicenseUsageMode UsageMode { get { throw null; } }
        public virtual string GetSavedLicenseKey(System.Type type, System.Reflection.Assembly resourceAssembly) { throw null; }
        public virtual object GetService(System.Type type) { throw null; }
        public virtual void SetSavedLicenseKey(System.Type type, string key) { }
    }
    public partial class LicenseException : System.SystemException
    {
        protected LicenseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public LicenseException(System.Type type) { }
        public LicenseException(System.Type type, object instance) { }
        public LicenseException(System.Type type, object instance, string message) { }
        public LicenseException(System.Type type, object instance, string message, System.Exception innerException) { }
        public System.Type LicensedType { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public sealed partial class LicenseManager
    {
        internal LicenseManager() { }
        public static System.ComponentModel.LicenseContext CurrentContext { get { throw null; } set { } }
        public static System.ComponentModel.LicenseUsageMode UsageMode { get { throw null; } }
        public static object CreateWithContext(System.Type type, System.ComponentModel.LicenseContext creationContext) { throw null; }
        public static object CreateWithContext(System.Type type, System.ComponentModel.LicenseContext creationContext, object[] args) { throw null; }
        public static bool IsLicensed(System.Type type) { throw null; }
        public static bool IsValid(System.Type type) { throw null; }
        public static bool IsValid(System.Type type, object instance, out System.ComponentModel.License license) { throw null; }
        public static void LockContext(object contextUser) { }
        public static void UnlockContext(object contextUser) { }
        public static void Validate(System.Type type) { }
        public static System.ComponentModel.License Validate(System.Type type, object instance) { throw null; }
    }
    public abstract partial class LicenseProvider
    {
        protected LicenseProvider() { }
        public abstract System.ComponentModel.License GetLicense(System.ComponentModel.LicenseContext context, System.Type type, object instance, bool allowExceptions);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=false)]
    public sealed partial class LicenseProviderAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.LicenseProviderAttribute Default;
        public LicenseProviderAttribute() { }
        public LicenseProviderAttribute(string typeName) { }
        public LicenseProviderAttribute(System.Type type) { }
        public System.Type LicenseProvider { get { throw null; } }
        public override object TypeId { get { throw null; } }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public enum LicenseUsageMode
    {
        Runtime = 0,
        Designtime = 1,
    }
    public partial class LicFileLicenseProvider : System.ComponentModel.LicenseProvider
    {
        public LicFileLicenseProvider() { }
        protected virtual string GetKey(System.Type type) { throw null; }
        public override System.ComponentModel.License GetLicense(System.ComponentModel.LicenseContext context, System.Type type, object instance, bool allowExceptions) { throw null; }
        protected virtual bool IsKeyValid(string key, System.Type type) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class ListBindableAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.ListBindableAttribute Default;
        public static readonly System.ComponentModel.ListBindableAttribute No;
        public static readonly System.ComponentModel.ListBindableAttribute Yes;
        public ListBindableAttribute(bool listBindable) { }
        public ListBindableAttribute(System.ComponentModel.BindableSupport flags) { }
        public bool ListBindable { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public partial class ListChangedEventArgs : System.EventArgs
    {
        public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, System.ComponentModel.PropertyDescriptor propDesc) { }
        public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex) { }
        public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, System.ComponentModel.PropertyDescriptor propDesc) { }
        public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, int oldIndex) { }
        public System.ComponentModel.ListChangedType ListChangedType { get { throw null; } }
        public int NewIndex { get { throw null; } }
        public int OldIndex { get { throw null; } }
        public System.ComponentModel.PropertyDescriptor PropertyDescriptor { get { throw null; } }
    }
    public delegate void ListChangedEventHandler(object sender, System.ComponentModel.ListChangedEventArgs e);
    public enum ListChangedType
    {
        Reset = 0,
        ItemAdded = 1,
        ItemDeleted = 2,
        ItemMoved = 3,
        ItemChanged = 4,
        PropertyDescriptorAdded = 5,
        PropertyDescriptorDeleted = 6,
        PropertyDescriptorChanged = 7,
    }
    public partial class ListSortDescription
    {
        public ListSortDescription(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction) { }
        public System.ComponentModel.PropertyDescriptor PropertyDescriptor { get { throw null; } set { } }
        public System.ComponentModel.ListSortDirection SortDirection { get { throw null; } set { } }
    }
    public partial class ListSortDescriptionCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public ListSortDescriptionCollection() { }
        public ListSortDescriptionCollection(System.ComponentModel.ListSortDescription[] sorts) { }
        public int Count { get { throw null; } }
        public System.ComponentModel.ListSortDescription this[int index] { get { throw null; } set { } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public bool Contains(object value) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public int IndexOf(object value) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
    public enum ListSortDirection
    {
        Ascending = 0,
        Descending = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class LocalizableAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.LocalizableAttribute Default;
        public static readonly System.ComponentModel.LocalizableAttribute No;
        public static readonly System.ComponentModel.LocalizableAttribute Yes;
        public LocalizableAttribute(bool isLocalizable) { }
        public bool IsLocalizable { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class LookupBindingPropertiesAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.LookupBindingPropertiesAttribute Default;
        public LookupBindingPropertiesAttribute() { }
        public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember) { }
        public string DataSource { get { throw null; } }
        public string DisplayMember { get { throw null; } }
        public string LookupMember { get { throw null; } }
        public string ValueMember { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.ComponentModel.DesignerCategoryAttribute("Component")]
    public partial class MarshalByValueComponent : System.ComponentModel.IComponent, System.IDisposable, System.IServiceProvider
    {
        public MarshalByValueComponent() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual System.ComponentModel.IContainer Container { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual bool DesignMode { get { throw null; } }
        protected System.ComponentModel.EventHandlerList Events { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual System.ComponentModel.ISite Site { get { throw null; } set { } }
        public event System.EventHandler Disposed { add { } remove { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~MarshalByValueComponent() { }
        public virtual object GetService(System.Type service) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MaskedTextProvider : System.ICloneable
    {
        public MaskedTextProvider(string mask) { }
        public MaskedTextProvider(string mask, bool restrictToAscii) { }
        public MaskedTextProvider(string mask, char passwordChar, bool allowPromptAsInput) { }
        public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture) { }
        public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, bool restrictToAscii) { }
        public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii) { }
        public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, char passwordChar, bool allowPromptAsInput) { }
        public bool AllowPromptAsInput { get { throw null; } }
        public bool AsciiOnly { get { throw null; } }
        public int AssignedEditPositionCount { get { throw null; } }
        public int AvailableEditPositionCount { get { throw null; } }
        public System.Globalization.CultureInfo Culture { get { throw null; } }
        public static char DefaultPasswordChar { get { throw null; } }
        public int EditPositionCount { get { throw null; } }
        public System.Collections.IEnumerator EditPositions { get { throw null; } }
        public bool IncludeLiterals { get { throw null; } set { } }
        public bool IncludePrompt { get { throw null; } set { } }
        public static int InvalidIndex { get { throw null; } }
        public bool IsPassword { get { throw null; } set { } }
        public char this[int index] { get { throw null; } }
        public int LastAssignedPosition { get { throw null; } }
        public int Length { get { throw null; } }
        public string Mask { get { throw null; } }
        public bool MaskCompleted { get { throw null; } }
        public bool MaskFull { get { throw null; } }
        public char PasswordChar { get { throw null; } set { } }
        public char PromptChar { get { throw null; } set { } }
        public bool ResetOnPrompt { get { throw null; } set { } }
        public bool ResetOnSpace { get { throw null; } set { } }
        public bool SkipLiterals { get { throw null; } set { } }
        public bool Add(char input) { throw null; }
        public bool Add(char input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public bool Add(string input) { throw null; }
        public bool Add(string input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public void Clear() { }
        public void Clear(out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public object Clone() { throw null; }
        public int FindAssignedEditPositionFrom(int position, bool direction) { throw null; }
        public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction) { throw null; }
        public int FindEditPositionFrom(int position, bool direction) { throw null; }
        public int FindEditPositionInRange(int startPosition, int endPosition, bool direction) { throw null; }
        public int FindNonEditPositionFrom(int position, bool direction) { throw null; }
        public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction) { throw null; }
        public int FindUnassignedEditPositionFrom(int position, bool direction) { throw null; }
        public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction) { throw null; }
        public static bool GetOperationResultFromHint(System.ComponentModel.MaskedTextResultHint hint) { throw null; }
        public bool InsertAt(char input, int position) { throw null; }
        public bool InsertAt(char input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public bool InsertAt(string input, int position) { throw null; }
        public bool InsertAt(string input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public bool IsAvailablePosition(int position) { throw null; }
        public bool IsEditPosition(int position) { throw null; }
        public static bool IsValidInputChar(char c) { throw null; }
        public static bool IsValidMaskChar(char c) { throw null; }
        public static bool IsValidPasswordChar(char c) { throw null; }
        public bool Remove() { throw null; }
        public bool Remove(out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public bool RemoveAt(int position) { throw null; }
        public bool RemoveAt(int startPosition, int endPosition) { throw null; }
        public bool RemoveAt(int startPosition, int endPosition, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public bool Replace(char input, int position) { throw null; }
        public bool Replace(char input, int startPosition, int endPosition, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public bool Replace(char input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public bool Replace(string input, int position) { throw null; }
        public bool Replace(string input, int startPosition, int endPosition, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public bool Replace(string input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public bool Set(string input) { throw null; }
        public bool Set(string input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
        public string ToDisplayString() { throw null; }
        public override string ToString() { throw null; }
        public string ToString(bool ignorePasswordChar) { throw null; }
        public string ToString(bool includePrompt, bool includeLiterals) { throw null; }
        public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length) { throw null; }
        public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length) { throw null; }
        public string ToString(bool ignorePasswordChar, int startPosition, int length) { throw null; }
        public string ToString(int startPosition, int length) { throw null; }
        public bool VerifyChar(char input, int position, out System.ComponentModel.MaskedTextResultHint hint) { throw null; }
        public bool VerifyEscapeChar(char input, int position) { throw null; }
        public bool VerifyString(string input) { throw null; }
        public bool VerifyString(string input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { throw null; }
    }
    public enum MaskedTextResultHint
    {
        PositionOutOfRange = -55,
        NonEditPosition = -54,
        UnavailableEditPosition = -53,
        PromptCharNotAllowed = -52,
        InvalidInput = -51,
        SignedDigitExpected = -5,
        LetterExpected = -4,
        DigitExpected = -3,
        AlphanumericCharacterExpected = -2,
        AsciiCharacterExpected = -1,
        Unknown = 0,
        CharacterEscaped = 1,
        NoEffect = 2,
        SideEffect = 3,
        Success = 4,
    }
    public abstract partial class MemberDescriptor
    {
        protected MemberDescriptor(System.ComponentModel.MemberDescriptor descr) { }
        protected MemberDescriptor(System.ComponentModel.MemberDescriptor oldMemberDescriptor, System.Attribute[] newAttributes) { }
        protected MemberDescriptor(string name) { }
        protected MemberDescriptor(string name, System.Attribute[] attributes) { }
        protected virtual System.Attribute[] AttributeArray { get { throw null; } set { } }
        public virtual System.ComponentModel.AttributeCollection Attributes { get { throw null; } }
        public virtual string Category { get { throw null; } }
        public virtual string Description { get { throw null; } }
        public virtual bool DesignTimeOnly { get { throw null; } }
        public virtual string DisplayName { get { throw null; } }
        public virtual bool IsBrowsable { get { throw null; } }
        public virtual string Name { get { throw null; } }
        protected virtual int NameHashCode { get { throw null; } }
        protected virtual System.ComponentModel.AttributeCollection CreateAttributeCollection() { throw null; }
        public override bool Equals(object obj) { throw null; }
        protected virtual void FillAttributes(System.Collections.IList attributeList) { }
        protected static System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType) { throw null; }
        protected static System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType, bool publicOnly) { throw null; }
        public override int GetHashCode() { throw null; }
        protected virtual object GetInvocationTarget(System.Type type, object instance) { throw null; }
        [System.ObsoleteAttribute("This method has been deprecated. Use GetInvocationTarget instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        protected static object GetInvokee(System.Type componentClass, object component) { throw null; }
        protected static System.ComponentModel.ISite GetSite(object component) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class MergablePropertyAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.MergablePropertyAttribute Default;
        public static readonly System.ComponentModel.MergablePropertyAttribute No;
        public static readonly System.ComponentModel.MergablePropertyAttribute Yes;
        public MergablePropertyAttribute(bool allowMerge) { }
        public bool AllowMerge { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public partial class MultilineStringConverter : System.ComponentModel.TypeConverter
    {
        public MultilineStringConverter() { }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
        public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { throw null; }
        public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class NestedContainer : System.ComponentModel.Container, System.ComponentModel.IContainer, System.ComponentModel.INestedContainer, System.IDisposable
    {
        public NestedContainer(System.ComponentModel.IComponent owner) { }
        public System.ComponentModel.IComponent Owner { get { throw null; } }
        protected virtual string OwnerName { get { throw null; } }
        protected override System.ComponentModel.ISite CreateSite(System.ComponentModel.IComponent component, string name) { throw null; }
        protected override void Dispose(bool disposing) { }
        protected override object GetService(System.Type service) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property)]
    public sealed partial class NotifyParentPropertyAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.NotifyParentPropertyAttribute Default;
        public static readonly System.ComponentModel.NotifyParentPropertyAttribute No;
        public static readonly System.ComponentModel.NotifyParentPropertyAttribute Yes;
        public NotifyParentPropertyAttribute(bool notifyParent) { }
        public bool NotifyParent { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public partial class NullableConverter : System.ComponentModel.TypeConverter
    {
        public NullableConverter(System.Type type) { }
        public System.Type NullableType { get { throw null; } }
        public System.Type UnderlyingType { get { throw null; } }
        public System.ComponentModel.TypeConverter UnderlyingTypeConverter { get { throw null; } }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
        public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { throw null; }
        public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { throw null; }
        public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class ParenthesizePropertyNameAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.ParenthesizePropertyNameAttribute Default;
        public ParenthesizePropertyNameAttribute() { }
        public ParenthesizePropertyNameAttribute(bool needParenthesis) { }
        public bool NeedParenthesis { get { throw null; } }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class PasswordPropertyTextAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.PasswordPropertyTextAttribute Default;
        public static readonly System.ComponentModel.PasswordPropertyTextAttribute No;
        public static readonly System.ComponentModel.PasswordPropertyTextAttribute Yes;
        public PasswordPropertyTextAttribute() { }
        public PasswordPropertyTextAttribute(bool password) { }
        public bool Password { get { throw null; } }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public partial class ProgressChangedEventArgs : System.EventArgs
    {
        public ProgressChangedEventArgs(int progressPercentage, object userState) { }
        public int ProgressPercentage { get { throw null; } }
        public object UserState { get { throw null; } }
    }
    public delegate void ProgressChangedEventHandler(object sender, System.ComponentModel.ProgressChangedEventArgs e);
    public partial class PropertyChangedEventArgs : System.EventArgs
    {
        public PropertyChangedEventArgs(string propertyName) { }
        public virtual string PropertyName { get { throw null; } }
    }
    public delegate void PropertyChangedEventHandler(object sender, System.ComponentModel.PropertyChangedEventArgs e);
    public partial class PropertyChangingEventArgs : System.EventArgs
    {
        public PropertyChangingEventArgs(string propertyName) { }
        public virtual string PropertyName { get { throw null; } }
    }
    public delegate void PropertyChangingEventHandler(object sender, System.ComponentModel.PropertyChangingEventArgs e);
    public abstract partial class PropertyDescriptor : System.ComponentModel.MemberDescriptor
    {
        protected PropertyDescriptor(System.ComponentModel.MemberDescriptor descr) : base (default(string)) { }
        protected PropertyDescriptor(System.ComponentModel.MemberDescriptor descr, System.Attribute[] attrs) : base (default(string)) { }
        protected PropertyDescriptor(string name, System.Attribute[] attrs) : base (default(string)) { }
        public abstract System.Type ComponentType { get; }
        public virtual System.ComponentModel.TypeConverter Converter { get { throw null; } }
        public virtual bool IsLocalizable { get { throw null; } }
        public abstract bool IsReadOnly { get; }
        public abstract System.Type PropertyType { get; }
        public System.ComponentModel.DesignerSerializationVisibility SerializationVisibility { get { throw null; } }
        public virtual bool SupportsChangeEvents { get { throw null; } }
        public virtual void AddValueChanged(object component, System.EventHandler handler) { }
        public abstract bool CanResetValue(object component);
        protected object CreateInstance(System.Type type) { throw null; }
        public override bool Equals(object obj) { throw null; }
        protected override void FillAttributes(System.Collections.IList attributeList) { }
        public System.ComponentModel.PropertyDescriptorCollection GetChildProperties() { throw null; }
        public System.ComponentModel.PropertyDescriptorCollection GetChildProperties(System.Attribute[] filter) { throw null; }
        public System.ComponentModel.PropertyDescriptorCollection GetChildProperties(object instance) { throw null; }
        public virtual System.ComponentModel.PropertyDescriptorCollection GetChildProperties(object instance, System.Attribute[] filter) { throw null; }
        public virtual object GetEditor(System.Type editorBaseType) { throw null; }
        public override int GetHashCode() { throw null; }
        protected override object GetInvocationTarget(System.Type type, object instance) { throw null; }
        protected System.Type GetTypeFromName(string typeName) { throw null; }
        public abstract object GetValue(object component);
        protected internal System.EventHandler GetValueChangedHandler(object component) { throw null; }
        protected virtual void OnValueChanged(object component, System.EventArgs e) { }
        public virtual void RemoveValueChanged(object component, System.EventHandler handler) { }
        public abstract void ResetValue(object component);
        public abstract void SetValue(object component, object value);
        public abstract bool ShouldSerializeValue(object component);
    }
    public partial class PropertyDescriptorCollection : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.Collections.IList
    {
        public static readonly System.ComponentModel.PropertyDescriptorCollection Empty;
        public PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties) { }
        public PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, bool readOnly) { }
        public int Count { get { throw null; } }
        public virtual System.ComponentModel.PropertyDescriptor this[int index] { get { throw null; } }
        public virtual System.ComponentModel.PropertyDescriptor this[string name] { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IDictionary.IsFixedSize { get { throw null; } }
        bool System.Collections.IDictionary.IsReadOnly { get { throw null; } }
        object System.Collections.IDictionary.this[object key] { get { throw null; } set { } }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get { throw null; } }
        System.Collections.ICollection System.Collections.IDictionary.Values { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public int Add(System.ComponentModel.PropertyDescriptor value) { throw null; }
        public void Clear() { }
        public bool Contains(System.ComponentModel.PropertyDescriptor value) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public virtual System.ComponentModel.PropertyDescriptor Find(string name, bool ignoreCase) { throw null; }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.ComponentModel.PropertyDescriptor value) { throw null; }
        public void Insert(int index, System.ComponentModel.PropertyDescriptor value) { }
        protected void InternalSort(System.Collections.IComparer sorter) { }
        protected void InternalSort(string[] names) { }
        public void Remove(System.ComponentModel.PropertyDescriptor value) { }
        public void RemoveAt(int index) { }
        public virtual System.ComponentModel.PropertyDescriptorCollection Sort() { throw null; }
        public virtual System.ComponentModel.PropertyDescriptorCollection Sort(System.Collections.IComparer comparer) { throw null; }
        public virtual System.ComponentModel.PropertyDescriptorCollection Sort(string[] names) { throw null; }
        public virtual System.ComponentModel.PropertyDescriptorCollection Sort(string[] names, System.Collections.IComparer comparer) { throw null; }
        void System.Collections.IDictionary.Add(object key, object value) { }
        void System.Collections.IDictionary.Clear() { }
        bool System.Collections.IDictionary.Contains(object key) { throw null; }
        System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { throw null; }
        void System.Collections.IDictionary.Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public partial class PropertyTabAttribute : System.Attribute
    {
        public PropertyTabAttribute() { }
        public PropertyTabAttribute(string tabClassName) { }
        public PropertyTabAttribute(string tabClassName, System.ComponentModel.PropertyTabScope tabScope) { }
        public PropertyTabAttribute(System.Type tabClass) { }
        public PropertyTabAttribute(System.Type tabClass, System.ComponentModel.PropertyTabScope tabScope) { }
        public System.Type[] TabClasses { get { throw null; } }
        protected string[] TabClassNames { get { throw null; } }
        public System.ComponentModel.PropertyTabScope[] TabScopes { get { throw null; } }
        public bool Equals(System.ComponentModel.PropertyTabAttribute other) { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        protected void InitializeArrays(string[] tabClassNames, System.ComponentModel.PropertyTabScope[] tabScopes) { }
        protected void InitializeArrays(System.Type[] tabClasses, System.ComponentModel.PropertyTabScope[] tabScopes) { }
    }
    public enum PropertyTabScope
    {
        Static = 0,
        Global = 1,
        Document = 2,
        Component = 3,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=true)]
    public sealed partial class ProvidePropertyAttribute : System.Attribute
    {
        public ProvidePropertyAttribute(string propertyName, string receiverTypeName) { }
        public ProvidePropertyAttribute(string propertyName, System.Type receiverType) { }
        public string PropertyName { get { throw null; } }
        public string ReceiverTypeName { get { throw null; } }
        public override object TypeId { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class ReadOnlyAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.ReadOnlyAttribute Default;
        public static readonly System.ComponentModel.ReadOnlyAttribute No;
        public static readonly System.ComponentModel.ReadOnlyAttribute Yes;
        public ReadOnlyAttribute(bool isReadOnly) { }
        public bool IsReadOnly { get { throw null; } }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property)]
    [System.ObsoleteAttribute("Use System.ComponentModel.SettingsBindableAttribute instead to work with the new settings model.")]
    public partial class RecommendedAsConfigurableAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.RecommendedAsConfigurableAttribute Default;
        public static readonly System.ComponentModel.RecommendedAsConfigurableAttribute No;
        public static readonly System.ComponentModel.RecommendedAsConfigurableAttribute Yes;
        public RecommendedAsConfigurableAttribute(bool recommendedAsConfigurable) { }
        public bool RecommendedAsConfigurable { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public partial class ReferenceConverter : System.ComponentModel.TypeConverter
    {
        public ReferenceConverter(System.Type type) { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        protected virtual bool IsValueAllowed(System.ComponentModel.ITypeDescriptorContext context, object value) { throw null; }
    }
    public partial class RefreshEventArgs : System.EventArgs
    {
        public RefreshEventArgs(object componentChanged) { }
        public RefreshEventArgs(System.Type typeChanged) { }
        public object ComponentChanged { get { throw null; } }
        public System.Type TypeChanged { get { throw null; } }
    }
    public delegate void RefreshEventHandler(System.ComponentModel.RefreshEventArgs e);
    public enum RefreshProperties
    {
        None = 0,
        All = 1,
        Repaint = 2,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class RefreshPropertiesAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.RefreshPropertiesAttribute All;
        public static readonly System.ComponentModel.RefreshPropertiesAttribute Default;
        public static readonly System.ComponentModel.RefreshPropertiesAttribute Repaint;
        public RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties refresh) { }
        public System.ComponentModel.RefreshProperties RefreshProperties { get { throw null; } }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public partial class RunInstallerAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.RunInstallerAttribute Default;
        public static readonly System.ComponentModel.RunInstallerAttribute No;
        public static readonly System.ComponentModel.RunInstallerAttribute Yes;
        public RunInstallerAttribute(bool runInstaller) { }
        public bool RunInstaller { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public partial class RunWorkerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        public RunWorkerCompletedEventArgs(object result, System.Exception error, bool cancelled) : base (default(System.Exception), default(bool), default(object)) { }
        public object Result { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public new object UserState { get { throw null; } }
    }
    public delegate void RunWorkerCompletedEventHandler(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e);
    public partial class SByteConverter : System.ComponentModel.BaseNumberConverter
    {
        public SByteConverter() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property)]
    public sealed partial class SettingsBindableAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.SettingsBindableAttribute No;
        public static readonly System.ComponentModel.SettingsBindableAttribute Yes;
        public SettingsBindableAttribute(bool bindable) { }
        public bool Bindable { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class SingleConverter : System.ComponentModel.BaseNumberConverter
    {
        public SingleConverter() { }
    }
    public partial class StringConverter : System.ComponentModel.TypeConverter
    {
        public StringConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
    }
    public static partial class SyntaxCheck
    {
        public static bool CheckMachineName(string value) { throw null; }
        public static bool CheckPath(string value) { throw null; }
        public static bool CheckRootedPath(string value) { throw null; }
    }
    public partial class TimeSpanConverter : System.ComponentModel.TypeConverter
    {
        public TimeSpanConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public partial class ToolboxItemAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.ToolboxItemAttribute Default;
        public static readonly System.ComponentModel.ToolboxItemAttribute None;
        public ToolboxItemAttribute(bool defaultType) { }
        public ToolboxItemAttribute(string toolboxItemTypeName) { }
        public ToolboxItemAttribute(System.Type toolboxItemType) { }
        public System.Type ToolboxItemType { get { throw null; } }
        public string ToolboxItemTypeName { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=true, Inherited=true)]
    public sealed partial class ToolboxItemFilterAttribute : System.Attribute
    {
        public ToolboxItemFilterAttribute(string filterString) { }
        public ToolboxItemFilterAttribute(string filterString, System.ComponentModel.ToolboxItemFilterType filterType) { }
        public string FilterString { get { throw null; } }
        public System.ComponentModel.ToolboxItemFilterType FilterType { get { throw null; } }
        public override object TypeId { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool Match(object obj) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum ToolboxItemFilterType
    {
        Allow = 0,
        Custom = 1,
        Prevent = 2,
        Require = 3,
    }
    public partial class TypeConverter
    {
        public TypeConverter() { }
        public virtual bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public bool CanConvertFrom(System.Type sourceType) { throw null; }
        public virtual bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public bool CanConvertTo(System.Type destinationType) { throw null; }
        public virtual object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public object ConvertFrom(object value) { throw null; }
        public object ConvertFromInvariantString(System.ComponentModel.ITypeDescriptorContext context, string text) { throw null; }
        public object ConvertFromInvariantString(string text) { throw null; }
        public object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string text) { throw null; }
        public object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, string text) { throw null; }
        public object ConvertFromString(string text) { throw null; }
        public virtual object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
        public object ConvertTo(object value, System.Type destinationType) { throw null; }
        public string ConvertToInvariantString(System.ComponentModel.ITypeDescriptorContext context, object value) { throw null; }
        public string ConvertToInvariantString(object value) { throw null; }
        public string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, object value) { throw null; }
        public string ConvertToString(object value) { throw null; }
        public object CreateInstance(System.Collections.IDictionary propertyValues) { throw null; }
        public virtual object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { throw null; }
        protected System.Exception GetConvertFromException(object value) { throw null; }
        protected System.Exception GetConvertToException(object value, System.Type destinationType) { throw null; }
        public bool GetCreateInstanceSupported() { throw null; }
        public virtual bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value) { throw null; }
        public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { throw null; }
        public System.ComponentModel.PropertyDescriptorCollection GetProperties(object value) { throw null; }
        public bool GetPropertiesSupported() { throw null; }
        public virtual bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public System.Collections.ICollection GetStandardValues() { throw null; }
        public virtual System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public bool GetStandardValuesExclusive() { throw null; }
        public virtual bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public bool GetStandardValuesSupported() { throw null; }
        public virtual bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public virtual bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) { throw null; }
        public bool IsValid(object value) { throw null; }
        protected System.ComponentModel.PropertyDescriptorCollection SortProperties(System.ComponentModel.PropertyDescriptorCollection props, string[] names) { throw null; }
        protected abstract partial class SimplePropertyDescriptor : System.ComponentModel.PropertyDescriptor
        {
            protected SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType) : base (default(string), default(System.Attribute[])) { }
            protected SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType, System.Attribute[] attributes) : base (default(string), default(System.Attribute[])) { }
            public override System.Type ComponentType { get { throw null; } }
            public override bool IsReadOnly { get { throw null; } }
            public override System.Type PropertyType { get { throw null; } }
            public override bool CanResetValue(object component) { throw null; }
            public override void ResetValue(object component) { }
            public override bool ShouldSerializeValue(object component) { throw null; }
        }
        public partial class StandardValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
        {
            public StandardValuesCollection(System.Collections.ICollection values) { }
            public int Count { get { throw null; } }
            public object this[int index] { get { throw null; } }
            int System.Collections.ICollection.Count { get { throw null; } }
            bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
            object System.Collections.ICollection.SyncRoot { get { throw null; } }
            public void CopyTo(System.Array array, int index) { }
            public System.Collections.IEnumerator GetEnumerator() { throw null; }
            void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public sealed partial class TypeConverterAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.TypeConverterAttribute Default;
        public TypeConverterAttribute() { }
        public TypeConverterAttribute(string typeName) { }
        public TypeConverterAttribute(System.Type type) { }
        public string ConverterTypeName { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public abstract partial class TypeDescriptionProvider
    {
        protected TypeDescriptionProvider() { }
        protected TypeDescriptionProvider(System.ComponentModel.TypeDescriptionProvider parent) { }
        public virtual object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args) { throw null; }
        public virtual System.Collections.IDictionary GetCache(object instance) { throw null; }
        public virtual System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { throw null; }
        protected internal virtual System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance) { throw null; }
        public virtual string GetFullComponentName(object component) { throw null; }
        public System.Type GetReflectionType(object instance) { throw null; }
        public System.Type GetReflectionType(System.Type objectType) { throw null; }
        public virtual System.Type GetReflectionType(System.Type objectType, object instance) { throw null; }
        public virtual System.Type GetRuntimeType(System.Type reflectionType) { throw null; }
        public System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(object instance) { throw null; }
        public System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType) { throw null; }
        public virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance) { throw null; }
        public virtual bool IsSupportedType(System.Type type) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, Inherited=true)]
    public sealed partial class TypeDescriptionProviderAttribute : System.Attribute
    {
        public TypeDescriptionProviderAttribute(string typeName) { }
        public TypeDescriptionProviderAttribute(System.Type type) { }
        public string TypeName { get { throw null; } }
    }
    public sealed partial class TypeDescriptor
    {
        internal TypeDescriptor() { }
        [System.ObsoleteAttribute("This property has been deprecated.  Use a type description provider to supply type information for COM types instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.ComponentModel.IComNativeDescriptorHandler ComNativeDescriptorHandler { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Type ComObjectType { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Type InterfaceType { get { throw null; } }
        public static event System.ComponentModel.RefreshEventHandler Refreshed { add { } remove { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.ComponentModel.TypeDescriptionProvider AddAttributes(object instance, params System.Attribute[] attributes) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.ComponentModel.TypeDescriptionProvider AddAttributes(System.Type type, params System.Attribute[] attributes) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void AddEditorTable(System.Type editorBaseType, System.Collections.Hashtable table) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void AddProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void AddProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void CreateAssociation(object primary, object secondary) { }
        public static System.ComponentModel.Design.IDesigner CreateDesigner(System.ComponentModel.IComponent component, System.Type designerBaseType) { throw null; }
        public static System.ComponentModel.EventDescriptor CreateEvent(System.Type componentType, System.ComponentModel.EventDescriptor oldEventDescriptor, params System.Attribute[] attributes) { throw null; }
        public static System.ComponentModel.EventDescriptor CreateEvent(System.Type componentType, string name, System.Type type, params System.Attribute[] attributes) { throw null; }
        public static object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args) { throw null; }
        public static System.ComponentModel.PropertyDescriptor CreateProperty(System.Type componentType, System.ComponentModel.PropertyDescriptor oldPropertyDescriptor, params System.Attribute[] attributes) { throw null; }
        public static System.ComponentModel.PropertyDescriptor CreateProperty(System.Type componentType, string name, System.Type type, params System.Attribute[] attributes) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static object GetAssociation(System.Type type, object primary) { throw null; }
        public static System.ComponentModel.AttributeCollection GetAttributes(object component) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.ComponentModel.AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { throw null; }
        public static System.ComponentModel.AttributeCollection GetAttributes(System.Type componentType) { throw null; }
        public static string GetClassName(object component) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static string GetClassName(object component, bool noCustomTypeDesc) { throw null; }
        public static string GetClassName(System.Type componentType) { throw null; }
        public static string GetComponentName(object component) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static string GetComponentName(object component, bool noCustomTypeDesc) { throw null; }
        public static System.ComponentModel.TypeConverter GetConverter(object component) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.ComponentModel.TypeConverter GetConverter(object component, bool noCustomTypeDesc) { throw null; }
        public static System.ComponentModel.TypeConverter GetConverter(System.Type type) { throw null; }
        public static System.ComponentModel.EventDescriptor GetDefaultEvent(object component) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.ComponentModel.EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc) { throw null; }
        public static System.ComponentModel.EventDescriptor GetDefaultEvent(System.Type componentType) { throw null; }
        public static System.ComponentModel.PropertyDescriptor GetDefaultProperty(object component) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.ComponentModel.PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc) { throw null; }
        public static System.ComponentModel.PropertyDescriptor GetDefaultProperty(System.Type componentType) { throw null; }
        public static object GetEditor(object component, System.Type editorBaseType) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static object GetEditor(object component, System.Type editorBaseType, bool noCustomTypeDesc) { throw null; }
        public static object GetEditor(System.Type type, System.Type editorBaseType) { throw null; }
        public static System.ComponentModel.EventDescriptorCollection GetEvents(object component) { throw null; }
        public static System.ComponentModel.EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.ComponentModel.EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes, bool noCustomTypeDesc) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.ComponentModel.EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc) { throw null; }
        public static System.ComponentModel.EventDescriptorCollection GetEvents(System.Type componentType) { throw null; }
        public static System.ComponentModel.EventDescriptorCollection GetEvents(System.Type componentType, System.Attribute[] attributes) { throw null; }
        public static string GetFullComponentName(object component) { throw null; }
        public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component) { throw null; }
        public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes) { throw null; }
        public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes, bool noCustomTypeDesc) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { throw null; }
        public static System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type componentType) { throw null; }
        public static System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type componentType, System.Attribute[] attributes) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.ComponentModel.TypeDescriptionProvider GetProvider(object instance) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.ComponentModel.TypeDescriptionProvider GetProvider(System.Type type) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Type GetReflectionType(object instance) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Type GetReflectionType(System.Type type) { throw null; }
        public static void Refresh(object component) { }
        public static void Refresh(System.Reflection.Assembly assembly) { }
        public static void Refresh(System.Reflection.Module module) { }
        public static void Refresh(System.Type type) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void RemoveAssociation(object primary, object secondary) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void RemoveAssociations(object primary) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void RemoveProvider(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void RemoveProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void RemoveProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static void RemoveProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
        public static void SortDescriptorArray(System.Collections.IList infos) { }
    }
    public abstract partial class TypeListConverter : System.ComponentModel.TypeConverter
    {
        protected TypeListConverter(System.Type[] types) { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class UInt16Converter : System.ComponentModel.BaseNumberConverter
    {
        public UInt16Converter() { }
    }
    public partial class UInt32Converter : System.ComponentModel.BaseNumberConverter
    {
        public UInt32Converter() { }
    }
    public partial class UInt64Converter : System.ComponentModel.BaseNumberConverter
    {
        public UInt64Converter() { }
    }
    public partial class WarningException : System.SystemException
    {
        public WarningException() { }
        protected WarningException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public WarningException(string message) { }
        public WarningException(string message, System.Exception innerException) { }
        public WarningException(string message, string helpUrl) { }
        public WarningException(string message, string helpUrl, string helpTopic) { }
        public string HelpTopic { get { throw null; } }
        public string HelpUrl { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class Win32Exception : System.Runtime.InteropServices.ExternalException, System.Runtime.Serialization.ISerializable
    {
        public Win32Exception() { }
        public Win32Exception(int error) { }
        public Win32Exception(int error, string message) { }
        protected Win32Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public Win32Exception(string message) { }
        public Win32Exception(string message, System.Exception innerException) { }
        public int NativeErrorCode { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
namespace System.ComponentModel.Design
{
    public partial class ActiveDesignerEventArgs : System.EventArgs
    {
        public ActiveDesignerEventArgs(System.ComponentModel.Design.IDesignerHost oldDesigner, System.ComponentModel.Design.IDesignerHost newDesigner) { }
        public System.ComponentModel.Design.IDesignerHost NewDesigner { get { throw null; } }
        public System.ComponentModel.Design.IDesignerHost OldDesigner { get { throw null; } }
    }
    public delegate void ActiveDesignerEventHandler(object sender, System.ComponentModel.Design.ActiveDesignerEventArgs e);
    public partial class CheckoutException : System.Runtime.InteropServices.ExternalException
    {
        public static readonly System.ComponentModel.Design.CheckoutException Canceled;
        public CheckoutException() { }
        protected CheckoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CheckoutException(string message) { }
        public CheckoutException(string message, System.Exception innerException) { }
        public CheckoutException(string message, int errorCode) { }
    }
    public partial class CommandID
    {
        public CommandID(System.Guid menuGroup, int commandID) { }
        public virtual System.Guid Guid { get { throw null; } }
        public virtual int ID { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class ComponentChangedEventArgs : System.EventArgs
    {
        public ComponentChangedEventArgs(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue) { }
        public object Component { get { throw null; } }
        public System.ComponentModel.MemberDescriptor Member { get { throw null; } }
        public object NewValue { get { throw null; } }
        public object OldValue { get { throw null; } }
    }
    public delegate void ComponentChangedEventHandler(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e);
    public sealed partial class ComponentChangingEventArgs : System.EventArgs
    {
        public ComponentChangingEventArgs(object component, System.ComponentModel.MemberDescriptor member) { }
        public object Component { get { throw null; } }
        public System.ComponentModel.MemberDescriptor Member { get { throw null; } }
    }
    public delegate void ComponentChangingEventHandler(object sender, System.ComponentModel.Design.ComponentChangingEventArgs e);
    public partial class ComponentEventArgs : System.EventArgs
    {
        public ComponentEventArgs(System.ComponentModel.IComponent component) { }
        public virtual System.ComponentModel.IComponent Component { get { throw null; } }
    }
    public delegate void ComponentEventHandler(object sender, System.ComponentModel.Design.ComponentEventArgs e);
    public partial class ComponentRenameEventArgs : System.EventArgs
    {
        public ComponentRenameEventArgs(object component, string oldName, string newName) { }
        public object Component { get { throw null; } }
        public virtual string NewName { get { throw null; } }
        public virtual string OldName { get { throw null; } }
    }
    public delegate void ComponentRenameEventHandler(object sender, System.ComponentModel.Design.ComponentRenameEventArgs e);
    public partial class DesignerCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public DesignerCollection(System.Collections.IList designers) { }
        public DesignerCollection(System.ComponentModel.Design.IDesignerHost[] designers) { }
        public int Count { get { throw null; } }
        public virtual System.ComponentModel.Design.IDesignerHost this[int index] { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DesignerEventArgs : System.EventArgs
    {
        public DesignerEventArgs(System.ComponentModel.Design.IDesignerHost host) { }
        public System.ComponentModel.Design.IDesignerHost Designer { get { throw null; } }
    }
    public delegate void DesignerEventHandler(object sender, System.ComponentModel.Design.DesignerEventArgs e);
    public abstract partial class DesignerOptionService : System.ComponentModel.Design.IDesignerOptionService
    {
        protected DesignerOptionService() { }
        public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection Options { get { throw null; } }
        protected System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection CreateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection parent, string name, object value) { throw null; }
        protected virtual void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options) { }
        protected virtual bool ShowDialog(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options, object optionObject) { throw null; }
        object System.ComponentModel.Design.IDesignerOptionService.GetOptionValue(string pageName, string valueName) { throw null; }
        void System.ComponentModel.Design.IDesignerOptionService.SetOptionValue(string pageName, string valueName, object value) { }
        public sealed partial class DesignerOptionCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
        {
            internal DesignerOptionCollection() { }
            public int Count { get { throw null; } }
            public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection this[int index] { get { throw null; } }
            public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection this[string name] { get { throw null; } }
            public string Name { get { throw null; } }
            public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection Parent { get { throw null; } }
            public System.ComponentModel.PropertyDescriptorCollection Properties { get { throw null; } }
            bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
            object System.Collections.ICollection.SyncRoot { get { throw null; } }
            bool System.Collections.IList.IsFixedSize { get { throw null; } }
            bool System.Collections.IList.IsReadOnly { get { throw null; } }
            object System.Collections.IList.this[int index] { get { throw null; } set { } }
            public void CopyTo(System.Array array, int index) { }
            public System.Collections.IEnumerator GetEnumerator() { throw null; }
            public int IndexOf(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection value) { throw null; }
            public bool ShowDialog() { throw null; }
            int System.Collections.IList.Add(object value) { throw null; }
            void System.Collections.IList.Clear() { }
            bool System.Collections.IList.Contains(object value) { throw null; }
            int System.Collections.IList.IndexOf(object value) { throw null; }
            void System.Collections.IList.Insert(int index, object value) { }
            void System.Collections.IList.Remove(object value) { }
            void System.Collections.IList.RemoveAt(int index) { }
        }
    }
    public abstract partial class DesignerTransaction : System.IDisposable
    {
        protected DesignerTransaction() { }
        protected DesignerTransaction(string description) { }
        public bool Canceled { get { throw null; } }
        public bool Committed { get { throw null; } }
        public string Description { get { throw null; } }
        public void Cancel() { }
        public void Commit() { }
        protected virtual void Dispose(bool disposing) { }
        ~DesignerTransaction() { }
        protected abstract void OnCancel();
        protected abstract void OnCommit();
        void System.IDisposable.Dispose() { }
    }
    public partial class DesignerTransactionCloseEventArgs : System.EventArgs
    {
        [System.ObsoleteAttribute("This constructor is obsolete. Use DesignerTransactionCloseEventArgs(bool, bool) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public DesignerTransactionCloseEventArgs(bool commit) { }
        public DesignerTransactionCloseEventArgs(bool commit, bool lastTransaction) { }
        public bool LastTransaction { get { throw null; } }
        public bool TransactionCommitted { get { throw null; } }
    }
    public delegate void DesignerTransactionCloseEventHandler(object sender, System.ComponentModel.Design.DesignerTransactionCloseEventArgs e);
    public partial class DesignerVerb : System.ComponentModel.Design.MenuCommand
    {
        public DesignerVerb(string text, System.EventHandler handler) : base (default(System.EventHandler), default(System.ComponentModel.Design.CommandID)) { }
        public DesignerVerb(string text, System.EventHandler handler, System.ComponentModel.Design.CommandID startCommandID) : base (default(System.EventHandler), default(System.ComponentModel.Design.CommandID)) { }
        public string Description { get { throw null; } set { } }
        public string Text { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class DesignerVerbCollection : System.Collections.CollectionBase
    {
        public DesignerVerbCollection() { }
        public DesignerVerbCollection(System.ComponentModel.Design.DesignerVerb[] value) { }
        public System.ComponentModel.Design.DesignerVerb this[int index] { get { throw null; } set { } }
        public int Add(System.ComponentModel.Design.DesignerVerb value) { throw null; }
        public void AddRange(System.ComponentModel.Design.DesignerVerbCollection value) { }
        public void AddRange(System.ComponentModel.Design.DesignerVerb[] value) { }
        public bool Contains(System.ComponentModel.Design.DesignerVerb value) { throw null; }
        public void CopyTo(System.ComponentModel.Design.DesignerVerb[] array, int index) { }
        public int IndexOf(System.ComponentModel.Design.DesignerVerb value) { throw null; }
        public void Insert(int index, System.ComponentModel.Design.DesignerVerb value) { }
        protected override void OnClear() { }
        protected override void OnInsert(int index, object value) { }
        protected override void OnRemove(int index, object value) { }
        protected override void OnSet(int index, object oldValue, object newValue) { }
        protected override void OnValidate(object value) { }
        public void Remove(System.ComponentModel.Design.DesignerVerb value) { }
    }
    public partial class DesigntimeLicenseContext : System.ComponentModel.LicenseContext
    {
        public DesigntimeLicenseContext() { }
        public override System.ComponentModel.LicenseUsageMode UsageMode { get { throw null; } }
        public override string GetSavedLicenseKey(System.Type type, System.Reflection.Assembly resourceAssembly) { throw null; }
        public override void SetSavedLicenseKey(System.Type type, string key) { }
    }
    public partial class DesigntimeLicenseContextSerializer
    {
        internal DesigntimeLicenseContextSerializer() { }
        public static void Serialize(System.IO.Stream o, string cryptoKey, System.ComponentModel.Design.DesigntimeLicenseContext context) { }
    }
    public enum HelpContextType
    {
        Ambient = 0,
        Window = 1,
        Selection = 2,
        ToolWindowSelection = 3,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public sealed partial class HelpKeywordAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.Design.HelpKeywordAttribute Default;
        public HelpKeywordAttribute() { }
        public HelpKeywordAttribute(string keyword) { }
        public HelpKeywordAttribute(System.Type t) { }
        public string HelpKeyword { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public enum HelpKeywordType
    {
        F1Keyword = 0,
        GeneralKeyword = 1,
        FilterKeyword = 2,
    }
    public partial interface IComponentChangeService
    {
        event System.ComponentModel.Design.ComponentEventHandler ComponentAdded;
        event System.ComponentModel.Design.ComponentEventHandler ComponentAdding;
        event System.ComponentModel.Design.ComponentChangedEventHandler ComponentChanged;
        event System.ComponentModel.Design.ComponentChangingEventHandler ComponentChanging;
        event System.ComponentModel.Design.ComponentEventHandler ComponentRemoved;
        event System.ComponentModel.Design.ComponentEventHandler ComponentRemoving;
        event System.ComponentModel.Design.ComponentRenameEventHandler ComponentRename;
        void OnComponentChanged(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue);
        void OnComponentChanging(object component, System.ComponentModel.MemberDescriptor member);
    }
    public partial interface IComponentDiscoveryService
    {
        System.Collections.ICollection GetComponentTypes(System.ComponentModel.Design.IDesignerHost designerHost, System.Type baseType);
    }
    public partial interface IComponentInitializer
    {
        void InitializeExistingComponent(System.Collections.IDictionary defaultValues);
        void InitializeNewComponent(System.Collections.IDictionary defaultValues);
    }
    public partial interface IDesigner : System.IDisposable
    {
        System.ComponentModel.IComponent Component { get; }
        System.ComponentModel.Design.DesignerVerbCollection Verbs { get; }
        void DoDefaultAction();
        void Initialize(System.ComponentModel.IComponent component);
    }
    public partial interface IDesignerEventService
    {
        System.ComponentModel.Design.IDesignerHost ActiveDesigner { get; }
        System.ComponentModel.Design.DesignerCollection Designers { get; }
        event System.ComponentModel.Design.ActiveDesignerEventHandler ActiveDesignerChanged;
        event System.ComponentModel.Design.DesignerEventHandler DesignerCreated;
        event System.ComponentModel.Design.DesignerEventHandler DesignerDisposed;
        event System.EventHandler SelectionChanged;
    }
    public partial interface IDesignerFilter
    {
        void PostFilterAttributes(System.Collections.IDictionary attributes);
        void PostFilterEvents(System.Collections.IDictionary events);
        void PostFilterProperties(System.Collections.IDictionary properties);
        void PreFilterAttributes(System.Collections.IDictionary attributes);
        void PreFilterEvents(System.Collections.IDictionary events);
        void PreFilterProperties(System.Collections.IDictionary properties);
    }
    public partial interface IDesignerHost : System.ComponentModel.Design.IServiceContainer, System.IServiceProvider
    {
        System.ComponentModel.IContainer Container { get; }
        bool InTransaction { get; }
        bool Loading { get; }
        System.ComponentModel.IComponent RootComponent { get; }
        string RootComponentClassName { get; }
        string TransactionDescription { get; }
        event System.EventHandler Activated;
        event System.EventHandler Deactivated;
        event System.EventHandler LoadComplete;
        event System.ComponentModel.Design.DesignerTransactionCloseEventHandler TransactionClosed;
        event System.ComponentModel.Design.DesignerTransactionCloseEventHandler TransactionClosing;
        event System.EventHandler TransactionOpened;
        event System.EventHandler TransactionOpening;
        void Activate();
        System.ComponentModel.IComponent CreateComponent(System.Type componentClass);
        System.ComponentModel.IComponent CreateComponent(System.Type componentClass, string name);
        System.ComponentModel.Design.DesignerTransaction CreateTransaction();
        System.ComponentModel.Design.DesignerTransaction CreateTransaction(string description);
        void DestroyComponent(System.ComponentModel.IComponent component);
        System.ComponentModel.Design.IDesigner GetDesigner(System.ComponentModel.IComponent component);
        System.Type GetType(string typeName);
    }
    public partial interface IDesignerHostTransactionState
    {
        bool IsClosingTransaction { get; }
    }
    public partial interface IDesignerOptionService
    {
        object GetOptionValue(string pageName, string valueName);
        void SetOptionValue(string pageName, string valueName, object value);
    }
    public partial interface IDictionaryService
    {
        object GetKey(object value);
        object GetValue(object key);
        void SetValue(object key, object value);
    }
    public partial interface IEventBindingService
    {
        string CreateUniqueMethodName(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e);
        System.Collections.ICollection GetCompatibleMethods(System.ComponentModel.EventDescriptor e);
        System.ComponentModel.EventDescriptor GetEvent(System.ComponentModel.PropertyDescriptor property);
        System.ComponentModel.PropertyDescriptorCollection GetEventProperties(System.ComponentModel.EventDescriptorCollection events);
        System.ComponentModel.PropertyDescriptor GetEventProperty(System.ComponentModel.EventDescriptor e);
        bool ShowCode();
        bool ShowCode(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e);
        bool ShowCode(int lineNumber);
    }
    public partial interface IExtenderListService
    {
        System.ComponentModel.IExtenderProvider[] GetExtenderProviders();
    }
    public partial interface IExtenderProviderService
    {
        void AddExtenderProvider(System.ComponentModel.IExtenderProvider provider);
        void RemoveExtenderProvider(System.ComponentModel.IExtenderProvider provider);
    }
    public partial interface IHelpService
    {
        void AddContextAttribute(string name, string value, System.ComponentModel.Design.HelpKeywordType keywordType);
        void ClearContextAttributes();
        System.ComponentModel.Design.IHelpService CreateLocalContext(System.ComponentModel.Design.HelpContextType contextType);
        void RemoveContextAttribute(string name, string value);
        void RemoveLocalContext(System.ComponentModel.Design.IHelpService localContext);
        void ShowHelpFromKeyword(string helpKeyword);
        void ShowHelpFromUrl(string helpUrl);
    }
    public partial interface IInheritanceService
    {
        void AddInheritedComponents(System.ComponentModel.IComponent component, System.ComponentModel.IContainer container);
        System.ComponentModel.InheritanceAttribute GetInheritanceAttribute(System.ComponentModel.IComponent component);
    }
    public partial interface IMenuCommandService
    {
        System.ComponentModel.Design.DesignerVerbCollection Verbs { get; }
        void AddCommand(System.ComponentModel.Design.MenuCommand command);
        void AddVerb(System.ComponentModel.Design.DesignerVerb verb);
        System.ComponentModel.Design.MenuCommand FindCommand(System.ComponentModel.Design.CommandID commandID);
        bool GlobalInvoke(System.ComponentModel.Design.CommandID commandID);
        void RemoveCommand(System.ComponentModel.Design.MenuCommand command);
        void RemoveVerb(System.ComponentModel.Design.DesignerVerb verb);
        void ShowContextMenu(System.ComponentModel.Design.CommandID menuID, int x, int y);
    }
    public partial interface IReferenceService
    {
        System.ComponentModel.IComponent GetComponent(object reference);
        string GetName(object reference);
        object GetReference(string name);
        object[] GetReferences();
        object[] GetReferences(System.Type baseType);
    }
    public partial interface IResourceService
    {
        System.Resources.IResourceReader GetResourceReader(System.Globalization.CultureInfo info);
        System.Resources.IResourceWriter GetResourceWriter(System.Globalization.CultureInfo info);
    }
    public partial interface IRootDesigner : System.ComponentModel.Design.IDesigner, System.IDisposable
    {
        System.ComponentModel.Design.ViewTechnology[] SupportedTechnologies { get; }
        object GetView(System.ComponentModel.Design.ViewTechnology technology);
    }
    public partial interface ISelectionService
    {
        object PrimarySelection { get; }
        int SelectionCount { get; }
        event System.EventHandler SelectionChanged;
        event System.EventHandler SelectionChanging;
        bool GetComponentSelected(object component);
        System.Collections.ICollection GetSelectedComponents();
        void SetSelectedComponents(System.Collections.ICollection components);
        void SetSelectedComponents(System.Collections.ICollection components, System.ComponentModel.Design.SelectionTypes selectionType);
    }
    public partial interface IServiceContainer : System.IServiceProvider
    {
        void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback);
        void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback, bool promote);
        void AddService(System.Type serviceType, object serviceInstance);
        void AddService(System.Type serviceType, object serviceInstance, bool promote);
        void RemoveService(System.Type serviceType);
        void RemoveService(System.Type serviceType, bool promote);
    }
    public partial interface ITreeDesigner : System.ComponentModel.Design.IDesigner, System.IDisposable
    {
        System.Collections.ICollection Children { get; }
        System.ComponentModel.Design.IDesigner Parent { get; }
    }
    public partial interface ITypeDescriptorFilterService
    {
        bool FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes);
        bool FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events);
        bool FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties);
    }
    public partial interface ITypeDiscoveryService
    {
        System.Collections.ICollection GetTypes(System.Type baseType, bool excludeGlobalTypes);
    }
    public partial interface ITypeResolutionService
    {
        System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name);
        System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name, bool throwOnError);
        string GetPathOfAssembly(System.Reflection.AssemblyName name);
        System.Type GetType(string name);
        System.Type GetType(string name, bool throwOnError);
        System.Type GetType(string name, bool throwOnError, bool ignoreCase);
        void ReferenceAssembly(System.Reflection.AssemblyName name);
    }
    public partial class MenuCommand
    {
        public MenuCommand(System.EventHandler handler, System.ComponentModel.Design.CommandID command) { }
        public virtual bool Checked { get { throw null; } set { } }
        public virtual System.ComponentModel.Design.CommandID CommandID { get { throw null; } }
        public virtual bool Enabled { get { throw null; } set { } }
        public virtual int OleStatus { get { throw null; } }
        public virtual System.Collections.IDictionary Properties { get { throw null; } }
        public virtual bool Supported { get { throw null; } set { } }
        public virtual bool Visible { get { throw null; } set { } }
        public event System.EventHandler CommandChanged { add { } remove { } }
        public virtual void Invoke() { }
        public virtual void Invoke(object arg) { }
        protected virtual void OnCommandChanged(System.EventArgs e) { }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum SelectionTypes
    {
        Auto = 1,
        [System.ObsoleteAttribute("This value has been deprecated. Use SelectionTypes.Auto instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        Normal = 1,
        Replace = 2,
        [System.ObsoleteAttribute("This value has been deprecated.  It is no longer supported. http://go.microsoft.com/fwlink/?linkid=14202")]
        MouseDown = 4,
        [System.ObsoleteAttribute("This value has been deprecated.  It is no longer supported. http://go.microsoft.com/fwlink/?linkid=14202")]
        MouseUp = 8,
        [System.ObsoleteAttribute("This value has been deprecated. Use SelectionTypes.Primary instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        Click = 16,
        Primary = 16,
        [System.ObsoleteAttribute("This value has been deprecated. Use Enum class methods to determine valid values, or use a type converter. http://go.microsoft.com/fwlink/?linkid=14202")]
        Valid = 31,
        Toggle = 32,
        Add = 64,
        Remove = 128,
    }
    public partial class ServiceContainer : System.ComponentModel.Design.IServiceContainer, System.IDisposable, System.IServiceProvider
    {
        public ServiceContainer() { }
        public ServiceContainer(System.IServiceProvider parentProvider) { }
        protected virtual System.Type[] DefaultServices { get { throw null; } }
        public void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback) { }
        public virtual void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback, bool promote) { }
        public void AddService(System.Type serviceType, object serviceInstance) { }
        public virtual void AddService(System.Type serviceType, object serviceInstance, bool promote) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual object GetService(System.Type serviceType) { throw null; }
        public void RemoveService(System.Type serviceType) { }
        public virtual void RemoveService(System.Type serviceType, bool promote) { }
    }
    public delegate object ServiceCreatorCallback(System.ComponentModel.Design.IServiceContainer container, System.Type serviceType);
    public partial class StandardCommands
    {
        public static readonly System.ComponentModel.Design.CommandID AlignBottom;
        public static readonly System.ComponentModel.Design.CommandID AlignHorizontalCenters;
        public static readonly System.ComponentModel.Design.CommandID AlignLeft;
        public static readonly System.ComponentModel.Design.CommandID AlignRight;
        public static readonly System.ComponentModel.Design.CommandID AlignToGrid;
        public static readonly System.ComponentModel.Design.CommandID AlignTop;
        public static readonly System.ComponentModel.Design.CommandID AlignVerticalCenters;
        public static readonly System.ComponentModel.Design.CommandID ArrangeBottom;
        public static readonly System.ComponentModel.Design.CommandID ArrangeIcons;
        public static readonly System.ComponentModel.Design.CommandID ArrangeRight;
        public static readonly System.ComponentModel.Design.CommandID BringForward;
        public static readonly System.ComponentModel.Design.CommandID BringToFront;
        public static readonly System.ComponentModel.Design.CommandID CenterHorizontally;
        public static readonly System.ComponentModel.Design.CommandID CenterVertically;
        public static readonly System.ComponentModel.Design.CommandID Copy;
        public static readonly System.ComponentModel.Design.CommandID Cut;
        public static readonly System.ComponentModel.Design.CommandID Delete;
        public static readonly System.ComponentModel.Design.CommandID DocumentOutline;
        public static readonly System.ComponentModel.Design.CommandID F1Help;
        public static readonly System.ComponentModel.Design.CommandID Group;
        public static readonly System.ComponentModel.Design.CommandID HorizSpaceConcatenate;
        public static readonly System.ComponentModel.Design.CommandID HorizSpaceDecrease;
        public static readonly System.ComponentModel.Design.CommandID HorizSpaceIncrease;
        public static readonly System.ComponentModel.Design.CommandID HorizSpaceMakeEqual;
        public static readonly System.ComponentModel.Design.CommandID LineupIcons;
        public static readonly System.ComponentModel.Design.CommandID LockControls;
        public static readonly System.ComponentModel.Design.CommandID MultiLevelRedo;
        public static readonly System.ComponentModel.Design.CommandID MultiLevelUndo;
        public static readonly System.ComponentModel.Design.CommandID Paste;
        public static readonly System.ComponentModel.Design.CommandID Properties;
        public static readonly System.ComponentModel.Design.CommandID PropertiesWindow;
        public static readonly System.ComponentModel.Design.CommandID Redo;
        public static readonly System.ComponentModel.Design.CommandID Replace;
        public static readonly System.ComponentModel.Design.CommandID SelectAll;
        public static readonly System.ComponentModel.Design.CommandID SendBackward;
        public static readonly System.ComponentModel.Design.CommandID SendToBack;
        public static readonly System.ComponentModel.Design.CommandID ShowGrid;
        public static readonly System.ComponentModel.Design.CommandID ShowLargeIcons;
        public static readonly System.ComponentModel.Design.CommandID SizeToControl;
        public static readonly System.ComponentModel.Design.CommandID SizeToControlHeight;
        public static readonly System.ComponentModel.Design.CommandID SizeToControlWidth;
        public static readonly System.ComponentModel.Design.CommandID SizeToFit;
        public static readonly System.ComponentModel.Design.CommandID SizeToGrid;
        public static readonly System.ComponentModel.Design.CommandID SnapToGrid;
        public static readonly System.ComponentModel.Design.CommandID TabOrder;
        public static readonly System.ComponentModel.Design.CommandID Undo;
        public static readonly System.ComponentModel.Design.CommandID Ungroup;
        public static readonly System.ComponentModel.Design.CommandID VerbFirst;
        public static readonly System.ComponentModel.Design.CommandID VerbLast;
        public static readonly System.ComponentModel.Design.CommandID VertSpaceConcatenate;
        public static readonly System.ComponentModel.Design.CommandID VertSpaceDecrease;
        public static readonly System.ComponentModel.Design.CommandID VertSpaceIncrease;
        public static readonly System.ComponentModel.Design.CommandID VertSpaceMakeEqual;
        public static readonly System.ComponentModel.Design.CommandID ViewCode;
        public static readonly System.ComponentModel.Design.CommandID ViewGrid;
        public StandardCommands() { }
    }
    public partial class StandardToolWindows
    {
        public static readonly System.Guid ObjectBrowser;
        public static readonly System.Guid OutputWindow;
        public static readonly System.Guid ProjectExplorer;
        public static readonly System.Guid PropertyBrowser;
        public static readonly System.Guid RelatedLinks;
        public static readonly System.Guid ServerExplorer;
        public static readonly System.Guid TaskList;
        public static readonly System.Guid Toolbox;
        public StandardToolWindows() { }
    }
    public abstract partial class TypeDescriptionProviderService
    {
        protected TypeDescriptionProviderService() { }
        public abstract System.ComponentModel.TypeDescriptionProvider GetProvider(object instance);
        public abstract System.ComponentModel.TypeDescriptionProvider GetProvider(System.Type type);
    }
    public enum ViewTechnology
    {
        [System.ObsoleteAttribute("This value has been deprecated. Use ViewTechnology.Default instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        Passthrough = 0,
        [System.ObsoleteAttribute("This value has been deprecated. Use ViewTechnology.Default instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        WindowsForms = 1,
        Default = 2,
    }
}
namespace System.ComponentModel.Design.Serialization
{
    public abstract partial class ComponentSerializationService
    {
        protected ComponentSerializationService() { }
        public abstract System.ComponentModel.Design.Serialization.SerializationStore CreateStore();
        public abstract System.Collections.ICollection Deserialize(System.ComponentModel.Design.Serialization.SerializationStore store);
        public abstract System.Collections.ICollection Deserialize(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container);
        public void DeserializeTo(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container) { }
        public void DeserializeTo(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes) { }
        public abstract void DeserializeTo(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes, bool applyDefaults);
        public abstract System.ComponentModel.Design.Serialization.SerializationStore LoadStore(System.IO.Stream stream);
        public abstract void Serialize(System.ComponentModel.Design.Serialization.SerializationStore store, object value);
        public abstract void SerializeAbsolute(System.ComponentModel.Design.Serialization.SerializationStore store, object value);
        public abstract void SerializeMember(System.ComponentModel.Design.Serialization.SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member);
        public abstract void SerializeMemberAbsolute(System.ComponentModel.Design.Serialization.SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member);
    }
    public sealed partial class ContextStack
    {
        public ContextStack() { }
        public object Current { get { throw null; } }
        public object this[int level] { get { throw null; } }
        public object this[System.Type type] { get { throw null; } }
        public void Append(object context) { }
        public object Pop() { throw null; }
        public void Push(object context) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, Inherited=false)]
    public sealed partial class DefaultSerializationProviderAttribute : System.Attribute
    {
        public DefaultSerializationProviderAttribute(string providerTypeName) { }
        public DefaultSerializationProviderAttribute(System.Type providerType) { }
        public string ProviderTypeName { get { throw null; } }
    }
    public abstract partial class DesignerLoader
    {
        protected DesignerLoader() { }
        public virtual bool Loading { get { throw null; } }
        public abstract void BeginLoad(System.ComponentModel.Design.Serialization.IDesignerLoaderHost host);
        public abstract void Dispose();
        public virtual void Flush() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface, AllowMultiple=true, Inherited=true)]
    public sealed partial class DesignerSerializerAttribute : System.Attribute
    {
        public DesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName) { }
        public DesignerSerializerAttribute(string serializerTypeName, System.Type baseSerializerType) { }
        public DesignerSerializerAttribute(System.Type serializerType, System.Type baseSerializerType) { }
        public string SerializerBaseTypeName { get { throw null; } }
        public string SerializerTypeName { get { throw null; } }
        public override object TypeId { get { throw null; } }
    }
    public partial interface IDesignerLoaderHost : System.ComponentModel.Design.IDesignerHost, System.ComponentModel.Design.IServiceContainer, System.IServiceProvider
    {
        void EndLoad(string baseClassName, bool successful, System.Collections.ICollection errorCollection);
        void Reload();
    }
    public partial interface IDesignerLoaderHost2 : System.ComponentModel.Design.IDesignerHost, System.ComponentModel.Design.IServiceContainer, System.ComponentModel.Design.Serialization.IDesignerLoaderHost, System.IServiceProvider
    {
        bool CanReloadWithErrors { get; set; }
        bool IgnoreErrorsDuringReload { get; set; }
    }
    public partial interface IDesignerLoaderService
    {
        void AddLoadDependency();
        void DependentLoadComplete(bool successful, System.Collections.ICollection errorCollection);
        bool Reload();
    }
    public partial interface IDesignerSerializationManager : System.IServiceProvider
    {
        System.ComponentModel.Design.Serialization.ContextStack Context { get; }
        System.ComponentModel.PropertyDescriptorCollection Properties { get; }
        event System.ComponentModel.Design.Serialization.ResolveNameEventHandler ResolveName;
        event System.EventHandler SerializationComplete;
        void AddSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider);
        object CreateInstance(System.Type type, System.Collections.ICollection arguments, string name, bool addToContainer);
        object GetInstance(string name);
        string GetName(object value);
        object GetSerializer(System.Type objectType, System.Type serializerType);
        System.Type GetType(string typeName);
        void RemoveSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider);
        void ReportError(object errorInformation);
        void SetName(object instance, string name);
    }
    public partial interface IDesignerSerializationProvider
    {
        object GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object currentSerializer, System.Type objectType, System.Type serializerType);
    }
    public partial interface IDesignerSerializationService
    {
        System.Collections.ICollection Deserialize(object serializationData);
        object Serialize(System.Collections.ICollection objects);
    }
    public partial interface INameCreationService
    {
        string CreateName(System.ComponentModel.IContainer container, System.Type dataType);
        bool IsValidName(string name);
        void ValidateName(string name);
    }
    public sealed partial class InstanceDescriptor
    {
        public InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments) { }
        public InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments, bool isComplete) { }
        public System.Collections.ICollection Arguments { get { throw null; } }
        public bool IsComplete { get { throw null; } }
        public System.Reflection.MemberInfo MemberInfo { get { throw null; } }
        public object Invoke() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MemberRelationship
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static readonly System.ComponentModel.Design.Serialization.MemberRelationship Empty;
        public MemberRelationship(object owner, System.ComponentModel.MemberDescriptor member) { throw null; }
        public bool IsEmpty { get { throw null; } }
        public System.ComponentModel.MemberDescriptor Member { get { throw null; } }
        public object Owner { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.ComponentModel.Design.Serialization.MemberRelationship left, System.ComponentModel.Design.Serialization.MemberRelationship right) { throw null; }
        public static bool operator !=(System.ComponentModel.Design.Serialization.MemberRelationship left, System.ComponentModel.Design.Serialization.MemberRelationship right) { throw null; }
    }
    public abstract partial class MemberRelationshipService
    {
        protected MemberRelationshipService() { }
        public System.ComponentModel.Design.Serialization.MemberRelationship this[System.ComponentModel.Design.Serialization.MemberRelationship source] { get { throw null; } set { } }
        public System.ComponentModel.Design.Serialization.MemberRelationship this[object sourceOwner, System.ComponentModel.MemberDescriptor sourceMember] { get { throw null; } set { } }
        protected virtual System.ComponentModel.Design.Serialization.MemberRelationship GetRelationship(System.ComponentModel.Design.Serialization.MemberRelationship source) { throw null; }
        protected virtual void SetRelationship(System.ComponentModel.Design.Serialization.MemberRelationship source, System.ComponentModel.Design.Serialization.MemberRelationship relationship) { }
        public abstract bool SupportsRelationship(System.ComponentModel.Design.Serialization.MemberRelationship source, System.ComponentModel.Design.Serialization.MemberRelationship relationship);
    }
    public partial class ResolveNameEventArgs : System.EventArgs
    {
        public ResolveNameEventArgs(string name) { }
        public string Name { get { throw null; } }
        public object Value { get { throw null; } set { } }
    }
    public delegate void ResolveNameEventHandler(object sender, System.ComponentModel.Design.Serialization.ResolveNameEventArgs e);
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface, AllowMultiple=true, Inherited=true)]
    [System.ObsoleteAttribute("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
    public sealed partial class RootDesignerSerializerAttribute : System.Attribute
    {
        public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }
        public RootDesignerSerializerAttribute(string serializerTypeName, System.Type baseSerializerType, bool reloadable) { }
        public RootDesignerSerializerAttribute(System.Type serializerType, System.Type baseSerializerType, bool reloadable) { }
        public bool Reloadable { get { throw null; } }
        public string SerializerBaseTypeName { get { throw null; } }
        public string SerializerTypeName { get { throw null; } }
        public override object TypeId { get { throw null; } }
    }
    public abstract partial class SerializationStore : System.IDisposable
    {
        protected SerializationStore() { }
        public abstract System.Collections.ICollection Errors { get; }
        public abstract void Close();
        protected virtual void Dispose(bool disposing) { }
        public abstract void Save(System.IO.Stream stream);
        void System.IDisposable.Dispose() { }
    }
}
namespace System.Diagnostics
{
    [System.Diagnostics.SwitchLevelAttribute(typeof(bool))]
    public partial class BooleanSwitch : System.Diagnostics.Switch
    {
        public BooleanSwitch(string displayName, string description) : base (default(string), default(string)) { }
        public BooleanSwitch(string displayName, string description, string defaultSwitchValue) : base (default(string), default(string)) { }
        public bool Enabled { get { throw null; } set { } }
        protected override void OnValueChanged() { }
    }
    public partial class CorrelationManager
    {
        internal CorrelationManager() { }
        public System.Guid ActivityId { get { throw null; } set { } }
        public System.Collections.Stack LogicalOperationStack { get { throw null; } }
        public void StartLogicalOperation() { }
        public void StartLogicalOperation(object operationId) { }
        public void StopLogicalOperation() { }
    }
    public partial class DataReceivedEventArgs : System.EventArgs
    {
        internal DataReceivedEventArgs() { }
        public string Data { get { throw null; } }
    }
    public delegate void DataReceivedEventHandler(object sender, System.Diagnostics.DataReceivedEventArgs e);
    public static partial class Debug
    {
        public static bool AutoFlush { get { throw null; } set { } }
        public static int IndentLevel { get { throw null; } set { } }
        public static int IndentSize { get { throw null; } set { } }
        public static System.Diagnostics.TraceListenerCollection Listeners { get { throw null; } }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Assert(bool condition) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Assert(bool condition, string message) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Assert(bool condition, string message, string detailMessage) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Assert(bool condition, string message, string detailMessageFormat, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Close() { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Fail(string message) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Fail(string message, string detailMessage) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Flush() { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Indent() { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Print(string message) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Print(string format, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Unindent() { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Write(object value) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Write(object value, string category) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Write(string message) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void Write(string message, string category) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteIf(bool condition, object value) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteIf(bool condition, object value, string category) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteIf(bool condition, string message) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteIf(bool condition, string message, string category) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteLine(object value) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteLine(object value, string category) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteLine(string message) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteLine(string format, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteLine(string message, string category) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteLineIf(bool condition, object value) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteLineIf(bool condition, object value, string category) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteLineIf(bool condition, string message) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        public static void WriteLineIf(bool condition, string message, string category) { }
    }
    public partial class DefaultTraceListener : System.Diagnostics.TraceListener
    {
        public DefaultTraceListener() { }
        public bool AssertUiEnabled { get { throw null; } set { } }
        public string LogFileName { get { throw null; } set { } }
        public override void Fail(string message) { }
        public override void Fail(string message, string detailMessage) { }
        public override void Write(string message) { }
        public override void WriteLine(string message) { }
    }
    public partial class DelimitedListTraceListener : System.Diagnostics.TextWriterTraceListener
    {
        public DelimitedListTraceListener(System.IO.Stream stream) { }
        public DelimitedListTraceListener(System.IO.Stream stream, string name) { }
        public DelimitedListTraceListener(System.IO.TextWriter writer) { }
        public DelimitedListTraceListener(System.IO.TextWriter writer, string name) { }
        public DelimitedListTraceListener(string fileName) { }
        public DelimitedListTraceListener(string fileName, string name) { }
        public string Delimiter { get { throw null; } set { } }
        protected internal override string[] GetSupportedAttributes() { throw null; }
        public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
        public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params object[] data) { }
        public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
        public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args) { }
    }
    public partial class EventTypeFilter : System.Diagnostics.TraceFilter
    {
        public EventTypeFilter(System.Diagnostics.SourceLevels level) { }
        public System.Diagnostics.SourceLevels EventType { get { throw null; } set { } }
        public override bool ShouldTrace(System.Diagnostics.TraceEventCache cache, string source, System.Diagnostics.TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data) { throw null; }
    }
    public sealed partial class FileVersionInfo
    {
        internal FileVersionInfo() { }
        public string Comments { get { throw null; } }
        public string CompanyName { get { throw null; } }
        public int FileBuildPart { get { throw null; } }
        public string FileDescription { get { throw null; } }
        public int FileMajorPart { get { throw null; } }
        public int FileMinorPart { get { throw null; } }
        public string FileName { get { throw null; } }
        public int FilePrivatePart { get { throw null; } }
        public string FileVersion { get { throw null; } }
        public string InternalName { get { throw null; } }
        public bool IsDebug { get { throw null; } }
        public bool IsPatched { get { throw null; } }
        public bool IsPreRelease { get { throw null; } }
        public bool IsPrivateBuild { get { throw null; } }
        public bool IsSpecialBuild { get { throw null; } }
        public string Language { get { throw null; } }
        public string LegalCopyright { get { throw null; } }
        public string LegalTrademarks { get { throw null; } }
        public string OriginalFilename { get { throw null; } }
        public string PrivateBuild { get { throw null; } }
        public int ProductBuildPart { get { throw null; } }
        public int ProductMajorPart { get { throw null; } }
        public int ProductMinorPart { get { throw null; } }
        public string ProductName { get { throw null; } }
        public int ProductPrivatePart { get { throw null; } }
        public string ProductVersion { get { throw null; } }
        public string SpecialBuild { get { throw null; } }
        public static System.Diagnostics.FileVersionInfo GetVersionInfo(string fileName) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public partial class MonitoringDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        public MonitoringDescriptionAttribute(string description) { }
        public override string Description { get { throw null; } }
    }
    [System.ComponentModel.DefaultEventAttribute("Exited")]
    [System.ComponentModel.DefaultPropertyAttribute("StartInfo")]
    public partial class Process : System.ComponentModel.Component
    {
        public Process() { }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int BasePriority { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EnableRaisingEvents { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int ExitCode { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.DateTime ExitTime { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.IntPtr Handle { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int HandleCount { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public bool HasExited { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int Id { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string MachineName { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Diagnostics.ProcessModule MainModule { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.IntPtr MainWindowHandle { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string MainWindowTitle { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.IntPtr MaxWorkingSet { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.IntPtr MinWorkingSet { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Diagnostics.ProcessModuleCollection Modules { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ObsoleteAttribute("Use NonpagedSystemMemorySize64")]
        public int NonpagedSystemMemorySize { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public long NonpagedSystemMemorySize64 { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ObsoleteAttribute("Use PagedMemorySize64")]
        public int PagedMemorySize { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public long PagedMemorySize64 { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ObsoleteAttribute("Use PagedSystemMemorySize64")]
        public int PagedSystemMemorySize { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public long PagedSystemMemorySize64 { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ObsoleteAttribute("Use PeakPagedMemorySize64")]
        public int PeakPagedMemorySize { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public long PeakPagedMemorySize64 { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ObsoleteAttribute("Use PeakVirtualMemorySize64")]
        public int PeakVirtualMemorySize { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public long PeakVirtualMemorySize64 { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ObsoleteAttribute("Use PeakWorkingSet64")]
        public int PeakWorkingSet { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public long PeakWorkingSet64 { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public bool PriorityBoostEnabled { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Diagnostics.ProcessPriorityClass PriorityClass { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ObsoleteAttribute("Use PrivateMemorySize64")]
        public int PrivateMemorySize { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public long PrivateMemorySize64 { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.TimeSpan PrivilegedProcessorTime { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string ProcessName { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.IntPtr ProcessorAffinity { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public bool Responding { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public Microsoft.Win32.SafeHandles.SafeProcessHandle SafeHandle { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int SessionId { get { throw null; } }
        [System.ObsoleteAttribute("Process.StandardError is not supported on the current platform.", true)]
        public System.IO.StreamReader StandardError { get { throw null; } }
        [System.ObsoleteAttribute("Process.StandardInput is not supported on the current platform.", true)]
        public System.IO.StreamWriter StandardInput { get { throw null; } }
        [System.ObsoleteAttribute("Process.StandardOutput is not supported on the current platform.", true)]
        public System.IO.StreamReader StandardOutput { get { throw null; } }
        [System.ObsoleteAttribute("Process.StartInfo is not supported on the current platform.", true)]
        public System.Diagnostics.ProcessStartInfo StartInfo { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.DateTime StartTime { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Diagnostics.ProcessThreadCollection Threads { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.TimeSpan TotalProcessorTime { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.TimeSpan UserProcessorTime { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ObsoleteAttribute("Use VirtualMemorySize64")]
        public int VirtualMemorySize { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public long VirtualMemorySize64 { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ObsoleteAttribute("Use WorkingSet64")]
        public int WorkingSet { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public long WorkingSet64 { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(true)]
        public event System.Diagnostics.DataReceivedEventHandler ErrorDataReceived { add { } remove { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        public event System.EventHandler Exited { add { } remove { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        public event System.Diagnostics.DataReceivedEventHandler OutputDataReceived { add { } remove { } }
        [System.ObsoleteAttribute("Process.BeginOutputReadLine is not supported on the current platform.", true)]
        public void BeginErrorReadLine() { }
        [System.ObsoleteAttribute("Process.BeginOutputReadLine is not supported on the current platform.", true)]
        public void BeginOutputReadLine() { }
        [System.ObsoleteAttribute("Process.BeginOutputReadLine is not supported on the current platform.", true)]
        public void CancelErrorRead() { }
        [System.ObsoleteAttribute("Process.BeginOutputReadLine is not supported on the current platform.", true)]
        public void CancelOutputRead() { }
        public void Close() { }
        public bool CloseMainWindow() { throw null; }
        protected override void Dispose(bool disposing) { }
        public static void EnterDebugMode() { }
        public static System.Diagnostics.Process GetCurrentProcess() { throw null; }
        public static System.Diagnostics.Process GetProcessById(int processId) { throw null; }
        public static System.Diagnostics.Process GetProcessById(int processId, string machineName) { throw null; }
        public static System.Diagnostics.Process[] GetProcesses() { throw null; }
        public static System.Diagnostics.Process[] GetProcesses(string machineName) { throw null; }
        public static System.Diagnostics.Process[] GetProcessesByName(string processName) { throw null; }
        public static System.Diagnostics.Process[] GetProcessesByName(string processName, string machineName) { throw null; }
        public void Kill() { }
        public static void LeaveDebugMode() { }
        protected void OnExited() { }
        public void Refresh() { }
        [System.ObsoleteAttribute("Process.Start is not supported on the current platform.", true)]
        public bool Start() { throw null; }
        [System.ObsoleteAttribute("Process.Start is not supported on the current platform.", true)]
        public static System.Diagnostics.Process Start(System.Diagnostics.ProcessStartInfo startInfo) { throw null; }
        [System.ObsoleteAttribute("Process.Start is not supported on the current platform.", true)]
        public static System.Diagnostics.Process Start(string fileName) { throw null; }
        [System.ObsoleteAttribute("Process.Start is not supported on the current platform.", true)]
        public static System.Diagnostics.Process Start(string fileName, string arguments) { throw null; }
        [System.ObsoleteAttribute("Process.Start is not supported on the current platform.", true)]
        public static System.Diagnostics.Process Start(string fileName, string userName, System.Security.SecureString password, string domain) { throw null; }
        [System.ObsoleteAttribute("Process.Start is not supported on the current platform.", true)]
        public static System.Diagnostics.Process Start(string fileName, string arguments, string userName, System.Security.SecureString password, string domain) { throw null; }
        public override string ToString() { throw null; }
        public void WaitForExit() { }
        public bool WaitForExit(int milliseconds) { throw null; }
        public bool WaitForInputIdle() { throw null; }
        public bool WaitForInputIdle(int milliseconds) { throw null; }
    }
    public partial class ProcessModule : System.ComponentModel.Component
    {
        internal ProcessModule() { }
        public System.IntPtr BaseAddress { get { throw null; } }
        public System.IntPtr EntryPointAddress { get { throw null; } }
        public string FileName { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Diagnostics.FileVersionInfo FileVersionInfo { get { throw null; } }
        public int ModuleMemorySize { get { throw null; } }
        public string ModuleName { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class ProcessModuleCollection : System.Collections.ReadOnlyCollectionBase
    {
        protected ProcessModuleCollection() { }
        public ProcessModuleCollection(System.Diagnostics.ProcessModule[] processModules) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int Capacity { get { throw null; } set { } }
        public System.Diagnostics.ProcessModule this[int index] { get { throw null; } }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Add(System.Diagnostics.ProcessModule item) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void AddRange(System.Collections.Generic.IEnumerable<System.Diagnostics.ProcessModule> collection) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Diagnostics.ProcessModule> AsReadOnly() { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int BinarySearch(System.Diagnostics.ProcessModule item) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int BinarySearch(System.Diagnostics.ProcessModule item, System.Collections.Generic.IComparer<System.Diagnostics.ProcessModule> comparer) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int BinarySearch(int index, int count, System.Diagnostics.ProcessModule item, System.Collections.Generic.IComparer<System.Diagnostics.ProcessModule> comparer) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Clear() { }
        public bool Contains(System.Diagnostics.ProcessModule module) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Collections.Generic.List<TOutput> ConvertAll<TOutput>(System.Converter<System.Diagnostics.ProcessModule, TOutput> converter) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void CopyTo(System.Diagnostics.ProcessModule[] array) { }
        public void CopyTo(System.Diagnostics.ProcessModule[] array, int index) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void CopyTo(int index, System.Diagnostics.ProcessModule[] array, int arrayIndex, int count) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public bool Exists(System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Diagnostics.ProcessModule Find(System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Collections.Generic.List<System.Diagnostics.ProcessModule> FindAll(System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindIndex(int startIndex, int count, System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindIndex(int startIndex, System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindIndex(System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Diagnostics.ProcessModule FindLast(System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindLastIndex(int startIndex, int count, System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindLastIndex(int startIndex, System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindLastIndex(System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void ForEach(System.Action<System.Diagnostics.ProcessModule> action) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Collections.Generic.List<System.Diagnostics.ProcessModule> GetRange(int index, int count) { throw null; }
        public int IndexOf(System.Diagnostics.ProcessModule module) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int IndexOf(System.Diagnostics.ProcessModule item, int index) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int IndexOf(System.Diagnostics.ProcessModule item, int index, int count) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Insert(int index, System.Diagnostics.ProcessModule item) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void InsertRange(int index, System.Collections.Generic.IEnumerable<System.Diagnostics.ProcessModule> collection) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int LastIndexOf(System.Diagnostics.ProcessModule item) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int LastIndexOf(System.Diagnostics.ProcessModule item, int index) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int LastIndexOf(System.Diagnostics.ProcessModule item, int index, int count) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public bool Remove(System.Diagnostics.ProcessModule item) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int RemoveAll(System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void RemoveAt(int index) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void RemoveRange(int index, int count) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Reverse() { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Reverse(int index, int count) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Sort() { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Sort(System.Collections.Generic.IComparer<System.Diagnostics.ProcessModule> comparer) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Sort(System.Comparison<System.Diagnostics.ProcessModule> comparison) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Sort(int index, int count, System.Collections.Generic.IComparer<System.Diagnostics.ProcessModule> comparer) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Diagnostics.ProcessModule[] ToArray() { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void TrimExcess() { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public bool TrueForAll(System.Predicate<System.Diagnostics.ProcessModule> match) { throw null; }
    }
    public enum ProcessPriorityClass
    {
        Normal = 32,
        Idle = 64,
        High = 128,
        RealTime = 256,
        BelowNormal = 16384,
        AboveNormal = 32768,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public sealed partial class ProcessStartInfo
    {
        public ProcessStartInfo() { }
        public ProcessStartInfo(string fileName) { }
        public ProcessStartInfo(string fileName, string arguments) { }
        public System.Collections.ObjectModel.Collection<string> ArgumentList { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public string Arguments { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public bool CreateNoWindow { get { throw null; } set { } }
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public string Domain { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public System.Collections.Generic.IDictionary<string, string> Environment { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public System.Collections.Specialized.StringDictionary EnvironmentVariables { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public bool ErrorDialog { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.IntPtr ErrorDialogParentHandle { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public string FileName { get { throw null; } set { } }
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public bool LoadUserProfile { get { throw null; } set { } }
        public System.Security.SecureString Password { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string PasswordInClearText { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public bool RedirectStandardError { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public bool RedirectStandardInput { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public bool RedirectStandardOutput { get { throw null; } set { } }
        public System.Text.Encoding StandardErrorEncoding { get { throw null; } set { } }
        public System.Text.Encoding StandardInputEncoding { get { throw null; } set { } }
        public System.Text.Encoding StandardOutputEncoding { get { throw null; } set { } }
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public string UserName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public bool UseShellExecute { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public string Verb { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string[] Verbs { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.Diagnostics.ProcessWindowStyle.Normal)]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        public System.Diagnostics.ProcessWindowStyle WindowStyle { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.NotifyParentPropertyAttribute(true)]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public string WorkingDirectory { get { throw null; } set { } }
    }
    public partial class ProcessThread : System.ComponentModel.Component
    {
        internal ProcessThread() { }
        public int BasePriority { get { throw null; } }
        public int CurrentPriority { get { throw null; } }
        public int Id { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public int IdealProcessor { set { } }
        public bool PriorityBoostEnabled { get { throw null; } set { } }
        public System.Diagnostics.ThreadPriorityLevel PriorityLevel { get { throw null; } set { } }
        public System.TimeSpan PrivilegedProcessorTime { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.IntPtr ProcessorAffinity { set { } }
        public System.IntPtr StartAddress { get { throw null; } }
        public System.DateTime StartTime { get { throw null; } }
        public System.Diagnostics.ThreadState ThreadState { get { throw null; } }
        public System.TimeSpan TotalProcessorTime { get { throw null; } }
        public System.TimeSpan UserProcessorTime { get { throw null; } }
        public System.Diagnostics.ThreadWaitReason WaitReason { get { throw null; } }
        public void ResetIdealProcessor() { }
    }
    public partial class ProcessThreadCollection : System.Collections.ReadOnlyCollectionBase
    {
        protected ProcessThreadCollection() { }
        public ProcessThreadCollection(System.Diagnostics.ProcessThread[] processThreads) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int Capacity { get { throw null; } set { } }
        public System.Diagnostics.ProcessThread this[int index] { get { throw null; } }
        public int Add(System.Diagnostics.ProcessThread thread) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void AddRange(System.Collections.Generic.IEnumerable<System.Diagnostics.ProcessThread> collection) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Diagnostics.ProcessThread> AsReadOnly() { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int BinarySearch(System.Diagnostics.ProcessThread item) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int BinarySearch(System.Diagnostics.ProcessThread item, System.Collections.Generic.IComparer<System.Diagnostics.ProcessThread> comparer) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int BinarySearch(int index, int count, System.Diagnostics.ProcessThread item, System.Collections.Generic.IComparer<System.Diagnostics.ProcessThread> comparer) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Clear() { }
        public bool Contains(System.Diagnostics.ProcessThread thread) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Collections.Generic.List<TOutput> ConvertAll<TOutput>(System.Converter<System.Diagnostics.ProcessThread, TOutput> converter) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void CopyTo(System.Diagnostics.ProcessThread[] array) { }
        public void CopyTo(System.Diagnostics.ProcessThread[] array, int index) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void CopyTo(int index, System.Diagnostics.ProcessThread[] array, int arrayIndex, int count) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public bool Exists(System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Diagnostics.ProcessThread Find(System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Collections.Generic.List<System.Diagnostics.ProcessThread> FindAll(System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindIndex(int startIndex, int count, System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindIndex(int startIndex, System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindIndex(System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Diagnostics.ProcessThread FindLast(System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindLastIndex(int startIndex, int count, System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindLastIndex(int startIndex, System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int FindLastIndex(System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void ForEach(System.Action<System.Diagnostics.ProcessThread> action) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Collections.Generic.List<System.Diagnostics.ProcessThread> GetRange(int index, int count) { throw null; }
        public int IndexOf(System.Diagnostics.ProcessThread thread) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int IndexOf(System.Diagnostics.ProcessThread item, int index) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int IndexOf(System.Diagnostics.ProcessThread item, int index, int count) { throw null; }
        public void Insert(int index, System.Diagnostics.ProcessThread thread) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void InsertRange(int index, System.Collections.Generic.IEnumerable<System.Diagnostics.ProcessThread> collection) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int LastIndexOf(System.Diagnostics.ProcessThread item) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int LastIndexOf(System.Diagnostics.ProcessThread item, int index) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int LastIndexOf(System.Diagnostics.ProcessThread item, int index, int count) { throw null; }
        public void Remove(System.Diagnostics.ProcessThread thread) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public int RemoveAll(System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void RemoveAt(int index) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void RemoveRange(int index, int count) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Reverse() { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Reverse(int index, int count) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Sort() { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Sort(System.Collections.Generic.IComparer<System.Diagnostics.ProcessThread> comparer) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Sort(System.Comparison<System.Diagnostics.ProcessThread> comparison) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void Sort(int index, int count, System.Collections.Generic.IComparer<System.Diagnostics.ProcessThread> comparer) { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public System.Diagnostics.ProcessThread[] ToArray() { throw null; }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public void TrimExcess() { }
        [System.ObsoleteAttribute("This API is no longer available", true)]
        public bool TrueForAll(System.Predicate<System.Diagnostics.ProcessThread> match) { throw null; }
    }
    public enum ProcessWindowStyle
    {
        Normal = 0,
        Hidden = 1,
        Minimized = 2,
        Maximized = 3,
    }
    public partial class SourceFilter : System.Diagnostics.TraceFilter
    {
        public SourceFilter(string source) { }
        public string Source { get { throw null; } set { } }
        public override bool ShouldTrace(System.Diagnostics.TraceEventCache cache, string source, System.Diagnostics.TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data) { throw null; }
    }
    [System.FlagsAttribute]
    public enum SourceLevels
    {
        All = -1,
        Off = 0,
        Critical = 1,
        Error = 3,
        Warning = 7,
        Information = 15,
        Verbose = 31,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ActivityTracing = 65280,
    }
    public partial class SourceSwitch : System.Diagnostics.Switch
    {
        public SourceSwitch(string name) : base (default(string), default(string)) { }
        public SourceSwitch(string displayName, string defaultSwitchValue) : base (default(string), default(string)) { }
        public System.Diagnostics.SourceLevels Level { get { throw null; } set { } }
        protected override void OnValueChanged() { }
        public bool ShouldTrace(System.Diagnostics.TraceEventType eventType) { throw null; }
    }
    public static partial class StackFrameExtensions
    {
        public static System.IntPtr GetNativeImageBase(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        public static System.IntPtr GetNativeIP(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        public static bool HasILOffset(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        public static bool HasMethod(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        public static bool HasNativeImage(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        public static bool HasSource(this System.Diagnostics.StackFrame stackFrame) { throw null; }
    }
    public partial class Stopwatch
    {
        public static readonly long Frequency;
        public static readonly bool IsHighResolution;
        public Stopwatch() { }
        public System.TimeSpan Elapsed { get { throw null; } }
        public long ElapsedMilliseconds { get { throw null; } }
        public long ElapsedTicks { get { throw null; } }
        public bool IsRunning { get { throw null; } }
        public static long GetTimestamp() { throw null; }
        public void Reset() { }
        public void Restart() { }
        public void Start() { }
        public static System.Diagnostics.Stopwatch StartNew() { throw null; }
        public void Stop() { }
    }
    public abstract partial class Switch
    {
        protected Switch(string displayName, string description) { }
        protected Switch(string displayName, string description, string defaultSwitchValue) { }
        public System.Collections.Specialized.StringDictionary Attributes { get { throw null; } }
        public string Description { get { throw null; } }
        public string DisplayName { get { throw null; } }
        protected int SwitchSetting { get { throw null; } set { } }
        protected string Value { get { throw null; } set { } }
        protected internal virtual string[] GetSupportedAttributes() { throw null; }
        protected virtual void OnSwitchSettingChanged() { }
        protected virtual void OnValueChanged() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Event | System.AttributeTargets.Method | System.AttributeTargets.Property)]
    public sealed partial class SwitchAttribute : System.Attribute
    {
        public SwitchAttribute(string switchName, System.Type switchType) { }
        public string SwitchDescription { get { throw null; } set { } }
        public string SwitchName { get { throw null; } set { } }
        public System.Type SwitchType { get { throw null; } set { } }
        public static System.Diagnostics.SwitchAttribute[] GetAll(System.Reflection.Assembly assembly) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class SwitchLevelAttribute : System.Attribute
    {
        public SwitchLevelAttribute(System.Type switchLevelType) { }
        public System.Type SwitchLevelType { get { throw null; } set { } }
    }
    public partial class TextWriterTraceListener : System.Diagnostics.TraceListener
    {
        public TextWriterTraceListener() { }
        public TextWriterTraceListener(System.IO.Stream stream) { }
        public TextWriterTraceListener(System.IO.Stream stream, string name) { }
        public TextWriterTraceListener(System.IO.TextWriter writer) { }
        public TextWriterTraceListener(System.IO.TextWriter writer, string name) { }
        public TextWriterTraceListener(string fileName) { }
        public TextWriterTraceListener(string fileName, string name) { }
        public System.IO.TextWriter Writer { get { throw null; } set { } }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        public override void Write(string message) { }
        public override void WriteLine(string message) { }
    }
    public enum ThreadPriorityLevel
    {
        Idle = -15,
        Lowest = -2,
        BelowNormal = -1,
        Normal = 0,
        AboveNormal = 1,
        Highest = 2,
        TimeCritical = 15,
    }
    public enum ThreadState
    {
        Initialized = 0,
        Ready = 1,
        Running = 2,
        Standby = 3,
        Terminated = 4,
        Wait = 5,
        Transition = 6,
        Unknown = 7,
    }
    public enum ThreadWaitReason
    {
        Executive = 0,
        FreePage = 1,
        PageIn = 2,
        SystemAllocation = 3,
        ExecutionDelay = 4,
        Suspended = 5,
        UserRequest = 6,
        EventPairHigh = 7,
        EventPairLow = 8,
        LpcReceive = 9,
        LpcReply = 10,
        VirtualMemory = 11,
        PageOut = 12,
        Unknown = 13,
    }
    public sealed partial class Trace
    {
        internal Trace() { }
        public static bool AutoFlush { get { throw null; } set { } }
        public static System.Diagnostics.CorrelationManager CorrelationManager { get { throw null; } }
        public static int IndentLevel { get { throw null; } set { } }
        public static int IndentSize { get { throw null; } set { } }
        public static System.Diagnostics.TraceListenerCollection Listeners { get { throw null; } }
        public static bool UseGlobalLock { get { throw null; } set { } }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Assert(bool condition) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Assert(bool condition, string message) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Assert(bool condition, string message, string detailMessage) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Close() { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Fail(string message) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Fail(string message, string detailMessage) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Flush() { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Indent() { }
        public static void Refresh() { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void TraceError(string message) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void TraceError(string format, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void TraceInformation(string message) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void TraceInformation(string format, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void TraceWarning(string message) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void TraceWarning(string format, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Unindent() { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Write(object value) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Write(object value, string category) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Write(string message) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void Write(string message, string category) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteIf(bool condition, object value) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteIf(bool condition, object value, string category) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteIf(bool condition, string message) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteIf(bool condition, string message, string category) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteLine(object value) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteLine(object value, string category) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteLine(string message) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteLine(string message, string category) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteLineIf(bool condition, object value) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteLineIf(bool condition, object value, string category) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteLineIf(bool condition, string message) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public static void WriteLineIf(bool condition, string message, string category) { }
    }
    public partial class TraceEventCache
    {
        public TraceEventCache() { }
        public string Callstack { get { throw null; } }
        public System.DateTime DateTime { get { throw null; } }
        public System.Collections.Stack LogicalOperationStack { get { throw null; } }
        public int ProcessId { get { throw null; } }
        public string ThreadId { get { throw null; } }
        public long Timestamp { get { throw null; } }
    }
    public enum TraceEventType
    {
        Critical = 1,
        Error = 2,
        Warning = 4,
        Information = 8,
        Verbose = 16,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Start = 256,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Stop = 512,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Suspend = 1024,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Resume = 2048,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Transfer = 4096,
    }
    public abstract partial class TraceFilter
    {
        protected TraceFilter() { }
        public abstract bool ShouldTrace(System.Diagnostics.TraceEventCache cache, string source, System.Diagnostics.TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);
    }
    public enum TraceLevel
    {
        Off = 0,
        Error = 1,
        Warning = 2,
        Info = 3,
        Verbose = 4,
    }
    public abstract partial class TraceListener : System.MarshalByRefObject, System.IDisposable
    {
        protected TraceListener() { }
        protected TraceListener(string name) { }
        public System.Collections.Specialized.StringDictionary Attributes { get { throw null; } }
        public System.Diagnostics.TraceFilter Filter { get { throw null; } set { } }
        public int IndentLevel { get { throw null; } set { } }
        public int IndentSize { get { throw null; } set { } }
        public virtual bool IsThreadSafe { get { throw null; } }
        public virtual string Name { get { throw null; } set { } }
        protected bool NeedIndent { get { throw null; } set { } }
        public System.Diagnostics.TraceOptions TraceOutputOptions { get { throw null; } set { } }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual void Fail(string message) { }
        public virtual void Fail(string message, string detailMessage) { }
        public virtual void Flush() { }
        protected internal virtual string[] GetSupportedAttributes() { throw null; }
        public virtual void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
        public virtual void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params object[] data) { }
        public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id) { }
        public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
        public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args) { }
        public virtual void TraceTransfer(System.Diagnostics.TraceEventCache eventCache, string source, int id, string message, System.Guid relatedActivityId) { }
        public virtual void Write(object o) { }
        public virtual void Write(object o, string category) { }
        public abstract void Write(string message);
        public virtual void Write(string message, string category) { }
        protected virtual void WriteIndent() { }
        public virtual void WriteLine(object o) { }
        public virtual void WriteLine(object o, string category) { }
        public abstract void WriteLine(string message);
        public virtual void WriteLine(string message, string category) { }
    }
    public partial class TraceListenerCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        internal TraceListenerCollection() { }
        public int Count { get { throw null; } }
        public System.Diagnostics.TraceListener this[int i] { get { throw null; } set { } }
        public System.Diagnostics.TraceListener this[string name] { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public int Add(System.Diagnostics.TraceListener listener) { throw null; }
        public void AddRange(System.Diagnostics.TraceListenerCollection value) { }
        public void AddRange(System.Diagnostics.TraceListener[] value) { }
        public void Clear() { }
        public bool Contains(System.Diagnostics.TraceListener listener) { throw null; }
        public void CopyTo(System.Diagnostics.TraceListener[] listeners, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.Diagnostics.TraceListener listener) { throw null; }
        public void Insert(int index, System.Diagnostics.TraceListener listener) { }
        public void Remove(System.Diagnostics.TraceListener listener) { }
        public void Remove(string name) { }
        public void RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        int System.Collections.IList.Add(object value) { throw null; }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
    }
    [System.FlagsAttribute]
    public enum TraceOptions
    {
        None = 0,
        LogicalOperationStack = 1,
        DateTime = 2,
        Timestamp = 4,
        ProcessId = 8,
        ThreadId = 16,
        Callstack = 32,
    }
    public partial class TraceSource
    {
        public TraceSource(string name) { }
        public TraceSource(string name, System.Diagnostics.SourceLevels defaultLevel) { }
        public System.Collections.Specialized.StringDictionary Attributes { get { throw null; } }
        public System.Diagnostics.TraceListenerCollection Listeners { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Diagnostics.SourceSwitch Switch { get { throw null; } set { } }
        public void Close() { }
        public void Flush() { }
        protected internal virtual string[] GetSupportedAttributes() { throw null; }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public void TraceData(System.Diagnostics.TraceEventType eventType, int id, object data) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public void TraceData(System.Diagnostics.TraceEventType eventType, int id, params object[] data) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public void TraceEvent(System.Diagnostics.TraceEventType eventType, int id) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public void TraceEvent(System.Diagnostics.TraceEventType eventType, int id, string message) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public void TraceEvent(System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public void TraceInformation(string message) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public void TraceInformation(string format, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("TRACE")]
        public void TraceTransfer(int id, string message, System.Guid relatedActivityId) { }
    }
    [System.Diagnostics.SwitchLevelAttribute(typeof(System.Diagnostics.TraceLevel))]
    public partial class TraceSwitch : System.Diagnostics.Switch
    {
        public TraceSwitch(string displayName, string description) : base (default(string), default(string)) { }
        public TraceSwitch(string displayName, string description, string defaultSwitchValue) : base (default(string), default(string)) { }
        public System.Diagnostics.TraceLevel Level { get { throw null; } set { } }
        public bool TraceError { get { throw null; } }
        public bool TraceInfo { get { throw null; } }
        public bool TraceVerbose { get { throw null; } }
        public bool TraceWarning { get { throw null; } }
        protected override void OnSwitchSettingChanged() { }
        protected override void OnValueChanged() { }
    }
}
namespace System.Diagnostics.CodeAnalysis
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Event | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Struct, Inherited=false, AllowMultiple=false)]
    public sealed partial class ExcludeFromCodeCoverageAttribute : System.Attribute
    {
        public ExcludeFromCodeCoverageAttribute() { }
    }
}
namespace System.IO
{
    public partial class ErrorEventArgs : System.EventArgs
    {
        public ErrorEventArgs(System.Exception exception) { }
        public virtual System.Exception GetException() { throw null; }
    }
    public delegate void ErrorEventHandler(object sender, System.IO.ErrorEventArgs e);
    public partial class FileSystemEventArgs : System.EventArgs
    {
        public FileSystemEventArgs(System.IO.WatcherChangeTypes changeType, string directory, string name) { }
        public System.IO.WatcherChangeTypes ChangeType { get { throw null; } }
        public string FullPath { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public delegate void FileSystemEventHandler(object sender, System.IO.FileSystemEventArgs e);
    [System.ComponentModel.DefaultEventAttribute("Changed")]
    public partial class FileSystemWatcher : System.ComponentModel.Component, System.ComponentModel.ISupportInitialize
    {
        public FileSystemWatcher() { }
        public FileSystemWatcher(string path) { }
        public FileSystemWatcher(string path, string filter) { }
        public bool EnableRaisingEvents { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<string> Filters { get { throw null; } }
        public bool IncludeSubdirectories { get { throw null; } set { } }
        public int InternalBufferSize { get { throw null; } set { } }
        public System.IO.NotifyFilters NotifyFilter { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public override System.ComponentModel.ISite Site { get { throw null; } set { } }
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        public event System.IO.FileSystemEventHandler Changed { add { } remove { } }
        public event System.IO.FileSystemEventHandler Created { add { } remove { } }
        public event System.IO.FileSystemEventHandler Deleted { add { } remove { } }
        public event System.IO.ErrorEventHandler Error { add { } remove { } }
        public event System.IO.RenamedEventHandler Renamed { add { } remove { } }
        public void BeginInit() { }
        protected override void Dispose(bool disposing) { }
        public void EndInit() { }
        protected void OnChanged(System.IO.FileSystemEventArgs e) { }
        protected void OnCreated(System.IO.FileSystemEventArgs e) { }
        protected void OnDeleted(System.IO.FileSystemEventArgs e) { }
        protected void OnError(System.IO.ErrorEventArgs e) { }
        protected void OnRenamed(System.IO.RenamedEventArgs e) { }
        public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType) { throw null; }
        public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType, int timeout) { throw null; }
    }
    public partial class InternalBufferOverflowException : System.SystemException
    {
        public InternalBufferOverflowException() { }
        protected InternalBufferOverflowException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InternalBufferOverflowException(string message) { }
        public InternalBufferOverflowException(string message, System.Exception inner) { }
    }
    public sealed partial class InvalidDataException : System.SystemException
    {
        public InvalidDataException() { }
        public InvalidDataException(string message) { }
        public InvalidDataException(string message, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public partial class IODescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        public IODescriptionAttribute(string description) { }
        public override string Description { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum NotifyFilters
    {
        FileName = 1,
        DirectoryName = 2,
        Attributes = 4,
        Size = 8,
        LastWrite = 16,
        LastAccess = 32,
        CreationTime = 64,
        Security = 256,
    }
    public partial class RenamedEventArgs : System.IO.FileSystemEventArgs
    {
        public RenamedEventArgs(System.IO.WatcherChangeTypes changeType, string directory, string name, string oldName) : base (default(System.IO.WatcherChangeTypes), default(string), default(string)) { }
        public string OldFullPath { get { throw null; } }
        public string OldName { get { throw null; } }
    }
    public delegate void RenamedEventHandler(object sender, System.IO.RenamedEventArgs e);
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct WaitForChangedResult
    {
        private object _dummy;
        private int _dummyPrimitive;
        public System.IO.WatcherChangeTypes ChangeType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string OldName { get { throw null; } set { } }
        public bool TimedOut { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum WatcherChangeTypes
    {
        Created = 1,
        Deleted = 2,
        Changed = 4,
        Renamed = 8,
        All = 15,
    }
}
namespace System.IO.Compression
{
    public enum CompressionLevel
    {
        Optimal = 0,
        Fastest = 1,
        NoCompression = 2,
    }
    public enum CompressionMode
    {
        Decompress = 0,
        Compress = 1,
    }
    public partial class DeflateStream : System.IO.Stream
    {
        public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel) { }
        public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, bool leaveOpen) { }
        public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode) { }
        public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen) { }
        public System.IO.Stream BaseStream { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        ~DeflateStream() { }
        public override void Flush() { }
        public override int Read(byte[] array, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] array, int offset, int count) { }
    }
    public partial class GZipStream : System.IO.Stream
    {
        public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel) { }
        public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, bool leaveOpen) { }
        public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode) { }
        public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen) { }
        public System.IO.Stream BaseStream { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public override void CopyTo(System.IO.Stream destination, int bufferSize) { }
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] array, int offset, int count) { throw null; }
        public override int Read(System.Span<byte> buffer) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] array, int offset, int count) { }
        public override void Write(System.ReadOnlySpan<byte> buffer) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace System.Net
{
    public partial class AuthenticationManager
    {
        internal AuthenticationManager() { }
        public static System.Net.ICredentialPolicy CredentialPolicy { get { throw null; } set { } }
        public static System.Collections.Specialized.StringDictionary CustomTargetNameDictionary { get { throw null; } }
        public static System.Collections.IEnumerator RegisteredModules { get { throw null; } }
        public static System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials) { throw null; }
        public static System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials) { throw null; }
        public static void Register(System.Net.IAuthenticationModule authenticationModule) { }
        public static void Unregister(System.Net.IAuthenticationModule authenticationModule) { }
        public static void Unregister(string authenticationScheme) { }
    }
    [System.FlagsAttribute]
    public enum AuthenticationSchemes
    {
        None = 0,
        Digest = 1,
        Negotiate = 2,
        Ntlm = 4,
        IntegratedWindowsAuthentication = 6,
        Basic = 8,
        Anonymous = 32768,
    }
    public delegate System.Net.AuthenticationSchemes AuthenticationSchemeSelector(System.Net.HttpListenerRequest httpRequest);
    public partial class Authorization
    {
        public Authorization(string token) { }
        public Authorization(string token, bool finished) { }
        public Authorization(string token, bool finished, string connectionGroupId) { }
        public bool Complete { get { throw null; } }
        public string ConnectionGroupId { get { throw null; } }
        public string Message { get { throw null; } }
        public bool MutuallyAuthenticated { get { throw null; } set { } }
        public string[] ProtectionRealm { get { throw null; } set { } }
    }
    public delegate System.Net.IPEndPoint BindIPEndPoint(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount);
    public sealed partial class Cookie
    {
        public Cookie() { }
        public Cookie(string name, string value) { }
        public Cookie(string name, string value, string path) { }
        public Cookie(string name, string value, string path, string domain) { }
        public string Comment { get { throw null; } set { } }
        public System.Uri CommentUri { get { throw null; } set { } }
        public bool Discard { get { throw null; } set { } }
        public string Domain { get { throw null; } set { } }
        public bool Expired { get { throw null; } set { } }
        public System.DateTime Expires { get { throw null; } set { } }
        public bool HttpOnly { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string Port { get { throw null; } set { } }
        public bool Secure { get { throw null; } set { } }
        public System.DateTime TimeStamp { get { throw null; } }
        public string Value { get { throw null; } set { } }
        public int Version { get { throw null; } set { } }
        public override bool Equals(object comparand) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CookieCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public CookieCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Net.Cookie this[int index] { get { throw null; } }
        public System.Net.Cookie this[string name] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public void Add(System.Net.Cookie cookie) { }
        public void Add(System.Net.CookieCollection cookies) { }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Net.Cookie[] array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    public partial class CookieContainer
    {
        public const int DefaultCookieLengthLimit = 4096;
        public const int DefaultCookieLimit = 300;
        public const int DefaultPerDomainCookieLimit = 20;
        public CookieContainer() { }
        public CookieContainer(int capacity) { }
        public CookieContainer(int capacity, int perDomainCapacity, int maxCookieSize) { }
        public int Capacity { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public int MaxCookieSize { get { throw null; } set { } }
        public int PerDomainCapacity { get { throw null; } set { } }
        public void Add(System.Net.Cookie cookie) { }
        public void Add(System.Net.CookieCollection cookies) { }
        public void Add(System.Uri uri, System.Net.Cookie cookie) { }
        public void Add(System.Uri uri, System.Net.CookieCollection cookies) { }
        public string GetCookieHeader(System.Uri uri) { throw null; }
        public System.Net.CookieCollection GetCookies(System.Uri uri) { throw null; }
        public void SetCookies(System.Uri uri, string cookieHeader) { }
    }
    public partial class CookieException : System.FormatException, System.Runtime.Serialization.ISerializable
    {
        public CookieException() { }
        protected CookieException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public partial class CredentialCache : System.Collections.IEnumerable, System.Net.ICredentials, System.Net.ICredentialsByHost
    {
        public CredentialCache() { }
        public static System.Net.ICredentials DefaultCredentials { get { throw null; } }
        public static System.Net.NetworkCredential DefaultNetworkCredentials { get { throw null; } }
        public void Add(string host, int port, string authenticationType, System.Net.NetworkCredential credential) { }
        public void Add(System.Uri uriPrefix, string authType, System.Net.NetworkCredential cred) { }
        public System.Net.NetworkCredential GetCredential(string host, int port, string authenticationType) { throw null; }
        public System.Net.NetworkCredential GetCredential(System.Uri uriPrefix, string authType) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public void Remove(string host, int port, string authenticationType) { }
        public void Remove(System.Uri uriPrefix, string authType) { }
    }
    [System.FlagsAttribute]
    public enum DecompressionMethods
    {
        None = 0,
        GZip = 1,
        Deflate = 2,
    }
    public static partial class Dns
    {
        public static System.IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, System.AsyncCallback requestCallback, object state) { throw null; }
        [System.ObsoleteAttribute("Use BeginGetHostEntry instead")]
        public static System.IAsyncResult BeginGetHostByName(string hostName, System.AsyncCallback requestCallback, object stateObject) { throw null; }
        public static System.IAsyncResult BeginGetHostEntry(System.Net.IPAddress address, System.AsyncCallback requestCallback, object stateObject) { throw null; }
        public static System.IAsyncResult BeginGetHostEntry(string hostNameOrAddress, System.AsyncCallback requestCallback, object stateObject) { throw null; }
        [System.ObsoleteAttribute("Use BeginGetHostEntry instead")]
        public static System.IAsyncResult BeginResolve(string hostName, System.AsyncCallback requestCallback, object stateObject) { throw null; }
        public static System.Net.IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult) { throw null; }
        [System.ObsoleteAttribute("Use EndGetHostEntry instead")]
        public static System.Net.IPHostEntry EndGetHostByName(System.IAsyncResult asyncResult) { throw null; }
        public static System.Net.IPHostEntry EndGetHostEntry(System.IAsyncResult asyncResult) { throw null; }
        [System.ObsoleteAttribute("Use EndGetHostEntry instead")]
        public static System.Net.IPHostEntry EndResolve(System.IAsyncResult asyncResult) { throw null; }
        public static System.Net.IPAddress[] GetHostAddresses(string hostNameOrAddress) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { throw null; }
        [System.ObsoleteAttribute("Use GetHostEntry instead")]
        public static System.Net.IPHostEntry GetHostByAddress(System.Net.IPAddress address) { throw null; }
        [System.ObsoleteAttribute("Use GetHostEntry instead")]
        public static System.Net.IPHostEntry GetHostByAddress(string address) { throw null; }
        [System.ObsoleteAttribute("Use GetHostEntry instead")]
        public static System.Net.IPHostEntry GetHostByName(string hostName) { throw null; }
        public static System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address) { throw null; }
        public static System.Net.IPHostEntry GetHostEntry(string hostNameOrAddress) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.IPHostEntry> GetHostEntryAsync(System.Net.IPAddress address) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.IPHostEntry> GetHostEntryAsync(string hostNameOrAddress) { throw null; }
        public static string GetHostName() { throw null; }
        [System.ObsoleteAttribute("Use GetHostEntry instead")]
        public static System.Net.IPHostEntry Resolve(string hostName) { throw null; }
    }
    public partial class DnsEndPoint : System.Net.EndPoint
    {
        public DnsEndPoint(string host, int port) { }
        public DnsEndPoint(string host, int port, System.Net.Sockets.AddressFamily addressFamily) { }
        public override System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public string Host { get { throw null; } }
        public int Port { get { throw null; } }
        public override bool Equals(object comparand) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DownloadDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal DownloadDataCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public byte[] Result { get { throw null; } }
    }
    public delegate void DownloadDataCompletedEventHandler(object sender, System.Net.DownloadDataCompletedEventArgs e);
    public partial class DownloadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
    {
        internal DownloadProgressChangedEventArgs() : base (default(int), default(object)) { }
        public long BytesReceived { get { throw null; } }
        public long TotalBytesToReceive { get { throw null; } }
    }
    public delegate void DownloadProgressChangedEventHandler(object sender, System.Net.DownloadProgressChangedEventArgs e);
    public partial class DownloadStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal DownloadStringCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public string Result { get { throw null; } }
    }
    public delegate void DownloadStringCompletedEventHandler(object sender, System.Net.DownloadStringCompletedEventArgs e);
    public abstract partial class EndPoint
    {
        protected EndPoint() { }
        public virtual System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public virtual System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { throw null; }
        public virtual System.Net.SocketAddress Serialize() { throw null; }
    }
    public partial class EndpointPermission
    {
        internal EndpointPermission() { }
        public string Hostname { get { throw null; } }
        public int Port { get { throw null; } }
        public System.Net.TransportType Transport { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FileWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
    {
        [System.ObsoleteAttribute("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected FileWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override string ConnectionGroupName { get { throw null; } set { } }
        public override long ContentLength { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override System.Net.ICredentials Credentials { get { throw null; } set { } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } }
        public override string Method { get { throw null; } set { } }
        public override bool PreAuthenticate { get { throw null; } set { } }
        public override System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public override System.Uri RequestUri { get { throw null; } }
        public override int Timeout { get { throw null; } set { } }
        public override bool UseDefaultCredentials { get { throw null; } set { } }
        public override void Abort() { }
        public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { throw null; }
        public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { throw null; }
        public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { throw null; }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override System.IO.Stream GetRequestStream() { throw null; }
        public override System.Net.WebResponse GetResponse() { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public partial class FileWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable
    {
        [System.ObsoleteAttribute("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected FileWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override long ContentLength { get { throw null; } }
        public override string ContentType { get { throw null; } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } }
        public override System.Uri ResponseUri { get { throw null; } }
        public override bool SupportsHeaders { get { throw null; } }
        public override void Close() { }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override System.IO.Stream GetResponseStream() { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public enum FtpStatusCode
    {
        Undefined = 0,
        RestartMarker = 110,
        ServiceTemporarilyNotAvailable = 120,
        DataAlreadyOpen = 125,
        OpeningData = 150,
        CommandOK = 200,
        CommandExtraneous = 202,
        DirectoryStatus = 212,
        FileStatus = 213,
        SystemType = 215,
        SendUserCommand = 220,
        ClosingControl = 221,
        ClosingData = 226,
        EnteringPassive = 227,
        LoggedInProceed = 230,
        ServerWantsSecureSession = 234,
        FileActionOK = 250,
        PathnameCreated = 257,
        SendPasswordCommand = 331,
        NeedLoginAccount = 332,
        FileCommandPending = 350,
        ServiceNotAvailable = 421,
        CantOpenData = 425,
        ConnectionClosed = 426,
        ActionNotTakenFileUnavailableOrBusy = 450,
        ActionAbortedLocalProcessingError = 451,
        ActionNotTakenInsufficientSpace = 452,
        CommandSyntaxError = 500,
        ArgumentSyntaxError = 501,
        CommandNotImplemented = 502,
        BadCommandSequence = 503,
        NotLoggedIn = 530,
        AccountNeeded = 532,
        ActionNotTakenFileUnavailable = 550,
        ActionAbortedUnknownPageType = 551,
        FileActionAborted = 552,
        ActionNotTakenFilenameNotAllowed = 553,
    }
    public sealed partial class FtpWebRequest : System.Net.WebRequest
    {
        internal FtpWebRequest() { }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } set { } }
        public override string ConnectionGroupName { get { throw null; } set { } }
        public override long ContentLength { get { throw null; } set { } }
        public long ContentOffset { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override System.Net.ICredentials Credentials { get { throw null; } set { } }
        public bool EnableSsl { get { throw null; } set { } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } set { } }
        public bool KeepAlive { get { throw null; } set { } }
        public override string Method { get { throw null; } set { } }
        public override bool PreAuthenticate { get { throw null; } set { } }
        public override System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public int ReadWriteTimeout { get { throw null; } set { } }
        public string RenameTo { get { throw null; } set { } }
        public override System.Uri RequestUri { get { throw null; } }
        public System.Net.ServicePoint ServicePoint { get { throw null; } }
        public override int Timeout { get { throw null; } set { } }
        public bool UseBinary { get { throw null; } set { } }
        public override bool UseDefaultCredentials { get { throw null; } set { } }
        public bool UsePassive { get { throw null; } set { } }
        public override void Abort() { }
        public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { throw null; }
        public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { throw null; }
        public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { throw null; }
        public override System.IO.Stream GetRequestStream() { throw null; }
        public override System.Net.WebResponse GetResponse() { throw null; }
    }
    public partial class FtpWebResponse : System.Net.WebResponse
    {
        internal FtpWebResponse() { }
        public string BannerMessage { get { throw null; } }
        public override long ContentLength { get { throw null; } }
        public string ExitMessage { get { throw null; } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } }
        public System.DateTime LastModified { get { throw null; } }
        public override System.Uri ResponseUri { get { throw null; } }
        public System.Net.FtpStatusCode StatusCode { get { throw null; } }
        public string StatusDescription { get { throw null; } }
        public override bool SupportsHeaders { get { throw null; } }
        public string WelcomeMessage { get { throw null; } }
        public override void Close() { }
        public override System.IO.Stream GetResponseStream() { throw null; }
    }
    [System.ObsoleteAttribute("This class has been deprecated. Please use WebRequest.DefaultWebProxy instead to access and set the global default proxy. Use 'null' instead of GetEmptyWebProxy. https://go.microsoft.com/fwlink/?linkid=14202")]
    public partial class GlobalProxySelection
    {
        public GlobalProxySelection() { }
        public static System.Net.IWebProxy Select { get { throw null; } set { } }
        public static System.Net.IWebProxy GetEmptyWebProxy() { throw null; }
    }
    public delegate void HttpContinueDelegate(int StatusCode, System.Net.WebHeaderCollection httpHeaders);
    public sealed partial class HttpListener : System.IDisposable
    {
        public HttpListener() { }
        public System.Net.AuthenticationSchemes AuthenticationSchemes { get { throw null; } set { } }
        public System.Net.AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate { get { throw null; } set { } }
        public System.Security.Authentication.ExtendedProtection.ServiceNameCollection DefaultServiceNames { get { throw null; } }
        public System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy ExtendedProtectionPolicy { get { throw null; } set { } }
        public System.Net.HttpListener.ExtendedProtectionSelector ExtendedProtectionSelectorDelegate { get { throw null; } set { } }
        public bool IgnoreWriteExceptions { get { throw null; } set { } }
        public bool IsListening { get { throw null; } }
        public static bool IsSupported { get { throw null; } }
        public System.Net.HttpListenerPrefixCollection Prefixes { get { throw null; } }
        public string Realm { get { throw null; } set { } }
        public System.Net.HttpListenerTimeoutManager TimeoutManager { get { throw null; } }
        public bool UnsafeConnectionNtlmAuthentication { get { throw null; } set { } }
        public void Abort() { }
        public System.IAsyncResult BeginGetContext(System.AsyncCallback callback, object state) { throw null; }
        public void Close() { }
        public System.Net.HttpListenerContext EndGetContext(System.IAsyncResult asyncResult) { throw null; }
        public System.Net.HttpListenerContext GetContext() { throw null; }
        public System.Threading.Tasks.Task<System.Net.HttpListenerContext> GetContextAsync() { throw null; }
        public void Start() { }
        public void Stop() { }
        void System.IDisposable.Dispose() { }
        public delegate System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy ExtendedProtectionSelector(System.Net.HttpListenerRequest request);
    }
    public partial class HttpListenerBasicIdentity : System.Security.Principal.GenericIdentity
    {
        public HttpListenerBasicIdentity(string username, string password) : base (default(string)) { }
        public virtual string Password { get { throw null; } }
    }
    public sealed partial class HttpListenerContext
    {
        internal HttpListenerContext() { }
        public System.Net.HttpListenerRequest Request { get { throw null; } }
        public System.Net.HttpListenerResponse Response { get { throw null; } }
        public System.Security.Principal.IPrincipal User { get { throw null; } }
        public System.Threading.Tasks.Task<System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol) { throw null; }
        public System.Threading.Tasks.Task<System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, System.TimeSpan keepAliveInterval) { throw null; }
        public System.Threading.Tasks.Task<System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, System.TimeSpan keepAliveInterval, System.ArraySegment<byte> internalBuffer) { throw null; }
        public System.Threading.Tasks.Task<System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, System.TimeSpan keepAliveInterval) { throw null; }
    }
    public partial class HttpListenerException : System.ComponentModel.Win32Exception
    {
        public HttpListenerException() { }
        public HttpListenerException(int errorCode) { }
        public HttpListenerException(int errorCode, string message) { }
        protected HttpListenerException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override int ErrorCode { get { throw null; } }
    }
    public partial class HttpListenerPrefixCollection : System.Collections.Generic.ICollection<string>, System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable
    {
        internal HttpListenerPrefixCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public void Add(string uriPrefix) { }
        public void Clear() { }
        public bool Contains(string uriPrefix) { throw null; }
        public void CopyTo(System.Array array, int offset) { }
        public void CopyTo(string[] array, int offset) { }
        public System.Collections.Generic.IEnumerator<string> GetEnumerator() { throw null; }
        public bool Remove(string uriPrefix) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class HttpListenerRequest
    {
        internal HttpListenerRequest() { }
        public string[] AcceptTypes { get { throw null; } }
        public int ClientCertificateError { get { throw null; } }
        public System.Text.Encoding ContentEncoding { get { throw null; } }
        public long ContentLength64 { get { throw null; } }
        public string ContentType { get { throw null; } }
        public System.Net.CookieCollection Cookies { get { throw null; } }
        public bool HasEntityBody { get { throw null; } }
        public System.Collections.Specialized.NameValueCollection Headers { get { throw null; } }
        public string HttpMethod { get { throw null; } }
        public System.IO.Stream InputStream { get { throw null; } }
        public bool IsAuthenticated { get { throw null; } }
        public bool IsLocal { get { throw null; } }
        public bool IsSecureConnection { get { throw null; } }
        public bool IsWebSocketRequest { get { throw null; } }
        public bool KeepAlive { get { throw null; } }
        public System.Net.IPEndPoint LocalEndPoint { get { throw null; } }
        public System.Version ProtocolVersion { get { throw null; } }
        public System.Collections.Specialized.NameValueCollection QueryString { get { throw null; } }
        public string RawUrl { get { throw null; } }
        public System.Net.IPEndPoint RemoteEndPoint { get { throw null; } }
        public System.Guid RequestTraceIdentifier { get { throw null; } }
        public string ServiceName { get { throw null; } }
        public System.Net.TransportContext TransportContext { get { throw null; } }
        public System.Uri Url { get { throw null; } }
        public System.Uri UrlReferrer { get { throw null; } }
        public string UserAgent { get { throw null; } }
        public string UserHostAddress { get { throw null; } }
        public string UserHostName { get { throw null; } }
        public string[] UserLanguages { get { throw null; } }
        public System.IAsyncResult BeginGetClientCertificate(System.AsyncCallback requestCallback, object state) { throw null; }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 EndGetClientCertificate(System.IAsyncResult asyncResult) { throw null; }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 GetClientCertificate() { throw null; }
        public System.Threading.Tasks.Task<System.Security.Cryptography.X509Certificates.X509Certificate2> GetClientCertificateAsync() { throw null; }
    }
    public sealed partial class HttpListenerResponse : System.IDisposable
    {
        internal HttpListenerResponse() { }
        public System.Text.Encoding ContentEncoding { get { throw null; } set { } }
        public long ContentLength64 { get { throw null; } set { } }
        public string ContentType { get { throw null; } set { } }
        public System.Net.CookieCollection Cookies { get { throw null; } set { } }
        public System.Net.WebHeaderCollection Headers { get { throw null; } set { } }
        public bool KeepAlive { get { throw null; } set { } }
        public System.IO.Stream OutputStream { get { throw null; } }
        public System.Version ProtocolVersion { get { throw null; } set { } }
        public string RedirectLocation { get { throw null; } set { } }
        public bool SendChunked { get { throw null; } set { } }
        public int StatusCode { get { throw null; } set { } }
        public string StatusDescription { get { throw null; } set { } }
        public void Abort() { }
        public void AddHeader(string name, string value) { }
        public void AppendCookie(System.Net.Cookie cookie) { }
        public void AppendHeader(string name, string value) { }
        public void Close() { }
        public void Close(byte[] responseEntity, bool willBlock) { }
        public void CopyFrom(System.Net.HttpListenerResponse templateResponse) { }
        public void Redirect(string url) { }
        public void SetCookie(System.Net.Cookie cookie) { }
        void System.IDisposable.Dispose() { }
    }
    public partial class HttpListenerTimeoutManager
    {
        public HttpListenerTimeoutManager() { }
        public System.TimeSpan DrainEntityBody { get { throw null; } set { } }
        public System.TimeSpan EntityBody { get { throw null; } set { } }
        public System.TimeSpan HeaderWait { get { throw null; } set { } }
        public System.TimeSpan IdleConnection { get { throw null; } set { } }
        public long MinSendBytesPerSecond { get { throw null; } set { } }
        public System.TimeSpan RequestQueue { get { throw null; } set { } }
    }
    public enum HttpRequestHeader
    {
        CacheControl = 0,
        Connection = 1,
        Date = 2,
        KeepAlive = 3,
        Pragma = 4,
        Trailer = 5,
        TransferEncoding = 6,
        Upgrade = 7,
        Via = 8,
        Warning = 9,
        Allow = 10,
        ContentLength = 11,
        ContentType = 12,
        ContentEncoding = 13,
        ContentLanguage = 14,
        ContentLocation = 15,
        ContentMd5 = 16,
        ContentRange = 17,
        Expires = 18,
        LastModified = 19,
        Accept = 20,
        AcceptCharset = 21,
        AcceptEncoding = 22,
        AcceptLanguage = 23,
        Authorization = 24,
        Cookie = 25,
        Expect = 26,
        From = 27,
        Host = 28,
        IfMatch = 29,
        IfModifiedSince = 30,
        IfNoneMatch = 31,
        IfRange = 32,
        IfUnmodifiedSince = 33,
        MaxForwards = 34,
        ProxyAuthorization = 35,
        Referer = 36,
        Range = 37,
        Te = 38,
        Translate = 39,
        UserAgent = 40,
    }
    public enum HttpResponseHeader
    {
        CacheControl = 0,
        Connection = 1,
        Date = 2,
        KeepAlive = 3,
        Pragma = 4,
        Trailer = 5,
        TransferEncoding = 6,
        Upgrade = 7,
        Via = 8,
        Warning = 9,
        Allow = 10,
        ContentLength = 11,
        ContentType = 12,
        ContentEncoding = 13,
        ContentLanguage = 14,
        ContentLocation = 15,
        ContentMd5 = 16,
        ContentRange = 17,
        Expires = 18,
        LastModified = 19,
        AcceptRanges = 20,
        Age = 21,
        ETag = 22,
        Location = 23,
        ProxyAuthenticate = 24,
        RetryAfter = 25,
        Server = 26,
        SetCookie = 27,
        Vary = 28,
        WwwAuthenticate = 29,
    }
    public enum HttpStatusCode
    {
        Continue = 100,
        SwitchingProtocols = 101,
        Processing = 102,
        EarlyHints = 103,
        OK = 200,
        Created = 201,
        Accepted = 202,
        NonAuthoritativeInformation = 203,
        NoContent = 204,
        ResetContent = 205,
        PartialContent = 206,
        MultiStatus = 207,
        AlreadyReported = 208,
        IMUsed = 226,
        Ambiguous = 300,
        MultipleChoices = 300,
        Moved = 301,
        MovedPermanently = 301,
        Found = 302,
        Redirect = 302,
        RedirectMethod = 303,
        SeeOther = 303,
        NotModified = 304,
        UseProxy = 305,
        Unused = 306,
        RedirectKeepVerb = 307,
        TemporaryRedirect = 307,
        PermanentRedirect = 308,
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        NotAcceptable = 406,
        ProxyAuthenticationRequired = 407,
        RequestTimeout = 408,
        Conflict = 409,
        Gone = 410,
        LengthRequired = 411,
        PreconditionFailed = 412,
        RequestEntityTooLarge = 413,
        RequestUriTooLong = 414,
        UnsupportedMediaType = 415,
        RequestedRangeNotSatisfiable = 416,
        ExpectationFailed = 417,
        MisdirectedRequest = 421,
        UnprocessableEntity = 422,
        Locked = 423,
        FailedDependency = 424,
        UpgradeRequired = 426,
        PreconditionRequired = 428,
        TooManyRequests = 429,
        RequestHeaderFieldsTooLarge = 431,
        UnavailableForLegalReasons = 451,
        InternalServerError = 500,
        NotImplemented = 501,
        BadGateway = 502,
        ServiceUnavailable = 503,
        GatewayTimeout = 504,
        HttpVersionNotSupported = 505,
        VariantAlsoNegotiates = 506,
        InsufficientStorage = 507,
        LoopDetected = 508,
        NotExtended = 510,
        NetworkAuthenticationRequired = 511,
    }
    public partial class HttpVersion
    {
        public static readonly System.Version Unknown;
        public static readonly System.Version Version10;
        public static readonly System.Version Version11;
        public static readonly System.Version Version20;
        public HttpVersion() { }
    }
    public partial class HttpWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
    {
        protected HttpWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public HttpWebRequest(System.Uri uri) { }
        public string Accept { get { throw null; } set { } }
        public System.Uri Address { get { throw null; } }
        public virtual bool AllowAutoRedirect { get { throw null; } set { } }
        public virtual bool AllowReadStreamBuffering { get { throw null; } set { } }
        public virtual bool AllowWriteStreamBuffering { get { throw null; } set { } }
        public System.Net.DecompressionMethods AutomaticDecompression { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } set { } }
        public string Connection { get { throw null; } set { } }
        public override string ConnectionGroupName { get { throw null; } set { } }
        public override long ContentLength { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public System.Net.HttpContinueDelegate ContinueDelegate { get { throw null; } set { } }
        public int ContinueTimeout { get { throw null; } set { } }
        public virtual System.Net.CookieContainer CookieContainer { get { throw null; } set { } }
        public override System.Net.ICredentials Credentials { get { throw null; } set { } }
        public System.DateTime Date { get { throw null; } set { } }
        public static int DefaultMaximumErrorResponseLength { get { throw null; } set { } }
        public static int DefaultMaximumResponseHeadersLength { get { throw null; } set { } }
        public string Expect { get { throw null; } set { } }
        public virtual bool HaveResponse { get { throw null; } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public System.DateTime IfModifiedSince { get { throw null; } set { } }
        public bool KeepAlive { get { throw null; } set { } }
        public int MaximumAutomaticRedirections { get { throw null; } set { } }
        public int MaximumResponseHeadersLength { get { throw null; } set { } }
        public string MediaType { get { throw null; } set { } }
        public override string Method { get { throw null; } set { } }
        public bool Pipelined { get { throw null; } set { } }
        public override bool PreAuthenticate { get { throw null; } set { } }
        public System.Version ProtocolVersion { get { throw null; } set { } }
        public override System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public int ReadWriteTimeout { get { throw null; } set { } }
        public string Referer { get { throw null; } set { } }
        public override System.Uri RequestUri { get { throw null; } }
        public bool SendChunked { get { throw null; } set { } }
        public System.Net.Security.RemoteCertificateValidationCallback ServerCertificateValidationCallback { get { throw null; } set { } }
        public System.Net.ServicePoint ServicePoint { get { throw null; } }
        public virtual bool SupportsCookieContainer { get { throw null; } }
        public override int Timeout { get { throw null; } set { } }
        public string TransferEncoding { get { throw null; } set { } }
        public bool UnsafeAuthenticatedConnectionSharing { get { throw null; } set { } }
        public override bool UseDefaultCredentials { get { throw null; } set { } }
        public string UserAgent { get { throw null; } set { } }
        public override void Abort() { }
        public void AddRange(int range) { }
        public void AddRange(int from, int to) { }
        public void AddRange(long range) { }
        public void AddRange(long from, long to) { }
        public void AddRange(string rangeSpecifier, int range) { }
        public void AddRange(string rangeSpecifier, int from, int to) { }
        public void AddRange(string rangeSpecifier, long range) { }
        public void AddRange(string rangeSpecifier, long from, long to) { }
        public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { throw null; }
        public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { throw null; }
        public System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult, out System.Net.TransportContext transportContext) { throw null; }
        public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { throw null; }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override System.IO.Stream GetRequestStream() { throw null; }
        public System.IO.Stream GetRequestStream(out System.Net.TransportContext context) { throw null; }
        public override System.Net.WebResponse GetResponse() { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public partial class HttpWebResponse : System.Net.WebResponse, System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        public HttpWebResponse() { }
        [System.ObsoleteAttribute("Serialization is obsoleted for this type", false)]
        protected HttpWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public string CharacterSet { get { throw null; } }
        public string ContentEncoding { get { throw null; } }
        public override long ContentLength { get { throw null; } }
        public override string ContentType { get { throw null; } }
        public virtual System.Net.CookieCollection Cookies { get { throw null; } set { } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } }
        public override bool IsMutuallyAuthenticated { get { throw null; } }
        public System.DateTime LastModified { get { throw null; } }
        public virtual string Method { get { throw null; } }
        public System.Version ProtocolVersion { get { throw null; } }
        public override System.Uri ResponseUri { get { throw null; } }
        public string Server { get { throw null; } }
        public virtual System.Net.HttpStatusCode StatusCode { get { throw null; } }
        public virtual string StatusDescription { get { throw null; } }
        public override bool SupportsHeaders { get { throw null; } }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public string GetResponseHeader(string headerName) { throw null; }
        public override System.IO.Stream GetResponseStream() { throw null; }
        void System.IDisposable.Dispose() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public partial interface IAuthenticationModule
    {
        string AuthenticationType { get; }
        bool CanPreAuthenticate { get; }
        System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
        System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
    }
    public partial interface ICertificatePolicy
    {
        bool CheckValidationResult(System.Net.ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, int certificateProblem);
    }
    public partial interface ICredentialPolicy
    {
        bool ShouldSendCredential(System.Uri challengeUri, System.Net.WebRequest request, System.Net.NetworkCredential credential, System.Net.IAuthenticationModule authenticationModule);
    }
    public partial interface ICredentials
    {
        System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
    }
    public partial interface ICredentialsByHost
    {
        System.Net.NetworkCredential GetCredential(string host, int port, string authenticationType);
    }
    public partial class IPAddress
    {
        public static readonly System.Net.IPAddress Any;
        public static readonly System.Net.IPAddress Broadcast;
        public static readonly System.Net.IPAddress IPv6Any;
        public static readonly System.Net.IPAddress IPv6Loopback;
        public static readonly System.Net.IPAddress IPv6None;
        public static readonly System.Net.IPAddress Loopback;
        public static readonly System.Net.IPAddress None;
        public IPAddress(byte[] address) { }
        public IPAddress(byte[] address, long scopeid) { }
        public IPAddress(long newAddress) { }
        public IPAddress(System.ReadOnlySpan<byte> address) { }
        public IPAddress(System.ReadOnlySpan<byte> address, long scopeid) { }
        [System.ObsoleteAttribute("This property has been deprecated. It is address family dependent. Please use IPAddress.Equals method to perform comparisons. https://go.microsoft.com/fwlink/?linkid=14202")]
        public long Address { get { throw null; } set { } }
        public System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public bool IsIPv4MappedToIPv6 { get { throw null; } }
        public bool IsIPv6LinkLocal { get { throw null; } }
        public bool IsIPv6Multicast { get { throw null; } }
        public bool IsIPv6SiteLocal { get { throw null; } }
        public bool IsIPv6Teredo { get { throw null; } }
        public long ScopeId { get { throw null; } set { } }
        public override bool Equals(object comparand) { throw null; }
        public byte[] GetAddressBytes() { throw null; }
        public override int GetHashCode() { throw null; }
        public static short HostToNetworkOrder(short host) { throw null; }
        public static int HostToNetworkOrder(int host) { throw null; }
        public static long HostToNetworkOrder(long host) { throw null; }
        public static bool IsLoopback(System.Net.IPAddress address) { throw null; }
        public System.Net.IPAddress MapToIPv4() { throw null; }
        public System.Net.IPAddress MapToIPv6() { throw null; }
        public static short NetworkToHostOrder(short network) { throw null; }
        public static int NetworkToHostOrder(int network) { throw null; }
        public static long NetworkToHostOrder(long network) { throw null; }
        public static System.Net.IPAddress Parse(System.ReadOnlySpan<char> ipSpan) { throw null; }
        public static System.Net.IPAddress Parse(string ipString) { throw null; }
        public override string ToString() { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> ipSpan, out System.Net.IPAddress address) { throw null; }
        public static bool TryParse(string ipString, out System.Net.IPAddress address) { throw null; }
        public bool TryWriteBytes(System.Span<byte> destination, out int bytesWritten) { throw null; }
    }
    public partial class IPEndPoint : System.Net.EndPoint
    {
        public const int MaxPort = 65535;
        public const int MinPort = 0;
        public IPEndPoint(long address, int port) { }
        public IPEndPoint(System.Net.IPAddress address, int port) { }
        public System.Net.IPAddress Address { get { throw null; } set { } }
        public override System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public int Port { get { throw null; } set { } }
        public override System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { throw null; }
        public override bool Equals(object comparand) { throw null; }
        public override int GetHashCode() { throw null; }
        public override System.Net.SocketAddress Serialize() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class IPHostEntry
    {
        public IPHostEntry() { }
        public System.Net.IPAddress[] AddressList { get { throw null; } set { } }
        public string[] Aliases { get { throw null; } set { } }
        public string HostName { get { throw null; } set { } }
    }
    public partial interface IWebProxy
    {
        System.Net.ICredentials Credentials { get; set; }
        System.Uri GetProxy(System.Uri destination);
        bool IsBypassed(System.Uri host);
    }
    public partial interface IWebProxyScript
    {
        void Close();
        bool Load(System.Uri scriptLocation, string script, System.Type helperType);
        string Run(string url, string host);
    }
    public partial interface IWebRequestCreate
    {
        System.Net.WebRequest Create(System.Uri uri);
    }
    [System.FlagsAttribute]
    public enum NetworkAccess
    {
        Connect = 64,
        Accept = 128,
    }
    public partial class NetworkCredential : System.Net.ICredentials, System.Net.ICredentialsByHost
    {
        public NetworkCredential() { }
        public NetworkCredential(string userName, System.Security.SecureString password) { }
        public NetworkCredential(string userName, System.Security.SecureString password, string domain) { }
        public NetworkCredential(string userName, string password) { }
        public NetworkCredential(string userName, string password, string domain) { }
        public string Domain { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        public System.Security.SecureString SecurePassword { get { throw null; } set { } }
        public string UserName { get { throw null; } set { } }
        public System.Net.NetworkCredential GetCredential(string host, int port, string authenticationType) { throw null; }
        public System.Net.NetworkCredential GetCredential(System.Uri uri, string authType) { throw null; }
    }
    public partial class OpenReadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal OpenReadCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public System.IO.Stream Result { get { throw null; } }
    }
    public delegate void OpenReadCompletedEventHandler(object sender, System.Net.OpenReadCompletedEventArgs e);
    public partial class OpenWriteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal OpenWriteCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public System.IO.Stream Result { get { throw null; } }
    }
    public delegate void OpenWriteCompletedEventHandler(object sender, System.Net.OpenWriteCompletedEventArgs e);
    public partial class ProtocolViolationException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
    {
        public ProtocolViolationException() { }
        protected ProtocolViolationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public ProtocolViolationException(string message) { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    [System.FlagsAttribute]
    public enum SecurityProtocolType
    {
        SystemDefault = 0,
        Ssl3 = 48,
        Tls = 192,
        Tls11 = 768,
        Tls12 = 3072,
        Tls13 = 12288,
    }
    public partial class ServicePoint
    {
        internal ServicePoint() { }
        public System.Uri Address { get { throw null; } }
        public System.Net.BindIPEndPoint BindIPEndPointDelegate { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Certificate ClientCertificate { get { throw null; } }
        public int ConnectionLeaseTimeout { get { throw null; } set { } }
        public int ConnectionLimit { get { throw null; } set { } }
        public string ConnectionName { get { throw null; } }
        public int CurrentConnections { get { throw null; } }
        public bool Expect100Continue { get { throw null; } set { } }
        public System.DateTime IdleSince { get { throw null; } }
        public int MaxIdleTime { get { throw null; } set { } }
        public virtual System.Version ProtocolVersion { get { throw null; } }
        public int ReceiveBufferSize { get { throw null; } set { } }
        public bool SupportsPipelining { get { throw null; } }
        public bool UseNagleAlgorithm { get { throw null; } set { } }
        public bool CloseConnectionGroup(string connectionGroupName) { throw null; }
        public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }
    }
    public partial class ServicePointManager
    {
        internal ServicePointManager() { }
        public const int DefaultNonPersistentConnectionLimit = 4;
        public const int DefaultPersistentConnectionLimit = 10;
        public static System.Net.ICertificatePolicy CertificatePolicy { get { throw null; } set { } }
        public static bool CheckCertificateRevocationList { get { throw null; } set { } }
        public static int DefaultConnectionLimit { get { throw null; } set { } }
        public static int DnsRefreshTimeout { get { throw null; } set { } }
        public static bool EnableDnsRoundRobin { get { throw null; } set { } }
        public static System.Net.Security.EncryptionPolicy EncryptionPolicy { get { throw null; } }
        public static bool Expect100Continue { get { throw null; } set { } }
        public static int MaxServicePointIdleTime { get { throw null; } set { } }
        public static int MaxServicePoints { get { throw null; } set { } }
        public static bool ReusePort { get { throw null; } set { } }
        public static System.Net.SecurityProtocolType SecurityProtocol { get { throw null; } set { } }
        public static System.Net.Security.RemoteCertificateValidationCallback ServerCertificateValidationCallback { get { throw null; } set { } }
        public static bool UseNagleAlgorithm { get { throw null; } set { } }
        public static System.Net.ServicePoint FindServicePoint(string uriString, System.Net.IWebProxy proxy) { throw null; }
        public static System.Net.ServicePoint FindServicePoint(System.Uri address) { throw null; }
        public static System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy) { throw null; }
        public static void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }
    }
    public partial class SocketAddress
    {
        public SocketAddress(System.Net.Sockets.AddressFamily family) { }
        public SocketAddress(System.Net.Sockets.AddressFamily family, int size) { }
        public System.Net.Sockets.AddressFamily Family { get { throw null; } }
        public byte this[int offset] { get { throw null; } set { } }
        public int Size { get { throw null; } }
        public override bool Equals(object comparand) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class SocketPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public const int AllPorts = -1;
        public SocketPermission(System.Net.NetworkAccess access, System.Net.TransportType transport, string hostName, int portNumber) { }
        public SocketPermission(System.Security.Permissions.PermissionState state) { }
        public System.Collections.IEnumerator AcceptList { get { throw null; } }
        public System.Collections.IEnumerator ConnectList { get { throw null; } }
        public void AddPermission(System.Net.NetworkAccess access, System.Net.TransportType transport, string hostName, int portNumber) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Struct, AllowMultiple=true, Inherited=false)]
    public sealed partial class SocketPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public SocketPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Access { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public string Port { get { throw null; } set { } }
        public string Transport { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    public abstract partial class TransportContext
    {
        protected TransportContext() { }
        public abstract System.Security.Authentication.ExtendedProtection.ChannelBinding GetChannelBinding(System.Security.Authentication.ExtendedProtection.ChannelBindingKind kind);
        public virtual System.Collections.Generic.IEnumerable<System.Security.Authentication.ExtendedProtection.TokenBinding> GetTlsTokenBindings() { throw null; }
    }
    public enum TransportType
    {
        Connectionless = 1,
        Udp = 1,
        ConnectionOriented = 2,
        Tcp = 2,
        All = 3,
    }
    public partial class UploadDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadDataCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public byte[] Result { get { throw null; } }
    }
    public delegate void UploadDataCompletedEventHandler(object sender, System.Net.UploadDataCompletedEventArgs e);
    public partial class UploadFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadFileCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public byte[] Result { get { throw null; } }
    }
    public delegate void UploadFileCompletedEventHandler(object sender, System.Net.UploadFileCompletedEventArgs e);
    public partial class UploadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
    {
        internal UploadProgressChangedEventArgs() : base (default(int), default(object)) { }
        public long BytesReceived { get { throw null; } }
        public long BytesSent { get { throw null; } }
        public long TotalBytesToReceive { get { throw null; } }
        public long TotalBytesToSend { get { throw null; } }
    }
    public delegate void UploadProgressChangedEventHandler(object sender, System.Net.UploadProgressChangedEventArgs e);
    public partial class UploadStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadStringCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public string Result { get { throw null; } }
    }
    public delegate void UploadStringCompletedEventHandler(object sender, System.Net.UploadStringCompletedEventArgs e);
    public partial class UploadValuesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadValuesCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public byte[] Result { get { throw null; } }
    }
    public delegate void UploadValuesCompletedEventHandler(object sender, System.Net.UploadValuesCompletedEventArgs e);
    public partial class WebClient : System.ComponentModel.Component
    {
        public WebClient() { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public bool AllowReadStreamBuffering { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public bool AllowWriteStreamBuffering { get { throw null; } set { } }
        public string BaseAddress { get { throw null; } set { } }
        public System.Net.Cache.RequestCachePolicy CachePolicy { get { throw null; } set { } }
        public System.Net.ICredentials Credentials { get { throw null; } set { } }
        public System.Text.Encoding Encoding { get { throw null; } set { } }
        public System.Net.WebHeaderCollection Headers { get { throw null; } set { } }
        public bool IsBusy { get { throw null; } }
        public System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public System.Collections.Specialized.NameValueCollection QueryString { get { throw null; } set { } }
        public System.Net.WebHeaderCollection ResponseHeaders { get { throw null; } }
        public bool UseDefaultCredentials { get { throw null; } set { } }
        public event System.Net.DownloadDataCompletedEventHandler DownloadDataCompleted { add { } remove { } }
        public event System.ComponentModel.AsyncCompletedEventHandler DownloadFileCompleted { add { } remove { } }
        public event System.Net.DownloadProgressChangedEventHandler DownloadProgressChanged { add { } remove { } }
        public event System.Net.DownloadStringCompletedEventHandler DownloadStringCompleted { add { } remove { } }
        public event System.Net.OpenReadCompletedEventHandler OpenReadCompleted { add { } remove { } }
        public event System.Net.OpenWriteCompletedEventHandler OpenWriteCompleted { add { } remove { } }
        public event System.Net.UploadDataCompletedEventHandler UploadDataCompleted { add { } remove { } }
        public event System.Net.UploadFileCompletedEventHandler UploadFileCompleted { add { } remove { } }
        public event System.Net.UploadProgressChangedEventHandler UploadProgressChanged { add { } remove { } }
        public event System.Net.UploadStringCompletedEventHandler UploadStringCompleted { add { } remove { } }
        public event System.Net.UploadValuesCompletedEventHandler UploadValuesCompleted { add { } remove { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public event System.Net.WriteStreamClosedEventHandler WriteStreamClosed { add { } remove { } }
        public void CancelAsync() { }
        public byte[] DownloadData(string address) { throw null; }
        public byte[] DownloadData(System.Uri address) { throw null; }
        public void DownloadDataAsync(System.Uri address) { }
        public void DownloadDataAsync(System.Uri address, object userToken) { }
        public System.Threading.Tasks.Task<byte[]> DownloadDataTaskAsync(string address) { throw null; }
        public System.Threading.Tasks.Task<byte[]> DownloadDataTaskAsync(System.Uri address) { throw null; }
        public void DownloadFile(string address, string fileName) { }
        public void DownloadFile(System.Uri address, string fileName) { }
        public void DownloadFileAsync(System.Uri address, string fileName) { }
        public void DownloadFileAsync(System.Uri address, string fileName, object userToken) { }
        public System.Threading.Tasks.Task DownloadFileTaskAsync(string address, string fileName) { throw null; }
        public System.Threading.Tasks.Task DownloadFileTaskAsync(System.Uri address, string fileName) { throw null; }
        public string DownloadString(string address) { throw null; }
        public string DownloadString(System.Uri address) { throw null; }
        public void DownloadStringAsync(System.Uri address) { }
        public void DownloadStringAsync(System.Uri address, object userToken) { }
        public System.Threading.Tasks.Task<string> DownloadStringTaskAsync(string address) { throw null; }
        public System.Threading.Tasks.Task<string> DownloadStringTaskAsync(System.Uri address) { throw null; }
        protected virtual System.Net.WebRequest GetWebRequest(System.Uri address) { throw null; }
        protected virtual System.Net.WebResponse GetWebResponse(System.Net.WebRequest request) { throw null; }
        protected virtual System.Net.WebResponse GetWebResponse(System.Net.WebRequest request, System.IAsyncResult result) { throw null; }
        protected virtual void OnDownloadDataCompleted(System.Net.DownloadDataCompletedEventArgs e) { }
        protected virtual void OnDownloadFileCompleted(System.ComponentModel.AsyncCompletedEventArgs e) { }
        protected virtual void OnDownloadProgressChanged(System.Net.DownloadProgressChangedEventArgs e) { }
        protected virtual void OnDownloadStringCompleted(System.Net.DownloadStringCompletedEventArgs e) { }
        protected virtual void OnOpenReadCompleted(System.Net.OpenReadCompletedEventArgs e) { }
        protected virtual void OnOpenWriteCompleted(System.Net.OpenWriteCompletedEventArgs e) { }
        protected virtual void OnUploadDataCompleted(System.Net.UploadDataCompletedEventArgs e) { }
        protected virtual void OnUploadFileCompleted(System.Net.UploadFileCompletedEventArgs e) { }
        protected virtual void OnUploadProgressChanged(System.Net.UploadProgressChangedEventArgs e) { }
        protected virtual void OnUploadStringCompleted(System.Net.UploadStringCompletedEventArgs e) { }
        protected virtual void OnUploadValuesCompleted(System.Net.UploadValuesCompletedEventArgs e) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        protected virtual void OnWriteStreamClosed(System.Net.WriteStreamClosedEventArgs e) { }
        public System.IO.Stream OpenRead(string address) { throw null; }
        public System.IO.Stream OpenRead(System.Uri address) { throw null; }
        public void OpenReadAsync(System.Uri address) { }
        public void OpenReadAsync(System.Uri address, object userToken) { }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenReadTaskAsync(string address) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenReadTaskAsync(System.Uri address) { throw null; }
        public System.IO.Stream OpenWrite(string address) { throw null; }
        public System.IO.Stream OpenWrite(string address, string method) { throw null; }
        public System.IO.Stream OpenWrite(System.Uri address) { throw null; }
        public System.IO.Stream OpenWrite(System.Uri address, string method) { throw null; }
        public void OpenWriteAsync(System.Uri address) { }
        public void OpenWriteAsync(System.Uri address, string method) { }
        public void OpenWriteAsync(System.Uri address, string method, object userToken) { }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(string address) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(string address, string method) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(System.Uri address) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(System.Uri address, string method) { throw null; }
        public byte[] UploadData(string address, byte[] data) { throw null; }
        public byte[] UploadData(string address, string method, byte[] data) { throw null; }
        public byte[] UploadData(System.Uri address, byte[] data) { throw null; }
        public byte[] UploadData(System.Uri address, string method, byte[] data) { throw null; }
        public void UploadDataAsync(System.Uri address, byte[] data) { }
        public void UploadDataAsync(System.Uri address, string method, byte[] data) { }
        public void UploadDataAsync(System.Uri address, string method, byte[] data, object userToken) { }
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(string address, byte[] data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(string address, string method, byte[] data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(System.Uri address, byte[] data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(System.Uri address, string method, byte[] data) { throw null; }
        public byte[] UploadFile(string address, string fileName) { throw null; }
        public byte[] UploadFile(string address, string method, string fileName) { throw null; }
        public byte[] UploadFile(System.Uri address, string fileName) { throw null; }
        public byte[] UploadFile(System.Uri address, string method, string fileName) { throw null; }
        public void UploadFileAsync(System.Uri address, string fileName) { }
        public void UploadFileAsync(System.Uri address, string method, string fileName) { }
        public void UploadFileAsync(System.Uri address, string method, string fileName, object userToken) { }
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(string address, string fileName) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(string address, string method, string fileName) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(System.Uri address, string fileName) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(System.Uri address, string method, string fileName) { throw null; }
        public string UploadString(string address, string data) { throw null; }
        public string UploadString(string address, string method, string data) { throw null; }
        public string UploadString(System.Uri address, string data) { throw null; }
        public string UploadString(System.Uri address, string method, string data) { throw null; }
        public void UploadStringAsync(System.Uri address, string data) { }
        public void UploadStringAsync(System.Uri address, string method, string data) { }
        public void UploadStringAsync(System.Uri address, string method, string data, object userToken) { }
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(string address, string data) { throw null; }
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(string address, string method, string data) { throw null; }
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(System.Uri address, string data) { throw null; }
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(System.Uri address, string method, string data) { throw null; }
        public byte[] UploadValues(string address, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public byte[] UploadValues(string address, string method, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public byte[] UploadValues(System.Uri address, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public byte[] UploadValues(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public void UploadValuesAsync(System.Uri address, System.Collections.Specialized.NameValueCollection data) { }
        public void UploadValuesAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) { }
        public void UploadValuesAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data, object userToken) { }
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(string address, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(string address, string method, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(System.Uri address, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) { throw null; }
    }
    public partial class WebException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
    {
        public WebException() { }
        protected WebException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public WebException(string message) { }
        public WebException(string message, System.Exception innerException) { }
        public WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response) { }
        public WebException(string message, System.Net.WebExceptionStatus status) { }
        public System.Net.WebResponse Response { get { throw null; } }
        public System.Net.WebExceptionStatus Status { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public enum WebExceptionStatus
    {
        Success = 0,
        NameResolutionFailure = 1,
        ConnectFailure = 2,
        ReceiveFailure = 3,
        SendFailure = 4,
        PipelineFailure = 5,
        RequestCanceled = 6,
        ProtocolError = 7,
        ConnectionClosed = 8,
        TrustFailure = 9,
        SecureChannelFailure = 10,
        ServerProtocolViolation = 11,
        KeepAliveFailure = 12,
        Pending = 13,
        Timeout = 14,
        ProxyNameResolutionFailure = 15,
        UnknownError = 16,
        MessageLengthLimitExceeded = 17,
        CacheEntryNotFound = 18,
        RequestProhibitedByCachePolicy = 19,
        RequestProhibitedByProxy = 20,
    }
    public partial class WebHeaderCollection : System.Collections.Specialized.NameValueCollection, System.Runtime.Serialization.ISerializable
    {
        public WebHeaderCollection() { }
        protected WebHeaderCollection(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override string[] AllKeys { get { throw null; } }
        public override int Count { get { throw null; } }
        public string this[System.Net.HttpRequestHeader header] { get { throw null; } set { } }
        public string this[System.Net.HttpResponseHeader header] { get { throw null; } set { } }
        public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { throw null; } }
        public void Add(System.Net.HttpRequestHeader header, string value) { }
        public void Add(System.Net.HttpResponseHeader header, string value) { }
        public void Add(string header) { }
        public override void Add(string name, string value) { }
        protected void AddWithoutValidate(string headerName, string headerValue) { }
        public override void Clear() { }
        public override string Get(int index) { throw null; }
        public override string Get(string name) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override string GetKey(int index) { throw null; }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override string[] GetValues(int index) { throw null; }
        public override string[] GetValues(string header) { throw null; }
        public static bool IsRestricted(string headerName) { throw null; }
        public static bool IsRestricted(string headerName, bool response) { throw null; }
        public override void OnDeserialization(object sender) { }
        public void Remove(System.Net.HttpRequestHeader header) { }
        public void Remove(System.Net.HttpResponseHeader header) { }
        public override void Remove(string name) { }
        public void Set(System.Net.HttpRequestHeader header, string value) { }
        public void Set(System.Net.HttpResponseHeader header, string value) { }
        public override void Set(string name, string value) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public byte[] ToByteArray() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class WebPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public WebPermission() { }
        public WebPermission(System.Net.NetworkAccess access, string uriString) { }
        public WebPermission(System.Net.NetworkAccess access, System.Text.RegularExpressions.Regex uriRegex) { }
        public WebPermission(System.Security.Permissions.PermissionState state) { }
        public System.Collections.IEnumerator AcceptList { get { throw null; } }
        public System.Collections.IEnumerator ConnectList { get { throw null; } }
        public void AddPermission(System.Net.NetworkAccess access, string uriString) { }
        public void AddPermission(System.Net.NetworkAccess access, System.Text.RegularExpressions.Regex uriRegex) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Struct, AllowMultiple=true, Inherited=false)]
    public sealed partial class WebPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public WebPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Accept { get { throw null; } set { } }
        public string AcceptPattern { get { throw null; } set { } }
        public string Connect { get { throw null; } set { } }
        public string ConnectPattern { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    public partial class WebProxy : System.Net.IWebProxy, System.Runtime.Serialization.ISerializable
    {
        public WebProxy() { }
        protected WebProxy(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public WebProxy(string Address) { }
        public WebProxy(string Address, bool BypassOnLocal) { }
        public WebProxy(string Address, bool BypassOnLocal, string[] BypassList) { }
        public WebProxy(string Address, bool BypassOnLocal, string[] BypassList, System.Net.ICredentials Credentials) { }
        public WebProxy(string Host, int Port) { }
        public WebProxy(System.Uri Address) { }
        public WebProxy(System.Uri Address, bool BypassOnLocal) { }
        public WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList) { }
        public WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList, System.Net.ICredentials Credentials) { }
        public System.Uri Address { get { throw null; } set { } }
        public System.Collections.ArrayList BypassArrayList { get { throw null; } }
        public string[] BypassList { get { throw null; } set { } }
        public bool BypassProxyOnLocal { get { throw null; } set { } }
        public System.Net.ICredentials Credentials { get { throw null; } set { } }
        public bool UseDefaultCredentials { get { throw null; } set { } }
        public static System.Net.IWebProxy CreateDefaultProxy() { throw null; }
        [System.ObsoleteAttribute("This method has been deprecated. Please use the proxy selected for you by default. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.Net.WebProxy GetDefaultProxy() { throw null; }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public System.Uri GetProxy(System.Uri destination) { throw null; }
        public bool IsBypassed(System.Uri host) { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public abstract partial class WebRequest : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable
    {
        protected WebRequest() { }
        protected WebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public System.Net.Security.AuthenticationLevel AuthenticationLevel { get { throw null; } set { } }
        public virtual System.Net.Cache.RequestCachePolicy CachePolicy { get { throw null; } set { } }
        public virtual string ConnectionGroupName { get { throw null; } set { } }
        public virtual long ContentLength { get { throw null; } set { } }
        public virtual string ContentType { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public virtual System.Net.IWebRequestCreate CreatorInstance { get { throw null; } }
        public virtual System.Net.ICredentials Credentials { get { throw null; } set { } }
        public static System.Net.Cache.RequestCachePolicy DefaultCachePolicy { get { throw null; } set { } }
        public static System.Net.IWebProxy DefaultWebProxy { get { throw null; } set { } }
        public virtual System.Net.WebHeaderCollection Headers { get { throw null; } set { } }
        public System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get { throw null; } set { } }
        public virtual string Method { get { throw null; } set { } }
        public virtual bool PreAuthenticate { get { throw null; } set { } }
        public virtual System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public virtual System.Uri RequestUri { get { throw null; } }
        public virtual int Timeout { get { throw null; } set { } }
        public virtual bool UseDefaultCredentials { get { throw null; } set { } }
        public virtual void Abort() { }
        public virtual System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { throw null; }
        public virtual System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { throw null; }
        public static System.Net.WebRequest Create(string requestUriString) { throw null; }
        public static System.Net.WebRequest Create(System.Uri requestUri) { throw null; }
        public static System.Net.WebRequest CreateDefault(System.Uri requestUri) { throw null; }
        public static System.Net.HttpWebRequest CreateHttp(string requestUriString) { throw null; }
        public static System.Net.HttpWebRequest CreateHttp(System.Uri requestUri) { throw null; }
        public virtual System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { throw null; }
        public virtual System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { throw null; }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public virtual System.IO.Stream GetRequestStream() { throw null; }
        public virtual System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync() { throw null; }
        public virtual System.Net.WebResponse GetResponse() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync() { throw null; }
        public static System.Net.IWebProxy GetSystemWebProxy() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public static void RegisterPortableWebRequestCreator(System.Net.IWebRequestCreate creator) { }
        public static bool RegisterPrefix(string prefix, System.Net.IWebRequestCreate creator) { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public static partial class WebRequestMethods
    {
        public static partial class File
        {
            public const string DownloadFile = "GET";
            public const string UploadFile = "PUT";
        }
        public static partial class Ftp
        {
            public const string AppendFile = "APPE";
            public const string DeleteFile = "DELE";
            public const string DownloadFile = "RETR";
            public const string GetDateTimestamp = "MDTM";
            public const string GetFileSize = "SIZE";
            public const string ListDirectory = "NLST";
            public const string ListDirectoryDetails = "LIST";
            public const string MakeDirectory = "MKD";
            public const string PrintWorkingDirectory = "PWD";
            public const string RemoveDirectory = "RMD";
            public const string Rename = "RENAME";
            public const string UploadFile = "STOR";
            public const string UploadFileWithUniqueName = "STOU";
        }
        public static partial class Http
        {
            public const string Connect = "CONNECT";
            public const string Get = "GET";
            public const string Head = "HEAD";
            public const string MkCol = "MKCOL";
            public const string Post = "POST";
            public const string Put = "PUT";
        }
    }
    public abstract partial class WebResponse : System.MarshalByRefObject, System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        protected WebResponse() { }
        protected WebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public virtual long ContentLength { get { throw null; } set { } }
        public virtual string ContentType { get { throw null; } set { } }
        public virtual System.Net.WebHeaderCollection Headers { get { throw null; } }
        public virtual bool IsFromCache { get { throw null; } }
        public virtual bool IsMutuallyAuthenticated { get { throw null; } }
        public virtual System.Uri ResponseUri { get { throw null; } }
        public virtual bool SupportsHeaders { get { throw null; } }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public virtual System.IO.Stream GetResponseStream() { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public static partial class WebUtility
    {
        public static string HtmlDecode(string value) { throw null; }
        public static void HtmlDecode(string value, System.IO.TextWriter output) { }
        public static string HtmlEncode(string value) { throw null; }
        public static void HtmlEncode(string value, System.IO.TextWriter output) { }
        public static string UrlDecode(string encodedValue) { throw null; }
        public static byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count) { throw null; }
        public static string UrlEncode(string value) { throw null; }
        public static byte[] UrlEncodeToBytes(byte[] value, int offset, int count) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class WriteStreamClosedEventArgs : System.EventArgs
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public WriteStreamClosedEventArgs() { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public System.Exception Error { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public delegate void WriteStreamClosedEventHandler(object sender, System.Net.WriteStreamClosedEventArgs e);
}
namespace System.Net.Cache
{
    public enum HttpCacheAgeControl
    {
        None = 0,
        MinFresh = 1,
        MaxAge = 2,
        MaxAgeAndMinFresh = 3,
        MaxStale = 4,
        MaxAgeAndMaxStale = 6,
    }
    public enum HttpRequestCacheLevel
    {
        Default = 0,
        BypassCache = 1,
        CacheOnly = 2,
        CacheIfAvailable = 3,
        Revalidate = 4,
        Reload = 5,
        NoCacheNoStore = 6,
        CacheOrNextCacheOnly = 7,
        Refresh = 8,
    }
    public partial class HttpRequestCachePolicy : System.Net.Cache.RequestCachePolicy
    {
        public HttpRequestCachePolicy() { }
        public HttpRequestCachePolicy(System.DateTime cacheSyncDate) { }
        public HttpRequestCachePolicy(System.Net.Cache.HttpCacheAgeControl cacheAgeControl, System.TimeSpan ageOrFreshOrStale) { }
        public HttpRequestCachePolicy(System.Net.Cache.HttpCacheAgeControl cacheAgeControl, System.TimeSpan maxAge, System.TimeSpan freshOrStale) { }
        public HttpRequestCachePolicy(System.Net.Cache.HttpCacheAgeControl cacheAgeControl, System.TimeSpan maxAge, System.TimeSpan freshOrStale, System.DateTime cacheSyncDate) { }
        public HttpRequestCachePolicy(System.Net.Cache.HttpRequestCacheLevel level) { }
        public System.DateTime CacheSyncDate { get { throw null; } }
        public new System.Net.Cache.HttpRequestCacheLevel Level { get { throw null; } }
        public System.TimeSpan MaxAge { get { throw null; } }
        public System.TimeSpan MaxStale { get { throw null; } }
        public System.TimeSpan MinFresh { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public enum RequestCacheLevel
    {
        Default = 0,
        BypassCache = 1,
        CacheOnly = 2,
        CacheIfAvailable = 3,
        Revalidate = 4,
        Reload = 5,
        NoCacheNoStore = 6,
    }
    public partial class RequestCachePolicy
    {
        public RequestCachePolicy() { }
        public RequestCachePolicy(System.Net.Cache.RequestCacheLevel level) { }
        public System.Net.Cache.RequestCacheLevel Level { get { throw null; } }
        public override string ToString() { throw null; }
    }
}
namespace System.Net.Mail
{
    public partial class AlternateView : System.Net.Mail.AttachmentBase
    {
        public AlternateView(System.IO.Stream contentStream) : base (default(System.IO.Stream)) { }
        public AlternateView(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
        public AlternateView(System.IO.Stream contentStream, string mediaType) : base (default(System.IO.Stream)) { }
        public AlternateView(string fileName) : base (default(System.IO.Stream)) { }
        public AlternateView(string fileName, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
        public AlternateView(string fileName, string mediaType) : base (default(System.IO.Stream)) { }
        public System.Uri BaseUri { get { throw null; } set { } }
        public System.Net.Mail.LinkedResourceCollection LinkedResources { get { throw null; } }
        public static System.Net.Mail.AlternateView CreateAlternateViewFromString(string content) { throw null; }
        public static System.Net.Mail.AlternateView CreateAlternateViewFromString(string content, System.Net.Mime.ContentType contentType) { throw null; }
        public static System.Net.Mail.AlternateView CreateAlternateViewFromString(string content, System.Text.Encoding contentEncoding, string mediaType) { throw null; }
        protected override void Dispose(bool disposing) { }
    }
    public sealed partial class AlternateViewCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.AlternateView>, System.IDisposable
    {
        internal AlternateViewCollection() { }
        protected override void ClearItems() { }
        public void Dispose() { }
        protected override void InsertItem(int index, System.Net.Mail.AlternateView item) { }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, System.Net.Mail.AlternateView item) { }
    }
    public partial class Attachment : System.Net.Mail.AttachmentBase
    {
        public Attachment(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
        public Attachment(System.IO.Stream contentStream, string name) : base (default(System.IO.Stream)) { }
        public Attachment(System.IO.Stream contentStream, string name, string mediaType) : base (default(System.IO.Stream)) { }
        public Attachment(string fileName) : base (default(System.IO.Stream)) { }
        public Attachment(string fileName, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
        public Attachment(string fileName, string mediaType) : base (default(System.IO.Stream)) { }
        public System.Net.Mime.ContentDisposition ContentDisposition { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public System.Text.Encoding NameEncoding { get { throw null; } set { } }
        public static System.Net.Mail.Attachment CreateAttachmentFromString(string content, System.Net.Mime.ContentType contentType) { throw null; }
        public static System.Net.Mail.Attachment CreateAttachmentFromString(string content, string name) { throw null; }
        public static System.Net.Mail.Attachment CreateAttachmentFromString(string content, string name, System.Text.Encoding contentEncoding, string mediaType) { throw null; }
    }
    public abstract partial class AttachmentBase : System.IDisposable
    {
        protected AttachmentBase(System.IO.Stream contentStream) { }
        protected AttachmentBase(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) { }
        protected AttachmentBase(System.IO.Stream contentStream, string mediaType) { }
        protected AttachmentBase(string fileName) { }
        protected AttachmentBase(string fileName, System.Net.Mime.ContentType contentType) { }
        protected AttachmentBase(string fileName, string mediaType) { }
        public string ContentId { get { throw null; } set { } }
        public System.IO.Stream ContentStream { get { throw null; } }
        public System.Net.Mime.ContentType ContentType { get { throw null; } set { } }
        public System.Net.Mime.TransferEncoding TransferEncoding { get { throw null; } set { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
    }
    public sealed partial class AttachmentCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.Attachment>, System.IDisposable
    {
        internal AttachmentCollection() { }
        protected override void ClearItems() { }
        public void Dispose() { }
        protected override void InsertItem(int index, System.Net.Mail.Attachment item) { }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, System.Net.Mail.Attachment item) { }
    }
    [System.FlagsAttribute]
    public enum DeliveryNotificationOptions
    {
        None = 0,
        OnSuccess = 1,
        OnFailure = 2,
        Delay = 4,
        Never = 134217728,
    }
    public partial class LinkedResource : System.Net.Mail.AttachmentBase
    {
        public LinkedResource(System.IO.Stream contentStream) : base (default(System.IO.Stream)) { }
        public LinkedResource(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
        public LinkedResource(System.IO.Stream contentStream, string mediaType) : base (default(System.IO.Stream)) { }
        public LinkedResource(string fileName) : base (default(System.IO.Stream)) { }
        public LinkedResource(string fileName, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
        public LinkedResource(string fileName, string mediaType) : base (default(System.IO.Stream)) { }
        public System.Uri ContentLink { get { throw null; } set { } }
        public static System.Net.Mail.LinkedResource CreateLinkedResourceFromString(string content) { throw null; }
        public static System.Net.Mail.LinkedResource CreateLinkedResourceFromString(string content, System.Net.Mime.ContentType contentType) { throw null; }
        public static System.Net.Mail.LinkedResource CreateLinkedResourceFromString(string content, System.Text.Encoding contentEncoding, string mediaType) { throw null; }
    }
    public sealed partial class LinkedResourceCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.LinkedResource>, System.IDisposable
    {
        internal LinkedResourceCollection() { }
        protected override void ClearItems() { }
        public void Dispose() { }
        protected override void InsertItem(int index, System.Net.Mail.LinkedResource item) { }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, System.Net.Mail.LinkedResource item) { }
    }
    public partial class MailAddress
    {
        public MailAddress(string address) { }
        public MailAddress(string address, string displayName) { }
        public MailAddress(string address, string displayName, System.Text.Encoding displayNameEncoding) { }
        public string Address { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string Host { get { throw null; } }
        public string User { get { throw null; } }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MailAddressCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.MailAddress>
    {
        public MailAddressCollection() { }
        public void Add(string addresses) { }
        protected override void InsertItem(int index, System.Net.Mail.MailAddress item) { }
        protected override void SetItem(int index, System.Net.Mail.MailAddress item) { }
        public override string ToString() { throw null; }
    }
    public partial class MailMessage : System.IDisposable
    {
        public MailMessage() { }
        public MailMessage(System.Net.Mail.MailAddress from, System.Net.Mail.MailAddress to) { }
        public MailMessage(string from, string to) { }
        public MailMessage(string from, string to, string subject, string body) { }
        public System.Net.Mail.AlternateViewCollection AlternateViews { get { throw null; } }
        public System.Net.Mail.AttachmentCollection Attachments { get { throw null; } }
        public System.Net.Mail.MailAddressCollection Bcc { get { throw null; } }
        public string Body { get { throw null; } set { } }
        public System.Text.Encoding BodyEncoding { get { throw null; } set { } }
        public System.Net.Mime.TransferEncoding BodyTransferEncoding { get { throw null; } set { } }
        public System.Net.Mail.MailAddressCollection CC { get { throw null; } }
        public System.Net.Mail.DeliveryNotificationOptions DeliveryNotificationOptions { get { throw null; } set { } }
        public System.Net.Mail.MailAddress From { get { throw null; } set { } }
        public System.Collections.Specialized.NameValueCollection Headers { get { throw null; } }
        public System.Text.Encoding HeadersEncoding { get { throw null; } set { } }
        public bool IsBodyHtml { get { throw null; } set { } }
        public System.Net.Mail.MailPriority Priority { get { throw null; } set { } }
        [System.ObsoleteAttribute("Use ReplyToList instead")]
        public System.Net.Mail.MailAddress ReplyTo { get { throw null; } set { } }
        public System.Net.Mail.MailAddressCollection ReplyToList { get { throw null; } }
        public System.Net.Mail.MailAddress Sender { get { throw null; } set { } }
        public string Subject { get { throw null; } set { } }
        public System.Text.Encoding SubjectEncoding { get { throw null; } set { } }
        public System.Net.Mail.MailAddressCollection To { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
    }
    public enum MailPriority
    {
        Normal = 0,
        Low = 1,
        High = 2,
    }
    public delegate void SendCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    public enum SmtpAccess
    {
        None = 0,
        Connect = 1,
        ConnectToUnrestrictedPort = 2,
    }
    public partial class SmtpClient : System.IDisposable
    {
        public SmtpClient() { }
        public SmtpClient(string host) { }
        public SmtpClient(string host, int port) { }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } }
        public System.Net.ICredentialsByHost Credentials { get { throw null; } set { } }
        public System.Net.Mail.SmtpDeliveryFormat DeliveryFormat { get { throw null; } set { } }
        public System.Net.Mail.SmtpDeliveryMethod DeliveryMethod { get { throw null; } set { } }
        public bool EnableSsl { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public string PickupDirectoryLocation { get { throw null; } set { } }
        public int Port { get { throw null; } set { } }
        public System.Net.ServicePoint ServicePoint { get { throw null; } }
        public string TargetName { get { throw null; } set { } }
        public int Timeout { get { throw null; } set { } }
        public bool UseDefaultCredentials { get { throw null; } set { } }
        public event System.Net.Mail.SendCompletedEventHandler SendCompleted { add { } remove { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected void OnSendCompleted(System.ComponentModel.AsyncCompletedEventArgs e) { }
        public void Send(System.Net.Mail.MailMessage message) { }
        public void Send(string from, string to, string subject, string body) { }
        public void SendAsync(System.Net.Mail.MailMessage message, object userToken) { }
        public void SendAsync(string from, string to, string subject, string body, object userToken) { }
        public void SendAsyncCancel() { }
        public System.Threading.Tasks.Task SendMailAsync(System.Net.Mail.MailMessage message) { throw null; }
        public System.Threading.Tasks.Task SendMailAsync(string from, string recipients, string subject, string body) { throw null; }
    }
    public enum SmtpDeliveryFormat
    {
        SevenBit = 0,
        International = 1,
    }
    public enum SmtpDeliveryMethod
    {
        Network = 0,
        SpecifiedPickupDirectory = 1,
        PickupDirectoryFromIis = 2,
    }
    public partial class SmtpException : System.Exception, System.Runtime.Serialization.ISerializable
    {
        public SmtpException() { }
        public SmtpException(System.Net.Mail.SmtpStatusCode statusCode) { }
        public SmtpException(System.Net.Mail.SmtpStatusCode statusCode, string message) { }
        protected SmtpException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public SmtpException(string message) { }
        public SmtpException(string message, System.Exception innerException) { }
        public System.Net.Mail.SmtpStatusCode StatusCode { get { throw null; } set { } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class SmtpFailedRecipientException : System.Net.Mail.SmtpException, System.Runtime.Serialization.ISerializable
    {
        public SmtpFailedRecipientException() { }
        public SmtpFailedRecipientException(System.Net.Mail.SmtpStatusCode statusCode, string failedRecipient) { }
        public SmtpFailedRecipientException(System.Net.Mail.SmtpStatusCode statusCode, string failedRecipient, string serverResponse) { }
        protected SmtpFailedRecipientException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SmtpFailedRecipientException(string message) { }
        public SmtpFailedRecipientException(string message, System.Exception innerException) { }
        public SmtpFailedRecipientException(string message, string failedRecipient, System.Exception innerException) { }
        public string FailedRecipient { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public partial class SmtpFailedRecipientsException : System.Net.Mail.SmtpFailedRecipientException, System.Runtime.Serialization.ISerializable
    {
        public SmtpFailedRecipientsException() { }
        protected SmtpFailedRecipientsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SmtpFailedRecipientsException(string message) { }
        public SmtpFailedRecipientsException(string message, System.Exception innerException) { }
        public SmtpFailedRecipientsException(string message, System.Net.Mail.SmtpFailedRecipientException[] innerExceptions) { }
        public System.Net.Mail.SmtpFailedRecipientException[] InnerExceptions { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public enum SmtpStatusCode
    {
        GeneralFailure = -1,
        SystemStatus = 211,
        HelpMessage = 214,
        ServiceReady = 220,
        ServiceClosingTransmissionChannel = 221,
        Ok = 250,
        UserNotLocalWillForward = 251,
        CannotVerifyUserWillAttemptDelivery = 252,
        StartMailInput = 354,
        ServiceNotAvailable = 421,
        MailboxBusy = 450,
        LocalErrorInProcessing = 451,
        InsufficientStorage = 452,
        ClientNotPermitted = 454,
        CommandUnrecognized = 500,
        SyntaxError = 501,
        CommandNotImplemented = 502,
        BadCommandSequence = 503,
        CommandParameterNotImplemented = 504,
        MustIssueStartTlsFirst = 530,
        MailboxUnavailable = 550,
        UserNotLocalTryAlternatePath = 551,
        ExceededStorageAllocation = 552,
        MailboxNameNotAllowed = 553,
        TransactionFailed = 554,
    }
}
namespace System.Net.Mime
{
    public partial class ContentDisposition
    {
        public ContentDisposition() { }
        public ContentDisposition(string disposition) { }
        public System.DateTime CreationDate { get { throw null; } set { } }
        public string DispositionType { get { throw null; } set { } }
        public string FileName { get { throw null; } set { } }
        public bool Inline { get { throw null; } set { } }
        public System.DateTime ModificationDate { get { throw null; } set { } }
        public System.Collections.Specialized.StringDictionary Parameters { get { throw null; } }
        public System.DateTime ReadDate { get { throw null; } set { } }
        public long Size { get { throw null; } set { } }
        public override bool Equals(object rparam) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContentType
    {
        public ContentType() { }
        public ContentType(string contentType) { }
        public string Boundary { get { throw null; } set { } }
        public string CharSet { get { throw null; } set { } }
        public string MediaType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Collections.Specialized.StringDictionary Parameters { get { throw null; } }
        public override bool Equals(object rparam) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class DispositionTypeNames
    {
        public const string Attachment = "attachment";
        public const string Inline = "inline";
    }
    public static partial class MediaTypeNames
    {
        public static partial class Application
        {
            public const string Json = "application/json";
            public const string Octet = "application/octet-stream";
            public const string Pdf = "application/pdf";
            public const string Rtf = "application/rtf";
            public const string Soap = "application/soap+xml";
            public const string Xml = "application/xml";
            public const string Zip = "application/zip";
        }
        public static partial class Image
        {
            public const string Gif = "image/gif";
            public const string Jpeg = "image/jpeg";
            public const string Tiff = "image/tiff";
        }
        public static partial class Text
        {
            public const string Html = "text/html";
            public const string Plain = "text/plain";
            public const string RichText = "text/richtext";
            public const string Xml = "text/xml";
        }
    }
    public enum TransferEncoding
    {
        Unknown = -1,
        QuotedPrintable = 0,
        Base64 = 1,
        SevenBit = 2,
        EightBit = 3,
    }
}
namespace System.Net.NetworkInformation
{
    public enum DuplicateAddressDetectionState
    {
        Invalid = 0,
        Tentative = 1,
        Duplicate = 2,
        Deprecated = 3,
        Preferred = 4,
    }
    public abstract partial class GatewayIPAddressInformation
    {
        protected GatewayIPAddressInformation() { }
        public abstract System.Net.IPAddress Address { get; }
    }
    public partial class GatewayIPAddressInformationCollection : System.Collections.Generic.ICollection<System.Net.NetworkInformation.GatewayIPAddressInformation>, System.Collections.Generic.IEnumerable<System.Net.NetworkInformation.GatewayIPAddressInformation>, System.Collections.IEnumerable
    {
        protected internal GatewayIPAddressInformationCollection() { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual System.Net.NetworkInformation.GatewayIPAddressInformation this[int index] { get { throw null; } }
        public virtual void Add(System.Net.NetworkInformation.GatewayIPAddressInformation address) { }
        public virtual void Clear() { }
        public virtual bool Contains(System.Net.NetworkInformation.GatewayIPAddressInformation address) { throw null; }
        public virtual void CopyTo(System.Net.NetworkInformation.GatewayIPAddressInformation[] array, int offset) { }
        public virtual System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.GatewayIPAddressInformation> GetEnumerator() { throw null; }
        public virtual bool Remove(System.Net.NetworkInformation.GatewayIPAddressInformation address) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public abstract partial class IcmpV4Statistics
    {
        protected IcmpV4Statistics() { }
        public abstract long AddressMaskRepliesReceived { get; }
        public abstract long AddressMaskRepliesSent { get; }
        public abstract long AddressMaskRequestsReceived { get; }
        public abstract long AddressMaskRequestsSent { get; }
        public abstract long DestinationUnreachableMessagesReceived { get; }
        public abstract long DestinationUnreachableMessagesSent { get; }
        public abstract long EchoRepliesReceived { get; }
        public abstract long EchoRepliesSent { get; }
        public abstract long EchoRequestsReceived { get; }
        public abstract long EchoRequestsSent { get; }
        public abstract long ErrorsReceived { get; }
        public abstract long ErrorsSent { get; }
        public abstract long MessagesReceived { get; }
        public abstract long MessagesSent { get; }
        public abstract long ParameterProblemsReceived { get; }
        public abstract long ParameterProblemsSent { get; }
        public abstract long RedirectsReceived { get; }
        public abstract long RedirectsSent { get; }
        public abstract long SourceQuenchesReceived { get; }
        public abstract long SourceQuenchesSent { get; }
        public abstract long TimeExceededMessagesReceived { get; }
        public abstract long TimeExceededMessagesSent { get; }
        public abstract long TimestampRepliesReceived { get; }
        public abstract long TimestampRepliesSent { get; }
        public abstract long TimestampRequestsReceived { get; }
        public abstract long TimestampRequestsSent { get; }
    }
    public abstract partial class IcmpV6Statistics
    {
        protected IcmpV6Statistics() { }
        public abstract long DestinationUnreachableMessagesReceived { get; }
        public abstract long DestinationUnreachableMessagesSent { get; }
        public abstract long EchoRepliesReceived { get; }
        public abstract long EchoRepliesSent { get; }
        public abstract long EchoRequestsReceived { get; }
        public abstract long EchoRequestsSent { get; }
        public abstract long ErrorsReceived { get; }
        public abstract long ErrorsSent { get; }
        public abstract long MembershipQueriesReceived { get; }
        public abstract long MembershipQueriesSent { get; }
        public abstract long MembershipReductionsReceived { get; }
        public abstract long MembershipReductionsSent { get; }
        public abstract long MembershipReportsReceived { get; }
        public abstract long MembershipReportsSent { get; }
        public abstract long MessagesReceived { get; }
        public abstract long MessagesSent { get; }
        public abstract long NeighborAdvertisementsReceived { get; }
        public abstract long NeighborAdvertisementsSent { get; }
        public abstract long NeighborSolicitsReceived { get; }
        public abstract long NeighborSolicitsSent { get; }
        public abstract long PacketTooBigMessagesReceived { get; }
        public abstract long PacketTooBigMessagesSent { get; }
        public abstract long ParameterProblemsReceived { get; }
        public abstract long ParameterProblemsSent { get; }
        public abstract long RedirectsReceived { get; }
        public abstract long RedirectsSent { get; }
        public abstract long RouterAdvertisementsReceived { get; }
        public abstract long RouterAdvertisementsSent { get; }
        public abstract long RouterSolicitsReceived { get; }
        public abstract long RouterSolicitsSent { get; }
        public abstract long TimeExceededMessagesReceived { get; }
        public abstract long TimeExceededMessagesSent { get; }
    }
    public partial class IPAddressCollection : System.Collections.Generic.ICollection<System.Net.IPAddress>, System.Collections.Generic.IEnumerable<System.Net.IPAddress>, System.Collections.IEnumerable
    {
        protected internal IPAddressCollection() { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual System.Net.IPAddress this[int index] { get { throw null; } }
        public virtual void Add(System.Net.IPAddress address) { }
        public virtual void Clear() { }
        public virtual bool Contains(System.Net.IPAddress address) { throw null; }
        public virtual void CopyTo(System.Net.IPAddress[] array, int offset) { }
        public virtual System.Collections.Generic.IEnumerator<System.Net.IPAddress> GetEnumerator() { throw null; }
        public virtual bool Remove(System.Net.IPAddress address) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public abstract partial class IPAddressInformation
    {
        protected IPAddressInformation() { }
        public abstract System.Net.IPAddress Address { get; }
        public abstract bool IsDnsEligible { get; }
        public abstract bool IsTransient { get; }
    }
    public partial class IPAddressInformationCollection : System.Collections.Generic.ICollection<System.Net.NetworkInformation.IPAddressInformation>, System.Collections.Generic.IEnumerable<System.Net.NetworkInformation.IPAddressInformation>, System.Collections.IEnumerable
    {
        internal IPAddressInformationCollection() { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual System.Net.NetworkInformation.IPAddressInformation this[int index] { get { throw null; } }
        public virtual void Add(System.Net.NetworkInformation.IPAddressInformation address) { }
        public virtual void Clear() { }
        public virtual bool Contains(System.Net.NetworkInformation.IPAddressInformation address) { throw null; }
        public virtual void CopyTo(System.Net.NetworkInformation.IPAddressInformation[] array, int offset) { }
        public virtual System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.IPAddressInformation> GetEnumerator() { throw null; }
        public virtual bool Remove(System.Net.NetworkInformation.IPAddressInformation address) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public abstract partial class IPGlobalProperties
    {
        protected IPGlobalProperties() { }
        public abstract string DhcpScopeName { get; }
        public abstract string DomainName { get; }
        public abstract string HostName { get; }
        public abstract bool IsWinsProxy { get; }
        public abstract System.Net.NetworkInformation.NetBiosNodeType NodeType { get; }
        public virtual System.IAsyncResult BeginGetUnicastAddresses(System.AsyncCallback callback, object state) { throw null; }
        public virtual System.Net.NetworkInformation.UnicastIPAddressInformationCollection EndGetUnicastAddresses(System.IAsyncResult asyncResult) { throw null; }
        public abstract System.Net.NetworkInformation.TcpConnectionInformation[] GetActiveTcpConnections();
        public abstract System.Net.IPEndPoint[] GetActiveTcpListeners();
        public abstract System.Net.IPEndPoint[] GetActiveUdpListeners();
        public abstract System.Net.NetworkInformation.IcmpV4Statistics GetIcmpV4Statistics();
        public abstract System.Net.NetworkInformation.IcmpV6Statistics GetIcmpV6Statistics();
        public static System.Net.NetworkInformation.IPGlobalProperties GetIPGlobalProperties() { throw null; }
        public abstract System.Net.NetworkInformation.IPGlobalStatistics GetIPv4GlobalStatistics();
        public abstract System.Net.NetworkInformation.IPGlobalStatistics GetIPv6GlobalStatistics();
        public abstract System.Net.NetworkInformation.TcpStatistics GetTcpIPv4Statistics();
        public abstract System.Net.NetworkInformation.TcpStatistics GetTcpIPv6Statistics();
        public abstract System.Net.NetworkInformation.UdpStatistics GetUdpIPv4Statistics();
        public abstract System.Net.NetworkInformation.UdpStatistics GetUdpIPv6Statistics();
        public virtual System.Net.NetworkInformation.UnicastIPAddressInformationCollection GetUnicastAddresses() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Net.NetworkInformation.UnicastIPAddressInformationCollection> GetUnicastAddressesAsync() { throw null; }
    }
    public abstract partial class IPGlobalStatistics
    {
        protected IPGlobalStatistics() { }
        public abstract int DefaultTtl { get; }
        public abstract bool ForwardingEnabled { get; }
        public abstract int NumberOfInterfaces { get; }
        public abstract int NumberOfIPAddresses { get; }
        public abstract int NumberOfRoutes { get; }
        public abstract long OutputPacketRequests { get; }
        public abstract long OutputPacketRoutingDiscards { get; }
        public abstract long OutputPacketsDiscarded { get; }
        public abstract long OutputPacketsWithNoRoute { get; }
        public abstract long PacketFragmentFailures { get; }
        public abstract long PacketReassembliesRequired { get; }
        public abstract long PacketReassemblyFailures { get; }
        public abstract long PacketReassemblyTimeout { get; }
        public abstract long PacketsFragmented { get; }
        public abstract long PacketsReassembled { get; }
        public abstract long ReceivedPackets { get; }
        public abstract long ReceivedPacketsDelivered { get; }
        public abstract long ReceivedPacketsDiscarded { get; }
        public abstract long ReceivedPacketsForwarded { get; }
        public abstract long ReceivedPacketsWithAddressErrors { get; }
        public abstract long ReceivedPacketsWithHeadersErrors { get; }
        public abstract long ReceivedPacketsWithUnknownProtocol { get; }
    }
    public abstract partial class IPInterfaceProperties
    {
        protected IPInterfaceProperties() { }
        public abstract System.Net.NetworkInformation.IPAddressInformationCollection AnycastAddresses { get; }
        public abstract System.Net.NetworkInformation.IPAddressCollection DhcpServerAddresses { get; }
        public abstract System.Net.NetworkInformation.IPAddressCollection DnsAddresses { get; }
        public abstract string DnsSuffix { get; }
        public abstract System.Net.NetworkInformation.GatewayIPAddressInformationCollection GatewayAddresses { get; }
        public abstract bool IsDnsEnabled { get; }
        public abstract bool IsDynamicDnsEnabled { get; }
        public abstract System.Net.NetworkInformation.MulticastIPAddressInformationCollection MulticastAddresses { get; }
        public abstract System.Net.NetworkInformation.UnicastIPAddressInformationCollection UnicastAddresses { get; }
        public abstract System.Net.NetworkInformation.IPAddressCollection WinsServersAddresses { get; }
        public abstract System.Net.NetworkInformation.IPv4InterfaceProperties GetIPv4Properties();
        public abstract System.Net.NetworkInformation.IPv6InterfaceProperties GetIPv6Properties();
    }
    public abstract partial class IPInterfaceStatistics
    {
        protected IPInterfaceStatistics() { }
        public abstract long BytesReceived { get; }
        public abstract long BytesSent { get; }
        public abstract long IncomingPacketsDiscarded { get; }
        public abstract long IncomingPacketsWithErrors { get; }
        public abstract long IncomingUnknownProtocolPackets { get; }
        public abstract long NonUnicastPacketsReceived { get; }
        public abstract long NonUnicastPacketsSent { get; }
        public abstract long OutgoingPacketsDiscarded { get; }
        public abstract long OutgoingPacketsWithErrors { get; }
        public abstract long OutputQueueLength { get; }
        public abstract long UnicastPacketsReceived { get; }
        public abstract long UnicastPacketsSent { get; }
    }
    public enum IPStatus
    {
        Unknown = -1,
        Success = 0,
        DestinationNetworkUnreachable = 11002,
        DestinationHostUnreachable = 11003,
        DestinationProhibited = 11004,
        DestinationProtocolUnreachable = 11004,
        DestinationPortUnreachable = 11005,
        NoResources = 11006,
        BadOption = 11007,
        HardwareError = 11008,
        PacketTooBig = 11009,
        TimedOut = 11010,
        BadRoute = 11012,
        TtlExpired = 11013,
        TtlReassemblyTimeExceeded = 11014,
        ParameterProblem = 11015,
        SourceQuench = 11016,
        BadDestination = 11018,
        DestinationUnreachable = 11040,
        TimeExceeded = 11041,
        BadHeader = 11042,
        UnrecognizedNextHeader = 11043,
        IcmpError = 11044,
        DestinationScopeMismatch = 11045,
    }
    public abstract partial class IPv4InterfaceProperties
    {
        protected IPv4InterfaceProperties() { }
        public abstract int Index { get; }
        public abstract bool IsAutomaticPrivateAddressingActive { get; }
        public abstract bool IsAutomaticPrivateAddressingEnabled { get; }
        public abstract bool IsDhcpEnabled { get; }
        public abstract bool IsForwardingEnabled { get; }
        public abstract int Mtu { get; }
        public abstract bool UsesWins { get; }
    }
    public abstract partial class IPv4InterfaceStatistics
    {
        protected IPv4InterfaceStatistics() { }
        public abstract long BytesReceived { get; }
        public abstract long BytesSent { get; }
        public abstract long IncomingPacketsDiscarded { get; }
        public abstract long IncomingPacketsWithErrors { get; }
        public abstract long IncomingUnknownProtocolPackets { get; }
        public abstract long NonUnicastPacketsReceived { get; }
        public abstract long NonUnicastPacketsSent { get; }
        public abstract long OutgoingPacketsDiscarded { get; }
        public abstract long OutgoingPacketsWithErrors { get; }
        public abstract long OutputQueueLength { get; }
        public abstract long UnicastPacketsReceived { get; }
        public abstract long UnicastPacketsSent { get; }
    }
    public abstract partial class IPv6InterfaceProperties
    {
        protected IPv6InterfaceProperties() { }
        public abstract int Index { get; }
        public abstract int Mtu { get; }
        public virtual long GetScopeId(System.Net.NetworkInformation.ScopeLevel scopeLevel) { throw null; }
    }
    public abstract partial class MulticastIPAddressInformation : System.Net.NetworkInformation.IPAddressInformation
    {
        protected MulticastIPAddressInformation() { }
        public abstract long AddressPreferredLifetime { get; }
        public abstract long AddressValidLifetime { get; }
        public abstract long DhcpLeaseLifetime { get; }
        public abstract System.Net.NetworkInformation.DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }
        public abstract System.Net.NetworkInformation.PrefixOrigin PrefixOrigin { get; }
        public abstract System.Net.NetworkInformation.SuffixOrigin SuffixOrigin { get; }
    }
    public partial class MulticastIPAddressInformationCollection : System.Collections.Generic.ICollection<System.Net.NetworkInformation.MulticastIPAddressInformation>, System.Collections.Generic.IEnumerable<System.Net.NetworkInformation.MulticastIPAddressInformation>, System.Collections.IEnumerable
    {
        protected internal MulticastIPAddressInformationCollection() { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual System.Net.NetworkInformation.MulticastIPAddressInformation this[int index] { get { throw null; } }
        public virtual void Add(System.Net.NetworkInformation.MulticastIPAddressInformation address) { }
        public virtual void Clear() { }
        public virtual bool Contains(System.Net.NetworkInformation.MulticastIPAddressInformation address) { throw null; }
        public virtual void CopyTo(System.Net.NetworkInformation.MulticastIPAddressInformation[] array, int offset) { }
        public virtual System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.MulticastIPAddressInformation> GetEnumerator() { throw null; }
        public virtual bool Remove(System.Net.NetworkInformation.MulticastIPAddressInformation address) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public enum NetBiosNodeType
    {
        Unknown = 0,
        Broadcast = 1,
        Peer2Peer = 2,
        Mixed = 4,
        Hybrid = 8,
    }
    public delegate void NetworkAddressChangedEventHandler(object sender, System.EventArgs e);
    public delegate void NetworkAvailabilityChangedEventHandler(object sender, System.Net.NetworkInformation.NetworkAvailabilityEventArgs e);
    public partial class NetworkAvailabilityEventArgs : System.EventArgs
    {
        internal NetworkAvailabilityEventArgs() { }
        public bool IsAvailable { get { throw null; } }
    }
    public sealed partial class NetworkChange
    {
        public NetworkChange() { }
        public static event System.Net.NetworkInformation.NetworkAddressChangedEventHandler NetworkAddressChanged { add { } remove { } }
        public static event System.Net.NetworkInformation.NetworkAvailabilityChangedEventHandler NetworkAvailabilityChanged { add { } remove { } }
    }
    [System.FlagsAttribute]
    public enum NetworkInformationAccess
    {
        None = 0,
        Read = 1,
        Ping = 4,
    }
    public partial class NetworkInformationException : System.ComponentModel.Win32Exception
    {
        public NetworkInformationException() { }
        public NetworkInformationException(int errorCode) { }
        protected NetworkInformationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override int ErrorCode { get { throw null; } }
    }
    public sealed partial class NetworkInformationPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public NetworkInformationPermission(System.Net.NetworkInformation.NetworkInformationAccess access) { }
        public NetworkInformationPermission(System.Security.Permissions.PermissionState state) { }
        public System.Net.NetworkInformation.NetworkInformationAccess Access { get { throw null; } }
        public void AddPermission(System.Net.NetworkInformation.NetworkInformationAccess access) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Struct, AllowMultiple=true, Inherited=false)]
    public sealed partial class NetworkInformationPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Access { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    public abstract partial class NetworkInterface
    {
        protected NetworkInterface() { }
        public virtual string Description { get { throw null; } }
        public virtual string Id { get { throw null; } }
        public static int IPv6LoopbackInterfaceIndex { get { throw null; } }
        public virtual bool IsReceiveOnly { get { throw null; } }
        public static int LoopbackInterfaceIndex { get { throw null; } }
        public virtual string Name { get { throw null; } }
        public virtual System.Net.NetworkInformation.NetworkInterfaceType NetworkInterfaceType { get { throw null; } }
        public virtual System.Net.NetworkInformation.OperationalStatus OperationalStatus { get { throw null; } }
        public virtual long Speed { get { throw null; } }
        public virtual bool SupportsMulticast { get { throw null; } }
        public static System.Net.NetworkInformation.NetworkInterface[] GetAllNetworkInterfaces() { throw null; }
        public virtual System.Net.NetworkInformation.IPInterfaceProperties GetIPProperties() { throw null; }
        public virtual System.Net.NetworkInformation.IPInterfaceStatistics GetIPStatistics() { throw null; }
        public virtual System.Net.NetworkInformation.IPv4InterfaceStatistics GetIPv4Statistics() { throw null; }
        public static bool GetIsNetworkAvailable() { throw null; }
        public virtual System.Net.NetworkInformation.PhysicalAddress GetPhysicalAddress() { throw null; }
        public virtual bool Supports(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterfaceComponent) { throw null; }
    }
    public enum NetworkInterfaceComponent
    {
        IPv4 = 0,
        IPv6 = 1,
    }
    public enum NetworkInterfaceType
    {
        Unknown = 1,
        Ethernet = 6,
        TokenRing = 9,
        Fddi = 15,
        BasicIsdn = 20,
        PrimaryIsdn = 21,
        Ppp = 23,
        Loopback = 24,
        Ethernet3Megabit = 26,
        Slip = 28,
        Atm = 37,
        GenericModem = 48,
        FastEthernetT = 62,
        Isdn = 63,
        FastEthernetFx = 69,
        Wireless80211 = 71,
        AsymmetricDsl = 94,
        RateAdaptDsl = 95,
        SymmetricDsl = 96,
        VeryHighSpeedDsl = 97,
        IPOverAtm = 114,
        GigabitEthernet = 117,
        Tunnel = 131,
        MultiRateSymmetricDsl = 143,
        HighPerformanceSerialBus = 144,
        Wman = 237,
        Wwanpp = 243,
        Wwanpp2 = 244,
    }
    public enum OperationalStatus
    {
        Up = 1,
        Down = 2,
        Testing = 3,
        Unknown = 4,
        Dormant = 5,
        NotPresent = 6,
        LowerLayerDown = 7,
    }
    public partial class PhysicalAddress
    {
        public static readonly System.Net.NetworkInformation.PhysicalAddress None;
        public PhysicalAddress(byte[] address) { }
        public override bool Equals(object comparand) { throw null; }
        public byte[] GetAddressBytes() { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Net.NetworkInformation.PhysicalAddress Parse(string address) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Ping : System.ComponentModel.Component, System.IDisposable
    {
        public Ping() { }
        public event System.Net.NetworkInformation.PingCompletedEventHandler PingCompleted { add { } remove { } }
        protected void OnPingCompleted(System.Net.NetworkInformation.PingCompletedEventArgs e) { }
        public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address) { throw null; }
        public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address, int timeout) { throw null; }
        public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address, int timeout, byte[] buffer) { throw null; }
        public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options) { throw null; }
        public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress) { throw null; }
        public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress, int timeout) { throw null; }
        public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer) { throw null; }
        public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options) { throw null; }
        public void SendAsync(System.Net.IPAddress address, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options, object userToken) { }
        public void SendAsync(System.Net.IPAddress address, int timeout, byte[] buffer, object userToken) { }
        public void SendAsync(System.Net.IPAddress address, int timeout, object userToken) { }
        public void SendAsync(System.Net.IPAddress address, object userToken) { }
        public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options, object userToken) { }
        public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, object userToken) { }
        public void SendAsync(string hostNameOrAddress, int timeout, object userToken) { }
        public void SendAsync(string hostNameOrAddress, object userToken) { }
        public void SendAsyncCancel() { }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(System.Net.IPAddress address) { throw null; }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(System.Net.IPAddress address, int timeout) { throw null; }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(System.Net.IPAddress address, int timeout, byte[] buffer) { throw null; }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(System.Net.IPAddress address, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options) { throw null; }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(string hostNameOrAddress) { throw null; }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(string hostNameOrAddress, int timeout) { throw null; }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer) { throw null; }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options) { throw null; }
        void System.IDisposable.Dispose() { }
    }
    public partial class PingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal PingCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public System.Net.NetworkInformation.PingReply Reply { get { throw null; } }
    }
    public delegate void PingCompletedEventHandler(object sender, System.Net.NetworkInformation.PingCompletedEventArgs e);
    public partial class PingException : System.InvalidOperationException
    {
        protected PingException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public PingException(string message) { }
        public PingException(string message, System.Exception innerException) { }
    }
    public partial class PingOptions
    {
        public PingOptions() { }
        public PingOptions(int ttl, bool dontFragment) { }
        public bool DontFragment { get { throw null; } set { } }
        public int Ttl { get { throw null; } set { } }
    }
    public partial class PingReply
    {
        internal PingReply() { }
        public System.Net.IPAddress Address { get { throw null; } }
        public byte[] Buffer { get { throw null; } }
        public System.Net.NetworkInformation.PingOptions Options { get { throw null; } }
        public long RoundtripTime { get { throw null; } }
        public System.Net.NetworkInformation.IPStatus Status { get { throw null; } }
    }
    public enum PrefixOrigin
    {
        Other = 0,
        Manual = 1,
        WellKnown = 2,
        Dhcp = 3,
        RouterAdvertisement = 4,
    }
    public enum ScopeLevel
    {
        None = 0,
        Interface = 1,
        Link = 2,
        Subnet = 3,
        Admin = 4,
        Site = 5,
        Organization = 8,
        Global = 14,
    }
    public enum SuffixOrigin
    {
        Other = 0,
        Manual = 1,
        WellKnown = 2,
        OriginDhcp = 3,
        LinkLayerAddress = 4,
        Random = 5,
    }
    public abstract partial class TcpConnectionInformation
    {
        protected TcpConnectionInformation() { }
        public abstract System.Net.IPEndPoint LocalEndPoint { get; }
        public abstract System.Net.IPEndPoint RemoteEndPoint { get; }
        public abstract System.Net.NetworkInformation.TcpState State { get; }
    }
    public enum TcpState
    {
        Unknown = 0,
        Closed = 1,
        Listen = 2,
        SynSent = 3,
        SynReceived = 4,
        Established = 5,
        FinWait1 = 6,
        FinWait2 = 7,
        CloseWait = 8,
        Closing = 9,
        LastAck = 10,
        TimeWait = 11,
        DeleteTcb = 12,
    }
    public abstract partial class TcpStatistics
    {
        protected TcpStatistics() { }
        public abstract long ConnectionsAccepted { get; }
        public abstract long ConnectionsInitiated { get; }
        public abstract long CumulativeConnections { get; }
        public abstract long CurrentConnections { get; }
        public abstract long ErrorsReceived { get; }
        public abstract long FailedConnectionAttempts { get; }
        public abstract long MaximumConnections { get; }
        public abstract long MaximumTransmissionTimeout { get; }
        public abstract long MinimumTransmissionTimeout { get; }
        public abstract long ResetConnections { get; }
        public abstract long ResetsSent { get; }
        public abstract long SegmentsReceived { get; }
        public abstract long SegmentsResent { get; }
        public abstract long SegmentsSent { get; }
    }
    public abstract partial class UdpStatistics
    {
        protected UdpStatistics() { }
        public abstract long DatagramsReceived { get; }
        public abstract long DatagramsSent { get; }
        public abstract long IncomingDatagramsDiscarded { get; }
        public abstract long IncomingDatagramsWithErrors { get; }
        public abstract int UdpListeners { get; }
    }
    public abstract partial class UnicastIPAddressInformation : System.Net.NetworkInformation.IPAddressInformation
    {
        protected UnicastIPAddressInformation() { }
        public abstract long AddressPreferredLifetime { get; }
        public abstract long AddressValidLifetime { get; }
        public abstract long DhcpLeaseLifetime { get; }
        public abstract System.Net.NetworkInformation.DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }
        public abstract System.Net.IPAddress IPv4Mask { get; }
        public virtual int PrefixLength { get { throw null; } }
        public abstract System.Net.NetworkInformation.PrefixOrigin PrefixOrigin { get; }
        public abstract System.Net.NetworkInformation.SuffixOrigin SuffixOrigin { get; }
    }
    public partial class UnicastIPAddressInformationCollection : System.Collections.Generic.ICollection<System.Net.NetworkInformation.UnicastIPAddressInformation>, System.Collections.Generic.IEnumerable<System.Net.NetworkInformation.UnicastIPAddressInformation>, System.Collections.IEnumerable
    {
        protected internal UnicastIPAddressInformationCollection() { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual System.Net.NetworkInformation.UnicastIPAddressInformation this[int index] { get { throw null; } }
        public virtual void Add(System.Net.NetworkInformation.UnicastIPAddressInformation address) { }
        public virtual void Clear() { }
        public virtual bool Contains(System.Net.NetworkInformation.UnicastIPAddressInformation address) { throw null; }
        public virtual void CopyTo(System.Net.NetworkInformation.UnicastIPAddressInformation[] array, int offset) { }
        public virtual System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.UnicastIPAddressInformation> GetEnumerator() { throw null; }
        public virtual bool Remove(System.Net.NetworkInformation.UnicastIPAddressInformation address) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
}
namespace System.Net.Security
{
    public abstract partial class AuthenticatedStream : System.IO.Stream
    {
        protected AuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen) { }
        protected System.IO.Stream InnerStream { get { throw null; } }
        public abstract bool IsAuthenticated { get; }
        public abstract bool IsEncrypted { get; }
        public abstract bool IsMutuallyAuthenticated { get; }
        public abstract bool IsServer { get; }
        public abstract bool IsSigned { get; }
        public bool LeaveInnerStreamOpen { get { throw null; } }
        protected override void Dispose(bool disposing) { }
    }
    public enum AuthenticationLevel
    {
        None = 0,
        MutualAuthRequested = 1,
        MutualAuthRequired = 2,
    }
    public enum EncryptionPolicy
    {
        RequireEncryption = 0,
        AllowNoEncryption = 1,
        NoEncryption = 2,
    }
    public delegate System.Security.Cryptography.X509Certificates.X509Certificate LocalCertificateSelectionCallback(object sender, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
    public partial class NegotiateStream : System.Net.Security.AuthenticatedStream
    {
        public NegotiateStream(System.IO.Stream innerStream) : base (default(System.IO.Stream), default(bool)) { }
        public NegotiateStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen) : base (default(System.IO.Stream), default(bool)) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanTimeout { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public virtual System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get { throw null; } }
        public override bool IsAuthenticated { get { throw null; } }
        public override bool IsEncrypted { get { throw null; } }
        public override bool IsMutuallyAuthenticated { get { throw null; } }
        public override bool IsServer { get { throw null; } }
        public override bool IsSigned { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override int ReadTimeout { get { throw null; } set { } }
        public virtual System.Security.Principal.IIdentity RemoteIdentity { get { throw null; } }
        public override int WriteTimeout { get { throw null; } set { } }
        public virtual void AuthenticateAsClient() { }
        public virtual void AuthenticateAsClient(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ChannelBinding binding, string targetName) { }
        public virtual void AuthenticateAsClient(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ChannelBinding binding, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel) { }
        public virtual void AuthenticateAsClient(System.Net.NetworkCredential credential, string targetName) { }
        public virtual void AuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel) { }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync() { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ChannelBinding binding, string targetName) { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ChannelBinding binding, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel) { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(System.Net.NetworkCredential credential, string targetName) { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(System.Net.NetworkCredential credential, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel) { throw null; }
        public virtual void AuthenticateAsServer() { }
        public virtual void AuthenticateAsServer(System.Net.NetworkCredential credential, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel) { }
        public virtual void AuthenticateAsServer(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy policy, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel) { }
        public virtual void AuthenticateAsServer(System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy policy) { }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync() { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Net.NetworkCredential credential, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel) { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy policy, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel) { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy policy) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ChannelBinding binding, string targetName, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ChannelBinding binding, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsServer(System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Net.NetworkCredential credential, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy policy, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy policy, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        protected override void Dispose(bool disposing) { }
        public virtual void EndAuthenticateAsClient(System.IAsyncResult asyncResult) { }
        public virtual void EndAuthenticateAsServer(System.IAsyncResult asyncResult) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
    public enum ProtectionLevel
    {
        None = 0,
        Sign = 1,
        EncryptAndSign = 2,
    }
    public delegate bool RemoteCertificateValidationCallback(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
    public delegate System.Security.Cryptography.X509Certificates.X509Certificate ServerCertificateSelectionCallback(object sender, string hostName);
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SslApplicationProtocol : System.IEquatable<System.Net.Security.SslApplicationProtocol>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static readonly System.Net.Security.SslApplicationProtocol Http11;
        public static readonly System.Net.Security.SslApplicationProtocol Http2;
        public SslApplicationProtocol(byte[] protocol) { throw null; }
        public SslApplicationProtocol(string protocol) { throw null; }
        public System.ReadOnlyMemory<byte> Protocol { get { throw null; } }
        public bool Equals(System.Net.Security.SslApplicationProtocol other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Net.Security.SslApplicationProtocol left, System.Net.Security.SslApplicationProtocol right) { throw null; }
        public static bool operator !=(System.Net.Security.SslApplicationProtocol left, System.Net.Security.SslApplicationProtocol right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SslClientAuthenticationOptions
    {
        public SslClientAuthenticationOptions() { }
        public bool AllowRenegotiation { get { throw null; } set { } }
        public System.Collections.Generic.List<System.Net.Security.SslApplicationProtocol> ApplicationProtocols { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509RevocationMode CertificateRevocationCheckMode { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } set { } }
        public System.Security.Authentication.SslProtocols EnabledSslProtocols { get { throw null; } set { } }
        public System.Net.Security.EncryptionPolicy EncryptionPolicy { get { throw null; } set { } }
        public System.Net.Security.LocalCertificateSelectionCallback LocalCertificateSelectionCallback { get { throw null; } set { } }
        public System.Net.Security.RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get { throw null; } set { } }
        public string TargetHost { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum SslPolicyErrors
    {
        None = 0,
        RemoteCertificateNotAvailable = 1,
        RemoteCertificateNameMismatch = 2,
        RemoteCertificateChainErrors = 4,
    }
    public partial class SslServerAuthenticationOptions
    {
        public SslServerAuthenticationOptions() { }
        public bool AllowRenegotiation { get { throw null; } set { } }
        public System.Collections.Generic.List<System.Net.Security.SslApplicationProtocol> ApplicationProtocols { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509RevocationMode CertificateRevocationCheckMode { get { throw null; } set { } }
        public bool ClientCertificateRequired { get { throw null; } set { } }
        public System.Security.Authentication.SslProtocols EnabledSslProtocols { get { throw null; } set { } }
        public System.Net.Security.EncryptionPolicy EncryptionPolicy { get { throw null; } set { } }
        public System.Net.Security.RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509Certificate ServerCertificate { get { throw null; } set { } }
        public System.Net.Security.ServerCertificateSelectionCallback ServerCertificateSelectionCallback { get { throw null; } set { } }
    }
    public partial class SslStream : System.Net.Security.AuthenticatedStream
    {
        public SslStream(System.IO.Stream innerStream) : base (default(System.IO.Stream), default(bool)) { }
        public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen) : base (default(System.IO.Stream), default(bool)) { }
        public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback) : base (default(System.IO.Stream), default(bool)) { }
        public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback) : base (default(System.IO.Stream), default(bool)) { }
        public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback, System.Net.Security.EncryptionPolicy encryptionPolicy) : base (default(System.IO.Stream), default(bool)) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanTimeout { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public virtual bool CheckCertRevocationStatus { get { throw null; } }
        public virtual System.Security.Authentication.CipherAlgorithmType CipherAlgorithm { get { throw null; } }
        public virtual int CipherStrength { get { throw null; } }
        public virtual System.Security.Authentication.HashAlgorithmType HashAlgorithm { get { throw null; } }
        public virtual int HashStrength { get { throw null; } }
        public override bool IsAuthenticated { get { throw null; } }
        public override bool IsEncrypted { get { throw null; } }
        public override bool IsMutuallyAuthenticated { get { throw null; } }
        public override bool IsServer { get { throw null; } }
        public override bool IsSigned { get { throw null; } }
        public virtual System.Security.Authentication.ExchangeAlgorithmType KeyExchangeAlgorithm { get { throw null; } }
        public virtual int KeyExchangeStrength { get { throw null; } }
        public override long Length { get { throw null; } }
        public virtual System.Security.Cryptography.X509Certificates.X509Certificate LocalCertificate { get { throw null; } }
        public System.Net.Security.SslApplicationProtocol NegotiatedApplicationProtocol { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override int ReadTimeout { get { throw null; } set { } }
        public virtual System.Security.Cryptography.X509Certificates.X509Certificate RemoteCertificate { get { throw null; } }
        public virtual System.Security.Authentication.SslProtocols SslProtocol { get { throw null; } }
        public System.Net.TransportContext TransportContext { get { throw null; } }
        public override int WriteTimeout { get { throw null; } set { } }
        public virtual void AuthenticateAsClient(string targetHost) { }
        public virtual void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, bool checkCertificateRevocation) { }
        public virtual void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }
        public System.Threading.Tasks.Task AuthenticateAsClientAsync(System.Net.Security.SslClientAuthenticationOptions sslClientAuthenticationOptions, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost) { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, bool checkCertificateRevocation) { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { throw null; }
        public virtual void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate) { }
        public virtual void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation) { }
        public virtual void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }
        public System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Net.Security.SslServerAuthenticationOptions sslServerAuthenticationOptions, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate) { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation) { throw null; }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public virtual void EndAuthenticateAsClient(System.IAsyncResult asyncResult) { }
        public virtual void EndAuthenticateAsServer(System.IAsyncResult asyncResult) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public virtual System.Threading.Tasks.Task ShutdownAsync() { throw null; }
        public void Write(byte[] buffer) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
}
namespace System.Net.Sockets
{
    public enum AddressFamily
    {
        Unknown = -1,
        Unspecified = 0,
        Unix = 1,
        InterNetwork = 2,
        ImpLink = 3,
        Pup = 4,
        Chaos = 5,
        Ipx = 6,
        NS = 6,
        Iso = 7,
        Osi = 7,
        Ecma = 8,
        DataKit = 9,
        Ccitt = 10,
        Sna = 11,
        DecNet = 12,
        DataLink = 13,
        Lat = 14,
        HyperChannel = 15,
        AppleTalk = 16,
        NetBios = 17,
        VoiceView = 18,
        FireFox = 19,
        Banyan = 21,
        Atm = 22,
        InterNetworkV6 = 23,
        Cluster = 24,
        Ieee12844 = 25,
        Irda = 26,
        NetworkDesigners = 28,
        Max = 29,
    }
    public enum IOControlCode : long
    {
        EnableCircularQueuing = (long)671088642,
        Flush = (long)671088644,
        AddressListChange = (long)671088663,
        DataToRead = (long)1074030207,
        OobDataRead = (long)1074033415,
        GetBroadcastAddress = (long)1207959557,
        AddressListQuery = (long)1207959574,
        QueryTargetPnpHandle = (long)1207959576,
        AsyncIO = (long)2147772029,
        NonBlockingIO = (long)2147772030,
        AssociateHandle = (long)2281701377,
        MultipointLoopback = (long)2281701385,
        MulticastScope = (long)2281701386,
        SetQos = (long)2281701387,
        SetGroupQos = (long)2281701388,
        RoutingInterfaceChange = (long)2281701397,
        NamespaceChange = (long)2281701401,
        ReceiveAll = (long)2550136833,
        ReceiveAllMulticast = (long)2550136834,
        ReceiveAllIgmpMulticast = (long)2550136835,
        KeepAliveValues = (long)2550136836,
        AbsorbRouterAlert = (long)2550136837,
        UnicastInterface = (long)2550136838,
        LimitBroadcasts = (long)2550136839,
        BindToInterface = (long)2550136840,
        MulticastInterface = (long)2550136841,
        AddMulticastGroupOnInterface = (long)2550136842,
        DeleteMulticastGroupFromInterface = (long)2550136843,
        GetExtensionFunctionPointer = (long)3355443206,
        GetQos = (long)3355443207,
        GetGroupQos = (long)3355443208,
        TranslateHandle = (long)3355443213,
        RoutingInterfaceQuery = (long)3355443220,
        AddressListSort = (long)3355443225,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct IPPacketInformation
    {
        private object _dummy;
        private int _dummyPrimitive;
        public System.Net.IPAddress Address { get { throw null; } }
        public int Interface { get { throw null; } }
        public override bool Equals(object comparand) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Net.Sockets.IPPacketInformation packetInformation1, System.Net.Sockets.IPPacketInformation packetInformation2) { throw null; }
        public static bool operator !=(System.Net.Sockets.IPPacketInformation packetInformation1, System.Net.Sockets.IPPacketInformation packetInformation2) { throw null; }
    }
    public enum IPProtectionLevel
    {
        Unspecified = -1,
        Unrestricted = 10,
        EdgeRestricted = 20,
        Restricted = 30,
    }
    public partial class IPv6MulticastOption
    {
        public IPv6MulticastOption(System.Net.IPAddress group) { }
        public IPv6MulticastOption(System.Net.IPAddress group, long ifindex) { }
        public System.Net.IPAddress Group { get { throw null; } set { } }
        public long InterfaceIndex { get { throw null; } set { } }
    }
    public partial class LingerOption
    {
        public LingerOption(bool enable, int seconds) { }
        public bool Enabled { get { throw null; } set { } }
        public int LingerTime { get { throw null; } set { } }
    }
    public partial class MulticastOption
    {
        public MulticastOption(System.Net.IPAddress group) { }
        public MulticastOption(System.Net.IPAddress group, int interfaceIndex) { }
        public MulticastOption(System.Net.IPAddress group, System.Net.IPAddress mcint) { }
        public System.Net.IPAddress Group { get { throw null; } set { } }
        public int InterfaceIndex { get { throw null; } set { } }
        public System.Net.IPAddress LocalAddress { get { throw null; } set { } }
    }
    public partial class NetworkStream : System.IO.Stream
    {
        public NetworkStream(System.Net.Sockets.Socket socket) { }
        public NetworkStream(System.Net.Sockets.Socket socket, bool ownsSocket) { }
        public NetworkStream(System.Net.Sockets.Socket socket, System.IO.FileAccess access) { }
        public NetworkStream(System.Net.Sockets.Socket socket, System.IO.FileAccess access, bool ownsSocket) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanTimeout { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public virtual bool DataAvailable { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        protected bool Readable { get { throw null; } set { } }
        public override int ReadTimeout { get { throw null; } set { } }
        protected System.Net.Sockets.Socket Socket { get { throw null; } }
        protected bool Writeable { get { throw null; } set { } }
        public override int WriteTimeout { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state) { throw null; }
        public void Close(int timeout) { }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        ~NetworkStream() { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int size) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int size) { }
    }
    public enum ProtocolFamily
    {
        Unknown = -1,
        Unspecified = 0,
        Unix = 1,
        InterNetwork = 2,
        ImpLink = 3,
        Pup = 4,
        Chaos = 5,
        Ipx = 6,
        NS = 6,
        Iso = 7,
        Osi = 7,
        Ecma = 8,
        DataKit = 9,
        Ccitt = 10,
        Sna = 11,
        DecNet = 12,
        DataLink = 13,
        Lat = 14,
        HyperChannel = 15,
        AppleTalk = 16,
        NetBios = 17,
        VoiceView = 18,
        FireFox = 19,
        Banyan = 21,
        Atm = 22,
        InterNetworkV6 = 23,
        Cluster = 24,
        Ieee12844 = 25,
        Irda = 26,
        NetworkDesigners = 28,
        Max = 29,
    }
    public enum ProtocolType
    {
        Unknown = -1,
        IP = 0,
        IPv6HopByHopOptions = 0,
        Unspecified = 0,
        Icmp = 1,
        Igmp = 2,
        Ggp = 3,
        IPv4 = 4,
        Tcp = 6,
        Pup = 12,
        Udp = 17,
        Idp = 22,
        IPv6 = 41,
        IPv6RoutingHeader = 43,
        IPv6FragmentHeader = 44,
        IPSecEncapsulatingSecurityPayload = 50,
        IPSecAuthenticationHeader = 51,
        IcmpV6 = 58,
        IPv6NoNextHeader = 59,
        IPv6DestinationOptions = 60,
        ND = 77,
        Raw = 255,
        Ipx = 1000,
        Spx = 1256,
        SpxII = 1257,
    }
    public enum SelectMode
    {
        SelectRead = 0,
        SelectWrite = 1,
        SelectError = 2,
    }
    public partial class SendPacketsElement
    {
        public SendPacketsElement(byte[] buffer) { }
        public SendPacketsElement(byte[] buffer, int offset, int count) { }
        public SendPacketsElement(byte[] buffer, int offset, int count, bool endOfPacket) { }
        public SendPacketsElement(string filepath) { }
        public SendPacketsElement(string filepath, int offset, int count) { }
        public SendPacketsElement(string filepath, int offset, int count, bool endOfPacket) { }
        public byte[] Buffer { get { throw null; } }
        public int Count { get { throw null; } }
        public bool EndOfPacket { get { throw null; } }
        public string FilePath { get { throw null; } }
        public int Offset { get { throw null; } }
    }
    public partial class Socket : System.IDisposable
    {
        public Socket(System.Net.Sockets.AddressFamily addressFamily, System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType) { }
        public Socket(System.Net.Sockets.SocketInformation socketInformation) { }
        public Socket(System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType) { }
        public System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public int Available { get { throw null; } }
        public bool Blocking { get { throw null; } set { } }
        public bool Connected { get { throw null; } }
        public bool DontFragment { get { throw null; } set { } }
        public bool DualMode { get { throw null; } set { } }
        public bool EnableBroadcast { get { throw null; } set { } }
        public bool ExclusiveAddressUse { get { throw null; } set { } }
        public System.IntPtr Handle { get { throw null; } }
        public bool IsBound { get { throw null; } }
        public System.Net.Sockets.LingerOption LingerState { get { throw null; } set { } }
        public System.Net.EndPoint LocalEndPoint { get { throw null; } }
        public bool MulticastLoopback { get { throw null; } set { } }
        public bool NoDelay { get { throw null; } set { } }
        public static bool OSSupportsIPv4 { get { throw null; } }
        public static bool OSSupportsIPv6 { get { throw null; } }
        public System.Net.Sockets.ProtocolType ProtocolType { get { throw null; } }
        public int ReceiveBufferSize { get { throw null; } set { } }
        public int ReceiveTimeout { get { throw null; } set { } }
        public System.Net.EndPoint RemoteEndPoint { get { throw null; } }
        public int SendBufferSize { get { throw null; } set { } }
        public int SendTimeout { get { throw null; } set { } }
        public System.Net.Sockets.SocketType SocketType { get { throw null; } }
        [System.ObsoleteAttribute("SupportsIPv4 is obsoleted for this type, please use OSSupportsIPv4 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static bool SupportsIPv4 { get { throw null; } }
        [System.ObsoleteAttribute("SupportsIPv6 is obsoleted for this type, please use OSSupportsIPv6 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static bool SupportsIPv6 { get { throw null; } }
        public short Ttl { get { throw null; } set { } }
        public bool UseOnlyOverlappedIO { get { throw null; } set { } }
        public System.Net.Sockets.Socket Accept() { throw null; }
        public bool AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs e) { throw null; }
        public System.IAsyncResult BeginAccept(System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginAccept(int receiveSize, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginAccept(System.Net.Sockets.Socket acceptSocket, int receiveSize, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginConnect(System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginConnect(System.Net.IPAddress address, int port, System.AsyncCallback requestCallback, object state) { throw null; }
        public System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, int port, System.AsyncCallback requestCallback, object state) { throw null; }
        public System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback requestCallback, object state) { throw null; }
        public System.IAsyncResult BeginDisconnect(bool reuseSocket, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginReceive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public System.IAsyncResult BeginReceive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginReceiveMessageFrom(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginSend(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public System.IAsyncResult BeginSend(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginSendFile(string fileName, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginSendFile(string fileName, byte[] preBuffer, byte[] postBuffer, System.Net.Sockets.TransmitFileOptions flags, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state) { throw null; }
        public void Bind(System.Net.EndPoint localEP) { }
        public static void CancelConnectAsync(System.Net.Sockets.SocketAsyncEventArgs e) { }
        public void Close() { }
        public void Close(int timeout) { }
        public void Connect(System.Net.EndPoint remoteEP) { }
        public void Connect(System.Net.IPAddress address, int port) { }
        public void Connect(System.Net.IPAddress[] addresses, int port) { }
        public void Connect(string host, int port) { }
        public bool ConnectAsync(System.Net.Sockets.SocketAsyncEventArgs e) { throw null; }
        public static bool ConnectAsync(System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType, System.Net.Sockets.SocketAsyncEventArgs e) { throw null; }
        public void Disconnect(bool reuseSocket) { }
        public bool DisconnectAsync(System.Net.Sockets.SocketAsyncEventArgs e) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.Net.Sockets.SocketInformation DuplicateAndClose(int targetProcessId) { throw null; }
        public System.Net.Sockets.Socket EndAccept(out byte[] buffer, System.IAsyncResult asyncResult) { throw null; }
        public System.Net.Sockets.Socket EndAccept(out byte[] buffer, out int bytesTransferred, System.IAsyncResult asyncResult) { throw null; }
        public System.Net.Sockets.Socket EndAccept(System.IAsyncResult asyncResult) { throw null; }
        public void EndConnect(System.IAsyncResult asyncResult) { }
        public void EndDisconnect(System.IAsyncResult asyncResult) { }
        public int EndReceive(System.IAsyncResult asyncResult) { throw null; }
        public int EndReceive(System.IAsyncResult asyncResult, out System.Net.Sockets.SocketError errorCode) { throw null; }
        public int EndReceiveFrom(System.IAsyncResult asyncResult, ref System.Net.EndPoint endPoint) { throw null; }
        public int EndReceiveMessageFrom(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint endPoint, out System.Net.Sockets.IPPacketInformation ipPacketInformation) { throw null; }
        public int EndSend(System.IAsyncResult asyncResult) { throw null; }
        public int EndSend(System.IAsyncResult asyncResult, out System.Net.Sockets.SocketError errorCode) { throw null; }
        public void EndSendFile(System.IAsyncResult asyncResult) { }
        public int EndSendTo(System.IAsyncResult asyncResult) { throw null; }
        ~Socket() { }
        public object GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName) { throw null; }
        public void GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, byte[] optionValue) { }
        public byte[] GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionLength) { throw null; }
        public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { throw null; }
        public int IOControl(System.Net.Sockets.IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { throw null; }
        public void Listen(int backlog) { }
        public bool Poll(int microSeconds, System.Net.Sockets.SelectMode mode) { throw null; }
        public int Receive(byte[] buffer) { throw null; }
        public int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode) { throw null; }
        public int Receive(byte[] buffer, int size, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public int Receive(byte[] buffer, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers) { throw null; }
        public int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode) { throw null; }
        public int Receive(System.Span<byte> buffer) { throw null; }
        public int Receive(System.Span<byte> buffer, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public int Receive(System.Span<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode) { throw null; }
        public bool ReceiveAsync(System.Net.Sockets.SocketAsyncEventArgs e) { throw null; }
        public int ReceiveFrom(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP) { throw null; }
        public int ReceiveFrom(byte[] buffer, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP) { throw null; }
        public int ReceiveFrom(byte[] buffer, ref System.Net.EndPoint remoteEP) { throw null; }
        public int ReceiveFrom(byte[] buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP) { throw null; }
        public bool ReceiveFromAsync(System.Net.Sockets.SocketAsyncEventArgs e) { throw null; }
        public int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, out System.Net.Sockets.IPPacketInformation ipPacketInformation) { throw null; }
        public bool ReceiveMessageFromAsync(System.Net.Sockets.SocketAsyncEventArgs e) { throw null; }
        public static void Select(System.Collections.IList checkRead, System.Collections.IList checkWrite, System.Collections.IList checkError, int microSeconds) { }
        public int Send(byte[] buffer) { throw null; }
        public int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode) { throw null; }
        public int Send(byte[] buffer, int size, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public int Send(byte[] buffer, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers) { throw null; }
        public int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode) { throw null; }
        public int Send(System.ReadOnlySpan<byte> buffer) { throw null; }
        public int Send(System.ReadOnlySpan<byte> buffer, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public int Send(System.ReadOnlySpan<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode) { throw null; }
        public bool SendAsync(System.Net.Sockets.SocketAsyncEventArgs e) { throw null; }
        public void SendFile(string fileName) { }
        public void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, System.Net.Sockets.TransmitFileOptions flags) { }
        public bool SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs e) { throw null; }
        public int SendTo(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP) { throw null; }
        public int SendTo(byte[] buffer, int size, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP) { throw null; }
        public int SendTo(byte[] buffer, System.Net.EndPoint remoteEP) { throw null; }
        public int SendTo(byte[] buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP) { throw null; }
        public bool SendToAsync(System.Net.Sockets.SocketAsyncEventArgs e) { throw null; }
        public void SetIPProtectionLevel(System.Net.Sockets.IPProtectionLevel level) { }
        public void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, bool optionValue) { }
        public void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, byte[] optionValue) { }
        public void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue) { }
        public void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, object optionValue) { }
        public void Shutdown(System.Net.Sockets.SocketShutdown how) { }
    }
    public partial class SocketAsyncEventArgs : System.EventArgs, System.IDisposable
    {
        public SocketAsyncEventArgs() { }
        public System.Net.Sockets.Socket AcceptSocket { get { throw null; } set { } }
        public byte[] Buffer { get { throw null; } }
        public System.Collections.Generic.IList<System.ArraySegment<byte>> BufferList { get { throw null; } set { } }
        public int BytesTransferred { get { throw null; } }
        public System.Exception ConnectByNameError { get { throw null; } }
        public System.Net.Sockets.Socket ConnectSocket { get { throw null; } }
        public int Count { get { throw null; } }
        public bool DisconnectReuseSocket { get { throw null; } set { } }
        public System.Net.Sockets.SocketAsyncOperation LastOperation { get { throw null; } }
        public System.Memory<byte> MemoryBuffer { get { throw null; } }
        public int Offset { get { throw null; } }
        public System.Net.Sockets.IPPacketInformation ReceiveMessageFromPacketInfo { get { throw null; } }
        public System.Net.EndPoint RemoteEndPoint { get { throw null; } set { } }
        public System.Net.Sockets.SendPacketsElement[] SendPacketsElements { get { throw null; } set { } }
        public System.Net.Sockets.TransmitFileOptions SendPacketsFlags { get { throw null; } set { } }
        public int SendPacketsSendSize { get { throw null; } set { } }
        public System.Net.Sockets.SocketError SocketError { get { throw null; } set { } }
        public System.Net.Sockets.SocketFlags SocketFlags { get { throw null; } set { } }
        public object UserToken { get { throw null; } set { } }
        public event System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> Completed { add { } remove { } }
        public void Dispose() { }
        ~SocketAsyncEventArgs() { }
        protected virtual void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs e) { }
        public void SetBuffer(byte[] buffer, int offset, int count) { }
        public void SetBuffer(int offset, int count) { }
        public void SetBuffer(System.Memory<byte> buffer) { }
    }
    public enum SocketAsyncOperation
    {
        None = 0,
        Accept = 1,
        Connect = 2,
        Disconnect = 3,
        Receive = 4,
        ReceiveFrom = 5,
        ReceiveMessageFrom = 6,
        Send = 7,
        SendPackets = 8,
        SendTo = 9,
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public enum SocketClientAccessPolicyProtocol
    {
        Tcp = 0,
        Http = 1,
    }
    public enum SocketError
    {
        SocketError = -1,
        Success = 0,
        OperationAborted = 995,
        IOPending = 997,
        Interrupted = 10004,
        AccessDenied = 10013,
        Fault = 10014,
        InvalidArgument = 10022,
        TooManyOpenSockets = 10024,
        WouldBlock = 10035,
        InProgress = 10036,
        AlreadyInProgress = 10037,
        NotSocket = 10038,
        DestinationAddressRequired = 10039,
        MessageSize = 10040,
        ProtocolType = 10041,
        ProtocolOption = 10042,
        ProtocolNotSupported = 10043,
        SocketNotSupported = 10044,
        OperationNotSupported = 10045,
        ProtocolFamilyNotSupported = 10046,
        AddressFamilyNotSupported = 10047,
        AddressAlreadyInUse = 10048,
        AddressNotAvailable = 10049,
        NetworkDown = 10050,
        NetworkUnreachable = 10051,
        NetworkReset = 10052,
        ConnectionAborted = 10053,
        ConnectionReset = 10054,
        NoBufferSpaceAvailable = 10055,
        IsConnected = 10056,
        NotConnected = 10057,
        Shutdown = 10058,
        TimedOut = 10060,
        ConnectionRefused = 10061,
        HostDown = 10064,
        HostUnreachable = 10065,
        ProcessLimit = 10067,
        SystemNotReady = 10091,
        VersionNotSupported = 10092,
        NotInitialized = 10093,
        Disconnecting = 10101,
        TypeNotFound = 10109,
        HostNotFound = 11001,
        TryAgain = 11002,
        NoRecovery = 11003,
        NoData = 11004,
    }
    public partial class SocketException : System.ComponentModel.Win32Exception
    {
        public SocketException() { }
        public SocketException(int errorCode) { }
        protected SocketException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override int ErrorCode { get { throw null; } }
        public override string Message { get { throw null; } }
        public System.Net.Sockets.SocketError SocketErrorCode { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum SocketFlags
    {
        None = 0,
        OutOfBand = 1,
        Peek = 2,
        DontRoute = 4,
        MaxIOVectorLength = 16,
        Truncated = 256,
        ControlDataTruncated = 512,
        Broadcast = 1024,
        Multicast = 2048,
        Partial = 32768,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SocketInformation
    {
        private object _dummy;
        private int _dummyPrimitive;
        public System.Net.Sockets.SocketInformationOptions Options { get { throw null; } set { } }
        public byte[] ProtocolInformation { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum SocketInformationOptions
    {
        NonBlocking = 1,
        Connected = 2,
        Listening = 4,
        UseOnlyOverlappedIO = 8,
    }
    public enum SocketOptionLevel
    {
        IP = 0,
        Tcp = 6,
        Udp = 17,
        IPv6 = 41,
        Socket = 65535,
    }
    public enum SocketOptionName
    {
        DontLinger = -129,
        ExclusiveAddressUse = -5,
        Debug = 1,
        IPOptions = 1,
        NoChecksum = 1,
        NoDelay = 1,
        AcceptConnection = 2,
        BsdUrgent = 2,
        Expedited = 2,
        HeaderIncluded = 2,
        TypeOfService = 3,
        IpTimeToLive = 4,
        ReuseAddress = 4,
        KeepAlive = 8,
        MulticastInterface = 9,
        MulticastTimeToLive = 10,
        MulticastLoopback = 11,
        AddMembership = 12,
        DropMembership = 13,
        DontFragment = 14,
        AddSourceMembership = 15,
        DontRoute = 16,
        DropSourceMembership = 16,
        BlockSource = 17,
        UnblockSource = 18,
        PacketInformation = 19,
        ChecksumCoverage = 20,
        HopLimit = 21,
        IPProtectionLevel = 23,
        IPv6Only = 27,
        Broadcast = 32,
        UseLoopback = 64,
        Linger = 128,
        OutOfBandInline = 256,
        SendBuffer = 4097,
        ReceiveBuffer = 4098,
        SendLowWater = 4099,
        ReceiveLowWater = 4100,
        SendTimeout = 4101,
        ReceiveTimeout = 4102,
        Error = 4103,
        Type = 4104,
        ReuseUnicastPort = 12295,
        UpdateAcceptContext = 28683,
        UpdateConnectContext = 28688,
        MaxConnections = 2147483647,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SocketReceiveFromResult
    {
        public int ReceivedBytes;
        public System.Net.EndPoint RemoteEndPoint;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SocketReceiveMessageFromResult
    {
        public System.Net.Sockets.IPPacketInformation PacketInformation;
        public int ReceivedBytes;
        public System.Net.EndPoint RemoteEndPoint;
        public System.Net.Sockets.SocketFlags SocketFlags;
    }
    public enum SocketShutdown
    {
        Receive = 0,
        Send = 1,
        Both = 2,
    }
    public static partial class SocketTaskExtensions
    {
        public static System.Threading.Tasks.Task<System.Net.Sockets.Socket> AcceptAsync(this System.Net.Sockets.Socket socket) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Sockets.Socket> AcceptAsync(this System.Net.Sockets.Socket socket, System.Net.Sockets.Socket acceptSocket) { throw null; }
        public static System.Threading.Tasks.Task ConnectAsync(this System.Net.Sockets.Socket socket, System.Net.EndPoint remoteEP) { throw null; }
        public static System.Threading.Tasks.Task ConnectAsync(this System.Net.Sockets.Socket socket, System.Net.IPAddress address, int port) { throw null; }
        public static System.Threading.Tasks.Task ConnectAsync(this System.Net.Sockets.Socket socket, System.Net.IPAddress[] addresses, int port) { throw null; }
        public static System.Threading.Tasks.Task ConnectAsync(this System.Net.Sockets.Socket socket, string host, int port) { throw null; }
        public static System.Threading.Tasks.Task<int> ReceiveAsync(this System.Net.Sockets.Socket socket, System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public static System.Threading.Tasks.Task<int> ReceiveAsync(this System.Net.Sockets.Socket socket, System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public static System.Threading.Tasks.ValueTask<int> ReceiveAsync(this System.Net.Sockets.Socket socket, System.Memory<byte> memory, System.Net.Sockets.SocketFlags socketFlags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveFromResult> ReceiveFromAsync(this System.Net.Sockets.Socket socket, System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEndPoint) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveMessageFromResult> ReceiveMessageFromAsync(this System.Net.Sockets.Socket socket, System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEndPoint) { throw null; }
        public static System.Threading.Tasks.Task<int> SendAsync(this System.Net.Sockets.Socket socket, System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public static System.Threading.Tasks.Task<int> SendAsync(this System.Net.Sockets.Socket socket, System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags) { throw null; }
        public static System.Threading.Tasks.ValueTask<int> SendAsync(this System.Net.Sockets.Socket socket, System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<int> SendToAsync(this System.Net.Sockets.Socket socket, System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP) { throw null; }
    }
    public enum SocketType
    {
        Unknown = -1,
        Stream = 1,
        Dgram = 2,
        Raw = 3,
        Rdm = 4,
        Seqpacket = 5,
    }
    public partial class TcpClient : System.IDisposable
    {
        public TcpClient() { }
        public TcpClient(System.Net.IPEndPoint localEP) { }
        public TcpClient(System.Net.Sockets.AddressFamily family) { }
        public TcpClient(string hostname, int port) { }
        protected bool Active { get { throw null; } set { } }
        public int Available { get { throw null; } }
        public System.Net.Sockets.Socket Client { get { throw null; } set { } }
        public bool Connected { get { throw null; } }
        public bool ExclusiveAddressUse { get { throw null; } set { } }
        public System.Net.Sockets.LingerOption LingerState { get { throw null; } set { } }
        public bool NoDelay { get { throw null; } set { } }
        public int ReceiveBufferSize { get { throw null; } set { } }
        public int ReceiveTimeout { get { throw null; } set { } }
        public int SendBufferSize { get { throw null; } set { } }
        public int SendTimeout { get { throw null; } set { } }
        public System.IAsyncResult BeginConnect(System.Net.IPAddress address, int port, System.AsyncCallback requestCallback, object state) { throw null; }
        public System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, int port, System.AsyncCallback requestCallback, object state) { throw null; }
        public System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback requestCallback, object state) { throw null; }
        public void Close() { }
        public void Connect(System.Net.IPAddress address, int port) { }
        public void Connect(System.Net.IPAddress[] ipAddresses, int port) { }
        public void Connect(System.Net.IPEndPoint remoteEP) { }
        public void Connect(string hostname, int port) { }
        public System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress address, int port) { throw null; }
        public System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress[] addresses, int port) { throw null; }
        public System.Threading.Tasks.Task ConnectAsync(string host, int port) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void EndConnect(System.IAsyncResult asyncResult) { }
        ~TcpClient() { }
        public System.Net.Sockets.NetworkStream GetStream() { throw null; }
    }
    public partial class TcpListener
    {
        public TcpListener(int port) { }
        public TcpListener(System.Net.IPAddress localaddr, int port) { }
        public TcpListener(System.Net.IPEndPoint localEP) { }
        protected bool Active { get { throw null; } }
        public bool ExclusiveAddressUse { get { throw null; } set { } }
        public System.Net.EndPoint LocalEndpoint { get { throw null; } }
        public System.Net.Sockets.Socket Server { get { throw null; } }
        public System.Net.Sockets.Socket AcceptSocket() { throw null; }
        public System.Threading.Tasks.Task<System.Net.Sockets.Socket> AcceptSocketAsync() { throw null; }
        public System.Net.Sockets.TcpClient AcceptTcpClient() { throw null; }
        public System.Threading.Tasks.Task<System.Net.Sockets.TcpClient> AcceptTcpClientAsync() { throw null; }
        public void AllowNatTraversal(bool allowed) { }
        public System.IAsyncResult BeginAcceptSocket(System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginAcceptTcpClient(System.AsyncCallback callback, object state) { throw null; }
        public static System.Net.Sockets.TcpListener Create(int port) { throw null; }
        public System.Net.Sockets.Socket EndAcceptSocket(System.IAsyncResult asyncResult) { throw null; }
        public System.Net.Sockets.TcpClient EndAcceptTcpClient(System.IAsyncResult asyncResult) { throw null; }
        ~TcpListener() { }
        public bool Pending() { throw null; }
        public void Start() { }
        public void Start(int backlog) { }
        public void Stop() { }
    }
    [System.FlagsAttribute]
    public enum TransmitFileOptions
    {
        UseDefaultWorkerThread = 0,
        Disconnect = 1,
        ReuseSocket = 2,
        WriteBehind = 4,
        UseSystemThread = 16,
        UseKernelApc = 32,
    }
    public partial class UdpClient : System.IDisposable
    {
        public UdpClient() { }
        public UdpClient(int port) { }
        public UdpClient(int port, System.Net.Sockets.AddressFamily family) { }
        public UdpClient(System.Net.IPEndPoint localEP) { }
        public UdpClient(System.Net.Sockets.AddressFamily family) { }
        public UdpClient(string hostname, int port) { }
        protected bool Active { get { throw null; } set { } }
        public int Available { get { throw null; } }
        public System.Net.Sockets.Socket Client { get { throw null; } set { } }
        public bool DontFragment { get { throw null; } set { } }
        public bool EnableBroadcast { get { throw null; } set { } }
        public bool ExclusiveAddressUse { get { throw null; } set { } }
        public bool MulticastLoopback { get { throw null; } set { } }
        public short Ttl { get { throw null; } set { } }
        public void AllowNatTraversal(bool allowed) { }
        public System.IAsyncResult BeginReceive(System.AsyncCallback requestCallback, object state) { throw null; }
        public System.IAsyncResult BeginSend(byte[] datagram, int bytes, System.AsyncCallback requestCallback, object state) { throw null; }
        public System.IAsyncResult BeginSend(byte[] datagram, int bytes, System.Net.IPEndPoint endPoint, System.AsyncCallback requestCallback, object state) { throw null; }
        public System.IAsyncResult BeginSend(byte[] datagram, int bytes, string hostname, int port, System.AsyncCallback requestCallback, object state) { throw null; }
        public void Close() { }
        public void Connect(System.Net.IPAddress addr, int port) { }
        public void Connect(System.Net.IPEndPoint endPoint) { }
        public void Connect(string hostname, int port) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void DropMulticastGroup(System.Net.IPAddress multicastAddr) { }
        public void DropMulticastGroup(System.Net.IPAddress multicastAddr, int ifindex) { }
        public byte[] EndReceive(System.IAsyncResult asyncResult, ref System.Net.IPEndPoint remoteEP) { throw null; }
        public int EndSend(System.IAsyncResult asyncResult) { throw null; }
        ~UdpClient() { }
        public void JoinMulticastGroup(int ifindex, System.Net.IPAddress multicastAddr) { }
        public void JoinMulticastGroup(System.Net.IPAddress multicastAddr) { }
        public void JoinMulticastGroup(System.Net.IPAddress multicastAddr, int timeToLive) { }
        public void JoinMulticastGroup(System.Net.IPAddress multicastAddr, System.Net.IPAddress localAddress) { }
        public byte[] Receive(ref System.Net.IPEndPoint remoteEP) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Sockets.UdpReceiveResult> ReceiveAsync() { throw null; }
        public int Send(byte[] dgram, int bytes) { throw null; }
        public int Send(byte[] dgram, int bytes, System.Net.IPEndPoint endPoint) { throw null; }
        public int Send(byte[] dgram, int bytes, string hostname, int port) { throw null; }
        public System.Threading.Tasks.Task<int> SendAsync(byte[] datagram, int bytes) { throw null; }
        public System.Threading.Tasks.Task<int> SendAsync(byte[] datagram, int bytes, System.Net.IPEndPoint endPoint) { throw null; }
        public System.Threading.Tasks.Task<int> SendAsync(byte[] datagram, int bytes, string hostname, int port) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct UdpReceiveResult : System.IEquatable<System.Net.Sockets.UdpReceiveResult>
    {
        private object _dummy;
        private int _dummyPrimitive;
        public UdpReceiveResult(byte[] buffer, System.Net.IPEndPoint remoteEndPoint) { throw null; }
        public byte[] Buffer { get { throw null; } }
        public System.Net.IPEndPoint RemoteEndPoint { get { throw null; } }
        public bool Equals(System.Net.Sockets.UdpReceiveResult other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Net.Sockets.UdpReceiveResult left, System.Net.Sockets.UdpReceiveResult right) { throw null; }
        public static bool operator !=(System.Net.Sockets.UdpReceiveResult left, System.Net.Sockets.UdpReceiveResult right) { throw null; }
    }
}
namespace System.Net.WebSockets
{
    public sealed partial class ClientWebSocket : System.Net.WebSockets.WebSocket
    {
        public ClientWebSocket() { }
        public override System.Net.WebSockets.WebSocketCloseStatus? CloseStatus { get { throw null; } }
        public override string CloseStatusDescription { get { throw null; } }
        public System.Net.WebSockets.ClientWebSocketOptions Options { get { throw null; } }
        public override System.Net.WebSockets.WebSocketState State { get { throw null; } }
        public override string SubProtocol { get { throw null; } }
        public override void Abort() { }
        public override System.Threading.Tasks.Task CloseAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task ConnectAsync(System.Uri uri, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void Dispose() { }
        public override System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask<System.Net.WebSockets.ValueWebSocketReceiveResult> ReceiveAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask SendAsync(System.ReadOnlyMemory<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class ClientWebSocketOptions
    {
        internal ClientWebSocketOptions() { }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } set { } }
        public System.Net.CookieContainer Cookies { get { throw null; } set { } }
        public System.Net.ICredentials Credentials { get { throw null; } set { } }
        public System.TimeSpan KeepAliveInterval { get { throw null; } set { } }
        public System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public System.Net.Security.RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get { throw null; } set { } }
        public bool UseDefaultCredentials { get { throw null; } set { } }
        public void AddSubProtocol(string subProtocol) { }
        public void SetBuffer(int receiveBufferSize, int sendBufferSize) { }
        public void SetBuffer(int receiveBufferSize, int sendBufferSize, System.ArraySegment<byte> buffer) { }
        public void SetRequestHeader(string headerName, string headerValue) { }
    }
    public partial class HttpListenerWebSocketContext : System.Net.WebSockets.WebSocketContext
    {
        internal HttpListenerWebSocketContext() { }
        public override System.Net.CookieCollection CookieCollection { get { throw null; } }
        public override System.Collections.Specialized.NameValueCollection Headers { get { throw null; } }
        public override bool IsAuthenticated { get { throw null; } }
        public override bool IsLocal { get { throw null; } }
        public override bool IsSecureConnection { get { throw null; } }
        public override string Origin { get { throw null; } }
        public override System.Uri RequestUri { get { throw null; } }
        public override string SecWebSocketKey { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<string> SecWebSocketProtocols { get { throw null; } }
        public override string SecWebSocketVersion { get { throw null; } }
        public override System.Security.Principal.IPrincipal User { get { throw null; } }
        public override System.Net.WebSockets.WebSocket WebSocket { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ValueWebSocketReceiveResult
    {
        private readonly int _dummyPrimitive;
        public ValueWebSocketReceiveResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage) { throw null; }
        public int Count { get { throw null; } }
        public bool EndOfMessage { get { throw null; } }
        public System.Net.WebSockets.WebSocketMessageType MessageType { get { throw null; } }
    }
    public abstract partial class WebSocket : System.IDisposable
    {
        protected WebSocket() { }
        public abstract System.Net.WebSockets.WebSocketCloseStatus? CloseStatus { get; }
        public abstract string CloseStatusDescription { get; }
        public static System.TimeSpan DefaultKeepAliveInterval { get { throw null; } }
        public abstract System.Net.WebSockets.WebSocketState State { get; }
        public abstract string SubProtocol { get; }
        public abstract void Abort();
        public abstract System.Threading.Tasks.Task CloseAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken);
        public abstract System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken);
        public static System.ArraySegment<byte> CreateClientBuffer(int receiveBufferSize, int sendBufferSize) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Net.WebSockets.WebSocket CreateClientWebSocket(System.IO.Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, System.TimeSpan keepAliveInterval, bool useZeroMaskingKey, System.ArraySegment<byte> internalBuffer) { throw null; }
        public static System.Net.WebSockets.WebSocket CreateFromStream(System.IO.Stream stream, bool isServer, string subProtocol, System.TimeSpan keepAliveInterval) { throw null; }
        public static System.ArraySegment<byte> CreateServerBuffer(int receiveBufferSize) { throw null; }
        public abstract void Dispose();
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.")]
        public static bool IsApplicationTargeting45() { throw null; }
        protected static bool IsStateTerminal(System.Net.WebSockets.WebSocketState state) { throw null; }
        public abstract System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken);
        public virtual System.Threading.Tasks.ValueTask<System.Net.WebSockets.ValueWebSocketReceiveResult> ReceiveAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void RegisterPrefixes() { }
        public abstract System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken);
        public virtual System.Threading.Tasks.ValueTask SendAsync(System.ReadOnlyMemory<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected static void ThrowOnInvalidState(System.Net.WebSockets.WebSocketState state, params System.Net.WebSockets.WebSocketState[] validStates) { }
    }
    public enum WebSocketCloseStatus
    {
        NormalClosure = 1000,
        EndpointUnavailable = 1001,
        ProtocolError = 1002,
        InvalidMessageType = 1003,
        Empty = 1005,
        InvalidPayloadData = 1007,
        PolicyViolation = 1008,
        MessageTooBig = 1009,
        MandatoryExtension = 1010,
        InternalServerError = 1011,
    }
    public abstract partial class WebSocketContext
    {
        protected WebSocketContext() { }
        public abstract System.Net.CookieCollection CookieCollection { get; }
        public abstract System.Collections.Specialized.NameValueCollection Headers { get; }
        public abstract bool IsAuthenticated { get; }
        public abstract bool IsLocal { get; }
        public abstract bool IsSecureConnection { get; }
        public abstract string Origin { get; }
        public abstract System.Uri RequestUri { get; }
        public abstract string SecWebSocketKey { get; }
        public abstract System.Collections.Generic.IEnumerable<string> SecWebSocketProtocols { get; }
        public abstract string SecWebSocketVersion { get; }
        public abstract System.Security.Principal.IPrincipal User { get; }
        public abstract System.Net.WebSockets.WebSocket WebSocket { get; }
    }
    public enum WebSocketError
    {
        Success = 0,
        InvalidMessageType = 1,
        Faulted = 2,
        NativeError = 3,
        NotAWebSocket = 4,
        UnsupportedVersion = 5,
        UnsupportedProtocol = 6,
        HeaderError = 7,
        ConnectionClosedPrematurely = 8,
        InvalidState = 9,
    }
    public sealed partial class WebSocketException : System.ComponentModel.Win32Exception
    {
        public WebSocketException() { }
        public WebSocketException(int nativeError) { }
        public WebSocketException(int nativeError, System.Exception innerException) { }
        public WebSocketException(int nativeError, string message) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, System.Exception innerException) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError, System.Exception innerException) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError, string message) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError, string message, System.Exception innerException) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, string message) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, string message, System.Exception innerException) { }
        public WebSocketException(string message) { }
        public WebSocketException(string message, System.Exception innerException) { }
        public override int ErrorCode { get { throw null; } }
        public System.Net.WebSockets.WebSocketError WebSocketErrorCode { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public enum WebSocketMessageType
    {
        Text = 0,
        Binary = 1,
        Close = 2,
    }
    public partial class WebSocketReceiveResult
    {
        public WebSocketReceiveResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage) { }
        public WebSocketReceiveResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Net.WebSockets.WebSocketCloseStatus? closeStatus, string closeStatusDescription) { }
        public System.Net.WebSockets.WebSocketCloseStatus? CloseStatus { get { throw null; } }
        public string CloseStatusDescription { get { throw null; } }
        public int Count { get { throw null; } }
        public bool EndOfMessage { get { throw null; } }
        public System.Net.WebSockets.WebSocketMessageType MessageType { get { throw null; } }
    }
    public enum WebSocketState
    {
        None = 0,
        Connecting = 1,
        Open = 2,
        CloseSent = 3,
        CloseReceived = 4,
        Closed = 5,
        Aborted = 6,
    }
}
namespace System.Runtime.InteropServices
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter)]
    public sealed partial class DefaultParameterValueAttribute : System.Attribute
    {
        public DefaultParameterValueAttribute(object value) { }
        public object Value { get { throw null; } }
    }
    public sealed partial class HandleCollector
    {
        public HandleCollector(string name, int initialThreshold) { }
        public HandleCollector(string name, int initialThreshold, int maximumThreshold) { }
        public int Count { get { throw null; } }
        public int InitialThreshold { get { throw null; } }
        public int MaximumThreshold { get { throw null; } }
        public string Name { get { throw null; } }
        public void Add() { }
        public void Remove() { }
    }
}
namespace System.Runtime.InteropServices.ComTypes
{
    [System.FlagsAttribute]
    public enum ADVF
    {
        ADVF_NODATA = 1,
        ADVF_PRIMEFIRST = 2,
        ADVF_ONLYONCE = 4,
        ADVFCACHE_NOHANDLER = 8,
        ADVFCACHE_FORCEBUILTIN = 16,
        ADVFCACHE_ONSAVE = 32,
        ADVF_DATAONSTOP = 64,
    }
    public enum DATADIR
    {
        DATADIR_GET = 1,
        DATADIR_SET = 2,
    }
    [System.FlagsAttribute]
    public enum DVASPECT
    {
        DVASPECT_CONTENT = 1,
        DVASPECT_THUMBNAIL = 2,
        DVASPECT_ICON = 4,
        DVASPECT_DOCPRINT = 8,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FORMATETC
    {
        public short cfFormat;
        public System.Runtime.InteropServices.ComTypes.DVASPECT dwAspect;
        public int lindex;
        public System.IntPtr ptd;
        public System.Runtime.InteropServices.ComTypes.TYMED tymed;
    }
    public partial interface IAdviseSink
    {
        void OnClose();
        void OnDataChange(ref System.Runtime.InteropServices.ComTypes.FORMATETC format, ref System.Runtime.InteropServices.ComTypes.STGMEDIUM stgmedium);
        void OnRename(System.Runtime.InteropServices.ComTypes.IMoniker moniker);
        void OnSave();
        void OnViewChange(int aspect, int index);
    }
    public partial interface IDataObject
    {
        int DAdvise(ref System.Runtime.InteropServices.ComTypes.FORMATETC pFormatetc, System.Runtime.InteropServices.ComTypes.ADVF advf, System.Runtime.InteropServices.ComTypes.IAdviseSink adviseSink, out int connection);
        void DUnadvise(int connection);
        int EnumDAdvise(out System.Runtime.InteropServices.ComTypes.IEnumSTATDATA enumAdvise);
        System.Runtime.InteropServices.ComTypes.IEnumFORMATETC EnumFormatEtc(System.Runtime.InteropServices.ComTypes.DATADIR direction);
        int GetCanonicalFormatEtc(ref System.Runtime.InteropServices.ComTypes.FORMATETC formatIn, out System.Runtime.InteropServices.ComTypes.FORMATETC formatOut);
        void GetData(ref System.Runtime.InteropServices.ComTypes.FORMATETC format, out System.Runtime.InteropServices.ComTypes.STGMEDIUM medium);
        void GetDataHere(ref System.Runtime.InteropServices.ComTypes.FORMATETC format, ref System.Runtime.InteropServices.ComTypes.STGMEDIUM medium);
        int QueryGetData(ref System.Runtime.InteropServices.ComTypes.FORMATETC format);
        void SetData(ref System.Runtime.InteropServices.ComTypes.FORMATETC formatIn, ref System.Runtime.InteropServices.ComTypes.STGMEDIUM medium, bool release);
    }
    public partial interface IEnumFORMATETC
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumFORMATETC newEnum);
        int Next(int celt, System.Runtime.InteropServices.ComTypes.FORMATETC[] rgelt, int[] pceltFetched);
        int Reset();
        int Skip(int celt);
    }
    public partial interface IEnumSTATDATA
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumSTATDATA newEnum);
        int Next(int celt, System.Runtime.InteropServices.ComTypes.STATDATA[] rgelt, int[] pceltFetched);
        int Reset();
        int Skip(int celt);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct STATDATA
    {
        public System.Runtime.InteropServices.ComTypes.ADVF advf;
        public System.Runtime.InteropServices.ComTypes.IAdviseSink advSink;
        public int connection;
        public System.Runtime.InteropServices.ComTypes.FORMATETC formatetc;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct STGMEDIUM
    {
        public object pUnkForRelease;
        public System.Runtime.InteropServices.ComTypes.TYMED tymed;
        public System.IntPtr unionmember;
    }
    [System.FlagsAttribute]
    public enum TYMED
    {
        TYMED_NULL = 0,
        TYMED_HGLOBAL = 1,
        TYMED_FILE = 2,
        TYMED_ISTREAM = 4,
        TYMED_ISTORAGE = 8,
        TYMED_GDI = 16,
        TYMED_MFPICT = 32,
        TYMED_ENHMF = 64,
    }
}
namespace System.Runtime.Versioning
{
    public sealed partial class FrameworkName : System.IEquatable<System.Runtime.Versioning.FrameworkName>
    {
        public FrameworkName(string frameworkName) { }
        public FrameworkName(string identifier, System.Version version) { }
        public FrameworkName(string identifier, System.Version version, string profile) { }
        public string FullName { get { throw null; } }
        public string Identifier { get { throw null; } }
        public string Profile { get { throw null; } }
        public System.Version Version { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Runtime.Versioning.FrameworkName other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Runtime.Versioning.FrameworkName left, System.Runtime.Versioning.FrameworkName right) { throw null; }
        public static bool operator !=(System.Runtime.Versioning.FrameworkName left, System.Runtime.Versioning.FrameworkName right) { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace System.Security
{
    public static partial class SecureStringMarshal
    {
        public static System.IntPtr SecureStringToCoTaskMemAnsi(System.Security.SecureString s) { throw null; }
        public static System.IntPtr SecureStringToCoTaskMemUnicode(System.Security.SecureString s) { throw null; }
        public static System.IntPtr SecureStringToGlobalAllocAnsi(System.Security.SecureString s) { throw null; }
        public static System.IntPtr SecureStringToGlobalAllocUnicode(System.Security.SecureString s) { throw null; }
    }
}
namespace System.Security.AccessControl
{
    public sealed partial class SemaphoreAccessRule : System.Security.AccessControl.AccessRule
    {
        public SemaphoreAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.SemaphoreRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public SemaphoreAccessRule(string identity, System.Security.AccessControl.SemaphoreRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public System.Security.AccessControl.SemaphoreRights SemaphoreRights { get { throw null; } }
    }
    public sealed partial class SemaphoreAuditRule : System.Security.AccessControl.AuditRule
    {
        public SemaphoreAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.SemaphoreRights eventRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public System.Security.AccessControl.SemaphoreRights SemaphoreRights { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum SemaphoreRights
    {
        Modify = 2,
        Delete = 65536,
        ReadPermissions = 131072,
        ChangePermissions = 262144,
        TakeOwnership = 524288,
        Synchronize = 1048576,
        FullControl = 2031619,
    }
    public sealed partial class SemaphoreSecurity : System.Security.AccessControl.NativeObjectSecurity
    {
        public SemaphoreSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public SemaphoreSecurity(string name, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public override System.Type AccessRightType { get { throw null; } }
        public override System.Type AccessRuleType { get { throw null; } }
        public override System.Type AuditRuleType { get { throw null; } }
        public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { throw null; }
        public void AddAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
        public void AddAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { }
        public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { throw null; }
        public bool RemoveAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { throw null; }
        public void RemoveAccessRuleAll(System.Security.AccessControl.SemaphoreAccessRule rule) { }
        public void RemoveAccessRuleSpecific(System.Security.AccessControl.SemaphoreAccessRule rule) { }
        public bool RemoveAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { throw null; }
        public void RemoveAuditRuleAll(System.Security.AccessControl.SemaphoreAuditRule rule) { }
        public void RemoveAuditRuleSpecific(System.Security.AccessControl.SemaphoreAuditRule rule) { }
        public void ResetAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
        public void SetAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
        public void SetAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { }
    }
}
namespace System.Security.Authentication
{
    public partial class AuthenticationException : System.SystemException
    {
        public AuthenticationException() { }
        protected AuthenticationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public AuthenticationException(string message) { }
        public AuthenticationException(string message, System.Exception innerException) { }
    }
    public enum CipherAlgorithmType
    {
        None = 0,
        Null = 24576,
        Des = 26113,
        Rc2 = 26114,
        TripleDes = 26115,
        Aes128 = 26126,
        Aes192 = 26127,
        Aes256 = 26128,
        Aes = 26129,
        Rc4 = 26625,
    }
    public enum ExchangeAlgorithmType
    {
        None = 0,
        RsaSign = 9216,
        RsaKeyX = 41984,
        DiffieHellman = 43522,
    }
    public enum HashAlgorithmType
    {
        None = 0,
        Md5 = 32771,
        Sha1 = 32772,
        Sha256 = 32780,
        Sha384 = 32781,
        Sha512 = 32782,
    }
    public partial class InvalidCredentialException : System.Security.Authentication.AuthenticationException
    {
        public InvalidCredentialException() { }
        protected InvalidCredentialException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public InvalidCredentialException(string message) { }
        public InvalidCredentialException(string message, System.Exception innerException) { }
    }
    [System.FlagsAttribute]
    public enum SslProtocols
    {
        None = 0,
        Ssl2 = 12,
        Ssl3 = 48,
        Tls = 192,
        Default = 240,
        Tls11 = 768,
        Tls12 = 3072,
        Tls13 = 12288,
    }
}
namespace System.Security.Authentication.ExtendedProtection
{
    public abstract partial class ChannelBinding : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        protected ChannelBinding() : base (default(bool)) { }
        protected ChannelBinding(bool ownsHandle) : base (default(bool)) { }
        public abstract int Size { get; }
    }
    public enum ChannelBindingKind
    {
        Unknown = 0,
        Unique = 25,
        Endpoint = 26,
    }
    public partial class ExtendedProtectionPolicy : System.Runtime.Serialization.ISerializable
    {
        protected ExtendedProtectionPolicy(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement) { }
        public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement, System.Security.Authentication.ExtendedProtection.ChannelBinding customChannelBinding) { }
        public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement, System.Security.Authentication.ExtendedProtection.ProtectionScenario protectionScenario, System.Collections.ICollection customServiceNames) { }
        public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement, System.Security.Authentication.ExtendedProtection.ProtectionScenario protectionScenario, System.Security.Authentication.ExtendedProtection.ServiceNameCollection customServiceNames) { }
        public System.Security.Authentication.ExtendedProtection.ChannelBinding CustomChannelBinding { get { throw null; } }
        public System.Security.Authentication.ExtendedProtection.ServiceNameCollection CustomServiceNames { get { throw null; } }
        public static bool OSSupportsExtendedProtection { get { throw null; } }
        public System.Security.Authentication.ExtendedProtection.PolicyEnforcement PolicyEnforcement { get { throw null; } }
        public System.Security.Authentication.ExtendedProtection.ProtectionScenario ProtectionScenario { get { throw null; } }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public partial class ExtendedProtectionPolicyTypeConverter : System.ComponentModel.TypeConverter
    {
        public ExtendedProtectionPolicyTypeConverter() { }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    public enum PolicyEnforcement
    {
        Never = 0,
        WhenSupported = 1,
        Always = 2,
    }
    public enum ProtectionScenario
    {
        TransportSelected = 0,
        TrustedProxy = 1,
    }
    public partial class ServiceNameCollection : System.Collections.ReadOnlyCollectionBase
    {
        public ServiceNameCollection(System.Collections.ICollection items) { }
        public bool Contains(string searchServiceName) { throw null; }
        public System.Security.Authentication.ExtendedProtection.ServiceNameCollection Merge(System.Collections.IEnumerable serviceNames) { throw null; }
        public System.Security.Authentication.ExtendedProtection.ServiceNameCollection Merge(string serviceName) { throw null; }
    }
    public partial class TokenBinding
    {
        internal TokenBinding() { }
        public System.Security.Authentication.ExtendedProtection.TokenBindingType BindingType { get { throw null; } }
        public byte[] GetRawTokenBindingId() { throw null; }
    }
    public enum TokenBindingType
    {
        Provided = 0,
        Referred = 1,
    }
}
namespace System.Security.Cryptography
{
    public partial class AsnEncodedData
    {
        protected AsnEncodedData() { }
        public AsnEncodedData(byte[] rawData) { }
        public AsnEncodedData(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        public AsnEncodedData(System.Security.Cryptography.Oid oid, byte[] rawData) { }
        public AsnEncodedData(string oid, byte[] rawData) { }
        public System.Security.Cryptography.Oid Oid { get { throw null; } set { } }
        public byte[] RawData { get { throw null; } set { } }
        public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        public virtual string Format(bool multiLine) { throw null; }
    }
    public sealed partial class AsnEncodedDataCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public AsnEncodedDataCollection() { }
        public AsnEncodedDataCollection(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Cryptography.AsnEncodedData this[int index] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public int Add(System.Security.Cryptography.AsnEncodedData asnEncodedData) { throw null; }
        public void CopyTo(System.Security.Cryptography.AsnEncodedData[] array, int index) { }
        public System.Security.Cryptography.AsnEncodedDataEnumerator GetEnumerator() { throw null; }
        public void Remove(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class AsnEncodedDataEnumerator : System.Collections.IEnumerator
    {
        internal AsnEncodedDataEnumerator() { }
        public System.Security.Cryptography.AsnEncodedData Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    public sealed partial class Oid
    {
        public Oid() { }
        public Oid(System.Security.Cryptography.Oid oid) { }
        public Oid(string oid) { }
        public Oid(string value, string friendlyName) { }
        public string FriendlyName { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        public static System.Security.Cryptography.Oid FromFriendlyName(string friendlyName, System.Security.Cryptography.OidGroup group) { throw null; }
        public static System.Security.Cryptography.Oid FromOidValue(string oidValue, System.Security.Cryptography.OidGroup group) { throw null; }
    }
    public sealed partial class OidCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public OidCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Cryptography.Oid this[int index] { get { throw null; } }
        public System.Security.Cryptography.Oid this[string oid] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public int Add(System.Security.Cryptography.Oid oid) { throw null; }
        public void CopyTo(System.Security.Cryptography.Oid[] array, int index) { }
        public System.Security.Cryptography.OidEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class OidEnumerator : System.Collections.IEnumerator
    {
        internal OidEnumerator() { }
        public System.Security.Cryptography.Oid Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    public enum OidGroup
    {
        All = 0,
        HashAlgorithm = 1,
        EncryptionAlgorithm = 2,
        PublicKeyAlgorithm = 3,
        SignatureAlgorithm = 4,
        Attribute = 5,
        ExtensionOrAttribute = 6,
        EnhancedKeyUsage = 7,
        Policy = 8,
        Template = 9,
        KeyDerivationFunction = 10,
    }
}
namespace System.Security.Cryptography.X509Certificates
{
    public sealed partial class CertificateRequest
    {
        public CertificateRequest(System.Security.Cryptography.X509Certificates.X500DistinguishedName subjectName, System.Security.Cryptography.ECDsa key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { }
        public CertificateRequest(System.Security.Cryptography.X509Certificates.X500DistinguishedName subjectName, System.Security.Cryptography.RSA key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { }
        public CertificateRequest(System.Security.Cryptography.X509Certificates.X500DistinguishedName subjectName, System.Security.Cryptography.X509Certificates.PublicKey publicKey, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { }
        public CertificateRequest(string subjectName, System.Security.Cryptography.ECDsa key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { }
        public CertificateRequest(string subjectName, System.Security.Cryptography.RSA key, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { }
        public System.Collections.ObjectModel.Collection<System.Security.Cryptography.X509Certificates.X509Extension> CertificateExtensions { get { throw null; } }
        public System.Security.Cryptography.HashAlgorithmName HashAlgorithm { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.PublicKey PublicKey { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName SubjectName { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Create(System.Security.Cryptography.X509Certificates.X500DistinguishedName issuerName, System.Security.Cryptography.X509Certificates.X509SignatureGenerator generator, System.DateTimeOffset notBefore, System.DateTimeOffset notAfter, byte[] serialNumber) { throw null; }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Create(System.Security.Cryptography.X509Certificates.X509Certificate2 issuerCertificate, System.DateTimeOffset notBefore, System.DateTimeOffset notAfter, byte[] serialNumber) { throw null; }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 CreateSelfSigned(System.DateTimeOffset notBefore, System.DateTimeOffset notAfter) { throw null; }
        public byte[] CreateSigningRequest() { throw null; }
        public byte[] CreateSigningRequest(System.Security.Cryptography.X509Certificates.X509SignatureGenerator signatureGenerator) { throw null; }
    }
    [System.FlagsAttribute]
    public enum OpenFlags
    {
        ReadOnly = 0,
        ReadWrite = 1,
        MaxAllowed = 2,
        OpenExistingOnly = 4,
        IncludeArchived = 8,
    }
    public sealed partial class PublicKey
    {
        public PublicKey(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedData parameters, System.Security.Cryptography.AsnEncodedData keyValue) { }
        public System.Security.Cryptography.AsnEncodedData EncodedKeyValue { get { throw null; } }
        public System.Security.Cryptography.AsnEncodedData EncodedParameters { get { throw null; } }
        public System.Security.Cryptography.AsymmetricAlgorithm Key { get { throw null; } }
        public System.Security.Cryptography.Oid Oid { get { throw null; } }
    }
    public enum StoreLocation
    {
        CurrentUser = 1,
        LocalMachine = 2,
    }
    public enum StoreName
    {
        AddressBook = 1,
        AuthRoot = 2,
        CertificateAuthority = 3,
        Disallowed = 4,
        My = 5,
        Root = 6,
        TrustedPeople = 7,
        TrustedPublisher = 8,
    }
    public sealed partial class SubjectAlternativeNameBuilder
    {
        public SubjectAlternativeNameBuilder() { }
        public void AddDnsName(string dnsName) { }
        public void AddEmailAddress(string emailAddress) { }
        public void AddIpAddress(System.Net.IPAddress ipAddress) { }
        public void AddUri(System.Uri uri) { }
        public void AddUserPrincipalName(string upn) { }
        public System.Security.Cryptography.X509Certificates.X509Extension Build(bool critical = false) { throw null; }
    }
    public sealed partial class X500DistinguishedName : System.Security.Cryptography.AsnEncodedData
    {
        public X500DistinguishedName(byte[] encodedDistinguishedName) { }
        public X500DistinguishedName(System.Security.Cryptography.AsnEncodedData encodedDistinguishedName) { }
        public X500DistinguishedName(System.Security.Cryptography.X509Certificates.X500DistinguishedName distinguishedName) { }
        public X500DistinguishedName(string distinguishedName) { }
        public X500DistinguishedName(string distinguishedName, System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag) { }
        public string Name { get { throw null; } }
        public string Decode(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag) { throw null; }
        public override string Format(bool multiLine) { throw null; }
    }
    [System.FlagsAttribute]
    public enum X500DistinguishedNameFlags
    {
        None = 0,
        Reversed = 1,
        UseSemicolons = 16,
        DoNotUsePlusSign = 32,
        DoNotUseQuotes = 64,
        UseCommas = 128,
        UseNewLines = 256,
        UseUTF8Encoding = 4096,
        UseT61Encoding = 8192,
        ForceUTF8Encoding = 16384,
    }
    public sealed partial class X509BasicConstraintsExtension : System.Security.Cryptography.X509Certificates.X509Extension
    {
        public X509BasicConstraintsExtension() { }
        public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }
        public X509BasicConstraintsExtension(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, bool critical) { }
        public bool CertificateAuthority { get { throw null; } }
        public bool HasPathLengthConstraint { get { throw null; } }
        public int PathLengthConstraint { get { throw null; } }
        public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    }
    public partial class X509Certificate2 : System.Security.Cryptography.X509Certificates.X509Certificate
    {
        public X509Certificate2() { }
        public X509Certificate2(byte[] rawData) { }
        [System.CLSCompliantAttribute(false)]
        public X509Certificate2(byte[] rawData, System.Security.SecureString password) { }
        [System.CLSCompliantAttribute(false)]
        public X509Certificate2(byte[] rawData, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        public X509Certificate2(byte[] rawData, string password) { }
        public X509Certificate2(byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        public X509Certificate2(System.IntPtr handle) { }
        protected X509Certificate2(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public X509Certificate2(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        public X509Certificate2(string fileName) { }
        public X509Certificate2(string fileName, System.Security.SecureString password) { }
        public X509Certificate2(string fileName, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        public X509Certificate2(string fileName, string password) { }
        public X509Certificate2(string fileName, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        public bool Archived { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509ExtensionCollection Extensions { get { throw null; } }
        public string FriendlyName { get { throw null; } set { } }
        public bool HasPrivateKey { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName IssuerName { get { throw null; } }
        public System.DateTime NotAfter { get { throw null; } }
        public System.DateTime NotBefore { get { throw null; } }
        public System.Security.Cryptography.AsymmetricAlgorithm PrivateKey { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.PublicKey PublicKey { get { throw null; } }
        public byte[] RawData { get { throw null; } }
        public string SerialNumber { get { throw null; } }
        public System.Security.Cryptography.Oid SignatureAlgorithm { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName SubjectName { get { throw null; } }
        public string Thumbprint { get { throw null; } }
        public int Version { get { throw null; } }
        public static System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(byte[] rawData) { throw null; }
        public static System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(string fileName) { throw null; }
        public string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer) { throw null; }
        public override void Import(byte[] rawData) { }
        [System.CLSCompliantAttribute(false)]
        public override void Import(byte[] rawData, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        public override void Import(byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        public override void Import(string fileName) { }
        [System.CLSCompliantAttribute(false)]
        public override void Import(string fileName, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        public override void Import(string fileName, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        public override void Reset() { }
        public override string ToString() { throw null; }
        public override string ToString(bool verbose) { throw null; }
        public bool Verify() { throw null; }
    }
    public partial class X509Certificate2Collection : System.Security.Cryptography.X509Certificates.X509CertificateCollection
    {
        public X509Certificate2Collection() { }
        public X509Certificate2Collection(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public X509Certificate2Collection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
        public X509Certificate2Collection(System.Security.Cryptography.X509Certificates.X509Certificate2[] certificates) { }
        public new System.Security.Cryptography.X509Certificates.X509Certificate2 this[int index] { get { throw null; } set { } }
        public int Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
        public void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2[] certificates) { }
        public bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType contentType) { throw null; }
        public byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType contentType, string password) { throw null; }
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Find(System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue, bool validOnly) { throw null; }
        public new System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator GetEnumerator() { throw null; }
        public void Import(byte[] rawData) { }
        public void Import(byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        public void Import(string fileName) { }
        public void Import(string fileName, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
        public void Insert(int index, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public void Remove(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public void RemoveRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
        public void RemoveRange(System.Security.Cryptography.X509Certificates.X509Certificate2[] certificates) { }
    }
    public sealed partial class X509Certificate2Enumerator : System.Collections.IEnumerator
    {
        internal X509Certificate2Enumerator() { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
        bool System.Collections.IEnumerator.MoveNext() { throw null; }
        void System.Collections.IEnumerator.Reset() { }
    }
    public partial class X509CertificateCollection : System.Collections.CollectionBase
    {
        public X509CertificateCollection() { }
        public X509CertificateCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection value) { }
        public X509CertificateCollection(System.Security.Cryptography.X509Certificates.X509Certificate[] value) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate this[int index] { get { throw null; } set { } }
        public int Add(System.Security.Cryptography.X509Certificates.X509Certificate value) { throw null; }
        public void AddRange(System.Security.Cryptography.X509Certificates.X509CertificateCollection value) { }
        public void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate[] value) { }
        public bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate value) { throw null; }
        public void CopyTo(System.Security.Cryptography.X509Certificates.X509Certificate[] array, int index) { }
        public new System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { throw null; }
        public override int GetHashCode() { throw null; }
        public int IndexOf(System.Security.Cryptography.X509Certificates.X509Certificate value) { throw null; }
        public void Insert(int index, System.Security.Cryptography.X509Certificates.X509Certificate value) { }
        public void Remove(System.Security.Cryptography.X509Certificates.X509Certificate value) { }
        public partial class X509CertificateEnumerator : System.Collections.IEnumerator
        {
            public X509CertificateEnumerator(System.Security.Cryptography.X509Certificates.X509CertificateCollection mappings) { }
            public System.Security.Cryptography.X509Certificates.X509Certificate Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public bool MoveNext() { throw null; }
            public void Reset() { }
            bool System.Collections.IEnumerator.MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
        }
    }
    public partial class X509Chain : System.IDisposable
    {
        public X509Chain() { }
        public X509Chain(bool useMachineContext) { }
        public X509Chain(System.IntPtr chainContext) { }
        public System.IntPtr ChainContext { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509ChainElementCollection ChainElements { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509ChainPolicy ChainPolicy { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509ChainStatus[] ChainStatus { get { throw null; } }
        public Microsoft.Win32.SafeHandles.SafeX509ChainHandle SafeHandle { get { throw null; } }
        public bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public static System.Security.Cryptography.X509Certificates.X509Chain Create() { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~X509Chain() { }
        public void Reset() { }
    }
    public partial class X509ChainElement
    {
        internal X509ChainElement() { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509ChainStatus[] ChainElementStatus { get { throw null; } }
        public string Information { get { throw null; } }
    }
    public sealed partial class X509ChainElementCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal X509ChainElementCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509ChainElement this[int index] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public void CopyTo(System.Security.Cryptography.X509Certificates.X509ChainElement[] array, int index) { }
        public System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class X509ChainElementEnumerator : System.Collections.IEnumerator
    {
        internal X509ChainElementEnumerator() { }
        public System.Security.Cryptography.X509Certificates.X509ChainElement Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    public sealed partial class X509ChainPolicy
    {
        public X509ChainPolicy() { }
        public System.Security.Cryptography.OidCollection ApplicationPolicy { get { throw null; } }
        public System.Security.Cryptography.OidCollection CertificatePolicy { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection ExtraStore { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509RevocationFlag RevocationFlag { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { throw null; } set { } }
        public System.TimeSpan UrlRetrievalTimeout { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509VerificationFlags VerificationFlags { get { throw null; } set { } }
        public System.DateTime VerificationTime { get { throw null; } set { } }
        public void Reset() { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct X509ChainStatus
    {
        private object _dummy;
        private int _dummyPrimitive;
        public System.Security.Cryptography.X509Certificates.X509ChainStatusFlags Status { get { throw null; } set { } }
        public string StatusInformation { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum X509ChainStatusFlags
    {
        NoError = 0,
        NotTimeValid = 1,
        NotTimeNested = 2,
        Revoked = 4,
        NotSignatureValid = 8,
        NotValidForUsage = 16,
        UntrustedRoot = 32,
        RevocationStatusUnknown = 64,
        Cyclic = 128,
        InvalidExtension = 256,
        InvalidPolicyConstraints = 512,
        InvalidBasicConstraints = 1024,
        InvalidNameConstraints = 2048,
        HasNotSupportedNameConstraint = 4096,
        HasNotDefinedNameConstraint = 8192,
        HasNotPermittedNameConstraint = 16384,
        HasExcludedNameConstraint = 32768,
        PartialChain = 65536,
        CtlNotTimeValid = 131072,
        CtlNotSignatureValid = 262144,
        CtlNotValidForUsage = 524288,
        HasWeakSignature = 1048576,
        OfflineRevocation = 16777216,
        NoIssuanceChainPolicy = 33554432,
        ExplicitDistrust = 67108864,
        HasNotSupportedCriticalExtension = 134217728,
    }
    public sealed partial class X509EnhancedKeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
    {
        public X509EnhancedKeyUsageExtension() { }
        public X509EnhancedKeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }
        public X509EnhancedKeyUsageExtension(System.Security.Cryptography.OidCollection enhancedKeyUsages, bool critical) { }
        public System.Security.Cryptography.OidCollection EnhancedKeyUsages { get { throw null; } }
        public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    }
    public partial class X509Extension : System.Security.Cryptography.AsnEncodedData
    {
        protected X509Extension() { }
        public X509Extension(System.Security.Cryptography.AsnEncodedData encodedExtension, bool critical) { }
        public X509Extension(System.Security.Cryptography.Oid oid, byte[] rawData, bool critical) { }
        public X509Extension(string oid, byte[] rawData, bool critical) { }
        public bool Critical { get { throw null; } set { } }
        public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    }
    public sealed partial class X509ExtensionCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public X509ExtensionCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Extension this[int index] { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Extension this[string oid] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public int Add(System.Security.Cryptography.X509Certificates.X509Extension extension) { throw null; }
        public void CopyTo(System.Security.Cryptography.X509Certificates.X509Extension[] array, int index) { }
        public System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class X509ExtensionEnumerator : System.Collections.IEnumerator
    {
        internal X509ExtensionEnumerator() { }
        public System.Security.Cryptography.X509Certificates.X509Extension Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    public enum X509FindType
    {
        FindByThumbprint = 0,
        FindBySubjectName = 1,
        FindBySubjectDistinguishedName = 2,
        FindByIssuerName = 3,
        FindByIssuerDistinguishedName = 4,
        FindBySerialNumber = 5,
        FindByTimeValid = 6,
        FindByTimeNotYetValid = 7,
        FindByTimeExpired = 8,
        FindByTemplateName = 9,
        FindByApplicationPolicy = 10,
        FindByCertificatePolicy = 11,
        FindByExtension = 12,
        FindByKeyUsage = 13,
        FindBySubjectKeyIdentifier = 14,
    }
    public enum X509IncludeOption
    {
        None = 0,
        ExcludeRoot = 1,
        EndCertOnly = 2,
        WholeChain = 3,
    }
    public sealed partial class X509KeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
    {
        public X509KeyUsageExtension() { }
        public X509KeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, bool critical) { }
        public X509KeyUsageExtension(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags keyUsages, bool critical) { }
        public System.Security.Cryptography.X509Certificates.X509KeyUsageFlags KeyUsages { get { throw null; } }
        public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    }
    [System.FlagsAttribute]
    public enum X509KeyUsageFlags
    {
        None = 0,
        EncipherOnly = 1,
        CrlSign = 2,
        KeyCertSign = 4,
        KeyAgreement = 8,
        DataEncipherment = 16,
        KeyEncipherment = 32,
        NonRepudiation = 64,
        DigitalSignature = 128,
        DecipherOnly = 32768,
    }
    public enum X509NameType
    {
        SimpleName = 0,
        EmailName = 1,
        UpnName = 2,
        DnsName = 3,
        DnsFromAlternativeName = 4,
        UrlName = 5,
    }
    public enum X509RevocationFlag
    {
        EndCertificateOnly = 0,
        EntireChain = 1,
        ExcludeRoot = 2,
    }
    public enum X509RevocationMode
    {
        NoCheck = 0,
        Online = 1,
        Offline = 2,
    }
    public abstract partial class X509SignatureGenerator
    {
        protected X509SignatureGenerator() { }
        public System.Security.Cryptography.X509Certificates.PublicKey PublicKey { get { throw null; } }
        protected abstract System.Security.Cryptography.X509Certificates.PublicKey BuildPublicKey();
        public static System.Security.Cryptography.X509Certificates.X509SignatureGenerator CreateForECDsa(System.Security.Cryptography.ECDsa key) { throw null; }
        public static System.Security.Cryptography.X509Certificates.X509SignatureGenerator CreateForRSA(System.Security.Cryptography.RSA key, System.Security.Cryptography.RSASignaturePadding signaturePadding) { throw null; }
        public abstract byte[] GetSignatureAlgorithmIdentifier(System.Security.Cryptography.HashAlgorithmName hashAlgorithm);
        public abstract byte[] SignData(byte[] data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm);
    }
    public sealed partial class X509Store : System.IDisposable
    {
        public X509Store() { }
        public X509Store(System.IntPtr storeHandle) { }
        public X509Store(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation) { }
        public X509Store(System.Security.Cryptography.X509Certificates.StoreName storeName) { }
        public X509Store(System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation) { }
        public X509Store(System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.OpenFlags openFlags) { }
        public X509Store(string storeName) { }
        public X509Store(string storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation) { }
        public X509Store(string storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.OpenFlags openFlags) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get { throw null; } }
        public bool IsOpen { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.StoreLocation Location { get { throw null; } }
        public string Name { get { throw null; } }
        public System.IntPtr StoreHandle { get { throw null; } }
        public void Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
        public void Close() { }
        public void Dispose() { }
        public void Open(System.Security.Cryptography.X509Certificates.OpenFlags flags) { }
        public void Remove(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public void RemoveRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
    }
    public sealed partial class X509SubjectKeyIdentifierExtension : System.Security.Cryptography.X509Certificates.X509Extension
    {
        public X509SubjectKeyIdentifierExtension() { }
        public X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical) { }
        public X509SubjectKeyIdentifierExtension(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }
        public X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, bool critical) { }
        public X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }
        public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical) { }
        public string SubjectKeyIdentifier { get { throw null; } }
        public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    }
    public enum X509SubjectKeyIdentifierHashAlgorithm
    {
        Sha1 = 0,
        ShortSha1 = 1,
        CapiSha1 = 2,
    }
    [System.FlagsAttribute]
    public enum X509VerificationFlags
    {
        NoFlag = 0,
        IgnoreNotTimeValid = 1,
        IgnoreCtlNotTimeValid = 2,
        IgnoreNotTimeNested = 4,
        IgnoreInvalidBasicConstraints = 8,
        AllowUnknownCertificateAuthority = 16,
        IgnoreWrongUsage = 32,
        IgnoreInvalidName = 64,
        IgnoreInvalidPolicy = 128,
        IgnoreEndRevocationUnknown = 256,
        IgnoreCtlSignerRevocationUnknown = 512,
        IgnoreCertificateAuthorityRevocationUnknown = 1024,
        IgnoreRootRevocationUnknown = 2048,
        AllFlags = 4095,
    }
}
namespace System.Security.Permissions
{
    public sealed partial class TypeDescriptorPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public TypeDescriptorPermission(System.Security.Permissions.PermissionState state) { }
        public TypeDescriptorPermission(System.Security.Permissions.TypeDescriptorPermissionFlags flag) { }
        public System.Security.Permissions.TypeDescriptorPermissionFlags Flags { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.FlagsAttribute]
    public enum TypeDescriptorPermissionFlags
    {
        NoFlags = 0,
        RestrictedRegistrationAccess = 1,
    }
}
namespace System.Text.RegularExpressions
{
    public partial class Capture
    {
        internal Capture() { }
        public int Index { get { throw null; } }
        public int Length { get { throw null; } }
        public string Value { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class CaptureCollection : System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Capture>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        internal CaptureCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Text.RegularExpressions.Capture this[int i] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        System.Text.RegularExpressions.Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.this[int index] { get { throw null; } set { } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public void CopyTo(System.Array array, int arrayIndex) { }
        public void CopyTo(System.Text.RegularExpressions.Capture[] array, int arrayIndex) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture item) { }
        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture item) { throw null; }
        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture item) { throw null; }
        System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator() { throw null; }
        int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture item) { throw null; }
        void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, System.Text.RegularExpressions.Capture item) { }
        void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index) { }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
    public partial class Group : System.Text.RegularExpressions.Capture
    {
        internal Group() { }
        public System.Text.RegularExpressions.CaptureCollection Captures { get { throw null; } }
        public string Name { get { throw null; } }
        public bool Success { get { throw null; } }
        public static System.Text.RegularExpressions.Group Synchronized(System.Text.RegularExpressions.Group inner) { throw null; }
    }
    public partial class GroupCollection : System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>, System.Collections.Generic.IList<System.Text.RegularExpressions.Group>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Group>, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Group>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        internal GroupCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Text.RegularExpressions.Group this[int groupnum] { get { throw null; } }
        public System.Text.RegularExpressions.Group this[string groupname] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        System.Text.RegularExpressions.Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.this[int index] { get { throw null; } set { } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public void CopyTo(System.Array array, int arrayIndex) { }
        public void CopyTo(System.Text.RegularExpressions.Group[] array, int arrayIndex) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(System.Text.RegularExpressions.Group item) { }
        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(System.Text.RegularExpressions.Group item) { throw null; }
        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(System.Text.RegularExpressions.Group item) { throw null; }
        System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { throw null; }
        int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(System.Text.RegularExpressions.Group item) { throw null; }
        void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, System.Text.RegularExpressions.Group item) { }
        void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
    public partial class Match : System.Text.RegularExpressions.Group
    {
        internal Match() { }
        public static System.Text.RegularExpressions.Match Empty { get { throw null; } }
        public virtual System.Text.RegularExpressions.GroupCollection Groups { get { throw null; } }
        public System.Text.RegularExpressions.Match NextMatch() { throw null; }
        public virtual string Result(string replacement) { throw null; }
        public static System.Text.RegularExpressions.Match Synchronized(System.Text.RegularExpressions.Match inner) { throw null; }
    }
    public partial class MatchCollection : System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>, System.Collections.Generic.IList<System.Text.RegularExpressions.Match>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Match>, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Match>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        internal MatchCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public virtual System.Text.RegularExpressions.Match this[int i] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        System.Text.RegularExpressions.Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.this[int index] { get { throw null; } set { } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public void CopyTo(System.Array array, int arrayIndex) { }
        public void CopyTo(System.Text.RegularExpressions.Match[] array, int arrayIndex) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(System.Text.RegularExpressions.Match item) { }
        void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match item) { throw null; }
        bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(System.Text.RegularExpressions.Match item) { throw null; }
        System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { throw null; }
        int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match item) { throw null; }
        void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, System.Text.RegularExpressions.Match item) { }
        void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
    public delegate string MatchEvaluator(System.Text.RegularExpressions.Match match);
    public partial class Regex : System.Runtime.Serialization.ISerializable
    {
        protected internal System.Collections.Hashtable capnames;
        protected internal System.Collections.Hashtable caps;
        protected internal int capsize;
        protected internal string[] capslist;
        protected internal System.Text.RegularExpressions.RegexRunnerFactory factory;
        public static readonly System.TimeSpan InfiniteMatchTimeout;
        protected internal System.TimeSpan internalMatchTimeout;
        protected internal string pattern;
        protected internal System.Text.RegularExpressions.RegexOptions roptions;
        protected Regex() { }
        protected Regex(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public Regex(string pattern) { }
        public Regex(string pattern, System.Text.RegularExpressions.RegexOptions options) { }
        public Regex(string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { }
        public static int CacheSize { get { throw null; } set { } }
        [System.CLSCompliantAttribute(false)]
        protected System.Collections.IDictionary CapNames { get { throw null; } set { } }
        [System.CLSCompliantAttribute(false)]
        protected System.Collections.IDictionary Caps { get { throw null; } set { } }
        public System.TimeSpan MatchTimeout { get { throw null; } }
        public System.Text.RegularExpressions.RegexOptions Options { get { throw null; } }
        public bool RightToLeft { get { throw null; } }
        public static string Escape(string str) { throw null; }
        public string[] GetGroupNames() { throw null; }
        public int[] GetGroupNumbers() { throw null; }
        public string GroupNameFromNumber(int i) { throw null; }
        public int GroupNumberFromName(string name) { throw null; }
        protected void InitializeReferences() { }
        public bool IsMatch(string input) { throw null; }
        public bool IsMatch(string input, int startat) { throw null; }
        public static bool IsMatch(string input, string pattern) { throw null; }
        public static bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) { throw null; }
        public static bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { throw null; }
        public System.Text.RegularExpressions.Match Match(string input) { throw null; }
        public System.Text.RegularExpressions.Match Match(string input, int startat) { throw null; }
        public System.Text.RegularExpressions.Match Match(string input, int beginning, int length) { throw null; }
        public static System.Text.RegularExpressions.Match Match(string input, string pattern) { throw null; }
        public static System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) { throw null; }
        public static System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { throw null; }
        public System.Text.RegularExpressions.MatchCollection Matches(string input) { throw null; }
        public System.Text.RegularExpressions.MatchCollection Matches(string input, int startat) { throw null; }
        public static System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern) { throw null; }
        public static System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) { throw null; }
        public static System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { throw null; }
        public string Replace(string input, string replacement) { throw null; }
        public string Replace(string input, string replacement, int count) { throw null; }
        public string Replace(string input, string replacement, int count, int startat) { throw null; }
        public static string Replace(string input, string pattern, string replacement) { throw null; }
        public static string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options) { throw null; }
        public static string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { throw null; }
        public static string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator) { throw null; }
        public static string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options) { throw null; }
        public static string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { throw null; }
        public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator) { throw null; }
        public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count) { throw null; }
        public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count, int startat) { throw null; }
        public string[] Split(string input) { throw null; }
        public string[] Split(string input, int count) { throw null; }
        public string[] Split(string input, int count, int startat) { throw null; }
        public static string[] Split(string input, string pattern) { throw null; }
        public static string[] Split(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) { throw null; }
        public static string[] Split(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
        public static string Unescape(string str) { throw null; }
        protected bool UseOptionC() { throw null; }
        protected internal bool UseOptionR() { throw null; }
        protected internal static void ValidateMatchTimeout(System.TimeSpan matchTimeout) { }
    }
    public partial class RegexCompilationInfo
    {
        public RegexCompilationInfo(string pattern, System.Text.RegularExpressions.RegexOptions options, string name, string fullnamespace, bool ispublic) { }
        public RegexCompilationInfo(string pattern, System.Text.RegularExpressions.RegexOptions options, string name, string fullnamespace, bool ispublic, System.TimeSpan matchTimeout) { }
        public bool IsPublic { get { throw null; } set { } }
        public System.TimeSpan MatchTimeout { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public System.Text.RegularExpressions.RegexOptions Options { get { throw null; } set { } }
        public string Pattern { get { throw null; } set { } }
    }
    public partial class RegexMatchTimeoutException : System.TimeoutException, System.Runtime.Serialization.ISerializable
    {
        public RegexMatchTimeoutException() { }
        protected RegexMatchTimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public RegexMatchTimeoutException(string message) { }
        public RegexMatchTimeoutException(string message, System.Exception inner) { }
        public RegexMatchTimeoutException(string regexInput, string regexPattern, System.TimeSpan matchTimeout) { }
        public string Input { get { throw null; } }
        public System.TimeSpan MatchTimeout { get { throw null; } }
        public string Pattern { get { throw null; } }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.FlagsAttribute]
    public enum RegexOptions
    {
        None = 0,
        IgnoreCase = 1,
        Multiline = 2,
        ExplicitCapture = 4,
        Compiled = 8,
        Singleline = 16,
        IgnorePatternWhitespace = 32,
        RightToLeft = 64,
        ECMAScript = 256,
        CultureInvariant = 512,
    }
    public abstract partial class RegexRunner
    {
        protected internal int[] runcrawl;
        protected internal int runcrawlpos;
        protected internal System.Text.RegularExpressions.Match runmatch;
        protected internal System.Text.RegularExpressions.Regex runregex;
        protected internal int[] runstack;
        protected internal int runstackpos;
        protected internal string runtext;
        protected internal int runtextbeg;
        protected internal int runtextend;
        protected internal int runtextpos;
        protected internal int runtextstart;
        protected internal int[] runtrack;
        protected internal int runtrackcount;
        protected internal int runtrackpos;
        protected internal RegexRunner() { }
        protected void Capture(int capnum, int start, int end) { }
        protected static bool CharInClass(char ch, string charClass) { throw null; }
        protected static bool CharInSet(char ch, string @set, string category) { throw null; }
        protected void CheckTimeout() { }
        protected void Crawl(int i) { }
        protected int Crawlpos() { throw null; }
        protected void DoubleCrawl() { }
        protected void DoubleStack() { }
        protected void DoubleTrack() { }
        protected void EnsureStorage() { }
        protected abstract bool FindFirstChar();
        protected abstract void Go();
        protected abstract void InitTrackCount();
        protected bool IsBoundary(int index, int startpos, int endpos) { throw null; }
        protected bool IsECMABoundary(int index, int startpos, int endpos) { throw null; }
        protected bool IsMatched(int cap) { throw null; }
        protected int MatchIndex(int cap) { throw null; }
        protected int MatchLength(int cap) { throw null; }
        protected int Popcrawl() { throw null; }
        protected internal System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick) { throw null; }
        protected internal System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, System.TimeSpan timeout) { throw null; }
        protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }
        protected void Uncapture() { }
    }
    public abstract partial class RegexRunnerFactory
    {
        protected RegexRunnerFactory() { }
        protected internal abstract System.Text.RegularExpressions.RegexRunner CreateInstance();
    }
}
namespace System.Threading
{
    public partial class Barrier : System.IDisposable
    {
        public Barrier(int participantCount) { }
        public Barrier(int participantCount, System.Action<System.Threading.Barrier> postPhaseAction) { }
        public long CurrentPhaseNumber { get { throw null; } }
        public int ParticipantCount { get { throw null; } }
        public int ParticipantsRemaining { get { throw null; } }
        public long AddParticipant() { throw null; }
        public long AddParticipants(int participantCount) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void RemoveParticipant() { }
        public void RemoveParticipants(int participantCount) { }
        public void SignalAndWait() { }
        public bool SignalAndWait(int millisecondsTimeout) { throw null; }
        public bool SignalAndWait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void SignalAndWait(System.Threading.CancellationToken cancellationToken) { }
        public bool SignalAndWait(System.TimeSpan timeout) { throw null; }
        public bool SignalAndWait(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class BarrierPostPhaseException : System.Exception
    {
        public BarrierPostPhaseException() { }
        public BarrierPostPhaseException(System.Exception innerException) { }
        protected BarrierPostPhaseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public BarrierPostPhaseException(string message) { }
        public BarrierPostPhaseException(string message, System.Exception innerException) { }
    }
    public sealed partial class Semaphore : System.Threading.WaitHandle
    {
        public Semaphore(int initialCount, int maximumCount) { }
        public Semaphore(int initialCount, int maximumCount, string name) { }
        public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew) { throw null; }
        public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew, System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { throw null; }
        public System.Security.AccessControl.SemaphoreSecurity GetAccessControl() { throw null; }
        public static System.Threading.Semaphore OpenExisting(string name) { throw null; }
        public static System.Threading.Semaphore OpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights) { throw null; }
        [System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute]
        public int Release() { throw null; }
        public int Release(int releaseCount) { throw null; }
        public void SetAccessControl(System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { }
        public static bool TryOpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights, out System.Threading.Semaphore result) { throw null; }
        public static bool TryOpenExisting(string name, out System.Threading.Semaphore result) { throw null; }
    }
    public partial class ThreadExceptionEventArgs : System.EventArgs
    {
        public ThreadExceptionEventArgs(System.Exception t) { }
        public System.Exception Exception { get { throw null; } }
    }
    public delegate void ThreadExceptionEventHandler(object sender, System.Threading.ThreadExceptionEventArgs e);
}
namespace System.Timers
{
    public partial class ElapsedEventArgs : System.EventArgs
    {
        internal ElapsedEventArgs() { }
        public System.DateTime SignalTime { get { throw null; } }
    }
    public delegate void ElapsedEventHandler(object sender, System.Timers.ElapsedEventArgs e);
    [System.ComponentModel.DefaultEventAttribute("Elapsed")]
    [System.ComponentModel.DefaultPropertyAttribute("Interval")]
    public partial class Timer : System.ComponentModel.Component, System.ComponentModel.ISupportInitialize
    {
        public Timer() { }
        public Timer(double interval) { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Timers.TimersDescriptionAttribute("Indicates whether the timer will be restarted when it is enabled.")]
        public bool AutoReset { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Timers.TimersDescriptionAttribute("Indicates whether the timer is enabled to fire events at a defined interval.")]
        public bool Enabled { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(100)]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        [System.Timers.TimersDescriptionAttribute("The number of milliseconds between timer events.")]
        public double Interval { get { throw null; } set { } }
        public override System.ComponentModel.ISite Site { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Timers.TimersDescriptionAttribute("The object used to marshal the event handler calls issued when an interval has elapsed.")]
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.Timers.TimersDescriptionAttribute("Occurs when the Interval has elapsed.")]
        public event System.Timers.ElapsedEventHandler Elapsed { add { } remove { } }
        public void BeginInit() { }
        public void Close() { }
        protected override void Dispose(bool disposing) { }
        public void EndInit() { }
        public void Start() { }
        public void Stop() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public partial class TimersDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        public TimersDescriptionAttribute(string description) { }
        public override string Description { get { throw null; } }
    }
}
namespace System.Windows.Input
{
    public partial interface ICommand
    {
        event System.EventHandler CanExecuteChanged;
        bool CanExecute(object parameter);
        void Execute(object parameter);
    }
}
namespace System.Windows.Markup
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Enum | System.AttributeTargets.Interface | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Struct, AllowMultiple=false, Inherited=true)]
    public sealed partial class ValueSerializerAttribute : System.Attribute
    {
        public ValueSerializerAttribute(string valueSerializerTypeName) { }
        public ValueSerializerAttribute(System.Type valueSerializerType) { }
        public System.Type ValueSerializerType { get { throw null; } }
        public string ValueSerializerTypeName { get { throw null; } }
    }
}
